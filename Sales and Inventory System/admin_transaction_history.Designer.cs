namespace Sales_and_Inventory_System
{
    partial class admin_transaction_history
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_transaction_history));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.current_date = new System.Windows.Forms.Label();
            this.total_records = new System.Windows.Forms.Label();
            this._total = new System.Windows.Forms.Label();
            this.transaction_grid = new Guna.UI.WinForms.GunaDataGridView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.refresh_btn = new Guna.UI.WinForms.GunaButton();
            this.search_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.total_sales = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new Guna.UI.WinForms.GunaDateTimePicker();
            this.date1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.load = new Guna.UI.WinForms.GunaButton();
            this.Export = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // current_date
            // 
            this.current_date.AutoSize = true;
            this.current_date.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.current_date.Location = new System.Drawing.Point(786, 10);
            this.current_date.Name = "current_date";
            this.current_date.Size = new System.Drawing.Size(71, 13);
            this.current_date.TabIndex = 49;
            this.current_date.Text = "datetime";
            // 
            // total_records
            // 
            this.total_records.AutoSize = true;
            this.total_records.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_records.ForeColor = System.Drawing.Color.Green;
            this.total_records.Location = new System.Drawing.Point(129, 633);
            this.total_records.Name = "total_records";
            this.total_records.Size = new System.Drawing.Size(15, 16);
            this.total_records.TabIndex = 47;
            this.total_records.Text = "0";
            // 
            // _total
            // 
            this._total.AutoSize = true;
            this._total.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._total.Location = new System.Drawing.Point(3, 633);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(116, 16);
            this._total.TabIndex = 46;
            this._total.Text = "TOTAL RECORDS:";
            // 
            // transaction_grid
            // 
            this.transaction_grid.AllowUserToAddRows = false;
            this.transaction_grid.AllowUserToDeleteRows = false;
            this.transaction_grid.AllowUserToResizeColumns = false;
            this.transaction_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.transaction_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transaction_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.transaction_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.transaction_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.transaction_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.transaction_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.NullValue = "0";
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.transaction_grid.ColumnHeadersHeight = 22;
            this.transaction_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.transaction_grid.DefaultCellStyle = dataGridViewCellStyle15;
            this.transaction_grid.EnableHeadersVisualStyles = false;
            this.transaction_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.transaction_grid.Location = new System.Drawing.Point(3, 58);
            this.transaction_grid.MultiSelect = false;
            this.transaction_grid.Name = "transaction_grid";
            this.transaction_grid.ReadOnly = true;
            this.transaction_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.transaction_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.transaction_grid.RowHeadersVisible = false;
            this.transaction_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.transaction_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_grid.RowTemplate.Height = 50;
            this.transaction_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transaction_grid.Size = new System.Drawing.Size(982, 534);
            this.transaction_grid.StandardTab = true;
            this.transaction_grid.TabIndex = 43;
            this.transaction_grid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.transaction_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.transaction_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.transaction_grid.MouseLeave += new System.EventHandler(this.transaction_grid_MouseLeave);
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
            this.refresh_btn.Location = new System.Drawing.Point(874, 29);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.refresh_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_btn.OnHoverImage = null;
            this.refresh_btn.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_btn.Size = new System.Drawing.Size(91, 25);
            this.refresh_btn.TabIndex = 50;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
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
            this.search_txt.DefaultFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.search_txt.Location = new System.Drawing.Point(3, 24);
            this.search_txt.MaxLength = 32767;
            this.search_txt.MinimumSize = new System.Drawing.Size(1, 1);
            this.search_txt.Modified = false;
            this.search_txt.Multiline = false;
            this.search_txt.Name = "search_txt";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.DimGray;
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.search_txt.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.DimGray;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Black;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnIdleState = stateProperties16;
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
            this.search_txt.Size = new System.Drawing.Size(260, 30);
            this.search_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search_txt.TabIndex = 45;
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search_txt.TextMarginBottom = 0;
            this.search_txt.TextMarginLeft = 3;
            this.search_txt.TextMarginTop = 1;
            this.search_txt.TextPlaceholder = "Search product";
            this.search_txt.UseSystemPasswordChar = false;
            this.search_txt.WordWrap = true;
            this.search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_txt_KeyPress);
            // 
            // total_sales
            // 
            this.total_sales.AutoSize = true;
            this.total_sales.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_sales.ForeColor = System.Drawing.Color.Green;
            this.total_sales.Location = new System.Drawing.Point(129, 604);
            this.total_sales.Name = "total_sales";
            this.total_sales.Size = new System.Drawing.Size(15, 16);
            this.total_sales.TabIndex = 53;
            this.total_sales.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "TOTAL SALES:";
            // 
            // date
            // 
            this.date.BaseColor = System.Drawing.Color.White;
            this.date.BorderColor = System.Drawing.Color.Silver;
            this.date.CustomFormat = null;
            this.date.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(536, 598);
            this.date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.OnHoverBaseColor = System.Drawing.Color.White;
            this.date.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date.OnPressedColor = System.Drawing.Color.Black;
            this.date.Size = new System.Drawing.Size(121, 30);
            this.date.TabIndex = 54;
            this.date.Text = "25/11/2021";
            this.date.Value = new System.DateTime(2021, 11, 25, 2, 45, 26, 849);
            // 
            // date1
            // 
            this.date1.BaseColor = System.Drawing.Color.White;
            this.date1.BorderColor = System.Drawing.Color.Silver;
            this.date1.CustomFormat = null;
            this.date1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.date1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date1.ForeColor = System.Drawing.Color.Black;
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date1.Location = new System.Drawing.Point(740, 598);
            this.date1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date1.Name = "date1";
            this.date1.OnHoverBaseColor = System.Drawing.Color.White;
            this.date1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.date1.OnPressedColor = System.Drawing.Color.Black;
            this.date1.Size = new System.Drawing.Size(121, 30);
            this.date1.TabIndex = 55;
            this.date1.Text = "25/11/2021";
            this.date1.Value = new System.DateTime(2021, 11, 25, 2, 42, 45, 474);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.label1.Location = new System.Drawing.Point(443, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "FROM DATE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.label2.Location = new System.Drawing.Point(663, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "TO DATE:";
            // 
            // load
            // 
            this.load.AnimationHoverSpeed = 0.07F;
            this.load.AnimationSpeed = 0.03F;
            this.load.BaseColor = System.Drawing.Color.Gray;
            this.load.BorderColor = System.Drawing.Color.Black;
            this.load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load.DialogResult = System.Windows.Forms.DialogResult.None;
            this.load.FocusedColor = System.Drawing.Color.Empty;
            this.load.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load.ForeColor = System.Drawing.Color.White;
            this.load.Image = null;
            this.load.ImageSize = new System.Drawing.Size(20, 20);
            this.load.Location = new System.Drawing.Point(874, 598);
            this.load.Name = "load";
            this.load.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.load.OnHoverBorderColor = System.Drawing.Color.Black;
            this.load.OnHoverForeColor = System.Drawing.Color.White;
            this.load.OnHoverImage = null;
            this.load.OnPressedColor = System.Drawing.Color.Black;
            this.load.Size = new System.Drawing.Size(91, 30);
            this.load.TabIndex = 59;
            this.load.Text = "Load";
            this.load.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // Export
            // 
            this.Export.AnimationHoverSpeed = 0.07F;
            this.Export.AnimationSpeed = 0.03F;
            this.Export.BaseColor = System.Drawing.Color.Gray;
            this.Export.BorderColor = System.Drawing.Color.Black;
            this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Export.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Export.FocusedColor = System.Drawing.Color.Empty;
            this.Export.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.ForeColor = System.Drawing.Color.White;
            this.Export.Image = null;
            this.Export.ImageSize = new System.Drawing.Size(20, 20);
            this.Export.Location = new System.Drawing.Point(771, 29);
            this.Export.Name = "Export";
            this.Export.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Export.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Export.OnHoverForeColor = System.Drawing.Color.White;
            this.Export.OnHoverImage = null;
            this.Export.OnPressedColor = System.Drawing.Color.Black;
            this.Export.Size = new System.Drawing.Size(97, 25);
            this.Export.TabIndex = 60;
            this.Export.Text = "Export to Excel";
            this.Export.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // admin_transaction_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Export);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.total_sales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.current_date);
            this.Controls.Add(this.total_records);
            this.Controls.Add(this._total);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.transaction_grid);
            this.Controls.Add(this.refresh_btn);
            this.Name = "admin_transaction_history";
            this.Size = new System.Drawing.Size(988, 662);
            this.Load += new System.EventHandler(this.admin_transaction_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transaction_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label current_date;
        private System.Windows.Forms.Label total_records;
        private System.Windows.Forms.Label _total;
        private Bunifu.UI.WinForms.BunifuTextBox search_txt;
        private Guna.UI.WinForms.GunaDataGridView transaction_grid;
        private System.Windows.Forms.Timer timer;
        private Guna.UI.WinForms.GunaButton refresh_btn;
        private System.Windows.Forms.Label total_sales;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDateTimePicker date;
        private Guna.UI.WinForms.GunaDateTimePicker date1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton load;
        private Guna.UI.WinForms.GunaButton Export;
    }
}
