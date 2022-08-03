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
    public partial class frmBus : Form
    {
        BRM db = new BRM();

        public class Data
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public frmBus()
        {
            InitializeComponent();
            LoadDataType();
            LoadDataDistributor();
            LoadDataBus();
            AddBinding();
            pnlForm.Visible = false;
        }

        #region methods
        void AddBinding()
        {
            if(txtLicensePlate.DataBindings.Count < 1)
            {
                txtLicensePlate.DataBindings.Add(new Binding("Text", dgvBus.DataSource, "licensePlate", true, DataSourceUpdateMode.Never));
                txtTaxCode.DataBindings.Add(new Binding("Text", dgvBus.DataSource, "taxCode", true, DataSourceUpdateMode.Never));
                txtSeats.DataBindings.Add(new Binding("Text", dgvBus.DataSource, "seats", true, DataSourceUpdateMode.Never));
                cboType.DataBindings.Add(new Binding("Text", dgvBus.DataSource, "type", true, DataSourceUpdateMode.Never));
                cboDistributor.DataBindings.Add(new Binding("Text", dgvBus.DataSource, "distributor", true, DataSourceUpdateMode.Never));
            }
        }
        void ClearData()
        {
            txtLicensePlate.DataBindings.Clear();
            txtSeats.DataBindings.Clear();
            txtTaxCode.DataBindings.Clear();
            cboType.DataBindings.Clear();
            cboDistributor.DataBindings.Clear();
            txtLicensePlate.Clear();
            txtSeats.Clear();
            txtTaxCode.Clear();
            cboType.SelectedIndex = 0;
            cboDistributor.SelectedIndex = 0;
        }
        void LoadDataType()
        {
            BindingList<Data> _cbo = new BindingList<Data>();
            var result = (from type in db.BusTypes select new { id = type.busTypeID, name = type.name }).ToList();
            foreach (var item in result)
            {
                _cbo.Add(new Data { name = item.name, id = item.id });
            }
            cboType.DataSource = _cbo;
            cboType.DisplayMember = "name";
            cboType.ValueMember = "id";
        }

        void LoadDataDistributor()
        {
            var result = (from distributor in db.BusDistributors select new { id = distributor.busDistributorId, name = distributor.name }).ToList();
            BindingList<Data> _cbo = new BindingList<Data>();
            foreach (var item in result)
            {
                _cbo.Add(new Data { name = item.name, id = item.id });
            }
            cboDistributor.DataSource = _cbo;
            cboDistributor.DisplayMember = "name";
            cboDistributor.ValueMember = "id";
        }
        void LoadDataBus()
        {
            var result = from bus in db.Buses
                         select new
                         {
                             id = bus.busId,
                             taxCode = bus.taxCode,
                             licensePlate = bus.licensePlate,
                             seats = bus.seats,
                             type = bus.BusType.name,
                             distributor = bus.BusDistributor.name
                         };
            dgvBus.DataSource = result.ToList();
        }
        void AddBus()
        {
            Bus bus = new Bus() {
                licensePlate = txtLicensePlate.Text,
                taxCode = txtTaxCode.Text,
                seats = Convert.ToInt32(txtSeats.Text),
                busDistributorId = Convert.ToInt32(cboDistributor.SelectedValue),
                busTypeId = Convert.ToInt32(cboType.SelectedValue),
            };
            db.Buses.Add(bus);
            db.SaveChanges();
            LoadDataBus();
        }

        void EditBus()
        {
            int id = Convert.ToInt32(dgvBus.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            Bus bus = db.Buses.Find(id);
            bus.licensePlate = txtLicensePlate.Text;
            bus.taxCode = txtTaxCode.Text;
            bus.seats = Convert.ToInt32(txtSeats.Text);
            bus.busDistributorId = Convert.ToInt32(cboDistributor.SelectedValue);
            bus.busTypeId = Convert.ToInt32(cboType.SelectedValue);
            db.SaveChanges();
            LoadDataBus();
        }

        void DeleteBus()
        {
            int id = Convert.ToInt32(dgvBus.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            Bus bus = db.Buses.Find(id);
            db.Buses.Remove(bus);
            db.SaveChanges();
            LoadDataBus();
        }

        bool FindBus()
        {
            int result = db.Buses
                        .Where(p => p.licensePlate == txtLicensePlate.Text && p.taxCode == txtTaxCode.Text)
                        .Count();
            if (result > 0)
                return true;
            return false;
        }
        #endregion

        #region events
        private void frmBus_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            cboDistributor.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
            btnSubmit.Text = "Thêm";
            btnRetry.Visible = true;
            txtLicensePlate.ReadOnly = false;
            pnlForm.Visible = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            AddBinding();
            btnSubmit.Text = "Chỉnh sửa";
            btnRetry.Visible = false;
            txtLicensePlate.ReadOnly = true;
            pnlForm.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvBus.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá xe buýt này?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearData();
                    DeleteBus();
                    MessageBox.Show("Xoá thành công");
                    pnlForm.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe buýt muốn xoá");
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
                if (txtLicensePlate.Text != String.Empty && txtTaxCode.Text != String.Empty)
                {
                    if (FindBus())
                    {
                        MessageBox.Show("Xe buýt biển hiệu này đã tồn tại");
                        txtLicensePlate.BackColor = Color.OrangeRed;
                        txtLicensePlate.Focus();
                    }
                    else
                    {
                        AddBus();
                        MessageBox.Show("Thêm thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    txtLicensePlate.Focus();
                }
            }
            else
            {
                EditBus();
                MessageBox.Show("Chỉnh sửa thành công");
                ClearData();
                pnlForm.Visible = false;
            }
        }

        private void txtLicensePlate_TextChanged(object sender, EventArgs e)
        {
            txtLicensePlate.BackColor = Color.White;
        }
        #endregion
    }
}
