namespace Uclaray_Transport_Management_System.Forms.Account_management
{
    partial class frmAccountManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManagement));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            this.reset = new System.Windows.Forms.DataGridViewImageColumn();
            this.deac = new System.Windows.Forms.DataGridViewImageColumn();
            this.active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Accounts";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvUsers);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 354);
            this.panel1.TabIndex = 111;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeight = 45;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnFirst,
            this.columnLast,
            this.columnDesignation,
            this.columnContact,
            this.Column1,
            this.contact,
            this.update,
            this.reset,
            this.deac,
            this.active});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.EnableHeadersVisualStyles = false;
            this.dgvUsers.Location = new System.Drawing.Point(0, 0);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            this.dgvUsers.RowTemplate.Height = 35;
            this.dgvUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(780, 354);
            this.dgvUsers.StandardTab = true;
            this.dgvUsers.TabIndex = 109;
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // columnID
            // 
            this.columnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnID.FillWeight = 152.2843F;
            this.columnID.HeaderText = "ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnID.Visible = false;
            this.columnID.Width = 60;
            // 
            // columnFirst
            // 
            this.columnFirst.FillWeight = 64F;
            this.columnFirst.HeaderText = "First name";
            this.columnFirst.MinimumWidth = 100;
            this.columnFirst.Name = "columnFirst";
            this.columnFirst.ReadOnly = true;
            // 
            // columnLast
            // 
            this.columnLast.FillWeight = 64F;
            this.columnLast.HeaderText = "Last name";
            this.columnLast.MinimumWidth = 100;
            this.columnLast.Name = "columnLast";
            this.columnLast.ReadOnly = true;
            // 
            // columnDesignation
            // 
            this.columnDesignation.FillWeight = 64F;
            this.columnDesignation.HeaderText = "User name";
            this.columnDesignation.MinimumWidth = 100;
            this.columnDesignation.Name = "columnDesignation";
            this.columnDesignation.ReadOnly = true;
            // 
            // columnContact
            // 
            this.columnContact.FillWeight = 64F;
            this.columnContact.HeaderText = "Email";
            this.columnContact.MinimumWidth = 100;
            this.columnContact.Name = "columnContact";
            this.columnContact.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Role";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.FillWeight = 34.79669F;
            this.contact.HeaderText = "Contact";
            this.contact.MinimumWidth = 100;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // update
            // 
            this.update.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.update.HeaderText = "";
            this.update.MinimumWidth = 30;
            this.update.Name = "update";
            this.update.ReadOnly = true;
            this.update.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.update.ToolTipText = "Update user account";
            this.update.Width = 30;
            // 
            // reset
            // 
            this.reset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reset.HeaderText = "Action";
            this.reset.MinimumWidth = 30;
            this.reset.Name = "reset";
            this.reset.ReadOnly = true;
            this.reset.Width = 52;
            // 
            // deac
            // 
            this.deac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deac.HeaderText = "";
            this.deac.MinimumWidth = 30;
            this.deac.Name = "deac";
            this.deac.ReadOnly = true;
            this.deac.ToolTipText = "Deactivate";
            this.deac.Width = 30;
            // 
            // active
            // 
            this.active.HeaderText = "Active";
            this.active.Name = "active";
            this.active.ReadOnly = true;
            this.active.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(-1, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "DATE";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit_user_48px.png");
            this.imageList1.Images.SetKeyName(1, "important_user_48pxlight.png");
            this.imageList1.Images.SetKeyName(2, "user_secured_48px green.png");
            this.imageList1.Images.SetKeyName(3, "user_secured_48px red.png");
            this.imageList1.Images.SetKeyName(4, "gear.png");
            this.imageList1.Images.SetKeyName(5, "important_user_48px.png");
            this.imageList1.Images.SetKeyName(6, "important_user_48pxdark.png");
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(252)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::Uclaray_Transport_Management_System.Properties.Resources.add_user_male_48px1;
            this.btnAdd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdd.Location = new System.Drawing.Point(682, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 120;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 491);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label1);
            this.Name = "frmAccountManagement";
            this.Text = "frmAccountManagement";
            this.Load += new System.EventHandler(this.frmAccountManagement_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewImageColumn update;
        private System.Windows.Forms.DataGridViewImageColumn reset;
        private System.Windows.Forms.DataGridViewImageColumn deac;
        private System.Windows.Forms.DataGridViewTextBoxColumn active;
    }
}