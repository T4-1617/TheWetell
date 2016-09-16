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
            Car car = new Car();

            carList.Add(new Car() { Make = "Volvo" });
            carList.Add(new Car() { Make = "Opel" });
            carList.Add(new Car() { Make = "Ford" });
        }

        private void btnShowCars_Click(object sender, EventArgs e)
        {
            Visable(false);
            pnlAvailableCars.Visible = true;
            listBoxAvailableCars.Items.Add(carList);
        }

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            pnlThankYou.Visible = true;

            Thread.Sleep(5000);

            Visable(false);

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
                    pnlThankYou.Visible = false;
                    pnlAddCar.Visible = false;
                    pnlRetunCar.Visible = false;
                    pnlReturnThanks.Visible = false;
                    break;

                default:
                    break;
            }
        }

        private void ShowCars()
        {
            foreach (var car in carList)
            {
                listBoxAvailableCars.Items.Add(car.GetType().Name);
                listBoxAvailableCars.DisplayMember = "Make";
            }
        }

    }
}
