using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_CodeFirst.DomainClass
{
    [Table("Wishlist")]
    [Index(nameof(ProductId), Name = "IX_Wishlist_ProductId")]
    [Index(nameof(UserId), Name = "IX_Wishlist_UserId")]
    public partial class Wishlist
    {
        [Key]
        public Guid WishlistId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ProductId { get; set; }
        public int Status { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Wishlists")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Wishlists")]
        public virtual User User { get; set; }
    }
}
