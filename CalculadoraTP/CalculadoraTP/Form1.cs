using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConcatena_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + textBox2.Text);
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int soma;
            // usa o convert para converter para o n1 receber a string textBox1
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            soma = n1 + n2;
            MessageBox.Show(Convert.ToString(soma));
                               
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int subtrai;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            subtrai = n1 - n2;
            MessageBox.Show(Convert.ToString(subtrai));

        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int multiplica;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            multiplica = n1 * n2;
            MessageBox.Show(Convert.ToString(multiplica));
        }

        private void btnDividi_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int dividi;
            n1 = Convert.ToInt16(textBox1.Text);
            n2 = Convert.ToInt16(textBox2.Text);
            dividi = n1 / n2;
            MessageBox.Show(Convert.ToString(dividi));
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            int eleva;
            n1 = Convert.ToInt32(textBox1.Text);
            n2 = Convert.ToInt32(textBox2.Text);
            // usa-se (Math.Pow(n1, n2)) para elevar uma variável a outra.
            eleva = Convert.ToInt32(Math.Pow(n1, n2));
            //precisa converter para string, pois ele está preparado para receber um número inteiro
            
            MessageBox.Show(Convert.ToString(eleva));
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double n1;
            double resultado;
            n1 = Convert.ToDouble(textBox1.Text);
            resultado = Math.Sqrt(n1);

            MessageBox.Show(Convert.ToString(resultado));            
            
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
    }
}
