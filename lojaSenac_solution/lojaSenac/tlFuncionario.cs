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
    public partial class tlFuncionario : Form
    {
        public tlFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadFuncionario_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Conexao.conector());
            SqlCommand cmd = new SqlCommand("pFuncionarioInserir", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeFuncionario", txtNomeFunc.Text);
                cmd.Parameters.AddWithValue("@foneFuncionario", txtFoneFunc.Text);
                cmd.Parameters.AddWithValue("@emailfuncionario", txtEmailFunc.Text);
                cmd.Parameters.AddWithValue("@senhaFuncionario", txtSenhaFunc.Text);

                SqlParameter nv = cmd.Parameters.Add("@idfuncionario",SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Funcionário Cadastrado com Sucesso!",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if(resposta == DialogResult.Yes)
                {
                    txtNomeFunc.Clear();
                    txtFoneFunc.Clear();
                    txtEmailFunc.Clear();
                    txtSenhaFunc.Clear();
                }
                else
                {
                    this.Close();
                }

                cn.Close();
            }
            catch
            {
                 MessageBox.Show("Funcionário Não Cadastrado ","Atenção");
            }
        }
    }
}
