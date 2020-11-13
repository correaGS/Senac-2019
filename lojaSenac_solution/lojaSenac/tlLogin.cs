using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lojaSenac
{
    public partial class tlLogin : Form
    {
        public tlLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string email = txtEmail.Text;
            //string senha = txtSenha.Text;

            //if (email == "kluybibi@gmail.com" && senha == "1209")
            //{
            //    tlMenu menu = new tlMenu();
            //    this.Visible = false;
            //    menu.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("Senha ou Email incorretas");
            //}

            dados.Usuario = txtEmail.Text;

            var cn = new SqlConnection(Conexao.conector());
            var cmd = new SqlCommand("plogin", cn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

            cn.Open();

            int i = (int)cmd.ExecuteScalar();

            if (i > 0)
            {
                tlMenu menu = new tlMenu();
                this.Visible = false;
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Senha ou Email incorretas");
            }

            cn.Close();
        }
    }
}
