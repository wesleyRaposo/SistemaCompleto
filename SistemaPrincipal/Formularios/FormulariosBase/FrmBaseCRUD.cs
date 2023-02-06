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

namespace SistemaPrincipal.Formularios.FormulariosBase
{
    public partial class FrmBaseCRUD : FormulariosBase.FrmBase, IFrmBaseCRUD
    {
        protected TipoOperacaoCRUD StatusTela { get; set; }

        public FrmBaseCRUD()
        {
            InitializeComponent();
            LimparCampos();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //
        }

        #region Métodos a serem herdados.

        protected virtual void LimparCampos()
        {
            //-Implementar nos cadastros herdados.
            //-Deve limpar os campos e focar no campo de entrada da tela.
            StatusTela = TipoOperacaoCRUD.NaoDefinida;
        }

        protected virtual void carregarCampos()
        {
            //-Implementar nos cadastros herdados.
            //-Deve carregar os campos com os dados vindos da base.
        }

        #endregion


        #region Eventos pré-definidos
        private void FrmBaseCRUD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }

        #endregion

    }
}
