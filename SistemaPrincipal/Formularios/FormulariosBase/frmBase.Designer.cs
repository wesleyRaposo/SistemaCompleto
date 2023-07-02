
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
            resources.ApplyResources(this.pnlFundo, "pnlFundo");
            this.pnlFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFundo.Controls.Add(this.pnlCentral);
            this.pnlFundo.Name = "pnlFundo";
            // 
            // pnlCentral
            // 
            resources.ApplyResources(this.pnlCentral, "pnlCentral");
            this.pnlCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCentral.Name = "pnlCentral";
            // 
            // pnlRodape
            // 
            resources.ApplyResources(this.pnlRodape, "pnlRodape");
            this.pnlRodape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRodape.Controls.Add(this.btnFechar);
            this.pnlRodape.Name = "pnlRodape";
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            this.btnFechar.Image = global::SistemaPrincipal.Properties.Resources.icons8_sair_32;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBase
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlFundo);
            this.Name = "FrmBase";
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