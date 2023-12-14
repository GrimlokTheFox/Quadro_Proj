using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NauchnoVnedrencheskoePredpr_Quadro
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            
        }
        //Глобальные значения для входа в аккаунт админа/пользователя после успешного ввода каптчи
        public static int isLoggedIn = 0;
        public static int isCaptchaGood = 0;
        private void lb_MainIntro_Click(object sender, EventArgs e)
        {

        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void WelcomeScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
