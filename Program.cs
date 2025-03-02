Podcast podcast = new Podcast("Marcelo", "DevCast");

Episodio episodio1 = new Episodio("Primeiro episódio", 1, 4);
episodio1.AdicionarConvidados("Nelson Mandela");
episodio1.AdicionarConvidados("Alce");

Episodio episodio2 = new Episodio("Segundo episódio", 2, 4);
episodio2.AdicionarConvidados("Luciano Huck");
episodio2.AdicionarConvidados("Messi");

Episodio episodio3 = new Episodio("Terceiro episódio", 3, 2);
episodio3.AdicionarConvidados("Ariana Grande");
episodio3.AdicionarConvidados("Eixosinistro");
episodio3.AdicionarConvidados("Mestre dos magos");

Episodio episodio4 = new Episodio("Último episódio", 4, 40);
episodio4.AdicionarConvidados("Neymar");
episodio4.AdicionarConvidados("Donald Trump");
episodio4.AdicionarConvidados("Peixe míope");
episodio4.AdicionarConvidados("Alecrim dourado (que nasceu no campo sem ser semeado)");
episodio4.AdicionarConvidados("Sucrilhos Kellogg's");

podcast.AdicionarEpisodio(episodio1);
podcast.AdicionarEpisodio(episodio2);
podcast.AdicionarEpisodio(episodio3);
podcast.AdicionarEpisodio(episodio4);

podcast.ExibirDetalhes();
