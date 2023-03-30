
namespace login
{
    partial class FrmPersoane
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtSeriaCI = new System.Windows.Forms.TextBox();
            this.txtNrCI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtJudet = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodPersoana = new System.Windows.Forms.TextBox();
            this.CodPersoana = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cboGen = new System.Windows.Forms.ComboBox();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnResp = new System.Windows.Forms.Button();
            this.btnPacienti = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnVizualizare1 = new System.Windows.Forms.Button();
            this.btnModifică = new System.Windows.Forms.Button();
            this.dtGridVizPersoane = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizPersoane)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Bisque;
            this.btnAdauga.ForeColor = System.Drawing.Color.Black;
            this.btnAdauga.Location = new System.Drawing.Point(80, 26);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(134, 54);
            this.btnAdauga.TabIndex = 0;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume pacient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data nasterii:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "CNP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seria CI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numar CI:";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(166, 68);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(135, 27);
            this.txtNume.TabIndex = 7;
            this.txtNume.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(445, 83);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(150, 27);
            this.txtCNP.TabIndex = 10;
            // 
            // txtSeriaCI
            // 
            this.txtSeriaCI.Location = new System.Drawing.Point(447, 16);
            this.txtSeriaCI.Name = "txtSeriaCI";
            this.txtSeriaCI.Size = new System.Drawing.Size(42, 27);
            this.txtSeriaCI.TabIndex = 11;
            // 
            // txtNrCI
            // 
            this.txtNrCI.Location = new System.Drawing.Point(447, 51);
            this.txtNrCI.Name = "txtNrCI";
            this.txtNrCI.Size = new System.Drawing.Size(87, 27);
            this.txtNrCI.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(637, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Adresă:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(637, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Județ:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(317, 314);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 18;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(445, 150);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 27);
            this.txtTelefon.TabIndex = 20;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(721, 106);
            this.txtAdresa.Multiline = true;
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(150, 56);
            this.txtAdresa.TabIndex = 21;
            this.txtAdresa.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtJudet
            // 
            this.txtJudet.Location = new System.Drawing.Point(721, 61);
            this.txtJudet.Name = "txtJudet";
            this.txtJudet.Size = new System.Drawing.Size(150, 27);
            this.txtJudet.TabIndex = 23;
            this.txtJudet.TextChanged += new System.EventHandler(this.txtJudet_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(355, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Email:";
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStergere.Location = new System.Drawing.Point(220, 25);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(121, 55);
            this.btnStergere.TabIndex = 25;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(445, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 27);
            this.txtEmail.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodPersoana);
            this.groupBox1.Controls.Add(this.CodPersoana);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboGen);
            this.groupBox1.Controls.Add(this.txtTara);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtDataNasterii);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNume);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtJudet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCNP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSeriaCI);
            this.groupBox1.Controls.Add(this.txtNrCI);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(938, 188);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informații persoane";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCodPersoana
            // 
            this.txtCodPersoana.Location = new System.Drawing.Point(166, 26);
            this.txtCodPersoana.Name = "txtCodPersoana";
            this.txtCodPersoana.Size = new System.Drawing.Size(42, 27);
            this.txtCodPersoana.TabIndex = 38;
            // 
            // CodPersoana
            // 
            this.CodPersoana.AutoSize = true;
            this.CodPersoana.Location = new System.Drawing.Point(28, 31);
            this.CodPersoana.Name = "CodPersoana";
            this.CodPersoana.Size = new System.Drawing.Size(118, 20);
            this.CodPersoana.TabIndex = 37;
            this.CodPersoana.Text = "Cod persoană:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 36;
            this.label13.Text = "Gen:";
            // 
            // cboGen
            // 
            this.cboGen.FormattingEnabled = true;
            this.cboGen.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cboGen.Location = new System.Drawing.Point(99, 139);
            this.cboGen.Name = "cboGen";
            this.cboGen.Size = new System.Drawing.Size(46, 28);
            this.cboGen.TabIndex = 35;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(721, 19);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(150, 27);
            this.txtTara.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(637, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Țară:";
            // 
            // dtDataNasterii
            // 
            this.dtDataNasterii.AllowDrop = true;
            this.dtDataNasterii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNasterii.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtDataNasterii.Location = new System.Drawing.Point(166, 109);
            this.dtDataNasterii.Name = "dtDataNasterii";
            this.dtDataNasterii.RightToLeftLayout = true;
            this.dtDataNasterii.Size = new System.Drawing.Size(135, 27);
            this.dtDataNasterii.TabIndex = 28;
            this.dtDataNasterii.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            this.dtDataNasterii.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnResp);
            this.groupBox2.Controls.Add(this.btnPacienti);
            this.groupBox2.Controls.Add(this.btnRenunta);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnVizualizare1);
            this.groupBox2.Controls.Add(this.btnModifică);
            this.groupBox2.Controls.Add(this.btnStergere);
            this.groupBox2.Controls.Add(this.btnAdauga);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(944, 118);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operațiuni";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(6, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 24);
            this.label14.TabIndex = 36;
            this.label14.Text = "Căutare...";
            // 
            // btnResp
            // 
            this.btnResp.BackColor = System.Drawing.Color.Cornsilk;
            this.btnResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResp.Location = new System.Drawing.Point(776, 53);
            this.btnResp.Name = "btnResp";
            this.btnResp.Size = new System.Drawing.Size(148, 31);
            this.btnResp.TabIndex = 33;
            this.btnResp.Text = "Resp. Legali>>";
            this.btnResp.UseVisualStyleBackColor = false;
            // 
            // btnPacienti
            // 
            this.btnPacienti.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienti.Location = new System.Drawing.Point(802, 19);
            this.btnPacienti.Name = "btnPacienti";
            this.btnPacienti.Size = new System.Drawing.Size(108, 28);
            this.btnPacienti.TabIndex = 32;
            this.btnPacienti.Text = "Pacienți>>";
            this.btnPacienti.UseVisualStyleBackColor = false;
            this.btnPacienti.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.Bisque;
            this.btnRenunta.Location = new System.Drawing.Point(635, 24);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(126, 56);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunță";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.CausesValidation = false;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.txtSearch.HideSelection = false;
            this.txtSearch.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtSearch.Location = new System.Drawing.Point(116, 93);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ShortcutsEnabled = false;
            this.txtSearch.Size = new System.Drawing.Size(116, 20);
            this.txtSearch.TabIndex = 30;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseWaitCursor = true;
            this.txtSearch.WordWrap = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnVizualizare1
            // 
            this.btnVizualizare1.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVizualizare1.Location = new System.Drawing.Point(487, 24);
            this.btnVizualizare1.Name = "btnVizualizare1";
            this.btnVizualizare1.Size = new System.Drawing.Size(142, 56);
            this.btnVizualizare1.TabIndex = 27;
            this.btnVizualizare1.Text = "Vizualizează";
            this.btnVizualizare1.UseVisualStyleBackColor = false;
            this.btnVizualizare1.Click += new System.EventHandler(this.btnVizualizare_Click);
            // 
            // btnModifică
            // 
            this.btnModifică.BackColor = System.Drawing.Color.Bisque;
            this.btnModifică.Location = new System.Drawing.Point(347, 24);
            this.btnModifică.Name = "btnModifică";
            this.btnModifică.Size = new System.Drawing.Size(134, 56);
            this.btnModifică.TabIndex = 26;
            this.btnModifică.Text = "Modifică";
            this.btnModifică.UseVisualStyleBackColor = false;
            this.btnModifică.Click += new System.EventHandler(this.btnModifică_Click);
            // 
            // dtGridVizPersoane
            // 
            this.dtGridVizPersoane.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridVizPersoane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVizPersoane.GridColor = System.Drawing.Color.Wheat;
            this.dtGridVizPersoane.Location = new System.Drawing.Point(16, 350);
            this.dtGridVizPersoane.Name = "dtGridVizPersoane";
            this.dtGridVizPersoane.RowHeadersWidth = 51;
            this.dtGridVizPersoane.RowTemplate.Height = 24;
            this.dtGridVizPersoane.Size = new System.Drawing.Size(944, 173);
            this.dtGridVizPersoane.TabIndex = 29;
            this.dtGridVizPersoane.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridVizPersoane_CellContentClick);
            this.dtGridVizPersoane.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtGridVizPersoane_MouseDoubleClick);
            // 
            // FrmPersoane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(981, 535);
            this.Controls.Add(this.dtGridVizPersoane);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label12);
            this.Name = "FrmPersoane";
            this.Text = "FrmPersoane";
            this.Load += new System.EventHandler(this.FrmPersoane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizPersoane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtSeriaCI;
        private System.Windows.Forms.TextBox txtNrCI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtJudet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtDataNasterii;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVizualizare1;
        private System.Windows.Forms.Button btnModifică;
        private System.Windows.Forms.DataGridView dtGridVizPersoane;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboGen;
        private System.Windows.Forms.TextBox txtCodPersoana;
        private System.Windows.Forms.Label CodPersoana;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnResp;
        private System.Windows.Forms.Button btnPacienti;
        private System.Windows.Forms.Label label14;
    }
}