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
    public partial class frmBusStop : Form
    {
        BRM db = new BRM();
        public frmBusStop()
        {
            InitializeComponent();
            LoadData();
            LoadMap();
            LoadPoint();
            pnlForm.Visible = false;
            btnClose.Visible = false;
        }

        #region methods
        void AddBinding()
        {
            if(txtName.DataBindings.Count < 1)
            {
                txtName.DataBindings.Add(new Binding("Text", dgvBusStop.DataSource, "name", true, DataSourceUpdateMode.Never));
                txtX.DataBindings.Add(new Binding("Text", dgvBusStop.DataSource, "x", true, DataSourceUpdateMode.Never));
                txtY.DataBindings.Add(new Binding("Text", dgvBusStop.DataSource, "y", true, DataSourceUpdateMode.Never));
            }
        }
        void ClearData()
        {
            txtName.DataBindings.Clear();
            txtX.DataBindings.Clear();
            txtY.DataBindings.Clear();
            txtName.Clear();
            txtX.Clear();
            txtY.Clear();
        }
        void LoadData()
        {
            var result = from busStop in db.BusStops select new { 
                id = busStop.busStopId,
                name = busStop.name,
                x = busStop.x,
                y = busStop.y
            };
            dgvBusStop.DataSource = result.ToList();
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
            var result = (from busStop in db.BusStops select new { 
                x = busStop.x, y = busStop.y, name = busStop.name
                }).ToList();
            foreach(var item in result)
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
        void AddBusStop()
        {
            BusStop model = new BusStop()
            {
                name = txtName.Text,
                x = Convert.ToDouble(txtX.Text),
                y = Convert.ToDouble(txtY.Text)
            };
            db.BusStops.Add(model);
            db.SaveChanges();
            LoadData();
            LoadPoint();
        }
        void EditBusStop()
        {
            int id = Convert.ToInt32(dgvBusStop.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            BusStop model = db.BusStops.Find(id);
            model.name = txtName.Text;
            model.x = Convert.ToDouble(txtX.Text);
            model.y = Convert.ToDouble(txtY.Text);
            db.SaveChanges();
            LoadData();
            LoadPoint();
        }
        void DeleteBusStop()
        {
            int id = Convert.ToInt32(dgvBusStop.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
            if (id > 0)
            {
                BusStop model = db.BusStops.Find(id);
                db.BusStops.Remove(model);
                db.SaveChanges();
                LoadData();
                LoadPoint();
            }
        }

        bool FindBusStop()
        {
            var result = db.BusStops
                        .Where(p => p.name == txtName.Text)
                        .Count();
            if (result > 0)
                return true;
            return false;
        }
        #endregion

        #region events
        private void frmBusStop_Activated(object sender, EventArgs e)
        {
            LoadMap();
            LoadPoint();
        }
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
            if (dgvBusStop.SelectedCells.Count > 0)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xoá trạm này?", "THÔNTG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClearData();
                    DeleteBusStop();
                    MessageBox.Show("Xoá thành công");
                    pnlForm.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trạm muốn xoá");
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
                if (txtName.Text != String.Empty && txtX.Text != String.Empty && txtY.Text != String.Empty)
                {
                    if (FindBusStop())
                    {
                        MessageBox.Show("Tên trạm này đã tồn tại");
                        txtName.BackColor = Color.OrangeRed;
                        txtName.Focus();
                    }
                    else
                    {
                        AddBusStop();
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
                EditBusStop();
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
