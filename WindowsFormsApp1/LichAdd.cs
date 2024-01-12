using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LichAdd : Form
    {
        public LichAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet.Tables[3].NewRow();
                int rc = main.dataGridView2.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbpol.Text;
                nRow[2] = tbcon.Text;
                nRow[3] = textBox3.Text;
                nRow[4] = textBox4.Text;
                main.database1DataSet.Tables[3].Rows.Add(nRow);
                main.lichnye_dannie_sotrudnikovTableAdapter.Update(main.database1DataSet.lichnye_dannie_sotrudnikov);
                main.database1DataSet.Tables[3].AcceptChanges();
                main.dataGridView2.Refresh();
                tbpol.Text = "";
                tbcon.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";


            }
        }
    }
}
