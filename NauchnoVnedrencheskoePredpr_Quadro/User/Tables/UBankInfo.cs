using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NauchnoVnedrencheskoePredpr_Quadro.User
{
    public partial class UBankInfo : Form
    {
        public UBankInfo()
        {
            InitializeComponent();
        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bank_InfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bank_InfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quadroDataSet);

        }

        private void UBankInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quadroDataSet.Bank_Info". При необходимости она может быть перемещена или удалена.
            this.bank_InfoTableAdapter.Fill(this.quadroDataSet.Bank_Info);

        }

        private void btn_First_Click(object sender, EventArgs e)
        {

        }
    }
}
