using game;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace game
{
    public partial class Menu : Form
    {
        public string Nome;
        public Menu(string nome)
        {
            InitializeComponent();
            Nome = nome;
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void modoFacilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Nome == null)
            {
                MessageBox.Show("Primeiro é necessário adicionar seu nome");
            }
            else
            {
                this.Hide();
                Jogo jogofacil = new Jogo(Nome);
                jogofacil.Init(300);
                jogofacil.Show();
            }
        }

        private void modoNormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nome == null)
            {
                MessageBox.Show("Primeiro é necessário adicionar seu nome");
            }
            else
            {
                this.Hide();
                Jogo jogofacil = new Jogo(Nome);
                jogofacil.Init(200);
                jogofacil.Show();
            }
        }

        private void modoDifícilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Nome == null)
            {
                MessageBox.Show("Primeiro é necessário adicionar seu nome");
            }
            else
            {
                this.Hide();
                Jogo jogofacil = new Jogo(Nome);
                jogofacil.Init(100);
                jogofacil.Show();
            }

            Stopwatch stop = new Stopwatch();
        }

        private void referênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Referencias reference = new Referencias();
            this.Hide();
            reference.ShowDialog();
        }

        private void rankingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ranking frmRanking = new Ranking();
            this.Hide();
            frmRanking.ShowDialog();

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            this.Hide();
            cadastro.ShowDialog();
        }
    }
}

