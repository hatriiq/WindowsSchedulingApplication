using C969Scheduling;
using System;
using System.Linq;
using System.Windows.Forms;

namespace C969Scheduling
{
    public partial class AptAddUpdateForm : Form
    {
        private AptForm PreviousForm;
        private int SelectedAppointmentID = -1;

        public AptAddUpdateForm(AptForm prevForm, int appointmentId = -1)
        {
            InitializeComponent();
            PreviousForm = prevForm;
            SelectedAppointmentID = appointmentId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                TimeSpan businessStart = new TimeSpan(9, 0, 0);
                TimeSpan businessEnd = new TimeSpan(17, 0, 0);
                int selectedCustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
                string selectedType = typeComboBox.SelectedValue.ToString();
                DateTime selectedStart = startDateTimePicker.Value;
                DateTime selectedEnd = endDateTimePicker.Value;
                bool overlapping = false;

                foreach (var appt in MainHubForm.ListOfAppointments)
                {
                    if (selectedStart >= appt.Start && selectedStart < appt.End ||
                        selectedEnd > appt.Start && selectedEnd <= appt.End)
                    {
                        overlapping = true;
                        break;
                    }
                }

                if (selectedCustomerId < 1)
                    throw new ApplicationException("Select a customer.");

                if (selectedStart > selectedEnd)
                    throw new ApplicationException("Start time must be before end time.");

                if (selectedStart.TimeOfDay < businessStart || selectedStart.TimeOfDay > businessEnd ||
                    selectedEnd.TimeOfDay < businessStart || selectedEnd.TimeOfDay > businessEnd)
                    throw new ApplicationException("Please select a time within business hours, 9 am - 5 pm.");

                if (overlapping)
                    throw new ApplicationException("You can not double appointments.");

                if (SelectedAppointmentID >= 0)
                {
                    Apt appointment = MainHubForm.ListOfAppointments.FirstOrDefault(appt => appt.AppointmentId == SelectedAppointmentID);
                    if (appointment != null)
                        DB.UpdateAppointment(appointment, selectedCustomerId, selectedType, selectedStart, selectedEnd);
                }
                else
                {
                    DB.AddAppointment(selectedCustomerId, selectedType, selectedStart, selectedEnd);
                }
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select an appointment by type.", "Instructions", MessageBoxButtons.OK);
            }
            catch (ApplicationException err)
            {
                MessageBox.Show(err.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AptAddUpdateForm_Load(object sender, EventArgs e)
        {
            var customerDictionary = MainHubForm.ListOfCustomers.ToDictionary(list => list.CustomerId, list => list.CustomerName);
            customerComboBox.DataSource = new BindingSource(customerDictionary, null);
            customerComboBox.DisplayMember = "Value";
            customerComboBox.ValueMember = "Key";
            customerComboBox.SelectedItem = null;

            typeComboBox.DataSource = new[] { "Coaching", "Presentation", "Interview", "Consultation" };
            typeComboBox.SelectedItem = null;

            if (SelectedAppointmentID >= 0)
            {
                AddAptLabel.Text = "Update Appointment";
                Apt appointment = MainHubForm.ListOfAppointments.FirstOrDefault(appt => appt.AppointmentId == SelectedAppointmentID);
                if (appointment != null)
                {
                    idTextBox.Text = appointment.AppointmentId.ToString();
                    customerComboBox.Text = customerDictionary[appointment.CustomerId];
                    typeComboBox.Text = appointment.Type;
                    startDateTimePicker.Value = appointment.Start;
                    endDateTimePicker.Value = appointment.End;
                }
            }
            else
            {
                DateTime now = DateTime.Now;
                startDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 8, 0, 0);
                endDateTimePicker.Value = new DateTime(now.Year, now.Month, now.Day, 17, 0, 0);
            }
        }

        private void AptAddUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm?.UpdateSelection();
            PreviousForm?.Show();
        }

        private void customerComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void typeComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}