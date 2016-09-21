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

            // Adds choices for combobox
            cbRegister.Items.Add(new ComboboxItem() { Text = "<Select an option>", Value = 0 });
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

            // Checks if all necessary textboxes have been filled
            bool hasValue = true;
            for (int i = 0; i < pnlEnterInfo.Controls.Count; i++)
            {
                TextBox txt;
                if (pnlEnterInfo.Controls[i] is TextBox)
                {
                    txt = (TextBox)pnlEnterInfo.Controls[i];

                    bool skip = false;
                    
                    switch (item.Value)
                    {
                        // Skips unnecessary textboxes for Customer
                        case 1:
                            if (txt.Name == "txtTitle" || txt.Name == "txtSalary" || txt.Name == "txtCompany")
                            {
                                skip = true;
                            }
                            break;

                        // Skips unnecessary textboxes for Employee
                        case 2:
                            if (txt.Name == "txtCompany")
                            {
                                skip = true;
                            }
                            break;

                        // Skips unnecessary textboxes for Supplier
                        case 3:
                            if (txt.Name == "txtSalary" || txt.Name == "txtTitle")
                            {
                                skip = true;
                            }
                            break;
                        default:
                            break;
                    }

                    if (!skip)
                    {
                        if (txt.Text == string.Empty)
                        {
                            hasValue = false;
                            break;
                        }
                    }
                    
                }

            }

            // Alerts user if there are empty textboxes
            if (!hasValue)
            {
                MessageBox.Show("Textboxes are missing values", "Alert");
                return;
            }
            
            // Sets right case according to choosen comboboxitem
            switch (item.Value)
            {
                //  Adds a customer
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

                //  Adds an employee
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

                // Adds a upplier
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
            cbRegister.SelectedIndex = 0;
            CheckPeople();
            ClearText("enter");
        }
        // Forces user to enter numbers in textboxes "phonenumber" and "Salary"
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

        // Initialzes some "people"
        private Customer customer; 
        private Employee employee;
        private Supplier supplier;
       
        // Save button for edit panel
        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            ClearText("edit");
            Person person = (Person)lbPersonList.SelectedItem;

            // Saves info in the common textboxes
            person.FirstName = txtFirstNameEdit.Text;
            person.LastName = txtLastNameEdit.Text;
            person.PhoneNumber = txtPhoneNumberEdit.Text;

            // Checks which type person is
            switch (person.GetType().Name)
            {
                // Saves the info from the extra textboxes 
                case "Employee":
                    employee.Salary = txtSalaryEdit.Text;
                    employee.Title = txtTitleEdit.Text;
                    break;

                // Saves the info from the extra textboxes 
                case "Supplier":
                    supplier.Company = txtCompanyEdit.Text;
                    break;

                default:
                    MessageBox.Show("Choose an option", "Alert");
                    break;
            }

            CheckPeople();
        }
        // Forces user to enter numbers in textboxes "phonenumber" and "Salary"
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

        // Listbox holding all the people
        private void lbPersonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clears textboxes to avoid pre-filled textboxes
            ClearText("edit");
            pnlEditInfo.Visible = true;
            // Sets peron to the choosen listboxitem
            Person person = (Person)lbPersonList.SelectedItem;

            // Sets saved info into the common textboxes
            txtFirstNameEdit.Text = person.FirstName;
            txtLastNameEdit.Text = person.LastName;
            txtPhoneNumberEdit.Text = person.PhoneNumber;

            switch (person.GetType().Name)
            {
                // Sets info in to the right textbox
                case "Customer":
                    GetPersonType(4);
                    break;

                // Sets info in to the right textbox
                case "Employee":
                    GetPersonType(5);

                    Employee employee = (Employee)lbPersonList.SelectedItem;

                    txtSalaryEdit.Text = employee.Salary;
                    txtTitleEdit.Text = employee.Title;
                    break;

                // Sets info in to the right textbox
                case "Supplier":
                    GetPersonType(6);

                    Supplier supplier = (Supplier)lbPersonList.SelectedItem;

                    txtCompanyEdit.Text = supplier.Company;
                    break;

                default:
                    break;
            }
        }

        // Sets the proper textboxes to readable and opens panels
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

        //Updates listbox
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

        // Control for GUI
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

        // Clears text in textboxes
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

        // Count the number of people in respective gruops
        void CountPeople()
        {
            int number = lbPersonList.Items.Count;
            lblCountingPeople.Text = string.Format("You have registered {0} customer(s), {1} Employee(s) and {2} supplier(s).",
                customerCount, employeeCount, supplierCount);
        }
    }
}