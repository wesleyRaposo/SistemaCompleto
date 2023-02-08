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
               con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\EstudoC#\Exercícios\SistemaCompleto\CamadaDeConexao\ProjetoDataBase.mdf;Integrated Security=True";
               //con.ConnectionString = ConfigurationManager.ConnectionStrings["DBTeste"].ConnectionString; //-A string de conexão foi movida para o App.config.
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
