using Npgsql;
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
    public partial class FrmPacienți : Form
    {
        public FrmPacienți()
        {
            InitializeComponent();
        


        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=l1");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
        string npgsql;
      


        private void FrmPacienți_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select codpersoana, numepersoana from persoane left join pacient on persoane.codpersoana = pacient.codpacient except select codpersoana, numepersoana from persoane right join pacient on persoane.codpersoana = pacient.codpacient";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["numepersoana"]);
            }
            con.Close();
            comboBox3.Items.Clear();
            con.Open();
            NpgsqlCommand cmd1;
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select numepersoana from persoane";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                comboBox3.Items.Add(dr1["numepersoana"]);
            }
            con.Close();



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtGridPacienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from pacient", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridPacienti.DataSource = data;
            conexiune.Close();
        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersoane fm = new FrmPersoane();
            fm.ShowDialog();
        }

        private void btnResp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmResponsabiliLegali fm = new FrmResponsabiliLegali();
            fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChestionarSănătate fm = new ChestionarSănătate();
            fm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChestionarCovid fm = new ChestionarCovid();
            fm.ShowDialog();
        }

        private void btnRenuntaPacienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void btnAdaugaPacienti_Click(object sender, EventArgs e)
        {


            try
            {
                con.Open();
                cmd = new NpgsqlCommand(npgsql, con);
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("INSERT INTO PACIENT(codpacient,codreprezentantlegal,boli,detalii,dataprimeiintalniri,dataultimeiintalniri,starepacient) VALUES ('" + int.Parse(txtCodPacient.Text) + "','" + int.Parse(txtReprezentantLegal.Text) + "','" +cboBoli.Text + "','" + txtDetalii.Text + "','" + dateTimePicker2.Text + "','" + dateTimePicker1.Text  +"','"+cboStarePacient.Text+ "')", con);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Ați adăugat cu succes un nou pacient în baza de date!");

                con.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut o eroare " + eroare.Message.ToString());
                if (con.State == ConnectionState.Open)
                    con.Close();

            }
            txtCodPacient.Clear();
            txtReprezentantLegal.Clear();
            txtDetalii.Clear();
             cboBoli.Text = string.Empty;
            cboStarePacient.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new NpgsqlCommand("select * from persoane where numepersoana='" + comboBox2.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            NpgsqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string codpersoana = (string)dr["codpersoana"].ToString();
                txtCodPacient.Text = codpersoana;
            }
            con.Close();

          
        } 

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new NpgsqlCommand("select * from persoane where numepersoana='" + comboBox3.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            NpgsqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string codpersoana = (string)dr["codpersoana"].ToString();
                txtReprezentantLegal.Text = codpersoana;
            }
            con.Close();
        }

        private void txtDetalii_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtCautarePacienti_TextChanged(object sender, EventArgs e)
        {
          
         
        }

        private void FrmPacienți_Enter(object sender, EventArgs e)
        {

        }

        private void txtCautarePacienti_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtCautarePacienti_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Căutare pacient")
            {
               comboBox2.Text = "";

            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                comboBox2.Text = "Căutare pacient";

            }
        }

        private void comboBox3_Enter(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Căutare reprezentant")
            {
                comboBox3.Text = "";

            }
        }
        private void comboBox3_Leave(object sender, EventArgs e)
        {
            if (comboBox3.Text == "")
            {
                comboBox3.Text = "Căutare reprezentant";

            }
        }

        private void btnStergerePacienti_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=l1";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            try
            {
                conexiune.Open();
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("DELETE FROM PACIENT WHERE codpacient='" + txtCodPacient.Text + "'", conexiune);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Pacientul a fost șters din baza de date!");
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut o eroare " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
            txtCodPacient.Clear();
            txtReprezentantLegal.Clear();
            txtDetalii.Clear();
            cboBoli.Text = string.Empty;
            cboStarePacient.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
        }

        private void dtGridPacienti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodPacient.Text = dtGridPacienti.SelectedRows[0].Cells[0].Value.ToString();
            txtReprezentantLegal.Text = dtGridPacienti.SelectedRows[0].Cells[1].Value.ToString();
            cboBoli.Text = dtGridPacienti.SelectedRows[0].Cells[2].Value.ToString();
            txtDetalii.Text = dtGridPacienti.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker2.Text = dtGridPacienti.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text = dtGridPacienti.SelectedRows[0].Cells[5].Value.ToString();
          cboStarePacient.Text = dtGridPacienti.SelectedRows[0].Cells[6].Value.ToString();
            

        }
    }
}
