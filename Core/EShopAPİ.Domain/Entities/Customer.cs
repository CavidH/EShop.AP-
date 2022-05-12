using EShopAPİ.Domain.Entities.Comon;

namespace EShopAPİ.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public ICollection<Order> Orders { get; set; }
    }
}
