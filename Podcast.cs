class Podcast
{
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;
    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Detalhes do Podcast:");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Host: {Host}");
        Console.WriteLine($"Total de episódios: {TotalEpisodios}");
        Console.WriteLine("Lista de episódios disponíveis:");
        foreach (var episodio in episodios)
        {
            Console.WriteLine($"{episodio.Resumo}");
        }
    }
}
