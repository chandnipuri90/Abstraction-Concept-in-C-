using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace create_json_obeject_serialization
{
    class Program 
     {      
          static void Main(string[] args)
          {               
            employee emp = new employee();
            List<UnitProject> empPrj = new List<UnitProject>();
            List<ProjectType> lprj = new List<ProjectType>();
          
      
            emp.empid = 123;
            emp.empname = "Chandni Puri";
            emp.EmployeeUnits.Add(new employeeUnit() { unitName = "Test", description = "TestDescription"  ,unitDescription="TestUnitDescription" , UnitProjects = empPrj  });
            emp.EmployeeUnits.Add(new employeeUnit() { unitName = "Test1", description = "TestDescription1",unitDescription="TestUnitDescription1" ,UnitProjects = empPrj });
            emp.EmployeeUnits.Add(new employeeUnit() { unitName = "Test2", description = "TestDescription2",unitDescription="TestUnitDescription2", UnitProjects = empPrj });
            emp.EmployeeUnits.Add(new employeeUnit() { unitName = "Test3", description = "TestDescription2", unitDescription = "TestUnitDescription2", UnitProjects = empPrj });


            empPrj.Add(new UnitProject() { projectName = "AssetMark", projectTenure = "2Years", prjtyp = lprj });
            empPrj.Add(new UnitProject() { projectName = "Cambridge", projectTenure = "3Years", prjtyp = lprj });
            empPrj.Add(new UnitProject() { projectName = "Perforce", projectTenure = "4Years", prjtyp = lprj });


            lprj.Add(new ProjectType() { ProjectName = "ghg", ProjectTypeId = 345 });
            lprj.Add(new ProjectType() { ProjectName = "ghg", ProjectTypeId = 345 });
            lprj.Add(new ProjectType() { ProjectName = "ghg", ProjectTypeId = 345 });

           
           
            string path = @"C:\Users\chandni1\Desktop\test2.json";

            ProcessEmployee(emp, path);

            Console.WriteLine("data is saved");
            Console.Read();
        }

        private static void ProcessEmployee(employee emp, string path)
        {
            string result = JsonConvert.SerializeObject(emp);
            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(result.ToString());
                    tw.Close();

                }
            }
            else if (!File.Exists(path))

                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(result.ToString());
                    tw.Close();

                }
        }
    }
}

