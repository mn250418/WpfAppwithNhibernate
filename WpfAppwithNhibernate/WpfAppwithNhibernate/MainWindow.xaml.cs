using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppwithNhibernate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICustomer _customerDAO;
        string response = string.Empty;
        public MainWindow()
        {
            _customerDAO = App.container.Resolve<ICustomer>();
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GetAllCustomers();
        }
        private void GetAllCustomers()
        {
            try
            {
                var contactDetails = _customerDAO.GetCustomers();
                dataGridContact.ItemsSource = contactDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            CustomerInfo cInfo = SetContactInfo();
            try
            {
                if (btnAdd.Content.ToString() == "Add")
                {
                    response = _customerDAO.AddCustomer(cInfo);
                    MessageBox.Show(response);
                    GetAllCustomers();
                }
                else
                {
                    response = _customerDAO.UpdateCustomer(cInfo); //update the new data 
                    MessageBox.Show(response);
                    GetAllCustomers(); //display the updated record 
                }
                ClearControlsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            ClearControlsData();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var selectedContact = dataGridContact.SelectedItem;
            BindContactInfo(selectedContact as CustomerInfo);
            btnAdd.Content = "Submit";
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if ((MessageBox.Show("Are you sure you want to delete?", "Please confirm.", MessageBoxButton.YesNo) == MessageBoxResult.Yes))
            {
                try
                {
                    var selectedContact = dataGridContact.SelectedItem as CustomerInfo;
                    response = _customerDAO.DeleteCustomer(selectedContact); //delete the record 
                    MessageBox.Show(response);
                    GetAllCustomers(); //display the new collection 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private CustomerInfo SetContactInfo()
        {
            CustomerInfo customerInfo = new CustomerInfo();
            customerInfo.FirstName = txtFirstName.Text;
            customerInfo.LastName = txtLastName.Text;
            customerInfo.Address = txtAddress.Text;
            customerInfo.MobileNumber = Convert.ToInt32(txtMobileNumber.Text);
            if (btnAdd.Content.ToString() == "Submit")
            {
                customerInfo.CustomerId = Convert.ToInt32(txtCustomerId.Text);
            }
            return customerInfo;
        }
        private void BindContactInfo(CustomerInfo customerInfo)
        {

            txtFirstName.Text = customerInfo.FirstName;
            txtLastName.Text = customerInfo.LastName;
            txtAddress.Text = customerInfo.Address;
            txtMobileNumber.Text = Convert.ToString(customerInfo.MobileNumber);
            txtCustomerId.Text = Convert.ToString(customerInfo.CustomerId);
        }
        private void ClearControlsData()
        {
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtMobileNumber.Text = "";
            txtAddress.Text = string.Empty;
            txtCustomerId.Text = string.Empty;
            btnAdd.Content = "Add";
        }
    }
}
