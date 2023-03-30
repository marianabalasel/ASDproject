
namespace login
{
    partial class FrmUrgente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrgente));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodPacient = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodStomatolog = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPacient = new System.Windows.Forms.ComboBox();
            this.cboCodSto = new System.Windows.Forms.ComboBox();
            this.CodPersoana = new System.Windows.Forms.Label();
            this.dtDataProgramare = new System.Windows.Forms.DateTimePicker();
            this.txtCodServiciuStom = new System.Windows.Forms.TextBox();
            this.txtCodUrgenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnVizualizare1 = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnModifică = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.dtGridVizProgramari = new System.Windows.Forms.DataGridView();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizProgramari)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodPacient);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodStomatolog);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboPacient);
            this.groupBox1.Controls.Add(this.cboCodSto);
            this.groupBox1.Controls.Add(this.CodPersoana);
            this.groupBox1.Controls.Add(this.dtDataProgramare);
            this.groupBox1.Controls.Add(this.txtCodServiciuStom);
            this.groupBox1.Controls.Add(this.txtCodUrgenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 288);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informații urgențe";
            // 
            // txtCodPacient
            // 
            this.txtCodPacient.Location = new System.Drawing.Point(233, 115);
            this.txtCodPacient.Name = "txtCodPacient";
            this.txtCodPacient.Size = new System.Drawing.Size(55, 27);
            this.txtCodPacient.TabIndex = 50;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(309, 48);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 28);
            this.comboBox2.TabIndex = 49;
            this.comboBox2.Text = "Căutare serviciu stomatologic";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cod pacient:";
            // 
            // txtCodStomatolog
            // 
            this.txtCodStomatolog.Location = new System.Drawing.Point(233, 82);
            this.txtCodStomatolog.Name = "txtCodStomatolog";
            this.txtCodStomatolog.Size = new System.Drawing.Size(55, 27);
            this.txtCodStomatolog.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 59);
            this.textBox1.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Detalii:";
            // 
            // cboPacient
            // 
            this.cboPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPacient.ForeColor = System.Drawing.Color.DimGray;
            this.cboPacient.FormattingEnabled = true;
            this.cboPacient.Location = new System.Drawing.Point(309, 114);
            this.cboPacient.Name = "cboPacient";
            this.cboPacient.Size = new System.Drawing.Size(205, 28);
            this.cboPacient.TabIndex = 44;
            this.cboPacient.Text = "Căutare pacient";
            this.cboPacient.SelectedIndexChanged += new System.EventHandler(this.cboPacient_SelectedIndexChanged);
            // 
            // cboCodSto
            // 
            this.cboCodSto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCodSto.ForeColor = System.Drawing.Color.DimGray;
            this.cboCodSto.FormattingEnabled = true;
            this.cboCodSto.Items.AddRange(new object[] {
            "Încheiată cu succes",
            "Programare neonorată"});
            this.cboCodSto.Location = new System.Drawing.Point(309, 82);
            this.cboCodSto.Name = "cboCodSto";
            this.cboCodSto.Size = new System.Drawing.Size(205, 28);
            this.cboCodSto.TabIndex = 38;
            this.cboCodSto.Text = "Căutare stomatolog";
            this.cboCodSto.SelectedIndexChanged += new System.EventHandler(this.cboCodSto_SelectedIndexChanged);
            // 
            // CodPersoana
            // 
            this.CodPersoana.AutoSize = true;
            this.CodPersoana.Location = new System.Drawing.Point(6, 26);
            this.CodPersoana.Name = "CodPersoana";
            this.CodPersoana.Size = new System.Drawing.Size(105, 20);
            this.CodPersoana.TabIndex = 37;
            this.CodPersoana.Text = "Cod urgență:";
            // 
            // dtDataProgramare
            // 
            this.dtDataProgramare.Checked = false;
            this.dtDataProgramare.CustomFormat = "";
            this.dtDataProgramare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataProgramare.Location = new System.Drawing.Point(219, 151);
            this.dtDataProgramare.Name = "dtDataProgramare";
            this.dtDataProgramare.Size = new System.Drawing.Size(245, 27);
            this.dtDataProgramare.TabIndex = 4;
            // 
            // txtCodServiciuStom
            // 
            this.txtCodServiciuStom.Location = new System.Drawing.Point(233, 52);
            this.txtCodServiciuStom.Name = "txtCodServiciuStom";
            this.txtCodServiciuStom.Size = new System.Drawing.Size(55, 27);
            this.txtCodServiciuStom.TabIndex = 3;
            // 
            // txtCodUrgenta
            // 
            this.txtCodUrgenta.Location = new System.Drawing.Point(233, 19);
            this.txtCodUrgenta.Name = "txtCodUrgenta";
            this.txtCodUrgenta.Size = new System.Drawing.Size(55, 27);
            this.txtCodUrgenta.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cod stomatolog:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cod serviciu stomatologic:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Data și ora urgenței:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnRenunta);
            this.groupBox2.Controls.Add(this.btnVizualizare1);
            this.groupBox2.Controls.Add(this.btnSalvare);
            this.groupBox2.Controls.Add(this.btnModifică);
            this.groupBox2.Controls.Add(this.btnStergere);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(538, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 288);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operațiuni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ora:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(299, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 64);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.Bisque;
            this.btnRenunta.Location = new System.Drawing.Point(299, 24);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(126, 66);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunță";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnVizualizare1
            // 
            this.btnVizualizare1.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVizualizare1.Location = new System.Drawing.Point(22, 110);
            this.btnVizualizare1.Name = "btnVizualizare1";
            this.btnVizualizare1.Size = new System.Drawing.Size(139, 66);
            this.btnVizualizare1.TabIndex = 27;
            this.btnVizualizare1.Text = "Vizualizează";
            this.btnVizualizare1.UseVisualStyleBackColor = false;
            this.btnVizualizare1.Click += new System.EventHandler(this.btnVizualizare1_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.BackColor = System.Drawing.Color.Bisque;
            this.btnSalvare.Location = new System.Drawing.Point(22, 26);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(139, 64);
            this.btnSalvare.TabIndex = 8;
            this.btnSalvare.Text = "Adaugă";
            this.btnSalvare.UseVisualStyleBackColor = false;
            // 
            // btnModifică
            // 
            this.btnModifică.BackColor = System.Drawing.Color.Bisque;
            this.btnModifică.Location = new System.Drawing.Point(167, 110);
            this.btnModifică.Name = "btnModifică";
            this.btnModifică.Size = new System.Drawing.Size(126, 64);
            this.btnModifică.TabIndex = 26;
            this.btnModifică.Text = "Modifică";
            this.btnModifică.UseVisualStyleBackColor = false;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStergere.Location = new System.Drawing.Point(167, 25);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(126, 65);
            this.btnStergere.TabIndex = 25;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            // 
            // dtGridVizProgramari
            // 
            this.dtGridVizProgramari.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridVizProgramari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVizProgramari.GridColor = System.Drawing.Color.Wheat;
            this.dtGridVizProgramari.Location = new System.Drawing.Point(12, 306);
            this.dtGridVizProgramari.Name = "dtGridVizProgramari";
            this.dtGridVizProgramari.RowHeadersWidth = 51;
            this.dtGridVizProgramari.RowTemplate.Height = 24;
            this.dtGridVizProgramari.Size = new System.Drawing.Size(960, 132);
            this.dtGridVizProgramari.TabIndex = 32;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmUrgente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.dtGridVizProgramari);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUrgente";
            this.Text = "FrmUrgențe";
            this.Load += new System.EventHandler(this.FrmUrgente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizProgramari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPacient;
        private System.Windows.Forms.ComboBox cboCodSto;
        private System.Windows.Forms.Label CodPersoana;
        private System.Windows.Forms.DateTimePicker dtDataProgramare;
        private System.Windows.Forms.TextBox txtCodServiciuStom;
        private System.Windows.Forms.TextBox txtCodUrgenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodStomatolog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnVizualizare1;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnModifică;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridView dtGridVizProgramari;
        private System.Windows.Forms.TextBox txtCodPacient;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer2;
    }
}