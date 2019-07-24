using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperadoresMatematicos
{
    public partial class Form1 : Form
    {
        Char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_executar_Click(object sender, EventArgs e)
        {
            int parcela1 = int.Parse(text_parcela1.Text);
            int parcela2 = int.Parse(text_parcela2.Text);
            int resultado = 0;

            /*if (parcela1.GetType() == typeof(String) | parcela1.GetType() == typeof(Char) | parcela1.Equals(null))
                label_resultado.Text = "Insira um número na primeira caixa";
            else if (parcela2.GetType() != typeof(int))
                label_resultado.Text = "Insira um número na primeira caixa";*/
            if (operador == '+')
                resultado = parcela1 + parcela2;
            else if (operador == '-')
                resultado = parcela1 - parcela2;
            else if (operador == '*')
                resultado = parcela1 * parcela2;
            else if (operador == '/')
                resultado = parcela1 / parcela2;
            else if (operador == '%')
                resultado = parcela1 % parcela2;
            else label_resultado.Text =  "Um operador deve ser escolhdo.";

            label_resultado.Text = resultado.ToString();
        }

        private void Btn_soma_Click(object sender, EventArgs e)
        {
            operador = '+';
        }

        private void Btn_menos_Click(object sender, EventArgs e)
        {
            operador = '-';
        }

        private void Btn_multiplica_Click(object sender, EventArgs e)
        {
            operador = '*';
        }

        private void Btn_divide_Click(object sender, EventArgs e)
        {
            operador = '/';
        }

        private void Btn_modulo_Click(object sender, EventArgs e)
        {
            operador = '%';
        }

        private void Bt_limpar_Click(object sender, EventArgs e)
        {
            label_resultado.Text = "";
            text_parcela1.Text = "";
            text_parcela2.Text = "";
        }
    }
}
