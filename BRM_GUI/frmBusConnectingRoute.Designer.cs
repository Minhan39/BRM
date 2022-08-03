namespace BRM_GUI
{
    partial class frmBusConnectingRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBusConnectingRoute));
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.cboDistributor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboBus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBus = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSelect = new System.Windows.Forms.DateTimePicker();
            this.dgvRoute = new System.Windows.Forms.DataGridView();
            this.pnlForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.btnSubmit);
            this.pnlForm.Controls.Add(this.dtpEnd);
            this.pnlForm.Controls.Add(this.dtpBegin);
            this.pnlForm.Controls.Add(this.cboDistributor);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.cboType);
            this.pnlForm.Controls.Add(this.cboRoute);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.cboBus);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1208, 119);
            this.pnlForm.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(677, 77);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(153, 30);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Thêm";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(510, 78);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(152, 30);
            this.dtpEnd.TabIndex = 11;
            // 
            // dtpBegin
            // 
            this.dtpBegin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBegin.Location = new System.Drawing.Point(207, 78);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(152, 30);
            this.dtpBegin.TabIndex = 10;
            // 
            // cboDistributor
            // 
            this.cboDistributor.FormattingEnabled = true;
            this.cboDistributor.Location = new System.Drawing.Point(725, 41);
            this.cboDistributor.Name = "cboDistributor";
            this.cboDistributor.Size = new System.Drawing.Size(366, 31);
            this.cboDistributor.TabIndex = 9;
            this.cboDistributor.SelectedIndexChanged += new System.EventHandler(this.cboDistributor_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(505, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(211, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lọc xe theo nhà cung cấp:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(725, 4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(366, 31);
            this.cboType.TabIndex = 7;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // cboRoute
            // 
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(124, 41);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(366, 31);
            this.cboRoute.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lọc xe theo loại:";
            // 
            // cboBus
            // 
            this.cboBus.FormattingEnabled = true;
            this.cboBus.Location = new System.Drawing.Point(124, 4);
            this.cboBus.Name = "cboBus";
            this.cboBus.Size = new System.Drawing.Size(366, 31);
            this.cboBus.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dự kiến kết thúc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian bắt đầu chạy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn xe:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tuyến:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvBus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(736, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 405);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Xoá";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBus
            // 
            this.dgvBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBus.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBus.Location = new System.Drawing.Point(0, 45);
            this.dgvBus.Name = "dgvBus";
            this.dgvBus.RowHeadersWidth = 51;
            this.dgvBus.RowTemplate.Height = 24;
            this.dgvBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBus.Size = new System.Drawing.Size(472, 360);
            this.dgvBus.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(472, 45);
            this.label8.TabIndex = 5;
            this.label8.Text = "DANH SÁCH XE TRÊN TUYẾN";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(726, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 405);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(726, 45);
            this.label7.TabIndex = 4;
            this.label7.Text = "DANH SÁCH TUYẾN";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpSelect
            // 
            this.dtpSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpSelect.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelect.Location = new System.Drawing.Point(593, 128);
            this.dtpSelect.Name = "dtpSelect";
            this.dtpSelect.Size = new System.Drawing.Size(127, 30);
            this.dtpSelect.TabIndex = 13;
            this.dtpSelect.ValueChanged += new System.EventHandler(this.dtpSelect_ValueChanged);
            // 
            // dgvRoute
            // 
            this.dgvRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoute.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoute.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRoute.Location = new System.Drawing.Point(0, 164);
            this.dgvRoute.Name = "dgvRoute";
            this.dgvRoute.RowHeadersWidth = 51;
            this.dgvRoute.RowTemplate.Height = 24;
            this.dgvRoute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoute.Size = new System.Drawing.Size(726, 360);
            this.dgvRoute.TabIndex = 14;
            this.dgvRoute.SelectionChanged += new System.EventHandler(this.dgvRoute_SelectionChanged);
            // 
            // frmBusConnectingRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 524);
            this.Controls.Add(this.dgvRoute);
            this.Controls.Add(this.dtpSelect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlForm);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBusConnectingRoute";
            this.Text = "PHÂN PHỐI XE";
            this.Load += new System.EventHandler(this.frmBusConnectingRoute_Load);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.ComboBox cboDistributor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboRoute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboBus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSelect;
        private System.Windows.Forms.DataGridView dgvBus;
        private System.Windows.Forms.DataGridView dgvRoute;
        private System.Windows.Forms.Button button1;
    }
}