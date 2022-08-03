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
    public partial class frmRouteChildManage : Form
    {
        BRM db = new BRM();
        private int id;
        public frmRouteChildManage(int id)
        {
            InitializeComponent();
            this.id = id;
            LoadData();
            LoadListExit();
            LoadListNoExit();
        }

        #region methods
        void LoadData()
        {
            BusRoute route = db.BusRoutes.Find(id);
            label1.Text = "Tuyến " + route.name;
        }
        void LoadListNoExit()
        {
            var result = from route in db.BusRoutes
                         where !route.isMatch && !db.BusRouteMatches.Any(brm => brm.busRouteIdParent == id && brm.busRouteIdChild == route.busRouteId)
                         select new
                         {
                             name = route.name,
                             id = route.busRouteId
                         };
            libNoExit.Items.Clear();
            foreach (var item in result)
            {
                libNoExit.Items.Add(item.name);
            }
        }
        void LoadListExit()
        {
            var result = from match in db.BusRouteMatches
                         where match.busRouteIdParent == id
                         select new { 
                            name = match.BusRoute1.name,
                            id = match.BusRoute1.busRouteId
                         };
            libExit.Items.Clear();
            foreach(var item in result)
            {
                libExit.Items.Add(item.name);
            }
        }
        void Save()
        {
            DeleteList();
            AddList();
            LoadListExit();
            LoadListNoExit();
        }
        void AddList()
        {
            List<BusRoute> list = new List<BusRoute>();
            List<string> listExit = libExit.Items.Cast<string>().ToList();
            list = (from route in db.BusRoutes where listExit.Contains(route.name) select route).ToList();
            int order = 0;
            foreach(var item in list)
            {
                order++;
                BusRouteMatch match = new BusRouteMatch()
                {
                    busRouteIdParent = id,
                    busRouteIdChild = item.busRouteId,
                    numericalOrder = order
                };
                db.BusRouteMatches.Add(match);
            }
            db.SaveChanges();
        }
        void DeleteList()
        {
            List<BusRouteMatch> list = new List<BusRouteMatch>();
            list = (from match in db.BusRouteMatches
                    where match.busRouteIdParent == id
                    select match).ToList();
            foreach(var item in list)
            {
                db.BusRouteMatches.Remove(item);
            }
            db.SaveChanges();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (libNoExit.SelectedItems.Count > 0)
            {
                libExit.Items.Add(libNoExit.SelectedItem);
                libNoExit.Items.Remove(libNoExit.SelectedItem);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            while (libNoExit.Items.Count > 0)
            {
                libExit.Items.Add(libNoExit.Items[0]);
                libNoExit.Items.Remove(libNoExit.Items[0]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (libExit.SelectedItems.Count > 0)
            {
                libNoExit.Items.Add(libExit.SelectedItem);
                libExit.Items.Remove(libExit.SelectedItem);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            while (libExit.Items.Count > 0)
            {
                libNoExit.Items.Add(libExit.Items[0]);
                libExit.Items.Remove(libExit.Items[0]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(libExit.Items.Count < 2)
            {
                MessageBox.Show("Bạn phải có ít nhất 2 tuyến phần tử để tạo thành tuyến cha");
            }
            else
            {
                Save();
            }
        }
    }
}
