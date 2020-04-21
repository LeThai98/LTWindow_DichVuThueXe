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
    public partial class fUpdateDeleteBike : Form
    {
        public fUpdateDeleteBike()
        {
            InitializeComponent();
        }
        Bike bike = new Bike();
        private void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            // truy vấn đến csdl
            SqlCommand command = new SqlCommand("SELECT Id,ImageBike,ImageOwner,Name,Address,Phone,TimeRent,DateRent,Type FROM dbo.Bike WHERE Id = " + id);

            // đổ dữ liệu ra table
            DataTable table = bike.getBike(command);

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
                else if(table.Rows[0]["Type"].ToString() == "Week")
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
                byte[] pic = (byte[])table.Rows[0]["imagebike"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxBike.Image = Image.FromStream(picture);

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

            string type= "Hour";

            if (radioButtonWeek.Checked)
            {
                type = "Week";
            }
            else if(radioButtonDay.Checked)
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
                    pictureBoxBike.Image.Save(pic1, pictureBoxBike.Image.RawFormat);
                    pictureBoxOwner.Image.Save(pic2, pictureBoxOwner.Image.RawFormat);

                    if (bike.UpdateBkie(id, name, address, phone, timeRent, dateRent,type,pic1, pic2))
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
        bool verif()
        {
            if ((textBoxNameOwner.Text.Trim() == "")
                        || (textBoxAddress.Text.Trim() == "")
                        || (textBoxPhone.Text.Trim() == "")
                        ||(pictureBoxOwner.Image == null)
                        || (pictureBoxBike.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void buttonUploadImageBike_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBike.Image = Image.FromFile(open.FileName);
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
                        textBoxNameOwner.Text = "";
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

        private void fUpdateDelete_Load(object sender, EventArgs e)
        {

        }
    }
}
