using EShopAPİ.Domain.Entities.Comon;

namespace EShopAPİ.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
