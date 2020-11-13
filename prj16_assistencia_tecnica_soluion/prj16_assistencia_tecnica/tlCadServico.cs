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
    public partial class tlCadServico : Form
    {
        public tlCadServico()
        {
            InitializeComponent();
            ListaEquipamento();
            ListaCliente();
        }

        MySqlConnection conexao;
        MySqlCommand comando;

        string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbassistenciatecnica;UID=root;PASSWORD=;";

        public void ListaEquipamento()
        {
            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbequipamento";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            DataTable equipamentoSelecionados = new DataTable();

            equipamentoSelecionados.Load(comando.ExecuteReader());

            cbEquipamento.DisplayMember = "aparelho";

            cbEquipamento.ValueMember = "idEquipamento";

            cbEquipamento.DataSource = equipamentoSelecionados;

            conexao.Close();

        }

        public void ListaCliente()
        {
            conexao = new MySqlConnection(caminhoBanco);

            conexao.Open();

            string selecionar = "SELECT * FROM tbcliente";

            comando = new MySqlCommand(selecionar, conexao);

            comando.ExecuteNonQuery();

            DataTable equipamentoSelecionados = new DataTable();

            equipamentoSelecionados.Load(comando.ExecuteReader());

            cbCliente.DisplayMember = "nomeCliente";

            cbCliente.ValueMember = "idCliente";

            cbCliente.DataSource = equipamentoSelecionados;

            conexao.Close();

        }

        private void btnCadServico_Click(object sender, EventArgs e)
        {
            ModeloServico modeloServico = new ModeloServico();

            Cadastro cadastro = new Cadastro();
            modeloServico.Cliente = Convert.ToInt32(cbCliente.SelectedValue);
            modeloServico.Equipamento = Convert.ToInt32(cbEquipamento.SelectedValue);
            modeloServico.Valor = Convert.ToInt32(txtValor.Text);
            modeloServico.Problema = txtProblema.Text;


            cadastro.CadastrarServico(modeloServico);

            MessageBox.Show("Serviço cadastrado com sucesso!", "Cadastro Efetuado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
