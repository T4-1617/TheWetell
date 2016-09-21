using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace CRM
{
    public partial class CRM : Form
    {

        System.Collections.ArrayList peopleList;
        Random r = new Random();

        int employeeID = 1;

        int customerCount = 0;
        int employeeCount = 0;
        int supplierCount = 0;

        public CRM()
        {
            InitializeComponent();
            GUI(false);

            peopleList = new System.Collections.ArrayList();

            cbRegister.Items.Add(new ComboboxItem() { Text = "Customer", Value = 1 });
            cbRegister.Items.Add(new ComboboxItem() { Text = "Employee", Value = 2 });
            cbRegister.Items.Add(new ComboboxItem() { Text = "Supplier", Value = 3 });

            CheckPeople();
            CountPeople();
        }

        private void cbRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)cbRegister.SelectedItem;
            GetPersonType(item.Value);
        }

        // Save button for regestration panel
        private void btnSaveReg_Click(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)cbRegister.SelectedItem;

            switch (item.Value)
            {
                case 1:
                    peopleList.Add(new Customer()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        CustomerID = r.Next(0, 500)
                    });

                    customerCount++;
                    break;

                case 2:
                    peopleList.Add(new Employee(employeeID)
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Salary = txtSalary.Text,
                        Title = txtTitle.Text,
                    });
                    employeeID++;

                    employeeCount++;
                    break;

                case 3:
                    peopleList.Add(new Supplier()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        PhoneNumber = txtPhoneNumber.Text,
                        Company = txtCompany.Text
                    });

                    supplierCount++;
                    break;

                default:
                    break;
            }
            CheckPeople();
            ClearText("enter");
        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a phone number:", "Alert");
            }
        }
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a number", "Alert");
            }
        }

        // Save button for edit panel
        private Customer customer; 
        private Employee employee;
        private Supplier supplier;
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            ClearText("edit");
            Person person = (Person)lbPersonList.SelectedItem;

            person.FirstName = txtFirstNameEdit.Text;
            person.LastName = txtLastNameEdit.Text;
            person.PhoneNumber = txtPhoneNumberEdit.Text;

            switch (person.GetType().Name)
            {
                case "Employee":
                    employee.Salary = txtSalaryEdit.Text;
                    employee.Title = txtTitleEdit.Text;
                    break;

                case "Supplier":
                    supplier.Company = txtCompanyEdit.Text;
                    break;

                default:
                    break;
            }

            CheckPeople();
        }
        private void txtPhoneNumberEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a number", "Alert");
            }
        }
        private void txtSalaryEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a number", "Alert");
            }
        }

        // Cancel buttons clear textboxes in respective panles
        private void btnCancelReg_Click(object sender, EventArgs e)
        {

            ClearText("enter");
        }
        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            ClearText("edit");
        }

        private void lbPersonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearText("edit");
            pnlEditInfo.Visible = true;
            Person person = (Person)lbPersonList.SelectedItem;

            txtFirstNameEdit.Text = person.FirstName;
            txtLastNameEdit.Text = person.LastName;
            txtPhoneNumberEdit.Text = person.PhoneNumber;

            switch (person.GetType().Name)
            {
                case "Customer":
                    GetPersonType(4);
                    
                    break;

                case "Employee":
                    GetPersonType(5);

                    Employee employee = (Employee)lbPersonList.SelectedItem;

                    txtSalaryEdit.Text = employee.Salary;
                    txtTitleEdit.Text = employee.Title;
                    break;

                case "Supplier":
                    GetPersonType(6);

                    Supplier supplier = (Supplier)lbPersonList.SelectedItem;

                    txtCompanyEdit.Text = supplier.Company;
                    break;

                default:
                    break;
            }
        }

        void GetPersonType(int value)
        {
            // Used to set all textboxes to readonly when changing "input"
            GUI(false);

            // These textboxes are common and is used for everyone
            // Changes all "common" textboxes to readable

            txtFirstName.ReadOnly = false;
            txtFirstNameEdit.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtLastNameEdit.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtPhoneNumberEdit.ReadOnly = false;
            if (value <= 3)
            {
                switch (value)
                {
                    // Case when choosing "Customer"
                    case 1:
                        pnlEnterInfo.Visible = true;
                        break;

                    // Case when choosing "Employee"
                    case 2:
                        pnlEnterInfo.Visible = true;

                        txtTitle.ReadOnly = false;
                        txtSalary.ReadOnly = false;
                        break;

                    //Case when choosing "Supplier" 
                    case 3:
                        pnlEnterInfo.Visible = true;

                        txtCompany.ReadOnly = false;
                        break;
                    default:
                        break;
                }
            }

            else
            {
                switch (value)
                {
                    case 4:
                        pnlEditInfo.Visible = true;
                        break;

                    case 5:
                        pnlEditInfo.Visible = true;

                        txtTitleEdit.ReadOnly = false;
                        txtSalaryEdit.ReadOnly = false;
                        break;

                    case 6:
                        pnlEditInfo.Visible = true;

                        txtCompanyEdit.ReadOnly = false;
                        break;

                    default:
                        break;
                }
            }
        }

        void CheckPeople()
        {

            lbPersonList.Items.Clear();
            foreach (Person person in peopleList)
            {
                if (person is Customer)
                {
                    lbPersonList.Items.Add(person);
                }
            }

            foreach (Person person in peopleList)
            {
                if (person is Employee)
                {
                    lbPersonList.Items.Add(person);
                }
            }

            foreach (Person person in peopleList)
            {
                if (person is Supplier)
                {
                    lbPersonList.Items.Add(person);
                }
            }
            CountPeople();
        }

        void GUI(bool visible)
        {
            // Check if bool is empty and terminate

            pnlEnterInfo.Visible = visible;
            pnlEditInfo.Visible = visible;

            // Sets all textboxes to read only

            txtFirstName.ReadOnly = !visible;
            txtLastName.ReadOnly = !visible;
            txtPhoneNumber.ReadOnly = !visible;
            txtSalary.ReadOnly = !visible;
            txtCompany.ReadOnly = !visible;
            txtTitle.ReadOnly = !visible;

            txtFirstNameEdit.ReadOnly = !visible;
            txtLastNameEdit.ReadOnly = !visible;
            txtPhoneNumberEdit.ReadOnly = !visible;
            txtSalaryEdit.ReadOnly = !visible;
            txtCompanyEdit.ReadOnly = !visible;
            txtTitleEdit.ReadOnly = !visible;
        }

        void ClearText(string clear)
        {
            switch (clear)
            {
                case "enter":
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtPhoneNumber.Clear();
                    txtSalary.Clear();
                    txtCompany.Clear();
                    txtTitle.Clear();

                    break;

                case "edit":
                    txtFirstNameEdit.Clear();
                    txtLastNameEdit.Clear();
                    txtPhoneNumberEdit.Clear();
                    txtSalaryEdit.Clear();
                    txtCompanyEdit.Clear();
                    txtTitleEdit.Clear();

                    break;
                default:
                    break;
            }
        }

        void CountPeople()
        {
            int number = lbPersonList.Items.Count;
            lblCountingPeople.Text = string.Format("You have registered {0} customer(s), {1} Employee(s) and {2} supplier(s).",
                customerCount, employeeCount, supplierCount);
        }
    }
}