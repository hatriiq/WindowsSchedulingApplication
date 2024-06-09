using C969Scheduling;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C969Scheduling
{
    public partial class CustomerRecords : Form
    {
        private Form Main;

        public CustomerRecords(Form main)
        {
            InitializeComponent();
            customerDataGridView.DataSource = MainHubForm.ListOfCustomers;
            Main = main;
        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Address2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ZipTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearCustomerInputs();
            BindCityComboBox();
            ToggleActiveInputs(true);
        }

        private void ClearCustomerInputs()
        {
            customerDataGridView.ClearSelection();
            ClearInputs();
        }

        private void BindCityComboBox()
        {
            var cityNameDictionary = MainHubForm.CityDictionary.ToDictionary(dict => dict.Key, dict => dict.Value.CityName);

            cityComboBox.DataSource = new BindingSource(cityNameDictionary, null);
            cityComboBox.DisplayMember = "Value";
            cityComboBox.ValueMember = "Key";
            cityComboBox.SelectedItem = null;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateCustomerInput();

                string customerName = nameTextBox.Text;
                string address1 = addressTextBox.Text;
                string address2 = address2TextBox.Text;
                string postalCode = zipTextBox.Text;
                string phone = phoneTextBox.Text;
                int cityID = Convert.ToInt32(cityComboBox.SelectedValue);
                int customerID;

                if (string.IsNullOrEmpty(idTextBox.Text))
                {
                    int addressID = DB.AddAddress(address1, address2, cityID, postalCode, phone, MainHubForm.LoggedInUser.UserName);
                    customerID = DB.AddCustomer(customerName, addressID, MainHubForm.LoggedInUser.UserName);
                    idTextBox.Text = customerID.ToString();
                }
                else
                {
                    customerID = Convert.ToInt32(idTextBox.Text);
                    Customer currentCustomer = MainHubForm.ListOfCustomers.SingleOrDefault(c => c.CustomerId == customerID);
                    if (currentCustomer != null)
                    {
                        Address address = MainHubForm.AddressDictionary[currentCustomer.AddressId];
                        DB.UpdateCustomer(currentCustomer, customerName, MainHubForm.LoggedInUser.UserName);
                        DB.UpdateAddress(address, address1, address2, cityID, postalCode, phone, MainHubForm.LoggedInUser.UserName);
                    }
                }

                ToggleActiveInputs(false);
                var selectedRow = customerDataGridView.Rows.Cast<DataGridViewRow>().SingleOrDefault(row => Convert.ToInt32(row.Cells[0].Value) == customerID);
                if (selectedRow != null)
                {
                    selectedRow.Selected = true;
                }
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ValidateCustomerInput()
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                throw new ApplicationException("Please enter a name.");
            }
            if (string.IsNullOrEmpty(addressTextBox.Text))
            {
                throw new ApplicationException("Please enter an address.");
            }
            if (cityComboBox.SelectedItem == null)
            {
                throw new ApplicationException("Please select a city.");
            }
            if (string.IsNullOrEmpty(zipTextBox.Text))
            {
                throw new ApplicationException("Please enter a zip code.");
            }
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                throw new ApplicationException("Please enter a phone number.");
            }
        }


        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateSelectedCustomer();

                ToggleActiveInputs(true);
                UpdateCityComboBox();
            }
            catch (ApplicationException error)
            {
                ShowErrorMessage("Instructions", error.Message);
            }
            catch (Exception err)
            {
                ShowErrorMessage("Error", err.Message);
            }
        }

        private void ValidateSelectedCustomer()
        {
            if (customerDataGridView.SelectedRows.Count < 1)
            {
                throw new ApplicationException("Please select a customer to update.");
            }
        }

        private void UpdateCityComboBox()
        {
            var selectedCountryKey = Convert.ToInt32(countryComboBox.SelectedValue);
            var newCityNameDictionary = MainHubForm.CityDictionary
                .Where(dict => dict.Value.CountryId == selectedCountryKey)
                .ToDictionary(dict => dict.Key, dict => dict.Value.CityName);

            cityComboBox.DataSource = new BindingSource(newCityNameDictionary, null);
            cityComboBox.DisplayMember = "Value";
            cityComboBox.ValueMember = "Key";
        }

        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK);
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearInputsAndToggleActive(false);
        }

        private void ClearInputsAndToggleActive(bool active)
        {
            customerDataGridView.ClearSelection();
            ClearInputs();
            ToggleActiveInputs(active);
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (customerDataGridView.SelectedRows.Count < 1)
                {
                    throw new ApplicationException("Please select a customer to delete.");
                }

                DialogResult confirmDelete = MessageBox.Show("Please confirm that you want to delete the selected customer.", "Application Instruction", MessageBoxButtons.YesNo);

                if (confirmDelete == DialogResult.Yes)
                {
                    var selectedRow = customerDataGridView.SelectedRows[0];
                    int selectedCustomerId = Convert.ToInt32(selectedRow.Cells[0].Value);

                    if (MainHubForm.ListOfAppointments.Any(appt => appt.CustomerId == selectedCustomerId))
                    {
                        throw new ApplicationException("You must delete all customer appointments before deleting customer.");
                    }

                    Customer selectedCustomer = MainHubForm.ListOfCustomers.Single(customer => customer.CustomerId == selectedCustomerId);
                    DB.DeleteCustomer(selectedCustomer);
                    ClearInputs();
                }
                else
                {
                    ClearInputsAndSelection();
                }
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void ClearInputsAndSelection()
        {
            customerDataGridView.ClearSelection();
            ClearInputs();
        }


        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerRecords_Load(object sender, EventArgs e)
        {
            customerRecordLabel.Text = "Customer Records";
            Dictionary<int, string> countryNameDictionary = MainHubForm.CountryDictionary.ToDictionary(dict => dict.Key, dict => dict.Value.CountryName);
            countryComboBox.DataSource = new BindingSource(countryNameDictionary, null);
            countryComboBox.DisplayMember = "Value";
            countryComboBox.ValueMember = "Key";
            countryComboBox.SelectedItem = null;
            // Using Lambda in Linq statement below to construct a new dictionary that holds "string" as a value rather than the City object
            // The Lambda Expession is easier to read and faster
            Dictionary<int, string> cityNameDictionary = MainHubForm.CityDictionary.ToDictionary(dict => dict.Key, dict => dict.Value.CityName);
            cityComboBox.DataSource = new BindingSource(cityNameDictionary, null);
            cityComboBox.DisplayMember = "Value";
            cityComboBox.ValueMember = "Key";
            cityComboBox.SelectedItem = null;
        }

        private void CustomerRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main.Show();
        }

        private void CustomDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            var dataGridView = customerDataGridView;
            dataGridView.AutoResizeColumns();
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.MultiSelect = false;
            dataGridView.ClearSelection();
        }

        private void ClearInputs()
        {
            nameTextBox.Text = "";
            idTextBox.Text = "";
            addressTextBox.Text = "";
            address2TextBox.Text = "";
            zipTextBox.Text = "";
            phoneTextBox.Text = "";
            cityComboBox.Text = "";
            countryComboBox.Text = "";
        }


        private void ToggleActiveInputs(bool active)
        {
            nameTextBox.Enabled = active;
            addressTextBox.Enabled = active;
            address2TextBox.Enabled = active;
            countryComboBox.Enabled = active;
            cityComboBox.Enabled = active;
            zipTextBox.Enabled = active;
            phoneTextBox.Enabled = active;
            saveButton.Visible = active;
            cancelButton.Visible = active;
            addButton.Visible = !active;
            editButton.Visible = !active;
            deleteButton.Visible = !active;
            backButton.Visible = !active;
            customerDataGridView.Enabled = !active;
        }

        private void CustomDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CustomDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (customerDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = customerDataGridView.SelectedRows[0];
                if (selectedRow.Cells[0].Value != null && int.TryParse(selectedRow.Cells[0].Value.ToString(), out int selectedCustomerId))
                {
                    Customer selectedCustomer = MainHubForm.ListOfCustomers.FirstOrDefault(customer => customer.CustomerId == selectedCustomerId);
                    if (selectedCustomer != null)
                    {
                        int selectedAddressId = Convert.ToInt32(selectedCustomer.AddressId);
                        if (MainHubForm.AddressDictionary.TryGetValue(selectedAddressId, out var selectedAddress))
                        {
                            int selectedCityId = selectedAddress.CityId;
                            if (MainHubForm.CityDictionary.TryGetValue(selectedCityId, out var selectedCity))
                            {
                                int selectedCountryId = selectedCity.CountryId;

                                nameTextBox.Text = selectedCustomer.CustomerName;
                                idTextBox.Text = selectedCustomer.CustomerId.ToString();
                                addressTextBox.Text = selectedAddress.AddressLine;
                                address2TextBox.Text = selectedAddress.AddressLine2;
                                zipTextBox.Text = selectedAddress.PostalCode;
                                phoneTextBox.Text = selectedAddress.Phone;
                                cityComboBox.Text = selectedCity.CityName;
                                countryComboBox.Text = MainHubForm.CountryDictionary.ContainsKey(selectedCountryId) ? MainHubForm.CountryDictionary[selectedCountryId].CountryName : "";
                            }
                        }
                    }
                }
            }
        }


        private void CityComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (countryComboBox.Text == "")
            {
                var selectedCityKey = cityComboBox.SelectedValue;
                int selectedCountryKey = MainHubForm.CityDictionary[Convert.ToInt32(selectedCityKey)].CountryId;
                countryComboBox.Text = MainHubForm.CountryDictionary[selectedCountryKey].CountryName;
            }
        }

        private void CountryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (countryComboBox.SelectedValue != null && int.TryParse(countryComboBox.SelectedValue.ToString(), out int selectedCountryKey))
            {
                var newCityNameDictionary = MainHubForm.CityDictionary
                    .Where(dict => dict.Value.CountryId == selectedCountryKey)
                    .ToDictionary(dict => dict.Key, dict => dict.Value.CityName);

                cityComboBox.DataSource = new BindingSource(newCityNameDictionary, null);
                cityComboBox.DisplayMember = "Value";
                cityComboBox.ValueMember = "Key";
                cityComboBox.SelectedItem = null;
            }
        }


        private void CountryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CityComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }


}
