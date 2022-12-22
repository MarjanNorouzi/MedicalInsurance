using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInsurance.Model.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string DrugName { get; set; } = null!;

        [Required]
        public int Count { get; set; }

        [Required]
        public int Dosage { get; set; }

        public DateTime ExpireDate { get; set; }

    }
}
