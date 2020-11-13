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
    public partial class tlCadEquipamento : Form
    {
        public tlCadEquipamento()
        {
            InitializeComponent();
            ListaModelo();
        }

        MySqlConnection conexao;
        MySqlCommand comando;

        string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbassistenciatecnica;UID=root;PASSWORD=;";

        public void ListaModelo()
        {
            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbmodelo";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            DataTable modeloSelecionados = new DataTable();

            modeloSelecionados.Load(comando.ExecuteReader());

            cbModelo.DisplayMember = "modelo";

            cbModelo.ValueMember = "idModelo";

            cbModelo.DataSource = modeloSelecionados;

            conexao.Close();

        }

        private void btnCadEquipamento_Click(object sender, EventArgs e)
        {
            ModeloEquipamento modeloEquipamento = new ModeloEquipamento();

            Cadastro cadastro = new Cadastro();

            if (string.IsNullOrEmpty(txtAparelho.Text) || string.IsNullOrWhiteSpace(txtAparelho.Text))
            {
                MessageBox.Show("Por favor informar o nome do Cliente",
                    "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAparelho.Focus();
            }
            else
            {
                modeloEquipamento.Aparelho = txtAparelho.Text;
                modeloEquipamento.Modelo = Convert.ToInt32(cbModelo.SelectedValue);


                cadastro.CadastrarEquipamento(modeloEquipamento);

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro Efetuado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAparelho.Clear();
            }
        }
    }
}
