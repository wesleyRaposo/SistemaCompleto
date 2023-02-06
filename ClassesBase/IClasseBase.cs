using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBase
{
    interface IClasseBase
    {
        public void LimparLista();
        public void AdicionarErroNaLista(string mensageDeErro);
        public void AdicionarAvisoNaLista(string aviso);
        public bool TemErros();
        public bool TemAvisos();
        public bool TemErrosOuAvisos();
        public void ClonarListaMensagens(List<string> listaDeErrosDestino);
        public abstract void Limpar();
        public abstract int GerarProximoCodigo();
        public abstract void CarregarPorId(int id);
        public abstract void CarregarPorCodigo(String codigo);
        public abstract bool VerificaExistenciaPorId(int id);
        public abstract bool VerificaExistenciaPorCodigo(String codigo);
        public abstract void Incluir();
        public abstract void Atualizar();
        public abstract void Excluir();
        //protected abstract bool ExecutarVadidacoesGlobais();
        //public bool ValidarInclusao();
        //public bool ValidarAlteracao();
    }
}
