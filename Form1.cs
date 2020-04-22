using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace appquanlimon
{
    public partial class frmLogin : Form
    {
        SqlConnection Con = new SqlConnection( @"Data Source=DESKTOP-PGISFD6\SQLEXPRESS;Initial Catalog=app;Integrated Security=True");
        public frmLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new System.Data.SqlClient.SqlConnection(@"Data Source=DESKTOP-PGISFD6\SQLEXPRESS;Initial Catalog=app;Integrated Security=True");
            try
            {
                Con.Open();
                string tk = txtAccount.Text;
                string mk = txtPassword.Text;
                string sql = "select Account , Password from Login where Account= N'" + tk + "'and Password =N'" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                    this.Show();
                    txtAccount.Clear();
                    txtPassword.Clear();

                }
                else
                {
                    MessageBox.Show("Đăng Nhập Lỗi ", "Thông Báo", MessageBoxButtons.OK);
                    txtAccount.Clear();
                    txtPassword.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
            }

        }
       
        private void txtAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ? ", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
