using CamadaDeConexao;
using ClassesBase;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;

namespace CamadaDeDados
{
    public class Usuario : ClasseBase
    {
        #region >>> Constantes de erro e aviso
        
        protected const string cte_CodigoNaoInformado = "Código do usuário não informado." + ctg_tagDeErro + "USe00001";
        protected const string cte_NomeNaoInformado = "Nome do usuário não informado." + ctg_tagDeErro + "USe00002";
        protected const string cte_EmailNaoInformado = "Email do usuário não informado." + ctg_tagDeErro + "US00003";
        protected const string cte_EmailInvalido = "Email inválido." + ctg_tagDeErro + "USe00004";
        protected const string cte_EmailDeRecuperacaoInvalido = "Email de recuperação inválido." + ctg_tagDeErro + "USe00005";
        protected const string cte_SenhaNaoInformada = "Senha do usuário não informada." + ctg_tagDeErro + "USe00006";

        protected const string cte_UsuarioIncluido = "Usuário incluído." + ctg_tagDeAviso + "USa00001";
        protected const string cte_UsuarioAlterado = "Usuário alterado." + ctg_tagDeAviso + "USa00002";
        protected const string cte_UsuarioExcluido = "Usuário excluído." + ctg_tagDeAviso + "USa00003";
        protected const string cte_LinhasAfetadas = " linha(s) afetada(s).";// + ctg_tagDeAviso + "USa0004";

        #endregion

        public Int32 Id { get; set; }
        public String Codigo { get; set; }
        public String Nome { get; set; }
        public String NomeSocial { get; set; }
        public String UsarNomeSocial { get; set; }
        public String Email { get; set; }
        public String EmailRecuperacao { get; set; }
        public String Senha { get; set; }
        public String EnviarEmailCadastramento { get; set; }
        public String SolicitarConfirmacaoPorEmail { get; set; }

    //Conexao cnx = new Conexao();
    SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        private Usuario()
        {
            //
        }

        public Usuario(Conexao conexaoDeBanco) : base(conexaoDeBanco) 
        {
            //-Passa o parâmetro para o construtor da classe base.
        }

        #region >>> Buscas e carregamento

        public override void Limpar()
        {
            this.Id = 0;
            this.Codigo = "";
            this.Nome = "";
            this.NomeSocial = "";
            this.UsarNomeSocial = "N";
            this.Email = "";
            this.EmailRecuperacao = "";
            this.Senha = "";
        }

        protected override int GerarProximoId()
        {
            cmd.CommandText = @"SELECT COALESCE(MAX(ID)+1,1) 
                                FROM TB_USUARIOS";

            try
            {
                cmd.Connection = _conexaoDeBanco.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return (int)dr.GetSqlInt32(0);
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                dr.Close();
                _conexaoDeBanco.Desconectar();
            }
        }

        public override int GerarProximoCodigo()
        {
            cmd.CommandText = @"SELECT COALESCE(MAX(CODIGO)+1,1) 
                                FROM TB_USUARIOS";

            try
            {
                cmd.Connection = _conexaoDeBanco.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return (int)dr.GetSqlInt32(0);
                }
                else
                {
                    return 0;
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                dr.Close();
                _conexaoDeBanco.Desconectar();
            }
        }

        public override void CarregarPorId(int id)
        {
            cmd.CommandText = @"SELECT ID, CODIGO, NOME, NOMESOCIAL, USARSOCIAL, EMAIL, EMAILRECUPERACAO, SENHA, ENVIAREMAILCADASTRAMENTO, SOLICITARCONFIRMACAOEMAIL 
                                FROM TB_USUARIOS 
                                WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = _conexaoDeBanco.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Id = (int)dr.GetSqlInt32(0);
                    this.Codigo = dr.GetString(1);
                    this.Nome = dr.GetString(2);
                    this.NomeSocial = dr.GetString(3);
                    this.UsarNomeSocial = dr.GetString(4);
                    this.Email = dr.GetString(5);
                    this.EmailRecuperacao = dr.GetString(6);
                    this.Senha = dr.GetString(7);
                    this.EnviarEmailCadastramento = dr.GetString(8);
                    this.SolicitarConfirmacaoPorEmail = dr.GetString(9);
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                dr.Close();
                _conexaoDeBanco.Desconectar();
            }
        }

        public override void CarregarPorCodigo(String codigo)
        {
            cmd.CommandText = @"SELECT ID, CODIGO, NOME, NOMESOCIAL, USARSOCIAL, EMAIL, EMAILRECUPERACAO, SENHA, ENVIAREMAILCADASTRAMENTO, SOLICITARCONFIRMACAOEMAIL 
                                FROM TB_USUARIOS 
                                WHERE CODIGO = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                cmd.Connection = _conexaoDeBanco.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Id = (int)dr.GetSqlInt32(0);
                    this.Codigo = dr.GetString(1);
                    this.Nome = dr.GetString(2);
                    this.NomeSocial = !dr.IsDBNull(3) ? dr.GetString(3) : ""; //-Operador ternário. Campo pode vir null.
                    this.UsarNomeSocial = dr.GetString(4);
                    this.Email = dr.GetString(5);
                    this.EmailRecuperacao = !dr.IsDBNull(6) ? dr.GetString(6) : ""; //-Operador ternário. Campo pode vir null.
                    this.Senha = dr.GetString(7);
                    this.EnviarEmailCadastramento = dr.GetString(8);
                    this.SolicitarConfirmacaoPorEmail = dr.GetString(9);
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                dr.Close();
                _conexaoDeBanco.Desconectar();
            }
        }

        public override bool VerificaExistenciaPorId(int id)
        {
            cmd.CommandText = @"SELECT COUNT(*) AS TOTAL 
                                FROM TB_USUARIOS 
                                WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = _conexaoDeBanco.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetSqlInt32(0) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                dr.Close();
                _conexaoDeBanco.Desconectar();
            }
        }

        public override bool VerificaExistenciaPorCodigo(String codigo)
        {
            cmd.CommandText = @"SELECT COUNT(*) AS TOTAL 
                                FROM TB_USUARIOS 
                                WHERE CODIGO = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);

            try
            {
                cmd.Connection = _conexaoDeBanco.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetSqlInt32(0) > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                dr.Close();
                _conexaoDeBanco.Desconectar();
            }
        }

        #endregion

        #region >>> CRUD

        public override void Incluir()
        {
            if(ValidarInclusao())
            {
                int proximoId = this.GerarProximoId(); //-Tem que ser executado primeiro, senão o método altera o "CommandText".

                cmd.CommandText = @"INSERT INTO TB_USUARIOS (ID, CODIGO, NOME, NOMESOCIAL, USARSOCIAL, EMAIL, EMAILRECUPERACAO, SENHA, ENVIAREMAILCADASTRAMENTO, SOLICITARCONFIRMACAOEMAIL) 
                                                     VALUES (@id, @codigo, @nome, @nomesocial, @usarsocial, @email, @emailrec, @senha,  @enviaremailcadastramento, @solicitarconfirmacaoporemail)";
                cmd.Parameters.AddWithValue("@id", proximoId); //this.Id
                cmd.Parameters.AddWithValue("@codigo", this.Codigo);
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@nomesocial", this.NomeSocial);
                cmd.Parameters.AddWithValue("@usarsocial", this.UsarNomeSocial);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@emailrec", this.EmailRecuperacao);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
                cmd.Parameters.AddWithValue("@enviaremailcadastramento", this.EnviarEmailCadastramento);
                cmd.Parameters.AddWithValue("@solicitarconfirmacaoporemail", this.SolicitarConfirmacaoPorEmail);

                try
                {
                    try
                    {
                        cmd.Connection = _conexaoDeBanco.Conectar();
                        var linhasAfetadas = cmd.ExecuteNonQuery();

                        AdicionarAvisoNaLista(cte_UsuarioIncluido);
                        AdicionarAvisoNaLista(linhasAfetadas + cte_LinhasAfetadas);
                    }
                    catch (Exception e)
                    {
                        AdicionarErroNaLista(ctg_tagDeErro+" Erro de execução de script: " +e.Message);
                    }
                }
                finally
                {
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                    _conexaoDeBanco.Desconectar();
                }
            }
        }

        public override void Atualizar()
        {
            if (ValidarAlteracao())
            {
                cmd.CommandText = @"UPDATE TB_USUARIOS 
                                    SET CODIGO = @codigo, NOME = @nome, 
                                        NOMESOCIAL = @nomesocial, 
                                        USARSOCIAL = @usarsocial, 
                                        EMAIL = @email, 
                                        EMAILRECUPERACAO = @emailrec, 
                                        SENHA = @senha, 
                                        ENVIAREMAILCADASTRAMENTO = @EnviarEmailCadastramento, 
                                        SOLICITARCONFIRMACAOEMAIL = @SolicitarConfirmacaoPorEmail
                                    WHERE ID = @id";
                cmd.Parameters.AddWithValue("@codigo", this.Codigo);
                cmd.Parameters.AddWithValue("@nome", this.Nome);
                cmd.Parameters.AddWithValue("@nomesocial", this.NomeSocial);
                cmd.Parameters.AddWithValue("@usarsocial", this.UsarNomeSocial);
                cmd.Parameters.AddWithValue("@email", this.Email);
                cmd.Parameters.AddWithValue("@emailrec", this.EmailRecuperacao);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
                cmd.Parameters.AddWithValue("@EnviarEmailCadastramento", this.EnviarEmailCadastramento);
                cmd.Parameters.AddWithValue("@SolicitarConfirmacaoPorEmail", this.SolicitarConfirmacaoPorEmail);
                cmd.Parameters.AddWithValue("@id", this.Id);

                try
                {
                    try
                    {
                        cmd.Connection = _conexaoDeBanco.Conectar();
                        var linhasAfetadas = cmd.ExecuteNonQuery();

                        AdicionarAvisoNaLista(cte_UsuarioAlterado);
                        AdicionarAvisoNaLista(linhasAfetadas + cte_LinhasAfetadas);
                    }
                    catch (Exception e)
                    {
                        AdicionarErroNaLista(ctg_tagDeErro + " Erro de execução de script: " + e.Message);
                    }                    
                }
                finally
                {
                    cmd.Parameters.Clear();
                    cmd.Dispose();
                    _conexaoDeBanco.Desconectar();
                }
            }
        }

        public override void Excluir()
        {
            cmd.CommandText = @"DELETE FROM TB_USUARIOS 
                                WHERE ID = @id";
            cmd.Parameters.AddWithValue("@id", this.Id);

            try
            {
                cmd.Connection = _conexaoDeBanco.Conectar();
                var linhasAfetadas = cmd.ExecuteNonQuery();
                Limpar();

                try
                {
                    AdicionarAvisoNaLista(cte_UsuarioExcluido);
                    AdicionarAvisoNaLista(linhasAfetadas + cte_LinhasAfetadas);
                }
                catch (Exception e)
                {
                    AdicionarErroNaLista(ctg_tagDeErro + " Erro de execução de script: " + e.Message);
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                _conexaoDeBanco.Desconectar();
            }
        }

        #endregion

        #region >>> validações

        protected override bool ExecutarVadidacoesGlobais() 
        {
            bool resultado = true;

            if(this.Codigo == "")
            {
                resultado = false;
                AdicionarErroNaLista(cte_CodigoNaoInformado);
            }

            if(this.Nome == "")
            {
                resultado = false;
                AdicionarErroNaLista(cte_NomeNaoInformado);
            }

            if(this.Email == "")
            {
                resultado = false;
                AdicionarErroNaLista(cte_EmailNaoInformado);
            }
            else
            if (!Funcoes.ValidaEmail(this.Email))
            {
                resultado = false;
                AdicionarErroNaLista(cte_EmailInvalido);
            }

            if (this.EmailRecuperacao != "")
            {
                if (!Funcoes.ValidaEmail(this.EmailRecuperacao))
                {
                    resultado = false;
                    AdicionarErroNaLista(cte_EmailDeRecuperacaoInvalido);
                }
            }

            if (this.Senha == "")
            {
                resultado = false;
                AdicionarErroNaLista(cte_SenhaNaoInformada);
            }

            return resultado;
        }

        #endregion

    }
}
