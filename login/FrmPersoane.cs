using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class FrmPersoane : Form
    {

        public FrmPersoane()
        {
            InitializeComponent();
           
         

        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
        string npgsql;
      

        public void GetCodPersoana()
        {
            string persid;
            string query = "select codpersoana from persoane order by codpersoana Desc";
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString())+ 1;
                persid = id.ToString("00");
            }
            else if (Convert.IsDBNull(dr))
            {
                persid = ("000");
            }
            else
            {
                persid = ("000");
            }
            con.Close();
            txtCodPersoana.Text = persid.ToString();
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
          
            try
            {
                con.Open();
                cmd = new NpgsqlCommand(npgsql, con);
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("INSERT INTO PERSOANE(codpersoana,numepersoana,datanasterii,gen,cnp,seriaci,numarci,adresa,judet,tara,email,telefon) VALUES ('" + int.Parse(txtCodPersoana.Text)+"','"+ txtNume.Text  + "','" + dtDataNasterii.Text + "','" + cboGen.Text + "','" + txtCNP.Text + "','" + txtSeriaCI.Text + "','" + txtNrCI.Text + "','" + txtAdresa.Text + "','" + txtJudet.Text + "','" + txtTara.Text + "','" + txtEmail.Text + "','" + txtTelefon.Text + "')", con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Ați adăugat cu succes o nouă persoană în baza de date!");
               
                con.Close();
            }
            catch(Exception eroare)
            {
                MessageBox.Show("A aparut o eroare " + eroare.Message.ToString());
                if (con.State == ConnectionState.Open)
                    con.Close();
              
            }
            txtCodPersoana.Clear();
            txtNume.Clear();
            txtCNP.Clear();
            txtSeriaCI.Clear();
            txtNrCI.Clear();
            txtAdresa.Clear();
            txtJudet.Clear();
            txtTara.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            cboGen.Text = string.Empty;
            GetCodPersoana();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rdBtnF_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtJudet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodPersoana_Click(object sender, EventArgs e)
        {

        }

        private void btnVizualizare_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from persoane", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridVizPersoane.DataSource = data;
            conexiune.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune1;
             string sirConectare1;
            sirConectare1 = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune1 = new NpgsqlConnection();
            conexiune1.ConnectionString = sirConectare1;
            if(conexiune1.State== ConnectionState.Closed)
                conexiune1.Open();
            NpgsqlCommand comanda1;
                comanda1 = new NpgsqlCommand("select * from persoane where numepersoana like'%" + txtSearch.Text + "%'", conexiune1);
                NpgsqlDataAdapter sda = new NpgsqlDataAdapter();
                DataTable dt = new DataTable();
                sda.SelectCommand = comanda1;
                dt.Clear();
                
            sda.Fill(dt);
                dtGridVizPersoane.DataSource = dt;
                conexiune1.Close();
            
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            try
            {
                conexiune.Open();
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("DELETE FROM PERSOANE WHERE codpersoana='" + txtCodPersoana.Text + "'", conexiune);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Persoana a fost ștearsă din baza de date!");
                conexiune.Close();
            }
            catch(Exception eroare)
            {
                MessageBox.Show("A aparut o eroare " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
            txtCodPersoana.Clear();
            txtNume.Clear();
            txtCNP.Clear();
            txtSeriaCI.Clear();
            txtNrCI.Clear();
            txtAdresa.Clear();
            txtJudet.Clear();
            txtTara.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            cboGen.Text = string.Empty;
            GetCodPersoana();

        }

        private void btnModifică_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("Update PERSOANE set numepersoana='"  + txtNume.Text +  "',datanasterii='" + dtDataNasterii.Text + "',gen='" + cboGen.Text + "',cnp='" + txtCNP.Text + "',seriaci='" + txtSeriaCI.Text + "',numarci='" + txtNrCI.Text + "',adresa='" + txtAdresa.Text + "',judet='" + txtJudet.Text + "',tara='" + txtTara.Text + "',email='" + txtEmail.Text+"',telefon='"+txtTelefon.Text+"' WHERE codpersoana='"+txtCodPersoana.Text+"'", conexiune);
            SDA.SelectCommand.ExecuteNonQuery();
            conexiune.Close();
            MessageBox.Show("Datele au fost modificate cu succes in baza de date!");
            txtCodPersoana.Clear();
            txtNume.Clear();
            txtCNP.Clear();
            txtSeriaCI.Clear();
            txtNrCI.Clear();
            txtAdresa.Clear();
            txtJudet.Clear();
            txtTara.Clear();
            txtEmail.Clear();
            txtTelefon.Clear();
            cboGen.Text = string.Empty;

        }

        private void FrmPersoane_Load(object sender, EventArgs e)
        {
            GetCodPersoana();
        }

        private void dtGridVizPersoane_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
           txtCodPersoana.Text = dtGridVizPersoane.SelectedRows[0].Cells[0].Value.ToString();
            txtNume.Text = dtGridVizPersoane.SelectedRows[0].Cells[1].Value.ToString();
            dtDataNasterii.Text = dtGridVizPersoane.SelectedRows[0].Cells[2].Value.ToString();
            cboGen.Text = dtGridVizPersoane.SelectedRows[0].Cells[3].Value.ToString();
            txtCNP.Text = dtGridVizPersoane.SelectedRows[0].Cells[4].Value.ToString();
            txtSeriaCI.Text = dtGridVizPersoane.SelectedRows[0].Cells[5].Value.ToString();
           txtNrCI.Text = dtGridVizPersoane.SelectedRows[0].Cells[6].Value.ToString();
            txtAdresa.Text = dtGridVizPersoane.SelectedRows[0].Cells[7].Value.ToString();
            txtJudet.Text = dtGridVizPersoane.SelectedRows[0].Cells[8].Value.ToString();
            txtTara.Text = dtGridVizPersoane.SelectedRows[0].Cells[9].Value.ToString();
            txtEmail.Text = dtGridVizPersoane.SelectedRows[0].Cells[10].Value.ToString();
            txtTelefon.Text = dtGridVizPersoane.SelectedRows[0].Cells[11].Value.ToString();

        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPacienți fm = new FrmPacienți();
            fm.ShowDialog();
        }

        private void dtGridVizPersoane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
    }
}




