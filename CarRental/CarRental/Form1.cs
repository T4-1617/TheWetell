using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CarRental
{
    public partial class CarRental : Form
    {
        System.Collections.ArrayList carList;

        public CarRental()
        {
            InitializeComponent();

            Visable(false);

            carList = new System.Collections.ArrayList();

            carList.Add(new Car() { Make = "Volvo" });
            carList.Add(new Car() { Make = "Opel" });
            carList.Add(new Car() { Make = "Ford" });
        }

        private void btnShowAvailableCars_Click(object sender, EventArgs e)
        {
            Visable(false);
            pnlAvailableCars.Visible = true;
            ShowAvailableCars();
        }

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            pnlThankYouBooking.Visible = true;

            Thread.Sleep(5000);
            Visable(false);
            pnlAvailableCars.Visible = true;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Visable(false);

            pnlAddCar.Visible = true;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            Visable(false);
            pnlRetunCar.Visible = true;

            ShowAvailableCars();
        }

        private void Visable(bool toggle)
        {
            switch (toggle)
            {
                case true:
                    toggle = true;
                    break;

                case false:
                    pnlAvailableCars.Visible = false;
                    pnlThankYouBooking.Visible = false;
                    pnlAddCar.Visible = false;
                    pnlRetunCar.Visible = false;
                    pnlReturnThanks.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void ShowAvailableCars()
        {
            listBoxAvailableCars.Items.Clear();
            foreach (var car in carList)
            {
                listBoxAvailableCars.Items.Add(car);
                listBoxAvailableCars.DisplayMember = "Make";

            }
        }

    }
}
