﻿using EShopAPİ.Domain.Entities.Comon;

namespace EShopAPİ.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}