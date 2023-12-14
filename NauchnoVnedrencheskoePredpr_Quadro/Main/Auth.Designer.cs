
namespace NauchnoVnedrencheskoePredpr_Quadro
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.panel_Auth = new System.Windows.Forms.Panel();
            this.pb_Icantsee = new System.Windows.Forms.PictureBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checktimer = new System.Windows.Forms.Timer(this.components);
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_func_Exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Auth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icantsee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Auth
            // 
            this.panel_Auth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Auth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.panel_Auth.Controls.Add(this.pb_Icantsee);
            this.panel_Auth.Controls.Add(this.btn_enter);
            this.panel_Auth.Controls.Add(this.tb_password);
            this.panel_Auth.Controls.Add(this.lb_password);
            this.panel_Auth.Controls.Add(this.tb_login);
            this.panel_Auth.Controls.Add(this.lb_login);
            this.panel_Auth.Controls.Add(this.label1);
            this.panel_Auth.Location = new System.Drawing.Point(12, 73);
            this.panel_Auth.Name = "panel_Auth";
            this.panel_Auth.Size = new System.Drawing.Size(360, 297);
            this.panel_Auth.TabIndex = 7;
            // 
            // pb_Icantsee
            // 
            this.pb_Icantsee.BackColor = System.Drawing.Color.White;
            this.pb_Icantsee.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.passon;
            this.pb_Icantsee.Location = new System.Drawing.Point(327, 196);
            this.pb_Icantsee.Name = "pb_Icantsee";
            this.pb_Icantsee.Size = new System.Drawing.Size(30, 29);
            this.pb_Icantsee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Icantsee.TabIndex = 10;
            this.pb_Icantsee.TabStop = false;
            this.pb_Icantsee.Click += new System.EventHandler(this.pb_Icantsee_Click);
            // 
            // btn_enter
            // 
            this.btn_enter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enter.Location = new System.Drawing.Point(132, 247);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(92, 33);
            this.btn_enter.TabIndex = 9;
            this.btn_enter.Text = "Войти";
            this.btn_enter.UseVisualStyleBackColor = false;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // tb_password
            // 
            this.tb_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_password.Location = new System.Drawing.Point(47, 196);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(275, 29);
            this.tb_password.TabIndex = 8;
            // 
            // lb_password
            // 
            this.lb_password.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(43, 154);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(69, 23);
            this.lb_password.TabIndex = 7;
            this.lb_password.Text = "Пароль:";
            this.lb_password.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tb_login
            // 
            this.tb_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_login.Location = new System.Drawing.Point(47, 108);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(275, 29);
            this.tb_login.TabIndex = 6;
            // 
            // lb_login
            // 
            this.lb_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(43, 70);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(57, 23);
            this.lb_login.TabIndex = 5;
            this.lb_login.Text = "Логин:";
            this.lb_login.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // checktimer
            // 
            this.checktimer.Tick += new System.EventHandler(this.checktimer_Tick);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.Logo;
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(50, 50);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 8;
            this.pb_logo.TabStop = false;
            // 
            // pb_func_Exit
            // 
            this.pb_func_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_func_Exit.BackgroundImage = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.close;
            this.pb_func_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_func_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_func_Exit.Location = new System.Drawing.Point(322, 12);
            this.pb_func_Exit.Name = "pb_func_Exit";
            this.pb_func_Exit.Size = new System.Drawing.Size(50, 50);
            this.pb_func_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_func_Exit.TabIndex = 6;
            this.pb_func_Exit.TabStop = false;
            this.pb_func_Exit.Click += new System.EventHandler(this.pb_func_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.Logo_text;
            this.pictureBox1.Location = new System.Drawing.Point(103, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(384, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.panel_Auth);
            this.Controls.Add(this.pb_func_Exit);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 421);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 421);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auth";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Auth_FormClosed);
            this.Load += new System.EventHandler(this.Auth_Load);
            this.panel_Auth.ResumeLayout(false);
            this.panel_Auth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icantsee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_func_Exit;
        private System.Windows.Forms.Panel panel_Auth;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Timer checktimer;
        private System.Windows.Forms.PictureBox pb_Icantsee;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}