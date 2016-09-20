using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class CRM : Form
    {
        public CRM()
        {
            InitializeComponent();

            pnlRegistration.Visible = true;
            pnlCustomerReg.Visible = true;

            txtFirstName.Visible = false;
            pnlEmployeeReg.Visible = false;
            pnlSupplierReg.Visible = false;
        }
    }
}
