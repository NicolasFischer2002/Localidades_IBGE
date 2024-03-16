
using Localidades_IBGE;
using Localidades_IBGE.Classes;
using Newtonsoft.Json;

try
{
    Console.ForegroundColor = ConsoleColor.Green;
    string? opcao = "";

    do
    {
        Console.WriteLine("\nDigite 1 para requisição WEB ou digite 2 para leitura do arquivo");
        opcao = Console.ReadLine();

        if (opcao == "1")
        {
            Console.WriteLine("\nDigite a sigla do estado desejado: ");
            string? UFescolhido = Console.ReadLine();

            if (!string.IsNullOrEmpty(UFescolhido))
            {
                if (IBGE.UFs.Contains(UFescolhido.ToUpper()))
                {
                    // Faz o processo via requisição web:
                    string? jsonLocalidadesCidades = await IBGE.ConsultaLocalidadesCidades(IBGE.URLLocalidadesCidades);

                    // Desserializa o JSON e obtém a lista de cidades
                    List<Cidade> cidades = JsonConvert.DeserializeObject<List<Cidade>>(jsonLocalidadesCidades);

                    string[] nomesCidades = cidades.Where(f => f.RegiaoImediata.RegiaoIntermediaria.UF.Sigla == UFescolhido.ToUpper()).Select(f => f.Nome).ToArray();

                    if (nomesCidades.Any())
                    {
                        Console.WriteLine($"\nCidades do estado de {UFescolhido}: ");
                        foreach (string nomeCidade in nomesCidades)
                            Console.WriteLine($"{nomeCidade}");

                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nCidades não encontradas, verifique se digitou uma sigla válida! sigla digitada: {UFescolhido}");
                    Console.WriteLine("Estados válidos: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    IBGE.EstadosValidos();
                    Console.WriteLine("\n");
                }
            }
            else
                Console.WriteLine("\nDigite um valor diferente de nulo ou vazio!");
        }
        else if (opcao == "2")
        {
            Console.WriteLine("\nDigite a sigla do estado desejado: ");
            string? UFescolhido = Console.ReadLine();

            if (!string.IsNullOrEmpty(UFescolhido))
            {
                if (IBGE.UFs.Contains(UFescolhido.ToUpper()))
                {
                    // Faz o processo via leitura de arquivo local
                    string jsonText = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}Estados-Cidades-IBGE.txt");

                    List<Cidade> cidadesFile = JsonConvert.DeserializeObject<List<Cidade>>(jsonText);

                    string[] nomesCidades = cidadesFile.Where(f => f.RegiaoImediata.RegiaoIntermediaria.UF.Sigla == UFescolhido.ToUpper()).Select(f => f.Nome).ToArray();

                    if (nomesCidades.Any())
                    {
                        Console.WriteLine($"\nCidades do estado de {UFescolhido}: ");
                        foreach (string nomeCidade in nomesCidades)
                            Console.WriteLine($"{nomeCidade}");

                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nCidades não encontradas, verifique se digitou uma sigla válida! sigla digitada: {UFescolhido}");
                    Console.WriteLine("Estados válidos: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    IBGE.EstadosValidos();
                    Console.WriteLine("\n");
                }
            }
            else
                Console.WriteLine("\nDigite um valor diferente de nulo ou vazio!");
        }
    }
    while (opcao != "1" || opcao != "2");

    Console.WriteLine("\nPrecione qualquer tecla para finalizar a aplicação...");
    Console.ReadLine();
}
catch (Exception Erro)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"\nErro inesperado: {Erro.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\nAplicação finalizada");
}