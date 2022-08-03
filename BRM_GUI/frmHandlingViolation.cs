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
    public partial class frmHandlingViolation : Form
    {
        BRM db = new BRM();
        bool checkLoad = false;
        public class Data
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public frmHandlingViolation()
        {
            InitializeComponent();
            LoadDataDistributor();
            LoadDataType();
            LoadDataViolation();
            pnlForm.Visible = false;
        }

        #region methods
        void AddBinding()
        {
            cboBus.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "bus", true, DataSourceUpdateMode.Never));
            txtDispatchNumber.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "dispatchNumber", true, DataSourceUpdateMode.Never));
            txtNumberOfMinutes.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "numberOfminutes", true, DataSourceUpdateMode.Never));
            txtViolationLevel.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "violationLevel", true, DataSourceUpdateMode.Never));
            txtPenaltyRate.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "penaltyRate", true, DataSourceUpdateMode.Never));
            cboCurrencyUnit.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "currencyUnit", true, DataSourceUpdateMode.Never));
            rtbBody.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "body", true, DataSourceUpdateMode.Never));
            dtpDateOfViolation.DataBindings.Add(new Binding("Text", dgvHadlingViolation.DataSource, "dateOfViolation", true, DataSourceUpdateMode.Never));
        }

        void ClearData()
        {
            cboBus.DataBindings.Clear();
            txtDispatchNumber.DataBindings.Clear();
            txtNumberOfMinutes.DataBindings.Clear();
            txtViolationLevel.DataBindings.Clear();
            txtPenaltyRate.DataBindings.Clear();
            cboCurrencyUnit.DataBindings.Clear();
            rtbBody.DataBindings.Clear();
            dtpDateOfViolation.DataBindings.Clear();
            cboBus.SelectedIndex = 0;
            txtDispatchNumber.Clear();
            txtNumberOfMinutes.Clear();
            txtViolationLevel.Clear();
            txtPenaltyRate.Clear();
            cboCurrencyUnit.SelectedIndex = 0;
            rtbBody.Clear();
            dtpDateOfViolation.Value = DateTime.Today;
        }
        void LoadDataType()
        {
            var result = (from type in db.BusTypes select new { id = type.busTypeID, name = type.name }).ToList();
            BindingList<Data> _cbo = new BindingList<Data>();
            _cbo.Add(new Data { name = "Tất cả", id = 0 });
            foreach (var item in result)
            {
                _cbo.Add(new Data { name = item.name, id = item.id });
            }
            cboType.DataSource = _cbo;
            cboType.DisplayMember = "name";
            cboType.ValueMember = "id";
            cboType.SelectedIndex = 0;
        }

        void LoadDataDistributor()
        {
            var result = (from distributor in db.BusDistributors select new { id = distributor.busDistributorId, name = distributor.name }).ToList();
            BindingList<Data> _cbo = new BindingList<Data>();
            _cbo.Add(new Data { name = "Tất cả", id = 0 });
            foreach (var item in result)
            {
                _cbo.Add(new Data { name = item.name, id = item.id });
            }
            cboDistributor.DataSource = _cbo;
            cboDistributor.DisplayMember = "name";
            cboDistributor.ValueMember = "id";
            cboDistributor.SelectedIndex = 0;
        }

        void LoadDataBus()
        {
            BindingList<Data> _cbo = new BindingList<Data>();
            var result = db.Buses
                            .Select(p => new { p.licensePlate, p.busId })
                            .ToList();
            int a = 0;
            if(Int32.TryParse(cboDistributor.SelectedValue.ToString(), out a))
            {
                a = Convert.ToInt32(cboDistributor.SelectedValue.ToString());
            }
            int b = 0;
            if(Int32.TryParse(cboType.SelectedValue.ToString(), out b))
            {
                b = Convert.ToInt32(cboType.SelectedValue.ToString());
            }
            if (cboType.SelectedIndex != 0 && cboDistributor.SelectedIndex != 0)
            {
                result = db.Buses
                            .Where(p => p.busDistributorId == a && p.busTypeId == b)
                            .Select(p => new {p.licensePlate, p.busId})
                            .ToList();
                foreach (var item in result)
                {
                    _cbo.Add(new Data { name = item.licensePlate, id = item.busId });
                }
                cboBus.DataSource = _cbo;
                cboBus.DisplayMember = "name";
                cboBus.ValueMember = "id";
                return;
            }
            if (cboType.SelectedIndex != 0)
            {
                result = db.Buses
                            .Where(p => p.busTypeId == b)
                            .Select(p => new { p.licensePlate, p.busId })
                            .ToList();
                foreach (var item in result)
                {
                    _cbo.Add(new Data { name = item.licensePlate, id = item.busId });
                }
                cboBus.DataSource = _cbo;
                cboBus.DisplayMember = "name";
                cboBus.ValueMember = "id";
                return;
            }
            if (cboDistributor.SelectedIndex != 0)
            {
                result = db.Buses
                            .Where(p => p.busDistributorId == a)
                            .Select(p => new { p.licensePlate, p.busId })
                            .ToList();
                foreach (var item in result)
                {
                    _cbo.Add(new Data { name = item.licensePlate, id = item.busId });
                }
                cboBus.DataSource = _cbo;
                cboBus.DisplayMember = "name";
                cboBus.ValueMember = "id";
                return;
            }
            foreach (var item in result)
            {
                _cbo.Add(new Data { name = item.licensePlate, id = item.busId });
            }
            cboBus.DataSource = _cbo;
            cboBus.DisplayMember = "name";
            cboBus.ValueMember = "id";
            return;
        }

        void LoadDataViolation()
        {
            var result = from violation in db.HandlingViolations
                         select new { 
                             id = violation.hadlingViolationId,
                             bus = violation.Bus.licensePlate,
                             busId = violation.busId,
                             dispatchNumber = violation.dispatchNumber,
                             numberOfminutes = violation.numberOfminutes,
                             violationLevel = violation.violationLevel,
                             penaltyRate = violation.penaltyRate,
                             currencyUnit = violation.currencyUnit,
                             body = violation.body,
                             dateOfViolation = violation.dateOfViolation
                         };
            dgvHadlingViolation.DataSource = result.ToList();
            dgvHadlingViolation.Columns["busId"].Visible = false;
            dgvHadlingViolation.Columns["body"].Visible = false;
        }

        void AddHandlingViolation()
        {
            HandlingViolation model = new HandlingViolation()
            {
                busId = Convert.ToInt32(cboBus.SelectedValue.ToString()),
                dispatchNumber = txtDispatchNumber.Text,
                numberOfminutes = (txtNumberOfMinutes.Text != "") ? Convert.ToInt32(txtNumberOfMinutes.Text) : 0,
                violationLevel = txtViolationLevel.Text,
                penaltyRate = Convert.ToInt32(txtPenaltyRate.Text),
                currencyUnit = cboCurrencyUnit.Text,
                body = rtbBody.Text,
                dateOfViolation = dtpDateOfViolation.Value
            };
            db.HandlingViolations.Add(model);
            db.SaveChanges();
            LoadDataViolation();
        }

        void EditHandlingViolation()
        {
            int id = Convert.ToInt32(dgvHadlingViolation.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            HandlingViolation model = db.HandlingViolations.Find(id);
            model.busId = Convert.ToInt32(cboBus.SelectedValue.ToString());
            model.dispatchNumber = txtDispatchNumber.Text;
            model.numberOfminutes = (txtNumberOfMinutes.Text != "") ? Convert.ToInt32(txtNumberOfMinutes.Text) : 0;
            model.violationLevel = txtViolationLevel.Text;
            model.penaltyRate = Convert.ToInt32(txtPenaltyRate.Text);
            model.currencyUnit = cboCurrencyUnit.Text;
            model.body = rtbBody.Text;
            model.dateOfViolation = dtpDateOfViolation.Value;
            db.SaveChanges();
            LoadDataViolation();
        }

        void DeleteHandlingViolation()
        {
            int id = Convert.ToInt32(dgvHadlingViolation.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            HandlingViolation model = db.HandlingViolations.Find(id);
            db.HandlingViolations.Remove(model);
            db.SaveChanges();
            LoadDataViolation();
        }
        #endregion

        #region events
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboType.SelectedIndex >= 0 && checkLoad)
            {
                LoadDataBus();
            }
        }

        private void cboDistributor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDistributor.SelectedIndex >= 0 && checkLoad)
            {
                LoadDataBus();
            }
        }

        private void frmHandlingViolation_Load(object sender, EventArgs e)
        {
            checkLoad = true;
            LoadDataBus();
            cboCurrencyUnit.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
            cboBus.SelectedIndex = 0;
            cboCurrencyUnit.SelectedIndex = 0;
            cboBus.Enabled = true;
            btnSubmit.Text = "Thêm";
            btnRetry.Visible = true;
            pnlForm.Visible = true;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            AddBinding();
            cboBus.Enabled = false;
            btnSubmit.Text = "Chỉnh sửa";
            btnRetry.Visible = false;
            pnlForm.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvHadlingViolation.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá vi phạm?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearData();
                    DeleteHandlingViolation();
                    MessageBox.Show("Xoá thành công");
                    pnlForm.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn vi phạm muốn xoá");
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
                if (txtDispatchNumber.Text != String.Empty && txtPenaltyRate.Text != String.Empty && txtViolationLevel.Text != String.Empty && rtbBody.Text != String.Empty)
                {
                    AddHandlingViolation();
                    MessageBox.Show("Thêm thành công");
                    pnlForm.Visible = false;
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    txtDispatchNumber.Focus();
                }
            }
            else
            {
                EditHandlingViolation();
                MessageBox.Show("Chỉnh sửa thành công");
                ClearData();
                pnlForm.Visible = false;
            }
        }
        #endregion
    }
}
