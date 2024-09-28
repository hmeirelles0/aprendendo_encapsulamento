using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEncapsulamento
{
    /* 
     * AO INICIAR A CLASSE, ADICIONAR OS MODIFICADORES "public" 
     * para visualização da mesma pelas demais classes e objetos 
     */
    public class Compartilha
    {
        /* 
         * SÃO BOAS PRÁTICAS UTILIZAR OS MODIFICADORES "private" E "static"
         * PARA EVITAR REUTILIZAÇÃO DAS VARIÁVEIS
         */
        private static Double valor1;
        private static Double valor2;
        private static String operador;
        public void recebeNum(String v1, String v2, String op)
        {
            /* 
             * RECEBE AS VARIÁVEIS ENVIADAS COMO ARGUMENTOS DO "Form1" E AS
             * ARMAZENA NAS VARIÁVEIS DECLARADAS NO ESCOPO GLOBAL ACIMA
             */
            valor1 = Double.Parse(v1);
            valor2 = Double.Parse(v2);
            operador = op;
        }
        /* 
         * MÉTODO QUE INICIALMENTE ENVIARÁ A OPERAÇÃO
         * POR EXTENSO, SEM QUALQUER PROCESSAMENTO
         */
        public String enviaResExtenso()
        {
            if (operador == "0")
                return valor1.ToString() + " + " + valor2.ToString() + " = ";
            else if (operador == "1")
                return valor1.ToString() + " - " + valor2.ToString() + " = ";
            else if (operador == "2")
                return valor1.ToString() + " x " + valor2.ToString() + " = ";
            else
                return valor1.ToString() + " / " + valor2.ToString() + " = ";
        }

        public Double enviaRes ()
        {
            /* 
             * PROCESSAMENTO 
             */
            if (operador == "0")
                return valor1 + valor2;
            else if (operador == "1")
                return valor1 - valor2;
            else if (operador == "2")
                return valor1 * valor2;
            else
                return valor1 / valor2;
        }
    }
}
