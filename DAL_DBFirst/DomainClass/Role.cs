using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_CodeFirst.DomainClass
{
    [Table("Role")]
    [Index(nameof(RoleCode), Name = "IX_Role_RoleCode", IsUnique = true)]
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Key]
        public Guid RoleId { get; set; }
        [Required]
        [StringLength(10)]
        public string RoleCode { get; set; }
        [Required]
        [StringLength(50)]
        public string RoleDescription { get; set; }
        [Required]
        public bool? Status { get; set; }
        public string Alias { get; set; }

        [InverseProperty(nameof(User.Role))]
        public virtual ICollection<User> Users { get; set; }
    }
}
