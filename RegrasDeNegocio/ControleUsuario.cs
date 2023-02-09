using CamadaDeConexao;
using CamadaDeDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegrasDeNegocio
{
    public class ControleUsuario
    {
        private Conexao cnx = new Conexao();

        private Usuario usuario;

        List<string> listaDeMensagensTemporaria = new List<string>();

        public ControleUsuario()
        {
            usuario = new Usuario(cnx);
        }
        
        public String MontarListaDeMensagensComoString()
        {
            String stringDeRetorno = "";

            if(listaDeMensagensTemporaria.Count > 0)
            {
                foreach(String erro in listaDeMensagensTemporaria)
                {
                    stringDeRetorno += erro + "\r\n";
                }
            }

            return stringDeRetorno;
        }

        public bool acessar(String login, String senha)
        {
            return true;
        }

        public bool UsuarioExistePorId(int id)
        {
            return usuario.VerificaExistenciaPorId(id);
        }
        public bool UsuarioExistePorCodigo(string codigo)
        {
            return usuario.VerificaExistenciaPorCodigo(codigo);
        }

        public Usuario CarregarUsuarioPorId(int id)
        {
            usuario.CarregarPorId(id);
            return usuario;
        }

        public Usuario CarregarUsuarioPorCodigo(string codigo)
        {
            usuario.CarregarPorCodigo(codigo);
            return usuario;
        }

        public bool IncluirUsuario(String codigo, String nome, String nomeSocial, String usarSocial, String email, String emailRecuperacao, String senha, String senhaConfirmacao,
            String EnviarEmailCadastramento, String SolicitarConfirmacaoPorEmail)
        {
            Usuario us = new Usuario(cnx);

            us.Codigo = codigo;
            us.Nome = nome;
            us.NomeSocial = nomeSocial;
            us.UsarNomeSocial = usarSocial;
            us.Email = email;
            us.EmailRecuperacao = emailRecuperacao;
            us.Senha = senha;
            us.EnviarEmailCadastramento = EnviarEmailCadastramento;
            us.SolicitarConfirmacaoPorEmail = SolicitarConfirmacaoPorEmail;

            us.Incluir();

            if(us.TemErrosOuAvisos())
            {
                listaDeMensagensTemporaria.Clear();
                us.ClonarListaMensagens(listaDeMensagensTemporaria);
            }

            if(us.TemErros())
                return false;
            else
                return true;
        }

        public bool AtualizarUsuario(String Id, String codigo, String nome, String nomeSocial, String usarSocial, String email, String emailRecuperacao, String senha, String senhaConfirmacao,
            String EnviarEmailCadastramento, String SolicitarConfirmacaoPorEmail)
        {
            Usuario us = new Usuario(cnx);

            us.Id = Convert.ToInt32(Id);
            us.Codigo = codigo;
            us.Nome = nome;
            us.NomeSocial = nomeSocial;
            us.UsarNomeSocial = usarSocial;
            us.Email = email;
            us.EmailRecuperacao = emailRecuperacao;
            us.Senha = senha;
            us.EnviarEmailCadastramento = EnviarEmailCadastramento;
            us.SolicitarConfirmacaoPorEmail = SolicitarConfirmacaoPorEmail;

            us.Atualizar();

            if (us.TemErrosOuAvisos())
            {
                listaDeMensagensTemporaria.Clear();
                us.ClonarListaMensagens(listaDeMensagensTemporaria);
            }

            if (us.TemErros())
                return false;
            else
                return true;
        }

        public bool ExcluirUsuario(String Id)
        {
            Usuario us = new Usuario(cnx);

            us.Id = Convert.ToInt32(Id);

            us.Excluir();

            if (us.TemErrosOuAvisos())
            {
                listaDeMensagensTemporaria.Clear();
                us.ClonarListaMensagens(listaDeMensagensTemporaria);
            }

            if (us.TemErros())
                return false;
            else
                return true;
        }
        
        public int GerarProximoCodigoDoCliente()
        {
            Usuario us = new Usuario(cnx);
            return us.GerarProximoCodigo();
        }

    }
}
