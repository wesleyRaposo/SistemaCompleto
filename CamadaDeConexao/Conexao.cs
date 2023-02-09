using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace CamadaDeConexao
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        private bool _conexaoInstanciada = false;

        public Conexao()
        {
            try
            {
                //-Forma antiga de conexão. Os dados são fixos na aplicação.
                //con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\EstudoC#\Exercícios\SistemaCompleto\CamadaDeConexao\ProjetoDataBase.mdf;Integrated Security=True";

                //-Nova forma de conexão.
                // Essa forma é flexível, pois o arquivo "App.config" é editável.
                // Esse arquivo tem que ficar no projeto que inicializa a aplicação (no caso, o "SistemaPrincipal").
                // Antes estava no projeto da camada de conexão e dava erro de objeto nulo ou não instanciado.
                con.ConnectionString = ConfigurationManager.ConnectionStrings["DBTeste"].ConnectionString;
            }
            catch (Exception e)
            {
                _conexaoInstanciada = false;
                MessageBox.Show("String de conexão \"DBTeste\" não parametrizada ou inacessível: " + e.Message);
            }
        }

        public bool ConexaoAberta()
        {
            return _conexaoInstanciada;
        }

        public SqlConnection Conectar()
        {
            if (con.State == ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    _conexaoInstanciada = (con.State == ConnectionState.Open);
                    return con;
                }
                catch (Exception e)
                {
                    _conexaoInstanciada = false;
                    MessageBox.Show("Erro ao tentar conectar a aplicação: "+e.Message);
                }                
            }
            return con;
        }

        public void Desconectar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                _conexaoInstanciada = false;
            }
        }

    }
}
