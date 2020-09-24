using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace game
{
    public class JSON
    {
        private string Context { get; set; }
        private string NameArqJSON { get; set; }
        private string Path { get; set; }

        public JSON()
        {
            Path = Environment.CurrentDirectory;
            Path = Path.Replace("\\bin\\Debug", "");
            Path = Path + "\\DB\\Ranking.json";
            Context = File.ReadAllText(Path);
            NameArqJSON = "Ranking";
        }
        public List<Jogada> ListadeJogadas()
        {
            List<Jogada> Jogadas = new List<Jogada>();
            var context = JsonConvert.DeserializeObject<List<Jogada>>(Context);
            try
            {
                if (context != null)
                {
                    foreach (var item in context)
                    {
                        Jogadas.Add(item);
                    }
                }
                else
                {
                    throw new Exception($"Não há nenhum {NameArqJSON} cadastrado");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return Jogadas;
        }
   
        public void AddOrder(Jogada jogada)
        {

            var jogadas = JsonConvert.DeserializeObject<List<Jogada>>(Context);
            jogadas.Add(new Jogada(jogada));
            string novoJsonResult = JsonConvert.SerializeObject(jogadas, Formatting.Indented);
            File.WriteAllText(Path, novoJsonResult);
        }

        public List<Jogada> GetByName(string nome)
        {
            List<Jogada> jogadas = new List<Jogada>();
            var jsonObj = JsonConvert.DeserializeObject<List<Jogada>>(Context);

            foreach (var item in jsonObj)
            {
                if (item.Nome.ToLower().Trim() == nome.Trim().ToLower())
                    jogadas.Add(item);
            }
            return jogadas;
        }

        public List<Jogada> GetByDateTime(DateTime date)
        {
            List<Jogada> jogadas = new List<Jogada>();
            var jsonObj = JsonConvert.DeserializeObject<List<Jogada>>(Context);

            foreach (var item in jsonObj)
            {
                if (item.Tempo == date)
                    jogadas.Add(item);
            }
            return jogadas;
        }
    }
}