using SimpleWebStore.Domain.Entities;

namespace SimpleWebStore.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingsDetails);
    }
}
