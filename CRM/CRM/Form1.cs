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

        public CRM()
        {
            InitializeComponent();
            GUI(false);

            peopleList = new System.Collections.ArrayList();
            cbRegister.Focus();

            ComboboxItem customer = new ComboboxItem() { Text = "Customer", Value = 1 };
            ComboboxItem employee = new ComboboxItem() { Text = "Employee", Value = 2 };
            ComboboxItem supplier = new ComboboxItem() { Text = "Supplier", Value = 3 };

        }

        void GetPersonType(int value)
        {
            // These textboxes are common and is used for everyone
            // Changes all "common" textboxes to readable
            txtFirstName.ReadOnly = false;
            txtFirstNameEdit.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtLastNameEdit.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtPhoneNumberEdit.ReadOnly = false;

            switch (value)
            {
                // Case when choosing "Employee"
                case 2:
                    txtTitle.ReadOnly = false;
                    txtTitleEdit.ReadOnly = false;
                    txtSalary.ReadOnly = false;
                    txtSalaryEdit.ReadOnly = false;
                    break;

                //Case when choosing "Supplier" 
                case 3:
                    txtCompany.ReadOnly = false;
                    txtCompanyEdit.ReadOnly = false;
                    break;

                default:
                    break;
            }
        }

        void GUI(bool visible)
        {
            // Check if bool is empty and terminate

            pnlEnterInfo.Visible = visible;
            pnlEditInfo.Visible = visible;

            // Sets all textboxes to read only

            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtPhoneNumber.ReadOnly = true;
            txtSalary.ReadOnly = true;
            txtCompany.ReadOnly = true;
            txtTitle.ReadOnly = true;

            txtFirstNameEdit.ReadOnly = true;
            txtLastNameEdit.ReadOnly = true;
            txtPhoneNumberEdit.ReadOnly = true;
            txtSalaryEdit.ReadOnly = true;
            txtCompanyEdit.ReadOnly = true;
            txtTitleEdit.ReadOnly = true; 
        }
    }
}
