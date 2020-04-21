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
    public partial class fListMoto : Form
    {
        public fListMoto()
        {
            InitializeComponent();
        }
        Moto moto = new Moto();
        private void fListMoto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamSocVaGuiXe_ListMoto.Moto' table. You can move, or remove it, as needed.
            this.motoTableAdapter.Fill(this.chamSocVaGuiXe_ListMoto.Moto);
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Moto");
            dataGridViewMotoList.ReadOnly = true;
            // xu ly hinh anh, code co tham khao msdn
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            dataGridViewMotoList.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019,co gian de pic dep, dang tim auto-size
            dataGridViewMotoList.DataSource = moto.getMoto(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewMotoList.Columns[1];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewMotoList.Columns[2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewMotoList.AllowUserToAddRows = false;

        }

        private void dataGridViewMotoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id - fname - lnane - bd - gdr - phn - adrs - pic
            fUpdateDeleteMoto fm = new fUpdateDeleteMoto();

            fm.textBoxID.Text = dataGridViewMotoList.CurrentRow.Cells[0].Value.ToString();
            fm.textBoxNameOwner.Text = dataGridViewMotoList.CurrentRow.Cells[3].Value.ToString();
            fm.textBoxAddress.Text = dataGridViewMotoList.CurrentRow.Cells[4].Value.ToString();
            fm.textBoxPhone.Text = dataGridViewMotoList.CurrentRow.Cells[5].Value.ToString();
            fm.numericUpDownTimeRent.Value = (int)dataGridViewMotoList.CurrentRow.Cells[6].Value;
            fm.dateTimePicker1.Value = (DateTime)dataGridViewMotoList.CurrentRow.Cells[7].Value;
            if ((dataGridViewMotoList.CurrentRow.Cells[8].Value.ToString().Trim() == "Hour"))
            {
                fm.radioButtonHour.Checked = true;
            }
            else if ((dataGridViewMotoList.CurrentRow.Cells[8].Value.ToString().Trim() == "Week"))
            {
                fm.radioButtonWeek.Checked = true;
            }
            else
            {
                fm.radioButtonMonth.Checked = true;
            }

            // code xu ly hinh anh up len, version 01, chay OK, tim hieu them de code nhe hon
            byte[] pic1;
            pic1 = (byte[])dataGridViewMotoList.CurrentRow.Cells[1].Value;
            MemoryStream picture1 = new MemoryStream(pic1);
            fm.pictureBoxNumberPlate.Image = Image.FromStream(picture1);

            byte[] pic2;
            pic2 = (byte[])dataGridViewMotoList.CurrentRow.Cells[2].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            fm.pictureBoxOwner.Image = Image.FromStream(picture2);

            this.Show();
            fm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Moto");

            dataGridViewMotoList.ReadOnly = true;// nap lai du lieu len datagrid view

            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            dataGridViewMotoList.RowTemplate.Height = 80;

            dataGridViewMotoList.DataSource = moto.getMoto(command);

            picCol1 = (DataGridViewImageColumn)dataGridViewMotoList.Columns[1];

            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewMotoList.AllowUserToAddRows = false; // dong nay tren stackoverflow

            picCol2 = (DataGridViewImageColumn)dataGridViewMotoList.Columns[2];

            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewMotoList.AllowUserToAddRows = false; // dong nay tren stackoverflow
        }
    }
}
