using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_json_obeject_serialization
{
    public class Response
    {
        public Dictionary<string, Info> Items { get; set; }
    }

    public class Info
    {
        public string prop1 { get; set; }
        public string prop2 { get; set; }
        public int  prop3 { get; set; }
        // Modified from 
        //public Dictionary<string, List<int>> prop4 {get;set}
        public List<Dictionary<string, int>> prop4 { get; set; }
    }
}
