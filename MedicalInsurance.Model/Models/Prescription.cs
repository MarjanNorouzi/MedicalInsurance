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
        public int DrId { get; set; } 

        [Required]
        public int PrescriptionTypeId { get; set; }

        [Required]
        public int PationtId { get; set; }

        [Required]
        [StringLength(64)]
        public string Insurance { get; set; }

        [Required]
        public DateOnly Date { get; set; }
    }
}
