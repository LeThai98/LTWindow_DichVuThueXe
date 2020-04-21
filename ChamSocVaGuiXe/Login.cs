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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            My_DB db = new My_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Login Where Username=@User AND Password=@Pass", db.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = txbUserName.Text;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = txbPassWord.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                fMain fm = new fMain();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password ", "Login Errol", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        // xử lý sự kiện close form
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // kiểm tra xem user có chọn yes khi có thông báo đóng form không
          if(MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)!=DialogResult.Yes)
            {
                e.Cancel = true;
            }

            //if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
