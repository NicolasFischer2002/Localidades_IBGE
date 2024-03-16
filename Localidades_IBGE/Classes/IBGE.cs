using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localidades_IBGE.Classes
{
    public class IBGE
    {
        public const string URLLocalidadesCidades = "https://servicodados.ibge.gov.br/api/v1/localidades/municipios";
        public static readonly string[] UFs = [
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA",
            "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN",
            "RS", "RO", "RR", "SC", "SP", "SE", "TO"
        ];

        public IBGE()
        {

        }

        public static async Task<string> ConsultaLocalidadesCidades(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Faz a requisição GET
                HttpResponseMessage response = await client.GetAsync(url);

                // Verifica se a requisição foi bem-sucedida
                response.EnsureSuccessStatusCode();

                // Lê o JSON retornado
                return await response.Content.ReadAsStringAsync();
            }
        }

        public static void EstadosValidos()
        {
            foreach (string uf in UFs)
                Console.Write($"{uf} ");
        }
    }
}
