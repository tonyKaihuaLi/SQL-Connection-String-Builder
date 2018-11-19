using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConnectionStringBuilder
{
    public partial class MiniFrm : Form
    {
        public MiniFrm()
        {
            InitializeComponent();

            SqlConnectionStringBuilder sqlConStrBld = new SqlConnectionStringBuilder();
            this.pG4String.SelectedObject = sqlConStrBld;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGetSting_Click(object sender, EventArgs e)
        {
            string str = this.pG4String.SelectedObject.ToString();
            Clipboard.Clear();
            Clipboard.SetText(str);
            MessageBox.Show(str);
        }
    }
}
