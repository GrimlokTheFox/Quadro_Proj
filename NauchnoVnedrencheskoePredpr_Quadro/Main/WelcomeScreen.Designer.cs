
namespace NauchnoVnedrencheskoePredpr_Quadro
{
    partial class WelcomeScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeScreen));
            this.panel_Main = new System.Windows.Forms.Panel();
            this.pb_func_Exit = new System.Windows.Forms.PictureBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lb_Author = new System.Windows.Forms.Label();
            this.lb_MainIntro = new System.Windows.Forms.Label();
            this.pb_Logo = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.panel_Main.Controls.Add(this.pictureBox1);
            this.panel_Main.Controls.Add(this.pb_func_Exit);
            this.panel_Main.Controls.Add(this.btn_Enter);
            this.panel_Main.Controls.Add(this.lb_Author);
            this.panel_Main.Controls.Add(this.lb_MainIntro);
            this.panel_Main.Controls.Add(this.pb_Logo);
            this.panel_Main.Controls.Add(this.lb_name);
            this.panel_Main.Location = new System.Drawing.Point(12, 12);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(760, 537);
            this.panel_Main.TabIndex = 0;
            // 
            // pb_func_Exit
            // 
            this.pb_func_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_func_Exit.BackgroundImage = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.close;
            this.pb_func_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_func_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_func_Exit.Location = new System.Drawing.Point(704, 3);
            this.pb_func_Exit.Name = "pb_func_Exit";
            this.pb_func_Exit.Size = new System.Drawing.Size(50, 50);
            this.pb_func_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_func_Exit.TabIndex = 5;
            this.pb_func_Exit.TabStop = false;
            this.pb_func_Exit.Click += new System.EventHandler(this.pb_func_Exit_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Enter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Location = new System.Drawing.Point(327, 359);
            this.btn_Enter.MaximumSize = new System.Drawing.Size(98, 53);
            this.btn_Enter.MinimumSize = new System.Drawing.Size(98, 53);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(98, 53);
            this.btn_Enter.TabIndex = 4;
            this.btn_Enter.Text = "Войти";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lb_Author
            // 
            this.lb_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Author.AutoSize = true;
            this.lb_Author.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Author.Location = new System.Drawing.Point(425, 521);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(335, 16);
            this.lb_Author.TabIndex = 3;
            this.lb_Author.Text = "Программа написана Студентом группы П-46-20 Вовчок Глебом";
            this.lb_Author.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_MainIntro
            // 
            this.lb_MainIntro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_MainIntro.AutoSize = true;
            this.lb_MainIntro.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_MainIntro.Location = new System.Drawing.Point(301, 53);
            this.lb_MainIntro.Name = "lb_MainIntro";
            this.lb_MainIntro.Size = new System.Drawing.Size(397, 87);
            this.lb_MainIntro.TabIndex = 1;
            this.lb_MainIntro.Text = "Вас приветсвтует\r\nПриложение для учета заказаов\r\n\"Квадро\"";
            this.lb_MainIntro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_MainIntro.Click += new System.EventHandler(this.lb_MainIntro_Click);
            // 
            // pb_Logo
            // 
            this.pb_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_Logo.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.Logo;
            this.pb_Logo.Location = new System.Drawing.Point(3, 3);
            this.pb_Logo.Name = "pb_Logo";
            this.pb_Logo.Size = new System.Drawing.Size(200, 200);
            this.pb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logo.TabIndex = 0;
            this.pb_Logo.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_name.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_name.Location = new System.Drawing.Point(0, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(760, 537);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Информационная система";
            this.lb_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.Logo_text;
            this.pictureBox1.Location = new System.Drawing.Point(288, 289);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_Main);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "WelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приветствие";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WelcomeScreen_FormClosed);
            this.panel_Main.ResumeLayout(false);
            this.panel_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.PictureBox pb_Logo;
        private System.Windows.Forms.Label lb_MainIntro;
        private System.Windows.Forms.Label lb_Author;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.PictureBox pb_func_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

