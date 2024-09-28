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
    public partial class Form1 : Form
    {
        //INSTANCIAMENTO DOS OBJETOS "Form2" E "Compartilha" (ENCAPSULADORA)
        Compartilha share = new Compartilha();
        Form2 frm2 = new Form2();

        private static String primeiro = "";
        private static String segundo = "";
        private static String terceiro = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEnvia_Click(object sender, EventArgs e)
        {
            /*
             * RESGATA OS VALORES ENVIADOS NOS CAMPOS "TextBox" ABAIXO E
             * ARMAZENA EM SUAS RESPECTIVAS VARIÁVEIS 
             */
            primeiro = txtNum1.Text;
            segundo = txtNum2.Text;
            terceiro = (cbxOperadores.SelectedIndex).ToString();
            /* 
             * ESSAS VARIÁVEIS SERÃO ENTÃO ENVIADAS COMO ARGUMENTOS DO MÉTODO
             * INICIADO NA CLASSE ENCAPSULADORA "Compartilha"
             */
            share.recebeNum(primeiro, segundo, terceiro);
            //MOSTRA O FORMULÁRIO 2 AO CLIQUE DO BOTÃO
            frm2.Show();
        }
    }
}
