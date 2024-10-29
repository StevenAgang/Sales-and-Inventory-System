namespace Sales_and_Inventory_System
{
    partial class ProgressBars
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
            this.result = new System.Windows.Forms.Label();
            this.progressbar = new Guna.UI.WinForms.GunaProgressBar();
            this.close_btn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(8, 45);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(102, 19);
            this.result.TabIndex = 1;
            this.result.Text = "Processing...";
            // 
            // progressbar
            // 
            this.progressbar.BorderColor = System.Drawing.Color.Black;
            this.progressbar.ColorStyle = Guna.UI.WinForms.ColorStyle.Default;
            this.progressbar.IdleColor = System.Drawing.Color.Gainsboro;
            this.progressbar.Location = new System.Drawing.Point(12, 12);
            this.progressbar.Name = "progressbar";
            this.progressbar.ProgressMaxColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progressbar.ProgressMinColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.progressbar.Size = new System.Drawing.Size(339, 30);
            this.progressbar.TabIndex = 2;
            // 
            // close_btn
            // 
            this.close_btn.AnimationHoverSpeed = 0.07F;
            this.close_btn.AnimationSpeed = 0.03F;
            this.close_btn.BaseColor = System.Drawing.Color.Gray;
            this.close_btn.BorderColor = System.Drawing.Color.Black;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.close_btn.FocusedColor = System.Drawing.Color.Empty;
            this.close_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = null;
            this.close_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.close_btn.Location = new System.Drawing.Point(257, 48);
            this.close_btn.Name = "close_btn";
            this.close_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.close_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.close_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.close_btn.OnHoverImage = null;
            this.close_btn.OnPressedColor = System.Drawing.Color.Black;
            this.close_btn.Size = new System.Drawing.Size(91, 25);
            this.close_btn.TabIndex = 51;
            this.close_btn.Text = "Close";
            this.close_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.close_btn.Visible = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // ProgressBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 79);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.result);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressBars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label result;
        public Guna.UI.WinForms.GunaProgressBar progressbar;
        public Guna.UI.WinForms.GunaButton close_btn;
    }
}