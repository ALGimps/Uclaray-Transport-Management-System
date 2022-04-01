namespace Uclaray_Transport_Management_System.Forms.Employee_management
{
    partial class frmAddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.cbDesignation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtLast = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirst = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Designation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contact No.";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Transparent;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.DefaultText = "";
            this.txtContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.DisabledState.Parent = this.txtContact;
            this.txtContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.FocusedState.Parent = this.txtContact;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtContact.HoverState.Parent = this.txtContact;
            this.txtContact.Location = new System.Drawing.Point(129, 187);
            this.txtContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtContact.PlaceholderText = "";
            this.txtContact.SelectedText = "";
            this.txtContact.ShadowDecoration.BorderRadius = 0;
            this.txtContact.ShadowDecoration.Depth = 20;
            this.txtContact.ShadowDecoration.Enabled = true;
            this.txtContact.ShadowDecoration.Parent = this.txtContact;
            this.txtContact.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtContact.Size = new System.Drawing.Size(192, 30);
            this.txtContact.TabIndex = 121;
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
            this.btnAdd.Location = new System.Drawing.Point(249, 258);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(110, 35);
            this.btnAdd.TabIndex = 120;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(133, 258);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 122;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbDesignation
            // 
            this.cbDesignation.BackColor = System.Drawing.Color.Transparent;
            this.cbDesignation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDesignation.FocusedColor = System.Drawing.Color.Empty;
            this.cbDesignation.FocusedState.Parent = this.cbDesignation;
            this.cbDesignation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDesignation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDesignation.FormattingEnabled = true;
            this.cbDesignation.HoverState.Parent = this.cbDesignation;
            this.cbDesignation.ItemHeight = 24;
            this.cbDesignation.Items.AddRange(new object[] {
            "Driver",
            "Helper"});
            this.cbDesignation.ItemsAppearance.Parent = this.cbDesignation;
            this.cbDesignation.Location = new System.Drawing.Point(129, 151);
            this.cbDesignation.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.cbDesignation.Name = "cbDesignation";
            this.cbDesignation.ShadowDecoration.Parent = this.cbDesignation;
            this.cbDesignation.Size = new System.Drawing.Size(192, 30);
            this.cbDesignation.TabIndex = 123;
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.Transparent;
            this.txtLast.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLast.DefaultText = "";
            this.txtLast.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLast.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLast.DisabledState.Parent = this.txtLast;
            this.txtLast.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLast.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLast.FocusedState.Parent = this.txtLast;
            this.txtLast.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLast.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLast.HoverState.Parent = this.txtLast;
            this.txtLast.Location = new System.Drawing.Point(129, 115);
            this.txtLast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLast.Name = "txtLast";
            this.txtLast.PasswordChar = '\0';
            this.txtLast.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtLast.PlaceholderText = "";
            this.txtLast.SelectedText = "";
            this.txtLast.ShadowDecoration.BorderRadius = 0;
            this.txtLast.ShadowDecoration.Depth = 20;
            this.txtLast.ShadowDecoration.Enabled = true;
            this.txtLast.ShadowDecoration.Parent = this.txtLast;
            this.txtLast.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtLast.Size = new System.Drawing.Size(192, 30);
            this.txtLast.TabIndex = 124;
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.Transparent;
            this.txtFirst.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirst.DefaultText = "";
            this.txtFirst.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirst.DisabledState.Parent = this.txtFirst;
            this.txtFirst.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirst.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirst.FocusedState.Parent = this.txtFirst;
            this.txtFirst.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFirst.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirst.HoverState.Parent = this.txtFirst;
            this.txtFirst.Location = new System.Drawing.Point(129, 79);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.PasswordChar = '\0';
            this.txtFirst.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtFirst.PlaceholderText = "";
            this.txtFirst.SelectedText = "";
            this.txtFirst.ShadowDecoration.BorderRadius = 0;
            this.txtFirst.ShadowDecoration.Depth = 20;
            this.txtFirst.ShadowDecoration.Enabled = true;
            this.txtFirst.ShadowDecoration.Parent = this.txtFirst;
            this.txtFirst.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2, 1, 2, 3);
            this.txtFirst.Size = new System.Drawing.Size(192, 30);
            this.txtFirst.TabIndex = 124;
            // 
            // frmAddEmployee
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.cbDesignation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(450, 410);
            this.MinimumSize = new System.Drawing.Size(400, 360);
            this.Name = "frmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtContact;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2ComboBox cbDesignation;
        private Guna.UI2.WinForms.Guna2TextBox txtLast;
        private Guna.UI2.WinForms.Guna2TextBox txtFirst;
    }
}