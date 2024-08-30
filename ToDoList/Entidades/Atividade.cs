namespace ToDoList.Entidades
{
    public abstract class Atividade
    {
        protected int _id;
        public int Id { get => _id; set => _id = value; }

        protected string _nome;
        public string Nome { get => _nome; set => _nome = value; }

        protected bool _estaConcluida;
        public bool EstaConcluida { get => _estaConcluida; set => _estaConcluida = value; }

        protected List<Atividade> _atividades;
    }
}
