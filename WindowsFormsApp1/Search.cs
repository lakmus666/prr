using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView1.RowCount; i++)
                {
                    main.dataGridView1.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView1.ColumnCount; j++)
                        if (main.dataGridView1.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void tbStr_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView2.RowCount; i++)
                {
                    main.dataGridView2.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView2.ColumnCount; j++)
                        if (main.dataGridView2.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView2.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView2.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView3.RowCount; i++)
                {
                    main.dataGridView3.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView3.ColumnCount; j++)
                        if (main.dataGridView3.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView3.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView3.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView4.RowCount; i++)
                {
                    main.dataGridView4.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView4.ColumnCount; j++)
                        if (main.dataGridView4.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView4.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView4.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView5.RowCount; i++)
                {
                    main.dataGridView5.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView5.ColumnCount; j++)
                        if (main.dataGridView5.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView5.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView5.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGridView6.RowCount; i++)
                {
                    main.dataGridView6.Rows[i].Selected = false;
                    for (int j = 0; j < main.dataGridView6.ColumnCount; j++)
                        if (main.dataGridView6.Rows[i].Cells[j].Value != null)
                            if (main.dataGridView6.Rows[i].Cells[j].Value.ToString().Contains(tbStr.Text))
                            {
                                main.dataGridView6.Rows[i].Selected = true;
                                break;
                            }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
