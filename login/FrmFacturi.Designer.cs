
namespace login
{
    partial class FrmFacturi
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
            this.txtCodFactura = new System.Windows.Forms.TextBox();
            this.CodPersoana = new System.Windows.Forms.Label();
            this.dtDataFacturii = new System.Windows.Forms.DateTimePicker();
            this.txtCodPacient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValoareTotala = new System.Windows.Forms.TextBox();
            this.txtNrFactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnVizualizare1 = new System.Windows.Forms.Button();
            this.btnModifică = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.dtGridVizFacturi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizFacturi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPacient);
            this.groupBox1.Controls.Add(this.txtCodFactura);
            this.groupBox1.Controls.Add(this.CodPersoana);
            this.groupBox1.Controls.Add(this.dtDataFacturii);
            this.groupBox1.Controls.Add(this.txtCodPacient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValoareTotala);
            this.groupBox1.Controls.Add(this.txtNrFactura);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 142);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informații facturi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboPacient
            // 
            this.cboPacient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPacient.ForeColor = System.Drawing.Color.DimGray;
            this.cboPacient.FormattingEnabled = true;
            this.cboPacient.Location = new System.Drawing.Point(251, 60);
            this.cboPacient.Name = "cboPacient";
            this.cboPacient.Size = new System.Drawing.Size(171, 28);
            this.cboPacient.TabIndex = 39;
            this.cboPacient.Text = "Căutare pacient";
            this.cboPacient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCodFactura
            // 
            this.txtCodFactura.Location = new System.Drawing.Point(166, 27);
            this.txtCodFactura.Name = "txtCodFactura";
            this.txtCodFactura.Size = new System.Drawing.Size(63, 27);
            this.txtCodFactura.TabIndex = 38;
            // 
            // CodPersoana
            // 
            this.CodPersoana.AutoSize = true;
            this.CodPersoana.Location = new System.Drawing.Point(28, 31);
            this.CodPersoana.Name = "CodPersoana";
            this.CodPersoana.Size = new System.Drawing.Size(101, 20);
            this.CodPersoana.TabIndex = 37;
            this.CodPersoana.Text = "Cod factură:";
            // 
            // dtDataFacturii
            // 
            this.dtDataFacturii.AllowDrop = true;
            this.dtDataFacturii.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataFacturii.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dtDataFacturii.Location = new System.Drawing.Point(166, 97);
            this.dtDataFacturii.Name = "dtDataFacturii";
            this.dtDataFacturii.RightToLeftLayout = true;
            this.dtDataFacturii.Size = new System.Drawing.Size(135, 27);
            this.dtDataFacturii.TabIndex = 28;
            this.dtDataFacturii.Value = new System.DateTime(2021, 4, 28, 0, 0, 0, 0);
            // 
            // txtCodPacient
            // 
            this.txtCodPacient.Location = new System.Drawing.Point(166, 61);
            this.txtCodPacient.Name = "txtCodPacient";
            this.txtCodPacient.Size = new System.Drawing.Size(63, 27);
            this.txtCodPacient.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cod pacient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data facturii:";
            // 
            // txtValoareTotala
            // 
            this.txtValoareTotala.Location = new System.Drawing.Point(584, 65);
            this.txtValoareTotala.Name = "txtValoareTotala";
            this.txtValoareTotala.Size = new System.Drawing.Size(77, 27);
            this.txtValoareTotala.TabIndex = 11;
            // 
            // txtNrFactura
            // 
            this.txtNrFactura.Location = new System.Drawing.Point(584, 20);
            this.txtNrFactura.Name = "txtNrFactura";
            this.txtNrFactura.Size = new System.Drawing.Size(77, 27);
            this.txtNrFactura.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valoare totală:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Număr factură:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRenunta);
            this.groupBox2.Controls.Add(this.btnVizualizare1);
            this.groupBox2.Controls.Add(this.btnModifică);
            this.groupBox2.Controls.Add(this.btnStergere);
            this.groupBox2.Controls.Add(this.btnAdauga);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 125);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operațiuni";
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.Bisque;
            this.btnRenunta.Location = new System.Drawing.Point(594, 26);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(121, 55);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunță";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnVizualizare1
            // 
            this.btnVizualizare1.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVizualizare1.Location = new System.Drawing.Point(451, 26);
            this.btnVizualizare1.Name = "btnVizualizare1";
            this.btnVizualizare1.Size = new System.Drawing.Size(121, 55);
            this.btnVizualizare1.TabIndex = 27;
            this.btnVizualizare1.Text = "Vizualizare";
            this.btnVizualizare1.UseVisualStyleBackColor = false;
            this.btnVizualizare1.Click += new System.EventHandler(this.btnVizualizare1_Click);
            // 
            // btnModifică
            // 
            this.btnModifică.BackColor = System.Drawing.Color.Bisque;
            this.btnModifică.Location = new System.Drawing.Point(311, 26);
            this.btnModifică.Name = "btnModifică";
            this.btnModifică.Size = new System.Drawing.Size(121, 55);
            this.btnModifică.TabIndex = 26;
            this.btnModifică.Text = "Modifică";
            this.btnModifică.UseVisualStyleBackColor = false;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStergere.Location = new System.Drawing.Point(166, 26);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(121, 55);
            this.btnStergere.TabIndex = 25;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = false;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Bisque;
            this.btnAdauga.ForeColor = System.Drawing.Color.Black;
            this.btnAdauga.Location = new System.Drawing.Point(32, 26);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(121, 55);
            this.btnAdauga.TabIndex = 25;
            this.btnAdauga.Text = "Adăugare";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // dtGridVizFacturi
            // 
            this.dtGridVizFacturi.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridVizFacturi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVizFacturi.GridColor = System.Drawing.Color.Wheat;
            this.dtGridVizFacturi.Location = new System.Drawing.Point(12, 291);
            this.dtGridVizFacturi.Name = "dtGridVizFacturi";
            this.dtGridVizFacturi.RowHeadersWidth = 51;
            this.dtGridVizFacturi.RowTemplate.Height = 24;
            this.dtGridVizFacturi.Size = new System.Drawing.Size(762, 210);
            this.dtGridVizFacturi.TabIndex = 30;
            this.dtGridVizFacturi.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtGridVizFacturi_MouseDoubleClick);
            // 
            // FrmFacturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(781, 506);
            this.Controls.Add(this.dtGridVizFacturi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFacturi";
            this.Text = "FrmFacturi";
            this.Load += new System.EventHandler(this.FrmFacturi_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmFacturi_MouseDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizFacturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodFactura;
        private System.Windows.Forms.Label CodPersoana;
        private System.Windows.Forms.DateTimePicker dtDataFacturii;
        private System.Windows.Forms.TextBox txtCodPacient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValoareTotala;
        private System.Windows.Forms.TextBox txtNrFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnVizualizare1;
        private System.Windows.Forms.Button btnModifică;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.DataGridView dtGridVizFacturi;
        private System.Windows.Forms.ComboBox cboPacient;
    }
}