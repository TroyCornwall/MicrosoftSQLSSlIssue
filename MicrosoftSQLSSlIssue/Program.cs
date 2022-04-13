using Microsoft.Data.SqlClient;

//docker build -f Dockerfile -t sqlissue . && docker run sqlissue <dbname>

var server =  "test";
var catalog = "dbo";
var user = "sqlserveradmin";
var password = "";


if (args.Length < 4)
{
    Console.WriteLine(
        $"Please run with the following command\n docker run <server-name> <db catalog> <username> <password>");
    throw new Exception("Missing parameters");
}

server = args[0];
catalog = args[1];
user = args[2];
password = args[3];


Console.WriteLine($"Connecting to {server}.database.windows.net...");

string connectionString = $"Server=tcp:{server}.database.windows.net,1433;Initial Catalog={catalog};Persist Security Info=False;User ID={user};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

using var connection = new SqlConnection(connectionString);
await connection.OpenAsync();

Console.WriteLine("Connected!");