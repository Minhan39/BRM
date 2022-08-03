namespace BRM_GUI
{
    partial class frmRouteChildManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRouteChildManage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.libNoExit = new System.Windows.Forms.ListBox();
            this.libExit = new System.Windows.Forms.ListBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tuyến abc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách tuyến phần tử còn lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách tuyến phần tử thuộc tuyến trên";
            // 
            // libNoExit
            // 
            this.libNoExit.FormattingEnabled = true;
            this.libNoExit.ItemHeight = 23;
            this.libNoExit.Location = new System.Drawing.Point(16, 77);
            this.libNoExit.Name = "libNoExit";
            this.libNoExit.Size = new System.Drawing.Size(332, 372);
            this.libNoExit.TabIndex = 3;
            // 
            // libExit
            // 
            this.libExit.FormattingEnabled = true;
            this.libExit.ItemHeight = 23;
            this.libExit.Location = new System.Drawing.Point(423, 77);
            this.libExit.Name = "libExit";
            this.libExit.Size = new System.Drawing.Size(332, 372);
            this.libExit.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(356, 89);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(54, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAll.ImageOptions.Image")));
            this.btnAddAll.Location = new System.Drawing.Point(357, 144);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(54, 44);
            this.btnAddAll.TabIndex = 6;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.Location = new System.Drawing.Point(357, 202);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(55, 44);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveAll.ImageOptions.Image")));
            this.btnRemoveAll.Location = new System.Drawing.Point(357, 264);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(10);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(55, 44);
            this.btnRemoveAll.TabIndex = 8;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(357, 330);
            this.btnSave.Margin = new System.Windows.Forms.Padding(12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 44);
            this.btnSave.TabIndex = 9;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmRouteChildManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 469);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.libExit);
            this.Controls.Add(this.libNoExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRouteChildManage";
            this.Text = "QUẢN LÝ TUYẾN PHẦN TỬ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox libNoExit;
        private System.Windows.Forms.ListBox libExit;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnAddAll;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnRemoveAll;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}