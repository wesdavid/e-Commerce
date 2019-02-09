using System.Linq;
using CasaDoCodigo.Models;

namespace CasaDoCodigo.Repositories
{
    public interface IItemPedidoRepository
    {
        ItemPedido GetItemPedido(int itemPedidoId);
        void RemoveItempedido(int itemPedidoId);
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            return
            dbSet
                 .Where(ip => ip.Id == itemPedidoId)
                 .SingleOrDefault();
        }

        public void RemoveItempedido(int itemPedidoId)
        {
            dbSet.Remove(GetItemPedido(itemPedidoId));
        }
    }
}