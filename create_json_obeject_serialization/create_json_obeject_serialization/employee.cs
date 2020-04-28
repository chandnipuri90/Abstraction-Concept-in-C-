using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_json_obeject_serialization
{
    class employee
    {
        public employee()
        {
           // EmployeeUnits = new List<employeeUnit>();
        }

        public int empid { get; set; }
        public string empname { get; set; }
        public List<employeeUnit> EmployeeUnits { get; set; }

    }
}