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
    public partial class FrmFacturi : Form
    {
        public FrmFacturi()
        {
            InitializeComponent();
            GetCodFactura();
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
        public void GetCodFactura()
        {
            string persid;
            string query = "select codfactura from factura order by codfactura Desc";
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
            txtCodFactura.Text = persid.ToString();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {

        }

        private void btnPacienti_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmPacienți fm = new FrmPacienți();
            fm.ShowDialog();
        }
        
        private void btnPreviw_Click(object sender, EventArgs e)
        {
            

        }

        

        private void FrmFacturi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void dtGridVizFacturi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtCodFactura.Text = dtGridVizFacturi.SelectedRows[0].Cells[0].Value.ToString();
            txtCodPacient.Text = dtGridVizFacturi.SelectedRows[0].Cells[1].Value.ToString();
            dtDataFacturii.Text = dtGridVizFacturi.SelectedRows[0].Cells[2].Value.ToString();
            txtNrFactura.Text = dtGridVizFacturi.SelectedRows[0].Cells[3].Value.ToString();
            txtValoareTotala.Text = dtGridVizFacturi.SelectedRows[0].Cells[4].Value.ToString();

        }

        private void btnVizualizare1_Click(object sender, EventArgs e)
        {
              NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from factura", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridVizFacturi.DataSource = data;
            conexiune.Close();
        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void FrmFacturi_Load(object sender, EventArgs e)
        {

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
                cboPacient.Items.Add(dr2["numepersoana"]);
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
