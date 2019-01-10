using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    interface IItemPedidoRepository
    {

    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }
    }
}