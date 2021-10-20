using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CarDBexample
{
    public class CarFactory
    {
        SqlConnection connection = null;
        SqlCommand cmd = null;

        connection = new SqlConnection(@"");

        public void AddCar(Car carToAdd)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }


            string insertQuery = "inset into car (engine, numberplate, model) values (@engine, @numberplate"
        }
    }
}
