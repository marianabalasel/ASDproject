
namespace login
{
    partial class frmProgramări
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgramări));
            this.btnSalvare = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodProgramare = new System.Windows.Forms.TextBox();
            this.txtCodPacient = new System.Windows.Forms.TextBox();
            this.dtDataProgramare = new System.Windows.Forms.DateTimePicker();
            this.CodPersoana = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnVizualizare1 = new System.Windows.Forms.Button();
            this.btnModifică = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.dtGridVizProgramari = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizProgramari)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Data și ora programării:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cod pacient:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Status:";
            // 
            // txtCodProgramare
            // 
            this.txtCodProgramare.Location = new System.Drawing.Point(170, 22);
            this.txtCodProgramare.Name = "txtCodProgramare";
            this.txtCodProgramare.Size = new System.Drawing.Size(55, 27);
            this.txtCodProgramare.TabIndex = 2;
            this.txtCodProgramare.TextChanged += new System.EventHandler(this.txtCodProgramare_TextChanged);
            // 
            // txtCodPacient
            // 
            this.txtCodPacient.Location = new System.Drawing.Point(170, 60);
            this.txtCodPacient.Name = "txtCodPacient";
            this.txtCodPacient.Size = new System.Drawing.Size(55, 27);
            this.txtCodPacient.TabIndex = 3;
            // 
            // dtDataProgramare
            // 
            this.dtDataProgramare.Checked = false;
            this.dtDataProgramare.CustomFormat = "";
            this.dtDataProgramare.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDataProgramare.Location = new System.Drawing.Point(215, 142);
            this.dtDataProgramare.Name = "dtDataProgramare";
            this.dtDataProgramare.Size = new System.Drawing.Size(215, 27);
            this.dtDataProgramare.TabIndex = 4;
            this.dtDataProgramare.ValueChanged += new System.EventHandler(this.dtDataProgramare_ValueChanged);
            // 
            // CodPersoana
            // 
            this.CodPersoana.AutoSize = true;
            this.CodPersoana.Location = new System.Drawing.Point(6, 29);
            this.CodPersoana.Name = "CodPersoana";
            this.CodPersoana.Size = new System.Drawing.Size(135, 20);
            this.CodPersoana.TabIndex = 37;
            this.CodPersoana.Text = "Cod programare:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.cboStatus);
            this.groupBox1.Controls.Add(this.CodPersoana);
            this.groupBox1.Controls.Add(this.dtDataProgramare);
            this.groupBox1.Controls.Add(this.txtCodPacient);
            this.groupBox1.Controls.Add(this.txtCodProgramare);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 245);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informații programare";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 28);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.Text = "Căutare pacient";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Încheiată cu succes",
            "Programare neonorată"});
            this.cboStatus.Location = new System.Drawing.Point(170, 99);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(226, 28);
            this.cboStatus.TabIndex = 38;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnRenunta);
            this.groupBox2.Controls.Add(this.btnVizualizare1);
            this.groupBox2.Controls.Add(this.btnSalvare);
            this.groupBox2.Controls.Add(this.btnModifică);
            this.groupBox2.Controls.Add(this.btnStergere);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(535, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(454, 245);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operațiuni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ora:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(322, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 64);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.Bisque;
            this.btnRenunta.Location = new System.Drawing.Point(322, 29);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(126, 61);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunță";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnVizualizare1
            // 
            this.btnVizualizare1.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnVizualizare1.Location = new System.Drawing.Point(176, 24);
            this.btnVizualizare1.Name = "btnVizualizare1";
            this.btnVizualizare1.Size = new System.Drawing.Size(140, 63);
            this.btnVizualizare1.TabIndex = 27;
            this.btnVizualizare1.Text = "Vizualizează";
            this.btnVizualizare1.UseVisualStyleBackColor = false;
            this.btnVizualizare1.Click += new System.EventHandler(this.btnVizualizare1_Click);
            // 
            // btnModifică
            // 
            this.btnModifică.BackColor = System.Drawing.Color.Bisque;
            this.btnModifică.Location = new System.Drawing.Point(176, 96);
            this.btnModifică.Name = "btnModifică";
            this.btnModifică.Size = new System.Drawing.Size(140, 64);
            this.btnModifică.TabIndex = 26;
            this.btnModifică.Text = "Modifică";
            this.btnModifică.UseVisualStyleBackColor = false;
            // 
            // btnStergere
            // 
            this.btnStergere.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStergere.Location = new System.Drawing.Point(23, 95);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(138, 65);
            this.btnStergere.TabIndex = 25;
            this.btnStergere.Text = "Șterge";
            this.btnStergere.UseVisualStyleBackColor = false;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // dtGridVizProgramari
            // 
            this.dtGridVizProgramari.BackgroundColor = System.Drawing.Color.Ivory;
            this.dtGridVizProgramari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridVizProgramari.GridColor = System.Drawing.Color.Wheat;
            this.dtGridVizProgramari.Location = new System.Drawing.Point(7, 263);
            this.dtGridVizProgramari.Name = "dtGridVizProgramari";
            this.dtGridVizProgramari.RowHeadersWidth = 51;
            this.dtGridVizProgramari.RowTemplate.Height = 24;
            this.dtGridVizProgramari.Size = new System.Drawing.Size(977, 153);
            this.dtGridVizProgramari.TabIndex = 31;
            this.dtGridVizProgramari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtGridVizProgramari_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmProgramări
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.dtGridVizProgramari);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmProgramări";
            this.Text = "FrmProgramări";
            this.Load += new System.EventHandler(this.frmCalendar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridVizProgramari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodProgramare;
        private System.Windows.Forms.TextBox txtCodPacient;
        private System.Windows.Forms.DateTimePicker dtDataProgramare;
        private System.Windows.Forms.Label CodPersoana;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnVizualizare1;
        private System.Windows.Forms.Button btnModifică;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.DataGridView dtGridVizProgramari;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}