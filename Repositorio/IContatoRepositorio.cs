using MVC_Asp.net_portifolio.Models;

namespace MVC_Asp.net_portifolio.Repositorio
{
    public interface IContatoRepositorio
    {
        List<ContatoModel> BuscarTodos();
        ContatoModel Adicionar(ContatoModel contato);
    }
}
