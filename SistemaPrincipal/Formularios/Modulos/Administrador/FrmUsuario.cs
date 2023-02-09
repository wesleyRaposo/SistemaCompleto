using CamadaDeConexao;
using CamadaDeDados;
using ClassesBase;
using RegrasDeNegocio;
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

namespace SistemaPrincipal.Formularios.Modulos.Administrador
{
    public partial class FrmUsuario : FormulariosBase.FrmBaseCRUD
    {
        private ControleUsuario con = new ControleUsuario();
        private Conexao cnx = new Conexao();

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void textCodigo_Enter(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Funcoes.CharENumero(e.KeyChar)) && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void textNomeCompleto_Enter(object sender, EventArgs e)
        {
            CarregarCampos();
        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (!Funcoes.ValidaEmail((sender as TextBox).Text))
                {
                    (sender as TextBox).Focus();
                    MessageBox.Show("Email fora do padrão", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void textEmailDeRecuperacao_Leave(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty((sender as TextBox).Text))
            {
                if (!Funcoes.ValidaEmail((sender as TextBox).Text))
                {
                    (sender as TextBox).Focus();
                    MessageBox.Show("Email fora do padrão", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }            
        }

        protected override void LimparCampos()
        {
            base.LimparCampos();

            if (!this.DesignMode)
            {
                textID.Clear();
                textCodigo.Clear();
                textNomeCompleto.Clear();
                textNomeSocial.Clear();
                textEmail.Clear();
                textEmailDeRecuperacao.Clear();
                textSenha.Clear();
                textSenhaConfirmacao.Clear();
                chkEnviarEmailDeConfirmacao.Checked = false;
                chkExigirConfirmacaoPorEmail.Checked = false;
                chkExigirConfirmacaoPorEmail.Enabled = false;

                btnExcluir.Enabled = false;
                btnGravar.Enabled = false;

                textCodigo.Focus();

                DefinirStatusDeOpearcao(TipoOperacaoCRUD.NaoDefinida);
            }
        }

        protected override void CarregarCampos()
        {
            if (textCodigo.Text != "")
            {
                //-Se informou código, então quer achar um usuário ou para consulta, ou para atualização ou para exclusão.
                if (con.UsuarioExistePorCodigo(textCodigo.Text))
                {
                    Usuario us = new Usuario(cnx);
                    us = con.CarregarUsuarioPorCodigo(textCodigo.Text);

                    //-Carregar campos.
                    textID.Text = us.Id.ToString();
                    textCodigo.Text = us.Codigo;
                    textNomeCompleto.Text = us.Nome;
                    textNomeSocial.Text = us.NomeSocial;
                    chkNomeSocialPreferencial.Checked = (us.UsarNomeSocial == "S");
                    textEmail.Text = us.Email;
                    textEmailDeRecuperacao.Text = us.EmailRecuperacao;
                    textSenha.Text = us.Senha;
                    textSenhaConfirmacao.Text = us.Senha;
                    chkEnviarEmailDeConfirmacao.Checked = (us.EnviarEmailCadastramento == "S");
                    chkExigirConfirmacaoPorEmail.Checked = (us.SolicitarConfirmacaoPorEmail == "S");
                    chkExigirConfirmacaoPorEmail.Enabled = chkEnviarEmailDeConfirmacao.Checked;

                    btnExcluir.Enabled = true;
                    btnGravar.Enabled = true;

                    DefinirStatusDeOpearcao(TipoOperacaoCRUD.Alteracao);
                }
                else
                {
                    //-Se não informou Id, então quer fazer uma inclusão.
                    btnGravar.Enabled = true;

                    DefinirStatusDeOpearcao(TipoOperacaoCRUD.Inclusao);
                }
            }
            else
            {
                MessageBox.Show("Informe um código", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textCodigo.Focus();
            }
        }

        protected override void Gravar()
        {            
            if (StatusTela == TipoOperacaoCRUD.Inclusao)
            {
                if (!con.IncluirUsuario(textCodigo.Text,
                                   textNomeCompleto.Text,
                                   textNomeSocial.Text,
                                   Funcoes.BooleanParaString(chkNomeSocialPreferencial.Checked),
                                   textEmail.Text,
                                   textEmailDeRecuperacao.Text,
                                   textSenha.Text,
                                   textSenhaConfirmacao.Text,
                                   Funcoes.BooleanParaString(chkEnviarEmailDeConfirmacao.Checked),
                                   Funcoes.BooleanParaString(chkExigirConfirmacaoPorEmail.Checked)
                                   ))
                {
                    MessageBox.Show("Um erro ocorreu ao tentar incluir o usuário." + "\r\n" + con.MontarListaDeMensagensComoString());
                }
                else
                {
                    MessageBox.Show(con.MontarListaDeMensagensComoString());
                }
            }
            else
            if (StatusTela == TipoOperacaoCRUD.Alteracao)
            {
                if (!con.AtualizarUsuario(textID.Text,
                                     textCodigo.Text,
                                     textNomeCompleto.Text,
                                     textNomeSocial.Text,
                                     Funcoes.BooleanParaString(chkNomeSocialPreferencial.Checked),
                                     textEmail.Text,
                                     textEmailDeRecuperacao.Text,
                                     textSenha.Text,
                                     textSenhaConfirmacao.Text,
                                     Funcoes.BooleanParaString(chkEnviarEmailDeConfirmacao.Checked),
                                     Funcoes.BooleanParaString(chkExigirConfirmacaoPorEmail.Checked)
                                     ))
                {
                    MessageBox.Show("Um erro ocorreu ao tentar atualizar o usuário." + "\r\n" + con.MontarListaDeMensagensComoString());
                }
                else
                {
                    MessageBox.Show(con.MontarListaDeMensagensComoString());
                }
            }
            textCodigo.Focus();
        }        

        protected override void Excluir()
        {
            if ((StatusTela == TipoOperacaoCRUD.Alteracao))
            {
                if (!con.ExcluirUsuario(textID.Text))
                {
                    MessageBox.Show("Um erro ocorreu ao tentar excluir o usuário." + "\r\n" + con.MontarListaDeMensagensComoString());
                }
                else
                {
                    MessageBox.Show(con.MontarListaDeMensagensComoString());
                }
            }
            textCodigo.Focus();
        }

        private void btnObterProximoCodigo_Click(object sender, EventArgs e)
        {            
            textCodigo.Text = con.GerarProximoCodigoDoCliente().ToString();
            textNomeCompleto.Focus();
        }

        protected override bool PodeGravar()
        {
            if (textSenha.Text != textSenhaConfirmacao.Text)
            {
                MessageBox.Show("Senha diferente da confirmação.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void chkEnviarEmailDeConfirmacao_Click(object sender, EventArgs e)
        {
            if((sender as CheckBox).Checked == false)
            {
                chkExigirConfirmacaoPorEmail.Checked = false;
            }
            chkExigirConfirmacaoPorEmail.Enabled = (sender as CheckBox).Checked;
        }
    }
}
