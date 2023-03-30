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
    public partial class RaportPacientiServiciiPrestateAfectiuni : Form
    {
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private ComboBox cboPacienti;
        private ListBox listBox1;
        private ListBox listBox2;

        public RaportPacientiServiciiPrestateAfectiuni()
        {
            InitializeComponent();
         
           
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlCommand cmd1;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
        string npgsql;

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cboPacienti = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(62, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pacienți";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(62, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "ServiciiPrestate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(62, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Afecțiuni";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Ivory;
            this.button2.ForeColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 34);
            this.button2.TabIndex = 14;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboPacienti
            // 
            this.cboPacienti.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPacienti.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPacienti.ForeColor = System.Drawing.Color.DimGray;
            this.cboPacienti.FormattingEnabled = true;
            this.cboPacienti.Location = new System.Drawing.Point(33, 85);
            this.cboPacienti.Name = "cboPacienti";
            this.cboPacienti.Size = new System.Drawing.Size(515, 30);
            this.cboPacienti.TabIndex = 15;
            this.cboPacienti.Text = "Căutare pacienți";
            this.cboPacienti.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(33, 172);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 120);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Location = new System.Drawing.Point(33, 339);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(515, 120);
            this.listBox2.TabIndex = 19;
            // 
            // RaportPacientiServiciiPrestateAfectiuni
            // 
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(626, 480);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cboPacienti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RaportPacientiServiciiPrestateAfectiuni";
            this.Text = "Raport Pacienți-ServiciiPrestate-Afecțiuni";
            this.Load += new System.EventHandler(this.RaportPacientiServiciiPrestateAfectiuni_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void RaportPacientiServiciiPrestateAfectiuni_Load(object sender, EventArgs e)
        {
            cboPacienti.Items.Clear();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select numepersoana from persoane, pacient where codpersoana=codpacient";
            cmd.ExecuteNonQuery();
              DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cboPacienti.Items.Add(dr["numepersoana"]);
            }
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();       
            cmd = new NpgsqlCommand("select denumireserviciu from persoane inner join pacient on  persoane.codpersoana = pacient.codpacient inner join programare on pacient.codpacient = programare.codpacient inner join serviciiprestate on serviciiprestate.codprogramare = programare.codprogramare inner join serviciistomatologice on serviciistomatologice.codserviciustomatologic = serviciiprestate.codserviciustomatologic where numepersoana='" + cboPacienti.Text + "'", con) ;
            con.Open();
            cmd.ExecuteNonQuery();
            NpgsqlDataReader dr;
                int i = 0;
            dr = cmd.ExecuteReader();
        
            while (dr.Read())
            {  
                listBox1.Items.Add(dr["denumireserviciu"]);
                
                
            }
            con.Close();

            listBox2.Items.Clear();
            cmd1 = new NpgsqlCommand(" select distinct denumireafectiune from persoane inner join pacient on persoane.codpersoana = pacient.codpacient inner join programare on pacient.codpacient = programare.codpacient inner join serviciiprestate on serviciiprestate.codprogramare = programare.codprogramare inner join diagnostice on diagnostice.idserviciuprestat = serviciiprestate.idserviciuprestat inner join afectiuni on afectiuni.codafectiune = diagnostice.codafectiune where numepersoana='"+cboPacienti.Text+"'",con);
            con.Open();
            cmd1.ExecuteNonQuery();
            NpgsqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                listBox2.Items.Add(dr1["denumireafectiune"]);


            }
            con.Close();  

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
