using Car.Controllers;
using Car.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car.Views
{
    public partial class CarView : Form
    {
        CarController carController = new CarController();

        public CarView()
        {
            InitializeComponent();
        }

        private void CarView_Load(object sender, EventArgs e)
        {

            dgvCars.DataSource = carController.GetCars();

        }
        private void RefreshTable()
        {
            dgvCars.DataSource = carController.GetCars();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CarTable carTable = new CarTable();
            carTable.Brand = txtBrand.Text;
            carTable.Model = txtModel.Text;
            carTable.ProductionYear = ProductionYearPick.Value;
            carController.CreateCar(carTable);
            RefreshTable();
        }
    }
}
