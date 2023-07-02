
namespace SistemaPrincipal.Formularios.FormulariosBase
{
    public partial class FrmBaseCRUD : FormulariosBase.FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaseCRUD));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblStatusOperacao = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            resources.ApplyResources(this.pnlFundo, "pnlFundo");
            this.pnlFundo.Controls.Add(this.lblStatusOperacao);
            this.pnlFundo.Controls.SetChildIndex(this.pnlCentral, 0);
            this.pnlFundo.Controls.SetChildIndex(this.lblStatusOperacao, 0);
            // 
            // pnlRodape
            // 
            resources.ApplyResources(this.pnlRodape, "pnlRodape");
            this.pnlRodape.Controls.Add(this.btnExcluir);
            this.pnlRodape.Controls.Add(this.btnGravar);
            this.pnlRodape.Controls.SetChildIndex(this.btnFechar, 0);
            this.pnlRodape.Controls.SetChildIndex(this.btnGravar, 0);
            this.pnlRodape.Controls.SetChildIndex(this.btnExcluir, 0);
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            // 
            // pnlCentral
            // 
            resources.ApplyResources(this.pnlCentral, "pnlCentral");
            // 
            // btnGravar
            // 
            resources.ApplyResources(this.btnGravar, "btnGravar");
            this.btnGravar.Image = global::SistemaPrincipal.Properties.Resources.icons8_crie_um_novo_32;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            resources.ApplyResources(this.btnExcluir, "btnExcluir");
            this.btnExcluir.Image = global::SistemaPrincipal.Properties.Resources.icons8_excluir_lixeira_32;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblStatusOperacao
            // 
            resources.ApplyResources(this.lblStatusOperacao, "lblStatusOperacao");
            this.lblStatusOperacao.BackColor = System.Drawing.Color.Black;
            this.lblStatusOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusOperacao.ForeColor = System.Drawing.Color.White;
            this.lblStatusOperacao.Name = "lblStatusOperacao";
            // 
            // FrmBaseCRUD
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FrmBaseCRUD";
            this.Shown += new System.EventHandler(this.FrmBaseCRUD_Shown);
            this.pnlFundo.ResumeLayout(false);
            this.pnlFundo.PerformLayout();
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnGravar;
        protected System.Windows.Forms.Button btnExcluir;
        protected System.Windows.Forms.Label lblStatusOperacao;
    }
}