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
    public partial class fUpdateDeleteMoto : Form
    {
        public fUpdateDeleteMoto()
        {
            InitializeComponent();
        }

        private void fUpdateDeleteMoto_Load(object sender, EventArgs e)
        {

        }
        Moto moto = new Moto();
        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            // truy vấn đến csdl
            SqlCommand command = new SqlCommand("SELECT Id,ImageNumberPlate,ImageOwner,Name,Address,Phone,TimeRent,DateRent,Type FROM dbo.Moto WHERE Id = " + id);

            // đổ dữ liệu ra table
            DataTable table = moto.getMoto(command);

            if (table.Rows.Count > 0)
            {
                // trong bảng table lấy dữ liệu hàng đầu tiên, tên cột là Name
                textBoxNameOwner.Text = table.Rows[0]["Name"].ToString();
                textBoxPhone.Text = table.Rows[0]["Phone"].ToString();
                textBoxAddress.Text = table.Rows[0]["Address"].ToString();

                dateTimePicker1.Value = (DateTime)table.Rows[0]["DateRent"];

                numericUpDownTimeRent.Value = (int)table.Rows[0]["TimeRent"];

                //  type
                if (table.Rows[0]["Type"].ToString() == "Hour")
                {
                    radioButtonHour.Checked = true;
                }
                else if (table.Rows[0]["Type"].ToString() == "Week")
                {
                    radioButtonWeek.Checked = true;
                }
                else if (table.Rows[0]["Type"].ToString() == "Day")
                {
                    radioButtonDay.Checked = true;
                }
                else
                {
                    radioButtonDay.Checked = true;
                }

                // Imge of Bike
                byte[] pic = (byte[])table.Rows[0]["ImageNumberPlate"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxNumberPlate.Image = Image.FromStream(picture);

                // Image of Owner
                byte[] pic1 = (byte[])table.Rows[0]["ImageOwner"];
                MemoryStream picture1 = new MemoryStream(pic1);
                pictureBoxOwner.Image = Image.FromStream(picture1);

                // Address
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string name = textBoxNameOwner.Text;
            string address = textBoxAddress.Text;
            string phone = textBoxPhone.Text;
            int timeRent = (int)numericUpDownTimeRent.Value;
            DateTime dateRent = dateTimePicker1.Value;

            string type = "Hour";

            if (radioButtonWeek.Checked)
            {
                type = "Week";
            }
            else if (radioButtonDay.Checked)
            {
                type = "Day";
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
                    pictureBoxNumberPlate.Image.Save(pic1, pictureBoxNumberPlate.Image.RawFormat);
                    pictureBoxOwner.Image.Save(pic2, pictureBoxOwner.Image.RawFormat);

                    if (moto.UpdateMoto(id, name, address, phone, timeRent, dateRent, type, pic1, pic2))
                    {
                        MessageBox.Show("Moto Infor Updated", "Edit Moto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Moto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Moto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Moto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxNameOwner.Text.Trim() == "")
                        || (textBoxAddress.Text.Trim() == "")
                        || (textBoxPhone.Text.Trim() == "")
                        || (pictureBoxOwner.Image == null)
                        || (pictureBoxNumberPlate.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //  delete student
            try
            {
                int BikeId = Convert.ToInt32(textBoxID.Text);
                //  display a confirmation message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Moto", "Delete Moto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (moto.deleteMoto(BikeId))
                    {
                        MessageBox.Show("Moto Deleted", "Delete Moto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  clear fields after delete
                        textBoxNameOwner.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxNumberPlate.Image = null;
                        pictureBoxOwner.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Moto Not Deleted", "Delete Moto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Moto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUploadImageNumberPlate_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxNumberPlate.Image = Image.FromFile(open.FileName);
            }
        }

        private void buttonUploadImageOwner_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxOwner.Image = Image.FromFile(open.FileName);
            }
        }
    }
}
