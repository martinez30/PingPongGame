using game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Jogo : Form
    {
        public List<Jogada> ranking = new List<Jogada>();
        JSON json = new JSON();
        DateTime hora;
        public string Nome;
        string Nivel;

        public Jogo(string nome)
        {
            InitializeComponent();
            crono.Enabled = false;
            Nome = nome;
        }

        public void Init(int tam)
        {
            switch (tam)
            {
                case 100:
                    raquete.Height = 50;
                    Nivel = "Dificil";
                    break;
                case 200:
                    raquete.Height = 100;
                    Nivel = "Medio";
                    break;
                case 300:
                    raquete.Height = 200;
                    Nivel = "Facil";
                    break;
            }
        }

        int veloc = 10, min = 0, seg = 0;
        bool top, esq, advtop = false;

        private void Jogo_Load(object sender, EventArgs e)
        {
            bola.Location = new Point(65, 180);
            top = esq = true;
        }

        private void iniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crono.Enabled = true;
            relogio.Enabled = true;
            iniciarJogoToolStripMenuItem.Enabled = false;
            pausarJogoToolStripMenuItem.Enabled = true;
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            tempo.Text = $"{AddZero(min)}:{AddZero(seg)}";
        }

        private void reiniciarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bola.Location = new Point(65, 180);
            top = esq = true;
            crono.Enabled = true;
            relogio.Enabled = true;
            bola.Visible = true;
            reiniciarJogoToolStripMenuItem.Enabled = false;
            pausarJogoToolStripMenuItem.Enabled = true;
        }

        private void encerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crono.Enabled = false;
            relogio.Enabled = false;
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void pausarJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relogio.Enabled = false;
            crono.Enabled = false;
            pausarJogoToolStripMenuItem.Enabled = false;
            iniciarJogoToolStripMenuItem.Text = "Retomar Jogo";
            iniciarJogoToolStripMenuItem.Enabled = true;
        }

        private void Crono_Tick(object sender, EventArgs e)
        {
            if (!advtop)
            {
                adversario.Location = new Point(0, adversario.Location.Y - 5);
            }
            else
            {
                adversario.Location = new Point(0, adversario.Location.Y + 5);
            }

            if (adversario.Location.Y >= 230)
            {
                advtop = false;
            }
            else if (adversario.Location.Y <= 27)
            {
                advtop = true;
            }

            if (bola.Left > raquete.Left)
            {
                crono.Enabled = false;
                relogio.Enabled = false;
                hora = DateTime.Now;
                Jogada J = new Jogada(Guid.NewGuid(), Nome, hora, Nivel, "Derrota", $"{AddZero(min)}:{AddZero(seg)}");
                json.AddOrder(J);
                notifyIcon1.ShowBalloonTip(100,"Banco de dados","Resultado guardado no banco", ToolTipIcon.None);
                MessageBox.Show("Você perdeu");
                pausarJogoToolStripMenuItem.Enabled = false;
                reiniciarJogoToolStripMenuItem.Visible = true;
            }

            if (
                bola.Left + bola.Width >= raquete.Left &&
                bola.Left + bola.Width <= raquete.Left + raquete.Width &&
                bola.Top + bola.Height >= raquete.Top &&
                bola.Top + bola.Height <= raquete.Top + raquete.Height + bola.Height
                )
            {
                esq = false;
            }

            if (
                bola.Left + bola.Width >= adversario.Right &&
                bola.Left <= adversario.Right &&
                bola.Top + bola.Height >= adversario.Top &&
                bola.Top + bola.Height <= adversario.Top + adversario.Height + bola.Height
                )
            {
                esq = true;
            }

            if (esq)
            {
                if (bola.Right < adversario.Right)
                {
                    crono.Enabled = false;
                    relogio.Enabled = false;
                    hora = DateTime.Now;
                    Jogada J = new Jogada(Guid.NewGuid(), Nome, hora, Nivel, "Vitória", $"{AddZero(min)}:{AddZero(seg)}");
                    json.AddOrder(J);
                    notifyIcon1.ShowBalloonTip(100, "Banco de dados", "Resultado guardado no banco", ToolTipIcon.None);
                    MessageBox.Show("Você ganhou");
                    pausarJogoToolStripMenuItem.Enabled = false;
                    reiniciarJogoToolStripMenuItem.Visible = true;
                    return;
                }
                else
                {
                    bola.Left += veloc;
                }
            }
            else
            {
                bola.Left -= veloc;
            }

            if (top)
            {
                bola.Top += veloc;
            }
            else
            {
                bola.Top -= veloc;
            }

            if (bola.Top >= this.Height - 70)
            {
                top = false;
            }

            if (bola.Top <= 27)
            {
                top = true;
            }

            if (bola.Right <= 0)
            {
                esq = true;
            }

        }

        private void Jogo_MouseMove(object sender, MouseEventArgs e)
        {
            raquete.Top = e.Y;
        }

        private string AddZero(int num)
        {
            if (num < 10)
            {
                return "0" + num.ToString();
            }
            else
            {
                return num.ToString();
            }
        }
    }
}
