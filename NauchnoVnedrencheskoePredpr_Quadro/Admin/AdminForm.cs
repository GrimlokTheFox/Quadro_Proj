using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NauchnoVnedrencheskoePredpr_Quadro.Main;

namespace NauchnoVnedrencheskoePredpr_Quadro.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {

        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.LoggedIn = 0;
            auth.Captcha = 0;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
        }
    }
}
