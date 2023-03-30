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
    public partial class ChestionarSănătate : Form
    {
        public ChestionarSănătate()
        {
            InitializeComponent();
        }

        private void ChestionarSănătate_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
          
        }

        private void btnPacientiChestionar_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmPacienți fm = new FrmPacienți();
            fm.ShowDialog();
        }
    }
}
