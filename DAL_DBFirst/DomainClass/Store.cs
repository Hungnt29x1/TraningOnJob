using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_CodeFirst.DomainClass
{
    [Table("Store")]
    [Index(nameof(UserId), Name = "IX_Store_UserId")]
    public partial class Store
    {
        public Store()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public Guid StoreId { get; set; }
        [Required]
        [StringLength(250)]
        public string StoreName { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsTrending { get; set; }
        public int Status { get; set; }
        public Guid UserId { get; set; }
        public string Alias { get; set; }

        [ForeignKey(nameof(UserId))]
        [InverseProperty("Stores")]
        public virtual User User { get; set; }
        [InverseProperty(nameof(Product.Store))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
