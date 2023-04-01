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
    public class PharmacyRepository : QueryRepository, IPharmacyRepository
    {
        public DataTable GetMedicineFromNationalCode(string procedureName, int NationalCode)
        {
            var dt = new DataTable();
            var cmd = new SqlCommand(procedureName, sqlConnection);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NationalCode" , NationalCode);


            sqlConnection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);

            sqlConnection.Close();
            return dt;

        }

        public void Add(Patient patient)
        {
            var cmd = new SqlCommand("Usp_Patient_Add", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", patient.Name);
            cmd.Parameters.AddWithValue("@Family", patient.Family);
            cmd.Parameters.AddWithValue("@BirthDate", patient.BirthDate);
            cmd.Parameters.AddWithValue("@NationalCode", patient.NationalCode);
            cmd.Parameters.AddWithValue("@Gender", patient.Gender);


            sqlConnection.Open();

            cmd.ExecuteNonQuery();

            sqlConnection.Close();

        }
    }
}
