using ToDoList.Interfaces;

namespace ToDoList.Entidades
{
    public class Lazer : Atividade, IAtividade<Lazer>
    {
        private List<Lazer> _lazereres;

        public Lazer()
        { 
            _lazereres = new List<Lazer>();
        }

        public void Adicionar(Lazer atividade)
        {
            _lazereres.Add(atividade);
        }

        public void Concluir(int id)
        {
            _lazereres.ForEach(t =>
            {
                if (t._id == id)
                    t._estaConcluida = true;
            });
        }

        public List<Lazer> Listar()
        {
            return _lazereres;
        }

        public void Remover(Lazer atividade)
        {
            _lazereres.Remove(atividade);
        }
    }
}
