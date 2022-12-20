using MedicalInsurance.Model.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInsurance.InfraStructrue.IRepositories
{
    public interface IPatientRepository : IQueryRepository
    {
        void Add(Patient patient);
        DataTable GetByNationalCode(string nationalCode);
    }
}
