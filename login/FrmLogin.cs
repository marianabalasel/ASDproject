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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
       
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShow.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;

            } 
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             AdentisApp fm = new AdentisApp();
             fm.ShowDialog();*/
            NpgsqlConnection conexiune;
            string sirConectare;
            sirConectare = "Host=localhost;Username=postgres;Password=mariana12;Database=Clinica_stomatologica";
            conexiune = new NpgsqlConnection();
            conexiune.ConnectionString = sirConectare;
            conexiune.Open();
                NpgsqlDataAdapter adp = new NpgsqlDataAdapter("Select Count(*) From Users  where numeuser='" + txtUsername.Text + "'and parola='" + txtPassword.Text + "'", conexiune);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                if (dt.Rows[0][0].ToString()=="1")
                {
                    new AdentisApp().Show();
                    this.Hide();
                   
                }
                else
                {
                    MessageBox.Show("Combinația de nume utilizator și parolă nu corespunde niciunui cont din aplicație!");
                }
                conexiune.Close();
                
           

           
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
      
    }
}
