using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInsurance.InfraStructrue.IRepositories
{
    public interface IPharmacyRepository
    {
        DataTable GetMedicineFromNationalCode(string procedureName, int NationalCode);
    }
}
