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
    public partial class FrmServiciiPrestate : Form
    {
        public FrmServiciiPrestate()
        {
            InitializeComponent();
            GetIdServciu();
        }
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica");
        NpgsqlCommand cmd;
        NpgsqlDataAdapter da;
        NpgsqlDataReader dr;
        public void GetIdServciu()
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
            txtIdServiciuPrestat.Text = persid.ToString();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {

        }

        private void btnVizualizare1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from serviciiprestate", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridVizServiciiPrestate.DataSource = data;
            conexiune.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnModifică_Click(object sender, EventArgs e)
        {

        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {

        }

        private void dtGridVizPersoane_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServiciiPrestate));
            this.txtIdServiciuPrestat = new System.Windows.Forms.TextBox();
            this.txtCodServiciuStomatologic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodStomatolog = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodUrgenta = new System.Windows.Forms.TextBox();
            this.txtCodProgramare = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSear = new System.Windows.Forms.TextBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnVizualizare1 = new System.Windows.Forms.Button();
            this.btnModifică = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dtGridVizServiciiPrestate = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizServiciiPrestate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdServiciuPrestat
            // 
            this.txtIdServiciuPrestat.Location = new System.Drawing.Point(242, 20);
            this.txtIdServiciuPrestat.Name = "txtIdServiciuPrestat";
            this.txtIdServiciuPrestat.Size = new System.Drawing.Size(54, 27);
            this.txtIdServiciuPrestat.TabIndex = 60;
            this.txtIdServiciuPrestat.TextChanged += new System.EventHandler(this.txtIdServiciuPrestat_TextChanged);
            // 
            // txtCodServiciuStomatologic
            // 
            this.txtCodServiciuStomatologic.Location = new System.Drawing.Point(242, 63);
            this.txtCodServiciuStomatologic.Name = "txtCodServiciuStomatologic";
            this.txtCodServiciuStomatologic.Size = new System.Drawing.Size(54, 27);
            this.txtCodServiciuStomatologic.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Id serviciu prestat:";
            // 
            // txtCodStomatolog
            // 
            this.txtCodStomatolog.Location = new System.Drawing.Point(242, 107);
            this.txtCodStomatolog.Name = "txtCodStomatolog";
            this.txtCodStomatolog.Size = new System.Drawing.Size(54, 27);
            this.txtCodStomatolog.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Cod programare:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Cod serviciu stomatologic:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cod factură:";
            // 
            // txtCodUrgenta
            // 
            this.txtCodUrgenta.Location = new System.Drawing.Point(242, 196);
            this.txtCodUrgenta.Name = "txtCodUrgenta";
            this.txtCodUrgenta.Size = new System.Drawing.Size(54, 27);
            this.txtCodUrgenta.TabIndex = 46;
            // 
            // txtCodProgramare
            // 
            this.txtCodProgramare.Location = new System.Drawing.Point(242, 149);
            this.txtCodProgramare.Name = "txtCodProgramare";
            this.txtCodProgramare.Size = new System.Drawing.Size(54, 27);
            this.txtCodProgramare.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Cod urgență:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.txtIdServiciuPrestat);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCodStomatolog);
            this.groupBox2.Controls.Add(this.txtCodUrgenta);
            this.groupBox2.Controls.Add(this.txtCodServiciuStomatologic);
            this.groupBox2.Controls.Add(this.txtCodProgramare);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 268);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informații servicii prestate";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(306, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 28);
            this.comboBox2.TabIndex = 61;
            this.comboBox2.Text = "Căutare serviciu stomatologic";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtSear);
            this.groupBox3.Controls.Add(this.btnRenunta);
            this.groupBox3.Controls.Add(this.btnVizualizare1);
            this.groupBox3.Controls.Add(this.btnModifică);
            this.groupBox3.Controls.Add(this.btnStergere);
            this.groupBox3.Controls.Add(this.btnAdauga);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(994, 111);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operațiuni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 34;
            this.label6.Text = "Căutare...";
            // 
            // txtSear
            // 
            this.txtSear.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSear.Location = new System.Drawing.Point(119, 78);
            this.txtSear.Name = "txtSear";
            this.txtSear.Size = new System.Drawing.Size(100, 27);
            this.txtSear.TabIndex = 33;
            this.txtSear.TextChanged += new System.EventHandler(this.txtSear_TextChanged);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.Bisque;
            this.btnRenunta.Location = new System.Drawing.Point(846, 23);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(126, 56);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunță";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click_1);
            // 
            // btnVizualizare1
            // 
            this.btnVizualizare1.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVizualizare1.Location = new System.Drawing.Point(687, 25);
            this.btnVizualizare1.Name = "btnVizualizare1";
            this.btnVizualizare1.Size = new System.Drawing.Size(142, 56);
            this.btnVizualizare1.TabIndex = 27;
            this.btnVizualizare1.Text = "Vizualizează";
            this.btnVizualizare1.UseVisualStyleBackColor = false;
            this.btnVizualizare1.Click += new System.EventHandler(this.btnVizualizare1_Click_1);
            // 
            // btnModifică
            // 
            this.btnModifică.BackColor = System.Drawing.Color.Bisque;
            this.btnModifică.Location = new System.Drawing.Point(532, 26);
            this.btnModifică.Name = "btnModifică";
            this.btnModifică.Size = new System.Drawing.Size(134, 56);
            this.btnModifică.TabIndex = 26;
            this.btnModifică.Text = "Modifică";
            this.btnModifică.UseVisualStyleBackColor = false;
            this.btnModifică.Click += new System.EventHandler(this.btnModifică_Click_1);
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStergere.Location = new System.Drawing.Point(378, 25);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(121, 55);
            this.btnStergere.TabIndex = 25;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Bisque;
            this.btnAdauga.ForeColor = System.Drawing.Color.Black;
            this.btnAdauga.Location = new System.Drawing.Point(226, 28);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(134, 54);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = false;
            // 
            // dtGridVizServiciiPrestate
            // 
            this.dtGridVizServiciiPrestate.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridVizServiciiPrestate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVizServiciiPrestate.GridColor = System.Drawing.Color.Wheat;
            this.dtGridVizServiciiPrestate.Location = new System.Drawing.Point(12, 426);
            this.dtGridVizServiciiPrestate.Name = "dtGridVizServiciiPrestate";
            this.dtGridVizServiciiPrestate.RowHeadersWidth = 51;
            this.dtGridVizServiciiPrestate.RowTemplate.Height = 24;
            this.dtGridVizServiciiPrestate.Size = new System.Drawing.Size(992, 175);
            this.dtGridVizServiciiPrestate.TabIndex = 63;
            this.dtGridVizServiciiPrestate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridVizServiciiPrestate_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(535, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmServiciiPrestate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1018, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtGridVizServiciiPrestate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmServiciiPrestate";
            this.Text = "FrmServiciiPresate";
            this.Load += new System.EventHandler(this.FrmServiciiPrestate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizServiciiPrestate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void FrmServiciiPrestate_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            con.Open();
            NpgsqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from serviciistomatologice";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr["denumireserviciu"]);
            }
            con.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dtGridVizServiciiPrestate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRenunta_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdentisApp fm = new AdentisApp();
            fm.ShowDialog();
        }

        private void btnVizualizare1_Click_1(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter("Select * from serviciiprestate", conexiune);
            DataTable data = new DataTable();
            sda.Fill(data);
            dtGridVizServiciiPrestate.DataSource = data;
            conexiune.Close();
        }

        private void btnModifică_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSear_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conexiune1;
            string sirConectare1;
            sirConectare1 = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune1 = new NpgsqlConnection();
            conexiune1.ConnectionString = sirConectare1;
            if (conexiune1.State == ConnectionState.Closed)
                conexiune1.Open();
            NpgsqlCommand comanda1;
            comanda1 = new NpgsqlCommand("select * from serviciiprestate where idserviciuprestat like'%" + txtSear.Text + "%'", conexiune1);
            NpgsqlDataAdapter sda = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            sda.SelectCommand = comanda1;
            dt.Clear();

            sda.Fill(dt);
            dtGridVizServiciiPrestate.DataSource = dt;
            conexiune1.Close();
        }

        private void txtIdServiciuPrestat_TextChanged(object sender, EventArgs e)
        {

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
                txtCodServiciuStomatologic.Text = codserviciustomatologic;
            }
            con.Close();
        }
    }
}
