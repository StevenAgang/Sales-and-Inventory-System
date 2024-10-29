namespace Sales_and_Inventory_System
{
    partial class supplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.product_grid = new Guna.UI.WinForms.GunaDataGridView();
            this.delete_btn = new Guna.UI.WinForms.GunaButton();
            this.prod_price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.prod_desc = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.update_btn = new Guna.UI.WinForms.GunaButton();
            this.insert_btn = new Guna.UI.WinForms.GunaButton();
            this.clear_btn = new Guna.UI.WinForms.GunaButton();
            this.search_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.refresh_btn = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.size = new Guna.UI.WinForms.GunaComboBox();
            this.prod_id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // product_grid
            // 
            this.product_grid.AllowUserToAddRows = false;
            this.product_grid.AllowUserToDeleteRows = false;
            this.product_grid.AllowUserToResizeColumns = false;
            this.product_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.product_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.product_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.product_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.product_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.product_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.product_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.NullValue = "0";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.product_grid.ColumnHeadersHeight = 22;
            this.product_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.product_grid.DefaultCellStyle = dataGridViewCellStyle7;
            this.product_grid.EnableHeadersVisualStyles = false;
            this.product_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.product_grid.Location = new System.Drawing.Point(245, 41);
            this.product_grid.MultiSelect = false;
            this.product_grid.Name = "product_grid";
            this.product_grid.ReadOnly = true;
            this.product_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.product_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.product_grid.RowHeadersVisible = false;
            this.product_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_grid.RowTemplate.Height = 50;
            this.product_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.product_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.product_grid.Size = new System.Drawing.Size(740, 618);
            this.product_grid.StandardTab = true;
            this.product_grid.TabIndex = 17;
            this.product_grid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.product_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.product_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.product_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.product_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.product_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.product_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.product_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.product_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.product_grid.ThemeStyle.HeaderStyle.Height = 22;
            this.product_grid.ThemeStyle.ReadOnly = true;
            this.product_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.product_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.product_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.product_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.product_grid.ThemeStyle.RowsStyle.Height = 50;
            this.product_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.product_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.product_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_grid_CellClick);
            this.product_grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.product_grid_DataBindingComplete);
            this.product_grid.MouseLeave += new System.EventHandler(this.product_grid_MouseLeave);
            // 
            // delete_btn
            // 
            this.delete_btn.AnimationHoverSpeed = 0.07F;
            this.delete_btn.AnimationSpeed = 0.03F;
            this.delete_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.delete_btn.BorderColor = System.Drawing.Color.Black;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_btn.FocusedColor = System.Drawing.Color.Empty;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Image = null;
            this.delete_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.delete_btn.Location = new System.Drawing.Point(16, 406);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.delete_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delete_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.delete_btn.OnHoverImage = null;
            this.delete_btn.OnPressedColor = System.Drawing.Color.Black;
            this.delete_btn.Size = new System.Drawing.Size(222, 41);
            this.delete_btn.TabIndex = 18;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // prod_price
            // 
            this.prod_price.BackColor = System.Drawing.Color.White;
            this.prod_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prod_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.prod_price.ForeColor = System.Drawing.Color.Black;
            this.prod_price.HintForeColor = System.Drawing.Color.DimGray;
            this.prod_price.HintText = "Product price";
            this.prod_price.isPassword = false;
            this.prod_price.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.prod_price.LineIdleColor = System.Drawing.Color.Gray;
            this.prod_price.LineMouseHoverColor = System.Drawing.Color.Black;
            this.prod_price.LineThickness = 3;
            this.prod_price.Location = new System.Drawing.Point(16, 255);
            this.prod_price.Margin = new System.Windows.Forms.Padding(4);
            this.prod_price.Name = "prod_price";
            this.prod_price.Size = new System.Drawing.Size(222, 32);
            this.prod_price.TabIndex = 26;
            this.prod_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prod_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.prod_price_KeyPress);
            // 
            // prod_desc
            // 
            this.prod_desc.BackColor = System.Drawing.Color.White;
            this.prod_desc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prod_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.prod_desc.ForeColor = System.Drawing.Color.Black;
            this.prod_desc.HintForeColor = System.Drawing.Color.DimGray;
            this.prod_desc.HintText = "Product name";
            this.prod_desc.isPassword = false;
            this.prod_desc.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.prod_desc.LineIdleColor = System.Drawing.Color.Gray;
            this.prod_desc.LineMouseHoverColor = System.Drawing.Color.Black;
            this.prod_desc.LineThickness = 3;
            this.prod_desc.Location = new System.Drawing.Point(16, 107);
            this.prod_desc.Margin = new System.Windows.Forms.Padding(4);
            this.prod_desc.Name = "prod_desc";
            this.prod_desc.Size = new System.Drawing.Size(222, 32);
            this.prod_desc.TabIndex = 24;
            this.prod_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // update_btn
            // 
            this.update_btn.AnimationHoverSpeed = 0.07F;
            this.update_btn.AnimationSpeed = 0.03F;
            this.update_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.update_btn.BorderColor = System.Drawing.Color.Black;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.update_btn.FocusedColor = System.Drawing.Color.Empty;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Image = null;
            this.update_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.update_btn.Location = new System.Drawing.Point(16, 359);
            this.update_btn.Name = "update_btn";
            this.update_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.update_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.update_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.update_btn.OnHoverImage = null;
            this.update_btn.OnPressedColor = System.Drawing.Color.Black;
            this.update_btn.Size = new System.Drawing.Size(222, 41);
            this.update_btn.TabIndex = 30;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.AnimationHoverSpeed = 0.07F;
            this.insert_btn.AnimationSpeed = 0.03F;
            this.insert_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.insert_btn.BorderColor = System.Drawing.Color.Black;
            this.insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.insert_btn.FocusedColor = System.Drawing.Color.Empty;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.White;
            this.insert_btn.Image = null;
            this.insert_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.insert_btn.Location = new System.Drawing.Point(16, 312);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.insert_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.insert_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.insert_btn.OnHoverImage = null;
            this.insert_btn.OnPressedColor = System.Drawing.Color.Black;
            this.insert_btn.Size = new System.Drawing.Size(222, 41);
            this.insert_btn.TabIndex = 29;
            this.insert_btn.Text = "Add";
            this.insert_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.AnimationHoverSpeed = 0.07F;
            this.clear_btn.AnimationSpeed = 0.03F;
            this.clear_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.clear_btn.BorderColor = System.Drawing.Color.Black;
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clear_btn.FocusedColor = System.Drawing.Color.Empty;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Image = null;
            this.clear_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.clear_btn.Location = new System.Drawing.Point(16, 453);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.clear_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.clear_btn.OnHoverImage = null;
            this.clear_btn.OnPressedColor = System.Drawing.Color.Black;
            this.clear_btn.Size = new System.Drawing.Size(222, 41);
            this.clear_btn.TabIndex = 31;
            this.clear_btn.Text = "Clear input";
            this.clear_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
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
            this.search_txt.Location = new System.Drawing.Point(258, 7);
            this.search_txt.MaxLength = 32767;
            this.search_txt.MinimumSize = new System.Drawing.Size(1, 1);
            this.search_txt.Modified = false;
            this.search_txt.Multiline = false;
            this.search_txt.Name = "search_txt";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.DimGray;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.search_txt.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.DimGray;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Black;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.search_txt.OnIdleState = stateProperties8;
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
            this.search_txt.Size = new System.Drawing.Size(289, 30);
            this.search_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search_txt.TabIndex = 32;
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
            this.refresh_btn.Location = new System.Drawing.Point(868, 14);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.refresh_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh_btn.OnHoverImage = null;
            this.refresh_btn.OnPressedColor = System.Drawing.Color.Black;
            this.refresh_btn.Size = new System.Drawing.Size(91, 25);
            this.refresh_btn.TabIndex = 33;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(13, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Size: Leave NONE if not applicable";
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.Transparent;
            this.size.BaseColor = System.Drawing.Color.White;
            this.size.BorderColor = System.Drawing.Color.Silver;
            this.size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.FocusedColor = System.Drawing.Color.Empty;
            this.size.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.size.ForeColor = System.Drawing.Color.Black;
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "None",
            "Regular",
            "Large",
            "Medium",
            "Small"});
            this.size.Location = new System.Drawing.Point(16, 178);
            this.size.Name = "size";
            this.size.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.size.OnHoverItemForeColor = System.Drawing.Color.White;
            this.size.Size = new System.Drawing.Size(222, 26);
            this.size.TabIndex = 37;
            // 
            // prod_id
            // 
            this.prod_id.AutoSize = true;
            this.prod_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.prod_id.Location = new System.Drawing.Point(13, 55);
            this.prod_id.Name = "prod_id";
            this.prod_id.Size = new System.Drawing.Size(148, 21);
            this.prod_id.TabIndex = 38;
            this.prod_id.Text = "Selected Product ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prod_id);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.prod_price);
            this.Controls.Add(this.prod_desc);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.product_grid);
            this.Name = "supplier";
            this.Size = new System.Drawing.Size(988, 662);
            this.Load += new System.EventHandler(this.supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView product_grid;
        private Guna.UI.WinForms.GunaButton delete_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prod_price;
        private Bunifu.Framework.UI.BunifuMaterialTextbox prod_desc;
        private Guna.UI.WinForms.GunaButton update_btn;
        private Guna.UI.WinForms.GunaButton insert_btn;
        private Guna.UI.WinForms.GunaButton clear_btn;
        private Bunifu.UI.WinForms.BunifuTextBox search_txt;
        private Guna.UI.WinForms.GunaButton refresh_btn;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox size;
        private System.Windows.Forms.Label prod_id;
        private System.Windows.Forms.Button button1;
    }
}
