using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_json_obeject_serialization
{
    class employeeUnit
    {
        public employeeUnit()
        {
            UnitProjects = new List<UnitProject>();
        }

        public string unitName { get; set; }
        public string description { get; set; }
        public DateTime unitJoiningDate { get; set; }
        public string unitDescription { get; set; }
        public List<UnitProject> UnitProjects { get; set; }

    }
}
