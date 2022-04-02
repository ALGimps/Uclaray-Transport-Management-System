namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    partial class frmSuccessfulDeliveries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuccessfulDeliveries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.dgvSuccessfulDeliveries = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnApplyFilter = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccessfulDeliveries)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Component 2.png");
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(-1, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 129;
            this.lblDate.Text = "DATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(-2, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 130;
            this.label1.Text = "Successful Deliveries";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRecords.Location = new System.Drawing.Point(9, 544);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(70, 17);
            this.lblRecords.TabIndex = 128;
            this.lblRecords.Text = "Records: 0";
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(432, 217);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(148, 17);
            this.lblLoading.TabIndex = 118;
            this.lblLoading.Text = "Loading, please wait . . .";
            // 
            // dgvSuccessfulDeliveries
            // 
            this.dgvSuccessfulDeliveries.AllowUserToAddRows = false;
            this.dgvSuccessfulDeliveries.AllowUserToDeleteRows = false;
            this.dgvSuccessfulDeliveries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSuccessfulDeliveries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuccessfulDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuccessfulDeliveries.BackgroundColor = System.Drawing.Color.White;
            this.dgvSuccessfulDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSuccessfulDeliveries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSuccessfulDeliveries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuccessfulDeliveries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuccessfulDeliveries.ColumnHeadersHeight = 45;
            this.dgvSuccessfulDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSuccessfulDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnFirst,
            this.columnDesignation,
            this.columnContact,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuccessfulDeliveries.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSuccessfulDeliveries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuccessfulDeliveries.EnableHeadersVisualStyles = false;
            this.dgvSuccessfulDeliveries.Location = new System.Drawing.Point(0, 0);
            this.dgvSuccessfulDeliveries.MultiSelect = false;
            this.dgvSuccessfulDeliveries.Name = "dgvSuccessfulDeliveries";
            this.dgvSuccessfulDeliveries.RowHeadersVisible = false;
            this.dgvSuccessfulDeliveries.RowTemplate.Height = 35;
            this.dgvSuccessfulDeliveries.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuccessfulDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuccessfulDeliveries.Size = new System.Drawing.Size(1000, 430);
            this.dgvSuccessfulDeliveries.StandardTab = true;
            this.dgvSuccessfulDeliveries.TabIndex = 109;
            this.dgvSuccessfulDeliveries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSuccessfulDeliveries_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lblLoading);
            this.panel1.Controls.Add(this.dgvSuccessfulDeliveries);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 430);
            this.panel1.TabIndex = 127;
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Animated = true;
            this.dtpStart.BorderColor = System.Drawing.Color.LightGray;
            this.dtpStart.BorderThickness = 1;
            this.dtpStart.CheckedState.Parent = this.dtpStart;
            this.dtpStart.CustomFormat = "MMM dd yyyy";
            this.dtpStart.FillColor = System.Drawing.Color.White;
            this.dtpStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.HoverState.Parent = this.dtpStart;
            this.dtpStart.Location = new System.Drawing.Point(642, 75);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShadowDecoration.Parent = this.dtpStart;
            this.dtpStart.Size = new System.Drawing.Size(134, 30);
            this.dtpStart.TabIndex = 131;
            this.dtpStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dtpStart.Value = new System.DateTime(2022, 3, 13, 15, 30, 16, 622);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Animated = true;
            this.dtpEnd.BorderColor = System.Drawing.Color.LightGray;
            this.dtpEnd.BorderThickness = 1;
            this.dtpEnd.CheckedState.Parent = this.dtpEnd;
            this.dtpEnd.CustomFormat = "MMM dd yyyy";
            this.dtpEnd.FillColor = System.Drawing.Color.White;
            this.dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.HoverState.Parent = this.dtpEnd;
            this.dtpEnd.Location = new System.Drawing.Point(812, 75);
            this.dtpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShadowDecoration.Parent = this.dtpEnd;
            this.dtpEnd.Size = new System.Drawing.Size(134, 30);
            this.dtpEnd.TabIndex = 131;
            this.dtpEnd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dtpEnd.Value = new System.DateTime(2022, 3, 13, 15, 30, 16, 622);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyFilter.CheckedState.Parent = this.btnApplyFilter;
            this.btnApplyFilter.CustomImages.Parent = this.btnApplyFilter;
            this.btnApplyFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
            this.btnApplyFilter.HoverState.Parent = this.btnApplyFilter;
            this.btnApplyFilter.Location = new System.Drawing.Point(952, 75);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.ShadowDecoration.Parent = this.btnApplyFilter;
            this.btnApplyFilter.Size = new System.Drawing.Size(60, 30);
            this.btnApplyFilter.TabIndex = 133;
            this.btnApplyFilter.Text = "Filter";
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(12, 74);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search by Trip No. or Store";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.BorderRadius = 0;
            this.txtSearch.ShadowDecoration.Depth = 20;
            this.txtSearch.ShadowDecoration.Enabled = true;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtSearch.Size = new System.Drawing.Size(201, 30);
            this.txtSearch.TabIndex = 134;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::Uclaray_Transport_Management_System.Properties.Resources.search_100px;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnSearch.Location = new System.Drawing.Point(212, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.BorderRadius = 0;
            this.btnSearch.ShadowDecoration.Depth = 20;
            this.btnSearch.ShadowDecoration.Enabled = true;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.btnSearch.Size = new System.Drawing.Size(77, 30);
            this.btnSearch.TabIndex = 135;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSearch.TextOffset = new System.Drawing.Point(-5, 0);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Uclaray_Transport_Management_System.Properties.Resources.akar_icons_arrow_left;
            this.pictureBox1.Location = new System.Drawing.Point(779, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 132;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Action";
            this.dataGridViewImageColumn1.Image = global::Uclaray_Transport_Management_System.Properties.Resources.Component_2;
            this.dataGridViewImageColumn1.MinimumWidth = 95;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // columnID
            // 
            this.columnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnID.FillWeight = 152.2843F;
            this.columnID.HeaderText = "Tracking ID";
            this.columnID.Name = "columnID";
            this.columnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // Column7
            // 
            this.Column7.HeaderText = "Quantity";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Trip Assignment";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Driver";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Helper";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PO Number";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(207)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(207)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Action";
            this.Column6.MinimumWidth = 95;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Width = 95;
            // 
            // frmSuccessfulDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 567);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSuccessfulDeliveries";
            this.Text = "frmSuccessfulDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuccessfulDeliveries)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label lblLoading;
        internal System.Windows.Forms.DataGridView dgvSuccessfulDeliveries;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnApplyFilter;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
    }
}