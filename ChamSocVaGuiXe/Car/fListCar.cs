using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocVaGuiXe
{
    public partial class fListCar : Form
    {
        public fListCar()
        {
            InitializeComponent();
        }

        Car car = new Car();

        private void fListCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamSocVaGuiXe_ListCar.Car' table. You can move, or remove it, as needed.
            this.carTableAdapter.Fill(this.chamSocVaGuiXe_ListCar.Car);
            // TODO: This line of code loads data into the 'chamSocVaGuiXe_ListMoto.Moto' table. You can move, or remove it, as needed.
           // this.motoTableAdapter.Fill(this.chamSocVaGuiXe_ListMoto.Moto);
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Car");
            dataGridViewCarList.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            dataGridViewCarList.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019,co gian de pic dep, dang tim auto-size
            dataGridViewCarList.DataSource = car.getCar(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewCarList.Columns[1];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewCarList.Columns[2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewCarList.AllowUserToAddRows = false;

        }

        private void dataGridViewCarList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //id - fname - lnane - bd - gdr - phn - adrs - pic
            fUpdateDeleteCar fm = new fUpdateDeleteCar();

            fm.textBoxID.Text = dataGridViewCarList.CurrentRow.Cells[0].Value.ToString();
            fm.textBoxNameOwner.Text = dataGridViewCarList.CurrentRow.Cells[3].Value.ToString();
            fm.textBoxAddress.Text = dataGridViewCarList.CurrentRow.Cells[4].Value.ToString();
            fm.textBoxPhone.Text = dataGridViewCarList.CurrentRow.Cells[5].Value.ToString();
            fm.numericUpDownTimeRent.Value = (int)dataGridViewCarList.CurrentRow.Cells[6].Value;
            fm.dateTimePicker1.Value = (DateTime)dataGridViewCarList.CurrentRow.Cells[7].Value;
            if ((dataGridViewCarList.CurrentRow.Cells[8].Value.ToString().Trim() == "Hour"))
            {
                fm.radioButtonHour.Checked = true;
            }
            else if ((dataGridViewCarList.CurrentRow.Cells[8].Value.ToString().Trim() == "Week"))
            {
                fm.radioButtonWeek.Checked = true;
            }
            else
            {
                fm.radioButtonMonth.Checked = true;
            }

            // code xu ly hinh anh up len, version 01, chay OK, tim hieu them de code nhe hon
            byte[] pic1;
            pic1 = (byte[])dataGridViewCarList.CurrentRow.Cells[1].Value;
            MemoryStream picture1 = new MemoryStream(pic1);
            fm.pictureBoxNumberPlate.Image = Image.FromStream(picture1);

            byte[] pic2;
            pic2 = (byte[])dataGridViewCarList.CurrentRow.Cells[2].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            fm.pictureBoxType.Image = Image.FromStream(picture2);

            this.Show();
            fm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Car");

            dataGridViewCarList.ReadOnly = true;// nap lai du lieu len datagrid view

            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            dataGridViewCarList.RowTemplate.Height = 80;

            dataGridViewCarList.DataSource = car.getCar(command);

            picCol1 = (DataGridViewImageColumn)dataGridViewCarList.Columns[1];

            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewCarList.AllowUserToAddRows = false; // dong nay tren stackoverflow

            picCol2 = (DataGridViewImageColumn)dataGridViewCarList.Columns[2];

            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewCarList.AllowUserToAddRows = false; // dong nay tren stackoverflow
        }
    }
}
