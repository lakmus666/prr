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
    public partial class OklAdd : Form
    {
        public OklAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet.Tables[4].NewRow();
                int rc = main.dataGridView5.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbdol.Text;
                nRow[2] = tbok.Text;
                main.database1DataSet.Tables[4].Rows.Add(nRow);
                main.okladTableAdapter.Update(main.database1DataSet.Oklad);
                main.database1DataSet.Tables[4].AcceptChanges();
                main.dataGridView5.Refresh();
                tbdol.Text = "";
                tbok.Text = "";


            }
        }
    }
}
