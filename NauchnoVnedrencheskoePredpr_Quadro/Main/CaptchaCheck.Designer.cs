
namespace NauchnoVnedrencheskoePredpr_Quadro.Main
{
    partial class CaptchaCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptchaCheck));
            this.btn_check = new System.Windows.Forms.Button();
            this.tb_check_captcha = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pb_Captcha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_check.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_check.Location = new System.Drawing.Point(97, 242);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 30);
            this.btn_check.TabIndex = 8;
            this.btn_check.Text = "ОК";
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // tb_check_captcha
            // 
            this.tb_check_captcha.Location = new System.Drawing.Point(43, 207);
            this.tb_check_captcha.Name = "tb_check_captcha";
            this.tb_check_captcha.Size = new System.Drawing.Size(300, 29);
            this.tb_check_captcha.TabIndex = 7;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refresh.Location = new System.Drawing.Point(201, 242);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(97, 30);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Обновить";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // pb_Captcha
            // 
            this.pb_Captcha.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pb_Captcha.BackColor = System.Drawing.Color.White;
            this.pb_Captcha.Location = new System.Drawing.Point(43, 51);
            this.pb_Captcha.Name = "pb_Captcha";
            this.pb_Captcha.Size = new System.Drawing.Size(300, 150);
            this.pb_Captcha.TabIndex = 5;
            this.pb_Captcha.TabStop = false;
            // 
            // CaptchaCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.tb_check_captcha);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.pb_Captcha);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(384, 361);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(384, 361);
            this.Name = "CaptchaCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captcha";
            this.Load += new System.EventHandler(this.CaptchaCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Captcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.TextBox tb_check_captcha;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox pb_Captcha;
    }
}