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
    public partial class FrmProgramareServicii : Form
    {
        Event @event = new Event();
        public int AppID = 0;
        public FrmProgramareServicii()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void FrmProgramareServicii_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyy HH:mm";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
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
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("INSERT INTO PROGRAMARISERVICII(codprogramare,codserviciustomatologic,codstomatolog,detalii) VALUES ('" + int.Parse(txtCodProgramare1.Text) + "','" + int.Parse(txtCodServiciuStomatologic.Text) + "','" + int.Parse(txtCodStomatolog.Text) + "','" + txtDetalii.Text + "')", conexiune1);
                SDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Ați adăugat cu succes o nouă programare de servicii în baza de date!");
                conexiune1.Close();
            }
            catch (Exception eroare)
            {
                MessageBox.Show("A aparut o eroare " + eroare.Message.ToString());
                if (conexiune1.State == ConnectionState.Open)
                    conexiune1.Close();
            }
            txtCodStomatolog.Clear();
            txtCodProgramare1.Clear();
            txtCodServiciuStomatologic.Clear();
            txtDetalii.Clear();
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
                NpgsqlDataAdapter SDA = new NpgsqlDataAdapter("DELETE FROM programare WHERE codprogramare='" + txtCodProgramare1.Text + "'", conexiune);
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
            txtCodStomatolog.Clear();
            txtCodProgramare1.Clear();
            txtCodServiciuStomatologic.Clear();
            txtDetalii.Clear();
        }
        public int ID
        {
           set { AppID = value; }
            get { return AppID; }
        
    }
        public string textBox1
        {
            set { txtCodStomatolog.Text = value; }
            get { return txtCodStomatolog.Text; }
        }
        public string textBox2
        {
            set {txtCodServiciuStomatologic.Text = value; }
            get { return txtCodServiciuStomatologic.Text; }
        }
        public string textBox3
        {
            set { txtDetalii.Text = value; }
            get { return txtDetalii.Text; }
        }
        public string textBox4
        {
            set { txtCodProgramare1.Text = value; }
            get { return txtCodProgramare1.Text; }
        }

        
        public string textBox
        {
            set { txtDenumireServiciu.Text = value; }
            get { return txtDenumireServiciu.Text; }
        }

        public string textBoxx
        {
            set { txtNumeStomatolog.Text = value; }
            get { return txtNumeStomatolog.Text; }
        }
        public DateTime DatePicker
        {
            set { dateTimePicker1.Value = value; }
            get { return dateTimePicker1.Value; }
        }
         
        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
