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
    public partial class frmGuide : Form
    {
        BRM db = new BRM();
        public frmGuide()
        {
            InitializeComponent();
            LoadData();
            AddBinding();
            btnSubmit.Visible = false;
        }

        #region methods
        void AddBinding()
        {
            if (txtTitle.DataBindings.Count < 1)
            {
                txtTitle.DataBindings.Add(new Binding("Text", dgvGuide.DataSource, "name", true, DataSourceUpdateMode.Never));
                rtbBody.DataBindings.Add(new Binding("Text", dgvGuide.DataSource, "body", true, DataSourceUpdateMode.Never));
            }
        }

        void ClearData()
        {
            txtTitle.DataBindings.Clear();
            rtbBody.DataBindings.Clear();
            txtTitle.Clear();
            rtbBody.Clear();
        }

        void LoadData()
        {
            var result = from guide in db.Guides select new { 
                id = guide.guideId,
                name = guide.title,
                body = guide.body
            };
            dgvGuide.DataSource = result.ToList();
            dgvGuide.Columns["body"].Visible = false;
        }

        void AddGuide()
        {
            Guide guide = new Guide()
            {
                title = txtTitle.Text,
                body = rtbBody.Text
            };
            db.Guides.Add(guide);
            db.SaveChanges();
            LoadData();
        }

        void EditGuide()
        {
            int id = Convert.ToInt32(dgvGuide.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            Guide guide = db.Guides.Find(id);
            guide.title = txtTitle.Text;
            guide.body = rtbBody.Text;
            db.SaveChanges();
            LoadData();
        }

        void DeleteGuide()
        {
            int id = Convert.ToInt32(dgvGuide.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            Guide guide = db.Guides.Find(id);
            db.Guides.Remove(guide);
            db.SaveChanges();
            LoadData();
        }

        bool FindGuide()
        {
            var result = db.Guides
                        .Where(p => p.title == txtTitle.Text)
                        .Count();
            if (result > 0)
                return true;
            return false;
        }
        #endregion

        #region events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
            txtTitle.ReadOnly = false;
            btnSubmit.Visible = true;
            btnSubmit.Text = "Thêm";
        }

        private void dgvGuide_SelectionChanged(object sender, EventArgs e)
        {
            AddBinding();
            btnSubmit.Visible = false;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            txtTitle.ReadOnly = true;
            AddBinding();
            btnSubmit.Visible = true;
            btnSubmit.Text = "Chỉnh sửa";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvGuide.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá hướng dẫn?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteGuide();
                    MessageBox.Show("Xoá thành công");
                    ClearData();
                    pnlFill.Visible = false;
                    AddBinding();
                    btnSubmit.Visible = false;
                    pnlFill.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hướng dẫn muốn xoá");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "Thêm")
            {
                if (txtTitle.Text != String.Empty)
                {
                    if (FindGuide())
                    {
                        MessageBox.Show("Tên hướng dẫn này đã tồn tại");
                        txtTitle.BackColor = Color.OrangeRed;
                        txtTitle.Focus();
                    }
                    else
                    {
                        AddGuide();
                        MessageBox.Show("Thêm thành công");
                        ClearData();
                        pnlFill.Visible = false;
                        AddBinding();
                        btnSubmit.Visible = false;
                        pnlFill.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    txtTitle.Focus();
                }
            }
            else
            {
                EditGuide();
                MessageBox.Show("Chỉnh sửa thành công");
                ClearData();
                pnlFill.Visible = false;
                AddBinding();
                btnSubmit.Visible = false;
                pnlFill.Visible = true;
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            txtTitle.BackColor = Color.White;
        }
        #endregion
    }
}
