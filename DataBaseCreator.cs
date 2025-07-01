using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAdapter
{
    public static class DataBaseCreator
    {
        static void CountMethod(SqlConnection ConnectionString)
        {
            SqlCommand countCommand = new SqlCommand("""
            SELECT COUNT(*) FROM Person
            """, ConnectionString);
        }
    }
}
