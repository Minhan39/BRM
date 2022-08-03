namespace BRM_GUI
{
    partial class frmRoute
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoute));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMof = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvRouteParent = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRouteChild = new System.Windows.Forms.DataGridView();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboBusStopEnd = new System.Windows.Forms.ComboBox();
            this.cboBusStopBegin = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grbRoute = new System.Windows.Forms.GroupBox();
            this.rdoParent = new System.Windows.Forms.RadioButton();
            this.rdoChild = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteParent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteChild)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.grbRoute.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnMof,
            this.btnDel,
            this.btnManage,
            this.btnClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1451, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 27);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMof
            // 
            this.btnMof.Name = "btnMof";
            this.btnMof.Size = new System.Drawing.Size(52, 27);
            this.btnMof.Text = "Sửa";
            this.btnMof.Click += new System.EventHandler(this.btnMof_Click);
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(53, 27);
            this.btnDel.Text = "Xoá";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnManage
            // 
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(196, 27);
            this.btnManage.Text = "Quản lý tuyến phần tử";
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(143, 27);
            this.btnClose.Text = "Đóng biểu mẫu";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvRouteParent);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgvRouteChild);
            this.panel1.Controls.Add(this.pnlForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 557);
            this.panel1.TabIndex = 3;
            // 
            // dgvRouteParent
            // 
            this.dgvRouteParent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRouteParent.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRouteParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRouteParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRouteParent.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRouteParent.Location = new System.Drawing.Point(0, 175);
            this.dgvRouteParent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRouteParent.Name = "dgvRouteParent";
            this.dgvRouteParent.RowHeadersWidth = 51;
            this.dgvRouteParent.RowTemplate.Height = 24;
            this.dgvRouteParent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRouteParent.Size = new System.Drawing.Size(714, 195);
            this.dgvRouteParent.TabIndex = 6;
            this.dgvRouteParent.SelectionChanged += new System.EventHandler(this.dgvRouteParent_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 370);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 31);
            this.panel2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(714, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "CÁC TUYẾN PHẦN TỬ (NẾU CÓ)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRouteChild
            // 
            this.dgvRouteChild.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRouteChild.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRouteChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRouteChild.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRouteChild.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRouteChild.Location = new System.Drawing.Point(0, 401);
            this.dgvRouteChild.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRouteChild.Name = "dgvRouteChild";
            this.dgvRouteChild.RowHeadersWidth = 51;
            this.dgvRouteChild.RowTemplate.Height = 24;
            this.dgvRouteChild.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRouteChild.Size = new System.Drawing.Size(714, 156);
            this.dgvRouteChild.TabIndex = 4;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.btnSubmit);
            this.pnlForm.Controls.Add(this.cboBusStopEnd);
            this.pnlForm.Controls.Add(this.cboBusStopBegin);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.grbRoute);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(714, 175);
            this.pnlForm.TabIndex = 0;
            this.pnlForm.VisibleChanged += new System.EventHandler(this.pnlForm_VisibleChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(17, 116);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 42);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Hoàn thành";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboBusStopEnd
            // 
            this.cboBusStopEnd.FormattingEnabled = true;
            this.cboBusStopEnd.Location = new System.Drawing.Point(144, 79);
            this.cboBusStopEnd.Name = "cboBusStopEnd";
            this.cboBusStopEnd.Size = new System.Drawing.Size(357, 31);
            this.cboBusStopEnd.TabIndex = 6;
            // 
            // cboBusStopBegin
            // 
            this.cboBusStopBegin.FormattingEnabled = true;
            this.cboBusStopBegin.Location = new System.Drawing.Point(144, 42);
            this.cboBusStopBegin.Name = "cboBusStopBegin";
            this.cboBusStopBegin.Size = new System.Drawing.Size(357, 31);
            this.cboBusStopBegin.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(144, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 30);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // grbRoute
            // 
            this.grbRoute.Controls.Add(this.rdoParent);
            this.grbRoute.Controls.Add(this.rdoChild);
            this.grbRoute.Location = new System.Drawing.Point(518, 6);
            this.grbRoute.Name = "grbRoute";
            this.grbRoute.Size = new System.Drawing.Size(180, 110);
            this.grbRoute.TabIndex = 3;
            this.grbRoute.TabStop = false;
            this.grbRoute.Text = "Loại tuyến";
            // 
            // rdoParent
            // 
            this.rdoParent.AutoSize = true;
            this.rdoParent.Location = new System.Drawing.Point(21, 62);
            this.rdoParent.Name = "rdoParent";
            this.rdoParent.Size = new System.Drawing.Size(109, 27);
            this.rdoParent.TabIndex = 1;
            this.rdoParent.TabStop = true;
            this.rdoParent.Text = "Tuyến cha";
            this.rdoParent.UseVisualStyleBackColor = true;
            // 
            // rdoChild
            // 
            this.rdoChild.AutoSize = true;
            this.rdoChild.Location = new System.Drawing.Point(21, 29);
            this.rdoChild.Name = "rdoChild";
            this.rdoChild.Size = new System.Drawing.Size(142, 27);
            this.rdoChild.TabIndex = 0;
            this.rdoChild.TabStop = true;
            this.rdoChild.Text = "Tuyến phần tử";
            this.rdoChild.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạm kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạm bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tuyến:";
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(714, 33);
            this.map.Margin = new System.Windows.Forms.Padding(4);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(737, 557);
            this.map.TabIndex = 4;
            this.map.Zoom = 0D;
            // 
            // frmRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 590);
            this.Controls.Add(this.map);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRoute";
            this.Text = "TUYẾN XE";
            this.Activated += new System.EventHandler(this.frmRoute_Activated);
            this.Load += new System.EventHandler(this.frmRoute_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteParent)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRouteChild)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.grbRoute.ResumeLayout(false);
            this.grbRoute.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnMof;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlForm;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvRouteChild;
        private System.Windows.Forms.DataGridView dgvRouteParent;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cboBusStopEnd;
        private System.Windows.Forms.ComboBox cboBusStopBegin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grbRoute;
        private System.Windows.Forms.RadioButton rdoParent;
        private System.Windows.Forms.RadioButton rdoChild;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem btnManage;
    }
}