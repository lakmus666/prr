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
    public partial class DogAdd : Form
    {
        public DogAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet.Tables[0].NewRow();
                int rc = main.dataGridView6.RowCount + 1;
                nRow[0] = tbdog.Text;
                nRow[1] = tbzak.Text;
                nRow[2] = rc;
                nRow[3] = tbras.Text;
                main.database1DataSet.Tables[0].Rows.Add(nRow);
                main.dogovor_o_naimeTableAdapter.Update(main.database1DataSet.dogovor_o_naime);
                main.database1DataSet.Tables[0].AcceptChanges();
                main.dataGridView6.Refresh();
                tbdog.Text = "";
                tbzak.Text = "";
                tbras.Text = "";


            }
        }
    }
}
