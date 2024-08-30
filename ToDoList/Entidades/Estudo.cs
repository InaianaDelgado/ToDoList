using ToDoList.Interfaces;

namespace ToDoList.Entidades
{
    public class Estudo : Atividade, IAtividade<Estudo>
    {
        private List<Estudo> _estudos;

        public Estudo()
        { 
            _estudos = new List<Estudo>();
        }


        public void Adicionar(Estudo atividade)
        {
            _estudos.Add(atividade);
        }

        public void Concluir(int id)
        {
            _estudos.ForEach(t =>
            {
                if (t._id == id)
                    t._estaConcluida = true;
            });
        }

        public List<Estudo> Listar()
        {
            return _estudos;
        }

        public void Remover(Estudo atividade)
        {
            _estudos.Remove(atividade);
        }
    }
}
