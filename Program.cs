
using Microsoft.Data.SqlClient;

SqlConnection connection = new SqlConnection("""
    Data Source=.;Initial Catalog=TestDB;User ID=sa;Encrypt=FalseData Source=.;
    Initial Catalog=TestDB;User ID=sa;Encrypt=False
    """);


SqlCommand command = new SqlCommand("""
    SELECT COUNT(*) FROM Person
    """, connection);

connection.Open();
int count = (int)command.ExecuteScalar();
connection.Close();


