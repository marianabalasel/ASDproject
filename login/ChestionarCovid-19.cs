using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class ChestionarCovid : Form
    {
        public ChestionarCovid()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPacientiCov_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmPacienți fm = new FrmPacienți();
            fm.ShowDialog();
        }
    }
}
