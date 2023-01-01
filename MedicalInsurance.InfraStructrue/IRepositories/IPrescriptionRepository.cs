using MedicalInsurance.Model.Models;

namespace MedicalInsurance.InfraStructrue.IRepositories
{
    public interface IPrescriptionRepository : IQueryRepository
    {
        void Add(Prescription prescription);
        decimal GetLastId();
    }
}
