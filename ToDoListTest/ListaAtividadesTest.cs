using Moq;
using ToDoList;
using ToDoList.Entidades;
using ToDoList.Interfaces;

namespace ToDoListTest
{
    public class ListaAtividadesTest
    {
        [Fact]
        public void DeveAdicionarAtividades()
        {
            #region Arrange

            var atividadeMock = new Mock<IAtividade<Estudo>>();
            var atividades = new ListaAtividades<Estudo>(atividadeMock.Object);

            var atividade = new Estudo();
            atividade.Id = 1;
            atividade.Nome = "Ler";
            atividade.EstaConcluida = true;

            #endregion

            #region Act

            var exception = Record.Exception(() => atividades.Adicionar(atividade));

            #endregion

            #region Assert

            Assert.IsAssignableFrom<Estudo>(atividade);
            Assert.Null(exception);
            Assert.NotNull(atividades.Listar());

            #endregion
        }

        [Fact]
        public void DeveListarAtividades()
        {
            #region Arrange

            var atividadeMock1 = new Mock<IAtividade<Trabalho>>();
            var atividadesTrabalho = new ListaAtividades<Trabalho>(atividadeMock1.Object);
            var atividade1 = new Trabalho();
            atividade1.Id = 2;
            atividade1.Nome = "Testar";
            atividade1.EstaConcluida = true;

            var atividadeMock2= new Mock<IAtividade<Lazer>>();
            var atividadesLazer = new ListaAtividades<Lazer>(atividadeMock2.Object);
            var atividade2 = new Lazer();
            atividade2.Id = 3;
            atividade2.Nome = "Jogar";
            atividade2.EstaConcluida = false;

            atividadesTrabalho.Adicionar(atividade1);
            atividadesLazer.Adicionar(atividade2);

            #endregion

            #region Act

            var exception = Record.Exception(() => atividadesTrabalho.Listar());

            #endregion

            #region Assert

            Assert.Null(exception);

            #endregion
        }
    }
}