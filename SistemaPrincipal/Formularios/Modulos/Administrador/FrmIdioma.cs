using CamadaDeConexao;
using CamadaDeDados;
using ClassesBase;
using RegrasDeNegocio;
using SistemaPrincipal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace SistemaPrincipal.Formularios.Modulos.Administrador
{
    public partial class FrmIdioma : FormulariosBase.FrmBase
    {
        private string _idiomaInicial;
        private bool _executaEvento = true;

        private IEventoAlteracaoIdioma _formPrincipal;

        public FrmIdioma(IEventoAlteracaoIdioma formPrincipal)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Sessao.ObterInstancia.Idioma);

            _idiomaInicial = Sessao.ObterInstancia.Idioma;

            _formPrincipal = formPrincipal;

            InitializeComponent();

            _executaEvento = false;
            
            switch (_idiomaInicial)
            {
                case "pt-BR":
                    comboBox1.SelectedIndex = 0;
                    break;
                case "en-150":
                    comboBox1.SelectedIndex = 1;
                    break;
                case "es":
                    comboBox1.SelectedIndex = 2;
                    break;
                default:
                    comboBox1.SelectedIndex = 0;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;

            if (_executaEvento)
            {
                string _idiomaEscolhido = "pt-BR";

                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        _idiomaEscolhido = "pt-BR";
                        break;
                    case 1:
                        _idiomaEscolhido = "en-150";
                        break;
                    case 2:
                        _idiomaEscolhido = "es";
                        break;
                }

                Sessao.ObterInstancia.Idioma = _idiomaEscolhido;
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(_idiomaEscolhido);

                SalvaIdiomaNoIni(_idiomaEscolhido);

                base.Controls.Clear();
                this.Controls.Clear();

                base.InitializeComponent();
                InitializeComponent();

                //base.StartPosition = FormStartPosition.CenterParent;
                //this.StartPosition = FormStartPosition.CenterParent;

                base.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Normal;

                base.WindowState = FormWindowState.Maximized;
                this.WindowState = FormWindowState.Maximized;

                _executaEvento = false;
                comboBox1.SelectedIndex = index;
                //ReposicionarControles();
            }

            _executaEvento = true;
        }

        private void SalvaIdiomaNoIni(string idioma)
        {
            string nomeIni = "Config.ini";
            string path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());

            IniFile arquivoIni = new IniFile(path + "\\" + nomeIni);

            arquivoIni.WriteValue("CONFIGURACAO", "IDIOMA", idioma);
        }

        private void FrmIdioma_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if(_idiomaInicial != Sessao.ObterInstancia.Idioma)
            {
                _formPrincipal.AlterouIdioma(true);
            }
            else
            {
                //_formPrincipal.AlterouIdioma(false);
            }
        }
    }
}
