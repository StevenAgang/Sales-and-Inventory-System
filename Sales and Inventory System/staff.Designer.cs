namespace Sales_and_Inventory_System
{
    partial class staff
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
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(staff));
            this.transition = new Guna.UI.WinForms.GunaTransition(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.product_management_control1 = new Sales_and_Inventory_System.product_management_control();
            this.supplier1 = new Sales_and_Inventory_System.supplier();
            this.sales_management_control1 = new Sales_and_Inventory_System.sales_management_control();
            this.transaction_history1 = new Sales_and_Inventory_System.transaction_history();
            this.top_panel = new Guna.UI.WinForms.GunaGradientPanel();
            this.minimize_btn = new Guna.UI.WinForms.GunaControlBox();
            this.Exit_btn = new Guna.UI.WinForms.GunaButton();
            this.menu_panel = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.transac_history = new Guna.UI.WinForms.GunaAdvenceButton();
            this.supplier_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.sales_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.product_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.drag_control = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.panel2.SuspendLayout();
            this.top_panel.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // transition
            // 
            this.transition.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide;
            this.transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transition.DefaultAnimation = animation1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.product_management_control1);
            this.panel2.Controls.Add(this.supplier1);
            this.panel2.Controls.Add(this.sales_management_control1);
            this.panel2.Controls.Add(this.transaction_history1);
            this.transition.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(215, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 661);
            this.panel2.TabIndex = 6;
            // 
            // product_management_control1
            // 
            this.product_management_control1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.product_management_control1, Guna.UI.Animation.DecorationType.None);
            this.product_management_control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.product_management_control1.Location = new System.Drawing.Point(0, 0);
            this.product_management_control1.Name = "product_management_control1";
            this.product_management_control1.Size = new System.Drawing.Size(985, 661);
            this.product_management_control1.TabIndex = 0;
            // 
            // supplier1
            // 
            this.supplier1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.supplier1, Guna.UI.Animation.DecorationType.None);
            this.supplier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplier1.Location = new System.Drawing.Point(0, 0);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(985, 661);
            this.supplier1.TabIndex = 2;
            // 
            // sales_management_control1
            // 
            this.sales_management_control1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.sales_management_control1, Guna.UI.Animation.DecorationType.None);
            this.sales_management_control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sales_management_control1.Location = new System.Drawing.Point(0, 0);
            this.sales_management_control1.Name = "sales_management_control1";
            this.sales_management_control1.Size = new System.Drawing.Size(985, 661);
            this.sales_management_control1.TabIndex = 1;
            // 
            // transaction_history1
            // 
            this.transaction_history1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.transaction_history1, Guna.UI.Animation.DecorationType.None);
            this.transaction_history1.Location = new System.Drawing.Point(0, 0);
            this.transaction_history1.Name = "transaction_history1";
            this.transaction_history1.Size = new System.Drawing.Size(988, 662);
            this.transaction_history1.TabIndex = 3;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Transparent;
            this.top_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_panel.BackgroundImage")));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.minimize_btn);
            this.top_panel.Controls.Add(this.Exit_btn);
            this.transition.SetDecoration(this.top_panel, Guna.UI.Animation.DecorationType.None);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.top_panel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.top_panel.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.top_panel.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.top_panel.Location = new System.Drawing.Point(209, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(991, 33);
            this.top_panel.TabIndex = 5;
            // 
            // minimize_btn
            // 
            this.minimize_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_btn.AnimationHoverSpeed = 0.07F;
            this.minimize_btn.AnimationSpeed = 0.03F;
            this.minimize_btn.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.transition.SetDecoration(this.minimize_btn, Guna.UI.Animation.DecorationType.None);
            this.minimize_btn.IconColor = System.Drawing.Color.White;
            this.minimize_btn.IconSize = 15F;
            this.minimize_btn.Location = new System.Drawing.Point(887, 6);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.minimize_btn.OnHoverIconColor = System.Drawing.Color.White;
            this.minimize_btn.OnPressedColor = System.Drawing.Color.Black;
            this.minimize_btn.Size = new System.Drawing.Size(46, 24);
            this.minimize_btn.TabIndex = 15;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_btn.AnimationHoverSpeed = 0.07F;
            this.Exit_btn.AnimationSpeed = 0.03F;
            this.Exit_btn.BaseColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BorderColor = System.Drawing.Color.Black;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.Exit_btn, Guna.UI.Animation.DecorationType.None);
            this.Exit_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit_btn.FocusedColor = System.Drawing.Color.Empty;
            this.Exit_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.shutdown_30px;
            this.Exit_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.Exit_btn.Location = new System.Drawing.Point(939, 6);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(92)))), ((int)(((byte)(93)))));
            this.Exit_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exit_btn.OnHoverForeColor = System.Drawing.Color.Black;
            this.Exit_btn.OnHoverImage = null;
            this.Exit_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Exit_btn.Size = new System.Drawing.Size(46, 24);
            this.Exit_btn.TabIndex = 14;
            this.Exit_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // menu_panel
            // 
            this.menu_panel.AutoScroll = true;
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.menu_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_panel.BackgroundImage")));
            this.menu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_panel.Controls.Add(this.gunaAdvenceButton2);
            this.menu_panel.Controls.Add(this.transac_history);
            this.menu_panel.Controls.Add(this.supplier_btn);
            this.menu_panel.Controls.Add(this.sales_btn);
            this.menu_panel.Controls.Add(this.product_btn);
            this.menu_panel.Controls.Add(this.panel1);
            this.transition.SetDecoration(this.menu_panel, Guna.UI.Animation.DecorationType.None);
            this.menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_panel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.menu_panel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.menu_panel.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.menu_panel.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.menu_panel.Location = new System.Drawing.Point(0, 0);
            this.menu_panel.Name = "menu_panel";
            this.menu_panel.Size = new System.Drawing.Size(209, 700);
            this.menu_panel.TabIndex = 1;
            this.menu_panel.Text = "gunaGradientPanel2";
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.account_50pxgreen;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.gunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.gunaAdvenceButton2, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = global::Sales_and_Inventory_System.Properties.Resources.account_50px;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.LineLeft = 2;
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(0, 631);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnPressedDepth = 0;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(209, 40);
            this.gunaAdvenceButton2.TabIndex = 26;
            this.gunaAdvenceButton2.Text = " Profile";
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // transac_history
            // 
            this.transac_history.AnimationHoverSpeed = 0.07F;
            this.transac_history.AnimationSpeed = 0.03F;
            this.transac_history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.transac_history.BaseColor = System.Drawing.Color.Transparent;
            this.transac_history.BorderColor = System.Drawing.Color.Black;
            this.transac_history.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.transac_history.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.transac_history.CheckedBorderColor = System.Drawing.Color.Black;
            this.transac_history.CheckedForeColor = System.Drawing.Color.White;
            this.transac_history.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.list_64pxgreen;
            this.transac_history.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.transac_history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.transac_history, Guna.UI.Animation.DecorationType.None);
            this.transac_history.DialogResult = System.Windows.Forms.DialogResult.None;
            this.transac_history.Dock = System.Windows.Forms.DockStyle.Top;
            this.transac_history.FocusedColor = System.Drawing.Color.Empty;
            this.transac_history.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transac_history.ForeColor = System.Drawing.Color.White;
            this.transac_history.Image = global::Sales_and_Inventory_System.Properties.Resources.list_64px;
            this.transac_history.ImageSize = new System.Drawing.Size(20, 20);
            this.transac_history.LineColor = System.Drawing.Color.Transparent;
            this.transac_history.LineLeft = 2;
            this.transac_history.Location = new System.Drawing.Point(0, 335);
            this.transac_history.Name = "transac_history";
            this.transac_history.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.transac_history.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.transac_history.OnHoverForeColor = System.Drawing.Color.White;
            this.transac_history.OnHoverImage = null;
            this.transac_history.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.transac_history.OnPressedColor = System.Drawing.Color.Black;
            this.transac_history.OnPressedDepth = 0;
            this.transac_history.Size = new System.Drawing.Size(209, 40);
            this.transac_history.TabIndex = 24;
            this.transac_history.Text = "Transaction History";
            this.transac_history.Click += new System.EventHandler(this.transac_history_Click);
            // 
            // supplier_btn
            // 
            this.supplier_btn.AnimationHoverSpeed = 0.07F;
            this.supplier_btn.AnimationSpeed = 0.03F;
            this.supplier_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.supplier_btn.BaseColor = System.Drawing.Color.Transparent;
            this.supplier_btn.BorderColor = System.Drawing.Color.Black;
            this.supplier_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.supplier_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.supplier_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.supplier_btn.CheckedForeColor = System.Drawing.Color.White;
            this.supplier_btn.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.list_50pxGREEN;
            this.supplier_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.supplier_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.supplier_btn, Guna.UI.Animation.DecorationType.None);
            this.supplier_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.supplier_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.supplier_btn.FocusedColor = System.Drawing.Color.Empty;
            this.supplier_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_btn.ForeColor = System.Drawing.Color.White;
            this.supplier_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.list_50px;
            this.supplier_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.supplier_btn.LineColor = System.Drawing.Color.Transparent;
            this.supplier_btn.LineLeft = 2;
            this.supplier_btn.Location = new System.Drawing.Point(0, 295);
            this.supplier_btn.Name = "supplier_btn";
            this.supplier_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.supplier_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.supplier_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.supplier_btn.OnHoverImage = null;
            this.supplier_btn.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.supplier_btn.OnPressedColor = System.Drawing.Color.Black;
            this.supplier_btn.OnPressedDepth = 0;
            this.supplier_btn.Size = new System.Drawing.Size(209, 40);
            this.supplier_btn.TabIndex = 23;
            this.supplier_btn.Text = "Product List";
            this.supplier_btn.Click += new System.EventHandler(this.supplier_btn_Click);
            // 
            // sales_btn
            // 
            this.sales_btn.AnimationHoverSpeed = 0.07F;
            this.sales_btn.AnimationSpeed = 0.03F;
            this.sales_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.sales_btn.BaseColor = System.Drawing.Color.Transparent;
            this.sales_btn.BorderColor = System.Drawing.Color.Black;
            this.sales_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.sales_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.sales_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.sales_btn.CheckedForeColor = System.Drawing.Color.White;
            this.sales_btn.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.money_64px_green;
            this.sales_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.sales_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.sales_btn, Guna.UI.Animation.DecorationType.None);
            this.sales_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sales_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sales_btn.FocusedColor = System.Drawing.Color.Empty;
            this.sales_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_btn.ForeColor = System.Drawing.Color.White;
            this.sales_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.money_64px;
            this.sales_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.sales_btn.LineColor = System.Drawing.Color.Transparent;
            this.sales_btn.LineLeft = 2;
            this.sales_btn.Location = new System.Drawing.Point(0, 255);
            this.sales_btn.Name = "sales_btn";
            this.sales_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.sales_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.sales_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.sales_btn.OnHoverImage = null;
            this.sales_btn.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.sales_btn.OnPressedColor = System.Drawing.Color.DarkRed;
            this.sales_btn.OnPressedDepth = 0;
            this.sales_btn.Size = new System.Drawing.Size(209, 40);
            this.sales_btn.TabIndex = 22;
            this.sales_btn.Text = "Sales Management";
            this.sales_btn.Click += new System.EventHandler(this.sales_btn_Click);
            // 
            // product_btn
            // 
            this.product_btn.AnimationHoverSpeed = 0.07F;
            this.product_btn.AnimationSpeed = 0.03F;
            this.product_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.product_btn.BaseColor = System.Drawing.Color.Transparent;
            this.product_btn.BorderColor = System.Drawing.Color.Black;
            this.product_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.product_btn.Checked = true;
            this.product_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.product_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.product_btn.CheckedForeColor = System.Drawing.Color.White;
            this.product_btn.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.product_64px_green;
            this.product_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.product_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.product_btn, Guna.UI.Animation.DecorationType.None);
            this.product_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.product_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_btn.FocusedColor = System.Drawing.Color.Empty;
            this.product_btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_btn.ForeColor = System.Drawing.Color.White;
            this.product_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.product_64px;
            this.product_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.product_btn.LineColor = System.Drawing.Color.Transparent;
            this.product_btn.LineLeft = 2;
            this.product_btn.Location = new System.Drawing.Point(0, 215);
            this.product_btn.Name = "product_btn";
            this.product_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.product_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.product_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.product_btn.OnHoverImage = null;
            this.product_btn.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.product_btn.OnPressedColor = System.Drawing.Color.Black;
            this.product_btn.OnPressedDepth = 0;
            this.product_btn.Size = new System.Drawing.Size(209, 40);
            this.product_btn.TabIndex = 21;
            this.product_btn.Text = "Stock Management";
            this.product_btn.Click += new System.EventHandler(this.product_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logo);
            this.transition.SetDecoration(this.panel1, Guna.UI.Animation.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 215);
            this.panel1.TabIndex = 0;
            // 
            // logo
            // 
            this.transition.SetDecoration(this.logo, Guna.UI.Animation.DecorationType.None);
            this.logo.Image = global::Sales_and_Inventory_System.Properties.Resources.front_logo1;
            this.logo.Location = new System.Drawing.Point(8, 41);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(193, 143);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // drag_control
            // 
            this.drag_control.TargetControl = this.top_panel;
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.menu_panel);
            this.transition.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.staff_Load);
            this.panel2.ResumeLayout(false);
            this.top_panel.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTransition transition;
        private Guna.UI.WinForms.GunaGradientPanel menu_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI.WinForms.GunaAdvenceButton supplier_btn;
        private Guna.UI.WinForms.GunaAdvenceButton sales_btn;
        private Guna.UI.WinForms.GunaAdvenceButton product_btn;
        private System.Windows.Forms.Panel panel2;
        private product_management_control product_management_control1;
        private supplier supplier1;
        private sales_management_control sales_management_control1;
        public Guna.UI.WinForms.GunaDragControl drag_control;
        private Guna.UI.WinForms.GunaAdvenceButton transac_history;
        private transaction_history transaction_history1;
        private Guna.UI.WinForms.GunaGradientPanel top_panel;
        private Guna.UI.WinForms.GunaControlBox minimize_btn;
        private Guna.UI.WinForms.GunaButton Exit_btn;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
    }
}