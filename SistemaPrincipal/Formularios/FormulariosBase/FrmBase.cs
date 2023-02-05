using System;
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
    public partial class FrmBase : Form
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
        }

        private void FrmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            //NumeroDajanela--;
        }
    }
}
