namespace BRM_GUI
{
    partial class frmBus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBus));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMod = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboDistributor = new System.Windows.Forms.ComboBox();
            this.txtSeats = new System.Windows.Forms.TextBox();
            this.txtTaxCode = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBus = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlForm.SuspendLayout();
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
            this.btnClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 28);
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
            this.pnlForm.Controls.Add(this.cboType);
            this.pnlForm.Controls.Add(this.cboDistributor);
            this.pnlForm.Controls.Add(this.txtSeats);
            this.pnlForm.Controls.Add(this.txtTaxCode);
            this.pnlForm.Controls.Add(this.txtLicensePlate);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 28);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1171, 174);
            this.pnlForm.TabIndex = 1;
            this.pnlForm.VisibleChanged += new System.EventHandler(this.pnlForm_VisibleChanged);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(156, 119);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(134, 40);
            this.btnRetry.TabIndex = 11;
            this.btnRetry.Text = "Xoá trắng";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 119);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 40);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Hoàn thành";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cboType
            // 
            this.cboType.DisplayMember = "name";
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(676, 47);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(367, 31);
            this.cboType.TabIndex = 9;
            this.cboType.ValueMember = "id";
            // 
            // cboDistributor
            // 
            this.cboDistributor.DisplayMember = "name";
            this.cboDistributor.FormattingEnabled = true;
            this.cboDistributor.Location = new System.Drawing.Point(676, 10);
            this.cboDistributor.Name = "cboDistributor";
            this.cboDistributor.Size = new System.Drawing.Size(367, 31);
            this.cboDistributor.TabIndex = 8;
            this.cboDistributor.ValueMember = "id";
            // 
            // txtSeats
            // 
            this.txtSeats.Location = new System.Drawing.Point(148, 83);
            this.txtSeats.Name = "txtSeats";
            this.txtSeats.Size = new System.Drawing.Size(367, 30);
            this.txtSeats.TabIndex = 7;
            // 
            // txtTaxCode
            // 
            this.txtTaxCode.Location = new System.Drawing.Point(148, 47);
            this.txtTaxCode.Name = "txtTaxCode";
            this.txtTaxCode.Size = new System.Drawing.Size(367, 30);
            this.txtTaxCode.TabIndex = 6;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(148, 11);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(367, 30);
            this.txtLicensePlate.TabIndex = 5;
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.txtLicensePlate_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Loại xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhà cung cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng ghế:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số thuế:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biển số xe:";
            // 
            // dgvBus
            // 
            this.dgvBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBus.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBus.Location = new System.Drawing.Point(0, 202);
            this.dgvBus.Name = "dgvBus";
            this.dgvBus.RowHeadersWidth = 51;
            this.dgvBus.RowTemplate.Height = 24;
            this.dgvBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBus.Size = new System.Drawing.Size(1171, 258);
            this.dgvBus.TabIndex = 3;
            // 
            // frmBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 460);
            this.Controls.Add(this.dgvBus);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBus";
            this.Text = "XE BUÝT";
            this.Load += new System.EventHandler(this.frmBus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.ComboBox cboDistributor;
        private System.Windows.Forms.TextBox txtSeats;
        private System.Windows.Forms.TextBox txtTaxCode;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBus;
    }
}