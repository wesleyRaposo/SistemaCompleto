
namespace SistemaPrincipal.Formularios.FormulariosBase
{
    public partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlFundo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFundo
            // 
            this.pnlFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFundo.AutoScroll = true;
            this.pnlFundo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnlCentral);
            this.pnlFundo.Location = new System.Drawing.Point(0, 0);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(658, 328);
            this.pnlFundo.TabIndex = 2;
            // 
            // pnlCentral
            // 
            this.pnlCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentral.Location = new System.Drawing.Point(19, 28);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(614, 276);
            this.pnlCentral.TabIndex = 0;
            // 
            // pnlRodape
            // 
            this.pnlRodape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRodape.Controls.Add(this.btnFechar);
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 331);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(658, 61);
            this.pnlRodape.TabIndex = 3;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::SistemaPrincipal.Properties.Resources.icons8_sair_32;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(558, 8);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 43);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 392);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmBase_FormClosed);
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.Shown += new System.EventHandler(this.frmBase_Shown);
            this.SizeChanged += new System.EventHandler(this.FrmBase_SizeChanged);
            this.pnlFundo.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel pnlFundo;
        protected System.Windows.Forms.Panel pnlRodape;
        protected System.Windows.Forms.Button btnFechar;
        protected System.Windows.Forms.Panel pnlCentral;
    }
}