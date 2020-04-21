using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocVaGuiXe
{
    public partial class fSlotOfPark : Form
    {
        public fSlotOfPark()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            textBoxTotalBike.Text = "100";
           object RentBike= (object)bike.totalSlot();
            textBoxRentBike.Text = RentBike.ToString();
        }

        private void buttonMoto_Click(object sender, EventArgs e)
        {
            Moto bike = new Moto();
            textBoxTotalMoto.Text = "50";
            object RentMoto = (object)bike.totalSlot();
            textBoxRentMoto.Text = RentMoto.ToString();
        }

        private void buttonCar_Click(object sender, EventArgs e)
        {
            Car bike = new Car();
            textBoxTotalCar.Text = "30";
            object RentCar = (object)bike.totalSlot();
            textBoxRentCar.Text = RentCar.ToString();
        }
    }
}
