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
    public partial class frmPrintUser : Form
    {
        public frmPrintUser()
        {
            InitializeComponent();
        }

        public void PrintUser()
        {
            frmReportUser frmReportUser = new frmReportUser();
            foreach(DevExpress.XtraReports.Parameters.Parameter p in frmReportUser.Parameters)
                p.Visible = false;
            documentViewer1.DocumentSource = frmReportUser;
            frmReportUser.CreateDocument();
        }
    }
}
