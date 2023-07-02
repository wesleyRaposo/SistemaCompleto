using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPrincipal
{
    public sealed class Sessao
    {
        private static volatile Sessao _instancia;
        private static object sync = new Object();

        private Sessao() { }

        public static Sessao ObterInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    lock (sync)
                    {
                        if (_instancia == null)
                        {
                            _instancia = new Sessao();
                        }
                    }
                }
                return _instancia;
            }

        }

        public string Idioma { get; set; } = "pt-BR"; //"es"; //"en-150"; //"pt-BR";
    }
}
