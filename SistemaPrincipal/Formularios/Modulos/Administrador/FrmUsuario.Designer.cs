
namespace SistemaPrincipal.Formularios.Modulos.Administrador
{
    public partial class FrmUsuario : FormulariosBase.FrmBaseCRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.btnObterProximoCodigo = new System.Windows.Forms.Button();
            this.btnBusca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.chkNomeSocialPreferencial = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSenhaConfirmacao = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.textEmailDeRecuperacao = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNomeSocial = new System.Windows.Forms.TextBox();
            this.textNomeCompleto = new System.Windows.Forms.TextBox();
            this.chkEnviarEmailDeConfirmacao = new System.Windows.Forms.CheckBox();
            this.chkExigirConfirmacaoPorEmail = new System.Windows.Forms.CheckBox();
            this.pnlFundo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            resources.ApplyResources(this.btnGravar, "btnGravar");
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            // 
            // lblStatusOperacao
            // 
            resources.ApplyResources(this.lblStatusOperacao, "lblStatusOperacao");
            // 
            // pnlFundo
            // 
            resources.ApplyResources(this.pnlFundo, "pnlFundo");
            // 
            // pnlRodape
            // 
            resources.ApplyResources(this.pnlRodape, "pnlRodape");
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            // 
            // pnlCentral
            // 
            resources.ApplyResources(this.pnlCentral, "pnlCentral");
            this.pnlCentral.Controls.Add(this.chkExigirConfirmacaoPorEmail);
            this.pnlCentral.Controls.Add(this.chkEnviarEmailDeConfirmacao);
            this.pnlCentral.Controls.Add(this.chkNomeSocialPreferencial);
            this.pnlCentral.Controls.Add(this.label8);
            this.pnlCentral.Controls.Add(this.label7);
            this.pnlCentral.Controls.Add(this.label6);
            this.pnlCentral.Controls.Add(this.label5);
            this.pnlCentral.Controls.Add(this.label4);
            this.pnlCentral.Controls.Add(this.label3);
            this.pnlCentral.Controls.Add(this.textSenhaConfirmacao);
            this.pnlCentral.Controls.Add(this.textSenha);
            this.pnlCentral.Controls.Add(this.textEmailDeRecuperacao);
            this.pnlCentral.Controls.Add(this.textEmail);
            this.pnlCentral.Controls.Add(this.textNomeSocial);
            this.pnlCentral.Controls.Add(this.textNomeCompleto);
            this.pnlCentral.Controls.Add(this.btnObterProximoCodigo);
            this.pnlCentral.Controls.Add(this.btnBusca);
            this.pnlCentral.Controls.Add(this.label2);
            this.pnlCentral.Controls.Add(this.textCodigo);
            this.pnlCentral.Controls.Add(this.label1);
            this.pnlCentral.Controls.Add(this.textID);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textID
            // 
            resources.ApplyResources(this.textID, "textID");
            this.textID.Name = "textID";
            this.textID.TabStop = false;
            // 
            // btnObterProximoCodigo
            // 
            resources.ApplyResources(this.btnObterProximoCodigo, "btnObterProximoCodigo");
            this.btnObterProximoCodigo.Name = "btnObterProximoCodigo";
            this.btnObterProximoCodigo.TabStop = false;
            this.btnObterProximoCodigo.UseVisualStyleBackColor = true;
            this.btnObterProximoCodigo.Click += new System.EventHandler(this.btnObterProximoCodigo_Click);
            // 
            // btnBusca
            // 
            resources.ApplyResources(this.btnBusca, "btnBusca");
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.TabStop = false;
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textCodigo
            // 
            resources.ApplyResources(this.textCodigo, "textCodigo");
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Enter += new System.EventHandler(this.textCodigo_Enter);
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigo_KeyPress);
            // 
            // chkNomeSocialPreferencial
            // 
            resources.ApplyResources(this.chkNomeSocialPreferencial, "chkNomeSocialPreferencial");
            this.chkNomeSocialPreferencial.Name = "chkNomeSocialPreferencial";
            this.chkNomeSocialPreferencial.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textSenhaConfirmacao
            // 
            resources.ApplyResources(this.textSenhaConfirmacao, "textSenhaConfirmacao");
            this.textSenhaConfirmacao.Name = "textSenhaConfirmacao";
            // 
            // textSenha
            // 
            resources.ApplyResources(this.textSenha, "textSenha");
            this.textSenha.Name = "textSenha";
            // 
            // textEmailDeRecuperacao
            // 
            resources.ApplyResources(this.textEmailDeRecuperacao, "textEmailDeRecuperacao");
            this.textEmailDeRecuperacao.Name = "textEmailDeRecuperacao";
            this.textEmailDeRecuperacao.Leave += new System.EventHandler(this.textEmailDeRecuperacao_Leave);
            // 
            // textEmail
            // 
            resources.ApplyResources(this.textEmail, "textEmail");
            this.textEmail.Name = "textEmail";
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textNomeSocial
            // 
            resources.ApplyResources(this.textNomeSocial, "textNomeSocial");
            this.textNomeSocial.Name = "textNomeSocial";
            // 
            // textNomeCompleto
            // 
            resources.ApplyResources(this.textNomeCompleto, "textNomeCompleto");
            this.textNomeCompleto.Name = "textNomeCompleto";
            this.textNomeCompleto.Enter += new System.EventHandler(this.textNomeCompleto_Enter);
            // 
            // chkEnviarEmailDeConfirmacao
            // 
            resources.ApplyResources(this.chkEnviarEmailDeConfirmacao, "chkEnviarEmailDeConfirmacao");
            this.chkEnviarEmailDeConfirmacao.Name = "chkEnviarEmailDeConfirmacao";
            this.chkEnviarEmailDeConfirmacao.UseVisualStyleBackColor = true;
            this.chkEnviarEmailDeConfirmacao.Click += new System.EventHandler(this.chkEnviarEmailDeConfirmacao_Click);
            // 
            // chkExigirConfirmacaoPorEmail
            // 
            resources.ApplyResources(this.chkExigirConfirmacaoPorEmail, "chkExigirConfirmacaoPorEmail");
            this.chkExigirConfirmacaoPorEmail.Name = "chkExigirConfirmacaoPorEmail";
            this.chkExigirConfirmacaoPorEmail.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FrmUsuario";
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNomeSocialPreferencial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSenhaConfirmacao;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.TextBox textEmailDeRecuperacao;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textNomeSocial;
        private System.Windows.Forms.TextBox textNomeCompleto;
        private System.Windows.Forms.Button btnObterProximoCodigo;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.CheckBox chkExigirConfirmacaoPorEmail;
        private System.Windows.Forms.CheckBox chkEnviarEmailDeConfirmacao;
    }
}