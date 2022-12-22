﻿using MedicalInsurance.Model.Models;
using System.Data;

namespace MedicalInsurance.InfraStructrue.IRepositories
{
    public interface IMedicineRepository : IQueryRepository
    {
        void Add(Medicine medicine, int TypeOfMedicineId, int PrescriptionId);
        DataTable GetMedicineType();
    }
}
