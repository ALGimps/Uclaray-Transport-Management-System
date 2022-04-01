namespace Uclaray_Transport_Management_System.Forms
{
    partial class frmMain
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
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSide = new Guna.UI2.WinForms.Guna2Panel();
            this.panelSidebar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdvancedTracking = new Guna.UI2.WinForms.Guna2Button();
            this.btnCurrentDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployees = new Guna.UI2.WinForms.Guna2Button();
            this.btnUserAccounts = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowPanel2.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.flpNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.guna2ShadowPanel2;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.pictureBox2);
            this.guna2ShadowPanel2.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowShift = 1;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(1264, 75);
            this.guna2ShadowPanel2.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BorderColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.guna2ShadowPanel2);
            this.panelHeader.CustomBorderColor = System.Drawing.Color.Transparent;
            this.panelHeader.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShadowDecoration.Enabled = true;
            this.panelHeader.ShadowDecoration.Parent = this.panelHeader;
            this.panelHeader.Size = new System.Drawing.Size(1264, 75);
            this.panelHeader.TabIndex = 6;
            // 
            // panelSide
            // 
            this.panelSide.Controls.Add(this.panelSidebar);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 75);
            this.panelSide.Name = "panelSide";
            this.panelSide.ShadowDecoration.BorderRadius = 0;
            this.panelSide.ShadowDecoration.Depth = 20;
            this.panelSide.ShadowDecoration.Enabled = true;
            this.panelSide.ShadowDecoration.Parent = this.panelSide;
            this.panelSide.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.panelSide.Size = new System.Drawing.Size(224, 606);
            this.panelSide.TabIndex = 7;
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Transparent;
            this.panelSidebar.Controls.Add(this.flpNav);
            this.panelSidebar.Controls.Add(this.guna2CirclePictureBox1);
            this.panelSidebar.Controls.Add(this.lblRole);
            this.panelSidebar.Controls.Add(this.lblName);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSidebar.FillColor = System.Drawing.Color.White;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelSidebar.ShadowColor = System.Drawing.Color.Black;
            this.panelSidebar.ShadowDepth = 25;
            this.panelSidebar.ShadowShift = 4;
            this.panelSidebar.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panelSidebar.Size = new System.Drawing.Size(224, 606);
            this.panelSidebar.TabIndex = 0;
            // 
            // flpNav
            // 
            this.flpNav.Controls.Add(this.guna2Button2);
            this.flpNav.Controls.Add(this.btnAdvancedTracking);
            this.flpNav.Controls.Add(this.btnCurrentDelivery);
            this.flpNav.Controls.Add(this.guna2Button4);
            this.flpNav.Controls.Add(this.guna2Button3);
            this.flpNav.Controls.Add(this.guna2Button1);
            this.flpNav.Controls.Add(this.btnEmployees);
            this.flpNav.Controls.Add(this.btnUserAccounts);
            this.flpNav.Controls.Add(this.guna2Button8);
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.Location = new System.Drawing.Point(11, 127);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(200, 476);
            this.flpNav.TabIndex = 0;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(39, 95);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(150, 17);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Admin";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(215, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Juan Dela Cruz";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(224, 75);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.panelContainer.ShadowDecoration.Parent = this.panelContainer;
            this.panelContainer.Size = new System.Drawing.Size(1040, 606);
            this.panelContainer.TabIndex = 8;
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::Uclaray_Transport_Management_System.Properties.Resources.Vector;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(5, 5);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.BorderRadius = 0;
            this.guna2Button2.ShadowDecoration.Depth = 15;
            this.guna2Button2.ShadowDecoration.Enabled = true;
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.guna2Button2.Size = new System.Drawing.Size(183, 34);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Home";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAdvancedTracking
            // 
            this.btnAdvancedTracking.CheckedState.Parent = this.btnAdvancedTracking;
            this.btnAdvancedTracking.CustomImages.Parent = this.btnAdvancedTracking;
            this.btnAdvancedTracking.FillColor = System.Drawing.Color.White;
            this.btnAdvancedTracking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvancedTracking.ForeColor = System.Drawing.Color.Black;
            this.btnAdvancedTracking.HoverState.Parent = this.btnAdvancedTracking;
            this.btnAdvancedTracking.Image = global::Uclaray_Transport_Management_System.Properties.Resources.carbon_delivery_add;
            this.btnAdvancedTracking.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdvancedTracking.Location = new System.Drawing.Point(5, 49);
            this.btnAdvancedTracking.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdvancedTracking.Name = "btnAdvancedTracking";
            this.btnAdvancedTracking.ShadowDecoration.BorderRadius = 0;
            this.btnAdvancedTracking.ShadowDecoration.Depth = 15;
            this.btnAdvancedTracking.ShadowDecoration.Enabled = true;
            this.btnAdvancedTracking.ShadowDecoration.Parent = this.btnAdvancedTracking;
            this.btnAdvancedTracking.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.btnAdvancedTracking.Size = new System.Drawing.Size(183, 34);
            this.btnAdvancedTracking.TabIndex = 1;
            this.btnAdvancedTracking.Text = "Advanced Tracking";
            this.btnAdvancedTracking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdvancedTracking.Click += new System.EventHandler(this.btnAdvancedTracking_Click);
            // 
            // btnCurrentDelivery
            // 
            this.btnCurrentDelivery.CheckedState.Parent = this.btnCurrentDelivery;
            this.btnCurrentDelivery.CustomImages.Parent = this.btnCurrentDelivery;
            this.btnCurrentDelivery.FillColor = System.Drawing.Color.White;
            this.btnCurrentDelivery.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentDelivery.ForeColor = System.Drawing.Color.Black;
            this.btnCurrentDelivery.HoverState.Parent = this.btnCurrentDelivery;
            this.btnCurrentDelivery.Image = global::Uclaray_Transport_Management_System.Properties.Resources.carbon_delivery_truck;
            this.btnCurrentDelivery.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCurrentDelivery.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnCurrentDelivery.ImageSize = new System.Drawing.Size(22, 20);
            this.btnCurrentDelivery.Location = new System.Drawing.Point(5, 93);
            this.btnCurrentDelivery.Margin = new System.Windows.Forms.Padding(5);
            this.btnCurrentDelivery.Name = "btnCurrentDelivery";
            this.btnCurrentDelivery.ShadowDecoration.BorderRadius = 0;
            this.btnCurrentDelivery.ShadowDecoration.Depth = 15;
            this.btnCurrentDelivery.ShadowDecoration.Enabled = true;
            this.btnCurrentDelivery.ShadowDecoration.Parent = this.btnCurrentDelivery;
            this.btnCurrentDelivery.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.btnCurrentDelivery.Size = new System.Drawing.Size(183, 34);
            this.btnCurrentDelivery.TabIndex = 3;
            this.btnCurrentDelivery.Text = "Current Delivery";
            this.btnCurrentDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCurrentDelivery.TextOffset = new System.Drawing.Point(-2, 0);
            this.btnCurrentDelivery.Click += new System.EventHandler(this.btnCurrentDelivery_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = global::Uclaray_Transport_Management_System.Properties.Resources.bi_calendar_check;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2Button4.Location = new System.Drawing.Point(5, 137);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.BorderRadius = 0;
            this.guna2Button4.ShadowDecoration.Depth = 15;
            this.guna2Button4.ShadowDecoration.Enabled = true;
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.guna2Button4.Size = new System.Drawing.Size(183, 34);
            this.guna2Button4.TabIndex = 2;
            this.guna2Button4.Text = "Successful Delivery";
            this.guna2Button4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::Uclaray_Transport_Management_System.Properties.Resources.ant_design_file_excel_outlined;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(5, 181);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.BorderRadius = 0;
            this.guna2Button3.ShadowDecoration.Depth = 15;
            this.guna2Button3.ShadowDecoration.Enabled = true;
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.guna2Button3.Size = new System.Drawing.Size(183, 34);
            this.guna2Button3.TabIndex = 1;
            this.guna2Button3.Text = "Bad Orders";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::Uclaray_Transport_Management_System.Properties.Resources.clarity_list_line;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(5, 225);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.BorderRadius = 0;
            this.guna2Button1.ShadowDecoration.Depth = 15;
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.guna2Button1.Size = new System.Drawing.Size(183, 34);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "History";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEmployees
            // 
            this.btnEmployees.CheckedState.Parent = this.btnEmployees;
            this.btnEmployees.CustomImages.Parent = this.btnEmployees;
            this.btnEmployees.FillColor = System.Drawing.Color.White;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.Black;
            this.btnEmployees.HoverState.Parent = this.btnEmployees;
            this.btnEmployees.Image = global::Uclaray_Transport_Management_System.Properties.Resources.bi_people_fill;
            this.btnEmployees.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployees.ImageSize = new System.Drawing.Size(18, 18);
            this.btnEmployees.Location = new System.Drawing.Point(5, 269);
            this.btnEmployees.Margin = new System.Windows.Forms.Padding(5);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.ShadowDecoration.BorderRadius = 0;
            this.btnEmployees.ShadowDecoration.Depth = 15;
            this.btnEmployees.ShadowDecoration.Enabled = true;
            this.btnEmployees.ShadowDecoration.Parent = this.btnEmployees;
            this.btnEmployees.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.btnEmployees.Size = new System.Drawing.Size(183, 34);
            this.btnEmployees.TabIndex = 2;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnUserAccounts
            // 
            this.btnUserAccounts.CheckedState.Parent = this.btnUserAccounts;
            this.btnUserAccounts.CustomImages.Parent = this.btnUserAccounts;
            this.btnUserAccounts.FillColor = System.Drawing.Color.White;
            this.btnUserAccounts.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserAccounts.ForeColor = System.Drawing.Color.Black;
            this.btnUserAccounts.HoverState.Parent = this.btnUserAccounts;
            this.btnUserAccounts.Image = global::Uclaray_Transport_Management_System.Properties.Resources.Vector__1_;
            this.btnUserAccounts.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserAccounts.ImageSize = new System.Drawing.Size(18, 18);
            this.btnUserAccounts.Location = new System.Drawing.Point(5, 313);
            this.btnUserAccounts.Margin = new System.Windows.Forms.Padding(5);
            this.btnUserAccounts.Name = "btnUserAccounts";
            this.btnUserAccounts.ShadowDecoration.BorderRadius = 0;
            this.btnUserAccounts.ShadowDecoration.Depth = 15;
            this.btnUserAccounts.ShadowDecoration.Enabled = true;
            this.btnUserAccounts.ShadowDecoration.Parent = this.btnUserAccounts;
            this.btnUserAccounts.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.btnUserAccounts.Size = new System.Drawing.Size(183, 34);
            this.btnUserAccounts.TabIndex = 2;
            this.btnUserAccounts.Text = "User Accounts";
            this.btnUserAccounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUserAccounts.Click += new System.EventHandler(this.btnUserAccounts_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.CheckedState.Parent = this.guna2Button8;
            this.guna2Button8.CustomImages.Parent = this.guna2Button8;
            this.guna2Button8.FillColor = System.Drawing.Color.White;
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button8.ForeColor = System.Drawing.Color.Black;
            this.guna2Button8.HoverState.Parent = this.guna2Button8;
            this.guna2Button8.Image = global::Uclaray_Transport_Management_System.Properties.Resources.carbon_partnership;
            this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2Button8.Location = new System.Drawing.Point(5, 357);
            this.guna2Button8.Margin = new System.Windows.Forms.Padding(5);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.ShadowDecoration.BorderRadius = 0;
            this.guna2Button8.ShadowDecoration.Depth = 15;
            this.guna2Button8.ShadowDecoration.Enabled = true;
            this.guna2Button8.ShadowDecoration.Parent = this.guna2Button8;
            this.guna2Button8.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 1, 3, 6);
            this.guna2Button8.Size = new System.Drawing.Size(183, 34);
            this.guna2Button8.TabIndex = 3;
            this.guna2Button8.Text = "Partner Companies";
            this.guna2Button8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Uclaray_Transport_Management_System.Properties.Resources.male_user_60px;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(86, 22);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(50, 50);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Uclaray_Transport_Management_System.Properties.Resources.UCLARAY_TRANSPORT;
            this.pictureBox2.Location = new System.Drawing.Point(110, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Uclaray_Transport_Management_System.Properties.Resources.UCLARAY_TRANSPORT_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(21, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.flpNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Panel panelSide;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelSidebar;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnEmployees;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnAdvancedTracking;
        private Guna.UI2.WinForms.Guna2Button btnCurrentDelivery;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button btnUserAccounts;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}