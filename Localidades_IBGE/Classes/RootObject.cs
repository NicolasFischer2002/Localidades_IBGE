using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class RootObject
    {
        public List<Cidade> Cidades { get; }

        public RootObject(List<Cidade> cidades)
        {
            Cidades = cidades;
        }
    }
}
