namespace Sales_and_Inventory_System
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Guna.UI.Animation.Animation animation1 = new Guna.UI.Animation.Animation();
            this.drag_control = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.top_panel = new Guna.UI.WinForms.GunaGradientPanel();
            this.logout_btn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.minimize_btn = new Guna.UI.WinForms.GunaControlBox();
            this.Exit_btn = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.admin_stock1 = new Sales_and_Inventory_System.admin_stock();
            this.supplier1 = new Sales_and_Inventory_System.admin_supplier();
            this.admin_transaction_history1 = new Sales_and_Inventory_System.admin_transaction_history();
            this.account_manage1 = new Sales_and_Inventory_System.account_manage();
            this.login_histiory1 = new Sales_and_Inventory_System.login_histiory();
            this.data1 = new Sales_and_Inventory_System.data();
            this.request1 = new Sales_and_Inventory_System.request();
            this.transition = new Guna.UI.WinForms.GunaTransition(this.components);
            this.menu_panel = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.backup = new Guna.UI.WinForms.GunaAdvenceButton();
            this.login_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.transac_history = new Guna.UI.WinForms.GunaAdvenceButton();
            this.supplier_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.account_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.stock_btn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.top_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // drag_control
            // 
            this.drag_control.TargetControl = this.top_panel;
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.Transparent;
            this.top_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top_panel.BackgroundImage")));
            this.top_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_panel.Controls.Add(this.logout_btn);
            this.top_panel.Controls.Add(this.gunaButton1);
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
            this.top_panel.TabIndex = 8;
            // 
            // logout_btn
            // 
            this.logout_btn.AnimationHoverSpeed = 0.07F;
            this.logout_btn.AnimationSpeed = 0.03F;
            this.logout_btn.BaseColor1 = System.Drawing.Color.Transparent;
            this.logout_btn.BaseColor2 = System.Drawing.Color.Transparent;
            this.logout_btn.BorderColor = System.Drawing.Color.SpringGreen;
            this.logout_btn.BorderSize = 1;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.logout_btn, Guna.UI.Animation.DecorationType.None);
            this.logout_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logout_btn.FocusedColor = System.Drawing.Color.Empty;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.exit_24px;
            this.logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logout_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.logout_btn.Location = new System.Drawing.Point(851, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.OnHoverBaseColor1 = System.Drawing.Color.Transparent;
            this.logout_btn.OnHoverBaseColor2 = System.Drawing.Color.Transparent;
            this.logout_btn.OnHoverBorderColor = System.Drawing.Color.SpringGreen;
            this.logout_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.logout_btn.OnHoverImage = null;
            this.logout_btn.OnPressedColor = System.Drawing.Color.Black;
            this.logout_btn.Size = new System.Drawing.Size(30, 21);
            this.logout_btn.TabIndex = 30;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.gunaButton1, Guna.UI.Animation.DecorationType.None);
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::Sales_and_Inventory_System.Properties.Resources.shutdown_30px;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(941, 2);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(46, 24);
            this.gunaButton1.TabIndex = 16;
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
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
            this.minimize_btn.Location = new System.Drawing.Point(887, 2);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
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
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.shutdown_30px;
            this.Exit_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.Exit_btn.Location = new System.Drawing.Point(1148, 2);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(176)))), ((int)(((byte)(76)))));
            this.Exit_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.Exit_btn.OnHoverForeColor = System.Drawing.Color.Black;
            this.Exit_btn.OnHoverImage = null;
            this.Exit_btn.OnPressedColor = System.Drawing.Color.Black;
            this.Exit_btn.Size = new System.Drawing.Size(13, 24);
            this.Exit_btn.TabIndex = 14;
            this.Exit_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.admin_stock1);
            this.panel2.Controls.Add(this.supplier1);
            this.panel2.Controls.Add(this.admin_transaction_history1);
            this.panel2.Controls.Add(this.account_manage1);
            this.panel2.Controls.Add(this.login_histiory1);
            this.panel2.Controls.Add(this.data1);
            this.panel2.Controls.Add(this.request1);
            this.transition.SetDecoration(this.panel2, Guna.UI.Animation.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(215, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(985, 661);
            this.panel2.TabIndex = 9;
            // 
            // admin_stock1
            // 
            this.admin_stock1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.admin_stock1, Guna.UI.Animation.DecorationType.None);
            this.admin_stock1.Location = new System.Drawing.Point(0, 0);
            this.admin_stock1.Name = "admin_stock1";
            this.admin_stock1.Size = new System.Drawing.Size(988, 662);
            this.admin_stock1.TabIndex = 0;
            // 
            // supplier1
            // 
            this.supplier1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.supplier1, Guna.UI.Animation.DecorationType.None);
            this.supplier1.Location = new System.Drawing.Point(0, 0);
            this.supplier1.Name = "supplier1";
            this.supplier1.Size = new System.Drawing.Size(988, 662);
            this.supplier1.TabIndex = 1;
            // 
            // admin_transaction_history1
            // 
            this.admin_transaction_history1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.admin_transaction_history1, Guna.UI.Animation.DecorationType.None);
            this.admin_transaction_history1.Location = new System.Drawing.Point(0, 0);
            this.admin_transaction_history1.Name = "admin_transaction_history1";
            this.admin_transaction_history1.Size = new System.Drawing.Size(988, 662);
            this.admin_transaction_history1.TabIndex = 2;
            // 
            // account_manage1
            // 
            this.account_manage1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.account_manage1, Guna.UI.Animation.DecorationType.None);
            this.account_manage1.Location = new System.Drawing.Point(0, 0);
            this.account_manage1.Name = "account_manage1";
            this.account_manage1.Size = new System.Drawing.Size(988, 662);
            this.account_manage1.TabIndex = 3;
            // 
            // login_histiory1
            // 
            this.login_histiory1.BackColor = System.Drawing.Color.White;
            this.transition.SetDecoration(this.login_histiory1, Guna.UI.Animation.DecorationType.None);
            this.login_histiory1.Location = new System.Drawing.Point(0, 0);
            this.login_histiory1.Name = "login_histiory1";
            this.login_histiory1.Size = new System.Drawing.Size(988, 662);
            this.login_histiory1.TabIndex = 4;
            // 
            // data1
            // 
            this.transition.SetDecoration(this.data1, Guna.UI.Animation.DecorationType.None);
            this.data1.Location = new System.Drawing.Point(0, 0);
            this.data1.Name = "data1";
            this.data1.Size = new System.Drawing.Size(988, 662);
            this.data1.TabIndex = 5;
            // 
            // request1
            // 
            this.transition.SetDecoration(this.request1, Guna.UI.Animation.DecorationType.None);
            this.request1.Location = new System.Drawing.Point(0, 0);
            this.request1.Name = "request1";
            this.request1.Size = new System.Drawing.Size(988, 662);
            this.request1.TabIndex = 6;
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
            // menu_panel
            // 
            this.menu_panel.AutoScroll = true;
            this.menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.menu_panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menu_panel.BackgroundImage")));
            this.menu_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menu_panel.Controls.Add(this.gunaAdvenceButton2);
            this.menu_panel.Controls.Add(this.backup);
            this.menu_panel.Controls.Add(this.login_btn);
            this.menu_panel.Controls.Add(this.transac_history);
            this.menu_panel.Controls.Add(this.supplier_btn);
            this.menu_panel.Controls.Add(this.account_btn);
            this.menu_panel.Controls.Add(this.stock_btn);
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
            this.menu_panel.TabIndex = 7;
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
            this.gunaAdvenceButton2.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.inquiry_512pxgreen;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.gunaAdvenceButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.gunaAdvenceButton2, Guna.UI.Animation.DecorationType.None);
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = global::Sales_and_Inventory_System.Properties.Resources.inquiry_512px;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.LineLeft = 2;
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(0, 455);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.DarkRed;
            this.gunaAdvenceButton2.OnPressedDepth = 0;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(209, 40);
            this.gunaAdvenceButton2.TabIndex = 23;
            this.gunaAdvenceButton2.Text = "Account Creation Request";
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
            // 
            // backup
            // 
            this.backup.AnimationHoverSpeed = 0.07F;
            this.backup.AnimationSpeed = 0.03F;
            this.backup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.backup.BaseColor = System.Drawing.Color.Transparent;
            this.backup.BorderColor = System.Drawing.Color.Black;
            this.backup.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.backup.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.backup.CheckedBorderColor = System.Drawing.Color.Black;
            this.backup.CheckedForeColor = System.Drawing.Color.White;
            this.backup.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.data_backup_208px;
            this.backup.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.backup, Guna.UI.Animation.DecorationType.None);
            this.backup.DialogResult = System.Windows.Forms.DialogResult.None;
            this.backup.Dock = System.Windows.Forms.DockStyle.Top;
            this.backup.FocusedColor = System.Drawing.Color.Empty;
            this.backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backup.ForeColor = System.Drawing.Color.White;
            this.backup.Image = global::Sales_and_Inventory_System.Properties.Resources.data_backup_208pxwhite;
            this.backup.ImageSize = new System.Drawing.Size(20, 20);
            this.backup.LineColor = System.Drawing.Color.Transparent;
            this.backup.LineLeft = 2;
            this.backup.Location = new System.Drawing.Point(0, 415);
            this.backup.Name = "backup";
            this.backup.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.backup.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.backup.OnHoverForeColor = System.Drawing.Color.White;
            this.backup.OnHoverImage = null;
            this.backup.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.backup.OnPressedColor = System.Drawing.Color.Black;
            this.backup.OnPressedDepth = 0;
            this.backup.Size = new System.Drawing.Size(209, 40);
            this.backup.TabIndex = 27;
            this.backup.Text = " Backup/Restore";
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // login_btn
            // 
            this.login_btn.AnimationHoverSpeed = 0.07F;
            this.login_btn.AnimationSpeed = 0.03F;
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.login_btn.BaseColor = System.Drawing.Color.Transparent;
            this.login_btn.BorderColor = System.Drawing.Color.Black;
            this.login_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.login_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.login_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.login_btn.CheckedForeColor = System.Drawing.Color.White;
            this.login_btn.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.login_24pxgreen;
            this.login_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.login_btn, Guna.UI.Animation.DecorationType.None);
            this.login_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.login_btn.FocusedColor = System.Drawing.Color.Empty;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.login_24px;
            this.login_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.login_btn.LineColor = System.Drawing.Color.Transparent;
            this.login_btn.LineLeft = 2;
            this.login_btn.Location = new System.Drawing.Point(0, 375);
            this.login_btn.Name = "login_btn";
            this.login_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.login_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.login_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.login_btn.OnHoverImage = null;
            this.login_btn.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.login_btn.OnPressedColor = System.Drawing.Color.Black;
            this.login_btn.OnPressedDepth = 0;
            this.login_btn.Size = new System.Drawing.Size(209, 40);
            this.login_btn.TabIndex = 26;
            this.login_btn.Text = "Login History";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
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
            this.transac_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.transac_history.TabIndex = 25;
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
            this.supplier_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.supplier_btn.TabIndex = 24;
            this.supplier_btn.Text = "Product List";
            this.supplier_btn.Click += new System.EventHandler(this.supplier_btn_Click);
            // 
            // account_btn
            // 
            this.account_btn.AnimationHoverSpeed = 0.07F;
            this.account_btn.AnimationSpeed = 0.03F;
            this.account_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.account_btn.BaseColor = System.Drawing.Color.Transparent;
            this.account_btn.BorderColor = System.Drawing.Color.Black;
            this.account_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.account_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.account_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.account_btn.CheckedForeColor = System.Drawing.Color.White;
            this.account_btn.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.account_50pxgreen;
            this.account_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.account_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.account_btn, Guna.UI.Animation.DecorationType.None);
            this.account_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.account_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.account_btn.FocusedColor = System.Drawing.Color.Empty;
            this.account_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account_btn.ForeColor = System.Drawing.Color.White;
            this.account_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.account_50px;
            this.account_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.account_btn.LineColor = System.Drawing.Color.Transparent;
            this.account_btn.LineLeft = 2;
            this.account_btn.Location = new System.Drawing.Point(0, 255);
            this.account_btn.Name = "account_btn";
            this.account_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.account_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.account_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.account_btn.OnHoverImage = null;
            this.account_btn.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.account_btn.OnPressedColor = System.Drawing.Color.DarkRed;
            this.account_btn.OnPressedDepth = 0;
            this.account_btn.Size = new System.Drawing.Size(209, 40);
            this.account_btn.TabIndex = 22;
            this.account_btn.Text = "Account management";
            this.account_btn.Click += new System.EventHandler(this.sales_btn_Click);
            // 
            // stock_btn
            // 
            this.stock_btn.AnimationHoverSpeed = 0.07F;
            this.stock_btn.AnimationSpeed = 0.03F;
            this.stock_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.stock_btn.BaseColor = System.Drawing.Color.Transparent;
            this.stock_btn.BorderColor = System.Drawing.Color.Black;
            this.stock_btn.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.stock_btn.Checked = true;
            this.stock_btn.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.stock_btn.CheckedBorderColor = System.Drawing.Color.Black;
            this.stock_btn.CheckedForeColor = System.Drawing.Color.White;
            this.stock_btn.CheckedImage = global::Sales_and_Inventory_System.Properties.Resources.product_64px_green;
            this.stock_btn.CheckedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.stock_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transition.SetDecoration(this.stock_btn, Guna.UI.Animation.DecorationType.None);
            this.stock_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.stock_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stock_btn.FocusedColor = System.Drawing.Color.Empty;
            this.stock_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_btn.ForeColor = System.Drawing.Color.White;
            this.stock_btn.Image = global::Sales_and_Inventory_System.Properties.Resources.product_64px;
            this.stock_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.stock_btn.LineColor = System.Drawing.Color.Transparent;
            this.stock_btn.LineLeft = 2;
            this.stock_btn.Location = new System.Drawing.Point(0, 215);
            this.stock_btn.Name = "stock_btn";
            this.stock_btn.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.stock_btn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.stock_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.stock_btn.OnHoverImage = null;
            this.stock_btn.OnHoverLineColor = System.Drawing.Color.SpringGreen;
            this.stock_btn.OnPressedColor = System.Drawing.Color.Black;
            this.stock_btn.OnPressedDepth = 0;
            this.stock_btn.Size = new System.Drawing.Size(209, 40);
            this.stock_btn.TabIndex = 21;
            this.stock_btn.Text = "Stock Management";
            this.stock_btn.Click += new System.EventHandler(this.product_btn_Click);
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.top_panel);
            this.Controls.Add(this.menu_panel);
            this.Controls.Add(this.panel2);
            this.transition.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.top_panel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menu_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaDragControl drag_control;
        private Guna.UI.WinForms.GunaGradientPanel top_panel;
        private Guna.UI.WinForms.GunaControlBox minimize_btn;
        private Guna.UI.WinForms.GunaTransition transition;
        private Guna.UI.WinForms.GunaButton Exit_btn;
        private Guna.UI.WinForms.GunaAdvenceButton transac_history;
        private Guna.UI.WinForms.GunaAdvenceButton supplier_btn;
        private Guna.UI.WinForms.GunaAdvenceButton account_btn;
        private Guna.UI.WinForms.GunaAdvenceButton stock_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private Guna.UI.WinForms.GunaGradientPanel menu_panel;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaAdvenceButton login_btn;
        private admin_stock admin_stock1;
        private admin_supplier supplier1;
        private admin_transaction_history admin_transaction_history1;
        private account_manage account_manage1;
        private login_histiory login_histiory1;
        private Guna.UI.WinForms.GunaGradientButton logout_btn;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton backup;
        private data data1;
        private request request1;
    }
}