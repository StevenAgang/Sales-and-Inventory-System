namespace Sales_and_Inventory_System
{
    partial class mainformcs
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
            this.logout_btn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // logout_btn
            // 
            this.logout_btn.AnimationHoverSpeed = 0.07F;
            this.logout_btn.AnimationSpeed = 0.03F;
            this.logout_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.logout_btn.BorderColor = System.Drawing.Color.Black;
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logout_btn.FocusedColor = System.Drawing.Color.Empty;
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = null;
            this.logout_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.logout_btn.Location = new System.Drawing.Point(269, 200);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.OnHoverBaseColor = System.Drawing.Color.SpringGreen;
            this.logout_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logout_btn.OnHoverForeColor = System.Drawing.Color.Black;
            this.logout_btn.OnHoverImage = null;
            this.logout_btn.OnPressedColor = System.Drawing.Color.Black;
            this.logout_btn.Size = new System.Drawing.Size(160, 42);
            this.logout_btn.TabIndex = 0;
            this.logout_btn.Text = "Log out";
            this.logout_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // mainformcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 456);
            this.Controls.Add(this.logout_btn);
            this.Name = "mainformcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainformcs";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton logout_btn;
    }
}