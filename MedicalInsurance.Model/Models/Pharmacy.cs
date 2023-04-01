using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInsurance.Model.Models
{
    public class Pharmacy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string? PharmacyName { get; set; }

        [Required]
        public int PrescriptionId { get; set; }

        [Required]
        [StringLength(256)]
        public string? Address { get; set; }

        [Required]
        public int LicensePharmacy { get; set; }

    }
}
