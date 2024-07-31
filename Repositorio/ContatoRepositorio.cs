using MVC_Asp.net_portifolio.Data;
using MVC_Asp.net_portifolio.Models;
using System.Linq;
using System.Collections.Generic;

namespace MVC_Asp.net_portifolio.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
      

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
            // Gravar no banco de dados
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

		public ContatoModel ListarPorItem(int id)
		{
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
		}
	}
}
