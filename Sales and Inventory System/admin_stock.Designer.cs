namespace Sales_and_Inventory_System
{
    partial class admin_stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_stock));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.expired_btn = new Guna.UI.WinForms.GunaButton();
            this.show_all = new Guna.UI.WinForms.GunaButton();
            this.inventory_item = new Guna.UI.WinForms.GunaDataGridView();
            this.search_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.item_quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.item_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.update_btn = new Guna.UI.WinForms.GunaButton();
            this.delete_btn = new Guna.UI.WinForms.GunaButton();
            this.clear_input = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new Guna.UI.WinForms.GunaButton();
            this.prod_id = new System.Windows.Forms.Label();
            this.size = new Guna.UI.WinForms.GunaComboBox();
            this.refresh = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_item)).BeginInit();
            this.SuspendLayout();
            // 
            // expired_btn
            // 
            this.expired_btn.AnimationHoverSpeed = 0.07F;
            this.expired_btn.AnimationSpeed = 0.03F;
            this.expired_btn.BaseColor = System.Drawing.Color.Gray;
            this.expired_btn.BorderColor = System.Drawing.Color.Black;
            this.expired_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expired_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.expired_btn.FocusedColor = System.Drawing.Color.Empty;
            this.expired_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expired_btn.ForeColor = System.Drawing.Color.White;
            this.expired_btn.Image = null;
            this.expired_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.expired_btn.Location = new System.Drawing.Point(683, 43);
            this.expired_btn.Name = "expired_btn";
            this.expired_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.expired_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.expired_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.expired_btn.OnHoverImage = null;
            this.expired_btn.OnPressedColor = System.Drawing.Color.Black;
            this.expired_btn.Size = new System.Drawing.Size(91, 25);
            this.expired_btn.TabIndex = 20;
            this.expired_btn.Text = "Expired";
            this.expired_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expired_btn.Click += new System.EventHandler(this.expired_btn_Click);
            // 
            // show_all
            // 
            this.show_all.AnimationHoverSpeed = 0.07F;
            this.show_all.AnimationSpeed = 0.03F;
            this.show_all.BaseColor = System.Drawing.Color.Gray;
            this.show_all.BorderColor = System.Drawing.Color.Black;
            this.show_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.show_all.DialogResult = System.Windows.Forms.DialogResult.None;
            this.show_all.Enabled = false;
            this.show_all.FocusedColor = System.Drawing.Color.Empty;
            this.show_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_all.ForeColor = System.Drawing.Color.White;
            this.show_all.Image = null;
            this.show_all.ImageSize = new System.Drawing.Size(20, 20);
            this.show_all.Location = new System.Drawing.Point(780, 43);
            this.show_all.Name = "show_all";
            this.show_all.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.show_all.OnHoverBorderColor = System.Drawing.Color.Black;
            this.show_all.OnHoverForeColor = System.Drawing.Color.White;
            this.show_all.OnHoverImage = null;
            this.show_all.OnPressedColor = System.Drawing.Color.Black;
            this.show_all.Size = new System.Drawing.Size(91, 25);
            this.show_all.TabIndex = 19;
            this.show_all.Text = "Item in Stock";
            this.show_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // inventory_item
            // 
            this.inventory_item.AllowUserToAddRows = false;
            this.inventory_item.AllowUserToDeleteRows = false;
            this.inventory_item.AllowUserToResizeColumns = false;
            this.inventory_item.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_item.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.inventory_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventory_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inventory_item.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inventory_item.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inventory_item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventory_item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inventory_item.ColumnHeadersHeight = 22;
            this.inventory_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventory_item.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventory_item.EnableHeadersVisualStyles = false;
            this.inventory_item.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.inventory_item.Location = new System.Drawing.Point(241, 69);
            this.inventory_item.MultiSelect = false;
            this.inventory_item.Name = "inventory_item";
            this.inventory_item.ReadOnly = true;
            this.inventory_item.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventory_item.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.inventory_item.RowHeadersVisible = false;
            this.inventory_item.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_item.RowTemplate.Height = 50;
            this.inventory_item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inventory_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventory_item.Size = new System.Drawing.Size(744, 590);
            this.inventory_item.TabIndex = 15;
            this.inventory_item.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.inventory_item.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.inventory_item.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_item.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.inventory_item.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.inventory_item.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.inventory_item.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inventory_item.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.inventory_item.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.inventory_item.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inventory_item.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_item.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.inventory_item.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inventory_item.ThemeStyle.HeaderStyle.Height = 22;
            this.inventory_item.ThemeStyle.ReadOnly = true;
            this.inventory_item.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.inventory_item.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inventory_item.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_item.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.inventory_item.ThemeStyle.RowsStyle.Height = 50;
            this.inventory_item.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.inventory_item.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.inventory_item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventory_item_CellClick);
            this.inventory_item.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.inventory_item_DataBindingComplete);
            this.inventory_item.MouseLeave += new System.EventHandler(this.inventory_item_MouseLeave);
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
            this.search_txt.Location = new System.Drawing.Point(241, 32);
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
            this.search_txt.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search_txt.PlaceholderText = "Search item";
            this.search_txt.ReadOnly = false;
            this.search_txt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.search_txt.SelectedText = "";
            this.search_txt.SelectionLength = 0;
            this.search_txt.SelectionStart = 0;
            this.search_txt.ShortcutsEnabled = true;
            this.search_txt.Size = new System.Drawing.Size(267, 36);
            this.search_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search_txt.TabIndex = 16;
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search_txt.TextMarginBottom = 0;
            this.search_txt.TextMarginLeft = 3;
            this.search_txt.TextMarginTop = 1;
            this.search_txt.TextPlaceholder = "Search item";
            this.search_txt.UseSystemPasswordChar = false;
            this.search_txt.WordWrap = true;
            this.search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_txt_KeyPress);
            // 
            // item_quantity
            // 
            this.item_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.item_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity.ForeColor = System.Drawing.Color.Black;
            this.item_quantity.HintForeColor = System.Drawing.Color.Silver;
            this.item_quantity.HintText = "Quantity";
            this.item_quantity.isPassword = false;
            this.item_quantity.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.item_quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.item_quantity.LineMouseHoverColor = System.Drawing.Color.Black;
            this.item_quantity.LineThickness = 3;
            this.item_quantity.Location = new System.Drawing.Point(4, 264);
            this.item_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(231, 32);
            this.item_quantity.TabIndex = 23;
            this.item_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.item_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.item_quantity_KeyDown);
            this.item_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_quantity_KeyPress);
            // 
            // item_name
            // 
            this.item_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.item_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name.ForeColor = System.Drawing.Color.Black;
            this.item_name.HintForeColor = System.Drawing.Color.Silver;
            this.item_name.HintText = "Name";
            this.item_name.isPassword = false;
            this.item_name.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.item_name.LineIdleColor = System.Drawing.Color.Gray;
            this.item_name.LineMouseHoverColor = System.Drawing.Color.Black;
            this.item_name.LineThickness = 3;
            this.item_name.Location = new System.Drawing.Point(4, 122);
            this.item_name.Margin = new System.Windows.Forms.Padding(4);
            this.item_name.Name = "item_name";
            this.item_name.Size = new System.Drawing.Size(231, 32);
            this.item_name.TabIndex = 21;
            this.item_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.item_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.item_name_KeyDown);
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
            this.update_btn.Location = new System.Drawing.Point(6, 351);
            this.update_btn.Name = "update_btn";
            this.update_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.update_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.update_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.update_btn.OnHoverImage = null;
            this.update_btn.OnPressedColor = System.Drawing.Color.Black;
            this.update_btn.Size = new System.Drawing.Size(229, 41);
            this.update_btn.TabIndex = 26;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
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
            this.delete_btn.Location = new System.Drawing.Point(6, 398);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.delete_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delete_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.delete_btn.OnHoverImage = null;
            this.delete_btn.OnPressedColor = System.Drawing.Color.Black;
            this.delete_btn.Size = new System.Drawing.Size(229, 41);
            this.delete_btn.TabIndex = 27;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // clear_input
            // 
            this.clear_input.AnimationHoverSpeed = 0.07F;
            this.clear_input.AnimationSpeed = 0.03F;
            this.clear_input.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.clear_input.BorderColor = System.Drawing.Color.Black;
            this.clear_input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_input.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clear_input.FocusedColor = System.Drawing.Color.Empty;
            this.clear_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_input.ForeColor = System.Drawing.Color.White;
            this.clear_input.Image = null;
            this.clear_input.ImageSize = new System.Drawing.Size(20, 20);
            this.clear_input.Location = new System.Drawing.Point(6, 445);
            this.clear_input.Name = "clear_input";
            this.clear_input.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.clear_input.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear_input.OnHoverForeColor = System.Drawing.Color.White;
            this.clear_input.OnHoverImage = null;
            this.clear_input.OnPressedColor = System.Drawing.Color.Black;
            this.clear_input.Size = new System.Drawing.Size(229, 41);
            this.clear_input.TabIndex = 28;
            this.clear_input.Text = "Clear input";
            this.clear_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear_input.Click += new System.EventHandler(this.clear_input_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(3, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Leave none if not applicable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(3, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "N/A for deleting item";
            // 
            // clear
            // 
            this.clear.AnimationHoverSpeed = 0.07F;
            this.clear.AnimationSpeed = 0.03F;
            this.clear.BaseColor = System.Drawing.Color.Gray;
            this.clear.BorderColor = System.Drawing.Color.Black;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.clear.FocusedColor = System.Drawing.Color.Empty;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Image = null;
            this.clear.ImageSize = new System.Drawing.Size(20, 20);
            this.clear.Location = new System.Drawing.Point(586, 43);
            this.clear.Name = "clear";
            this.clear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.clear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear.OnHoverForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clear.OnHoverImage = null;
            this.clear.OnPressedColor = System.Drawing.Color.Black;
            this.clear.Size = new System.Drawing.Size(91, 25);
            this.clear.TabIndex = 41;
            this.clear.Text = "Clear";
            this.clear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear.Visible = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // prod_id
            // 
            this.prod_id.AutoSize = true;
            this.prod_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.prod_id.Location = new System.Drawing.Point(3, 69);
            this.prod_id.Name = "prod_id";
            this.prod_id.Size = new System.Drawing.Size(125, 21);
            this.prod_id.TabIndex = 42;
            this.prod_id.Text = "Selected Item ID:";
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.Transparent;
            this.size.BaseColor = System.Drawing.Color.White;
            this.size.BorderColor = System.Drawing.Color.Silver;
            this.size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.FocusedColor = System.Drawing.Color.Empty;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.ForeColor = System.Drawing.Color.Black;
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "None",
            "Regular",
            "Large",
            "Medium",
            "Small"});
            this.size.Location = new System.Drawing.Point(4, 197);
            this.size.Name = "size";
            this.size.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.size.OnHoverItemForeColor = System.Drawing.Color.White;
            this.size.Size = new System.Drawing.Size(231, 23);
            this.size.TabIndex = 43;
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
            this.refresh.Location = new System.Drawing.Point(877, 43);
            this.refresh.Name = "refresh";
            this.refresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.refresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.refresh.OnHoverForeColor = System.Drawing.Color.White;
            this.refresh.OnHoverImage = null;
            this.refresh.OnPressedColor = System.Drawing.Color.Black;
            this.refresh.Size = new System.Drawing.Size(91, 25);
            this.refresh.TabIndex = 44;
            this.refresh.Text = "Refresh";
            this.refresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // admin_stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.size);
            this.Controls.Add(this.prod_id);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear_input);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.item_quantity);
            this.Controls.Add(this.item_name);
            this.Controls.Add(this.expired_btn);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.inventory_item);
            this.Name = "admin_stock";
            this.Size = new System.Drawing.Size(988, 662);
            this.Load += new System.EventHandler(this.admin_stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton expired_btn;
        private Guna.UI.WinForms.GunaButton show_all;
        private Bunifu.UI.WinForms.BunifuTextBox search_txt;
        private Guna.UI.WinForms.GunaDataGridView inventory_item;
        private Bunifu.Framework.UI.BunifuMaterialTextbox item_quantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox item_name;
        private Guna.UI.WinForms.GunaButton update_btn;
        private Guna.UI.WinForms.GunaButton delete_btn;
        private Guna.UI.WinForms.GunaButton clear_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton clear;
        private System.Windows.Forms.Label prod_id;
        private Guna.UI.WinForms.GunaComboBox size;
        private Guna.UI.WinForms.GunaButton refresh;
    }
}
