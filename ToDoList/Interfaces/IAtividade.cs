namespace ToDoList.Interfaces
{
    public interface IAtividade<T> where T : class
    {
        int Id { get; set; }
        string Nome { get; set; }
        bool EstaConcluida { get; set; }

        void Adicionar(T atividade);
        void Remover(T atividade);
        List<T> Listar();
        void Concluir(int id);
    }
}
