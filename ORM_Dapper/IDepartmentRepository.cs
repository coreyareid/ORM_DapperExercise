﻿using System;
using System.Collections.Generic;
namespace ORM_Dapper
{

    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAllDepartments();
    }
}

