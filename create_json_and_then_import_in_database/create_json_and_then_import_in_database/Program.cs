using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
//using System.Web.Script.Serialization;
namespace create_json_obeject_serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            test2 _test = new test2();
            string result = JsonConvert.SerializeObject(_test);
            string path = @"C:\Users\chandni1\Desktop\test2.json";

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

            Console.WriteLine("data is saved");
            Console.Read();
        }





    }
}

