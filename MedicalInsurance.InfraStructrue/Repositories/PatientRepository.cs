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
    public class PatientRepository : QueryRepository, IPatientRepository
    {
        public void Add(Patient patient)
        {
            var cmd = new SqlCommand("Usp_Patient_Add", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", patient.Name);
            cmd.Parameters.AddWithValue("@Family", patient.Family);
            cmd.Parameters.AddWithValue("@BirthDate", DateTime.Now.ToString());
            cmd.Parameters.AddWithValue("@NationalCode", patient.NationalCode);
            cmd.Parameters.AddWithValue("@Gender", patient.Gender);


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

        public DataTable GetByNationalCode(string nationalCode)
        {
            var dt = new DataTable();

            var cmd = new SqlCommand("Usp_Patient_GetByNationalCode", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NationalCode", nationalCode);

            sqlConnection.Open();

            SqlDataReader? reader = cmd.ExecuteReader();
            dt.Load(reader);

            sqlConnection.Close();

            return dt;
        }
    }
}
