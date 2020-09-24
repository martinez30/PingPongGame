using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game
{
    public class Jogada
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public DateTime Tempo { get; set; }
        public string Duracao { get; set; }
        public string Modo { get; set; }
        public string Resultado { get; set; }

        public Jogada()
        {

        }

        public Jogada(Jogada jogada)
        {
            Id = jogada.Id;
            Nome = jogada.Nome;
            Tempo = jogada.Tempo;
            Duracao = jogada.Duracao;
            Modo = jogada.Modo;
            Resultado = jogada.Resultado;
        }

        public Jogada(Guid guid,string nome, DateTime tempo, string modo, string resultado, string duracao)
        {
            Id = guid.ToString();
            Nome = nome;
            Tempo = tempo;
            Modo = modo;
            Resultado = resultado;
            Duracao = duracao;
        }
    }
}
