using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula31
{
    public partial class Form3 : Form
    {
        int largura = 100;
        int click = 0;
        int click2 = 0;
        int altura = 100;
        public Form3()
        {

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            largura = largura + 2;
            altura = altura + 2;
           
            click = click + 1;
            pictureBox1.Size = new Size(altura, largura);
            label3.Text = ("Voce clicou " + click +" " +
                "vezes para aumentar");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            largura = largura - 2;
            altura = altura - 2;

            click2  = click2 + 1;
            pictureBox1.Size = new Size(altura, largura);
            label3.Text = ("Voce clicou " + click2 + " " +
                "vezes para diminuir");
        }
    }
    }

