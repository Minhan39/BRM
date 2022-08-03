namespace BRM_GUI
{
    partial class frmHandlingViolation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHandlingViolation));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMod = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDel = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.cboCurrencyUnit = new System.Windows.Forms.ComboBox();
            this.txtPenaltyRate = new System.Windows.Forms.TextBox();
            this.txtViolationLevel = new System.Windows.Forms.TextBox();
            this.dtpDateOfViolation = new System.Windows.Forms.DateTimePicker();
            this.txtNumberOfMinutes = new System.Windows.Forms.TextBox();
            this.txtDispatchNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboDistributor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHadlingViolation = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHadlingViolation)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1451, 28);
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
            this.pnlForm.Controls.Add(this.rtbBody);
            this.pnlForm.Controls.Add(this.cboCurrencyUnit);
            this.pnlForm.Controls.Add(this.txtPenaltyRate);
            this.pnlForm.Controls.Add(this.txtViolationLevel);
            this.pnlForm.Controls.Add(this.dtpDateOfViolation);
            this.pnlForm.Controls.Add(this.txtNumberOfMinutes);
            this.pnlForm.Controls.Add(this.txtDispatchNumber);
            this.pnlForm.Controls.Add(this.label10);
            this.pnlForm.Controls.Add(this.cboDistributor);
            this.pnlForm.Controls.Add(this.label9);
            this.pnlForm.Controls.Add(this.cboType);
            this.pnlForm.Controls.Add(this.label8);
            this.pnlForm.Controls.Add(this.cboBus);
            this.pnlForm.Controls.Add(this.label7);
            this.pnlForm.Controls.Add(this.label6);
            this.pnlForm.Controls.Add(this.label5);
            this.pnlForm.Controls.Add(this.label4);
            this.pnlForm.Controls.Add(this.label3);
            this.pnlForm.Controls.Add(this.label2);
            this.pnlForm.Controls.Add(this.label1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlForm.Location = new System.Drawing.Point(0, 28);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1451, 365);
            this.pnlForm.TabIndex = 1;
            this.pnlForm.VisibleChanged += new System.EventHandler(this.pnlForm_VisibleChanged);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(170, 303);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(158, 45);
            this.btnRetry.TabIndex = 21;
            this.btnRetry.Text = "Xoá trắng";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(16, 303);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(148, 45);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Hoàn thành";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(170, 156);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(1171, 138);
            this.rtbBody.TabIndex = 19;
            this.rtbBody.Text = "";
            // 
            // cboCurrencyUnit
            // 
            this.cboCurrencyUnit.FormattingEnabled = true;
            this.cboCurrencyUnit.Items.AddRange(new object[] {
            "VNĐ",
            "USD",
            "%"});
            this.cboCurrencyUnit.Location = new System.Drawing.Point(669, 120);
            this.cboCurrencyUnit.Name = "cboCurrencyUnit";
            this.cboCurrencyUnit.Size = new System.Drawing.Size(330, 31);
            this.cboCurrencyUnit.TabIndex = 18;
            // 
            // txtPenaltyRate
            // 
            this.txtPenaltyRate.Location = new System.Drawing.Point(669, 84);
            this.txtPenaltyRate.Name = "txtPenaltyRate";
            this.txtPenaltyRate.Size = new System.Drawing.Size(330, 30);
            this.txtPenaltyRate.TabIndex = 17;
            // 
            // txtViolationLevel
            // 
            this.txtViolationLevel.Location = new System.Drawing.Point(669, 48);
            this.txtViolationLevel.Name = "txtViolationLevel";
            this.txtViolationLevel.Size = new System.Drawing.Size(330, 30);
            this.txtViolationLevel.TabIndex = 16;
            // 
            // dtpDateOfViolation
            // 
            this.dtpDateOfViolation.Location = new System.Drawing.Point(171, 120);
            this.dtpDateOfViolation.Name = "dtpDateOfViolation";
            this.dtpDateOfViolation.Size = new System.Drawing.Size(330, 30);
            this.dtpDateOfViolation.TabIndex = 15;
            // 
            // txtNumberOfMinutes
            // 
            this.txtNumberOfMinutes.Location = new System.Drawing.Point(171, 84);
            this.txtNumberOfMinutes.Name = "txtNumberOfMinutes";
            this.txtNumberOfMinutes.Size = new System.Drawing.Size(330, 30);
            this.txtNumberOfMinutes.TabIndex = 14;
            // 
            // txtDispatchNumber
            // 
            this.txtDispatchNumber.Location = new System.Drawing.Point(171, 48);
            this.txtDispatchNumber.Name = "txtDispatchNumber";
            this.txtDispatchNumber.Size = new System.Drawing.Size(330, 30);
            this.txtDispatchNumber.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Đơn vị:";
            // 
            // cboDistributor
            // 
            this.cboDistributor.FormattingEnabled = true;
            this.cboDistributor.Location = new System.Drawing.Point(1101, 10);
            this.cboDistributor.Name = "cboDistributor";
            this.cboDistributor.Size = new System.Drawing.Size(260, 31);
            this.cboDistributor.TabIndex = 11;
            this.cboDistributor.SelectedIndexChanged += new System.EventHandler(this.cboDistributor_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(906, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "Lọc theo nhà cung cấp:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(669, 10);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(231, 31);
            this.cboType.TabIndex = 9;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Lọc theo kiểu xe:";
            // 
            // cboBus
            // 
            this.cboBus.FormattingEnabled = true;
            this.cboBus.Location = new System.Drawing.Point(171, 10);
            this.cboBus.Name = "cboBus";
            this.cboBus.Size = new System.Drawing.Size(330, 31);
            this.cboBus.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số công văn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mức xử phạt:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mức vi phạm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội dung vi phạm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày vi phạm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số biên bản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xe vi phạm:";
            // 
            // dgvHadlingViolation
            // 
            this.dgvHadlingViolation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHadlingViolation.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHadlingViolation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHadlingViolation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHadlingViolation.GridColor = System.Drawing.SystemColors.Control;
            this.dgvHadlingViolation.Location = new System.Drawing.Point(0, 393);
            this.dgvHadlingViolation.Name = "dgvHadlingViolation";
            this.dgvHadlingViolation.RowHeadersWidth = 51;
            this.dgvHadlingViolation.RowTemplate.Height = 24;
            this.dgvHadlingViolation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHadlingViolation.Size = new System.Drawing.Size(1451, 278);
            this.dgvHadlingViolation.TabIndex = 3;
            // 
            // frmHandlingViolation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 671);
            this.Controls.Add(this.dgvHadlingViolation);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHandlingViolation";
            this.Text = "VI PHẠM";
            this.Load += new System.EventHandler(this.frmHandlingViolation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHadlingViolation)).EndInit();
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
        private System.Windows.Forms.ComboBox cboCurrencyUnit;
        private System.Windows.Forms.TextBox txtPenaltyRate;
        private System.Windows.Forms.TextBox txtViolationLevel;
        private System.Windows.Forms.DateTimePicker dtpDateOfViolation;
        private System.Windows.Forms.TextBox txtNumberOfMinutes;
        private System.Windows.Forms.TextBox txtDispatchNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboDistributor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboBus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.DataGridView dgvHadlingViolation;
    }
}