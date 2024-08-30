using ToDoList.Interfaces;

namespace ToDoList
{
    public class ListaAtividades<T> where T : class
    {
        private IAtividade<T> _iAtividade;

        public ListaAtividades(IAtividade<T> iAtividade)
        {
           _iAtividade = iAtividade;
        }

        public void Adicionar(T atividade)
        {
            _iAtividade.Adicionar(atividade);
        }

        public void Concluir(int id)
        {
            _iAtividade.Concluir(id);
        }

        public List<T> Listar()
        {
            return _iAtividade.Listar();
        }

        public void Remover(T atividade)
        {
            _iAtividade.Remover(atividade);
        }
    }
}
