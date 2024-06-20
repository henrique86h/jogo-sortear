using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_sortear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random dado = new Random(); // Cria uma nova instância da classe Random para gerar números aleatórios
            int valor; // Declara uma variável do tipo inteiro chamada 'valor'

            valor = dado.Next(1, 4); // Atribui à variável 'valor' um número aleatório entre 1 e 3 (inclusive)

            if (valor == 1) // Verifica se o valor gerado é igual a 1 
            {
                pictureBox1.Visible = true; // Se for igual a 1, torna visível a imagem do Pokémon 1
                pictureBox2.Visible = false; // Esconde a imagem do Pokémon 2
                pictureBox3.Visible = false; // Esconde a imagem do Pokémon 3
            }

            if (valor == 2) 
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }

            if (valor == 3) 
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
        }
    }
}
