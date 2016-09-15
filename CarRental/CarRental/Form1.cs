using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class CarRental : Form
    {
        public CarRental()
        {
            InitializeComponent();
            pnlAvailableCars.Visible = false;
            pnlThankYou.Visible = false;

            pnlAddCar.Visible = false;

            pnlRetunCar.Visible = false;
            pnlReturnThanks.Visible = false;

        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            pnlAvailableCars.Visible = true;
        }
    }
}
