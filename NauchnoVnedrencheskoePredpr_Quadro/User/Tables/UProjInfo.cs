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
    public partial class UProjInfo : Form
    {
        public UProjInfo()
        {
            InitializeComponent();
        }

        private void UProjInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "quadroDataSet.Projects". При необходимости она может быть перемещена или удалена.
            this.projectsTableAdapter.Fill(this.quadroDataSet.Projects);

        }

        private void pb_func_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
