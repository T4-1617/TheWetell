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

            cbRegister.Items.Add(new ComboboxItem() { Text = "Customer", Value = 1 });
            cbRegister.Items.Add(new ComboboxItem() { Text = "Employee", Value = 2 });
            cbRegister.Items.Add(new ComboboxItem() { Text = "Supplier", Value = 3 });
        }

        private void cbRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboboxItem item = (ComboboxItem)cbRegister.SelectedItem;
            GetPersonType(item.Value);
        }

        private void btnSaveReg_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            ClearText("enter");
        }

        void GetPersonType(int value)
        {
            // Used to set all textboxes to readonly when changing "input"
            GUI(false);

            // These textboxes are common and is used for everyone
            // Changes all "common" textboxes to readable
            pnlEnterInfo.Visible = true;

            txtFirstName.ReadOnly = false;
            txtFirstNameEdit.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtLastNameEdit.ReadOnly = false;
            txtPhoneNumber.ReadOnly = false;
            txtPhoneNumberEdit.ReadOnly = false;

            switch (value)
            {
                case 0:
                    GUI(false);
                    pnlEnterInfo.Visible = true;
                    break;
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

                    GetPersonType(0);
                    break;

                case "edit":
                    txtFirstNameEdit.Clear();
                    txtLastNameEdit.Clear();
                    txtPhoneNumberEdit.Clear();
                    txtSalaryEdit.Clear();
                    txtCompanyEdit.Clear();
                    txtTitleEdit.Clear();

                    GetPersonType(0);
                    break;
                default:
                    break;
            }
        }
    }
}