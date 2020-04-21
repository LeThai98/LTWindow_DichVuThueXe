using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocVaGuiXe
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageContractToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            if(bike.totalSlot()==70)
            {
                MessageBox.Show("The park is fulled for bike.Sorry verry much.","Full slot",MessageBoxButtons.OK);
            }
            else 
            {
                fAddBike frm = new fAddBike();
                frm.ShowDialog(this);
            }

            
        }

        private void editBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUpdateDeleteBike frm = new fUpdateDeleteBike();
            frm.ShowDialog(this);
        }

        private void listBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListBike frm = new fListBike();
            frm.ShowDialog(this);
        }

        private void manageBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManageBike frm = new fManageBike();
            frm.ShowDialog(this);
        }

        private void costToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCostFineBike frm= new fCostFineBike();
            frm.ShowDialog(this);
        }

        private void manageBankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSlotOfPark frm = new fSlotOfPark();
            frm.ShowDialog(this);
        }

        private void addMotobikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Moto moto = new Moto();
            if (moto.totalSlot() ==50)
            {
                MessageBox.Show("The park is fulled for bike.Sorry verry much.", "Full slot", MessageBoxButtons.OK);
            }
            else
            {
                fAddMoto frm = new fAddMoto();
                frm.ShowDialog(this);
            }
           
        }

        private void listMotoBikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListMoto frm = new fListMoto();
            frm.ShowDialog(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fUpdateDeleteMoto frm = new fUpdateDeleteMoto();
            frm.ShowDialog(this);
        }

        private void manageMotobikeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManageMoto frm = new fManageMoto();
            frm.ShowDialog(this);
        }

        private void costFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCostFineMoto fr = new fCostFineMoto();
            fr.ShowDialog(this);
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            if (car.totalSlot() == 30)
            {
                MessageBox.Show("The park is fulled for bike.Sorry verry much.", "Full slot", MessageBoxButtons.OK);
            }
            else
            {
                fAddCar frm = new fAddCar();
                frm.ShowDialog(this);
            }
        }

        private void editRemoveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            fUpdateDeleteCar fr = new fUpdateDeleteCar();
            fr.ShowDialog(this);
        }

        private void listCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fListCar fr = new fListCar();
            fr.ShowDialog(this);
        }

        private void manageCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fManageCar fr = new fManageCar();
            fr.ShowDialog(this);
        }

        private void costFineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fCostFineCar fr = new fCostFineCar();
            fr.ShowDialog(this);
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fRavenue frm = new fRavenue();
            frm.ShowDialog(this);
        }
    }
}
