﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Library.Models
{
    public partial class Credit
    {
        [Key]
        public int CreditId { get; set; }
        public int PersonId { get; set; }
        public long Amount { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Credits")]
        public virtual Person Person { get; set; } = null!;
    }
}
