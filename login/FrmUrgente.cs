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
    public partial class FrmUrgente : Form
    {
        public FrmUrgente()
        {
            InitializeComponent();
            GetCodUrgenta();
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;

        public void GetCodUrgenta()
        {
            string persid;
            string query = "select codurgenta from urgenta order by codurgenta Desc";
            con.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, con);
            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
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
            txtCodUrgenta.Text = persid.ToString();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void FrmUrgente_Load(object sender, EventArgs e)
        {
            timer2.Start();
            label4.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            dtDataProgramare.Format = DateTimePickerFormat.Custom;
            dtDataProgramare.CustomFormat = "dd-MM-yyy HH:mm";
            comboBox2.Items.Clear();
            con.Open();
            NpgsqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from serviciistomatologice";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da= new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["denumireserviciu"]);
            }
            con.Close();

            cboCodSto.Items.Clear();
            con.Open();
            NpgsqlCommand cmd1;
            cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from personalmedical, stomatolog where codangajat=codstomatolog";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                cboCodSto.Items.Add(dr1["numePersonalMedical"]);
            }
            con.Close();

            cboPacient.Items.Clear();
            con.Open();
            NpgsqlCommand cmd2;
            cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select * from persoane, pacient where codpersoana=codpacient";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr2 in dt2.Rows)
            {
                cboPacient.Items.Add(dr2["numepersoana"] );
            }
            con.Close();


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new NpgsqlCommand("select * from serviciistomatologice where denumireserviciu='" + comboBox2.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            NpgsqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string codserviciustomatologic = (string)dr["codserviciustomatologic"].ToString();
                txtCodServiciuStom.Text = codserviciustomatologic;
            }
            con.Close();
        }

        private void cboCodSto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new NpgsqlCommand("select * from personalmedical inner join stomatolog on stomatolog.codstomatolog=personalmedical.codangajat where numePersonalMedical= '" + comboBox2.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            NpgsqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string codstomatolog = (string)dr["codstomatolog"].ToString();
                txtCodStomatolog.Text = codstomatolog;
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
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
                txtCodPacient.Text =codpersoana;
            }
            con.Close();
        }

        private void btnVizualizare1_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from urgenta", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridVizProgramari.DataSource = data;
            conexiune.Close();
        }
    }
}
