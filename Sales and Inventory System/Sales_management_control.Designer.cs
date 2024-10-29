namespace Sales_and_Inventory_System
{
    partial class sales_management_control
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
            this.prod_quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.record_grid = new Guna.UI.WinForms.GunaDataGridView();
            this.Product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeorgrams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insert_btn = new Guna.UI.WinForms.GunaButton();
            this.clear_btn = new Guna.UI.WinForms.GunaButton();
            this.delete_btn = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.regular_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.senior_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.update_btn = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.transaction_number = new System.Windows.Forms.Label();
            this.current_date = new System.Windows.Forms.Label();
            this._total = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lavel = new System.Windows.Forms.Label();
            this.order_total = new System.Windows.Forms.Label();
            this.cust_money = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cust_change = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.tot_price = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.prod_price = new System.Windows.Forms.Label();
            this.prod_desc = new Bunifu.UI.WinForms.BunifuDropdown();
            this.prod_size = new Bunifu.UI.WinForms.BunifuDropdown();
            this.id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.record_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // prod_quantity
            // 
            this.prod_quantity.BackColor = System.Drawing.Color.White;
            this.prod_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prod_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.prod_quantity.ForeColor = System.Drawing.Color.Black;
            this.prod_quantity.HintForeColor = System.Drawing.Color.Gray;
            this.prod_quantity.HintText = "Quantity";
            this.prod_quantity.isPassword = false;
            this.prod_quantity.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.prod_quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.prod_quantity.LineMouseHoverColor = System.Drawing.Color.Black;
            this.prod_quantity.LineThickness = 3;
            this.prod_quantity.Location = new System.Drawing.Point(9, 319);
            this.prod_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.prod_quantity.Name = "prod_quantity";
            this.prod_quantity.Size = new System.Drawing.Size(260, 32);
            this.prod_quantity.TabIndex = 14;
            this.prod_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prod_quantity.OnValueChanged += new System.EventHandler(this.prod_quantity_OnValueChanged);
            this.prod_quantity.Click += new System.EventHandler(this.prod_quantity_Click);
            this.prod_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cust_money_KeyDown);
            this.prod_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cust_money_KeyPress);
            // 
            // record_grid
            // 
            this.record_grid.AllowUserToAddRows = false;
            this.record_grid.AllowUserToResizeColumns = false;
            this.record_grid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.record_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.record_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.record_grid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.record_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.record_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.record_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.record_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.record_grid.ColumnHeadersHeight = 22;
            this.record_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.record_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_id,
            this.product_desc,
            this.sizeorgrams,
            this.quantity,
            this.product_price,
            this.total_price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.record_grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.record_grid.EnableHeadersVisualStyles = false;
            this.record_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.record_grid.Location = new System.Drawing.Point(289, 74);
            this.record_grid.MultiSelect = false;
            this.record_grid.Name = "record_grid";
            this.record_grid.ReadOnly = true;
            this.record_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.record_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.record_grid.RowHeadersVisible = false;
            this.record_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_grid.RowTemplate.Height = 50;
            this.record_grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.record_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.record_grid.Size = new System.Drawing.Size(697, 342);
            this.record_grid.StandardTab = true;
            this.record_grid.TabIndex = 16;
            this.record_grid.TabStop = false;
            this.record_grid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.WetAsphalt;
            this.record_grid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.record_grid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_grid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.record_grid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.record_grid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.record_grid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.record_grid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.record_grid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.record_grid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.record_grid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record_grid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.record_grid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.record_grid.ThemeStyle.HeaderStyle.Height = 22;
            this.record_grid.ThemeStyle.ReadOnly = true;
            this.record_grid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.record_grid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.record_grid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.record_grid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.record_grid.ThemeStyle.RowsStyle.Height = 50;
            this.record_grid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.record_grid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.record_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.record_grid_CellClick_1);
            this.record_grid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.record_grid_RowsAdded);
            this.record_grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.record_grid_RowsRemoved);
            this.record_grid.MouseLeave += new System.EventHandler(this.record_grid_MouseLeave);
            // 
            // Product_id
            // 
            this.Product_id.HeaderText = "Product id";
            this.Product_id.Name = "Product_id";
            this.Product_id.ReadOnly = true;
            // 
            // product_desc
            // 
            this.product_desc.HeaderText = "Description";
            this.product_desc.Name = "product_desc";
            this.product_desc.ReadOnly = true;
            // 
            // sizeorgrams
            // 
            this.sizeorgrams.HeaderText = "Size";
            this.sizeorgrams.Name = "sizeorgrams";
            this.sizeorgrams.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // product_price
            // 
            this.product_price.HeaderText = "Product Price";
            this.product_price.Name = "product_price";
            this.product_price.ReadOnly = true;
            // 
            // total_price
            // 
            this.total_price.HeaderText = "Total Price";
            this.total_price.Name = "total_price";
            this.total_price.ReadOnly = true;
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
            this.insert_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.White;
            this.insert_btn.Image = null;
            this.insert_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.insert_btn.Location = new System.Drawing.Point(5, 448);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.insert_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.insert_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.insert_btn.OnHoverImage = null;
            this.insert_btn.OnPressedColor = System.Drawing.Color.Black;
            this.insert_btn.Size = new System.Drawing.Size(221, 41);
            this.insert_btn.TabIndex = 17;
            this.insert_btn.Text = "INSERT ORDER";
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
            this.clear_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Image = null;
            this.clear_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.clear_btn.Location = new System.Drawing.Point(5, 495);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.clear_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.clear_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.clear_btn.OnHoverImage = null;
            this.clear_btn.OnPressedColor = System.Drawing.Color.Black;
            this.clear_btn.Size = new System.Drawing.Size(221, 41);
            this.clear_btn.TabIndex = 18;
            this.clear_btn.Text = "Clear input";
            this.clear_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.AnimationHoverSpeed = 0.07F;
            this.delete_btn.AnimationSpeed = 0.03F;
            this.delete_btn.BaseColor = System.Drawing.Color.Gray;
            this.delete_btn.BorderColor = System.Drawing.Color.Black;
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.delete_btn.FocusedColor = System.Drawing.Color.Empty;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Image = null;
            this.delete_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.delete_btn.Location = new System.Drawing.Point(853, 422);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.delete_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.delete_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.delete_btn.OnHoverImage = null;
            this.delete_btn.OnPressedColor = System.Drawing.Color.Black;
            this.delete_btn.Size = new System.Drawing.Size(116, 28);
            this.delete_btn.TabIndex = 25;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = null;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(401, 606);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(221, 41);
            this.gunaButton2.TabIndex = 26;
            this.gunaButton2.Text = "Save";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // regular_btn
            // 
            this.regular_btn.AnimationHoverSpeed = 0.07F;
            this.regular_btn.AnimationSpeed = 0.03F;
            this.regular_btn.BackColor = System.Drawing.Color.Gray;
            this.regular_btn.BaseColor = System.Drawing.Color.Transparent;
            this.regular_btn.BorderColor = System.Drawing.Color.Black;
            this.regular_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.regular_btn.Checked = true;
            this.regular_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.regular_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.regular_btn.CheckedForeColor = System.Drawing.Color.White;
            this.regular_btn.CheckedImage = null;
            this.regular_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.regular_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regular_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.regular_btn.Enabled = false;
            this.regular_btn.FocusedColor = System.Drawing.Color.Empty;
            this.regular_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regular_btn.ForeColor = System.Drawing.Color.White;
            this.regular_btn.Image = null;
            this.regular_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.regular_btn.LineColor = System.Drawing.Color.Transparent;
            this.regular_btn.LineLeft = 2;
            this.regular_btn.Location = new System.Drawing.Point(288, 39);
            this.regular_btn.Name = "regular_btn";
            this.regular_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.regular_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.regular_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.regular_btn.OnHoverImage = null;
            this.regular_btn.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.regular_btn.OnPressedColor = System.Drawing.Color.DarkRed;
            this.regular_btn.OnPressedDepth = 0;
            this.regular_btn.Size = new System.Drawing.Size(107, 29);
            this.regular_btn.TabIndex = 27;
            this.regular_btn.Text = "Regular";
            this.regular_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regular_btn.Click += new System.EventHandler(this.regular_btn_Click);
            // 
            // senior_btn
            // 
            this.senior_btn.AnimationHoverSpeed = 0.07F;
            this.senior_btn.AnimationSpeed = 0.03F;
            this.senior_btn.BackColor = System.Drawing.Color.Gray;
            this.senior_btn.BaseColor = System.Drawing.Color.Transparent;
            this.senior_btn.BorderColor = System.Drawing.Color.Black;
            this.senior_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.senior_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.senior_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.senior_btn.CheckedForeColor = System.Drawing.Color.White;
            this.senior_btn.CheckedImage = null;
            this.senior_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.senior_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.senior_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.senior_btn.FocusedColor = System.Drawing.Color.Empty;
            this.senior_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senior_btn.ForeColor = System.Drawing.Color.White;
            this.senior_btn.Image = null;
            this.senior_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.senior_btn.LineColor = System.Drawing.Color.Transparent;
            this.senior_btn.LineLeft = 2;
            this.senior_btn.Location = new System.Drawing.Point(401, 39);
            this.senior_btn.Name = "senior_btn";
            this.senior_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.senior_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.senior_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.senior_btn.OnHoverImage = null;
            this.senior_btn.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.senior_btn.OnPressedColor = System.Drawing.Color.DarkRed;
            this.senior_btn.OnPressedDepth = 0;
            this.senior_btn.Size = new System.Drawing.Size(107, 29);
            this.senior_btn.TabIndex = 28;
            this.senior_btn.Text = "Senior";
            this.senior_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.senior_btn.Click += new System.EventHandler(this.senior_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.AnimationHoverSpeed = 0.07F;
            this.update_btn.AnimationSpeed = 0.03F;
            this.update_btn.BaseColor = System.Drawing.Color.Gray;
            this.update_btn.BorderColor = System.Drawing.Color.Black;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.update_btn.FocusedColor = System.Drawing.Color.Empty;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Image = null;
            this.update_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.update_btn.Location = new System.Drawing.Point(731, 422);
            this.update_btn.Name = "update_btn";
            this.update_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.update_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.update_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.update_btn.OnHoverImage = null;
            this.update_btn.OnPressedColor = System.Drawing.Color.Black;
            this.update_btn.Size = new System.Drawing.Size(116, 28);
            this.update_btn.TabIndex = 29;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "TRANSACTION #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(752, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "DATE:";
            // 
            // transaction_number
            // 
            this.transaction_number.AutoSize = true;
            this.transaction_number.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaction_number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.transaction_number.Location = new System.Drawing.Point(870, 31);
            this.transaction_number.Name = "transaction_number";
            this.transaction_number.Size = new System.Drawing.Size(0, 13);
            this.transaction_number.TabIndex = 32;
            // 
            // current_date
            // 
            this.current_date.AutoSize = true;
            this.current_date.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.current_date.Location = new System.Drawing.Point(799, 51);
            this.current_date.Name = "current_date";
            this.current_date.Size = new System.Drawing.Size(0, 13);
            this.current_date.TabIndex = 33;
            // 
            // _total
            // 
            this._total.AutoSize = true;
            this._total.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._total.Location = new System.Drawing.Point(285, 477);
            this._total.Name = "_total";
            this._total.Size = new System.Drawing.Size(53, 16);
            this._total.TabIndex = 34;
            this._total.Text = "TOTAL:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(285, 516);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 16);
            this.label.TabIndex = 35;
            this.label.Text = "AMOUNT TENDERED:";
            // 
            // lavel
            // 
            this.lavel.AutoSize = true;
            this.lavel.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lavel.Location = new System.Drawing.Point(285, 552);
            this.lavel.Name = "lavel";
            this.lavel.Size = new System.Drawing.Size(65, 16);
            this.lavel.TabIndex = 36;
            this.lavel.Text = "CHANGE:";
            // 
            // order_total
            // 
            this.order_total.AutoSize = true;
            this.order_total.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_total.ForeColor = System.Drawing.Color.Green;
            this.order_total.Location = new System.Drawing.Point(512, 477);
            this.order_total.Name = "order_total";
            this.order_total.Size = new System.Drawing.Size(0, 16);
            this.order_total.TabIndex = 37;
            // 
            // cust_money
            // 
            this.cust_money.BackColor = System.Drawing.Color.White;
            this.cust_money.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cust_money.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cust_money.ForeColor = System.Drawing.Color.Black;
            this.cust_money.HintForeColor = System.Drawing.Color.Black;
            this.cust_money.HintText = "Money";
            this.cust_money.isPassword = false;
            this.cust_money.LineFocusedColor = System.Drawing.Color.Black;
            this.cust_money.LineIdleColor = System.Drawing.Color.Gray;
            this.cust_money.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.cust_money.LineThickness = 3;
            this.cust_money.Location = new System.Drawing.Point(488, 503);
            this.cust_money.Margin = new System.Windows.Forms.Padding(4);
            this.cust_money.Name = "cust_money";
            this.cust_money.Size = new System.Drawing.Size(134, 29);
            this.cust_money.TabIndex = 38;
            this.cust_money.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cust_money.OnValueChanged += new System.EventHandler(this.cust_money_OnValueChanged);
            this.cust_money.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cust_money_KeyDown_1);
            this.cust_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // cust_change
            // 
            this.cust_change.AutoSize = true;
            this.cust_change.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_change.ForeColor = System.Drawing.Color.Red;
            this.cust_change.Location = new System.Drawing.Point(512, 552);
            this.cust_change.Name = "cust_change";
            this.cust_change.Size = new System.Drawing.Size(0, 16);
            this.cust_change.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "DISCOUNT:";
            this.label3.Visible = false;
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.Color.Green;
            this.discount.Location = new System.Drawing.Point(512, 443);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(32, 16);
            this.discount.TabIndex = 41;
            this.discount.Text = "20%";
            this.discount.Visible = false;
            // 
            // time
            // 
            this.time.Enabled = true;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // tot_price
            // 
            this.tot_price.AutoSize = true;
            this.tot_price.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_price.ForeColor = System.Drawing.Color.Green;
            this.tot_price.Location = new System.Drawing.Point(4, 386);
            this.tot_price.Name = "tot_price";
            this.tot_price.Size = new System.Drawing.Size(26, 30);
            this.tot_price.TabIndex = 42;
            this.tot_price.Text = "0";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.size.Location = new System.Drawing.Point(4, 195);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(35, 20);
            this.size.TabIndex = 44;
            this.size.Text = "Size";
            // 
            // prod_price
            // 
            this.prod_price.AutoSize = true;
            this.prod_price.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.prod_price.Location = new System.Drawing.Point(5, 261);
            this.prod_price.Name = "prod_price";
            this.prod_price.Size = new System.Drawing.Size(109, 20);
            this.prod_price.TabIndex = 45;
            this.prod_price.Text = "Product price";
            this.prod_price.TextChanged += new System.EventHandler(this.prod_price_TextChanged);
            // 
            // prod_desc
            // 
            this.prod_desc.BackColor = System.Drawing.Color.Transparent;
            this.prod_desc.BackgroundColor = System.Drawing.Color.White;
            this.prod_desc.BorderColor = System.Drawing.Color.Silver;
            this.prod_desc.BorderRadius = 1;
            this.prod_desc.Color = System.Drawing.Color.Silver;
            this.prod_desc.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.prod_desc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.prod_desc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.prod_desc.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.prod_desc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prod_desc.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.prod_desc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.prod_desc.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.prod_desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prod_desc.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.prod_desc.FillDropDown = true;
            this.prod_desc.FillIndicator = false;
            this.prod_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prod_desc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_desc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.prod_desc.FormattingEnabled = true;
            this.prod_desc.Icon = null;
            this.prod_desc.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.prod_desc.IndicatorColor = System.Drawing.Color.DarkGray;
            this.prod_desc.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.prod_desc.IndicatorThickness = 2;
            this.prod_desc.IsDropdownOpened = false;
            this.prod_desc.ItemBackColor = System.Drawing.Color.White;
            this.prod_desc.ItemBorderColor = System.Drawing.Color.White;
            this.prod_desc.ItemForeColor = System.Drawing.Color.Black;
            this.prod_desc.ItemHeight = 26;
            this.prod_desc.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.prod_desc.ItemHighLightForeColor = System.Drawing.Color.White;
            this.prod_desc.Items.AddRange(new object[] {
            "Description"});
            this.prod_desc.ItemTopMargin = 3;
            this.prod_desc.Location = new System.Drawing.Point(9, 114);
            this.prod_desc.Name = "prod_desc";
            this.prod_desc.Size = new System.Drawing.Size(260, 32);
            this.prod_desc.TabIndex = 46;
            this.prod_desc.Text = null;
            this.prod_desc.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.prod_desc.TextLeftMargin = 5;
            this.prod_desc.SelectedIndexChanged += new System.EventHandler(this.prod_desc_SelectedIndexChanged);
            this.prod_desc.Click += new System.EventHandler(this.prod_desc_Click);
            // 
            // prod_size
            // 
            this.prod_size.BackColor = System.Drawing.Color.Transparent;
            this.prod_size.BackgroundColor = System.Drawing.Color.White;
            this.prod_size.BorderColor = System.Drawing.Color.Silver;
            this.prod_size.BorderRadius = 1;
            this.prod_size.Color = System.Drawing.Color.Silver;
            this.prod_size.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.prod_size.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.prod_size.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.prod_size.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.prod_size.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prod_size.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.prod_size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.prod_size.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.prod_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prod_size.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.prod_size.FillDropDown = true;
            this.prod_size.FillIndicator = false;
            this.prod_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prod_size.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prod_size.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.prod_size.FormattingEnabled = true;
            this.prod_size.Icon = null;
            this.prod_size.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.prod_size.IndicatorColor = System.Drawing.Color.DarkGray;
            this.prod_size.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.prod_size.IndicatorThickness = 2;
            this.prod_size.IsDropdownOpened = false;
            this.prod_size.ItemBackColor = System.Drawing.Color.White;
            this.prod_size.ItemBorderColor = System.Drawing.Color.White;
            this.prod_size.ItemForeColor = System.Drawing.Color.Black;
            this.prod_size.ItemHeight = 26;
            this.prod_size.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.prod_size.ItemHighLightForeColor = System.Drawing.Color.White;
            this.prod_size.Items.AddRange(new object[] {
            "Size"});
            this.prod_size.ItemTopMargin = 3;
            this.prod_size.Location = new System.Drawing.Point(9, 195);
            this.prod_size.Name = "prod_size";
            this.prod_size.Size = new System.Drawing.Size(260, 32);
            this.prod_size.TabIndex = 47;
            this.prod_size.Text = null;
            this.prod_size.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.prod_size.TextLeftMargin = 5;
            this.prod_size.SelectedIndexChanged += new System.EventHandler(this.prod_size_SelectedIndexChanged);
            this.prod_size.Click += new System.EventHandler(this.prod_size_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.id.Location = new System.Drawing.Point(6, 53);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(148, 21);
            this.id.TabIndex = 48;
            this.id.Text = "Selected Product ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(7, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Size";
            // 
            // sales_management_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id);
            this.Controls.Add(this.prod_size);
            this.Controls.Add(this.prod_desc);
            this.Controls.Add(this.prod_price);
            this.Controls.Add(this.size);
            this.Controls.Add(this.tot_price);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cust_change);
            this.Controls.Add(this.cust_money);
            this.Controls.Add(this.order_total);
            this.Controls.Add(this.lavel);
            this.Controls.Add(this.label);
            this.Controls.Add(this._total);
            this.Controls.Add(this.current_date);
            this.Controls.Add(this.transaction_number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.senior_btn);
            this.Controls.Add(this.regular_btn);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.record_grid);
            this.Controls.Add(this.prod_quantity);
            this.Name = "sales_management_control";
            this.Size = new System.Drawing.Size(988, 662);
            this.Load += new System.EventHandler(this.sales_management_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.record_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox prod_quantity;
        private Guna.UI.WinForms.GunaDataGridView record_grid;
        private Guna.UI.WinForms.GunaButton insert_btn;
        private Guna.UI.WinForms.GunaButton clear_btn;
        private Guna.UI.WinForms.GunaButton delete_btn;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaAdvenceButton regular_btn;
        private Guna.UI.WinForms.GunaAdvenceButton senior_btn;
        private Guna.UI.WinForms.GunaButton update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label transaction_number;
        private System.Windows.Forms.Label current_date;
        private System.Windows.Forms.Label _total;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lavel;
        private System.Windows.Forms.Label order_total;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cust_money;
        private System.Windows.Forms.Label cust_change;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.Label tot_price;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label prod_price;
        private Bunifu.UI.WinForms.BunifuDropdown prod_desc;
        private Bunifu.UI.WinForms.BunifuDropdown prod_size;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeorgrams;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
