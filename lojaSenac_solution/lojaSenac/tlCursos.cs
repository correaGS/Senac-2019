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
    public partial class tlCursos : Form
    {
        public tlCursos()
        {
            InitializeComponent();
        }

        private void btnCadCurso_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Conexao.conector());
            SqlCommand cmd = new SqlCommand("pCursoInserir", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@nomeCurso", txtNomeCurso.Text);
                cmd.Parameters.AddWithValue("@areaCurso", txtAreaCurso.Text);
                cmd.Parameters.AddWithValue("@duracaoCurso", txtDuracaoCurso.Text);

                SqlParameter nv = cmd.Parameters.Add("@idCurso", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Curso Cadastrado com Sucesso!",
                    "Novo Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    txtNomeCurso.Clear();
                    txtAreaCurso.Clear();
                    txtDuracaoCurso.Clear();
                }
                else
                {
                    this.Close();
                }

                cn.Close();
            }
            catch
            {
                MessageBox.Show("Curso Não Cadastrado ", "Atenção");
            }
        }
    }
}
