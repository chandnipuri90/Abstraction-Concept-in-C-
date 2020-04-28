using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_json_obeject_serialization
{
    class UnitProject
    {
        public UnitProject()
        {

            prjtyp = new List<ProjectType>();
        }

        public string projectName { get; set; }
        public string projectTenure { get; set; }
        public List<ProjectType> prjtyp {get; set;}

    }
}
