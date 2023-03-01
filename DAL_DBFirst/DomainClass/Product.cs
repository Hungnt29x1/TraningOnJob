using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_CodeFirst.DomainClass
{
    [Table("Product")]
    [Index(nameof(CategoryId), Name = "IX_Product_CategoryId")]
    [Index(nameof(StoreId), Name = "IX_Product_StoreId")]
    public partial class Product
    {
        public Product()
        {
            RecentlyViews = new HashSet<RecentlyView>();
            Reviews = new HashSet<Review>();
            Wishlists = new HashSet<Wishlist>();
        }

        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [StringLength(250)]
        public string ProductName { get; set; }
        [Required]
        public string ProductImage { get; set; }
        public bool IsTrending { get; set; }
        [Column(TypeName = "decimal(20, 0)")]
        public decimal Price { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [Required]
        [StringLength(250)]
        public string Description { get; set; }
        public int Status { get; set; }
        public Guid CategoryId { get; set; }
        public Guid StoreId { get; set; }
        public string Alias { get; set; }
        public int? Views { get; set; }
        public DateTime? RecentlyView { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Products")]
        public virtual Category Category { get; set; }
        [ForeignKey(nameof(StoreId))]
        [InverseProperty("Products")]
        public virtual Store Store { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        [InverseProperty(nameof(Review.Product))]
        public virtual ICollection<Review> Reviews { get; set; }
        [InverseProperty(nameof(Wishlist.Product))]
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
