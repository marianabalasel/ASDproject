
namespace login
{
    partial class FrmResponsabiliLegali
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboPacient = new System.Windows.Forms.ComboBox();
            this.cboReprezentant = new System.Windows.Forms.ComboBox();
            this.CodPersoana = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCodPacient = new System.Windows.Forms.TextBox();
            this.txtCodReprez = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPacienți = new System.Windows.Forms.Button();
            this.btnPersoane = new System.Windows.Forms.Button();
            this.btnRenuntaPacienti = new System.Windows.Forms.Button();
            this.btnVizualizarePacienti = new System.Windows.Forms.Button();
            this.btnModificăPacienti = new System.Windows.Forms.Button();
            this.btnStergerePacienti = new System.Windows.Forms.Button();
            this.btnAdaugaPacienti = new System.Windows.Forms.Button();
            this.dtGridPacienti = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPacienti)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPacient);
            this.groupBox1.Controls.Add(this.cboReprezentant);
            this.groupBox1.Controls.Add(this.CodPersoana);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtCodPacient);
            this.groupBox1.Controls.Add(this.txtCodReprez);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 230);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informații reprezentant legal";
            // 
            // cboPacient
            // 
            this.cboPacient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPacient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPacient.ForeColor = System.Drawing.Color.DimGray;
            this.cboPacient.FormattingEnabled = true;
            this.cboPacient.Location = new System.Drawing.Point(334, 66);
            this.cboPacient.Name = "cboPacient";
            this.cboPacient.Size = new System.Drawing.Size(182, 28);
            this.cboPacient.TabIndex = 40;
            this.cboPacient.Text = "Căutare persoane";
            this.cboPacient.SelectedIndexChanged += new System.EventHandler(this.cboPacient_SelectedIndexChanged);
            // 
            // cboReprezentant
            // 
            this.cboReprezentant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboReprezentant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboReprezentant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReprezentant.ForeColor = System.Drawing.Color.DimGray;
            this.cboReprezentant.FormattingEnabled = true;
            this.cboReprezentant.Location = new System.Drawing.Point(334, 26);
            this.cboReprezentant.Name = "cboReprezentant";
            this.cboReprezentant.Size = new System.Drawing.Size(182, 28);
            this.cboReprezentant.TabIndex = 39;
            this.cboReprezentant.Text = "Căutare persoane";
            this.cboReprezentant.SelectedIndexChanged += new System.EventHandler(this.cboReprezentant_SelectedIndexChanged);
            // 
            // CodPersoana
            // 
            this.CodPersoana.AutoSize = true;
            this.CodPersoana.Location = new System.Drawing.Point(9, 29);
            this.CodPersoana.Name = "CodPersoana";
            this.CodPersoana.Size = new System.Drawing.Size(183, 20);
            this.CodPersoana.TabIndex = 37;
            this.CodPersoana.Text = "Cod reprezentant legal:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(240, 116);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(135, 27);
            this.txtStatus.TabIndex = 7;
            // 
            // txtCodPacient
            // 
            this.txtCodPacient.Location = new System.Drawing.Point(240, 69);
            this.txtCodPacient.Name = "txtCodPacient";
            this.txtCodPacient.Size = new System.Drawing.Size(52, 27);
            this.txtCodPacient.TabIndex = 3;
            this.txtCodPacient.TextChanged += new System.EventHandler(this.txtCodPacient_TextChanged);
            // 
            // txtCodReprez
            // 
            this.txtCodReprez.Location = new System.Drawing.Point(240, 25);
            this.txtCodReprez.Name = "txtCodReprez";
            this.txtCodReprez.Size = new System.Drawing.Size(52, 27);
            this.txtCodReprez.TabIndex = 2;
            this.txtCodReprez.TextChanged += new System.EventHandler(this.txtCodProgr_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rol persoană:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cod pacient:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPacienți);
            this.groupBox3.Controls.Add(this.btnPersoane);
            this.groupBox3.Controls.Add(this.btnRenuntaPacienti);
            this.groupBox3.Controls.Add(this.btnVizualizarePacienti);
            this.groupBox3.Controls.Add(this.btnModificăPacienti);
            this.groupBox3.Controls.Add(this.btnStergerePacienti);
            this.groupBox3.Controls.Add(this.btnAdaugaPacienti);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(539, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 230);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operațiuni";
            // 
            // btnPacienți
            // 
            this.btnPacienți.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPacienți.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacienți.Location = new System.Drawing.Point(182, 53);
            this.btnPacienți.Name = "btnPacienți";
            this.btnPacienți.Size = new System.Drawing.Size(153, 31);
            this.btnPacienți.TabIndex = 33;
            this.btnPacienți.Text = "Pacienți>>";
            this.btnPacienți.UseVisualStyleBackColor = false;
            this.btnPacienți.Click += new System.EventHandler(this.btnResp_Click);
            // 
            // btnPersoane
            // 
            this.btnPersoane.BackColor = System.Drawing.Color.Cornsilk;
            this.btnPersoane.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersoane.Location = new System.Drawing.Point(196, 24);
            this.btnPersoane.Name = "btnPersoane";
            this.btnPersoane.Size = new System.Drawing.Size(128, 28);
            this.btnPersoane.TabIndex = 32;
            this.btnPersoane.Text = "Persoane>";
            this.btnPersoane.UseVisualStyleBackColor = false;
            this.btnPersoane.Click += new System.EventHandler(this.btnPacienti_Click);
            // 
            // btnRenuntaPacienti
            // 
            this.btnRenuntaPacienti.BackColor = System.Drawing.Color.Bisque;
            this.btnRenuntaPacienti.Location = new System.Drawing.Point(185, 90);
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
            this.btnVizualizarePacienti.Location = new System.Drawing.Point(185, 152);
            this.btnVizualizarePacienti.Name = "btnVizualizarePacienti";
            this.btnVizualizarePacienti.Size = new System.Drawing.Size(139, 56);
            this.btnVizualizarePacienti.TabIndex = 27;
            this.btnVizualizarePacienti.Text = "Vizualizează";
            this.btnVizualizarePacienti.UseVisualStyleBackColor = false;
            this.btnVizualizarePacienti.Click += new System.EventHandler(this.btnVizualizarePacienti_Click);
            // 
            // btnModificăPacienti
            // 
            this.btnModificăPacienti.BackColor = System.Drawing.Color.Bisque;
            this.btnModificăPacienti.Location = new System.Drawing.Point(30, 152);
            this.btnModificăPacienti.Name = "btnModificăPacienti";
            this.btnModificăPacienti.Size = new System.Drawing.Size(130, 56);
            this.btnModificăPacienti.TabIndex = 26;
            this.btnModificăPacienti.Text = "Modifică";
            this.btnModificăPacienti.UseVisualStyleBackColor = false;
            // 
            // btnStergerePacienti
            // 
            this.btnStergerePacienti.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStergerePacienti.Location = new System.Drawing.Point(30, 90);
            this.btnStergerePacienti.Name = "btnStergerePacienti";
            this.btnStergerePacienti.Size = new System.Drawing.Size(130, 56);
            this.btnStergerePacienti.TabIndex = 25;
            this.btnStergerePacienti.Text = "Șterge";
            this.btnStergerePacienti.UseVisualStyleBackColor = false;
            this.btnStergerePacienti.Click += new System.EventHandler(this.btnStergerePacienti_Click);
            // 
            // btnAdaugaPacienti
            // 
            this.btnAdaugaPacienti.BackColor = System.Drawing.Color.Bisque;
            this.btnAdaugaPacienti.ForeColor = System.Drawing.Color.Black;
            this.btnAdaugaPacienti.Location = new System.Drawing.Point(30, 29);
            this.btnAdaugaPacienti.Name = "btnAdaugaPacienti";
            this.btnAdaugaPacienti.Size = new System.Drawing.Size(130, 54);
            this.btnAdaugaPacienti.TabIndex = 0;
            this.btnAdaugaPacienti.Text = "Adaugă";
            this.btnAdaugaPacienti.UseVisualStyleBackColor = false;
            // 
            // dtGridPacienti
            // 
            this.dtGridPacienti.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPacienti.GridColor = System.Drawing.Color.Wheat;
            this.dtGridPacienti.Location = new System.Drawing.Point(3, 257);
            this.dtGridPacienti.Name = "dtGridPacienti";
            this.dtGridPacienti.RowHeadersWidth = 51;
            this.dtGridPacienti.RowTemplate.Height = 24;
            this.dtGridPacienti.Size = new System.Drawing.Size(894, 211);
            this.dtGridPacienti.TabIndex = 32;
            // 
            // FrmResponsabiliLegali
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(909, 480);
            this.Controls.Add(this.dtGridPacienti);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmResponsabiliLegali";
            this.Text = "FrmReprezentantiLegali";
            this.Load += new System.EventHandler(this.FrmResponsabiliLegali_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPacienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CodPersoana;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCodPacient;
        private System.Windows.Forms.TextBox txtCodReprez;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPacienți;
        private System.Windows.Forms.Button btnPersoane;
        private System.Windows.Forms.Button btnRenuntaPacienti;
        private System.Windows.Forms.Button btnVizualizarePacienti;
        private System.Windows.Forms.Button btnModificăPacienti;
        private System.Windows.Forms.Button btnStergerePacienti;
        private System.Windows.Forms.Button btnAdaugaPacienti;
        private System.Windows.Forms.DataGridView dtGridPacienti;
        private System.Windows.Forms.ComboBox cboPacient;
        private System.Windows.Forms.ComboBox cboReprezentant;
    }
}