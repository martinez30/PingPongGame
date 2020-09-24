using game;
using System;
using System.Windows.Forms;

namespace game
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                string nome = textBox1.Text;
                JSON json = new JSON();
                Menu menu = new Menu(nome);
                this.Hide();
                menu.ShowDialog();
            }
            else
                MessageBox.Show("É necessário inserir um nome");
        }

    private void Voltar_Click(object sender, EventArgs e)
    {
        Menu menu = new Menu();
        this.Hide();
        menu.ShowDialog();
    }
}
}
