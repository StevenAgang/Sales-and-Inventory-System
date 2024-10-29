namespace Sales_and_Inventory_System
{
    partial class Add_item
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
            this.item_quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Signin_btn = new Guna.UI.WinForms.GunaButton();
            this.Exit_panel = new Guna.UI.WinForms.GunaButton();
            this.drag_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.drag_control = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.desc = new Bunifu.UI.WinForms.BunifuDropdown();
            this.size = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drag_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // item_quantity
            // 
            this.item_quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.item_quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.item_quantity.ForeColor = System.Drawing.Color.Silver;
            this.item_quantity.HintForeColor = System.Drawing.Color.Silver;
            this.item_quantity.HintText = "Quantity";
            this.item_quantity.isPassword = false;
            this.item_quantity.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.item_quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.item_quantity.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.item_quantity.LineThickness = 3;
            this.item_quantity.Location = new System.Drawing.Point(10, 286);
            this.item_quantity.Margin = new System.Windows.Forms.Padding(4);
            this.item_quantity.Name = "item_quantity";
            this.item_quantity.Size = new System.Drawing.Size(336, 32);
            this.item_quantity.TabIndex = 4;
            this.item_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.item_quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.item_quantity_KeyDown);
            this.item_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.item_quantity_KeyPress);
            // 
            // Signin_btn
            // 
            this.Signin_btn.AnimationHoverSpeed = 0.07F;
            this.Signin_btn.AnimationSpeed = 0.03F;
            this.Signin_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Signin_btn.BorderColor = System.Drawing.Color.Black;
            this.Signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Signin_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Signin_btn.FocusedColor = System.Drawing.Color.Empty;
            this.Signin_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin_btn.ForeColor = System.Drawing.Color.White;
            this.Signin_btn.Image = null;
            this.Signin_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.Signin_btn.Location = new System.Drawing.Point(15, 393);
            this.Signin_btn.Name = "Signin_btn";
            this.Signin_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Signin_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Signin_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.Signin_btn.OnHoverImage = null;
            this.Signin_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Signin_btn.Size = new System.Drawing.Size(334, 41);
            this.Signin_btn.TabIndex = 6;
            this.Signin_btn.Text = "Insert";
            this.Signin_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Signin_btn.Click += new System.EventHandler(this.Signin_btn_Click);
            // 
            // Exit_panel
            // 
            this.Exit_panel.AnimationHoverSpeed = 0.07F;
            this.Exit_panel.AnimationSpeed = 0.03F;
            this.Exit_panel.BaseColor = System.Drawing.Color.Transparent;
            this.Exit_panel.BorderColor = System.Drawing.Color.Black;
            this.Exit_panel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_panel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit_panel.FocusedColor = System.Drawing.Color.Empty;
            this.Exit_panel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_panel.ForeColor = System.Drawing.Color.White;
            this.Exit_panel.Image = null;
            this.Exit_panel.ImageSize = new System.Drawing.Size(20, 20);
            this.Exit_panel.Location = new System.Drawing.Point(332, 2);
            this.Exit_panel.Name = "Exit_panel";
            this.Exit_panel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Exit_panel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exit_panel.OnHoverForeColor = System.Drawing.Color.White;
            this.Exit_panel.OnHoverImage = null;
            this.Exit_panel.OnPressedColor = System.Drawing.Color.Black;
            this.Exit_panel.Size = new System.Drawing.Size(27, 26);
            this.Exit_panel.TabIndex = 14;
            this.Exit_panel.Text = "X";
            this.Exit_panel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit_panel.Click += new System.EventHandler(this.Exit_panel_Click);
            // 
            // drag_panel
            // 
            this.drag_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(93)))), ((int)(((byte)(103)))));
            this.drag_panel.Controls.Add(this.label1);
            this.drag_panel.Controls.Add(this.Exit_panel);
            this.drag_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.drag_panel.Location = new System.Drawing.Point(0, 0);
            this.drag_panel.Name = "drag_panel";
            this.drag_panel.Size = new System.Drawing.Size(362, 30);
            this.drag_panel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "ADD ITEM";
            // 
            // drag_control
            // 
            this.drag_control.TargetControl = this.drag_panel;
            // 
            // desc
            // 
            this.desc.BackColor = System.Drawing.Color.Transparent;
            this.desc.BackgroundColor = System.Drawing.Color.White;
            this.desc.BorderColor = System.Drawing.Color.Silver;
            this.desc.BorderRadius = 1;
            this.desc.Color = System.Drawing.Color.Silver;
            this.desc.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.desc.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.desc.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.desc.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.desc.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.desc.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.desc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.desc.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desc.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.desc.FillDropDown = true;
            this.desc.FillIndicator = false;
            this.desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.desc.ForeColor = System.Drawing.Color.Black;
            this.desc.FormattingEnabled = true;
            this.desc.Icon = null;
            this.desc.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.desc.IndicatorColor = System.Drawing.Color.DarkGray;
            this.desc.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.desc.IndicatorThickness = 2;
            this.desc.IsDropdownOpened = false;
            this.desc.ItemBackColor = System.Drawing.Color.White;
            this.desc.ItemBorderColor = System.Drawing.Color.White;
            this.desc.ItemForeColor = System.Drawing.Color.Black;
            this.desc.ItemHeight = 26;
            this.desc.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.desc.ItemHighLightForeColor = System.Drawing.Color.White;
            this.desc.Items.AddRange(new object[] {
            "Description"});
            this.desc.ItemTopMargin = 3;
            this.desc.Location = new System.Drawing.Point(15, 115);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(335, 32);
            this.desc.TabIndex = 36;
            this.desc.Text = null;
            this.desc.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.desc.TextLeftMargin = 5;
            this.desc.SelectedIndexChanged += new System.EventHandler(this.desc_SelectedIndexChanged);
            // 
            // size
            // 
            this.size.BackColor = System.Drawing.Color.Transparent;
            this.size.BackgroundColor = System.Drawing.Color.White;
            this.size.BorderColor = System.Drawing.Color.Silver;
            this.size.BorderRadius = 1;
            this.size.Color = System.Drawing.Color.Silver;
            this.size.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.size.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.size.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.size.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.size.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.size.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.size.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.size.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.size.FillDropDown = true;
            this.size.FillIndicator = false;
            this.size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.size.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.size.ForeColor = System.Drawing.Color.Black;
            this.size.FormattingEnabled = true;
            this.size.Icon = null;
            this.size.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.size.IndicatorColor = System.Drawing.Color.DarkGray;
            this.size.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.size.IndicatorThickness = 2;
            this.size.IsDropdownOpened = false;
            this.size.ItemBackColor = System.Drawing.Color.White;
            this.size.ItemBorderColor = System.Drawing.Color.White;
            this.size.ItemForeColor = System.Drawing.Color.Black;
            this.size.ItemHeight = 26;
            this.size.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.size.ItemHighLightForeColor = System.Drawing.Color.White;
            this.size.Items.AddRange(new object[] {
            "Size"});
            this.size.ItemTopMargin = 3;
            this.size.Location = new System.Drawing.Point(15, 201);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(335, 32);
            this.size.TabIndex = 37;
            this.size.Text = null;
            this.size.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.size.TextLeftMargin = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Size";
            // 
            // Add_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(362, 463);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.size);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.drag_panel);
            this.Controls.Add(this.Signin_btn);
            this.Controls.Add(this.item_quantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Add_item_Load);
            this.drag_panel.ResumeLayout(false);
            this.drag_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox item_quantity;
        private Guna.UI.WinForms.GunaButton Signin_btn;
        private Guna.UI.WinForms.GunaButton Exit_panel;
        private System.Windows.Forms.Panel drag_panel;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDragControl drag_control;
        private Bunifu.UI.WinForms.BunifuDropdown desc;
        private Bunifu.UI.WinForms.BunifuDropdown size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}