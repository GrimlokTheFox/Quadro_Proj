
namespace NauchnoVnedrencheskoePredpr_Quadro.User
{
    partial class UBankInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UBankInfo));
            this.panel_main = new System.Windows.Forms.Panel();
            this.rdbtn_DESC = new System.Windows.Forms.RadioButton();
            this.rdbtn_ASC = new System.Windows.Forms.RadioButton();
            this.tb_srch = new System.Windows.Forms.TextBox();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.tableDataGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bank_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quadroDataSet = new NauchnoVnedrencheskoePredpr_Quadro.QuadroDataSet();
            this.bank_InfoTableAdapter = new NauchnoVnedrencheskoePredpr_Quadro.QuadroDataSetTableAdapters.Bank_InfoTableAdapter();
            this.tableAdapterManager = new NauchnoVnedrencheskoePredpr_Quadro.QuadroDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_func_Exit = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quadroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.panel_main.Controls.Add(this.rdbtn_DESC);
            this.panel_main.Controls.Add(this.rdbtn_ASC);
            this.panel_main.Controls.Add(this.tb_srch);
            this.panel_main.Controls.Add(this.btn_Sort);
            this.panel_main.Controls.Add(this.btn_Search);
            this.panel_main.Controls.Add(this.btn_Last);
            this.panel_main.Controls.Add(this.btn_next);
            this.panel_main.Controls.Add(this.btn_prev);
            this.panel_main.Controls.Add(this.btn_First);
            this.panel_main.Controls.Add(this.tableDataGrid);
            this.panel_main.Location = new System.Drawing.Point(12, 68);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(776, 370);
            this.panel_main.TabIndex = 17;
            // 
            // rdbtn_DESC
            // 
            this.rdbtn_DESC.AutoSize = true;
            this.rdbtn_DESC.Location = new System.Drawing.Point(585, 295);
            this.rdbtn_DESC.Name = "rdbtn_DESC";
            this.rdbtn_DESC.Size = new System.Drawing.Size(83, 27);
            this.rdbtn_DESC.TabIndex = 11;
            this.rdbtn_DESC.TabStop = true;
            this.rdbtn_DESC.Text = "Точка 2";
            this.rdbtn_DESC.UseVisualStyleBackColor = true;
            // 
            // rdbtn_ASC
            // 
            this.rdbtn_ASC.AutoSize = true;
            this.rdbtn_ASC.Location = new System.Drawing.Point(585, 262);
            this.rdbtn_ASC.Name = "rdbtn_ASC";
            this.rdbtn_ASC.Size = new System.Drawing.Size(83, 27);
            this.rdbtn_ASC.TabIndex = 10;
            this.rdbtn_ASC.TabStop = true;
            this.rdbtn_ASC.Text = "Точка 1";
            this.rdbtn_ASC.UseVisualStyleBackColor = true;
            // 
            // tb_srch
            // 
            this.tb_srch.Location = new System.Drawing.Point(26, 273);
            this.tb_srch.Name = "tb_srch";
            this.tb_srch.Size = new System.Drawing.Size(212, 29);
            this.tb_srch.TabIndex = 8;
            this.tb_srch.TextChanged += new System.EventHandler(this.tb_srch_TextChanged);
            // 
            // btn_Sort
            // 
            this.btn_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sort.Location = new System.Drawing.Point(580, 328);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(105, 39);
            this.btn_Sort.TabIndex = 6;
            this.btn_Sort.Text = "Сортировать";
            this.btn_Sort.UseVisualStyleBackColor = false;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(244, 270);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(105, 39);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Поиск";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Last
            // 
            this.btn_Last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_Last.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Last.Location = new System.Drawing.Point(355, 328);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(105, 39);
            this.btn_Last.TabIndex = 4;
            this.btn_Last.Text = "Последняя";
            this.btn_Last.UseVisualStyleBackColor = false;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Location = new System.Drawing.Point(244, 328);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(105, 39);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "Вперед";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Location = new System.Drawing.Point(133, 328);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(105, 39);
            this.btn_prev.TabIndex = 2;
            this.btn_prev.Text = "Назад";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_First
            // 
            this.btn_First.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_First.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_First.Location = new System.Drawing.Point(22, 328);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(105, 39);
            this.btn_First.TabIndex = 1;
            this.btn_First.Text = "Первая";
            this.btn_First.UseVisualStyleBackColor = false;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // tableDataGrid
            // 
            this.tableDataGrid.AllowUserToAddRows = false;
            this.tableDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.tableDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDataGrid.AutoGenerateColumns = false;
            this.tableDataGrid.BackgroundColor = System.Drawing.Color.Black;
            this.tableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tableDataGrid.DataSource = this.bank_InfoBindingSource;
            this.tableDataGrid.GridColor = System.Drawing.Color.White;
            this.tableDataGrid.Location = new System.Drawing.Point(3, 3);
            this.tableDataGrid.Name = "tableDataGrid";
            this.tableDataGrid.ReadOnly = true;
            this.tableDataGrid.Size = new System.Drawing.Size(538, 249);
            this.tableDataGrid.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Account_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код Аккаунта";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Bank_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название банка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Customer_INN";
            this.dataGridViewTextBoxColumn3.HeaderText = "ИНН Заказчика";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bank_InfoBindingSource
            // 
            this.bank_InfoBindingSource.DataMember = "Bank_Info";
            this.bank_InfoBindingSource.DataSource = this.quadroDataSet;
            // 
            // quadroDataSet
            // 
            this.quadroDataSet.DataSetName = "QuadroDataSet";
            this.quadroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bank_InfoTableAdapter
            // 
            this.bank_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Bank_InfoTableAdapter = this.bank_InfoTableAdapter;
            this.tableAdapterManager.Customer_WorkersTableAdapter = null;
            this.tableAdapterManager.CustomersTableAdapter = null;
            this.tableAdapterManager.Employees_InfoTableAdapter = null;
            this.tableAdapterManager.Employees_PaymentTableAdapter = null;
            this.tableAdapterManager.Employees_Work_TimeTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.ProjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NauchnoVnedrencheskoePredpr_Quadro.QuadroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.Logo_text;
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pb_func_Exit
            // 
            this.pb_func_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_func_Exit.BackgroundImage = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.close;
            this.pb_func_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_func_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_func_Exit.Location = new System.Drawing.Point(738, 12);
            this.pb_func_Exit.Name = "pb_func_Exit";
            this.pb_func_Exit.Size = new System.Drawing.Size(50, 50);
            this.pb_func_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_func_Exit.TabIndex = 15;
            this.pb_func_Exit.TabStop = false;
            this.pb_func_Exit.Click += new System.EventHandler(this.pb_func_Exit_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.Logo;
            this.pb_logo.Location = new System.Drawing.Point(12, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(50, 50);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 14;
            this.pb_logo.TabStop = false;
            // 
            // UBankInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_func_Exit);
            this.Controls.Add(this.pb_logo);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "UBankInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банковская Информация";
            this.Load += new System.EventHandler(this.UBankInfo_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bank_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quadroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_func_Exit;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Panel panel_main;
        private QuadroDataSet quadroDataSet;
        private System.Windows.Forms.BindingSource bank_InfoBindingSource;
        private QuadroDataSetTableAdapters.Bank_InfoTableAdapter bank_InfoTableAdapter;
        private QuadroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.RadioButton rdbtn_DESC;
        private System.Windows.Forms.RadioButton rdbtn_ASC;
        private System.Windows.Forms.TextBox tb_srch;
    }
}