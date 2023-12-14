using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NauchnoVnedrencheskoePredpr_Quadro.User.Tables
{
    public partial class UEmployeeInfo : Form
    {
        public UEmployeeInfo()
        {
            InitializeComponent();
        }

        private void UEmployeeInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quadroDataSet.Employees_Info". При необходимости она может быть перемещена или удалена.
            this.employees_InfoTableAdapter.Fill(this.quadroDataSet.Employees_Info);

        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
