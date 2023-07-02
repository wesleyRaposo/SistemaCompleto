
namespace SistemaPrincipal.Formularios.Modulos.Administrador
{
    partial class FrmIdioma
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIdioma));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSelecaoDeIdioma = new System.Windows.Forms.Label();
            this.pnlFundo.SuspendLayout();
            this.pnlRodape.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            resources.ApplyResources(this.btnFechar, "btnFechar");
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.lblSelecaoDeIdioma);
            this.pnlCentral.Controls.Add(this.comboBox1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblSelecaoDeIdioma
            // 
            resources.ApplyResources(this.lblSelecaoDeIdioma, "lblSelecaoDeIdioma");
            this.lblSelecaoDeIdioma.Name = "lblSelecaoDeIdioma";
            // 
            // FrmIdioma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FrmIdioma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIdioma_FormClosed);
            this.pnlFundo.ResumeLayout(false);
            this.pnlRodape.ResumeLayout(false);
            this.pnlCentral.ResumeLayout(false);
            this.pnlCentral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblSelecaoDeIdioma;
    }
}