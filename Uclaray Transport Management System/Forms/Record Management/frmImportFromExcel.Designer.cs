namespace Uclaray_Transport_Management_System.Forms.Record_Management
{
    partial class frmImportFromExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDeliveries = new System.Windows.Forms.DataGridView();
            this.lblDrop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.cbologistics = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).BeginInit();
            this.SuspendLayout();
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
            this.btnImport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnImport.Location = new System.Drawing.Point(348, 245);
            this.btnImport.Name = "btnImport";
            this.btnImport.ShadowDecoration.Parent = this.btnImport;
            this.btnImport.Size = new System.Drawing.Size(110, 35);
            this.btnImport.TabIndex = 129;
            this.btnImport.Text = "Select file";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // dgvDeliveries
            // 
            this.dgvDeliveries.AllowDrop = true;
            this.dgvDeliveries.AllowUserToAddRows = false;
            this.dgvDeliveries.AllowUserToDeleteRows = false;
            this.dgvDeliveries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDeliveries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDeliveries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDeliveries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeliveries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvDeliveries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDeliveries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDeliveries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDeliveries.ColumnHeadersHeight = 35;
            this.dgvDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDeliveries.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDeliveries.EnableHeadersVisualStyles = false;
            this.dgvDeliveries.Location = new System.Drawing.Point(12, 60);
            this.dgvDeliveries.MultiSelect = false;
            this.dgvDeliveries.Name = "dgvDeliveries";
            this.dgvDeliveries.RowHeadersVisible = false;
            this.dgvDeliveries.RowTemplate.Height = 35;
            this.dgvDeliveries.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDeliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeliveries.Size = new System.Drawing.Size(776, 378);
            this.dgvDeliveries.StandardTab = true;
            this.dgvDeliveries.TabIndex = 130;
            this.dgvDeliveries.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeliveries_CellValueChanged);
            this.dgvDeliveries.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvDeliveries_DragDrop);
            this.dgvDeliveries.DragOver += new System.Windows.Forms.DragEventHandler(this.dgvDeliveries_DragOver);
            // 
            // lblDrop
            // 
            this.lblDrop.AutoSize = true;
            this.lblDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.lblDrop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrop.Location = new System.Drawing.Point(325, 175);
            this.lblDrop.Name = "lblDrop";
            this.lblDrop.Size = new System.Drawing.Size(149, 17);
            this.lblDrop.TabIndex = 131;
            this.lblDrop.Text = "Drag or Drop Files Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 133;
            this.label2.Text = "Import Excel";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.Location = new System.Drawing.Point(678, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 129;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.Silver;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnClear.Location = new System.Drawing.Point(562, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(110, 35);
            this.btnClear.TabIndex = 129;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.cbologistics.Location = new System.Drawing.Point(204, 24);
            this.cbologistics.Name = "cbologistics";
            this.cbologistics.ShadowDecoration.Parent = this.cbologistics;
            this.cbologistics.Size = new System.Drawing.Size(191, 30);
            this.cbologistics.TabIndex = 137;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(140, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 17);
            this.label11.TabIndex = 138;
            this.label11.Text = "Logistics";
            // 
            // frmImportFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbologistics);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblDrop);
            this.Controls.Add(this.dgvDeliveries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmImportFromExcel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnImport;
        internal System.Windows.Forms.DataGridView dgvDeliveries;
        private System.Windows.Forms.Label lblDrop;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2ComboBox cbologistics;
        private System.Windows.Forms.Label label11;
    }
}