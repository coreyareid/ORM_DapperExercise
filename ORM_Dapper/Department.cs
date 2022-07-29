using System;
namespace ORM_Dapper
{
    public class Department
    {
        // Default Constructor
        public Department(){}

        // Properties which represents columns of the Department table
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }
}

