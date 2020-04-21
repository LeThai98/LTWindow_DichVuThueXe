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
    public partial class fListBike : Form
    {
        public fListBike()
        {
            InitializeComponent();
        }
        Bike bike = new Bike();
        private void fListBike_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamSocVaGuiXeDataSet1.Bike' table. You can move, or remove it, as needed.
            this.bikeTableAdapter1.Fill(this.chamSocVaGuiXeDataSet1.Bike);
            // TODO: This line of code loads data into the 'chamSocVaGuiXeDataSet.Bike' table. You can move, or remove it, as needed.
            this.bikeTableAdapter.Fill(this.chamSocVaGuiXeDataSet.Bike);
            // TODO: This line of code loads data into the 'myDBDataSet.Student' table. You can move, or remove it, as needed.
            this.bikeTableAdapter.Fill(this.chamSocVaGuiXeDataSet.Bike);
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Bike");
            dataGridViewBikeList.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            dataGridViewBikeList.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019,co gian de pic dep, dang tim auto-size
            dataGridViewBikeList.DataSource = bike.getBike(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewBikeList.Columns[1];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewBikeList.Columns[2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewBikeList.AllowUserToAddRows = false;

            // gán giá trị
            

        }

        private void dataGridViewBikeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id - fname - lnane - bd - gdr - phn - adrs - pic
            fUpdateDeleteBike fm = new fUpdateDeleteBike();
            
            fm.textBoxID.Text = dataGridViewBikeList.CurrentRow.Cells[0].Value.ToString();
            fm.textBoxNameOwner.Text = dataGridViewBikeList.CurrentRow.Cells[3].Value.ToString();
            fm.textBoxAddress.Text = dataGridViewBikeList.CurrentRow.Cells[4].Value.ToString();
            fm.textBoxPhone.Text = dataGridViewBikeList.CurrentRow.Cells[5].Value.ToString();
            fm.numericUpDownTimeRent.Value = (int)dataGridViewBikeList.CurrentRow.Cells[6].Value;
            fm.dateTimePicker1.Value = (DateTime)dataGridViewBikeList.CurrentRow.Cells[7].Value;
            if ((dataGridViewBikeList.CurrentRow.Cells[8].Value.ToString().Trim() == "Hour"))
            {
                fm.radioButtonHour.Checked = true;
            }
            else if((dataGridViewBikeList.CurrentRow.Cells[8].Value.ToString().Trim() == "Week"))
            {
                fm.radioButtonWeek.Checked = true;
            }
            else
            {
                fm.radioButtonMonth.Checked = true;
            }
            
            // code xu ly hinh anh up len, version 01, chay OK, tim hieu them de code nhe hon
            byte[] pic1;
            pic1 = (byte[])dataGridViewBikeList.CurrentRow.Cells[1].Value;
            MemoryStream picture1 = new MemoryStream(pic1);
            fm.pictureBoxBike.Image = Image.FromStream(picture1);

            byte[] pic2;
            pic2 = (byte[])dataGridViewBikeList.CurrentRow.Cells[2].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            fm.pictureBoxBike.Image = Image.FromStream(picture2);

            this.Show();
            fm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Bike");

            dataGridViewBikeList.ReadOnly = true;// nap lai du lieu len datagrid view

            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            dataGridViewBikeList.RowTemplate.Height = 80;

            dataGridViewBikeList.DataSource = bike.getBike(command);

            picCol1 = (DataGridViewImageColumn)dataGridViewBikeList.Columns[1];

            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewBikeList.AllowUserToAddRows = false; // dong nay tren stackoverflow

            picCol2 = (DataGridViewImageColumn)dataGridViewBikeList.Columns[2];

            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewBikeList.AllowUserToAddRows = false; // dong nay tren stackoverflow
        }
    }
}
