using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pag66_Loop_Cap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // isto é um comentário
            string nome = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("nome é " + nome
                    + "\nx é " + x
                    + "\nd é " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("x deve ser 10");
            }
            else
            {
                MessageBox.Show("x não deve ser 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int somaValor = 4;
            string nome = "Bobbo Jr";
            if ((somaValor == 3) && (nome == "Joe"))
            {
                MessageBox.Show("x é 3 e o nome é Joe");
            }
            MessageBox.Show("esta linha roda de qualquer forma");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show("A resposta é " + count); // resultado esperado é 5?
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Loop 1
            int count = 5;
            while (count > 0)
            {
                count = count * 3;
                count = count * -1;
            }
            MessageBox.Show("O valor de count é " + count);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Loop 2
            int i = 0;
            int count = 2;
            while (i == 0)
            {
                count = count * 3;
                count = count * -1;
            }
            MessageBox.Show("o valor de count é " + count);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Loop 3
            int j = 2;
            for (int i = 0; i < 100; i = i * 2)
            {
                j = j - 1;
                while (j < 25)
                {
                    j = j + 5;
                }
            }
            MessageBox.Show("O valor de j é" + j);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Loop 4
            int valor = 0;
            while (true)
            {
                int i = 1;
                valor = i;
            }
            MessageBox.Show("O valor é " + valor);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Loop 5
            int p = 2;
            for (int q = 0; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                }
                q = p - q;
            }
            MessageBox.Show("o valor de q é " + p);
        }
    }
}
