using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serialization
{
    //[Serializable]

        
    public class Person
    {
       [JsonProperty("name")]
        public string FullName { get; set; }

       [JsonIgnore]
        public int Age { get; set; }
    }
}
