using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChamSocVaGuiXe
{
    public partial class fManageBike : Form
    {
        public fManageBike()
        {
            InitializeComponent();
        }
        Bike bike = new Bike();
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        public void fillGrid(SqlCommand command)
        {

            dataGridView1.ReadOnly = true;

            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            dataGridView1.RowTemplate.Height = 80;

            dataGridView1.DataSource = bike.getBike(command);

            picCol1 = (DataGridViewImageColumn)dataGridView1.Columns[1];

            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridView1.Columns[2];

            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridView1.AllowUserToAddRows = false;

            //// TODO: This line of code loads data into the 'chamSocVaGuiXeDataSet1.Bike' table. You can move, or remove it, as needed.
            //this.bikeTableAdapter.Fill(this.chamSocVaGuiXeDataSet2.Bike);
            //// TODO: This line of code loads data into the 'chamSocVaGuiXeDataSet.Bike' table. You can move, or remove it, as needed.
            //this.bikeTableAdapter.Fill(this.chamSocVaGuiXeDataSet2.Bike);
            //// TODO: This line of code loads data into the 'myDBDataSet.Student' table. You can move, or remove it, as needed.
            //this.bikeTableAdapter.Fill(this.chamSocVaGuiXeDataSet2.Bike);
            //SqlCommand command = new SqlCommand("SELECT * FROM dbo.Bike");
            //dataGridView1.ReadOnly = true;
            //// xu ly hinh anh, code co tham khao msdn
            //DataGridViewImageColumn picCol1 = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            //DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            //dataGridView1.RowTemplate.Height = 80; // dong nay tham khao tren MSDN ngay 10/03/2019,co gian de pic dep, dang tim auto-size
            //dataGridView1.DataSource = bike.getBike(command);
            //picCol1 = (DataGridViewImageColumn)dataGridView1.Columns[1];
            //picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //picCol2 = (DataGridViewImageColumn)dataGridView1.Columns[2];
            //picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //dataGridView1.AllowUserToAddRows = false;

            // Dem sinh vien
            labelTotalBike.Text = ("Total Bike: " + dataGridView1.Rows.Count);
        }

        private void fManageBike_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chamSocVaGuiXe_ManageMoto.Moto' table. You can move, or remove it, as needed.
            //this.chamSocVaGuiXe_ManageMoto.Fill(this.chamSocVaGuiXe_ManageMoto.Moto);
            // TODO: This line of code loads data into the 'chamSocVaGuiXeDataSet2.Bike' table. You can move, or remove it, as needed.
            // this.bikeTableAdapter.Fill(this.chamSocVaGuiXeDataSet2.Bike);
            //fillGrid();
            fillGrid(new SqlCommand("SELECT * FROM Bike"));
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bike WHERE CONCAT(Id,Name,Address,Phone,Type) LIKE'%" + textBoxSearch.Text + "%'");
            fillGrid(command);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[7].Value;
            numericUpDownTimeRent.Value = (int)dataGridView1.CurrentRow.Cells[6].Value;
            //  type rent
            if ((dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Hour"))
            {
                radioButtonHour.Checked = true;
            }
            else if ((dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Week"))
            {
                radioButtonWeek.Checked = true;
            }
            else if ((dataGridView1.CurrentRow.Cells[8].Value.ToString() == "Day"))
            {
                radioButtonDay.Checked = true;
            }
            else
            {
                radioButtonMonth.Checked = true;
            }

           

            // image
            byte[] pic1;
            pic1 = (byte[])dataGridView1.CurrentRow.Cells[1].Value;
            MemoryStream picture1 = new MemoryStream(pic1);
            pictureBoxBike.Image = Image.FromStream(picture1);

            byte[] pic2;
            pic2 = (byte[])dataGridView1.CurrentRow.Cells[2].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            pictureBoxOwner.Image = Image.FromStream(picture1);
        }

        private void buttonUploadBike_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxBike.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonUploadOwner_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxOwner.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonDownloadBike_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Bike_" + textBoxID.Text);
            if ((pictureBoxBike.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxBike.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonDownloadOwner_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("Owner_" + textBoxID.Text);
            if ((pictureBoxBike.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxBike.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            int id = Convert.ToInt32(textBoxID.Text);

            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string phone = textBoxPhone.Text;
            int time = Convert.ToInt32(numericUpDownTimeRent.Value);
            DateTime date = dateTimePicker1.Value;

            string type = "Hour";
            if (radioButtonMonth.Checked)
            {
                type = "Month";
            }
            if (radioButtonWeek.Checked)
            {
                type = "Week";
            }

            MemoryStream pictureBike = new MemoryStream();
            MemoryStream pictureOwner = new MemoryStream();

            int born_year = dateTimePicker1.Value.Year;
            int present_year = DateTime.Now.Year;
            //if ((present_year - born_year < 10) || (present_year - born_year) > 100)
            //{
            //    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            //}
            if (verif())
            {
                pictureBoxBike.Image.Save(pictureBike, pictureBoxBike.Image.RawFormat);
                pictureBoxOwner.Image.Save(pictureOwner, pictureBoxOwner.Image.RawFormat);
                if (bike.InsertBike(id, pictureBike, pictureOwner, name, address, phone, time, date, type))
                {
                    MessageBox.Show("New Verhicle Added", "Add Verhicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Errol", "Add Verhicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Verhicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "")
                || (textBoxName.Text.Trim() == "")
                || (textBoxAddress.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                || (pictureBoxBike.Image == null)
                || (pictureBoxOwner.Image == null)
                )
            {
                return false;
            }
            else
                return true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string name = textBoxName.Text;
            string address = textBoxAddress.Text;
            string phone = textBoxPhone.Text;
            int timeRent = (int)numericUpDownTimeRent.Value;
            DateTime dateRent = dateTimePicker1.Value;

            string type = "Hour";

            if (radioButtonWeek.Checked)
            {
                type = "Week";
            }
            else
            {
                type = "Month";
            }


            MemoryStream pic1 = new MemoryStream();
            MemoryStream pic2 = new MemoryStream();


            //  sv tu 10-100,  co the thay doi
            //if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            //{
            //    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            if (verif())
            {
                try
                {
                    id = Convert.ToInt32(textBoxID.Text);
                    pictureBoxBike.Image.Save(pic1, pictureBoxBike.Image.RawFormat);
                    pictureBoxOwner.Image.Save(pic2, pictureBoxOwner.Image.RawFormat);

                    if (bike.UpdateBkie(id, name, address, phone, timeRent, dateRent, type, pic1, pic2))
                    {
                        MessageBox.Show("Bike Infor Updated", "Edit Bike", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Bike", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Bike", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Bike", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //  delete student
            try
            {
                int BikeId = Convert.ToInt32(textBoxID.Text);
                //  display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Bike", "Delete Bike", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (bike.deleteBike(BikeId))
                    {
                        MessageBox.Show("Bike Deleted", "Delete Bike", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  clear fields after delete
                        textBoxName.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxBike.Image = null;
                        pictureBoxOwner.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Bike Not Deleted", "Delete Bike", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Bike", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            pictureBoxBike.Image = null;
            pictureBoxOwner.Image = null;
            radioButtonHour.Checked = true;
            radioButtonWeek.Checked = true;
            radioButtonMonth.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
