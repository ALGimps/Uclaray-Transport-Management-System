namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    partial class frmAdvancedTracking
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvancedTracking));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoading = new System.Windows.Forms.Label();
            this.dgvAdvancedTracking = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDriver = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHelper = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cboDriver = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboHelper = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelBatchAssign = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedTracking)).BeginInit();
            this.panelBatchAssign.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.dgvAdvancedTracking);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 469);
            this.panel1.TabIndex = 121;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(439, 209);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(148, 17);
            this.lblLoading.TabIndex = 118;
            this.lblLoading.Text = "Loading, please wait . . .";
            // 
            // dgvAdvancedTracking
            // 
            this.dgvAdvancedTracking.AllowUserToAddRows = false;
            this.dgvAdvancedTracking.AllowUserToDeleteRows = false;
            this.dgvAdvancedTracking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAdvancedTracking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdvancedTracking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdvancedTracking.BackgroundColor = System.Drawing.Color.White;
            this.dgvAdvancedTracking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdvancedTracking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAdvancedTracking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvancedTracking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdvancedTracking.ColumnHeadersHeight = 45;
            this.dgvAdvancedTracking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAdvancedTracking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnFirst,
            this.columnDesignation,
            this.columnContact,
            this.Column1,
            this.contact,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.colDriver,
            this.colHelper,
            this.Column6});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvancedTracking.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdvancedTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdvancedTracking.EnableHeadersVisualStyles = false;
            this.dgvAdvancedTracking.Location = new System.Drawing.Point(0, 0);
            this.dgvAdvancedTracking.Name = "dgvAdvancedTracking";
            this.dgvAdvancedTracking.RowHeadersVisible = false;
            this.dgvAdvancedTracking.RowTemplate.Height = 35;
            this.dgvAdvancedTracking.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdvancedTracking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdvancedTracking.Size = new System.Drawing.Size(1016, 469);
            this.dgvAdvancedTracking.StandardTab = true;
            this.dgvAdvancedTracking.TabIndex = 109;
            this.dgvAdvancedTracking.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdvancedTracking_CellContentClick);
            this.dgvAdvancedTracking.SelectionChanged += new System.EventHandler(this.dgvAdvancedTracking_SelectionChanged);
            // 
            // columnID
            // 
            this.columnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnID.FillWeight = 152.2843F;
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnID.Visible = false;
            this.columnID.Width = 60;
            // 
            // columnFirst
            // 
            this.columnFirst.FillWeight = 64F;
            this.columnFirst.HeaderText = "Delivery Date";
            this.columnFirst.MinimumWidth = 100;
            this.columnFirst.Name = "columnFirst";
            this.columnFirst.ReadOnly = true;
            // 
            // columnDesignation
            // 
            this.columnDesignation.FillWeight = 64F;
            this.columnDesignation.HeaderText = "Store Name";
            this.columnDesignation.MinimumWidth = 100;
            this.columnDesignation.Name = "columnDesignation";
            this.columnDesignation.ReadOnly = true;
            // 
            // columnContact
            // 
            this.columnContact.FillWeight = 64F;
            this.columnContact.HeaderText = "Location";
            this.columnContact.MinimumWidth = 100;
            this.columnContact.Name = "columnContact";
            this.columnContact.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Area";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // contact
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.contact.DefaultCellStyle = dataGridViewCellStyle3;
            this.contact.FillWeight = 34.79669F;
            this.contact.HeaderText = "Trip Assignment No.";
            this.contact.MinimumWidth = 100;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Truck Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Plate No.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Drops";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trips";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // colDriver
            // 
            this.colDriver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDriver.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.colDriver.HeaderText = "Driver";
            this.colDriver.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.colDriver.MinimumWidth = 100;
            this.colDriver.Name = "colDriver";
            // 
            // colHelper
            // 
            this.colHelper.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colHelper.HeaderText = "Helper";
            this.colHelper.MinimumWidth = 100;
            this.colHelper.Name = "colHelper";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Action";
            this.Column6.MinimumWidth = 95;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 95;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(-1, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 123;
            this.lblDate.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 124;
            this.label1.Text = "Advanced Tracking";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRecords.Location = new System.Drawing.Point(9, 584);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 17);
            this.lblRecords.TabIndex = 119;
            this.lblRecords.Text = "Records: 0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Assign.png");
            // 
            // cboDriver
            // 
            this.cboDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboDriver.BackColor = System.Drawing.Color.Transparent;
            this.cboDriver.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriver.FocusedColor = System.Drawing.Color.Empty;
            this.cboDriver.FocusedState.Parent = this.cboDriver;
            this.cboDriver.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboDriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboDriver.FormattingEnabled = true;
            this.cboDriver.HoverState.Parent = this.cboDriver;
            this.cboDriver.ItemHeight = 30;
            this.cboDriver.ItemsAppearance.Parent = this.cboDriver;
            this.cboDriver.Location = new System.Drawing.Point(17, 28);
            this.cboDriver.Name = "cboDriver";
            this.cboDriver.ShadowDecoration.Parent = this.cboDriver;
            this.cboDriver.Size = new System.Drawing.Size(140, 36);
            this.cboDriver.TabIndex = 125;
            this.cboDriver.SelectedIndexChanged += new System.EventHandler(this.cboDriver_SelectedIndexChanged);
            // 
            // cboHelper
            // 
            this.cboHelper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboHelper.BackColor = System.Drawing.Color.Transparent;
            this.cboHelper.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHelper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHelper.FocusedColor = System.Drawing.Color.Empty;
            this.cboHelper.FocusedState.Parent = this.cboHelper;
            this.cboHelper.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboHelper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboHelper.FormattingEnabled = true;
            this.cboHelper.HoverState.Parent = this.cboHelper;
            this.cboHelper.ItemHeight = 30;
            this.cboHelper.ItemsAppearance.Parent = this.cboHelper;
            this.cboHelper.Location = new System.Drawing.Point(163, 28);
            this.cboHelper.Name = "cboHelper";
            this.cboHelper.ShadowDecoration.Parent = this.cboHelper;
            this.cboHelper.Size = new System.Drawing.Size(140, 36);
            this.cboHelper.TabIndex = 125;
            this.cboHelper.SelectedIndexChanged += new System.EventHandler(this.cboHelper_SelectedIndexChanged);
            // 
            // panelBatchAssign
            // 
            this.panelBatchAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBatchAssign.Controls.Add(this.label3);
            this.panelBatchAssign.Controls.Add(this.label2);
            this.panelBatchAssign.Controls.Add(this.cboDriver);
            this.panelBatchAssign.Controls.Add(this.cboHelper);
            this.panelBatchAssign.Controls.Add(this.guna2Button1);
            this.panelBatchAssign.Location = new System.Drawing.Point(590, 41);
            this.panelBatchAssign.Name = "panelBatchAssign";
            this.panelBatchAssign.Size = new System.Drawing.Size(457, 67);
            this.panelBatchAssign.TabIndex = 126;
            this.panelBatchAssign.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 118;
            this.label3.Text = "Select Helper";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 118;
            this.label2.Text = "Select Driver";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Uclaray_Transport_Management_System.Properties.Resources.add_user_male_48px1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(328, 29);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(110, 35);
            this.guna2Button1.TabIndex = 122;
            this.guna2Button1.Text = "Assign";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.CheckedState.Parent = this.btnImport;
            this.btnImport.CustomImages.Parent = this.btnImport;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.HoverState.Parent = this.btnImport;
            this.btnImport.Image = global::Uclaray_Transport_Management_System.Properties.Resources.add_user_male_48px1;
            this.btnImport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnImport.Location = new System.Drawing.Point(802, 70);
            this.btnImport.Name = "btnImport";
            this.btnImport.ShadowDecoration.Parent = this.btnImport;
            this.btnImport.Size = new System.Drawing.Size(110, 35);
            this.btnImport.TabIndex = 122;
            this.btnImport.Text = "Import";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Uclaray_Transport_Management_System.Properties.Resources.add_user_male_48px1;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Location = new System.Drawing.Point(918, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 122;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAdvancedTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 606);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBatchAssign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdvancedTracking";
            this.Text = "AdvancedTracking";
            this.Load += new System.EventHandler(this.frmAdvancedTracking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvancedTracking)).EndInit();
            this.panelBatchAssign.ResumeLayout(false);
            this.panelBatchAssign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView dgvAdvancedTracking;
        private Guna.UI2.WinForms.Guna2Button btnImport;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDriver;
        private System.Windows.Forms.DataGridViewComboBoxColumn colHelper;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2ComboBox cboDriver;
        private Guna.UI2.WinForms.Guna2ComboBox cboHelper;
        private System.Windows.Forms.Panel panelBatchAssign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}