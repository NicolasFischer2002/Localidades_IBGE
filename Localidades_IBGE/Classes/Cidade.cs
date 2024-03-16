using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class Cidade
    {
        public int Id { get; }
        public string Nome { get; }
        public Microrregiao Microrregiao { get; }
        [JsonProperty("regiao-imediata")]
        public RegiaoImediata RegiaoImediata { get; }

        public Cidade(int id, string nome, Microrregiao microrregiao, RegiaoImediata regiaoImediata)
        {
            Id = id;
            Nome = nome;
            Microrregiao = microrregiao;
            RegiaoImediata = regiaoImediata;
        }
    }
}
