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
    public partial class AdentisApp : Form
    {
        public AdentisApp()
        {
            InitializeComponent();
        }

        private void AdentisApp_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mmmmmyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
           FrmUrgente fm = new FrmUrgente();
            fm.ShowDialog();

        }

        private void pacientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void persoaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersoane fm = new FrmPersoane();
            fm.ShowDialog();
        }

        private void paciențiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPacienți fm = new FrmPacienți();
            fm.ShowDialog();
        }

        private void facturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmFacturi fm = new FrmFacturi();
            fm.ShowDialog();
        }

        private void calendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar fm = new Calendar();
            fm.ShowDialog();
        }

        private void programariToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmProgramări fm = new frmProgramări();
            fm.ShowDialog();
        }

        private void responsabilLegalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           FrmResponsabiliLegali fm = new FrmResponsabiliLegali();
            fm.ShowDialog();
        }

        private void serviciiPrestateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmServiciiPrestate fm = new FrmServiciiPrestate();
            fm.ShowDialog();
        }

        private void raportPersonalMedicalProgramLucruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RaportPersonalMedicalProgramLucru fm = new RaportPersonalMedicalProgramLucru();
            fm.ShowDialog();
        }

        private void raportPaciențiServiciiPrestateAfecțiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
           RaportPacientiServiciiPrestateAfectiuni fm = new RaportPacientiServiciiPrestateAfectiuni();
            fm.ShowDialog();
        }

        private void calendar1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void raportFacturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
         RaportFacturi fm = new RaportFacturi();
            fm.ShowDialog();
        }

    }
}
