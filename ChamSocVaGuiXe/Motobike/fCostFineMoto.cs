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
    public partial class fCostFineMoto : Form
    {
        public fCostFineMoto()
        {
            InitializeComponent();
        }
        Moto moto = new Moto();
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxSearch.Text);
            // truy vấn đến csdl
            SqlCommand command = new SqlCommand("SELECT Id,ImageNumberPlate,ImageOwner,Name,Address,Phone,TimeRent,DateRent,Type FROM dbo.Moto WHERE Id = " + id);

            // đổ dữ liệu ra table
            DataTable table = moto.getMoto(command);

            if (table.Rows.Count > 0)
            {
                // trong bảng table lấy dữ liệu hàng đầu tiên, tên cột là Name
                textBoxName.Text = table.Rows[0]["Name"].ToString();

                textBox1.Text = "800";
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
                    radioButtonMonth.Checked = true;
                }

               // MessageBox.Show(table.Rows[0]["Type"].ToString()+"hhh", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Imge of Bike
                byte[] pic = (byte[])table.Rows[0]["ImageNumberPlate"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxMoto.Image = Image.FromStream(picture);

                // Image of Owner
                byte[] pic1 = (byte[])table.Rows[0]["ImageOwner"];
                MemoryStream picture1 = new MemoryStream(pic1);
                pictureBoxOwner.Image = Image.FromStream(picture1);

                DateTime DayRent = dateTimePicker1.Value;
                DateTime DayNow = DateTime.Today;


                TimeSpan Time = DayNow - DayRent;
                int TongSoNgay = Time.Days;
                double Cost;
                double Fine;
                int gia = 500;
                int Hour;
                double Total;
                string type = table.Rows[0]["Type"].ToString();
                // tính cost
                //MessageBox.Show((table.Rows[0]["Name"].ToString()), "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (type == "Hour")
                {
                    //object cost = (object)Cost;
                    // object kk= (object)Cost;
                    if ((TongSoNgay) > 0)
                    {
                        Hour = 24 - (int)numericUpDownTimeRent.Value;
                        Cost = Hour * 800;
                        object cost = (object)Cost;
                        textBoxCost.Text = cost.ToString();

                        Fine = gia * 8 * 2;
                        object fine = (object)Fine;
                        textBoxFine.Text = fine.ToString();

                        Total = Cost + Fine;
                        object total = (object)Total;
                        textBoxTotal.Text = total.ToString();

                        MessageBox.Show("Over time rent!!! ", "Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int TimeNow = DateTime.Now.Hour;
                        Hour = TimeNow - (int)numericUpDownTimeRent.Value;
                        Cost = Hour * 800;
                        object cost = (object)Cost;
                        textBoxCost.Text = cost.ToString();

                        textBoxFine.Text = ("0");

                        Total = Cost;
                        object total = (object)Total;
                        textBoxTotal.Text = total.ToString();

                        //MessageBox.Show(, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (type == "Week")
                {
                    if (TongSoNgay > 7)
                    {
                        if (TongSoNgay <= 10)
                        {
                            Cost = 8 * 800 * 3;
                            object cost = (object)Cost;
                            textBoxCost.Text = cost.ToString();

                            Fine = (TongSoNgay - 7) * gia * 8;
                            object fine = (object)Fine;
                            textBoxFine.Text = fine.ToString();

                            Total = Cost + Fine;
                            object total = (object)Total;
                            textBoxTotal.Text = total.ToString();
                        }
                        else if (TongSoNgay < 30)
                        {

                            Cost = 8 * 800 * 3;
                            object cost = (object)Cost;
                            textBoxCost.Text = cost.ToString();

                            Fine = 8 * gia * 3 * 2;
                            object fine = (object)Fine;
                            textBoxFine.Text = fine.ToString();

                            Total = Cost + Fine;
                            object total = (object)Total;
                            textBoxTotal.Text = total.ToString();
                        }

                        MessageBox.Show("Over time rent!!! ", "Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Cost = 8 * 800 * 3;
                        object cost = (object)Cost;
                        textBoxCost.Text = cost.ToString();

                        Fine = 0;
                        object fine = (object)Fine;
                        textBoxFine.Text = fine.ToString();

                        Total = Cost + Fine;
                        object total = (object)Total;
                        textBoxTotal.Text = total.ToString();
                    }
                }
                else if (type == "Day")
                {
                    int TimeNow = DateTime.Now.Hour;
                    int TimeYesterday = 24 - (int)numericUpDownTimeRent.Value;
                    int TimeRent = TimeNow + TimeYesterday;

                    if (TimeRent > 24)
                    {
                        Cost = 8 * 800;
                        object cost = (object)Cost;
                        textBoxCost.Text = cost.ToString();

                        Fine = 8 * 800 * 3;
                        object fine = (object)Fine;
                        textBoxFine.Text = fine.ToString();

                        Total = Cost + Fine;
                        object total = (object)Total;
                        textBoxTotal.Text = total.ToString();
                        MessageBox.Show("Over time rent!!! ", "Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Cost = 8 * 800;
                        object cost = (object)Cost;
                        textBoxCost.Text = cost.ToString();

                        Fine = 0;
                        object fine = (object)Fine;
                        textBoxFine.Text = fine.ToString();

                        Total = Cost + Fine;
                        object total = (object)Total;
                        textBoxTotal.Text = total.ToString();
                    }
                }
                else
                {
                    if (TongSoNgay > 30)
                    {
                        Cost = 8 * 800 * 3 * 2;
                        object cost = (object)Cost;
                        textBoxCost.Text = cost.ToString();

                        Fine = 8 * 800 * 3 * 2 * 2;
                        object fine = (object)Fine;
                        textBoxFine.Text = fine.ToString();

                        Total = Cost + Fine;
                        object total = (object)Total;
                        textBoxTotal.Text = total.ToString();
                        MessageBox.Show("Over time rent!!! ", "Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Cost = 8 * 800 * 3;
                        object cost = (object)Cost;
                        textBoxCost.Text = cost.ToString();

                        Fine = 0;
                        object fine = (object)Fine;
                        textBoxFine.Text = fine.ToString();

                        Total = Cost + Fine;
                        object total = (object)Total;
                        textBoxTotal.Text = total.ToString();
                    }
                }

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            fUpdateDeleteMoto frm = new fUpdateDeleteMoto();
            frm.textBoxID.Text = textBoxSearch.Text;

            frm.ShowDialog(this);
        }
    }
}
