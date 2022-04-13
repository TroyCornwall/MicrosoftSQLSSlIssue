using Microsoft.Data.SqlClient;

//docker build -f Dockerfile -t sqlissue . && docker run sqlissue <dbname>

var server =  "test";
if (args.Length > 0)
{
    server = args[0];
}

Console.WriteLine($"Connecting to {server}.database.windows.net...");

string connectionString = $"Server=tcp:${server}.database.windows.net,1433;Initial Catalog=dbo;";

using var connection = new SqlConnection(connectionString);
await connection.OpenAsync();

Console.WriteLine("Connected!");