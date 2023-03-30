
namespace login
{
    partial class FrmProgramareServicii
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
            this.txtDetalii = new System.Windows.Forms.TextBox();
            this.txtCodStomatolog = new System.Windows.Forms.TextBox();
            this.CodPersoana = new System.Windows.Forms.Label();
            this.txtCodServiciuStomatologic = new System.Windows.Forms.TextBox();
            this.txtCodProgramare1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.txtDenumireServiciu = new System.Windows.Forms.TextBox();
            this.txtNumeStomatolog = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtNumeStomatolog);
            this.groupBox1.Controls.Add(this.txtDenumireServiciu);
            this.groupBox1.Controls.Add(this.btnRenunta);
            this.groupBox1.Controls.Add(this.txtDetalii);
            this.groupBox1.Controls.Add(this.txtCodStomatolog);
            this.groupBox1.Controls.Add(this.CodPersoana);
            this.groupBox1.Controls.Add(this.txtCodServiciuStomatologic);
            this.groupBox1.Controls.Add(this.txtCodProgramare1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 397);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informații programare";
            // 
            // txtDetalii
            // 
            this.txtDetalii.Location = new System.Drawing.Point(231, 167);
            this.txtDetalii.Multiline = true;
            this.txtDetalii.Name = "txtDetalii";
            this.txtDetalii.Size = new System.Drawing.Size(256, 134);
            this.txtDetalii.TabIndex = 46;
            // 
            // txtCodStomatolog
            // 
            this.txtCodStomatolog.Location = new System.Drawing.Point(231, 94);
            this.txtCodStomatolog.Name = "txtCodStomatolog";
            this.txtCodStomatolog.Size = new System.Drawing.Size(55, 27);
            this.txtCodStomatolog.TabIndex = 45;
            // 
            // CodPersoana
            // 
            this.CodPersoana.AutoSize = true;
            this.CodPersoana.Location = new System.Drawing.Point(6, 25);
            this.CodPersoana.Name = "CodPersoana";
            this.CodPersoana.Size = new System.Drawing.Size(135, 20);
            this.CodPersoana.TabIndex = 37;
            this.CodPersoana.Text = "Cod programare:";
            // 
            // txtCodServiciuStomatologic
            // 
            this.txtCodServiciuStomatologic.Location = new System.Drawing.Point(231, 54);
            this.txtCodServiciuStomatologic.Name = "txtCodServiciuStomatologic";
            this.txtCodServiciuStomatologic.Size = new System.Drawing.Size(55, 27);
            this.txtCodServiciuStomatologic.TabIndex = 3;
            // 
            // txtCodProgramare1
            // 
            this.txtCodProgramare1.Location = new System.Drawing.Point(231, 18);
            this.txtCodProgramare1.Name = "txtCodProgramare1";
            this.txtCodProgramare1.Size = new System.Drawing.Size(55, 27);
            this.txtCodProgramare1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cod stomatolog:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cod serviciu stomatologic:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Detalii:";
            // 
            // btnRenunta
            // 
            this.btnRenunta.BackColor = System.Drawing.Color.Bisque;
            this.btnRenunta.Location = new System.Drawing.Point(475, 316);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(161, 61);
            this.btnRenunta.TabIndex = 31;
            this.btnRenunta.Text = "Renunță";
            this.btnRenunta.UseVisualStyleBackColor = false;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // txtDenumireServiciu
            // 
            this.txtDenumireServiciu.Location = new System.Drawing.Point(325, 45);
            this.txtDenumireServiciu.Multiline = true;
            this.txtDenumireServiciu.Name = "txtDenumireServiciu";
            this.txtDenumireServiciu.Size = new System.Drawing.Size(288, 46);
            this.txtDenumireServiciu.TabIndex = 50;
            // 
            // txtNumeStomatolog
            // 
            this.txtNumeStomatolog.Location = new System.Drawing.Point(325, 97);
            this.txtNumeStomatolog.Name = "txtNumeStomatolog";
            this.txtNumeStomatolog.Size = new System.Drawing.Size(288, 27);
            this.txtNumeStomatolog.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(231, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Data și ora programării:";
            // 
            // FrmProgramareServicii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(701, 405);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmProgramareServicii";
            this.Text = "FrmProgramăriDetalii";
            this.Load += new System.EventHandler(this.FrmProgramareServicii_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label CodPersoana;
        private System.Windows.Forms.TextBox txtCodServiciuStomatologic;
        private System.Windows.Forms.TextBox txtCodProgramare1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.TextBox txtDetalii;
        private System.Windows.Forms.TextBox txtCodStomatolog;
        private System.Windows.Forms.TextBox txtNumeStomatolog;
        private System.Windows.Forms.TextBox txtDenumireServiciu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}