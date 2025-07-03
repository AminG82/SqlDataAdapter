
using Microsoft.Data.SqlClient;
using SqlDataAdapter;
using System.Data;

SqlConnection connection = new SqlConnection("""
    Data Source =.; Initial Catalog = TestDB; User ID = sa; Password = amin5123; Encrypt = False;
    """);

connection.Open();
 DataBaseCreator.CreateDatabase(connection);        // Create DataBase

DataBaseCreator.CreateTable(connection);            // Create Table

DataBaseCreator.InsertData(connection);             // Insert Data to the Table

DataBaseCreator.CountMethod(connection);            // Count Datas in table

connection.Close();

/*          //uncomment the following lines to create DataSet And use DataAdapter

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

*/
