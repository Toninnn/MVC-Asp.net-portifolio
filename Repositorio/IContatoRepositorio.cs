using MVC_Asp.net_portifolio.Models;

namespace MVC_Asp.net_portifolio.Repositorio
{
    public interface IContatoRepositorio
    {
       ContatoModel ListarPorItem(int id);
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
