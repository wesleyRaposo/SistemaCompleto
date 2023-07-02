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
using SistemaPrincipal.Classes;
using SistemaPrincipal.Formularios.Cadastros;
using SistemaPrincipal.Formularios.Modulos.Administrador;

namespace SistemaPrincipal.Formularios
{
    public partial class FrmPrincipal : Form, IEventoAlteracaoIdioma
    {
        private bool _jaFechou = false;
        private void MontarIni()
        {
            string nomeIni = "Config.ini";
            string path = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory.ToString());
            string idioma;

            IniFile arquivoIni = new IniFile(path + "\\" + nomeIni);

            idioma = arquivoIni.ReadValue("CONFIGURACAO", "IDIOMA", "");

            if (string.IsNullOrEmpty(idioma))
            {
                arquivoIni.WriteValue("CONFIGURACAO", "IDIOMA", "pt-BR");
                idioma = "pt-BR";
            }

            Sessao.ObterInstancia.Idioma = idioma;
        }


        public FrmPrincipal()
        {
            MontarIni();

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Sessao.ObterInstancia.Idioma);

            InitializeComponent();
        }

        public Boolean fecharAplicacao()
        {
            if (!_jaFechou) //-"Gambiarra" criada por conta da alteração do idioma do form principal ao fechar o form de mudança de idioma. Quando essa operação é executada, a função de sair entra em loop 3 vezes.
            {
                if (MessageBox.Show("Deseja fechar a aplicação?",                      //-Mensagem.
                   "Escolha:",                                         //-Título. 
                   MessageBoxButtons.YesNo,                            //-Botões de opção.
                   MessageBoxIcon.Question,                            //-Ícone.
                   MessageBoxDefaultButton.Button2,                    //-Botão defautl.
                   0,                                                  //-Ignora MessageBoxOptions
                   "C:\\Program Files\\Beyond Compare 4\\BCompare.chm" //-Arquivo de ajuda.
                   ) == DialogResult.Yes)         //-Retorno esperado para tomar ação.
                {
                    _jaFechou = true;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else return true;
        }

        protected void RestaurarJanelas()
        {
            //-Caso alguma janela esteja minimizada, restaura seu estado. 
            //-Necessário ser aplicado antes de arranjar as janelas (cascata, horizontal...).
            foreach (Form i in this.MdiChildren)
            {
                if (i.WindowState != FormWindowState.Normal)
                {
                    i.WindowState = FormWindowState.Minimized;
                    i.WindowState = FormWindowState.Normal;
                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-Comando para fechar a aplicação.
            Application.Exit();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //-Comando que anula o encerramento da aplicação, caso a resposta seja diferente de "Sim".
            e.Cancel = !fecharAplicacao();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //-Alimenta os labes de data e hora da barra de status com essa informação.
            //-Cria um movimento no ProgressBar a casa segundo. O ProgressBar reinicia o movimento a cada 59 segundos, conforme seus próprios parâmetros. 
            lblData.Text = "Data: "+DateTime.Now.ToString("d");
            lblHora.Text = "  Hora: "+DateTime.Now.ToString("T");
            lblBar.Value = Convert.ToInt32(DateTime.Now.ToString("ss"));
        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            //-Inicializa o ProgressBar com o segundo atual do minuto da hora corrente.
            //-Liga o timer.
            lblBar.Value = Convert.ToInt32( DateTime.Now.ToString("ss") );
            timerDataHora.Enabled = true;
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilho1 frm = new FrmFilho1();
            frm.MdiParent = this;
            frm.Show();            
        }

        private void emCascatgaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-Restaura janelas antes de organizar. Janelas minimizadas não são restauradas automaticamente.
            RestaurarJanelas();
            //-Organiza as múltiplas janelas abertas em cascata.
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-Restaura janelas antes de organizar. Janelas minimizadas não são restauradas automaticamente.
            RestaurarJanelas();
            //-Organiza as múltiplas janelas abertas em linhas horizontais.
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void menuVerticalmente_Click(object sender, EventArgs e)
        {
            //-Restaura janelas antes de organizar. Janelas minimizadas não são restauradas automaticamente.
            RestaurarJanelas();
            //-Organiza as múltiplas janelas abertas em linhas verticais.
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuMinimizarTodas_Click(object sender, EventArgs e)
        {
            //-Minimiza todas as janelas abertas.
            foreach(Form i in this.MdiChildren)
            {
                i.WindowState = FormWindowState.Minimized;
            }
        }

        private void menuRestaurarMinimizadas_Click(object sender, EventArgs e)
        {
            //-Restaura todas as janelas minimizadas.
            foreach (Form i in this.MdiChildren)
            {
                if(i.WindowState == FormWindowState.Minimized)
                {
                    i.WindowState = FormWindowState.Maximized;
                }                
            }
        }

        private void menuFecharTodas_Click(object sender, EventArgs e)
        {
            //-Fecha todas as janelas abertas.
            foreach (Form i in this.MdiChildren)
            {
                i.Close();
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario frm = new FrmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void menuIdioma_Click(object sender, EventArgs e)
        {
            FrmIdioma frm = new FrmIdioma(this);
            frm.MdiParent = this;
            frm.Show();
        }

        private void AlterarIdiomaOnline()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Sessao.ObterInstancia.Idioma);

            //-Fecha todas as janelas abertas.
            foreach (Form i in this.MdiChildren)
            {
                if (i.Name != "FrmIdioma")
                    i.Close();
            }

            this.Controls.Clear();
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterParent;
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }

        public void AlterouIdioma(bool idiomaAlterado)
        {
            if (idiomaAlterado)
            {
                this.AlterarIdiomaOnline();
            }
        }
    }
}
