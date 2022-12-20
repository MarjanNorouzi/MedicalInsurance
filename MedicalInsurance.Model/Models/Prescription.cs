using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInsurance.Model.Models
{
    public class Prescription
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DrId { get; set; } = null!;

        [Required]
        public string PrescriptionType { get; set; } = null!;

        [Required]
        public string PersonId { get; set; } = null!;

        [Required]
        [StringLength(64)]
        public string Insurance { get; set; }

        [Required]
        public DateOnly Date { get; set; }
    }
}
