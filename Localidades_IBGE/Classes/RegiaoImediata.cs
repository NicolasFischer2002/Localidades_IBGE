using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class RegiaoImediata
    {
        public int Id { get; }
        public string Nome { get; }
        [JsonProperty("regiao-intermediaria")]
        public RegiaoIntermediaria RegiaoIntermediaria { get; }

        public RegiaoImediata(int id, string nome, RegiaoIntermediaria regiaoIntermediaria)
        {
            Id = id;
            Nome = nome;
            RegiaoIntermediaria = regiaoIntermediaria;
        }
    }
}
