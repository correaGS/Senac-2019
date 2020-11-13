using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj16_assistencia_tecnica
{
    public partial class tlCadCliente : Form
    {
        public tlCadCliente()
        {
            InitializeComponent();
        }
        private void btnCadCliente_Click(object sender, EventArgs e)
        {
            ModeloCliente modeloCliente = new ModeloCliente();

            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor informar o nome do Cliente",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
            }
            else
            {
                modeloCliente.Nome = txtNome.Text;
                modeloCliente.Contato = txtContato.Text;
                modeloCliente.Email = txtEmail.Text;
                

                cadastro.CadastrarCliente(modeloCliente);

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro Efetuado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtEmail.Clear();
                txtContato.Clear();
            }

        }
    }
}
