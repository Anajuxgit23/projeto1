using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class projeto1 : Form
    {
        public projeto1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[15];
            Random numero = new Random();
            for (int i = 0; i < 15; i++)
            {
                int numeroSorteado = numero.Next(0, 100);
                vetor[i] = numeroSorteado;
            }
            for (int i = 0; i <15;i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    txtresult.Text += vetor[i] + " ";
                }
            }

        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }
    }
}
