using Microsoft.Extensions.DependencyInjection;
using ToDoList;
using ToDoList.Entidades;
using ToDoList.Interfaces;

public static class Program
{
    public static IServiceCollection AddTypeT<T>(this IServiceCollection services) where T : class
    {
        services.AddSingleton<ServicoGerenciamentoAtividades<T>>();

        var provider = services.BuildServiceProvider();
        provider.GetRequiredService<ServicoGerenciamentoAtividades<T>>();

        return services;
    }
    static void Main() 
    {
        IAtividade<Estudo> estudo = new Estudo();
        var servicoEstudo = new ServicoGerenciamentoAtividades<Estudo>(estudo);

        List<Estudo> estudos = new List<Estudo>()
        {
            new Estudo
            {
                Id = 1,
                Nome = "Ler",
                EstaConcluida = false
            },
            new Estudo 
            {
                Id = 2,
                Nome = "Praticar",
                EstaConcluida = false
            }
        };

        servicoEstudo.IncluirAtividade(estudos);

        servicoEstudo.ConcluirAtividade(1);

        servicoEstudo.ImprimirListas();

        //IAtividade<Trabalho> trabalho = new Trabalho();
        //var servicoTrabalho = new ServicoGerenciamentoAtividades<Trabalho>(trabalho);

        //List<Trabalho> trabalhos = new List<Trabalho>()
        //{
        //    new Trabalho
        //    {
        //        Id = 1,
        //        Nome = "Testar",
        //        EstaConcluida = false
        //    },
        //    new Trabalho
        //    {
        //        Id = 2,
        //        Nome = "Debugar",
        //        EstaConcluida = false
        //    }
        //};

        //servicoTrabalho.IncluirAtividade(trabalhos);

        //servicoTrabalho.ImprimirListas();
    }
}