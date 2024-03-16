using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class Mesorregiao
    {
        public int Id { get; }
        public string Nome { get; }
        public UF UF { get; }

        public Mesorregiao(int id, string nome, UF uf )
        {
            Id = id;
            Nome = nome;
            UF = uf;
        }
    }
}
