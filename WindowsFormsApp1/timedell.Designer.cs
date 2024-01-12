namespace WindowsFormsApp1
{
    partial class timedell
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
            this.database1DataSet = new WindowsFormsApp1.Database1DataSet();
            this.записиудаленияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.записи_удаленияTableAdapter = new WindowsFormsApp1.Database1DataSetTableAdapters.Записи_удаленияTableAdapter();
            this.времяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.былоудаленноDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиудаленияBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.времяDataGridViewTextBoxColumn,
            this.былоудаленноDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.записиудаленияBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // записиудаленияBindingSource
            // 
            this.записиудаленияBindingSource.DataMember = "Записи_удаления";
            this.записиудаленияBindingSource.DataSource = this.database1DataSet;
            // 
            // записи_удаленияTableAdapter
            // 
            this.записи_удаленияTableAdapter.ClearBeforeFill = true;
            // 
            // времяDataGridViewTextBoxColumn
            // 
            this.времяDataGridViewTextBoxColumn.DataPropertyName = "Время";
            this.времяDataGridViewTextBoxColumn.HeaderText = "Время";
            this.времяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.времяDataGridViewTextBoxColumn.Name = "времяDataGridViewTextBoxColumn";
            this.времяDataGridViewTextBoxColumn.Width = 125;
            // 
            // былоудаленноDataGridViewTextBoxColumn
            // 
            this.былоудаленноDataGridViewTextBoxColumn.DataPropertyName = "Было_удаленно";
            this.былоудаленноDataGridViewTextBoxColumn.HeaderText = "Было_удаленно";
            this.былоудаленноDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.былоудаленноDataGridViewTextBoxColumn.Name = "былоудаленноDataGridViewTextBoxColumn";
            this.былоудаленноDataGridViewTextBoxColumn.Width = 125;
            // 
            // timedell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "timedell";
            this.Text = "Журнал удаления сотрудников";
            this.Load += new System.EventHandler(this.timedell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.записиудаленияBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource записиудаленияBindingSource;
        private Database1DataSetTableAdapters.Записи_удаленияTableAdapter записи_удаленияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn былоудаленноDataGridViewTextBoxColumn;
    }
}