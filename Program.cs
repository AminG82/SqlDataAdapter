
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

SqlConnection connection = new SqlConnection("""
    Data Source =.; Initial Catalog = TestDB; User ID = sa; Password = amin5123; Encrypt = False;
    """);


SqlCommand countCommand = new SqlCommand("""
    SELECT COUNT(*) FROM Person
    """, connection);

SqlCommand createDataBase = new SqlCommand("""
    Create Database TestDB
    """, connection);

SqlCommand createTable = new SqlCommand("""
    Create Table Person
    (
        Id int identity(1,1) primary key,
        Name nvarchar(50) not null,
        Age int not null,
        Email nvarchar(50) not null,
        NationalCode nvarchar(10) not null
    )
    """, connection);

//connection.Open();
//int count = (int)command.ExecuteScalar();
//Console.WriteLine($"Number of records in Person table: {count}");
//connection.Close();

DataSet TestDB_DS = new DataSet();
SqlDataAdapter adapter = new SqlDataAdapter("""
    SP_SelectPerson
    """, connection);

adapter.Fill(TestDB_DS, "Person");

foreach (DataRow row in TestDB_DS.Tables["Person"].Rows)
{
    Console.WriteLine($"     Name: {row["Name"]}, Age: {row["Age"]} Email: {row["Email"]} NationalCode {row["NationalCode"]}");
    Console.WriteLine("*************************************************************************************");
}

