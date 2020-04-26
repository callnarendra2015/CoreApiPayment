using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApiPayment.Model
{
    public class PaymentDetail
    {
        [Key]
        public int PMid { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string CardOwnerName { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string CardNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string ExpirationDate { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CCV { get; set; }
    }
}
