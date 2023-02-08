using CamadaDeConexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBase
{
    public abstract class ClasseBase: IClasseBase
    {
        #region constantes de erro

        protected const string ctg_tagDeErro = "<!Erro>";
        protected const string ctg_tagDeAviso = "<!Aviso>";

        #endregion

        protected Conexao _conexaoDeBanco;

        List<string> listaDeMensagens = new List<string>();
        int contaErros = 0;
        int contaAvisos = 0;

        protected ClasseBase()
        {
            //-Não pode herdar este construtor
        }

        protected ClasseBase(Conexao conexaoDeBanco)
        {
            _conexaoDeBanco = conexaoDeBanco;
        }

        public void LimparLista()
        {
            listaDeMensagens.Clear();
            contaErros = 0;
            contaAvisos = 0;
        }

        public void AdicionarErroNaLista(string mensageDeErro)
        {
            if (mensageDeErro.Contains(ctg_tagDeErro))
            {
                listaDeMensagens.Add(mensageDeErro);
                contaErros += 1;
            }
        }

        public void AdicionarAvisoNaLista(string aviso)
        {
            listaDeMensagens.Add(aviso);
            contaAvisos += 1;
        }

        public bool TemErros()
        {
            return (contaErros > 0);
        }

        public bool TemAvisos()
        {
            return (contaAvisos > 0);
        }

        public bool TemErrosOuAvisos()
        {
            return (contaErros > 0) || (contaAvisos > 0);
        }

        public void ClonarListaMensagens(List<string> listaDeErrosDestino)
        {
            if (TemErrosOuAvisos())
            {
                foreach(String mensagem in listaDeMensagens)
                {
                    listaDeErrosDestino.Add(mensagem);
                }
            }
        }

        public abstract void Limpar();
        protected abstract int GerarProximoId();
        public abstract int GerarProximoCodigo();
        public abstract void CarregarPorId(int id);
        public abstract void CarregarPorCodigo(String codigo);
        public abstract bool VerificaExistenciaPorId(int id);
        public abstract bool VerificaExistenciaPorCodigo(String codigo);
        public abstract void Incluir();
        public abstract void Atualizar();
        public abstract void Excluir();
        protected abstract bool ExecutarVadidacoesGlobais();

        protected bool ValidarInclusao()
        {
            LimparLista();

            bool resultado;
            resultado = ExecutarVadidacoesGlobais();

            //-Validações exclusivas da inclusão aqui.
            // Sobrescrever na classe herdada, se precisar de validações exclusivas.

            return resultado;
        }

        protected bool ValidarAlteracao()
        {
            LimparLista();

            bool resultado;
            resultado = ExecutarVadidacoesGlobais();

            //-Validações exclusivas da alteração aqui.
            // Sobrescrever na classe herdada, se precisar de validações exclusivas.

            return resultado;
        }

    }
}
