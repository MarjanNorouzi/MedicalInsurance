using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalInsurance.InfraStructrue.ConnectionStrings;

namespace MedicalInsurance.InfraStructrue.Repositories
{
    public class QueryRepository
    {
        protected SqlConnection sqlConnection;

        public QueryRepository()
        {
            sqlConnection = new SqlConnection(ConnectionString.InsuranceConnectionString);
        }
    }
}
