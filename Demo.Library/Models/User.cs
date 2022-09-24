using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Library.Models
{
    public partial class User
    {
        [Key]
        public int UserId { get; set; }
        public int PersonId { get; set; }
        [StringLength(25)]
        public string UserName { get; set; } = null!;
        [StringLength(50)]
        public string Password { get; set; } = null!;

        [ForeignKey("PersonId")]
        [InverseProperty("Users")]
        public virtual Person Person { get; set; } = null!;
    }
}
