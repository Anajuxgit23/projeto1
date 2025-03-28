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
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        int notaslidas = 0;
        int soma = 0;
        int[] vetorNotas = new int[30];
        private void btncalcular_Click(object sender, EventArgs e)
        {

            if(notaslidas == 30)
            {
                for(int i = 0; i < 30; i++)
                {
                    soma += vetorNotas[i];
                    int resultado = soma / 30;
                    txt2.Text = resultado.ToString();
                }
            }
            else
            {
                vetorNotas[notaslidas] = Convert.ToInt32(txt1.Text);
                notaslidas++;
                lblnotas.Text = notaslidas.ToString() + "/30";
            }

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
