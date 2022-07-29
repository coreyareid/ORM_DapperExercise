using ORM_Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
//----------------------Part of Exercise One---------------------------//
// Pulls information from json file
var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();
// Looks at default connection to grab connection string
string connString = config.GetConnectionString("DefaultConnection");
// Used to link to SQL
IDbConnection conn = new MySqlConnection(connString);

//---------------------------Departments-------------------------------//
// Connects to Database
var depa = new DapperDepartmentRepository(conn);
// calls method to see departments in the Database
var departments = depa.GetAllDepartments();
foreach (var department in departments)
{
    Console.WriteLine($"{department.DepartmentID} {department.Name}");
}

//-------------------------Exercise Two--------------------------------//
//---------------------------Products----------------------------------//
Console.WriteLine("\n--------Exercise Two--------");
// connects to Database
var prod = new DapperProductRepository(conn);
// calls method to see all products in the Database
var products = prod.GetAllProducts();
foreach (var product in products)
{
    Console.WriteLine($"{product.Name} --Price: {product.Price}");
}