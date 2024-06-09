using C969Scheduling;
using System;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace C969Scheduling
{
    public partial class AptForm : Form
    {
        private Form Main;
        private DateTime SelectedDate;

        public AptForm(Form main)
        {
            InitializeComponent();
            appointmentLabel.Text = $"{MainHubForm.LoggedInUser.UserName}'s appointments";
            Main = main;
            SelectedDate = DateTime.Now;
            datesRadioButton.Checked = true;
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            DisplayThisMonth();
            PopulateComboBoxAppointmentType();
        }

        private void PopulateComboBoxAppointmentType()
        {
            appointmentTypeComboBox.DataSource = new[] { "Coaching", "Presentation", "Interview", "Consultation" };
            appointmentTypeComboBox.SelectedItem = null;
        }

        private void DisplayThisMonth()
        {
            dateTimePickerStartDate.Value = FindBeginningOfMonth(DateTime.Now);
            dateTimePickerEndDate.Value = FindEndOfMonth(DateTime.Now);
            appointmentDataGridView.DataSource = GetAppointmentsInTimePeriod(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
        }
        public void UpdateSelection()
        {

        }

        private void AppointmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Show();
        }

        private void FormatDataGridView()
        {
            var dataGridView = appointmentDataGridView;
            dataGridView.AutoResizeColumns();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.ClearSelection();
        }

        private void AppointmentDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FormatDataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            OpenAddUpdateForm();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (appointmentDataGridView.SelectedRows.Count < 1)
                    throw new ApplicationException("Please select an appointment.");

                int selectedAppointmentId = Convert.ToInt32(appointmentDataGridView.SelectedRows[0].Cells[0].Value);
                OpenAddUpdateForm(selectedAppointmentId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
            Main.Show();
        }

        private DateTime FindBeginningOfWeek(DateTime date) => date.AddDays(-((int)date.DayOfWeek - (int)Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek)).Date;

        private DateTime FindEndOfWeek(DateTime date) => FindBeginningOfWeek(date).AddDays(7).AddMilliseconds(-1);

        private DateTime FindBeginningOfMonth(DateTime date) => new DateTime(date.Year, date.Month, 1);

        private DateTime FindEndOfMonth(DateTime date) => FindBeginningOfMonth(date).AddMonths(1).AddMilliseconds(-1);

        private BindingList<Apt> GetAppointmentsInTimePeriod(DateTime beginTime, DateTime endTime) =>
            new BindingList<Apt>(MainHubForm.ListOfAppointments.Where(appt => appt.Start >= beginTime && appt.End <= endTime).ToList());

        private BindingList<Apt> GetAppointmentsByCustomerId(int id) =>
            new BindingList<Apt>(MainHubForm.ListOfAppointments.Where(appt => appt.CustomerId == id).ToList());

        private BindingList<Apt> GetAppointmentsByAppointmentType(string type) =>
            new BindingList<Apt>(MainHubForm.ListOfAppointments.Where(appt => appt.Type == type).ToList());

        private void UpdateViewWithMonthlySelected() =>
            appointmentDataGridView.DataSource = GetAppointmentsInTimePeriod(FindBeginningOfMonth(SelectedDate), FindEndOfMonth(SelectedDate));

        private void UpdateViewWithWeeklySelected() =>
            appointmentDataGridView.DataSource = GetAppointmentsInTimePeriod(FindBeginningOfWeek(SelectedDate), FindEndOfWeek(SelectedDate));

        private void UpdateViewWithSearchedId(int id) =>
            appointmentDataGridView.DataSource = GetAppointmentsByCustomerId(id);

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (customerIDradioButton.Checked)
                UpdateViewOnCustomerID();
            else if (appointmentTypeRadioButton.Checked)
                UpdateViewOnAppointmentType();
            else if (datesRadioButton.Checked)
                UpdateViewOnDate();
        }

        private void UpdateViewOnCustomerID()
        {
            int customerId = 0;
            if (int.TryParse(customerIDtextbox.Text, out customerId) && customerId > 0)
                appointmentDataGridView.DataSource = GetAppointmentsByCustomerId(customerId);
            else
                MessageBox.Show("Please enter a number over 0.");
        }

        private void UpdateViewOnAppointmentType()
        {
            string type = appointmentTypeComboBox.Text;
            if (!string.IsNullOrEmpty(type))
                appointmentDataGridView.DataSource = GetAppointmentsByAppointmentType(type);
            else
                MessageBox.Show("Please select the type of appointment.");
        }

        private void UpdateViewOnDate()
        {
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value.AddMilliseconds(1);

            if (startDate > endDate)
                MessageBox.Show($"The end date: {endDate} is before the\nthe start date: {startDate}");
            else
                appointmentDataGridView.DataSource = GetAppointmentsInTimePeriod(startDate, endDate);
        }

        private void CustomerIDRadioButton_CheckedChanged(object sender, EventArgs e) =>
            ToggleControlsVisibility(true, false, false);

        private void AppointmentTypeRadioButton_CheckedChanged(object sender, EventArgs e) =>
            ToggleControlsVisibility(false, true, false);

        private void DatesRadioButton_CheckedChanged(object sender, EventArgs e) =>
            ToggleControlsVisibility(false, false, true);

        private void ToggleControlsVisibility(bool customerIdVisible, bool appointmentTypeVisible, bool datesVisible)
        {
            customerIdLabel.Visible = customerIdVisible;
            appointmentTypeLabel.Visible = appointmentTypeVisible;
            customerIDtextbox.Visible = customerIdVisible;
            appointmentTypeComboBox.Visible = appointmentTypeVisible;
            startDateLabel.Visible = datesVisible;
            endDateLabel.Visible = datesVisible;
            dateTimePickerStartDate.Visible = datesVisible;
            dateTimePickerEndDate.Visible = datesVisible;
        }

        private void OpenAddUpdateForm(int selectedAppointmentId = -1)
        {
            var addForm = new AptAddUpdateForm(this, selectedAppointmentId);
            addForm.Show();
            appointmentDataGridView.ClearSelection();
            Hide();
        }

        private void appointmentTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
