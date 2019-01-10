using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    interface ICadastroRepository
    {

    }   
    public class CadastroRepository : BaseRepository<Cadastro>, ICadastroRepository
    {
        public CadastroRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}