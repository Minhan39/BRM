using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool admin;
        public frmMain(bool admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmUser = Application.OpenForms.OfType<frmUser>().FirstOrDefault();
            if (frmUser == null)
            {
                frmUser = new frmUser();
                frmUser.MdiParent = this;
                frmUser.Show();
            }
            else
            {
                frmUser.Focus();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmType = Application.OpenForms.OfType<frmType>().FirstOrDefault();
            if (frmType == null)
            {
                frmType = new frmType();
                frmType.MdiParent = this;
                frmType.Show();
            }
            else
            {
                frmType.Focus();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmGuide = Application.OpenForms.OfType<frmGuide>().FirstOrDefault();
            if (frmGuide == null)
            {
                frmGuide = new frmGuide();
                frmGuide.MdiParent = this;
                frmGuide.Show();
            }
            else
            {
                frmGuide.Focus();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmDistributor = Application.OpenForms.OfType<frmDistributor>().FirstOrDefault();
            if (frmDistributor == null)
            {
                frmDistributor = new frmDistributor();
                frmDistributor.MdiParent = this;
                frmDistributor.Show();
            }
            else
            {
                frmDistributor.Focus();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmBus = Application.OpenForms.OfType<frmBus>().FirstOrDefault();
            if (frmBus == null)
            {
                frmBus = new frmBus();
                frmBus.MdiParent = this;
                frmBus.Show();
            }
            else
            {
                frmBus.Focus();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmHandlingViolation = Application.OpenForms.OfType<frmHandlingViolation>().FirstOrDefault();
            if (frmHandlingViolation == null)
            {
                frmHandlingViolation = new frmHandlingViolation();
                frmHandlingViolation.MdiParent = this;
                frmHandlingViolation.Show();
            }
            else
            {
                frmHandlingViolation.Focus();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmBusStop = Application.OpenForms.OfType<frmBusStop>().FirstOrDefault();
            if (frmBusStop == null)
            {
                frmBusStop = new frmBusStop();
                frmBusStop.MdiParent = this;
                frmBusStop.Show();
            }
            else
            {
                frmBusStop.Focus();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmRoute = Application.OpenForms.OfType<frmRoute>().FirstOrDefault();
            if (frmRoute == null)
            {
                frmRoute = new frmRoute();
                frmRoute.MdiParent = this;
                frmRoute.Show();
            }
            else
            {
                frmRoute.Focus();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmBusConnectingRoute = Application.OpenForms.OfType<frmBusConnectingRoute>().FirstOrDefault();
            if (frmBusConnectingRoute == null)
            {
                frmBusConnectingRoute = new frmBusConnectingRoute();
                frmBusConnectingRoute.MdiParent = this;
                frmBusConnectingRoute.Show();
            }
            else
            {
                frmBusConnectingRoute.Focus();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmMap = Application.OpenForms.OfType<frmMap>().FirstOrDefault();
            if (frmMap == null)
            {
                frmMap = new frmMap();
                frmMap.MdiParent = this;
                frmMap.Show();
            }
            else
            {
                frmMap.Focus();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (!admin)
            {
                btnUser.Enabled = false;
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}