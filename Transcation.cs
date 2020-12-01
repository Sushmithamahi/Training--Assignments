namespace PecnumiaBank27.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transcation")]
    public partial class Transcation
    {
        public int Id { get; set; }

        
        [Required]
        public string PayeeAccountNo { get; set; }

        
        [Required]
        public string BeneficiaryAccNo { get; set; }

       
        [Required]
        public string ChequeNo { get; set; }

        
        [Required]
        public string PayeeName { get; set; }

      
        [Required]
        public string Amount { get; set; }

       
        [Required]
        public string BankName { get; set; }

        
        [Required]
        public string IFSC { get; set; }
    }
}
