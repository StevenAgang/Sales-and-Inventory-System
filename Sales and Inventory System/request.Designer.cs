namespace Sales_and_Inventory_System
{
    partial class request
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.approval = new Guna.UI.WinForms.GunaDataGridView();
            this.refresh = new Guna.UI.WinForms.GunaButton();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Decline = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.approval)).BeginInit();
            this.SuspendLayout();
            // 
            // approval
            // 
            this.approval.AllowUserToAddRows = false;
            this.approval.AllowUserToDeleteRows = false;
            this.approval.AllowUserToResizeColumns = false;
            this.approval.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approval.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.approval.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.approval.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.approval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.approval.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.approval.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approval.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.approval.ColumnHeadersHeight = 22;
            this.approval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.approval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.Decline});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.approval.DefaultCellStyle = dataGridViewCellStyle5;
            this.approval.EnableHeadersVisualStyles = false;
            this.approval.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.approval.Location = new System.Drawing.Point(3, 44);
            this.approval.MultiSelect = false;
            this.approval.Name = "approval";
            this.approval.ReadOnly = true;
            this.approval.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.approval.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.approval.RowHeadersVisible = false;
            this.approval.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approval.RowTemplate.Height = 50;
            this.approval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.approval.Size = new System.Drawing.Size(982, 615);
            this.approval.TabIndex = 18;
            this.approval.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.approval.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.approval.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approval.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.approval.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.approval.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.approval.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.approval.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.approval.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.approval.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.approval.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approval.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.approval.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.approval.ThemeStyle.HeaderStyle.Height = 22;
            this.approval.ThemeStyle.ReadOnly = true;
            this.approval.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.approval.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.approval.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.approval.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.approval.ThemeStyle.RowsStyle.Height = 50;
            this.approval.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.approval.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.approval.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.approval_CellContentClick);
            this.approval.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.approval_DataBindingComplete);
            this.approval.MouseLeave += new System.EventHandler(this.approval_MouseLeave);
            // 
            // refresh
            // 
            this.refresh.AnimationHoverSpeed = 0.07F;
            this.refresh.AnimationSpeed = 0.03F;
            this.refresh.BaseColor = System.Drawing.Color.Gray;
            this.refresh.BorderColor = System.Drawing.Color.Black;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refresh.FocusedColor = System.Drawing.Color.Empty;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.ForeColor = System.Drawing.Color.White;
            this.refresh.Image = null;
            this.refresh.ImageSize = new System.Drawing.Size(20, 20);
            this.refresh.Location = new System.Drawing.Point(891, 17);
            this.refresh.Name = "refresh";
            this.refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh.OnHoverImage = null;
            this.refresh.OnPressedColor = System.Drawing.Color.Black;
            this.refresh.Size = new System.Drawing.Size(91, 25);
            this.refresh.TabIndex = 45;
            this.refresh.Text = "Refresh";
            this.refresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Action
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Action.DefaultCellStyle = dataGridViewCellStyle3;
            this.Action.HeaderText = "Approve";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "Approve";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // Decline
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Decline.DefaultCellStyle = dataGridViewCellStyle4;
            this.Decline.HeaderText = "Decline";
            this.Decline.Name = "Decline";
            this.Decline.ReadOnly = true;
            this.Decline.Text = "Decline";
            this.Decline.UseColumnTextForButtonValue = true;
            // 
            // request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.approval);
            this.Name = "request";
            this.Size = new System.Drawing.Size(988, 662);
            this.Load += new System.EventHandler(this.request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.approval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView approval;
        private Guna.UI.WinForms.GunaButton refresh;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.DataGridViewButtonColumn Decline;
    }
}
