using game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Ranking : Form
    {
        public List<Jogada> ranking = new List<Jogada>();
        JSON json = new JSON();

        public Ranking()
        {
            InitializeComponent();
            ranking = json.ListadeJogadas();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("");
            foreach (var item in ranking.Select(x=> x.Nome).Distinct())
            {
                comboBox1.Items.Add($"{item}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var nome = comboBox1.Text;
            var data = dateTimePicker1.Value;
            if (nome == "" && data == null)
            {
                foreach (var item in ranking.OrderBy(x => x.Nome))
                {
                    listBox1.Items.Add($"{item.Nome} - {item.Tempo.Day}/{item.Tempo.Month}/{item.Tempo.Year} - {item.Modo} - {item.Resultado} - {item.Duracao}");
                }
            }
            else if (nome != "" && data != null)
            {
                foreach (var item in ranking.Where(x =>
                            x.Nome == nome &&
                            x.Tempo.Day == data.Day &&
                            x.Tempo.Month == data.Month &&
                            x.Tempo.Year == data.Year
                            ))
                {
                    listBox1.Items.Add($"{item.Nome} - {item.Tempo.Day}/{item.Tempo.Month}/{item.Tempo.Year} - {item.Modo} - {item.Resultado} - {item.Duracao}");
                }
            }
            else if (nome != "" && data == null)
            {
                foreach (var item in ranking.Where(x => x.Nome == nome))
                {
                    listBox1.Items.Add($"{item.Nome} - {item.Tempo.Day}/{item.Tempo.Month}/{item.Tempo.Year} - {item.Modo} - {item.Resultado} - {item.Duracao}");
                }

            }
            else if (nome == "" && data != null)
            {
                foreach (var item in ranking.Where(x =>
                            x.Tempo.Day == data.Day &&
                            x.Tempo.Month == data.Month &&
                            x.Tempo.Year == data.Year))
                {
                    listBox1.Items.Add($"{item.Nome} - {item.Tempo.Day}/{item.Tempo.Month}/{item.Tempo.Year} - {item.Modo} - {item.Resultado} - {item.Duracao}");
                }
            }

        }
    }
}
