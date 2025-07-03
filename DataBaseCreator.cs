using Microsoft.Data.SqlClient;

namespace SqlDataAdapter
{
    public static class DataBaseCreator
    {

        // Use Only Whene Connection is Open!

        public static void CreateDatabase(SqlConnection ConnectionString)
        {
            SqlCommand createDBCommand = new SqlCommand("""
            Create Database TestDB
            )
            """, ConnectionString);
            createDBCommand.ExecuteNonQuery();
        }

        public static void CreateTable(SqlConnection ConnectionString)
        {
            SqlCommand createTableCommand = new SqlCommand("""
            Create Table Person
            (
                Id int identity(1,1) primary key,
                Name nvarchar(50) not null,
                Age int not null,
                Email nvarchar(50) not null,
                NationalCode nvarchar(10) not null
            )
            """, ConnectionString);
            createTableCommand.ExecuteNonQuery();
        }

        public static void InsertData(SqlConnection ConnectionString)
        {
            SqlCommand insertDataCommand = new SqlCommand("""
            Insert Into Person (Name, Age, Email, NationalCode)
            Values ('Ali', 30, 'ali@gmail.com , '1234567890'),
            ('Sara', 25, 'sara@gmail.com, '0987654321'),
            ('Reza', 28, 'reza@gmail.com, '1122334455') 
            """, ConnectionString);
            insertDataCommand.ExecuteNonQuery();
        }
        public static void CountMethod(SqlConnection ConnectionString)
        {
            SqlCommand countCommand = new SqlCommand("""
            SELECT COUNT(*) FROM Person
            """, ConnectionString);
            Console.WriteLine($"Number of Datas in DB : {countCommand.ExecuteScalar()}");
        }
    }
}
