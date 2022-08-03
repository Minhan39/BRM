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
    public partial class frmDistributor : Form
    {
        BRM db = new BRM();
        public frmDistributor()
        {
            InitializeComponent();
            pnlForm.Visible = false;
            LoadDataDistributor();
            LoadDataBus();
            AddBinding();
        }

        #region methods
        void AddBinding()
        {
            if (txtName.DataBindings.Count < 1)
            {
                txtName.DataBindings.Add(new Binding("Text", dgvDistributor.DataSource, "name", true, DataSourceUpdateMode.Never));
                txtAddress.DataBindings.Add(new Binding("Text", dgvDistributor.DataSource, "address", true, DataSourceUpdateMode.Never));
                txtContact.DataBindings.Add(new Binding("Text", dgvDistributor.DataSource, "contact", true, DataSourceUpdateMode.Never));
                rtbDescription.DataBindings.Add(new Binding("Text", dgvDistributor.DataSource, "description", true, DataSourceUpdateMode.Never));
            }
        }

        void ClearData()
        {
            txtName.DataBindings.Clear();
            rtbDescription.DataBindings.Clear();
            txtAddress.DataBindings.Clear();
            txtContact.DataBindings.Clear();
            txtName.Clear();
            rtbDescription.Clear();
            txtAddress.Clear();
            txtContact.Clear();
        }

        void LoadDataDistributor()
        {
            var result = from distributor in db.BusDistributors
                         select new
                         {
                             id = distributor.busDistributorId,
                             name = distributor.name,
                             description = distributor.description,
                             address = distributor.address,
                             contact = distributor.contact
                         };
            dgvDistributor.DataSource = result.ToList();
            dgvDistributor.Columns["description"].Visible = false;
        }

        void LoadDataBus()
        {
            int id = 1;
            if (dgvDistributor.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(dgvDistributor.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            }
            var result = from bus in db.Buses
                         where bus.busDistributorId == id
                         select new
                         {
                             id = bus.busId,
                             taxCode = bus.taxCode,
                             licensePlate = bus.licensePlate,
                             seats = bus.seats,
                             type = bus.BusType.name
                         };
            dgvBus.DataSource = result.ToList();
        }

        void AddDistributor()
        {
            BusDistributor distributor = new BusDistributor()
            {
                name = txtName.Text,
                description = rtbDescription.Text,
                address = txtAddress.Text,
                contact = txtContact.Text,
            };

            db.BusDistributors.Add(distributor);
            db.SaveChanges();
            LoadDataDistributor();
        }

        void EditDistributor()
        {
            int id = Convert.ToInt32(dgvDistributor.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            BusDistributor distributor = db.BusDistributors.Find(id);
            distributor.name = txtName.Text;
            distributor.description = rtbDescription.Text;
            distributor.address = txtAddress.Text;
            distributor.contact = txtContact.Text;
            db.SaveChanges();
            LoadDataDistributor();
        }

        void DeleteDistributor()
        {
            int id = Convert.ToInt32(dgvDistributor.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            if (id > 0)
            {
                BusDistributor distributor = db.BusDistributors.Find(id);
                db.BusDistributors.Remove(distributor);
                db.SaveChanges();
                LoadDataDistributor();
            }
        }

        bool FindDistributor()
        {
            var result = db.BusDistributors
                        .Where(p => p.name == txtName.Text)
                        .Count();
            if (result > 0)
                return true;
            return false;
        }
        #endregion

        #region events
        private void btnChart_Click(object sender, EventArgs e)
        {
            frmChartDistributor frm = new frmChartDistributor();
            frm.ShowDialog();
        }
        private void dgvDistributor_SelectionChanged(object sender, EventArgs e)
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
            if (dgvDistributor.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá nhà cung cấp?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearData();
                    DeleteDistributor();
                    MessageBox.Show("Xoá thành công");
                    pnlForm.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp muốn xoá");
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
                    if (FindDistributor())
                    {
                        MessageBox.Show("Tên nhà cung cấp này đã tồn tại");
                        txtName.BackColor = Color.OrangeRed;
                        txtName.Focus();
                    }
                    else
                    {
                        AddDistributor();
                        MessageBox.Show("Thêm thành công");
                        pnlForm.Visible = false;
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
                EditDistributor();
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
