using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace C969Scheduling
{
    public partial class MainHubForm : Form
    {
        public static User LoggedInUser;
        public static BindingList<Customer> ListOfCustomers = new BindingList<Customer>();
        public static BindingList<Apt> ListOfAppointments = new BindingList<Apt>();
        public static Dictionary<int, Address> AddressDictionary = new Dictionary<int, Address>();
        public static Dictionary<int, City> CityDictionary = new Dictionary<int, City>();
        public static Dictionary<int, Country> CountryDictionary = new Dictionary<int, Country>();

        public MainHubForm(User user)
        {
            InitializeComponent();
            LoggedInUser = user;
        }

        private void MainHubForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DB.GetCustomers();
            DB.GetAddresses();
            DB.GetCities();
            DB.GetCountries();
            DB.GetAppointments();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            ShowForm(new CustomerRecords(this));
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            ShowForm(new AptForm(this));
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            ShowForm(new ReportForm(this));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowForm(Form form)
        {
            form.Show();
            this.Hide();
        }

        private void MainHubForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainHubForm_Shown(object sender, EventArgs e)
        {
            NotifyAppointments();
        }

        private void NotifyAppointments()
        {
            var upcomingAppointment = ListOfAppointments.FirstOrDefault(appt =>
                appt.Start > DateTime.Now && appt.Start <= DateTime.Now.AddMinutes(15));

            if (upcomingAppointment != null)
            {
                var customerName = ListOfCustomers.FirstOrDefault(cust => cust.CustomerId == upcomingAppointment.CustomerId)?.CustomerName;
                if (!string.IsNullOrEmpty(customerName))
                {
                    MessageBox.Show($"An appointment is scheduled with {customerName} at {upcomingAppointment.Start:hh:mm tt}.", "Appointment soon", MessageBoxButtons.OK);
                }
            }
        }
    }
}
