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
using NauchnoVnedrencheskoePredpr_Quadro.User.Tables;

namespace NauchnoVnedrencheskoePredpr_Quadro.User
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void btn_BankInfo_Click(object sender, EventArgs e)
        {
            UBankInfo bankInfo = new UBankInfo();
            bankInfo.ShowDialog();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            auth.LoggedIn = 0;
            auth.Captcha = 0;
        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Auth auth = new Auth();
            auth.Show();
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            UEmployees employees = new UEmployees();
            employees.ShowDialog();
        }

        private void btn_Employee_Info_Click(object sender, EventArgs e)
        {
            UEmployeeInfo info = new UEmployeeInfo();
            info.ShowDialog();
        }

        private void btn_Customer_Workers_Click(object sender, EventArgs e)
        {
            UCustomerWorkers customerWorkers = new UCustomerWorkers();
            customerWorkers.ShowDialog();
        }

        private void btn_ProjInfo_Click(object sender, EventArgs e)
        {
            UProjInfo projInfo = new UProjInfo();
            projInfo.ShowDialog();
        }
    }
}
