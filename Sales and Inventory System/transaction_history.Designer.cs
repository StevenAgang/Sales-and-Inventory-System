namespace Sales_and_Inventory_System
{
    partial class transaction_history
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transaction_history));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.transaction_grid = new Guna.UI.WinForms.GunaDataGridView();
            this.search_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.total_sales = new System.Windows.Forms.Label();
            this._total = new System.Windows.Forms.Label();
            this.current_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.refresh_btn = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // transaction_grid
            // 
            this.transaction_grid.AllowUserToAddRows = false;
            this.transaction_grid.AllowUserToDeleteRows = false;
            this.transaction_grid.AllowUserToResizeColumns = false;
            this.transaction_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.transaction_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transaction_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transaction_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.transaction_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transaction_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transaction_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.transaction_grid.ColumnHeadersHeight = 22;
            this.transaction_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transaction_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.transaction_grid.EnableHeadersVisualStyles = false;
            this.transaction_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.transaction_grid.Location = new System.Drawing.Point(3, 55);
            this.transaction_grid.MultiSelect = false;
            this.transaction_grid.Name = "transaction_grid";
            this.transaction_grid.ReadOnly = true;
            this.transaction_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.transaction_grid.RowHeadersVisible = false;
            this.transaction_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transaction_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_grid.RowTemplate.Height = 50;
            this.transaction_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transaction_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_grid.Size = new System.Drawing.Size(982, 604);
            this.transaction_grid.StandardTab = true;
            this.transaction_grid.TabIndex = 18;
            this.transaction_grid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.transaction_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.transaction_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.transaction_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.transaction_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.transaction_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.transaction_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.transaction_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.transaction_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.transaction_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.transaction_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.transaction_grid.ThemeStyle.HeaderStyle.Height = 22;
            this.transaction_grid.ThemeStyle.ReadOnly = true;
            this.transaction_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.transaction_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transaction_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.transaction_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.transaction_grid.ThemeStyle.RowsStyle.Height = 50;
            this.transaction_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.transaction_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.transaction_grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.transaction_grid_DataBindingComplete);
            this.transaction_grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.transaction_grid_RowsAdded);
            this.transaction_grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.transaction_grid_RowsRemoved);
            this.transaction_grid.MouseLeave += new System.EventHandler(this.transaction_grid_MouseLeave);
            // 
            // search_txt
            // 
            this.search_txt.AcceptsReturn = false;
            this.search_txt.AcceptsTab = false;
            this.search_txt.AnimationSpeed = 200;
            this.search_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.search_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.search_txt.AutoSizeHeight = true;
            this.search_txt.BackColor = System.Drawing.Color.Transparent;
            this.search_txt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_txt.BackgroundImage")));
            this.search_txt.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.search_txt.BorderColorDisabled = System.Drawing.Color.DimGray;
            this.search_txt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.search_txt.BorderColorIdle = System.Drawing.Color.DimGray;
            this.search_txt.BorderRadius = 35;
            this.search_txt.BorderThickness = 1;
            this.search_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.DefaultFont = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.DefaultText = "";
            this.search_txt.FillColor = System.Drawing.Color.White;
            this.search_txt.ForeColor = System.Drawing.Color.Black;
            this.search_txt.HideSelection = true;
            this.search_txt.IconLeft = null;
            this.search_txt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.IconPadding = 10;
            this.search_txt.IconRight = null;
            this.search_txt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.search_txt.Lines = new string[0];
            this.search_txt.Location = new System.Drawing.Point(3, 21);
            this.search_txt.MaxLength = 32767;
            this.search_txt.MinimumSize = new System.Drawing.Size(1, 1);
            this.search_txt.Modified = false;
            this.search_txt.Multiline = false;
            this.search_txt.Name = "search_txt";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.DimGray;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.search_txt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DimGray;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Black;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnIdleState = stateProperties4;
            this.search_txt.Padding = new System.Windows.Forms.Padding(3);
            this.search_txt.PasswordChar = '\0';
            this.search_txt.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.search_txt.PlaceholderText = "Search product";
            this.search_txt.ReadOnly = false;
            this.search_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_txt.SelectedText = "";
            this.search_txt.SelectionLength = 0;
            this.search_txt.SelectionStart = 0;
            this.search_txt.ShortcutsEnabled = true;
            this.search_txt.Size = new System.Drawing.Size(304, 30);
            this.search_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search_txt.TabIndex = 33;
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search_txt.TextMarginBottom = 0;
            this.search_txt.TextMarginLeft = 3;
            this.search_txt.TextMarginTop = 1;
            this.search_txt.TextPlaceholder = "Search product";
            this.search_txt.UseSystemPasswordChar = false;
            this.search_txt.WordWrap = true;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            this.search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_txt_KeyPress);
            // 
            // total_sales
            // 
            this.total_sales.AutoSize = true;
            this.total_sales.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_sales.ForeColor = System.Drawing.Color.Green;
            this.total_sales.Location = new System.Drawing.Point(706, 32);
            this.total_sales.Name = "total_sales";
            this.total_sales.Size = new System.Drawing.Size(0, 16);
            this.total_sales.TabIndex = 39;
            // 
            // _total
            // 
            this._total.AutoSize = true;
            this._total.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._total.Location = new System.Drawing.Point(556, 32);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(143, 16);
            this._total.TabIndex = 38;
            this._total.Text = "TOTAL SALES TODAY:";
            // 
            // current_date
            // 
            this.current_date.AutoSize = true;
            this.current_date.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.current_date.Location = new System.Drawing.Point(609, 8);
            this.current_date.Name = "current_date";
            this.current_date.Size = new System.Drawing.Size(0, 13);
            this.current_date.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "DATE:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // refresh_btn
            // 
            this.refresh_btn.AnimationHoverSpeed = 0.07F;
            this.refresh_btn.AnimationSpeed = 0.03F;
            this.refresh_btn.BaseColor = System.Drawing.Color.Gray;
            this.refresh_btn.BorderColor = System.Drawing.Color.Black;
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.refresh_btn.FocusedColor = System.Drawing.Color.Empty;
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.Image = null;
            this.refresh_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.refresh_btn.Location = new System.Drawing.Point(874, 26);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.refresh_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_btn.OnHoverImage = null;
            this.refresh_btn.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_btn.Size = new System.Drawing.Size(91, 25);
            this.refresh_btn.TabIndex = 42;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // transaction_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.current_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total_sales);
            this.Controls.Add(this._total);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.transaction_grid);
            this.Name = "transaction_history";
            this.Size = new System.Drawing.Size(988, 662);
            this.Load += new System.EventHandler(this.transaction_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView transaction_grid;
        private Bunifu.UI.WinForms.BunifuTextBox search_txt;
        private System.Windows.Forms.Label total_sales;
        private System.Windows.Forms.Label _total;
        private System.Windows.Forms.Label current_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer;
        private Guna.UI.WinForms.GunaButton refresh_btn;
    }
}
