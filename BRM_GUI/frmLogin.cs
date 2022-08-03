using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRM_GUI
{
    public partial class frmLogin : Form
    {
        BRM db = new BRM();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !checkBox1.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = txtPassword.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                var result = from user in db.Users
                             where user.username == txtUsername.Text && user.password == txtPassword.Text
                             select user;
                if (result.ToList().Count > 0)
                {
                    frmMain frm = new frmMain(result.ToList()[0].isRole);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            else
            {
                MessageBox.Show("Điền thiếu thông tin");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
