
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblStatusOperacao = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Controls.Add(this.lblStatusOperacao);
            this.pnlFundo.Controls.SetChildIndex(this.pnlCentral, 0);
            this.pnlFundo.Controls.SetChildIndex(this.lblStatusOperacao, 0);
            // 
            // pnlRodape
            // 
            this.pnlRodape.Controls.Add(this.btnExcluir);
            this.pnlRodape.Controls.Add(this.btnGravar);
            this.pnlRodape.Controls.SetChildIndex(this.btnFechar, 0);
            this.pnlRodape.Controls.SetChildIndex(this.btnGravar, 0);
            this.pnlRodape.Controls.SetChildIndex(this.btnExcluir, 0);
            // 
            // btnGravar
            // 
            this.btnGravar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGravar.Image = global::SistemaPrincipal.Properties.Resources.icons8_crie_um_novo_32;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(11, 8);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(87, 43);
            this.btnGravar.TabIndex = 1;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.Image = global::SistemaPrincipal.Properties.Resources.icons8_excluir_lixeira_32;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(123, 8);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 43);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblStatusOperacao
            // 
            this.lblStatusOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusOperacao.AutoSize = true;
            this.lblStatusOperacao.BackColor = System.Drawing.Color.Black;
            this.lblStatusOperacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusOperacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusOperacao.ForeColor = System.Drawing.Color.White;
            this.lblStatusOperacao.Location = new System.Drawing.Point(553, 1);
            this.lblStatusOperacao.Name = "lblStatusOperacao";
            this.lblStatusOperacao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStatusOperacao.Size = new System.Drawing.Size(100, 23);
            this.lblStatusOperacao.TabIndex = 18;
            this.lblStatusOperacao.Text = "Status CRUD";
            this.lblStatusOperacao.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmBaseCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 392);
            this.Name = "FrmBaseCRUD";
            this.Text = "FrmBaseCRUD";
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