using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class Regiao
    {
        public int Id { get; }
        public string Sigla { get; }
        public string Nome { get; }

        public Regiao(int id, string sigla, string nome)
        {
            Id = id;
            Sigla = sigla;
            Nome = nome;
        }
    }
}
