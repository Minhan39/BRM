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
    public partial class frmUser : Form
    {
        BRM db = new BRM();
        public frmUser()
        {
            InitializeComponent();
            pnlForm.Visible = false;
            LoadData();
        }

        #region methods
        void AddBinding()
        {
            if (txtUsername.DataBindings.Count < 1)
            {
                txtFirstname.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "firstname", true, DataSourceUpdateMode.Never));
                txtLastname.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "lastname", true, DataSourceUpdateMode.Never));
                txtUsername.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "username", true, DataSourceUpdateMode.Never));
                txtPassword.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "password", true, DataSourceUpdateMode.Never));
                txtEmail.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "email", true, DataSourceUpdateMode.Never));
                txtPhone.DataBindings.Add(new Binding("Text", dgvUser.DataSource, "phone", true, DataSourceUpdateMode.Never));
            }  
        }

        void ClearData()
        {
            txtFirstname.DataBindings.Clear();
            txtLastname.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtPhone.DataBindings.Clear();
            txtUsername.DataBindings.Clear();
            txtPassword.DataBindings.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        void LoadData()
        {
            var result = from users in db.Users select new {
                id = users.userId,
                lastname = users.lastname, 
                firstname = users.firstname, 
                username = users.username,
                role = (users.isRole) ? "Quản lý" : "Nhân viên",
                password = users.password, 
                email = users.email, 
                phone = users.phone  
            };
            dgvUser.DataSource = result.ToList();
        }

        void AddUser()
        {
            User user = new User()
            {
                firstname = txtFirstname.Text,
                lastname = txtLastname.Text,
                username = txtUsername.Text,
                password = txtPassword.Text,
                email = txtEmail.Text,
                phone = txtPhone.Text,
                isRole = false
            };
            db.Users.Add(user);
            db.SaveChanges();
            LoadData();
        }

        void EditeUser()
        {
            int id = Convert.ToInt32(dgvUser.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            User user = db.Users.Find(id);
            user.firstname = txtFirstname.Text;
            user.lastname = txtLastname.Text;
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;
            user.email = txtEmail.Text;
            user.phone = txtPhone.Text;
            db.SaveChanges();
            LoadData();
        }

        void DeleteUser()
        {
            int id = Convert.ToInt32(dgvUser.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            if(id > 0)
            {
                User user = db.Users.Find(id);
                db.Users.Remove(user);
                db.SaveChanges();
                LoadData();
            }
        }

        bool FindUser()
        {
            var result = db.Users
                        .Where(p => p.username == txtUsername.Text)
                        .Count();
            if(result > 0)
                return true;
            return false;
        }
        #endregion

        #region events

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
            btnSubmit.Text = "Thêm";
            btnRetry.Visible = true;
            txtUsername.ReadOnly = false;
            pnlForm.Visible = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            AddBinding();
            btnSubmit.Text = "Chỉnh sửa";
            btnRetry.Visible = false;
            txtUsername.ReadOnly = true;
            pnlForm.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvUser.SelectedCells.Count > 0)
            {
                if(MessageBox.Show("Bạn có thật sự muốn xoá tài khoản?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearData();
                    DeleteUser();
                    MessageBox.Show("Xoá thành công");
                    pnlForm.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản muốn xoá");
            }
        }

        private void pnlForm_VisibleChanged(object sender, EventArgs e)
        {
            btnClose.Visible = pnlForm.Visible;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            pnlForm.Visible = false;
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "Thêm")
            {
                if (txtUsername.Text != String.Empty && txtPassword.Text != String.Empty && txtFirstname.Text != String.Empty && txtLastname.Text != String.Empty)
                {
                    if (FindUser())
                    {
                        MessageBox.Show("Tên người dùng này đã tồn tại");
                        txtUsername.BackColor = Color.OrangeRed;
                        txtUsername.Focus();
                    }
                    else
                    {
                        AddUser();
                        MessageBox.Show("Thêm thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    txtLastname.Focus();
                }
            }
            else
            {
                EditeUser();
                MessageBox.Show("Chỉnh sửa thành công");
                ClearData();
                pnlForm.Visible = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.BackColor = Color.White;
        }

        private void btnPrt_Click(object sender, EventArgs e)
        {
            using (frmPrintUser frm = new frmPrintUser())
            {
                frm.PrintUser();
                frm.ShowDialog();
            }
        }
        #endregion
    }
}
