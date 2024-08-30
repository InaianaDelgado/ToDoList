using ToDoList.Interfaces;

namespace ToDoList.Entidades
{
    public class Trabalho : Atividade, IAtividade<Trabalho>
    {
        private List<Trabalho> _trabalhos;

        public Trabalho()
        { 
            _trabalhos = new List<Trabalho>();
        }

        public void Adicionar(Trabalho atividade)
        {
            _trabalhos.Add(atividade);
        }

        public void Concluir(int id)
        {
            _trabalhos.ForEach(t =>
            {
                if (t._id == id)
                    t._estaConcluida = true;
            });
        }

        public List<Trabalho> Listar()
        {
            return _trabalhos;
        }

        public void Remover(Trabalho atividade)
        {
            _trabalhos.Remove(atividade);
        }
    }
}
