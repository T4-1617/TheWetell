using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCompany
{
    public partial class Cars : Form
    {

        public Cars()
        {
            InitializeComponent();

            panelInfo.Visible = false;

            // Sets all textboxes to non-writable
            editInfo(true);

            listBoxCars.DisplayMember = "make";

            // Sets a random registration number on each vehicle
            Random r = new Random();
            listBoxCars.Items.Add(new Car() { make = "Volvo", regNumber = r.Next(100,500) });
            listBoxCars.Items.Add(new Car() { make = "Ford", regNumber = r.Next(100, 500) });
            listBoxCars.Items.Add(new Car() { make = "Mercedes-Benz", regNumber = r.Next(100, 500) });
            listBoxCars.Items.Add(new Car() { make = "Renault", regNumber = r.Next(100, 500) });
            listBoxCars.Items.Add(new Car() { make = "Opel", regNumber = r.Next(100, 500) });

        }

        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car car = (Car)listBoxCars.SelectedItem;

            // Sets textboxes to car values
            txtMake.Text = car.make;
            txtModel.Text = car.model;
            txtRegNum.Text = car.regNumber.ToString();
            txtSeats.Text = car.seats;

            panelInfo.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Sets textboxes to writable
            editInfo(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Car car = (Car)listBoxCars.SelectedItem;

            // Lets user change the variable values
            car.model = txtModel.Text;
            car.seats = txtSeats.Text;

            editInfo(true);

            // Sleep used to make the program less rigid
            Thread.Sleep(200);
            panelInfo.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Car car = (Car)listBoxCars.SelectedItem;
            panelInfo.Visible = false;
        }

        // Method that sets text boxes to writable or not
        private void editInfo(bool edit)
        {
            switch (edit)
            {
                // Textboxes become non-writable
                case true:
                    txtMake.ReadOnly = true;
                    txtModel.ReadOnly = true;
                    txtRegNum.ReadOnly = true;
                    txtSeats.ReadOnly = true;
                    break;
                
                // Some textboxes become writable
                case false:
                    txtModel.ReadOnly = false;
                    txtSeats.ReadOnly = false;
                    break;
                default:
                    break;
            }
        }
    }
}
