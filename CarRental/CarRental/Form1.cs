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

        int countCars;

        public CarRental()
        {
            InitializeComponent();

            VisiblePanel(false);

            carList = new System.Collections.ArrayList();

            carList.Add(new Car()
            {
                Make = "Volvo",
                Model = "V70",
                Colour = "Red",
                Seats = "5",
                Milage = "1000",
                Hired = false
            });
            carList.Add(new Car()
            {
                Make = "Ford",
                Model = "Fiesta",
                Colour = "White",
                Seats = "5",
                Milage = "5000",
                Hired = false
            });
            carList.Add(new Car()
            {
                Make = "Seat",
                Model = "Leon",
                Colour = "Blue",
                Seats = "5",
                Milage = "10000",
                Hired = false
            });

            listBoxAvailableCars.Items.Clear();
            listBoxAvailableCars.Items.Clear();
            foreach (Car car in carList)
            {
                switch (car.Hired)
                {
                    case false:
                        listBoxAvailableCars.Items.Add(car);
                        listBoxAvailableCars.DisplayMember = "Make";
                        countCars += 1;
                        break;

                    case true:
                        listBoxReturnCars.Items.Add(car);
                        listBoxReturnCars.DisplayMember = "Make";
                        break;
                    default:
                        break;
                }
                CountCars();
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
            if (listBoxAvailableCars.SelectedIndex != -1)
            {
                HireCar(true);
                VisiblePanel(false);
                pnlThankYouBooking.Visible = true;
            }
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            VisiblePanel(false);
            pnlRetunCar.Visible = true;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (listBoxReturnCars.SelectedIndex != -1)
            {
                HireCar(false);
                VisiblePanel(false);
                pnlReturnThanks.Visible = true;
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            VisiblePanel(false);
            pnlAddCar.Visible = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Car newCar = new Car();

            newCar.Make = txtMake.Text;
            newCar.Model = txtModel.Text;
            newCar.Colour = txtColour.Text;
            newCar.Seats = txtSeats.Text;
            newCar.Milage = txtMilage.Text;
            newCar.Hired = false;

            carList.Add(newCar);
            CountCars();

            txtMake.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtColour.Text = string.Empty;
            txtSeats.Text = string.Empty;
            txtMilage.Text = string.Empty;
        }

        // Forcing the user to enter a number
        private void txtSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a number", "Alert");
            }
        }
        private void txtMilage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter a number", "Alert");
            }
        }

        void VisiblePanel(bool toggle)
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

        void HireCar(bool hired)
        {
            Car car;

            switch (hired)
            {
                case false:
                    car = (Car)listBoxReturnCars.SelectedItem;
                    listBoxReturnCars.Items.RemoveAt(listBoxReturnCars.SelectedIndex);
                    listBoxAvailableCars.Items.Add(car);
                    break;

                case true:
                    car = (Car)listBoxAvailableCars.SelectedItem;
                    listBoxAvailableCars.Items.RemoveAt(listBoxAvailableCars.SelectedIndex);
                    listBoxReturnCars.Items.Add(car);
                    break;
                default:
                    break;
            }
            CountCars();

        }

        void CountCars()
        {
            countCars = listBoxAvailableCars.Items.Count;
            lblCountCars.Text = string.Format("We have {0} cars available", countCars);
        }


    }
}
