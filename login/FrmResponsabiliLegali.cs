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
    public partial class FrmResponsabiliLegali : Form
    {
        public FrmResponsabiliLegali()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
        string npgsql;

        private void btnPacienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPersoane fm = new FrmPersoane();
            fm.ShowDialog();
        }

        private void btnResp_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            FrmPacienți fm = new FrmPacienți();
            fm.ShowDialog();
        }

        private void btnRenuntaPacienti_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void txtCodProgr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStergerePacienti_Click(object sender, EventArgs e)
        {

        }

       
        private void FrmResponsabiliLegali_Load(object sender, EventArgs e)
        {
            cboReprezentant.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select distinct numepersoana from persoane";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cboReprezentant.Items.Add(dr["numepersoana"]);
            }
            con.Close();

            cboPacient.Items.Clear();
            con.Open();
            NpgsqlCommand cmd1;
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select numepersoana from persoane,pacient where codpacient=codpersoana";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                cboPacient.Items.Add(dr1["numepersoana"]);
            }
            con.Close();


        }

        private void txtCodPacient_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void cboReprezentant_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmd = new NpgsqlCommand("select * from persoane where numepersoana='" + cboReprezentant.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            NpgsqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string codpersoana = (string)dr["codpersoana"].ToString();
                txtCodReprez.Text = codpersoana;
            }
            con.Close();
        }

        private void cboPacient_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new NpgsqlCommand("select * from persoane where numepersoana='" + cboPacient.Text + "'", con);
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

        private void btnVizualizarePacienti_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from reprezentantlegal", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridPacienti.DataSource = data;
            conexiune.Close();
        }
    }
}
