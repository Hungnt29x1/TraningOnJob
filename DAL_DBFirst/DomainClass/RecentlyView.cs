using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_CodeFirst.DomainClass
{
    [Table("RecentlyView")]
    [Index(nameof(ProductId), Name = "IX_RecentlyView_ProductId")]
    [Index(nameof(UserId), Name = "IX_RecentlyView_UserId")]
    public partial class RecentlyView
    {
        [Key]
        public Guid RecentlyViewId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("RecentlyViews")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("RecentlyViews")]
        public virtual User User { get; set; }
    }
}
