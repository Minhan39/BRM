using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class frmRoute : Form
    {
        BRM db = new BRM();
        bool isLoad = false;
        public class Data
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public frmRoute()
        {
            InitializeComponent();
            LoadDataParent();
            rdoChild.Checked = true;
            LoadMap();
            LoadPoint();
            pnlForm.Visible = false;
            btnClose.Visible = false;
            LoadBusStop();
            AddBinding();
            btnManage.Visible = false;
        }

        #region methods
        void AddBinding()
        {
            if(txtName.DataBindings.Count < 1)
            {
                txtName.DataBindings.Add(new Binding("Text", dgvRouteParent.DataSource, "name", true, DataSourceUpdateMode.Never));
                cboBusStopBegin.DataBindings.Add(new Binding("Text", dgvRouteParent.DataSource, "busStopBegin", true, DataSourceUpdateMode.Never));
                cboBusStopEnd.DataBindings.Add(new Binding("Text", dgvRouteParent.DataSource, "busStopEnd", true, DataSourceUpdateMode.Never));
                rdoParent.DataBindings.Add(new Binding("Checked", dgvRouteParent.DataSource, "isMatch", true, DataSourceUpdateMode.Never));
            }
        }
        void ClearData()
        {
            txtName.DataBindings.Clear();
            cboBusStopBegin.DataBindings.Clear();
            cboBusStopEnd.DataBindings.Clear();
            rdoParent.DataBindings.Clear();
            txtName.Clear();
            cboBusStopBegin.SelectedIndex = 0;
            cboBusStopEnd.SelectedIndex = 0;
            rdoChild.Checked = true;
        }
        void LoadDataParent()
        {
            var result = from route in db.BusRoutes select new {
                id = route.busRouteId,
                name = route.name,
                busStopBegin = route.BusStop.name,
                busStopEnd = route.BusStop1.name,
                type = (route.isMatch) ? "Tuyến cha" : "Tuyến phần tử",
                isMatch = route.isMatch
            };
            dgvRouteParent.DataSource = result.ToList();
            dgvRouteParent.Columns["isMatch"].Visible = false;
        }
        void LoadDataChild()
        {
            int id = Convert.ToInt32(dgvRouteParent.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            if(id > 0)
            {
                var result = from match in db.BusRouteMatches
                             where match.busRouteIdParent == id
                             select new { 
                                 order = match.numericalOrder,
                                 name = match.BusRoute1.name
                             };
                 dgvRouteChild.DataSource = result.ToList();
            }
        }
        void LoadMap()
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            double a = 10.993353;
            double b = 106.660749;
            map.Position = new GMap.NET.PointLatLng(a, b);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 15;
        }
        void LoadPoint()
        {
            map.Overlays.Clear();
            GMapOverlay markers = new GMapOverlay("markers");
            var result = (from busStop in db.BusStops
                          select new
                          {
                              x = busStop.x,
                              y = busStop.y,
                              name = busStop.name
                          }).ToList();
            foreach (var item in result)
            {
                PointLatLng point = new PointLatLng(item.x, item.y);
                GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red);
                marker.ToolTipText = $"{item.name}\nToạ độ x: {item.x} \n Toạ độ y: {item.y}";

                var toolTip = new GMapToolTip(marker);
                toolTip.Fill = new SolidBrush(Color.White);
                toolTip.Foreground = new SolidBrush(Color.Black);
                toolTip.Offset = new Point(0, 0);
                marker.ToolTip = toolTip;

                markers.Markers.Add(marker);
            }
            map.Overlays.Add(markers);
            map.Refresh();
        }
        GMapOverlay overlayRoute = new GMapOverlay();
        void LoadRoute()
        {
            if (map.Overlays.Count > 0)
            {
                LoadBusStop();
                overlayRoute.Clear();
            }
            int id = 0;
            if (dgvRouteParent.SelectedCells.Count > 0)
            {
                id = Convert.ToInt32(dgvRouteParent.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                BusRoute route = db.BusRoutes.Find(id);
                if (route.isMatch)
                {
                    var list = (from match in db.BusRouteMatches
                                where match.busRouteIdParent == id
                                select match).ToList();
                    foreach (BusRouteMatch item in list)
                    {
                        BusRoute routeChild = db.BusRoutes.Find(item.busRouteIdChild);
                        BusStop begin = db.BusStops.Find(routeChild.busStopIdBegin);
                        BusStop end = db.BusStops.Find(routeChild.busStopIdEnd);
                        MapRoute routes = OpenStreetMapProvider.Instance.GetRoute(new PointLatLng(begin.x, begin.y), new PointLatLng(end.x, end.y), false, false, 15);
                        GMapRoute r = new GMapRoute(routes.Points, route.name);
                        r.Stroke = new Pen(Color.Red, 1);

                        overlayRoute.Routes.Add(r);
                        map.Overlays.Add(overlayRoute);
                        map.UpdateRouteLocalPosition(r);
                    }
                }
                else
                {
                    BusStop begin = db.BusStops.Find(route.busStopIdBegin);
                    BusStop end = db.BusStops.Find(route.busStopIdEnd);
                    MapRoute routes = OpenStreetMapProvider.Instance.GetRoute(new PointLatLng(begin.x, begin.y), new PointLatLng(end.x, end.y), false, false, 15);
                    GMapRoute r = new GMapRoute(routes.Points, route.name);
                    r.Stroke = new Pen(Color.Red, 1);

                    overlayRoute.Routes.Add(r);
                    map.Overlays.Add(overlayRoute);

                    map.UpdateRouteLocalPosition(r);
                }
            }
        }
        void LoadBusStop()
        {
            var result = (from busStop in db.BusStops select new { id = busStop.busStopId, name = busStop.name }).ToList();
            BindingList<Data> _cbo = new BindingList<Data>();
            BindingList<Data> _cbo1 = new BindingList<Data>();
            foreach (var item in result)
            {
                _cbo.Add(new Data { name = item.name, id = item.id });
                _cbo1.Add(new Data { name = item.name, id = item.id });
            }
            cboBusStopBegin.DataSource = _cbo;
            cboBusStopBegin.DisplayMember = "name";
            cboBusStopBegin.ValueMember = "id";
            cboBusStopEnd.DataSource = _cbo1;
            cboBusStopEnd.DisplayMember = "name";
            cboBusStopEnd.ValueMember = "id";
        }
        void AddRoute()
        {
            BusRoute route = new BusRoute()
            {
                name = txtName.Text,
                busStopIdBegin = Convert.ToInt32(cboBusStopBegin.SelectedValue),
                busStopIdEnd = Convert.ToInt32(cboBusStopEnd.SelectedValue),
                isMatch = (rdoParent.Checked) ? true : false,
            };
            db.BusRoutes.Add(route);
            db.SaveChanges();
            LoadDataParent();
        }
        void EditRoute()
        {
            int id = Convert.ToInt32(dgvRouteParent.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            BusRoute route = db.BusRoutes.Find(id);
            route.name = txtName.Text;
            route.busStopIdBegin = Convert.ToInt32(cboBusStopBegin.SelectedValue);
            route.busStopIdEnd = Convert.ToInt32(cboBusStopEnd.SelectedValue);
            route.isMatch = (rdoParent.Checked) ? true : false;
            db.SaveChanges();
            LoadDataParent();
        }
        void DeleteRoute()
        {
            int id = Convert.ToInt32(dgvRouteParent.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            BusRoute route = db.BusRoutes.Find(id);
            db.BusRoutes.Remove(route);
            db.SaveChanges();
            LoadDataParent();
        }
        bool FindRoute()
        {
            var result = db.BusRoutes
                        .Where(p => p.name == txtName.Text)
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
            btnSubmit.Text = "Thêm";
            txtName.ReadOnly = false;
            pnlForm.Visible = true;
        }

        private void btnMof_Click(object sender, EventArgs e)
        {
            AddBinding();
            btnSubmit.Text = "Chỉnh sửa";
            txtName.ReadOnly = true;
            pnlForm.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvRouteParent.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá tuyến này?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearData();
                    DeleteRoute();
                    MessageBox.Show("Xoá thành công");
                    pnlForm.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tuyến muốn xoá");
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
                    if(cboBusStopBegin.SelectedValue == cboBusStopEnd.SelectedValue)
                    {
                        MessageBox.Show("Ai lại chưa bắt đầu đã kết thúc =))))");
                        return;
                    }
                    if (FindRoute())
                    {
                        MessageBox.Show("Tên tuyến này đã tồn tại");
                        txtName.BackColor = Color.OrangeRed;
                        txtName.Focus();
                    }
                    else
                    {
                        AddRoute();
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
                if (cboBusStopBegin.SelectedValue == cboBusStopEnd.SelectedValue)
                {
                    MessageBox.Show("Ai lại chưa bắt đầu đã kết thúc =))))");
                    return;
                }
                EditRoute();
                MessageBox.Show("Chỉnh sửa thành công");
                ClearData();
                pnlForm.Visible = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void dgvRouteParent_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoad && dgvRouteParent.SelectedRows.Count > 0)
            {
                LoadRoute();
                bool isMatch = Convert.ToBoolean(dgvRouteParent.SelectedCells[0].OwningRow.Cells["isMatch"].Value.ToString());
                btnManage.Visible = isMatch;
                LoadDataChild();
            }
        }

        private void frmRoute_Load(object sender, EventArgs e)
        {
            isLoad = true;   
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvRouteParent.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            frmRouteChildManage frm = new frmRouteChildManage(id);
            frm.ShowDialog();  
        }

        private void frmRoute_Activated(object sender, EventArgs e)
        {
            LoadMap();
            LoadPoint();
        }
        #endregion
    }
}
