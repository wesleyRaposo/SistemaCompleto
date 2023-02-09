using ClassesBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios;

namespace SistemaPrincipal.Formularios.FormulariosBase
{
    public partial class FrmBaseCRUD : FormulariosBase.FrmBase, IFrmBaseCRUD, IFrmBase
    {
        protected TipoOperacaoCRUD StatusTela { get; set; }

        public FrmBaseCRUD()
        {
            InitializeComponent();
        }

        #region Métodos a serem herdados.

        protected virtual void LimparCampos()
        {
            //-Implementar nos cadastros herdados.
            //-Deve limpar os campos e focar no campo de entrada da tela.
            if (!this.DesignMode)
            {
                StatusTela = TipoOperacaoCRUD.NaoDefinida;
            }
        }

        protected virtual void CarregarCampos()
        {
            //-Implementar nos cadastros herdados.
            //-Deve carregar os campos com os dados vindos da base.
        }

        protected virtual void DefinirStatusDeOpearcao(TipoOperacaoCRUD status)
        {
            StatusTela = status;

            switch (status)
            {
                case TipoOperacaoCRUD.NaoDefinida:
                    {
                        lblStatusOperacao.Text = "";
                        break;
                    }
                case TipoOperacaoCRUD.Inclusao:
                    {
                        lblStatusOperacao.Text = "Operação: Inclusão";
                        break;
                    }
                case TipoOperacaoCRUD.Alteracao:
                    {
                        lblStatusOperacao.Text = "Operação: Alteração/Exclusão";
                        break;
                    }
                case TipoOperacaoCRUD.Exclusao:
                    {
                        lblStatusOperacao.Text = "Operação: Alteração/Exclusão";
                        break;
                    }
                case TipoOperacaoCRUD.Consulta:
                    {
                        lblStatusOperacao.Text = "Operação: Consulta";
                        break;
                    }
            }

            lblStatusOperacao.Left = pnlFundo.Width - lblStatusOperacao.Width;
        }

        protected virtual bool PodeGravar()
        {
            //-Implementar na herança.
            return true;
        }

        protected virtual void Gravar()
        {
            //-Implementar na herança.
        }

        protected virtual bool PodeExcluir()
        {
            //-Implementar na herança.
            return true;
        }

        protected virtual void Excluir()
        {
            //-Implementar na herança.
        }

        protected override void ReposicionarControles()
        {
            //-O reposicionamento de controles não deve ser chamado na criação dos componentes, pois pode provocar erros de referência nula.
            // Idealmente ele deve ser invocados em eventos do forme, quando em sua exibição ou redimensionamento.
            // Ele deve estar protegido pelo teste (!this.DesignMode) para não correr o crisco de provocar (ainda mais) problemas no mode de design.

            base.ReposicionarControles();

            if (!this.DesignMode)
            {
                //lblStatusOperacao.Location = new Point(pnlFundo.Height - lblStatusOperacao.Height -1 , 1);

                int X = this.pnlRodape.Location.X + 10;
                int X2 = this.btnGravar.Location.X + this.btnGravar.Width + 30;
                int Y = (pnlRodape.Size.Height / 2) - (btnGravar.Size.Height / 2);

                this.btnGravar.Location = new Point(X, Y);
                this.btnExcluir.Location = new Point(X2, Y);
            }
        }

        #endregion


        #region Eventos pré-definidos

        private void FrmBaseCRUD_Shown(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (PodeGravar())
            {
                Gravar();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (PodeExcluir())
            {
                Excluir();
            }
        }

        #endregion

    }
}
