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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.database1DataSet.Tables[5].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbfio.Text;
                nRow[2] = tbnd.Text;
                main.database1DataSet.Tables[5].Rows.Add(nRow);
                main.sotrydnikiTableAdapter.Update(main.database1DataSet.Sotrydniki);
                main.database1DataSet.Tables[5].AcceptChanges();
                main.dataGridView1.Refresh();
                tbfio.Text = "";
                tbnd.Text = "";


            }
        }

        
    }
}
