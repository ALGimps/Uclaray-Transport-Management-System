namespace Uclaray_Transport_Management_System.Forms.Employee_management
{
    partial class frmEmployeeDeliveries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeDeliveries));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEmployeeDeliveries = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            this.columnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 20);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(144, 21);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "EMPLOYEE NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "SUMMARY OF DELIVERIES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(178)))), ((int)(((byte)(47)))));
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "SUCCESSFUL ORDERS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL NUMBER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(113, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "0";
            // 
            // dgvEmployeeDeliveries
            // 
            this.dgvEmployeeDeliveries.AllowUserToAddRows = false;
            this.dgvEmployeeDeliveries.AllowUserToDeleteRows = false;
            this.dgvEmployeeDeliveries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployeeDeliveries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployeeDeliveries.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployeeDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployeeDeliveries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployeeDeliveries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDeliveries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeDeliveries.ColumnHeadersHeight = 35;
            this.dgvEmployeeDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployeeDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnID,
            this.columnFirst,
            this.columnLast,
            this.Column3,
            this.columnDesignation,
            this.columnContact,
            this.Column2,
            this.Status,
            this.Column1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeDeliveries.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployeeDeliveries.EnableHeadersVisualStyles = false;
            this.dgvEmployeeDeliveries.Location = new System.Drawing.Point(15, 141);
            this.dgvEmployeeDeliveries.MultiSelect = false;
            this.dgvEmployeeDeliveries.Name = "dgvEmployeeDeliveries";
            this.dgvEmployeeDeliveries.ReadOnly = true;
            this.dgvEmployeeDeliveries.RowHeadersVisible = false;
            this.dgvEmployeeDeliveries.RowTemplate.Height = 35;
            this.dgvEmployeeDeliveries.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeDeliveries.Size = new System.Drawing.Size(780, 508);
            this.dgvEmployeeDeliveries.StandardTab = true;
            this.dgvEmployeeDeliveries.TabIndex = 110;
            this.dgvEmployeeDeliveries.TabStop = false;
            this.dgvEmployeeDeliveries.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmployeeDeliveries_CellFormatting);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(216, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
            this.label7.TabIndex = 113;
            this.label7.Text = "PENDING ORDERS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(78)))), ((int)(((byte)(30)))));
            this.label8.Location = new System.Drawing.Point(414, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 113;
            this.label8.Text = "BAD ORDERS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(216, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 112;
            this.label6.Text = "TOTAL NUMBER:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(414, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 17);
            this.label9.TabIndex = 112;
            this.label9.Text = "TOTAL NUMBER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(316, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 17);
            this.label5.TabIndex = 111;
            this.label5.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(514, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 111;
            this.label10.Text = "0";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Component 2.png");
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(335, 325);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(148, 17);
            this.lblLoading.TabIndex = 124;
            this.lblLoading.Text = "Loading, please wait . . .";
            // 
            // columnID
            // 
            this.columnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.columnID.DefaultCellStyle = dataGridViewCellStyle3;
            this.columnID.FillWeight = 152.2843F;
            this.columnID.HeaderText = "Tracking ID";
            this.columnID.Name = "columnID";
            this.columnID.ReadOnly = true;
            this.columnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnID.Width = 60;
            // 
            // columnFirst
            // 
            this.columnFirst.FillWeight = 62.90896F;
            this.columnFirst.HeaderText = "Delivery date";
            this.columnFirst.Name = "columnFirst";
            this.columnFirst.ReadOnly = true;
            // 
            // columnLast
            // 
            this.columnLast.FillWeight = 62.90896F;
            this.columnLast.HeaderText = "Store name";
            this.columnLast.Name = "columnLast";
            this.columnLast.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // columnDesignation
            // 
            this.columnDesignation.FillWeight = 62.90896F;
            this.columnDesignation.HeaderText = "Helper";
            this.columnDesignation.Name = "columnDesignation";
            this.columnDesignation.ReadOnly = true;
            // 
            // columnContact
            // 
            this.columnContact.FillWeight = 62.90896F;
            this.columnContact.HeaderText = "Driver";
            this.columnContact.Name = "columnContact";
            this.columnContact.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PO number";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Status
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(184)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.Status.DefaultCellStyle = dataGridViewCellStyle5;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "deliveries";
            this.Column1.MinimumWidth = 95;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 95;
            // 
            // frmEmployeeDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvEmployeeDeliveries);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblEmployeeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEmployeeDeliveries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployeeDeliveries";
            this.Load += new System.EventHandler(this.frmEmployeeDeliveries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.DataGridView dgvEmployeeDeliveries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}