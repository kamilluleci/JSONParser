using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONParser
{
    /*    
        {
        "firstname":"Roger",
        "lastname":"Moore",
        "age":89,
        "isAlive":false,    
            "address":{
                "streetAddress":"1 Main Street",
                "city":"London",
                "postcode":"N1 3XX"
            },
            "phoneNumbers":
            [
                {"type":"home",   "number":"+61 03 333 3444 2220"},
                {"type":"mobile", "number":"+61 0244 44 220"}
            ]
        } 
    */
    class jsonPersonArray:jsonPersonComplex
    {
        /*
        public string firstname { get; set; }
        public string lastname { get; set; }
        public double age { get; set; }
        public bool isAlive { get; set; }
        public addr address { get; set; }
        */

        public List<phoneNum> phoneNumbers { get; set; }
        
        /*
        public class addr
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string postcode { get; set; }
        }
        */
        public class phoneNum
        {
            public string type { get; set; }
            public string number { get; set; }            
        }

    }
}
