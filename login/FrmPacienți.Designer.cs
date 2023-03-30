
namespace login
{
    partial class FrmPacienți
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cboStarePacient = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.txtCodPacient = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboBoli = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtReprezentantLegal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDetalii = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResp = new System.Windows.Forms.Button();
            this.btnPacienti = new System.Windows.Forms.Button();
            this.btnRenuntaPacienti = new System.Windows.Forms.Button();
            this.btnVizualizarePacienti = new System.Windows.Forms.Button();
            this.btnModificăPacienti = new System.Windows.Forms.Button();
            this.btnStergerePacienti = new System.Windows.Forms.Button();
            this.btnAdaugaPacienti = new System.Windows.Forms.Button();
            this.dtGridPacienti = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPacienti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.cboStarePacient);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.txtCodPacient);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cboBoli);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.txtReprezentantLegal);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtDetalii);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 255);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informații specifice";
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(290, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(199, 28);
            this.comboBox3.TabIndex = 44;
            this.comboBox3.Text = "Căutare persoane";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            this.comboBox3.Enter += new System.EventHandler(this.comboBox3_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(290, 23);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 28);
            this.comboBox2.TabIndex = 43;
            this.comboBox2.Text = "Căutare persoane";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.Enter += new System.EventHandler(this.comboBox2_Enter);
            this.comboBox2.Leave += new System.EventHandler(this.comboBox2_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(19, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 45);
            this.button2.TabIndex = 42;
            this.button2.Text = "Chestionar Covid-19";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 43);
            this.button1.TabIndex = 41;
            this.button1.Text = "Chestionar sănătate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboStarePacient
            // 
            this.cboStarePacient.FormattingEnabled = true;
            this.cboStarePacient.Items.AddRange(new object[] {
            "ACTIV",
            "INACTIV"});
            this.cboStarePacient.Location = new System.Drawing.Point(229, 101);
            this.cboStarePacient.Name = "cboStarePacient";
            this.cboStarePacient.Size = new System.Drawing.Size(112, 28);
            this.cboStarePacient.TabIndex = 40;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.AllowDrop = true;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker2.Location = new System.Drawing.Point(698, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeftLayout = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(135, 27);
            this.dateTimePicker2.TabIndex = 39;
            this.dateTimePicker2.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // txtCodPacient
            // 
            this.txtCodPacient.Location = new System.Drawing.Point(229, 26);
            this.txtCodPacient.Name = "txtCodPacient";
            this.txtCodPacient.Size = new System.Drawing.Size(55, 27);
            this.txtCodPacient.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Cod pacient:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(521, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Data primei întalnirii:";
            // 
            // cboBoli
            // 
            this.cboBoli.FormattingEnabled = true;
            this.cboBoli.Items.AddRange(new object[] {
            "DA",
            "NU"});
            this.cboBoli.Location = new System.Drawing.Point(600, 98);
            this.cboBoli.Name = "cboBoli";
            this.cboBoli.Size = new System.Drawing.Size(71, 28);
            this.cboBoli.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePicker1.Location = new System.Drawing.Point(698, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 27);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // txtReprezentantLegal
            // 
            this.txtReprezentantLegal.Location = new System.Drawing.Point(229, 63);
            this.txtReprezentantLegal.Name = "txtReprezentantLegal";
            this.txtReprezentantLegal.Size = new System.Drawing.Size(55, 27);
            this.txtReprezentantLegal.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(15, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(183, 20);
            this.label19.TabIndex = 1;
            this.label19.Text = "Cod reprezentant legal:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(521, 101);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Boli:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(521, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 20);
            this.label22.TabIndex = 3;
            this.label22.Text = "Detalii:";
            // 
            // txtDetalii
            // 
            this.txtDetalii.Location = new System.Drawing.Point(600, 137);
            this.txtDetalii.Multiline = true;
            this.txtDetalii.Name = "txtDetalii";
            this.txtDetalii.Size = new System.Drawing.Size(186, 94);
            this.txtDetalii.TabIndex = 11;
            this.txtDetalii.TextChanged += new System.EventHandler(this.txtDetalii_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(15, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(115, 20);
            this.label24.TabIndex = 5;
            this.label24.Text = "Stare Pacient:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(521, 64);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(164, 20);
            this.label25.TabIndex = 6;
            this.label25.Text = "Data ultimei întalniri:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnResp);
            this.groupBox3.Controls.Add(this.btnPacienti);
            this.groupBox3.Controls.Add(this.btnRenuntaPacienti);
            this.groupBox3.Controls.Add(this.btnVizualizarePacienti);
            this.groupBox3.Controls.Add(this.btnModificăPacienti);
            this.groupBox3.Controls.Add(this.btnStergerePacienti);
            this.groupBox3.Controls.Add(this.btnAdaugaPacienti);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(855, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 246);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operațiuni";
            // 
            // btnResp
            // 
            this.btnResp.BackColor = System.Drawing.Color.Cornsilk;
            this.btnResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResp.Location = new System.Drawing.Point(168, 56);
            this.btnResp.Name = "btnResp";
            this.btnResp.Size = new System.Drawing.Size(153, 31);
            this.btnResp.TabIndex = 33;
            this.btnResp.Text = "Resp. Legali>>";
            this.btnResp.UseVisualStyleBackColor = false;
            this.btnResp.Click += new System.EventHandler(this.btnResp_Click);
            // 
            // btnPacienti
            // 
            this.btnPacienti.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienti.Location = new System.Drawing.Point(184, 25);
            this.btnPacienti.Name = "btnPacienti";
            this.btnPacienti.Size = new System.Drawing.Size(128, 28);
            this.btnPacienti.TabIndex = 32;
            this.btnPacienti.Text = "Persoane>";
            this.btnPacienti.UseVisualStyleBackColor = false;
            this.btnPacienti.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // btnRenuntaPacienti
            // 
            this.btnRenuntaPacienti.BackColor = System.Drawing.Color.Bisque;
            this.btnRenuntaPacienti.Location = new System.Drawing.Point(184, 102);
            this.btnRenuntaPacienti.Name = "btnRenuntaPacienti";
            this.btnRenuntaPacienti.Size = new System.Drawing.Size(139, 56);
            this.btnRenuntaPacienti.TabIndex = 31;
            this.btnRenuntaPacienti.Text = "Renunță";
            this.btnRenuntaPacienti.UseVisualStyleBackColor = false;
            this.btnRenuntaPacienti.Click += new System.EventHandler(this.btnRenuntaPacienti_Click);
            // 
            // btnVizualizarePacienti
            // 
            this.btnVizualizarePacienti.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVizualizarePacienti.Location = new System.Drawing.Point(184, 169);
            this.btnVizualizarePacienti.Name = "btnVizualizarePacienti";
            this.btnVizualizarePacienti.Size = new System.Drawing.Size(139, 56);
            this.btnVizualizarePacienti.TabIndex = 27;
            this.btnVizualizarePacienti.Text = "Vizualizează";
            this.btnVizualizarePacienti.UseVisualStyleBackColor = false;
            this.btnVizualizarePacienti.Click += new System.EventHandler(this.btnVizualizare_Click);
            // 
            // btnModificăPacienti
            // 
            this.btnModificăPacienti.BackColor = System.Drawing.Color.Bisque;
            this.btnModificăPacienti.Location = new System.Drawing.Point(21, 169);
            this.btnModificăPacienti.Name = "btnModificăPacienti";
            this.btnModificăPacienti.Size = new System.Drawing.Size(131, 56);
            this.btnModificăPacienti.TabIndex = 26;
            this.btnModificăPacienti.Text = "Modifică";
            this.btnModificăPacienti.UseVisualStyleBackColor = false;
            // 
            // btnStergerePacienti
            // 
            this.btnStergerePacienti.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStergerePacienti.Location = new System.Drawing.Point(20, 102);
            this.btnStergerePacienti.Name = "btnStergerePacienti";
            this.btnStergerePacienti.Size = new System.Drawing.Size(132, 56);
            this.btnStergerePacienti.TabIndex = 25;
            this.btnStergerePacienti.Text = "Șterge";
            this.btnStergerePacienti.UseVisualStyleBackColor = false;
            this.btnStergerePacienti.Click += new System.EventHandler(this.btnStergerePacienti_Click);
            // 
            // btnAdaugaPacienti
            // 
            this.btnAdaugaPacienti.BackColor = System.Drawing.Color.Bisque;
            this.btnAdaugaPacienti.ForeColor = System.Drawing.Color.Black;
            this.btnAdaugaPacienti.Location = new System.Drawing.Point(21, 38);
            this.btnAdaugaPacienti.Name = "btnAdaugaPacienti";
            this.btnAdaugaPacienti.Size = new System.Drawing.Size(131, 54);
            this.btnAdaugaPacienti.TabIndex = 0;
            this.btnAdaugaPacienti.Text = "Adaugă";
            this.btnAdaugaPacienti.UseVisualStyleBackColor = false;
            this.btnAdaugaPacienti.Click += new System.EventHandler(this.btnAdaugaPacienti_Click);
            // 
            // dtGridPacienti
            // 
            this.dtGridPacienti.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPacienti.GridColor = System.Drawing.Color.Wheat;
            this.dtGridPacienti.Location = new System.Drawing.Point(6, 273);
            this.dtGridPacienti.Name = "dtGridPacienti";
            this.dtGridPacienti.RowHeadersWidth = 51;
            this.dtGridPacienti.RowTemplate.Height = 24;
            this.dtGridPacienti.Size = new System.Drawing.Size(1211, 202);
            this.dtGridPacienti.TabIndex = 31;
            this.dtGridPacienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridPacienti_CellContentClick);
            this.dtGridPacienti.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtGridPacienti_MouseDoubleClick);
            // 
            // FrmPacienți
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1231, 487);
            this.Controls.Add(this.dtGridPacienti);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmPacienți";
            this.Text = "FrmPacienți";
            this.Load += new System.EventHandler(this.FrmPacienți_Load);
            this.Enter += new System.EventHandler(this.FrmPacienți_Enter);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPacienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboStarePacient;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox txtCodPacient;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboBoli;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtReprezentantLegal;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDetalii;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnResp;
        private System.Windows.Forms.Button btnPacienti;
        private System.Windows.Forms.Button btnRenuntaPacienti;
        private System.Windows.Forms.Button btnVizualizarePacienti;
        private System.Windows.Forms.Button btnModificăPacienti;
        private System.Windows.Forms.Button btnStergerePacienti;
        private System.Windows.Forms.Button btnAdaugaPacienti;
        private System.Windows.Forms.DataGridView dtGridPacienti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}