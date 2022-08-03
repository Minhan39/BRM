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
    public partial class frmChartDistributor : Form
    {
        BRM db = new BRM();
        public frmChartDistributor()
        {
            InitializeComponent();
        }

        private void fillChart()
        {
            var result = (from bus in db.Buses
                          group bus by new { bus.BusDistributor.name } into gr
                          select new
                          {
                              gr.Key.name,
                              num = gr.Count()
                          }).ToList();
            foreach(var item in result)
            {
                chart1.Series["Số lượng xe"].Points.AddXY(item.name, item.num);
            }
        }

        private void frmChartDistributor_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
