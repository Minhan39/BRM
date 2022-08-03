using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRM_GUI
{
    public partial class frmBusConnectingRoute : Form
    {
        BRM db = new BRM();
        bool checkLoad = false;
        public class Data
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public frmBusConnectingRoute()
        {
            InitializeComponent();
            LoadDataType();
            LoadDataDistributor();
            LoadDataRoute();
        }

        #region methods
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
            if (Int32.TryParse(cboDistributor.SelectedValue.ToString(), out a))
            {
                a = Convert.ToInt32(cboDistributor.SelectedValue.ToString());
            }
            int b = 0;
            if (Int32.TryParse(cboType.SelectedValue.ToString(), out b))
            {
                b = Convert.ToInt32(cboType.SelectedValue.ToString());
            }
            if (cboType.SelectedIndex != 0 && cboDistributor.SelectedIndex != 0)
            {
                result = db.Buses
                            .Where(p => p.busDistributorId == a && p.busTypeId == b)
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

        void LoadDataBusNow()
        {
            int id = Convert.ToInt32(dgvRoute.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            var result = from bus in db.BusConnectingRoutes
                         where EntityFunctions.TruncateTime(bus.timeStart) >= dtpSelect.Value.Date && EntityFunctions.TruncateTime(bus.timeEnd) <= dtpSelect.Value.Date && bus.busRouteId == id
                         select new { 
                            id = bus.busConnectingRouteId,
                            idBus = bus.busId,
                             licensePlate = bus.Bus.licensePlate,
                            timeBegin = bus.timeStart,
                            timeEnd = bus.timeEnd
                         };
            dgvBus.DataSource = result.ToList();
        }

        void LoadDataRoute()
        {
            var result = (from route in db.BusRoutes where route.isMatch == true select new { id = route.busRouteId, name = route.name, busStopBegin = route.BusStop.name, busStopEnd = route.BusStop1.name }).ToList();
            BindingList<Data> _cbo = new BindingList<Data>();
            foreach (var item in result)
            {
                _cbo.Add(new Data { name = item.name, id = item.id });
            }
            cboRoute.DataSource = _cbo;
            cboRoute.DisplayMember = "name";
            cboRoute.ValueMember = "id";
            cboRoute.SelectedIndex = 0;

            dgvRoute.DataSource = result;
        }

        void AddConnecting()
        {
            BusConnectingRoute connect = new BusConnectingRoute() { 
                busId = Convert.ToInt32(cboBus.SelectedValue),
                busRouteId = Convert.ToInt32(cboRoute.SelectedValue),
                timeStart = dtpBegin.Value,
                timeEnd = dtpEnd.Value,
            };
            db.BusConnectingRoutes.Add(connect);
            db.SaveChanges();
            LoadDataBusNow();
        }

        void DeleteConnecting()
        {
            int id = Convert.ToInt32(dgvBus.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            BusConnectingRoute connect = db.BusConnectingRoutes.Find(id);
            db.BusConnectingRoutes.Remove(connect);
            db.SaveChanges();
            LoadDataBusNow();
        }
        #endregion

        private void frmBusConnectingRoute_Load(object sender, EventArgs e)
        {
            checkLoad = true;
            LoadDataBus();
            LoadDataBusNow();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex >= 0 && checkLoad)
            {
                LoadDataBus();
            }
        }

        private void cboDistributor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDistributor.SelectedIndex >= 0 && checkLoad)
            {
                LoadDataBus();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(dtpBegin.Value == dtpEnd.Value)
            {
                MessageBox.Show("Ai chưa chạy mà ngừng bao giờ");
            }
            else
            {
                AddConnecting();
                MessageBox.Show("Thêm thành công");
            }
        }

        private void dtpSelect_ValueChanged(object sender, EventArgs e)
        {
            LoadDataBusNow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvBus.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá xe buýt này?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteConnecting();
                    MessageBox.Show("Xoá thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn xe buýt muốn xoá");
            }
        }

        private void dgvRoute_SelectionChanged(object sender, EventArgs e)
        {
            if (checkLoad && dgvRoute.SelectedRows.Count > 0)
            {
                LoadDataBusNow();
            }
        }
    }
}
