using ToDoList.Entidades;
using ToDoList.Interfaces;

namespace ToDoList
{
    public class ServicoGerenciamentoAtividades<T> where T : class
    {
        private IAtividade<T> _iAtividade;
        private ListaAtividades<T> _listaAtividades;

        public ServicoGerenciamentoAtividades(IAtividade<T> iAtividade)
        {
            _iAtividade = iAtividade;
            _listaAtividades = new ListaAtividades<T>(_iAtividade);
        }

        public void IncluirAtividade(List<T> atividades)
        {
            atividades.ForEach(a =>
            {
                _listaAtividades.Adicionar(a);
            });
        }

        public List<T> ListarAtividades()
        {
            return _listaAtividades.Listar();
        }

        public void ImprimirListas()
        {
            var listas = ListarAtividades();

            if (listas?.Count > 0)
            {
                listas.ForEach(atv =>
                {
                    Console.WriteLine("______________________________________________________________________________");
                    Console.WriteLine($" Lista de tarefas de {atv?.GetType().Name}:");
                    Console.WriteLine($" Id: {atv?.GetType()?.GetProperty("Id")?.GetValue(atv)?.ToString()}");
                    Console.WriteLine($" Nome: {atv?.GetType()?.GetProperty("Nome")?.GetValue(atv)?.ToString()}");
                    Console.WriteLine($" Está concluída: {atv?.GetType()?.GetProperty("EstaConcluida")?.GetValue(atv)?.ToString()}");
                    Console.WriteLine("______________________________________________________________________________");
                });

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("______________________________________________________________________________");
                Console.WriteLine("Não existem tarefas para serem listadas");
                Console.WriteLine("______________________________________________________________________________");
                Console.ReadLine();
            }
        }

        public void ConcluirAtividade(int idAtividade)
        {
            _listaAtividades.Concluir(idAtividade);
        }


    }
}
