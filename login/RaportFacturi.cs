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
    public partial class RaportFacturi : Form
    {
        public RaportFacturi()
        {
            InitializeComponent();
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlCommand cmd1;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
        string npgsql;
        private void RaportFacturi_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("select distinct numepersoana, COALESCE(lunaianuarie.valoaretotala1, 0) AS lunaianuarie, COALESCE(lunafebruarie.valoaretotala1, 0) AS lunafebruarie, COALESCE(lunamartie.valoaretotala1, 0) AS lunamartie FROM factura inner join pacient on pacient.codpacient = factura.codpacient inner join persoane on persoane.codpersoana = pacient.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1 from factura  where extract(month from datafactura) = 1 group by codpacient) lunaianuarie on factura.codpacient = lunaianuarie.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1 from factura where extract(month from datafactura) = 2 group by codpacient) lunafebruarie on factura.codpacient = lunafebruarie.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1  from factura  where extract(month from datafactura) = 3 group by codpacient) lunamartie on factura.codpacient = lunamartie.codpacient   order by 1", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            conexiune.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }
        Bitmap bitmap;
        private void button3_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width,dataGridView1.Height) ;
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void btn6luni_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("select distinct numepersoana, COALESCE(lunaianuarie.valoaretotala1, 0) AS lunaianuarie, COALESCE(lunafebruarie.valoaretotala1, 0) AS lunafebruarie, COALESCE(lunamartie.valoaretotala1, 0) AS lunamartie, COALESCE(lunaaprilie.valoaretotala1,0) as lunaaprilie, COALESCE(lunamai.valoaretotala1,0) as lunamai, COALESCE(lunaiunie.valoaretotala1,0) as lunaiunie FROM factura inner join pacient on pacient.codpacient = factura.codpacient inner join persoane on persoane.codpersoana = pacient.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1 from factura  where extract(month from datafactura) = 1 group by codpacient) lunaianuarie on factura.codpacient = lunaianuarie.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1 from factura where extract(month from datafactura) = 2 group by codpacient) lunafebruarie on factura.codpacient = lunafebruarie.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1  from factura  where extract(month from datafactura) = 3 group by codpacient) lunamartie on factura.codpacient = lunamartie.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1  from factura  where extract(month from datafactura) = 4 group by codpacient) lunaaprilie on factura.codpacient = lunaaprilie.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1  from factura  where extract(month from datafactura) = 5 group by codpacient) lunamai on factura.codpacient = lunamai.codpacient left join(select codpacient, SUM(valoaretotala) as valoaretotala1  from factura  where extract(month from datafactura) = 6 group by codpacient) lunaiunie on factura.codpacient = lunaiunie.codpacient  order by 1", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            conexiune.Close();
          
        }
    }
}
