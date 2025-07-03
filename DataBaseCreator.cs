using Microsoft.Data.SqlClient;

namespace SqlDataAdapter
{
    public static class DataBaseCreator
    {

        // Use Only Whene Connection is Open!
        static void CreateDatabase(SqlConnection ConnectionString)
        {
            SqlCommand createCommand = new SqlCommand("""
            CREATE TABLE Person (
                Id INT PRIMARY KEY IDENTITY(1,1),
                Name NVARCHAR(100) NOT NULL,
                Age INT NOT NULL
            )
            """, ConnectionString);
            createCommand.ExecuteNonQuery();
        }
        static void CountMethod(SqlConnection ConnectionString)
        {
            SqlCommand countCommand = new SqlCommand("""
            SELECT COUNT(*) FROM Person
            """, ConnectionString);
            Console.WriteLine($"Number of Datas in DB : {countCommand.ExecuteScalar()}");
        }
    }
}
