using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdditionalFunc_Lib;
using NauchnoVnedrencheskoePredpr_Quadro.Main;

namespace NauchnoVnedrencheskoePredpr_Quadro.Main
{
    public partial class CaptchaCheck : Form
    {
        public CaptchaCheck()
        {
            InitializeComponent();
        }
        //Данная переменная дублирует данные из окна авторизации
        public static int passed;

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DoCaptcha captcha = new DoCaptcha();
            pb_Captcha.Image = captcha.CreateImage(300, 150);
        }
        //Проверка
        private void btn_check_Click(object sender, EventArgs e)
        {
            DoCaptcha captcha = new DoCaptcha();
            string text = captcha.GetText();
            if (tb_check_captcha.Text == text)
            {
                MessageBox.Show("Успех!");
                passed = 1;
                this.Close();
            }
            else
            {
                MessageBox.Show("Попробуйте ещё раз!");
                tb_check_captcha.Text = "";
                pb_Captcha.Image = captcha.CreateImage(300, 150);
            }
        }

        private void CaptchaCheck_Load(object sender, EventArgs e)
        {
            DoCaptcha captcha = new DoCaptcha();
            pb_Captcha.Image = captcha.CreateImage(300, 150);
        }
    }
}
