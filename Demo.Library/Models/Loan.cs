using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Demo.Library.Models
{
    public partial class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public int PersonId { get; set; }
        public long Amount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }

        [ForeignKey("PersonId")]
        [InverseProperty("Loans")]
        public virtual Person Person { get; set; } = null!;
    }
}
