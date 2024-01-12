namespace WindowsFormsApp1
{
    partial class timeadd
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.былоДобавленноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.записиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.записиTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.ЗаписиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.времяDataGridViewTextBoxColumn,
            this.былоДобавленноDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.записиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 449);
            this.dataGridView1.TabIndex = 0;
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            this.времяDataGridViewTextBoxColumn.Width = 125;
            // 
            // былоДобавленноDataGridViewTextBoxColumn
            // 
            this.былоДобавленноDataGridViewTextBoxColumn.DataPropertyName = "Было_Добавленно";
            this.былоДобавленноDataGridViewTextBoxColumn.HeaderText = "Было_Добавленно";
            this.былоДобавленноDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.былоДобавленноDataGridViewTextBoxColumn.Name = "былоДобавленноDataGridViewTextBoxColumn";
            this.былоДобавленноDataGridViewTextBoxColumn.Width = 125;
            // 
            // записиBindingSource
            // 
            this.записиBindingSource.DataMember = "Записи";
            this.записиBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // записиTableAdapter
            // 
            this.записиTableAdapter.ClearBeforeFill = true;
            // 
            // timeadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "timeadd";
            this.Text = "История добавления сотрудников";
            this.Load += new System.EventHandler(this.timeadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource записиBindingSource;
        private Database1DataSetTableAdapters.ЗаписиTableAdapter записиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn былоДобавленноDataGridViewTextBoxColumn;
    }
}