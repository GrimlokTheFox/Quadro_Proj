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
    public partial class UCustomerWorkers : Form
    {
        public UCustomerWorkers()
        {
            InitializeComponent();
        }

        private void UCustomerWorkers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quadroDataSet.Customer_Workers". При необходимости она может быть перемещена или удалена.
            this.customer_WorkersTableAdapter.Fill(this.quadroDataSet.Customer_Workers);

        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
