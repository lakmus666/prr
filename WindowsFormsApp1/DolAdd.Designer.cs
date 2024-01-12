namespace WindowsFormsApp1
{
    partial class DolAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbdol = new System.Windows.Forms.TextBox();
            this.tbfor = new System.Windows.Forms.TextBox();
            this.tbok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbnmdol = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbnmdol);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbok);
            this.groupBox1.Controls.Add(this.tbfor);
            this.groupBox1.Controls.Add(this.tbdol);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 661);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите информацию для добавления:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(100, 595);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Должность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Форма оплаты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Оклад:";
            // 
            // tbdol
            // 
            this.tbdol.AcceptsReturn = true;
            this.tbdol.Location = new System.Drawing.Point(9, 269);
            this.tbdol.Name = "tbdol";
            this.tbdol.Size = new System.Drawing.Size(166, 34);
            this.tbdol.TabIndex = 4;
            // 
            // tbfor
            // 
            this.tbfor.Location = new System.Drawing.Point(6, 390);
            this.tbfor.Name = "tbfor";
            this.tbfor.Size = new System.Drawing.Size(169, 34);
            this.tbfor.TabIndex = 5;
            // 
            // tbok
            // 
            this.tbok.Location = new System.Drawing.Point(9, 506);
            this.tbok.Name = "tbok";
            this.tbok.Size = new System.Drawing.Size(166, 34);
            this.tbok.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Номер должности:";
            // 
            // tbnmdol
            // 
            this.tbnmdol.Location = new System.Drawing.Point(11, 146);
            this.tbnmdol.Name = "tbnmdol";
            this.tbnmdol.Size = new System.Drawing.Size(164, 34);
            this.tbnmdol.TabIndex = 8;
            // 
            // DolAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 686);
            this.Controls.Add(this.groupBox1);
            this.Name = "DolAdd";
            this.Text = "Добавление информации в \"Должностная информация\"";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbok;
        private System.Windows.Forms.TextBox tbfor;
        private System.Windows.Forms.TextBox tbdol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbnmdol;
        private System.Windows.Forms.Label label4;
    }
}