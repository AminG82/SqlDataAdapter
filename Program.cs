
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

SqlConnection connection = new SqlConnection("""
    Data Source =.; Initial Catalog = TestDB; User ID = sa; Password = amin5123; Encrypt = False;
    """);


SqlCommand command = new SqlCommand("""
    SELECT COUNT(*) FROM Person
    """, connection);

connection.Open();
int count = (int)command.ExecuteScalar();
Console.WriteLine($"Number of records in Person table: {count}");
connection.Close();


