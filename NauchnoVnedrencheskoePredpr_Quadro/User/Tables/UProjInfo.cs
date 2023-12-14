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

        private void btn_First_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveFirst();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MovePrevious();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveNext();
        }

        private void btn_Last_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveLast();
        }

        private void tb_srch_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < tableDataGrid.ColumnCount - 1; i++)
            {
                for (int j = 0; j < tableDataGrid.RowCount - 1; j++)
                {
                    tableDataGrid[i, j].Style.BackColor = Color.White;
                    tableDataGrid[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < tableDataGrid.ColumnCount - 1; i++)
            {
                for (int j = 0; j < tableDataGrid.RowCount - 1; j++)
                {
                    if (tableDataGrid[i,
                        j].Value.ToString().IndexOf(tb_srch.Text) != -1)
                    {
                        tableDataGrid[i, j].Style.BackColor = Color.FromArgb(228, 108, 10);
                        tableDataGrid[i, j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableDataGrid.ColumnCount - 1; i++)
            {
                for (int j = 0; j < tableDataGrid.RowCount - 1; j++)
                {
                    tableDataGrid[i, j].Style.BackColor = Color.White;
                    tableDataGrid[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < tableDataGrid.ColumnCount - 1; i++)
            {
                for (int j = 0; j < tableDataGrid.RowCount - 1; j++)
                {
                    if (tableDataGrid[i,
                        j].Value.ToString().IndexOf(tb_srch.Text) != -1)
                    {
                        tableDataGrid[i, j].Style.BackColor = Color.FromArgb(228, 108, 10);
                        tableDataGrid[i, j].Style.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
