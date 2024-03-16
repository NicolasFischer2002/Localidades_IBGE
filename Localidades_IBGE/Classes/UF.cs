using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class UF
    {
        public int  Id { get; }
        public string Sigla { get; }
        public string Nome { get; }
        public Regiao Regiao { get; }

        public UF(int id, string sigla, string nome, Regiao regiao)
        {
            Id = id;
            Sigla = sigla;
            Nome = nome;
            Regiao = regiao;
        }
    }
}
