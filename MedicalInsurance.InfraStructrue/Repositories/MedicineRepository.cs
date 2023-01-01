using MedicalInsurance.InfraStructrue.IRepositories;
using MedicalInsurance.Model.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInsurance.InfraStructrue.Repositories
{
    public class MedicineRepository : QueryRepository, IMedicineRepository
    {

        public void Add(Medicine medicine, int PrescriptionId)
        {
            var cmd = new SqlCommand("Usp_Medicine_Add", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@DrugName", medicine.DrugName);
            cmd.Parameters.AddWithValue("@Count", medicine.Count);
            cmd.Parameters.AddWithValue("@TypeOfMedicineId", medicine.DrugTypeId);
            cmd.Parameters.AddWithValue("@PrescriptionId", PrescriptionId);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public DataTable GetAll(string procedureName)
        {
            var dt = new DataTable();

            SqlCommand cmd = new SqlCommand("Usp_ServiceMedicine_GetAll", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            sqlConnection.Open();

            SqlDataReader? reader = cmd.ExecuteReader();
            dt.Load(reader);

            sqlConnection.Close();

            return dt;
        }

        public DataTable GetById(string procedureName, int id)
        {
            throw new NotImplementedException();
        }

        public DataTable GetMedicineType()
        {
            var dt = new DataTable();

            SqlCommand cmd = new SqlCommand("Usp_TypeOfMedicine_GetAll", sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;

            sqlConnection.Open();

            SqlDataReader? reader = cmd.ExecuteReader();
            dt.Load(reader);

            sqlConnection.Close();

            return dt;
        }
    }
}
