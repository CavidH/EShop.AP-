using System.ComponentModel.DataAnnotations;

namespace EShopAPİ.Domain.Entities.Comon
{
    public class BaseEntity
    {
        [Key] public Guid İD { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDates { get; set; }
    }
}