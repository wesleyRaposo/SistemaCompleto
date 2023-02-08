﻿using System;
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
    public partial class FrmBase : Form, IFrmBase
    {
        
        public static int NumeroDajanela { get; private set; }

        protected Boolean podeFechar()
        {
            //-Implementar nos forms herdados se for o caso.
            return true;
        }
        
        public FrmBase()
        {
            InitializeComponent();

            NumeroDajanela++;
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
             //   this.WindowState = FormWindowState.Maximized;
             //   this.FormBorderStyle = FormBorderStyle.None;
             //   this.ShowIcon = false;    //-Na propriedade do form também funciona.
             //   this.ControlBox = false;  //-Na propriedade do form também funciona.
             //   this.MaximizeBox = false; //-Na propriedade do form também funciona.
             //   this.MinimizeBox = false; //-Na propriedade do form também funciona.
            }
            this.Text = "Janela " + NumeroDajanela;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (podeFechar())
            {
                this.Close();
            }       
        }
                
        private void frmBase_Shown(object sender, EventArgs e)
        {          
            if (!this.DesignMode)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            ReposicionarControles();
        }

        private void FrmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            //NumeroDajanela--;
        }

        protected virtual void ReposicionarControles()
        {
            //-O reposicionamento de controles não deve ser chamado na criação dos componentes, pois pode provocar erros de referência nula.
            // Idealmente ele deve ser invocados em eventos do forme, quando em sua exibição ou redimensionamento.
            // Ele deve estar protegido pelo teste (!this.DesignMode) para não correr o crisco de provocar (ainda mais) problemas no mode de design.

            if (!this.DesignMode)
            {
                int X = pnlRodape.Size.Width - btnFechar.Size.Width - 10;
                int Y = (pnlRodape.Size.Height / 2) - (btnFechar.Size.Height / 2);
                btnFechar.Location = new Point(X, Y);

                int Xp = 0;
                int Yp = 0;
                if ((pnlCentral.Width < pnlFundo.Width) && (pnlCentral.Height < pnlFundo.Height))
                {
                    Xp = (pnlFundo.Width / 2) - (pnlCentral.Width / 2);
                    Yp = (pnlFundo.Height / 2) - (pnlCentral.Height / 2);
                }
                else
                if ((pnlCentral.Width < pnlFundo.Width) && (pnlCentral.Height > pnlFundo.Height))
                {
                    Xp = (pnlFundo.Width / 2) - (pnlCentral.Width / 2);
                    Yp = 15;
                }
                else
                if ((pnlCentral.Width > pnlFundo.Width) && (pnlCentral.Height < pnlFundo.Height))
                {
                    Xp = 15;
                    Yp = (pnlFundo.Height / 2) - (pnlCentral.Height / 2);
                }

                pnlCentral.Location = new Point(Xp, Yp);
            }
        }

        private void FrmBase_SizeChanged(object sender, EventArgs e)
        {
            ReposicionarControles();
        }

        private void FrmBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
                SendKeys.Send("{tab}");
            }
        }
    }
}