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
    public partial class frmMap : Form
    {
        BRM db = new BRM();
        public frmMap()
        {
            InitializeComponent();
            LoadMap();
            LoadPoint();
            LoadRoute();
        }

        #region methods
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
        private Random rnd = new Random();
        void LoadRoute()
        {
            var result = (from route in db.BusRoutes where route.isMatch select route).ToList();
            foreach(BusRoute route in result)
            {
                if (route.isMatch)
                {
                    var list = (from match in db.BusRouteMatches
                                where match.busRouteIdParent == route.busRouteId
                                select match).ToList();
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    foreach (BusRouteMatch item in list)
                    {
                        BusRoute routeChild = db.BusRoutes.Find(item.busRouteIdChild);
                        BusStop begin = db.BusStops.Find(routeChild.busStopIdBegin);
                        BusStop end = db.BusStops.Find(routeChild.busStopIdEnd);
                        MapRoute routes = OpenStreetMapProvider.Instance.GetRoute(new PointLatLng(begin.x, begin.y), new PointLatLng(end.x, end.y), false, false, 15);
                        GMapRoute r = new GMapRoute(routes.Points, route.name);
                        r.Stroke = new Pen(randomColor, 2);

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
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            map.Zoom += 1;
            map.Refresh();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            map.Zoom -= 1;
            map.Refresh();
        }
    }
}
