﻿
namespace NauchnoVnedrencheskoePredpr_Quadro.User.Tables
{
    partial class UEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UEmployees));
            this.panel_main = new System.Windows.Forms.Panel();
            this.rdbtn_DESC = new System.Windows.Forms.RadioButton();
            this.rdbtn_ASC = new System.Windows.Forms.RadioButton();
            this.cmbbox_Filter = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.tableDataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_func_Exit = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.quadroDataSet = new NauchnoVnedrencheskoePredpr_Quadro.QuadroDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new NauchnoVnedrencheskoePredpr_Quadro.QuadroDataSetTableAdapters.EmployeesTableAdapter();
            this.employeenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeepictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quadroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(217)))), ((int)(((byte)(195)))));
            this.panel_main.Controls.Add(this.rdbtn_DESC);
            this.panel_main.Controls.Add(this.rdbtn_ASC);
            this.panel_main.Controls.Add(this.cmbbox_Filter);
            this.panel_main.Controls.Add(this.textBox1);
            this.panel_main.Controls.Add(this.btn_Filter);
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
            this.panel_main.TabIndex = 21;
            // 
            // rdbtn_DESC
            // 
            this.rdbtn_DESC.AutoSize = true;
            this.rdbtn_DESC.Location = new System.Drawing.Point(589, 67);
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
            this.rdbtn_ASC.Location = new System.Drawing.Point(589, 34);
            this.rdbtn_ASC.Name = "rdbtn_ASC";
            this.rdbtn_ASC.Size = new System.Drawing.Size(83, 27);
            this.rdbtn_ASC.TabIndex = 10;
            this.rdbtn_ASC.TabStop = true;
            this.rdbtn_ASC.Text = "Точка 1";
            this.rdbtn_ASC.UseVisualStyleBackColor = true;
            // 
            // cmbbox_Filter
            // 
            this.cmbbox_Filter.FormattingEnabled = true;
            this.cmbbox_Filter.Location = new System.Drawing.Point(560, 221);
            this.cmbbox_Filter.Name = "cmbbox_Filter";
            this.cmbbox_Filter.Size = new System.Drawing.Size(199, 31);
            this.cmbbox_Filter.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 29);
            this.textBox1.TabIndex = 8;
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Filter.Location = new System.Drawing.Point(608, 263);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(105, 39);
            this.btn_Filter.TabIndex = 7;
            this.btn_Filter.Text = "Фильтр";
            this.btn_Filter.UseVisualStyleBackColor = false;
            // 
            // btn_Sort
            // 
            this.btn_Sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(108)))), ((int)(((byte)(10)))));
            this.btn_Sort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sort.Location = new System.Drawing.Point(608, 100);
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
            // 
            // tableDataGrid
            // 
            this.tableDataGrid.AllowUserToAddRows = false;
            this.tableDataGrid.AllowUserToDeleteRows = false;
            this.tableDataGrid.AutoGenerateColumns = false;
            this.tableDataGrid.BackgroundColor = System.Drawing.Color.Black;
            this.tableDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeenameDataGridViewTextBoxColumn,
            this.employeepictureDataGridViewImageColumn});
            this.tableDataGrid.DataSource = this.employeesBindingSource;
            this.tableDataGrid.GridColor = System.Drawing.Color.White;
            this.tableDataGrid.Location = new System.Drawing.Point(3, 3);
            this.tableDataGrid.Name = "tableDataGrid";
            this.tableDataGrid.ReadOnly = true;
            this.tableDataGrid.Size = new System.Drawing.Size(538, 249);
            this.tableDataGrid.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NauchnoVnedrencheskoePredpr_Quadro.Properties.Resources.Logo_text;
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
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
            this.pb_func_Exit.TabIndex = 19;
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
            this.pb_logo.TabIndex = 18;
            this.pb_logo.TabStop = false;
            // 
            // quadroDataSet
            // 
            this.quadroDataSet.DataSetName = "QuadroDataSet";
            this.quadroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.quadroDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeenameDataGridViewTextBoxColumn
            // 
            this.employeenameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeenameDataGridViewTextBoxColumn.DataPropertyName = "Employee_name";
            this.employeenameDataGridViewTextBoxColumn.HeaderText = "ФИО Работника";
            this.employeenameDataGridViewTextBoxColumn.Name = "employeenameDataGridViewTextBoxColumn";
            this.employeenameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeepictureDataGridViewImageColumn
            // 
            this.employeepictureDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeepictureDataGridViewImageColumn.DataPropertyName = "Employee_picture";
            this.employeepictureDataGridViewImageColumn.HeaderText = "Фото Сотрудника";
            this.employeepictureDataGridViewImageColumn.Name = "employeepictureDataGridViewImageColumn";
            this.employeepictureDataGridViewImageColumn.ReadOnly = true;
            // 
            // UEmployees
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "UEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UEmployees";
            this.Load += new System.EventHandler(this.UEmployees_Load);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_func_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quadroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.RadioButton rdbtn_DESC;
        private System.Windows.Forms.RadioButton rdbtn_ASC;
        private System.Windows.Forms.ComboBox cmbbox_Filter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.DataGridView tableDataGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_func_Exit;
        private System.Windows.Forms.PictureBox pb_logo;
        private QuadroDataSet quadroDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private QuadroDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn employeepictureDataGridViewImageColumn;
    }
}