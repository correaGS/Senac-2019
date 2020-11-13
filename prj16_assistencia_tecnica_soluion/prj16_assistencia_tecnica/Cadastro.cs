using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace prj16_assistencia_tecnica
{
    class Cadastro
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string caminhoBanco = "SERVER=127.0.0.1;PORT=3306; DATABASE=dbassistenciatecnica;UID=root;PASSWORD=;";

        public void CadastrarCliente(ModeloCliente modeloCliente)
        {
            try
            {
                conexao = new MySqlConnection(caminhoBanco);

                conexao.Open();

                string inseriCliente = "INSERT INTO tbcliente(nomeCliente, contato, email)" +
                    "VALUES('" + modeloCliente.Nome + "', '" + modeloCliente.Contato + "', " +
                    "'" + modeloCliente.Email + "')";

                comando = new MySqlCommand(inseriCliente, conexao);

                comando.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Funcionário" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void CadastrarEquipamento(ModeloEquipamento modeloEquipamento)
        {
            try
            {
                conexao = new MySqlConnection(caminhoBanco);

                conexao.Open();

                string inseriEquipamento = "INSERT INTO tbequipamento(aparelho, fk_modelo)" +
                    "VALUES('" + modeloEquipamento.Aparelho + "', '" + modeloEquipamento.Modelo +"')";

                comando = new MySqlCommand(inseriEquipamento, conexao);

                comando.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Equipamento" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        public void CadastrarServico(ModeloServico modeloServico)
        {
            try
            {
                conexao = new MySqlConnection(caminhoBanco);

                conexao.Open();

                string inseriServiço = "INSERT INTO tbserviÇo(fk_cliente, " +
                    "fk_equipamento, decreverProblema, valorServico)" +
                    "VALUES('" + modeloServico.Cliente + "', '" + modeloServico.Equipamento + "', " +
                    "'" + modeloServico.Problema + "', '" + modeloServico.Valor + "')";

                comando = new MySqlCommand(inseriServiço, conexao);

                comando.ExecuteNonQuery();

                conexao.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar Serviço" + ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
