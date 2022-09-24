using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Library.Models
{
    [Table("Person")]
    public partial class Person
    {
        public Person()
        {
            Credits = new HashSet<Credit>();
            Loans = new HashSet<Loan>();
            SocialSecurities = new HashSet<SocialSecurity>();
            Users = new HashSet<User>();
        }

        [Key]
        public int PersonId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        [Unicode(false)]
        public string LastName { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string Id { get; set; } = null!;
        [StringLength(45)]
        [Unicode(false)]
        public string Address { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }

        [InverseProperty("Person")]
        public virtual ICollection<Credit> Credits { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<Loan> Loans { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<SocialSecurity> SocialSecurities { get; set; }
        [InverseProperty("Person")]
        public virtual ICollection<User> Users { get; set; }
    }
}
