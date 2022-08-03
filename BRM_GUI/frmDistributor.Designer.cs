namespace BRM_GUI
{
    partial class frmDistributor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDistributor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMod = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChart = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDistributor = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBus = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnMod,
            this.btnDel,
            this.btnChart,
            this.btnClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 24);
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMod
            // 
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(48, 24);
            this.btnMod.Text = "Sửa";
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnDel
            // 
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(49, 24);
            this.btnDel.Text = "Xoá";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnChart
            // 
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(74, 24);
            this.btnChart.Text = "Biểu đồ";
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 24);
            this.btnClose.Text = "Đóng biểu mẫu";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.btnRetry);
            this.pnlForm.Controls.Add(this.btnSubmit);
            this.pnlForm.Controls.Add(this.rtbDescription);
            this.pnlForm.Controls.Add(this.txtContact);
            this.pnlForm.Controls.Add(this.txtAddress);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 28);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1266, 191);
            this.pnlForm.TabIndex = 1;
            this.pnlForm.VisibleChanged += new System.EventHandler(this.pnlForm_VisibleChanged);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(142, 130);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(131, 45);
            this.btnRetry.TabIndex = 9;
            this.btnRetry.Text = "Xoá trắng";
            this.btnRetry.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 130);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 45);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Hoàn thành";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(674, 20);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(504, 99);
            this.rtbDescription.TabIndex = 7;
            this.rtbDescription.Text = "";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(174, 89);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(385, 30);
            this.txtContact.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(174, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(385, 30);
            this.txtAddress.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(174, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(385, 30);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(590, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Liên hệ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDistributor);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 366);
            this.panel1.TabIndex = 2;
            // 
            // dgvDistributor
            // 
            this.dgvDistributor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDistributor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDistributor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistributor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDistributor.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDistributor.Location = new System.Drawing.Point(0, 30);
            this.dgvDistributor.Name = "dgvDistributor";
            this.dgvDistributor.RowHeadersWidth = 51;
            this.dgvDistributor.RowTemplate.Height = 24;
            this.dgvDistributor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDistributor.Size = new System.Drawing.Size(649, 336);
            this.dgvDistributor.TabIndex = 4;
            this.dgvDistributor.SelectionChanged += new System.EventHandler(this.dgvDistributor_SelectionChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(649, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "DANH SÁCH NHÀ CUNG CẤP";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBus);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(649, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 366);
            this.panel2.TabIndex = 3;
            // 
            // dgvBus
            // 
            this.dgvBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBus.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBus.Location = new System.Drawing.Point(10, 30);
            this.dgvBus.Name = "dgvBus";
            this.dgvBus.RowHeadersWidth = 51;
            this.dgvBus.RowTemplate.Height = 24;
            this.dgvBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBus.Size = new System.Drawing.Size(607, 336);
            this.dgvBus.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(607, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "CÁC XE THUỘC NHÀ CUNG CẤP ĐANG CHỌN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 366);
            this.panel4.TabIndex = 1;
            // 
            // frmDistributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 585);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDistributor";
            this.Text = "NHÀ CUNG CẤP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributor)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnMod;
        private System.Windows.Forms.ToolStripMenuItem btnDel;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDistributor;
        private System.Windows.Forms.DataGridView dgvBus;
        private System.Windows.Forms.ToolStripMenuItem btnChart;
    }
}