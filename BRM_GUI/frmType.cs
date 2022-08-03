using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRM_GUI
{
    public partial class frmType : Form
    {
        BRM db = new BRM();
        public frmType()
        {
            InitializeComponent();
            pnlForm.Visible = false;
            LoadDataType();
            LoadDataBus();
            AddBinding();
        }

        #region methods

        void AddBinding()
        {
            if(txtName.DataBindings.Count < 1)
            {
                txtName.DataBindings.Add(new Binding("Text", dgvType.DataSource, "name", true, DataSourceUpdateMode.Never));
                rtbDescription.DataBindings.Add(new Binding("Text", dgvType.DataSource, "description", true, DataSourceUpdateMode.Never));
            }
        }

        void ClearData()
        {
            txtName.DataBindings.Clear();
            rtbDescription.DataBindings.Clear();
            txtName.Clear();
            rtbDescription.Clear();
        }

        void LoadDataType()
        {
            var result = from types in db.BusTypes
                         select new
                         {
                             id = types.busTypeID,
                             name = types.name,
                             description = types.description
                         };
            dgvType.DataSource = result.ToList();
            dgvType.Columns["description"].Visible = false;
        }

        void LoadDataBus()
        {
            int id = 1;
            if (dgvType.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvType.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            }
            var result = from bus in db.Buses
                         where bus.busTypeId == id
                         select new
                         {
                             id = bus.busId,
                             taxCode = bus.taxCode,
                             licensePlate = bus.licensePlate,
                             seats = bus.seats,
                             distributor = bus.BusDistributor.name,
                         };
            dgvBus.DataSource = result.ToList();
        }

        void AddType()
        {
            BusType type = new BusType()
            {
                name = txtName.Text,
                description = rtbDescription.Text
            };

            db.BusTypes.Add(type);
            db.SaveChanges();
            LoadDataType();
        }

        void EditType()
        {
            int id = Convert.ToInt32(dgvType.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            BusType type = db.BusTypes.Find(id);
            type.name = txtName.Text;
            type.description = rtbDescription.Text;
            db.SaveChanges();
            LoadDataType();
        }

        void DeleteType()
        {
            int id = Convert.ToInt32(dgvType.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            if(id > 0)
            {
                BusType type = db.BusTypes.Find(id);
                db.BusTypes.Remove(type);
                db.SaveChanges();
                LoadDataType();
            }
        }

        bool FindType()
        {
            var result = db.BusTypes
                        .Where(p => p.name == txtName.Text)
                        .Count();
            if (result > 0)
                return true;
            return false;
        }
        #endregion

        #region events
        private void dgvType_SelectionChanged(object sender, EventArgs e)
        {
            LoadDataBus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
            btnSubmit.Text = "Thêm";
            txtName.ReadOnly = false;
            pnlForm.Visible = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            AddBinding();
            btnSubmit.Text = "Chỉnh sửa";
            txtName.ReadOnly = true;
            pnlForm.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvType.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá loại xe?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearData();
                    DeleteType();
                    MessageBox.Show("Xoá thành công");
                    pnlForm.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại xe muốn xoá");
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            if (bt.Text == "Thêm")
            {
                if (txtName.Text != String.Empty)
                {
                    if (FindType())
                    {
                        MessageBox.Show("Tên loại xe này đã tồn tại");
                        txtName.BackColor = Color.OrangeRed;
                        txtName.Focus();
                    }
                    else
                    {
                        AddType();
                        MessageBox.Show("Thêm thành công");
                        pnlForm.Visible=false;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    txtName.Focus();
                }
            }
            else
            {
                EditType();
                MessageBox.Show("Chỉnh sửa thành công");
                ClearData();
                pnlForm.Visible = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }
        #endregion
    }
}
