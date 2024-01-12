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
    public partial class timedell : Form
    {
        public timedell()
        {
            InitializeComponent();
        }

        private void timedell_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Записи_удаления". При необходимости она может быть перемещена или удалена.
            this.записи_удаленияTableAdapter.Fill(this.database1DataSet.Записи_удаления);

        }
    }
}
