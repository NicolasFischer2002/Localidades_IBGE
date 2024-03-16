using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class Microrregiao
    {
        public int Id { get; }
        public string Nome { get; }
        public Mesorregiao Mesorregiao { get; }

        public Microrregiao(int id, string nome, Mesorregiao mesorregiao)
        {
            Id = id;
            Nome = nome;
            Mesorregiao = mesorregiao;
        }
    }
}
