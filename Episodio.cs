class Episodio
{
    public string Titulo { get; }
    public int Ordem { get; }
    public int Duracao { get; }
    public string Resumo =>
        $"{Titulo} - episódio {Ordem} - {Duracao} horas - Convidados: {string.Join(", ", convidados)}";

    private List<string> convidados = new List<string>();

    public Episodio(string titulo, int ordem, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}
