using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjEncapsulamento
{
    public partial class Form2 : Form
    {
        /* 
         * INSTANCIAMENTO DO OBJETO "Compartilha" 
         */
        Compartilha cp = new Compartilha();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            /* 
             * RECEBIMENTO DOS VALORES PROCESSADOS
             * E CONSECUTIVA SAÍDA NO CAMPO "Label" 
             */
            lblResultado.Text = cp.enviaResExtenso() + (cp.enviaRes()).ToString();
        }
    }
}
