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
    public partial class frmProgramări : Form
    {
        Event @event = new Event();
        public int AppCodProgramare = 0;
        public frmProgramări()
        {
            InitializeComponent();
            GetCodProgramare();
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
       


        public void GetCodProgramare()
        {
            string persid;
            string query = "select codprogramare from programare order by codprogramare Desc";
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
           txtCodProgramare.Text = persid.ToString();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune1;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune1 = new NpgsqlConnection();
            conexiune1.ConnectionString = sirConectare;
            try
            {
                conexiune1.Open();
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("INSERT INTO PROGRAMARE(codprogramare,codpacient,dataora,status) VALUES ('" + int.Parse(txtCodProgramare.Text) + "','" + int.Parse(txtCodPacient.Text)+ "','" + dtDataProgramare.Text + "','" + cboStatus.Text + "')", conexiune1);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Ați adăugat cu succes o nouă programare în baza de date!");
                conexiune1.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut o eroare " + eroare.Message.ToString());
                if (conexiune1.State == ConnectionState.Open)
                    conexiune1.Close();
            }
            txtCodPacient.Clear();
            txtCodProgramare.Clear();
            cboStatus.Text= string.Empty;
            comboBox1.Text = string.Empty;
            GetCodProgramare();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        public DataTable QueryAsDataTable(string npgsql)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            MessageBox.Show("S-a deschis conexiunea");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(npgsql, conexiune);
            DataSet ds = new DataSet();
            da.Fill(ds, "result");
            return ds.Tables["result"];
            conexiune.Close();
        }

        private void dtDataProgramare_ValueChanged(object sender, EventArgs e)
        {

        }
     
        private void frmCalendar_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select numepersoana from persoane";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["numepersoana"] );
            }
            con.Close();
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
            dtDataProgramare.Format = DateTimePickerFormat.Custom;
            dtDataProgramare.CustomFormat = "dd-MM-yyy HH:mm";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar fm = new Calendar();
            fm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calendar fm = new Calendar();
            fm.ShowDialog();
        }

        private void btnVizualizare1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from programare", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridVizProgramari.DataSource = data;
            conexiune.Close();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmd = new NpgsqlCommand("select * from persoane where numepersoana='" + comboBox1.Text +"'" , con);
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

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Căutare pacient";

            }
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Căutare pacient")
            {
                comboBox1.Text = "";

            }
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
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("DELETE FROM programare WHERE codprogramare='" + txtCodProgramare.Text + "'", conexiune);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Programarea a fost ștearsă din baza de date!");
                conexiune.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut o eroare " + eroare.Message.ToString());
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
            txtCodPacient.Clear();
            txtCodProgramare.Clear();
            cboStatus.Text = string.Empty;
            comboBox1.Text = string.Empty;
            GetCodProgramare();
        }

        private void dtGridVizProgramari_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           txtCodProgramare.Text = dtGridVizProgramari.SelectedRows[0].Cells[0].Value.ToString();
            txtCodPacient.Text = dtGridVizProgramari.SelectedRows[0].Cells[1].Value.ToString();
          dtDataProgramare.Text = dtGridVizProgramari.SelectedRows[0].Cells[2].Value.ToString();
            cboStatus.Text = dtGridVizProgramari.SelectedRows[0].Cells[3].Value.ToString();
           
        }

        private void txtCodProgramare_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
   
}

