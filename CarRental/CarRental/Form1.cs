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

        // Counts number of cars
        int countCars;

        string firstName = string.Empty;
        string lastName = string.Empty;

        public CarRental()
        {
            InitializeComponent();

            // Sets all panels non-visible
            VisiblePanel(false);

            carList = new System.Collections.ArrayList();

            // Adds three "static" cars
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

            // Clears listBoxes before adding new cars to prevent duplicates
            listBoxAvailableCars.Items.Clear();
            listBoxAvailableCars.Items.Clear();

            // Adds cars in respective listBoxes
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

        // Show and hire cars
        private void btnShowAvailableCars_Click(object sender, EventArgs e)
        {
            // Sets all panel to non-visible and sets proper panel to visible
            VisiblePanel(false);
            pnlAvailableCars.Visible = true;
        }
        private void btnBookCar_Click(object sender, EventArgs e)
        {
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;

            if (listBoxAvailableCars.SelectedIndex != -1)
            {
                // Sets the car to hired
                HireCar(true);

                //Hides all "useless" panel and displays thank you panel
                VisiblePanel(false);
                pnlThankYouBooking.Visible = true;
            }

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        // Return car
        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            // Sets all panel to non-visible and sets proper panel to visible
            VisiblePanel(false);
            pnlRetunCar.Visible = true;
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (listBoxReturnCars.SelectedIndex != -1)
            {
                // Sets the car to available
                HireCar(false);
                //Hides all "useless" panel and displays thanks panel
                VisiblePanel(false);
                pnlReturnThanks.Visible = true;
            }
        }

        // Add car
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            // Sets all panel to non-visible and sets proper panel to visible
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

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {
            // Sets all panel to non-visible and sets proper panel to visible
            VisiblePanel(false);
            pnlShowCustomers.Visible = true;
        }

        // Toogle switch to hide and show panels
        void VisiblePanel(bool toggle)
        {
            switch (toggle)
            {
                //Turns "off" all panels
                case false:
                    pnlAvailableCars.Visible = false;
                    pnlThankYouBooking.Visible = false;
                    pnlAddCar.Visible = false;
                    pnlRetunCar.Visible = false;
                    pnlReturnThanks.Visible = false;
                    pnlShowCustomers.Visible = false;
                    break;

                default:
                    break;
            }
        }

        void HireCar(bool hired)
        {
            Car car;

            string fullName = string.Format("{0} {1}", firstName, lastName);
            string bookingInfo = string.Empty;

            switch (hired)
            {
                case false:
                    // Gets the selected car to "car"
                    car = (Car)listBoxReturnCars.SelectedItem;
                    // Removes chosen car from the list
                    listBoxReturnCars.Items.RemoveAt(listBoxReturnCars.SelectedIndex);
                    // Adds the car to non-hired list
                    listBoxAvailableCars.Items.Add(car);
                    listBoxCustomers.Items.Remove(bookingInfo);
                    break;

                case true:
                    // Gets the selected car to "car"
                    car = (Car)listBoxAvailableCars.SelectedItem;
                    // Removes chosen car from the list
                    listBoxAvailableCars.Items.RemoveAt(listBoxAvailableCars.SelectedIndex);
                    // Adds the car to hired list
                    listBoxReturnCars.Items.Add(car);

                    //bookingInfo = string.Format("{0} {1} hired a {2} {3}", firstName, lastName, car.Make, car.Model);
                    listBoxCustomers.Items.Add(bookingInfo = string.Format("{0} hired a {1} {2}", fullName, car.Make, car.Model));
                    break;
            }
            CountCars();

        }

        void CountCars()
        {
            // Retrieves number of cars in avaliable list
            countCars = listBoxAvailableCars.Items.Count;
            // Prints the label with updated car count
            lblCountCars.Text = string.Format("We have {0} cars available", countCars);
        }


    }
}
