
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
            // lblStatusOperacao
            // 
            this.lblStatusOperacao.Location = new System.Drawing.Point(621, 0);
            // 
            // pnlFundo
            // 
            this.pnlFundo.Size = new System.Drawing.Size(725, 645);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Location = new System.Drawing.Point(0, 648);
            this.pnlRodape.Size = new System.Drawing.Size(725, 61);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(893, 8);
            // 
            // pnlCentral
            // 
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
            this.pnlCentral.Location = new System.Drawing.Point(36, 38);
            this.pnlCentral.Size = new System.Drawing.Size(640, 587);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID";
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(20, 37);
            this.textID.MaxLength = 13;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(125, 23);
            this.textID.TabIndex = 20;
            this.textID.TabStop = false;
            // 
            // btnObterProximoCodigo
            // 
            this.btnObterProximoCodigo.Location = new System.Drawing.Point(291, 98);
            this.btnObterProximoCodigo.Name = "btnObterProximoCodigo";
            this.btnObterProximoCodigo.Size = new System.Drawing.Size(105, 23);
            this.btnObterProximoCodigo.TabIndex = 40;
            this.btnObterProximoCodigo.TabStop = false;
            this.btnObterProximoCodigo.Text = "Próximo Código";
            this.btnObterProximoCodigo.UseVisualStyleBackColor = true;
            this.btnObterProximoCodigo.Click += new System.EventHandler(this.btnObterProximoCodigo_Click);
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(258, 98);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(27, 23);
            this.btnBusca.TabIndex = 38;
            this.btnBusca.TabStop = false;
            this.btnBusca.Text = "F1";
            this.btnBusca.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Código";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(20, 99);
            this.textCodigo.MaxLength = 20;
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.PlaceholderText = "Somente números";
            this.textCodigo.Size = new System.Drawing.Size(232, 23);
            this.textCodigo.TabIndex = 37;
            this.textCodigo.Enter += new System.EventHandler(this.textCodigo_Enter);
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCodigo_KeyPress);
            // 
            // chkNomeSocialPreferencial
            // 
            this.chkNomeSocialPreferencial.AutoSize = true;
            this.chkNomeSocialPreferencial.Location = new System.Drawing.Point(527, 229);
            this.chkNomeSocialPreferencial.Name = "chkNomeSocialPreferencial";
            this.chkNomeSocialPreferencial.Size = new System.Drawing.Size(88, 19);
            this.chkNomeSocialPreferencial.TabIndex = 43;
            this.chkNomeSocialPreferencial.Text = "Preferencial";
            this.chkNomeSocialPreferencial.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Senha (confirmação)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "Senha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Email (de recuperação)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 50;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Nome Social";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "Nome Completo";
            // 
            // textSenhaConfirmacao
            // 
            this.textSenhaConfirmacao.Location = new System.Drawing.Point(20, 472);
            this.textSenhaConfirmacao.MaxLength = 60;
            this.textSenhaConfirmacao.Name = "textSenhaConfirmacao";
            this.textSenhaConfirmacao.PasswordChar = '*';
            this.textSenhaConfirmacao.Size = new System.Drawing.Size(496, 23);
            this.textSenhaConfirmacao.TabIndex = 47;
            // 
            // textSenha
            // 
            this.textSenha.Location = new System.Drawing.Point(20, 408);
            this.textSenha.MaxLength = 60;
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(496, 23);
            this.textSenha.TabIndex = 46;
            // 
            // textEmailDeRecuperacao
            // 
            this.textEmailDeRecuperacao.Location = new System.Drawing.Point(20, 345);
            this.textEmailDeRecuperacao.MaxLength = 60;
            this.textEmailDeRecuperacao.Name = "textEmailDeRecuperacao";
            this.textEmailDeRecuperacao.Size = new System.Drawing.Size(496, 23);
            this.textEmailDeRecuperacao.TabIndex = 45;
            this.textEmailDeRecuperacao.Leave += new System.EventHandler(this.textEmailDeRecuperacao_Leave);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(20, 286);
            this.textEmail.MaxLength = 60;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(496, 23);
            this.textEmail.TabIndex = 44;
            this.textEmail.Leave += new System.EventHandler(this.textEmail_Leave);
            // 
            // textNomeSocial
            // 
            this.textNomeSocial.Location = new System.Drawing.Point(20, 226);
            this.textNomeSocial.MaxLength = 60;
            this.textNomeSocial.Name = "textNomeSocial";
            this.textNomeSocial.Size = new System.Drawing.Size(496, 23);
            this.textNomeSocial.TabIndex = 42;
            // 
            // textNomeCompleto
            // 
            this.textNomeCompleto.Location = new System.Drawing.Point(20, 166);
            this.textNomeCompleto.MaxLength = 100;
            this.textNomeCompleto.Name = "textNomeCompleto";
            this.textNomeCompleto.Size = new System.Drawing.Size(595, 23);
            this.textNomeCompleto.TabIndex = 41;
            this.textNomeCompleto.Enter += new System.EventHandler(this.textNomeCompleto_Enter);
            // 
            // chkEnviarEmailDeConfirmacao
            // 
            this.chkEnviarEmailDeConfirmacao.AutoSize = true;
            this.chkEnviarEmailDeConfirmacao.Location = new System.Drawing.Point(20, 511);
            this.chkEnviarEmailDeConfirmacao.Name = "chkEnviarEmailDeConfirmacao";
            this.chkEnviarEmailDeConfirmacao.Size = new System.Drawing.Size(274, 19);
            this.chkEnviarEmailDeConfirmacao.TabIndex = 54;
            this.chkEnviarEmailDeConfirmacao.Text = "Enviar email de confirmação de cadastramento";
            this.chkEnviarEmailDeConfirmacao.UseVisualStyleBackColor = true;
            this.chkEnviarEmailDeConfirmacao.Click += new System.EventHandler(this.chkEnviarEmailDeConfirmacao_Click);
            // 
            // chkExigirConfirmacaoPorEmail
            // 
            this.chkExigirConfirmacaoPorEmail.AutoSize = true;
            this.chkExigirConfirmacaoPorEmail.Enabled = false;
            this.chkExigirConfirmacaoPorEmail.Location = new System.Drawing.Point(46, 544);
            this.chkExigirConfirmacaoPorEmail.Name = "chkExigirConfirmacaoPorEmail";
            this.chkExigirConfirmacaoPorEmail.Size = new System.Drawing.Size(242, 19);
            this.chkExigirConfirmacaoPorEmail.TabIndex = 55;
            this.chkExigirConfirmacaoPorEmail.Text = "Exigir confirmação de cadastro por email";
            this.chkExigirConfirmacaoPorEmail.UseVisualStyleBackColor = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 709);
            this.Name = "FrmUsuario";
            this.Text = "Cadastro de Usuários";
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