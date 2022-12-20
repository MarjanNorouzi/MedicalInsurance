using MedicalInsurance.InfraStructrue.IRepositories;
using MedicalInsurance.Model.Models;
using System.Data;
using System.Data.SqlClient;

namespace MedicalInsurance.InfraStructrue.Repositories
{
    public class PrescriptionRepository : QueryRepository, IPrescriptionRepository
    {
        public void Add(Prescription prescription)
        {
            var cmd = new SqlCommand("Usp_Prescription_Add", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DrId", prescription.DrId);
            cmd.Parameters.AddWithValue("@PersonId", prescription.PersonId);
            cmd.Parameters.AddWithValue("@PrescriptionType", prescription.PrescriptionType);
            cmd.Parameters.AddWithValue("@Insurance", prescription.Insurance);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public DataTable GetAll(string procedureName)
        {
            throw new NotImplementedException();
        }

        public DataTable GetById(string procedureName, int id)
        {
            throw new NotImplementedException();
        }
    }
}
