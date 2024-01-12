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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.dogovor_o_naime". При необходимости она может быть перемещена или удалена.
            this.dogovor_o_naimeTableAdapter.Fill(this.database1DataSet.dogovor_o_naime);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Oklad". При необходимости она может быть перемещена или удалена.
            this.okladTableAdapter.Fill(this.database1DataSet.Oklad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Dolzhnastnya_inforamsia". При необходимости она может быть перемещена или удалена.
            this.dolzhnastnya_inforamsiaTableAdapter.Fill(this.database1DataSet.Dolzhnastnya_inforamsia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.grafic_raboti". При необходимости она может быть перемещена или удалена.
            this.grafic_rabotiTableAdapter.Fill(this.database1DataSet.grafic_raboti);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.lichnye_dannie_sotrudnikov". При необходимости она может быть перемещена или удалена.
            this.lichnye_dannie_sotrudnikovTableAdapter.Fill(this.database1DataSet.lichnye_dannie_sotrudnikov);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Sotrydniki". При необходимости она может быть перемещена или удалена.
            this.sotrydnikiTableAdapter.Fill(this.database1DataSet.Sotrydniki);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search sf = new Search();
            sf.Owner = this;
            sf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sotrydnikiTableAdapter.Update(database1DataSet.Sotrydniki);
            lichnye_dannie_sotrudnikovTableAdapter.Update(database1DataSet.lichnye_dannie_sotrudnikov);
            grafic_rabotiTableAdapter.Update(database1DataSet.grafic_raboti);
            dolzhnastnya_inforamsiaTableAdapter.Update(database1DataSet.Dolzhnastnya_inforamsia);
            okladTableAdapter.Update(database1DataSet.Oklad);
            dogovor_o_naimeTableAdapter.Update(database1DataSet.dogovor_o_naime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add ad = new Add();
            ad.Owner = this;
            ad.Show();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView5_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView6_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LichAdd la = new LichAdd();
            la.Owner = this;
            la.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GrafAdd ga = new GrafAdd();
            ga.Owner = this;
            ga.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DolAdd da  = new DolAdd();
            da.Owner = this;
            da.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OklAdd oa = new OklAdd();
            oa.Owner = this;
            oa.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DogAdd doa = new DogAdd();
            doa.Owner = this;
            doa.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timeadd ta = new timeadd();
            ta.Owner = this;
            ta.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            timedell tdl = new timedell();
            tdl.Owner = this;
            tdl.Show();
        }
    }
}
