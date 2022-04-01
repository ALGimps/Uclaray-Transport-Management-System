namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    partial class frmManualAdd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManualAdd));
            this.txtArea = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTripAssignmentNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTruckType = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nudNumberOfDrops = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudNumberOfTrips = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtPlateNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.btnAddDeliveries = new Guna.UI2.WinForms.Guna2Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.cbologistics = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDrops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTrips)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Animated = true;
            this.txtArea.AutoCompleteCustomSource.AddRange(new string[] {
            "Metro Manila",
            "Rizal"});
            this.txtArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtArea.BackColor = System.Drawing.Color.Transparent;
            this.txtArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArea.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtArea.DefaultText = "";
            this.txtArea.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtArea.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtArea.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArea.DisabledState.Parent = this.txtArea;
            this.txtArea.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtArea.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArea.FocusedState.Parent = this.txtArea;
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtArea.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtArea.HoverState.Parent = this.txtArea;
            this.txtArea.Location = new System.Drawing.Point(559, 95);
            this.txtArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtArea.Name = "txtArea";
            this.txtArea.PasswordChar = '\0';
            this.txtArea.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtArea.PlaceholderText = "";
            this.txtArea.SelectedText = "";
            this.txtArea.ShadowDecoration.BorderRadius = 0;
            this.txtArea.ShadowDecoration.Depth = 20;
            this.txtArea.ShadowDecoration.Enabled = true;
            this.txtArea.ShadowDecoration.Parent = this.txtArea;
            this.txtArea.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtArea.Size = new System.Drawing.Size(120, 30);
            this.txtArea.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.Animated = true;
            this.txtLocation.AutoCompleteCustomSource.AddRange(new string[] {
            "Caloocan",
            "Las Piñas",
            "Makati",
            "Malabon",
            "Mandaluyong",
            "Manila",
            "Marikina",
            "Muntinlupa",
            "Navotas",
            "Parañaque",
            "Pasay",
            "Pasig",
            "Pateros (Municipality)",
            "Quezon City",
            "San Juan",
            "Taguig",
            "Valenzuela",
            "",
            "Angono",
            "Antipolo",
            "Baras",
            "Binangonan",
            "Cainta",
            "Cardona",
            "Jalajala",
            "Morong",
            "Pililla",
            "Rodriguez\tmunicipality",
            "San Mateo",
            "Tanay",
            "Taytay",
            "Teresa"});
            this.txtLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLocation.BackColor = System.Drawing.Color.Transparent;
            this.txtLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.DisabledState.Parent = this.txtLocation;
            this.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.FocusedState.Parent = this.txtLocation;
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.HoverState.Parent = this.txtLocation;
            this.txtLocation.Location = new System.Drawing.Point(439, 96);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLocation.PlaceholderText = "";
            this.txtLocation.SelectedText = "";
            this.txtLocation.ShadowDecoration.BorderRadius = 0;
            this.txtLocation.ShadowDecoration.Depth = 20;
            this.txtLocation.ShadowDecoration.Enabled = true;
            this.txtLocation.ShadowDecoration.Parent = this.txtLocation;
            this.txtLocation.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtLocation.Size = new System.Drawing.Size(114, 30);
            this.txtLocation.TabIndex = 7;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Animated = true;
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.DisabledState.Parent = this.txtCustomerName;
            this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.FocusedState.Parent = this.txtCustomerName;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.HoverState.Parent = this.txtCustomerName;
            this.txtCustomerName.Location = new System.Drawing.Point(293, 95);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.ShadowDecoration.BorderRadius = 0;
            this.txtCustomerName.ShadowDecoration.Depth = 20;
            this.txtCustomerName.ShadowDecoration.Enabled = true;
            this.txtCustomerName.ShadowDecoration.Parent = this.txtCustomerName;
            this.txtCustomerName.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtCustomerName.Size = new System.Drawing.Size(140, 30);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtTripAssignmentNo
            // 
            this.txtTripAssignmentNo.Animated = true;
            this.txtTripAssignmentNo.BackColor = System.Drawing.Color.Transparent;
            this.txtTripAssignmentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTripAssignmentNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTripAssignmentNo.DefaultText = "";
            this.txtTripAssignmentNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTripAssignmentNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTripAssignmentNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTripAssignmentNo.DisabledState.Parent = this.txtTripAssignmentNo;
            this.txtTripAssignmentNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTripAssignmentNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTripAssignmentNo.FocusedState.Parent = this.txtTripAssignmentNo;
            this.txtTripAssignmentNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTripAssignmentNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTripAssignmentNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTripAssignmentNo.HoverState.Parent = this.txtTripAssignmentNo;
            this.txtTripAssignmentNo.Location = new System.Drawing.Point(32, 230);
            this.txtTripAssignmentNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTripAssignmentNo.Name = "txtTripAssignmentNo";
            this.txtTripAssignmentNo.PasswordChar = '\0';
            this.txtTripAssignmentNo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTripAssignmentNo.PlaceholderText = "";
            this.txtTripAssignmentNo.SelectedText = "";
            this.txtTripAssignmentNo.ShadowDecoration.BorderRadius = 0;
            this.txtTripAssignmentNo.ShadowDecoration.Depth = 20;
            this.txtTripAssignmentNo.ShadowDecoration.Enabled = true;
            this.txtTripAssignmentNo.ShadowDecoration.Parent = this.txtTripAssignmentNo;
            this.txtTripAssignmentNo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtTripAssignmentNo.Size = new System.Drawing.Size(220, 30);
            this.txtTripAssignmentNo.TabIndex = 1;
            // 
            // txtTruckType
            // 
            this.txtTruckType.Animated = true;
            this.txtTruckType.BackColor = System.Drawing.Color.Transparent;
            this.txtTruckType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTruckType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTruckType.DefaultText = "";
            this.txtTruckType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTruckType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTruckType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTruckType.DisabledState.Parent = this.txtTruckType;
            this.txtTruckType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTruckType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTruckType.FocusedState.Parent = this.txtTruckType;
            this.txtTruckType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruckType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTruckType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTruckType.HoverState.Parent = this.txtTruckType;
            this.txtTruckType.Location = new System.Drawing.Point(32, 296);
            this.txtTruckType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTruckType.Name = "txtTruckType";
            this.txtTruckType.PasswordChar = '\0';
            this.txtTruckType.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTruckType.PlaceholderText = "";
            this.txtTruckType.SelectedText = "";
            this.txtTruckType.ShadowDecoration.BorderRadius = 0;
            this.txtTruckType.ShadowDecoration.Depth = 20;
            this.txtTruckType.ShadowDecoration.Enabled = true;
            this.txtTruckType.ShadowDecoration.Parent = this.txtTruckType;
            this.txtTruckType.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtTruckType.Size = new System.Drawing.Size(220, 30);
            this.txtTruckType.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(583, 430);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(699, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 129;
            this.label2.Text = "Add new trip";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 127;
            this.label6.Text = "Plate Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(436, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 126;
            this.label8.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 125;
            this.label3.Text = "Store Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(29, 404);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 17);
            this.label9.TabIndex = 124;
            this.label9.Text = "No. Of Drops";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 17);
            this.label7.TabIndex = 123;
            this.label7.Text = "Area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 122;
            this.label5.Text = "Truck Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 17);
            this.label4.TabIndex = 128;
            this.label4.Text = "Trip Assignment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 121;
            this.label1.Text = "Delivery Date";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Animated = true;
            this.dtpDeliveryDate.BorderColor = System.Drawing.Color.LightGray;
            this.dtpDeliveryDate.BorderThickness = 1;
            this.dtpDeliveryDate.CheckedState.Parent = this.dtpDeliveryDate;
            this.dtpDeliveryDate.CustomFormat = "MMMM dd yyyy";
            this.dtpDeliveryDate.FillColor = System.Drawing.Color.White;
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.HoverState.Parent = this.dtpDeliveryDate;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(32, 165);
            this.dtpDeliveryDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDeliveryDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.ShadowDecoration.Parent = this.dtpDeliveryDate;
            this.dtpDeliveryDate.Size = new System.Drawing.Size(220, 30);
            this.dtpDeliveryDate.TabIndex = 0;
            this.dtpDeliveryDate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.dtpDeliveryDate.Value = new System.DateTime(2022, 3, 13, 15, 30, 16, 622);
            // 
            // nudNumberOfDrops
            // 
            this.nudNumberOfDrops.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfDrops.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfDrops.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNumberOfDrops.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudNumberOfDrops.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudNumberOfDrops.DisabledState.Parent = this.nudNumberOfDrops;
            this.nudNumberOfDrops.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudNumberOfDrops.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudNumberOfDrops.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudNumberOfDrops.FocusedState.Parent = this.nudNumberOfDrops;
            this.nudNumberOfDrops.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfDrops.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nudNumberOfDrops.Location = new System.Drawing.Point(32, 426);
            this.nudNumberOfDrops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfDrops.Name = "nudNumberOfDrops";
            this.nudNumberOfDrops.ShadowDecoration.BorderRadius = 0;
            this.nudNumberOfDrops.ShadowDecoration.Depth = 20;
            this.nudNumberOfDrops.ShadowDecoration.Enabled = true;
            this.nudNumberOfDrops.ShadowDecoration.Parent = this.nudNumberOfDrops;
            this.nudNumberOfDrops.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.nudNumberOfDrops.Size = new System.Drawing.Size(84, 30);
            this.nudNumberOfDrops.TabIndex = 4;
            this.nudNumberOfDrops.UpDownButtonFillColor = System.Drawing.Color.Gainsboro;
            this.nudNumberOfDrops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 406);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 17);
            this.label10.TabIndex = 124;
            this.label10.Text = "No. Of Trips";
            // 
            // nudNumberOfTrips
            // 
            this.nudNumberOfTrips.BackColor = System.Drawing.Color.Transparent;
            this.nudNumberOfTrips.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudNumberOfTrips.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudNumberOfTrips.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudNumberOfTrips.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudNumberOfTrips.DisabledState.Parent = this.nudNumberOfTrips;
            this.nudNumberOfTrips.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudNumberOfTrips.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudNumberOfTrips.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudNumberOfTrips.FocusedState.Parent = this.nudNumberOfTrips;
            this.nudNumberOfTrips.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumberOfTrips.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nudNumberOfTrips.Location = new System.Drawing.Point(168, 426);
            this.nudNumberOfTrips.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfTrips.Name = "nudNumberOfTrips";
            this.nudNumberOfTrips.ShadowDecoration.BorderRadius = 0;
            this.nudNumberOfTrips.ShadowDecoration.Depth = 20;
            this.nudNumberOfTrips.ShadowDecoration.Enabled = true;
            this.nudNumberOfTrips.ShadowDecoration.Parent = this.nudNumberOfTrips;
            this.nudNumberOfTrips.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.nudNumberOfTrips.Size = new System.Drawing.Size(84, 30);
            this.nudNumberOfTrips.TabIndex = 5;
            this.nudNumberOfTrips.UpDownButtonFillColor = System.Drawing.Color.Gainsboro;
            this.nudNumberOfTrips.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPlateNo
            // 
            this.txtPlateNo.Animated = true;
            this.txtPlateNo.BackColor = System.Drawing.Color.Transparent;
            this.txtPlateNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlateNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlateNo.DefaultText = "";
            this.txtPlateNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlateNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlateNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNo.DisabledState.Parent = this.txtPlateNo;
            this.txtPlateNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlateNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNo.FocusedState.Parent = this.txtPlateNo;
            this.txtPlateNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlateNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPlateNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlateNo.HoverState.Parent = this.txtPlateNo;
            this.txtPlateNo.Location = new System.Drawing.Point(32, 360);
            this.txtPlateNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlateNo.Name = "txtPlateNo";
            this.txtPlateNo.PasswordChar = '\0';
            this.txtPlateNo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPlateNo.PlaceholderText = "";
            this.txtPlateNo.SelectedText = "";
            this.txtPlateNo.ShadowDecoration.BorderRadius = 0;
            this.txtPlateNo.ShadowDecoration.Depth = 20;
            this.txtPlateNo.ShadowDecoration.Enabled = true;
            this.txtPlateNo.ShadowDecoration.Parent = this.txtPlateNo;
            this.txtPlateNo.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtPlateNo.Size = new System.Drawing.Size(220, 30);
            this.txtPlateNo.TabIndex = 3;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.dgvDeliveries);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(293, 139);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(516, 264);
            this.guna2ShadowPanel1.TabIndex = 133;
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.AllowUserToAddRows = false;
            this.dgvDeliveries.AllowUserToDeleteRows = false;
            this.dgvDeliveries.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDeliveries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveries.BackgroundColor = System.Drawing.Color.White;
            this.dgvDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeliveries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDeliveries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDeliveries.ColumnHeadersHeight = 35;
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.Column1});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveries.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDeliveries.EnableHeadersVisualStyles = false;
            this.dgvDeliveries.Location = new System.Drawing.Point(5, 3);
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.RowHeadersVisible = false;
            this.dgvDeliveries.RowTemplate.Height = 35;
            this.dgvDeliveries.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveries.Size = new System.Drawing.Size(505, 258);
            this.dgvDeliveries.StandardTab = true;
            this.dgvDeliveries.TabIndex = 123;
            this.dgvDeliveries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveries_CellContentClick);
            // 
            // btnAddDeliveries
            // 
            this.btnAddDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddDeliveries.CheckedState.Parent = this.btnAddDeliveries;
            this.btnAddDeliveries.CustomImages.Parent = this.btnAddDeliveries;
            this.btnAddDeliveries.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnAddDeliveries.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddDeliveries.ForeColor = System.Drawing.Color.White;
            this.btnAddDeliveries.HoverState.Parent = this.btnAddDeliveries;
            this.btnAddDeliveries.Location = new System.Drawing.Point(743, 96);
            this.btnAddDeliveries.Name = "btnAddDeliveries";
            this.btnAddDeliveries.ShadowDecoration.Parent = this.btnAddDeliveries;
            this.btnAddDeliveries.Size = new System.Drawing.Size(60, 30);
            this.btnAddDeliveries.TabIndex = 10;
            this.btnAddDeliveries.Text = "Add";
            this.btnAddDeliveries.Click += new System.EventHandler(this.btnAddDeliveries_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cancel_48px.png");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 70);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 135;
            this.label11.Text = "Logistics";
            // 
            // cbologistics
            // 
            this.cbologistics.BackColor = System.Drawing.Color.Transparent;
            this.cbologistics.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbologistics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbologistics.FocusedColor = System.Drawing.Color.Empty;
            this.cbologistics.FocusedState.Parent = this.cbologistics;
            this.cbologistics.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbologistics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbologistics.FormattingEnabled = true;
            this.cbologistics.HoverState.Parent = this.cbologistics;
            this.cbologistics.IntegralHeight = false;
            this.cbologistics.ItemHeight = 24;
            this.cbologistics.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbologistics.ItemsAppearance.Parent = this.cbologistics;
            this.cbologistics.Location = new System.Drawing.Point(32, 96);
            this.cbologistics.Name = "cbologistics";
            this.cbologistics.ShadowDecoration.Parent = this.cbologistics;
            this.cbologistics.Size = new System.Drawing.Size(220, 30);
            this.cbologistics.TabIndex = 136;
            // 
            // nudQuantity
            // 
            this.nudQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nudQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudQuantity.DisabledState.Parent = this.nudQuantity;
            this.nudQuantity.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudQuantity.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudQuantity.FocusedState.Parent = this.nudQuantity;
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.nudQuantity.Location = new System.Drawing.Point(685, 96);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.ShadowDecoration.BorderRadius = 0;
            this.nudQuantity.ShadowDecoration.Depth = 20;
            this.nudQuantity.ShadowDecoration.Enabled = true;
            this.nudQuantity.ShadowDecoration.Parent = this.nudQuantity;
            this.nudQuantity.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.nudQuantity.Size = new System.Drawing.Size(52, 30);
            this.nudQuantity.TabIndex = 9;
            this.nudQuantity.UpDownButtonFillColor = System.Drawing.Color.Gainsboro;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(684, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 123;
            this.label12.Text = "Qty";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.FillWeight = 64F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Store Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 115;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 64F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Location";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Area";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 60;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle11;
            this.Column1.HeaderText = " ";
            this.Column1.MinimumWidth = 20;
            this.Column1.Name = "Column1";
            this.Column1.Width = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(289, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 20);
            this.label13.TabIndex = 129;
            this.label13.Text = "Deliveries";
            // 
            // frmManualAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 477);
            this.Controls.Add(this.cbologistics);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.nudNumberOfTrips);
            this.Controls.Add(this.nudNumberOfDrops);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtTripAssignmentNo);
            this.Controls.Add(this.txtPlateNo);
            this.Controls.Add(this.txtTruckType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDeliveries);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManualAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManualAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfDrops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfTrips)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtArea;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtTripAssignmentNo;
        private Guna.UI2.WinForms.Guna2TextBox txtTruckType;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDeliveryDate;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfDrops;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudNumberOfTrips;
        private Guna.UI2.WinForms.Guna2TextBox txtPlateNo;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        internal System.Windows.Forms.DataGridView dgvDeliveries;
        private Guna.UI2.WinForms.Guna2Button btnAddDeliveries;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cbologistics;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}