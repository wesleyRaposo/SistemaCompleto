
namespace SistemaPrincipal.Formularios
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.stStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBar = new System.Windows.Forms.ToolStripProgressBar();
            this.timerDataHora = new System.Windows.Forms.Timer(this.components);
            this.mnStripFuncoes = new System.Windows.Forms.MenuStrip();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProcessos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUtilitarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuJanelas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOrganizar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmCascata = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHorizontalmente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVerticalmente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuMinimizarTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRestaurarMinimizadas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFecharTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.stStripPrincipal.SuspendLayout();
            this.mnStripFuncoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // stStripPrincipal
            // 
            this.stStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData,
            this.lblHora,
            this.lblBar});
            this.stStripPrincipal.Location = new System.Drawing.Point(0, 428);
            this.stStripPrincipal.Name = "stStripPrincipal";
            this.stStripPrincipal.Size = new System.Drawing.Size(800, 22);
            this.stStripPrincipal.TabIndex = 0;
            this.stStripPrincipal.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(95, 17);
            this.lblData.Text = "Data: 00/00/0000";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(81, 17);
            this.lblHora.Text = "Hora: 00:00:00";
            // 
            // lblBar
            // 
            this.lblBar.Maximum = 59;
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(100, 16);
            this.lblBar.Step = 1;
            this.lblBar.Value = 1;
            // 
            // timerDataHora
            // 
            this.timerDataHora.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnStripFuncoes
            // 
            this.mnStripFuncoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastros,
            this.menuProcessos,
            this.menuRelatorios,
            this.menuUtilitarios,
            this.menuJanelas,
            this.menuSair});
            this.mnStripFuncoes.Location = new System.Drawing.Point(0, 0);
            this.mnStripFuncoes.MdiWindowListItem = this.menuJanelas;
            this.mnStripFuncoes.Name = "mnStripFuncoes";
            this.mnStripFuncoes.Size = new System.Drawing.Size(800, 24);
            this.mnStripFuncoes.TabIndex = 1;
            this.mnStripFuncoes.Text = "menuStrip1";
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuModelos,
            this.toolStripMenuItem1,
            this.menuAdministrador});
            this.menuCadastros.Image = global::SistemaPrincipal.Properties.Resources.icons8_signing_a_document_32;
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(87, 20);
            this.menuCadastros.Text = "&Cadastros";
            // 
            // menuModelos
            // 
            this.menuModelos.Name = "menuModelos";
            this.menuModelos.Size = new System.Drawing.Size(180, 22);
            this.menuModelos.Text = "Modelos";
            this.menuModelos.Click += new System.EventHandler(this.modelosToolStripMenuItem_Click);
            // 
            // menuAdministrador
            // 
            this.menuAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuarios});
            this.menuAdministrador.Name = "menuAdministrador";
            this.menuAdministrador.Size = new System.Drawing.Size(180, 22);
            this.menuAdministrador.Text = "Adminstrador";
            // 
            // menuUsuarios
            // 
            this.menuUsuarios.Name = "menuUsuarios";
            this.menuUsuarios.Size = new System.Drawing.Size(180, 22);
            this.menuUsuarios.Text = "Usuários";
            this.menuUsuarios.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // menuProcessos
            // 
            this.menuProcessos.Image = global::SistemaPrincipal.Properties.Resources.icons8_vamos_para_32;
            this.menuProcessos.Name = "menuProcessos";
            this.menuProcessos.Size = new System.Drawing.Size(87, 20);
            this.menuProcessos.Text = "&Processos";
            // 
            // menuRelatorios
            // 
            this.menuRelatorios.Image = global::SistemaPrincipal.Properties.Resources.icons8_enviar_para_a_impressora_32;
            this.menuRelatorios.Name = "menuRelatorios";
            this.menuRelatorios.Size = new System.Drawing.Size(87, 20);
            this.menuRelatorios.Text = "&Relatórios";
            // 
            // menuUtilitarios
            // 
            this.menuUtilitarios.Image = global::SistemaPrincipal.Properties.Resources.icons8_trabalho_32;
            this.menuUtilitarios.Name = "menuUtilitarios";
            this.menuUtilitarios.Size = new System.Drawing.Size(85, 20);
            this.menuUtilitarios.Text = "&Utilitários";
            // 
            // menuJanelas
            // 
            this.menuJanelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOrganizar});
            this.menuJanelas.Image = global::SistemaPrincipal.Properties.Resources.icons8_abrir_em_janela_32;
            this.menuJanelas.Name = "menuJanelas";
            this.menuJanelas.Size = new System.Drawing.Size(72, 20);
            this.menuJanelas.Text = "&Janelas";
            // 
            // menuOrganizar
            // 
            this.menuOrganizar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEmCascata,
            this.menuHorizontalmente,
            this.menuVerticalmente,
            this.toolStripSeparator1,
            this.menuMinimizarTodas,
            this.menuRestaurarMinimizadas,
            this.menuFecharTodas});
            this.menuOrganizar.Image = global::SistemaPrincipal.Properties.Resources.icons8_four_squares_32;
            this.menuOrganizar.Name = "menuOrganizar";
            this.menuOrganizar.Size = new System.Drawing.Size(125, 22);
            this.menuOrganizar.Text = "Organizar";
            // 
            // menuEmCascata
            // 
            this.menuEmCascata.Image = global::SistemaPrincipal.Properties.Resources.icons8_apresentar_32;
            this.menuEmCascata.Name = "menuEmCascata";
            this.menuEmCascata.Size = new System.Drawing.Size(193, 22);
            this.menuEmCascata.Text = "Em Cascata";
            this.menuEmCascata.Click += new System.EventHandler(this.emCascatgaToolStripMenuItem_Click);
            // 
            // menuHorizontalmente
            // 
            this.menuHorizontalmente.Image = global::SistemaPrincipal.Properties.Resources.icons8_manchete_de_exibição_32;
            this.menuHorizontalmente.Name = "menuHorizontalmente";
            this.menuHorizontalmente.Size = new System.Drawing.Size(193, 22);
            this.menuHorizontalmente.Text = "Horizontalmente";
            this.menuHorizontalmente.Click += new System.EventHandler(this.horizontalmenteToolStripMenuItem_Click);
            // 
            // menuVerticalmente
            // 
            this.menuVerticalmente.Image = global::SistemaPrincipal.Properties.Resources.icons8_coluna_de_exibição_32;
            this.menuVerticalmente.Name = "menuVerticalmente";
            this.menuVerticalmente.Size = new System.Drawing.Size(193, 22);
            this.menuVerticalmente.Text = "Verticalmente";
            this.menuVerticalmente.Click += new System.EventHandler(this.menuVerticalmente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // menuMinimizarTodas
            // 
            this.menuMinimizarTodas.Image = global::SistemaPrincipal.Properties.Resources.icons8_minimizar_janela_32;
            this.menuMinimizarTodas.Name = "menuMinimizarTodas";
            this.menuMinimizarTodas.Size = new System.Drawing.Size(193, 22);
            this.menuMinimizarTodas.Text = "Minimizar Todas";
            this.menuMinimizarTodas.Click += new System.EventHandler(this.menuMinimizarTodas_Click);
            // 
            // menuRestaurarMinimizadas
            // 
            this.menuRestaurarMinimizadas.Image = global::SistemaPrincipal.Properties.Resources.icons8_maximizar_janela_32;
            this.menuRestaurarMinimizadas.Name = "menuRestaurarMinimizadas";
            this.menuRestaurarMinimizadas.Size = new System.Drawing.Size(193, 22);
            this.menuRestaurarMinimizadas.Text = "Restaurar Minimizadas";
            this.menuRestaurarMinimizadas.Click += new System.EventHandler(this.menuRestaurarMinimizadas_Click);
            // 
            // menuFecharTodas
            // 
            this.menuFecharTodas.Image = global::SistemaPrincipal.Properties.Resources.icons8_fechar_janela_32;
            this.menuFecharTodas.Name = "menuFecharTodas";
            this.menuFecharTodas.Size = new System.Drawing.Size(193, 22);
            this.menuFecharTodas.Text = "Fechar Todas";
            this.menuFecharTodas.Click += new System.EventHandler(this.menuFecharTodas_Click);
            // 
            // menuSair
            // 
            this.menuSair.Image = global::SistemaPrincipal.Properties.Resources.icons8_desligarB_32;
            this.menuSair.Name = "menuSair";
            this.menuSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuSair.Size = new System.Drawing.Size(54, 20);
            this.menuSair.Text = "&Sair";
            this.menuSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stStripPrincipal);
            this.Controls.Add(this.mnStripFuncoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnStripFuncoes;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.stStripPrincipal.ResumeLayout(false);
            this.stStripPrincipal.PerformLayout();
            this.mnStripFuncoes.ResumeLayout(false);
            this.mnStripFuncoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timerDataHora;
        private System.Windows.Forms.ToolStripProgressBar lblBar;
        private System.Windows.Forms.MenuStrip mnStripFuncoes;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem menuModelos;
        private System.Windows.Forms.ToolStripMenuItem menuProcessos;
        private System.Windows.Forms.ToolStripMenuItem menuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem menuUtilitarios;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.ToolStripMenuItem menuJanelas;
        private System.Windows.Forms.ToolStripMenuItem menuOrganizar;
        private System.Windows.Forms.ToolStripMenuItem menuEmCascata;
        private System.Windows.Forms.ToolStripMenuItem menuHorizontalmente;
        private System.Windows.Forms.ToolStripMenuItem menuVerticalmente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuMinimizarTodas;
        private System.Windows.Forms.ToolStripMenuItem menuFecharTodas;
        private System.Windows.Forms.ToolStripMenuItem menuRestaurarMinimizadas;
        private System.Windows.Forms.ToolStripMenuItem menuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem menuUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

