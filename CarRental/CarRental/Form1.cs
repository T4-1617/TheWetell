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

            VisiblePanel(false);

            carList = new System.Collections.ArrayList();

            carList.Add(new Car() { Make = "Volvo" });
            carList.Add(new Car() { Make = "Opel" });
            carList.Add(new Car() { Make = "Ford" });

            listBoxAvailableCars.Items.Clear();
            listBoxAvailableCars.Items.Clear();
            foreach (Car car in carList)
            {
                switch (car.Hired)
                {
                    case false:
                        listBoxAvailableCars.Items.Add(car);
                        listBoxAvailableCars.DisplayMember = "Make";
                        break;

                    case true:
                        listBoxReturnCars.Items.Add(car);
                        listBoxReturnCars.DisplayMember = "Make";
                        break;
                    default:
                        break;
                }
            }

        }

        private void btnShowAvailableCars_Click(object sender, EventArgs e)
        {
            Car tempCar = new Car();

            VisiblePanel(false);
            pnlAvailableCars.Visible = true;
        }

        private void btnBookCar_Click(object sender, EventArgs e)
        {
            
        }

        private void listBoxAvailableCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car tempCar = new Car();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            VisiblePanel(false);
            pnlAddCar.Visible = true;
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            Car tempCar = new Car();

            VisiblePanel(false);
            pnlRetunCar.Visible = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Car tempCar = new Car();

            VisiblePanel(false);
            pnlReturnThanks.Visible = true;

        }

        private void VisiblePanel(bool toggle)
        {
            switch (toggle)
            {
                case false:
                    pnlAvailableCars.Visible = false;
                    pnlThankYouBooking.Visible = false;
                    pnlAddCar.Visible = false;
                    pnlRetunCar.Visible = false;
                    pnlReturnThanks.Visible = false;
                    break;

                default:
                    toggle = true;
                    break;
            }
        }

        private void HireCar(bool hired)
        {

        }
    }
}
