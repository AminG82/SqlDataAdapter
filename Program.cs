
using Microsoft.Data.SqlClient;
using System.Data;

SqlConnection connection = new SqlConnection("""
    Data Source =.; Initial Catalog = TestDB; User ID = sa; Password = amin5123; Encrypt = False;
    """);


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

SqlCommand insertData = new SqlCommand("""
         Insert Into Person (Name, Age, Email, NationalCode)
         Values ('Ali', 30, 'ali@gmail.com , '1234567890'),
         ('Sara', 25, 'sara@gmail.com, '0987654321'),
         ('Reza', 28, 'reza@gmail.com, '1122334455')
    """, connection);

//connection.Open();
//int count = (int)command.ExecuteScalar();
//Console.WriteLine($"Number of records in Person table: {count}");
//connection.Close();

DataSet TestDB_DS = new DataSet();
Microsoft.Data.SqlClient.SqlDataAdapter adapter = new Microsoft.Data.SqlClient.SqlDataAdapter("""
    SP_SelectPerson
    """, connection);

adapter.Fill(TestDB_DS, "Person");

foreach (DataRow row in TestDB_DS.Tables["Person"].Rows)
{
    Console.WriteLine($"     Name: {row["Name"]}, Age: {row["Age"]} Email: {row["Email"]} NationalCode {row["NationalCode"]}");
    Console.WriteLine("*************************************************************************************");
}

