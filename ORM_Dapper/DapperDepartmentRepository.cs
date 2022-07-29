using System;
using System.Data;
using System.Collections.Generic;
using Dapper;

namespace ORM_Dapper
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        // Constructor used to store passed data into the connection field
        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        // Stores Database data to Department collection
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments;");
        }
    }
}

