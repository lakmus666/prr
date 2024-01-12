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
    public partial class GrafAdd : Form
    {
        public GrafAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet.Tables[2].NewRow();
                int rc = main.dataGridView3.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbnach.Text;
                nRow[2] = tbkon.Text;
                main.database1DataSet.Tables[2].Rows.Add(nRow);
                main.grafic_rabotiTableAdapter.Update(main.database1DataSet.grafic_raboti);
                main.database1DataSet.Tables[2].AcceptChanges();
                main.dataGridView3.Refresh();
                tbnach.Text = "";
                tbkon.Text = "";


            }
        }
    }
}
