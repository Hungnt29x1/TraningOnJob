using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_CodeFirst.DomainClass
{
    [Table("User")]
    [Index(nameof(Email), Name = "IX_User_Email", IsUnique = true)]
    [Index(nameof(RoleId), Name = "IX_User_RoleId")]
    [Index(nameof(UserName), Name = "IX_User_UserName", IsUnique = true)]
    public partial class User
    {
        public User()
        {
            RecentlyViews = new HashSet<RecentlyView>();
            Reviews = new HashSet<Review>();
            Stores = new HashSet<Store>();
            Wishlists = new HashSet<Wishlist>();
        }

        [Key]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(10)]
        public string UserName { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Avatar { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        [Required]
        [StringLength(100)]
        public string Email { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public Guid? RoleId { get; set; }
        [Required]
        public bool? Status { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        public string Alias { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; }
        [InverseProperty(nameof(RecentlyView.User))]
        public virtual ICollection<RecentlyView> RecentlyViews { get; set; }
        [InverseProperty(nameof(Review.User))]
        public virtual ICollection<Review> Reviews { get; set; }
        [InverseProperty(nameof(Store.User))]
        public virtual ICollection<Store> Stores { get; set; }
        [InverseProperty(nameof(Wishlist.User))]
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
