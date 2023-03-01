using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_CodeFirst.DomainClass
{
    [Table("Review")]
    [Index(nameof(ProductId), Name = "IX_Review_ProductId")]
    [Index(nameof(UserId), Name = "IX_Review_UserId")]
    public partial class Review
    {
        [Key]
        public Guid ReviewId { get; set; }
        public Guid UserId { get; set; }
        [Required]
        [StringLength(250)]
        public string Comment { get; set; }
        public DateTime? CreateDate { get; set; }
        public Guid ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Reviews")]
        public virtual Product Product { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Reviews")]
        public virtual User User { get; set; }
    }
}
