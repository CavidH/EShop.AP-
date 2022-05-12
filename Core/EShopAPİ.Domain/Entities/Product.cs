using EShopAPİ.Domain.Entities.Comon;

namespace EShopAPİ.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public long Price { get; set; }

    }
}
