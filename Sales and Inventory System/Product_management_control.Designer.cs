namespace Sales_and_Inventory_System
{
    partial class product_management_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product_management_control));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.inventory_item = new Guna.UI.WinForms.GunaDataGridView();
            this.insert_btn = new Guna.UI.WinForms.GunaButton();
            this.search_txt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.expired_btn = new Guna.UI.WinForms.GunaButton();
            this.show_all = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_item)).BeginInit();
            this.SuspendLayout();
            // 
            // inventory_item
            // 
            this.inventory_item.AllowUserToAddRows = false;
            this.inventory_item.AllowUserToDeleteRows = false;
            this.inventory_item.AllowUserToResizeColumns = false;
            this.inventory_item.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inventory_item.DefaultCellStyle = dataGridViewCellStyle3;
            this.inventory_item.EnableHeadersVisualStyles = false;
            this.inventory_item.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.inventory_item.Location = new System.Drawing.Point(0, 82);
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
            this.inventory_item.Size = new System.Drawing.Size(988, 580);
            this.inventory_item.TabIndex = 0;
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
            this.inventory_item.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_item.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.inventory_item.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.inventory_item.ThemeStyle.HeaderStyle.Height = 22;
            this.inventory_item.ThemeStyle.ReadOnly = true;
            this.inventory_item.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.inventory_item.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inventory_item.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.inventory_item.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.inventory_item.ThemeStyle.RowsStyle.Height = 50;
            this.inventory_item.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.inventory_item.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.inventory_item.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.inventory_item_DataBindingComplete);
            this.inventory_item.MouseLeave += new System.EventHandler(this.inventory_item_MouseLeave);
            // 
            // insert_btn
            // 
            this.insert_btn.AnimationHoverSpeed = 0.07F;
            this.insert_btn.AnimationSpeed = 0.03F;
            this.insert_btn.BaseColor = System.Drawing.Color.Gray;
            this.insert_btn.BorderColor = System.Drawing.Color.Black;
            this.insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.insert_btn.FocusedColor = System.Drawing.Color.Empty;
            this.insert_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.White;
            this.insert_btn.Image = null;
            this.insert_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.insert_btn.Location = new System.Drawing.Point(872, 51);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.insert_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.insert_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.insert_btn.OnHoverImage = null;
            this.insert_btn.OnPressedColor = System.Drawing.Color.Black;
            this.insert_btn.Size = new System.Drawing.Size(91, 25);
            this.insert_btn.TabIndex = 12;
            this.insert_btn.Text = "Insert";
            this.insert_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click_1);
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
            this.search_txt.Location = new System.Drawing.Point(5, 46);
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
            this.search_txt.Size = new System.Drawing.Size(273, 30);
            this.search_txt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.search_txt.TabIndex = 4;
            this.search_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search_txt.TextMarginBottom = 0;
            this.search_txt.TextMarginLeft = 3;
            this.search_txt.TextMarginTop = 1;
            this.search_txt.TextPlaceholder = "Search item";
            this.search_txt.UseSystemPasswordChar = false;
            this.search_txt.WordWrap = true;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            this.search_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_txt_KeyPress);
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
            this.expired_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expired_btn.ForeColor = System.Drawing.Color.White;
            this.expired_btn.Image = null;
            this.expired_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.expired_btn.Location = new System.Drawing.Point(676, 51);
            this.expired_btn.Name = "expired_btn";
            this.expired_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.expired_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.expired_btn.OnHoverForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.expired_btn.OnHoverImage = null;
            this.expired_btn.OnPressedColor = System.Drawing.Color.Black;
            this.expired_btn.Size = new System.Drawing.Size(91, 25);
            this.expired_btn.TabIndex = 14;
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
            this.show_all.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_all.ForeColor = System.Drawing.Color.White;
            this.show_all.Image = null;
            this.show_all.ImageSize = new System.Drawing.Size(20, 20);
            this.show_all.Location = new System.Drawing.Point(773, 51);
            this.show_all.Name = "show_all";
            this.show_all.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.show_all.OnHoverBorderColor = System.Drawing.Color.Black;
            this.show_all.OnHoverForeColor = System.Drawing.Color.White;
            this.show_all.OnHoverImage = null;
            this.show_all.OnPressedColor = System.Drawing.Color.Black;
            this.show_all.Size = new System.Drawing.Size(91, 25);
            this.show_all.TabIndex = 13;
            this.show_all.Text = "Items in Stock";
            this.show_all.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.show_all.Click += new System.EventHandler(this.show_all_Click);
            // 
            // product_management_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.expired_btn);
            this.Controls.Add(this.show_all);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.inventory_item);
            this.Name = "product_management_control";
            this.Size = new System.Drawing.Size(988, 662);
            this.Load += new System.EventHandler(this.product_management_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventory_item)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox search_txt;
        private Guna.UI.WinForms.GunaDataGridView inventory_item;
        private Guna.UI.WinForms.GunaButton insert_btn;
        private Guna.UI.WinForms.GunaButton expired_btn;
        private Guna.UI.WinForms.GunaButton show_all;
    }
}
