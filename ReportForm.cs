using C969Scheduling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace C969Scheduling
{
    public partial class ReportForm : Form
    {
        private Form Main;
        private List<User> ListOfUsers;

        public ReportForm(Form form)
        {
            InitializeComponent();
            Main = form;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ReportTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void NumberAptsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (numberAptsRadioButton.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("Number of appointment types by month report: (Every Month This Year)");
                text.AppendLine();
                DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime endOfYear = new DateTime(DateTime.Now.Year, 12, 31).AddDays(1).AddMilliseconds(-1);
                var groupedByMonthList = MainHubForm.ListOfAppointments
                    .OrderBy(appt => appt.Start)
                    .Where(appt => appt.Start >= startOfYear && appt.Start <= endOfYear)
                    .GroupBy(appt => appt.Start.ToString("MMMM yyyy"));

                foreach (var group in groupedByMonthList)
                {
                    text.AppendLine($"{group.Key}:");
                    var groupedByTypeList = group.GroupBy(appt => appt.Type);

                    foreach (var list in groupedByTypeList)
                    {
                        text.AppendLine($"\t{list.Key}: {list.Count()}");
                    }
                    text.AppendLine();
                }
                reportTextBox.Text = text.ToString();
            }
        }


        private void UserScheduleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (userScheduleRadioButton.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("User schedule report: (This Month)");
                text.AppendLine();

                DateTime beginningOfMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                DateTime endOfMonth = beginningOfMonth.AddMonths(1).AddMilliseconds(-1);

                var groupedByUserList = MainHubForm.ListOfAppointments
                    .Where(appt => appt.Start >= beginningOfMonth && appt.Start <= endOfMonth)
                    .GroupBy(appt => appt.UserId);

                foreach (var userList in groupedByUserList)
                {
                    text.AppendLine($"{ListOfUsers.First(user => user.UserID == userList.Key).UserName}'s Schedule:");
                    foreach (var appt in userList.OrderBy(appt => appt.Start))
                    {
                        text.AppendLine($"{MainHubForm.ListOfCustomers.First(customer => customer.CustomerId == appt.CustomerId).CustomerName} - \t{appt.Start:dddd M/d/yyyy h:mm tt}.");
                    }
                    text.AppendLine();
                }

                reportTextBox.Text = text.ToString();
            }
        }

        private void AptsTodayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (aptsTodayRadioButton.Checked)
            {
                var text = new StringBuilder();
                text.AppendLine("Customer appointments today:");
                text.AppendLine();

                var startOfToday = DateTime.Today;
                var endOfToday = startOfToday.AddDays(1).AddMilliseconds(-1);

                var listOfAppointmentsTodayGroupedByCustomerId = MainHubForm.ListOfAppointments
                    .Where(appt => appt.Start >= startOfToday && appt.Start <= endOfToday)
                    .GroupBy(appt => appt.CustomerId);

                foreach (var appt in listOfAppointmentsTodayGroupedByCustomerId)
                {
                    text.AppendLine($"Name:\t{MainHubForm.ListOfCustomers.First(customer => customer.CustomerId == appt.Key).CustomerName}");
                    text.AppendLine($"Phone:\t{MainHubForm.AddressDictionary[appt.Key].Phone}");
                    text.AppendLine();
                }

                reportTextBox.Text = text.ToString();
            }
        }

        private void ReportsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Show();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            ListOfUsers = DB.GetUsers();
        }
    }
}
