using MedicalInsurance.Model.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInsurance.InfraStructrue.IRepositories
{
    public interface IQueryRepository
    {
        DataTable GetAll(string procedureName);
        DataTable GetById(string procedureName, int id);
    }
}
