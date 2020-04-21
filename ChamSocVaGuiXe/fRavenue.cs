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
    public partial class fRavenue : Form
    {
        public fRavenue()
        {
            InitializeComponent();
        }
        Car car = new Car();
        Bike bike = new Bike();
        Moto moto = new Moto();

        double BikeCost = 0;
        double BikeFine = 0;

        double MotoCost = 0;
        double MotoFine = 0;

        double CarCost = 0;
        double CarFine = 0;

        double Total = 0;

        public void EvenueOfBike()
        {
            double t=0;
            double Cost=0;
            double Fine=0;
            int TotalSlot = bike.totalSlot();
            int Hour;

            SqlCommand command = new SqlCommand("SELECT *FROM dbo.Bike");
            DataTable table = bike.getBike(command);
            for(int i=0; i<TotalSlot; i++)
            {
                DateTime DayRent = (DateTime)table.Rows[i]["DateRent"];
                DateTime DayToDay= DateTime.Today;

                TimeSpan Time = DayToDay - DayRent;
                int TongSoNgay = Time.Days;
                int gia = 500;
               
                double Total;
                if (table.Rows[i]["Type"].ToString()=="Hour")
                {
                    double CotHour = 0;
                    double FineHour = 0;
                    if ((TongSoNgay) > 0)
                    {
                        Hour = 24 - (int)table.Rows[i]["TimeRent"];
                        CotHour = CotHour+ Hour * gia;
                        FineHour = FineHour+ gia * 8 * 2;
                    }
                    else
                    {
                        int TimeNow = DateTime.Now.Hour;
                        Hour = TimeNow - (int)table.Rows[i]["TimeRent"];
                        CotHour = Cost + Hour * gia;
                    }
                    Cost += CotHour;
                    Fine += FineHour;
                }
                else if(table.Rows[i]["Type"].ToString() == "Day" )
                {
                    double CostDay = 0;
                    double FineDay = 0;

                    int TimeNow = DateTime.Now.Hour;
                    int TimeYesterday = 24 - (int)table.Rows[i]["TimeRent"];
                    int TimeRent = TimeNow + TimeYesterday;

                    if (TimeRent > 24)
                    {
                        CostDay = CostDay+8 * gia;
                        FineDay = FineDay+8 * gia * 3;
                        
                    }
                    else
                    {
                        CostDay=CostDay+ 8 * gia;
                    }

                    Cost += CostDay;
                    Fine += FineDay;
                }
                else if(table.Rows[i]["Type"].ToString() == "Week")
                {
                    double CostWeek = 0;
                    double FineWeek = 0;

                    if (TongSoNgay > 7)
                    {
                        if (TongSoNgay <= 10)
                        {
                            CostWeek = CostWeek + 8 * gia * 3;
                            FineWeek = (TongSoNgay - 7) * gia * 8;
                        }
                        else if (TongSoNgay < 30)
                        {
                            CostWeek = 8 * gia * 3;
                            FineWeek = 8 * gia * 3 * 2;
                        }
                    }
                    else
                    {
                        CostWeek = 8 * 500 * 3;
                    }

                    Cost += CostWeek;
                    Fine += FineWeek;
                }
                else
                {
                    double CostMonth = 0;
                    double FineMonth = 0;
                    if (TongSoNgay > 30)
                    {
                        CostMonth = CostMonth +8 * gia * 3 * 2;
                        // phạt 2 tháng 
                        FineMonth = FineMonth +8 * gia * 3 * 2 * 2;
                    }
                    else
                    {
                        CostMonth = CostMonth+8 * gia * 3 * 2;
                     
                    }
                    Cost += CostMonth;
                    Fine += FineMonth;
                }

            }

            BikeCost += Cost;
            BikeFine += Fine;
            textBoxCostBike.Text = (BikeCost + "đ");
            textBoxFineBike.Text = (BikeFine + "đ");
            Total = Total + BikeCost + BikeFine;


        }
        public void EvenueOfMoto()
        {
            double t = 0;
            double Cost = 0;
            double Fine = 0;
            int TotalSlot = moto.totalSlot();
            int Hour;

            SqlCommand command = new SqlCommand("SELECT *FROM dbo.Moto");
            DataTable table = moto.getMoto(command);
            for (int i = 0; i < TotalSlot; i++)
            {
                DateTime DayRent = (DateTime)table.Rows[i]["DateRent"];
                DateTime DayToDay = DateTime.Today;

                TimeSpan Time = DayToDay - DayRent;
                int TongSoNgay = Time.Days;
                int gia = 800;

                double Total;
                if (table.Rows[i]["Type"].ToString() == "Hour")
                {
                    double CotHour = 0;
                    double FineHour = 0;
                    if ((TongSoNgay) > 0)
                    {
                        Hour = 24 - (int)table.Rows[i]["TimeRent"];
                        CotHour = CotHour + Hour * gia;
                        FineHour = FineHour + gia * 8 * 2;
                    }
                    else
                    {
                        int TimeNow = DateTime.Now.Hour;
                        Hour = TimeNow - (int)table.Rows[i]["TimeRent"];
                        CotHour = Cost + Hour * gia;
                    }
                    Cost += CotHour;
                    Fine += FineHour;
                }
                else if (table.Rows[i]["Type"].ToString() == "Day")
                {
                    double CostDay = 0;
                    double FineDay = 0;

                    int TimeNow = DateTime.Now.Hour;
                    int TimeYesterday = 24 - (int)table.Rows[i]["TimeRent"];
                    int TimeRent = TimeNow + TimeYesterday;

                    if (TimeRent > 24)
                    {
                        CostDay = CostDay + 8 * gia;
                        FineDay = FineDay + 8 * gia * 3;

                    }
                    else
                    {
                        CostDay = CostDay + 8 * gia;
                    }

                    Cost += CostDay;
                    Fine += FineDay;
                }
                else if (table.Rows[i]["Type"].ToString() == "Week")
                {
                    double CostWeek = 0;
                    double FineWeek = 0;

                    if (TongSoNgay > 7)
                    {
                        if (TongSoNgay <= 10)
                        {
                            CostWeek = CostWeek + 8 * gia * 3;
                            FineWeek = (TongSoNgay - 7) * gia * 8;
                        }
                        else if (TongSoNgay < 30)
                        {
                            CostWeek = 8 * gia * 3;
                            FineWeek = 8 * gia * 3 * 2;
                        }
                    }
                    else
                    {
                        CostWeek = 8 * 500 * 3;
                    }

                    Cost += CostWeek;
                    Fine += FineWeek;
                }
                else
                {
                    double CostMonth = 0;
                    double FineMonth = 0;
                    if (TongSoNgay > 30)
                    {
                        CostMonth = CostMonth + 8 * gia * 3 * 2;
                        // phạt 2 tháng 
                        FineMonth = FineMonth + 8 * gia * 3 * 2 * 2;
                    }
                    else
                    {
                        CostMonth = CostMonth + 8 * gia * 3 * 2;

                    }
                    Cost += CostMonth;
                    Fine += FineMonth;
                }

            }

            MotoCost += Cost;
            MotoFine += Fine;
            textBoxCostMoto.Text = (MotoCost + "đ");
            textBoxFineMoto.Text = (MotoFine + "đ");
            Total = Total + MotoCost + MotoFine;

        }
        public void EvenueOfCar()
        {
            double t = 0;
            double Cost = 0;
            double Fine = 0;
            int TotalSlot = car.totalSlot();
            int Hour;

            SqlCommand command = new SqlCommand("SELECT *FROM dbo.Car");
            DataTable table = car.getCar(command);
            for (int i = 0; i < TotalSlot; i++)
            {
                DateTime DayRent = (DateTime)table.Rows[i]["DateRent"];
                DateTime DayToDay = DateTime.Today;

                TimeSpan Time = DayToDay - DayRent;
                int TongSoNgay = Time.Days;
                int gia = 1200;

                double Total;
                if (table.Rows[i]["Type"].ToString() == "Hour")
                {
                    double CotHour = 0;
                    double FineHour = 0;
                    if ((TongSoNgay) > 0)
                    {
                        Hour = 24 - (int)table.Rows[i]["TimeRent"];
                        CotHour = CotHour + Hour * gia;
                        FineHour = FineHour + gia * 8 * 2;
                    }
                    else
                    {
                        int TimeNow = DateTime.Now.Hour;
                        Hour = TimeNow - (int)table.Rows[i]["TimeRent"];
                        CotHour = Cost + Hour * gia;
                    }
                    Cost += CotHour;
                    Fine += FineHour;
                }
                else if (table.Rows[i]["Type"].ToString() == "Day")
                {
                    double CostDay = 0;
                    double FineDay = 0;

                    int TimeNow = DateTime.Now.Hour;
                    int TimeYesterday = 24 - (int)table.Rows[i]["TimeRent"];
                    int TimeRent = TimeNow + TimeYesterday;

                    if (TimeRent > 24)
                    {
                        CostDay = CostDay + 8 * gia;
                        FineDay = FineDay + 8 * gia * 3;

                    }
                    else
                    {
                        CostDay = CostDay + 8 * gia;
                    }

                    Cost += CostDay;
                    Fine += FineDay;
                }
                else if (table.Rows[i]["Type"].ToString() == "Week")
                {
                    double CostWeek = 0;
                    double FineWeek = 0;

                    if (TongSoNgay > 7)
                    {
                        if (TongSoNgay <= 10)
                        {
                            CostWeek = CostWeek + 8 * gia * 3;
                            FineWeek = (TongSoNgay - 7) * gia * 8;
                        }
                        else if (TongSoNgay < 30)
                        {
                            CostWeek = 8 * gia * 3;
                            FineWeek = 8 * gia * 3 * 2;
                        }
                    }
                    else
                    {
                        CostWeek = 8 * 500 * 3;
                    }

                    Cost += CostWeek;
                    Fine += FineWeek;
                }
                else
                {
                    double CostMonth = 0;
                    double FineMonth = 0;
                    if (TongSoNgay > 30)
                    {
                        CostMonth = CostMonth + 8 * gia * 3 * 2;
                        // phạt 2 tháng 
                        FineMonth = FineMonth + 8 * gia * 3 * 2 * 2;
                    }
                    else
                    {
                        CostMonth = CostMonth + 8 * gia * 3 * 2;

                    }
                    Cost += CostMonth;
                    Fine += FineMonth;
                }

            }

            CarCost += Cost;
            CarFine += Fine;

            textBoxCostCar.Text = (CarCost + "đ");
            textBoxFineCar.Text = (CarFine + "đ");
            Total = Total + CarCost + CarFine;

        }
        private void fRavenue_Load(object sender, EventArgs e)
        {
            string DayNow = DateTime.Today.ToString("dd/MM/yyyy");
            labelDay.Text = DayNow;
            //textBoxCostBike.Text = (BikeCost+"đ");
            //textBoxFineBike.Text = (BikeFine + "đ");

            //textBoxCostMoto.Text = (MotoCost + "đ");
            //textBoxFineMoto.Text = (MotoFine + "đ");

            //textBoxCostCar.Text = (CarCost + "đ");
            //textBoxFineCar.Text = (CarFine + "đ");
            EvenueOfBike();
            EvenueOfMoto();
            EvenueOfCar();
            textBoxTotal.Text = (Total + "đ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ Total Ravenue Of Day.txt";

            using (var writer = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;
                // sinhvien nhin vao file huong dan lam tieu de cho cac cot
                writer.Write("Bike Cost:" + textBoxCostBike.Text + "\t" + "Bike Fine:" + textBoxFineBike.Text+"\n");
                writer.Write("Moto Cost:" + textBoxCostMoto.Text + "\t" + "Moto Fine:" + textBoxFineMoto.Text+"\n");
                writer.Write("Car Cost:" + textBoxCostCar.Text + "\t" + "\t" + "Car Fine:" + textBoxFineCar.Text+"\n");
                writer.Write("Total Ravenue:" + textBoxTotal.Text);
                writer.Close();

                MessageBox.Show("File saved");
                //for (int i = 0; i < DataGridView1.Rows.Count; i++)
                //{
                //    for (int j = 0; j < DataGridView1.Columns.Count - 1; j++)
                //    {
                //        if (j == 3)
                //        {
                //            bdate = Convert.ToDateTime(DataGridView1.Rows[i].Cells[j].Value.ToString());
                //            writer.Write("\t" + bdate.ToString("yyyy-MM-dd") + "\t" + "|");
                //        }
                //        else if (j == DataGridView1.Columns.Count - 2)
                //        {
                //            writer.Write("\t" + DataGridView1.Rows[i].Cells[j].Value.ToString());
                //        }
                //        else
                //        {
                //            writer.Write("\t" + DataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                //        }
                //    }
                //    writer.WriteLine("");
                //    writer.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------");
            }
               
               
            
        }
    }
              
}
