using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Person person = new Person
        //    {
        //        FullName = "Админович Админ Админов",
        //        Age = 35
        //    };
        //
        //
        //    XmlSerializer formatterXml = new XmlSerializer(typeof(Person));
        //
        //
        //    BinaryFormatter formatter = new BinaryFormatter();
        //    if (!Directory.Exists(@"C:/data"))
        //        Directory.CreateDirectory(@"C:/data");
        //
        //    using(FileStream stream = File.Create(@"C:/data/file.bin"))
        //    {
        //        formatter.Serialize(stream, person);               
        //    }
        //
        //
        //    using (FileStream stream = File.OpenRead(@"C:/data/file.bin"))
        //    {                
        //        var resultPerson = formatter.Deserialize(stream) as Person;
        //    }
        //
        //    // SoapFormatter formatterSoap = new SoapFormatter();
        //
        //
        //
        //
        //    if (!Directory.Exists(@"C:/dataXml"))
        //        Directory.CreateDirectory(@"C:/dataXml");
        //
        //    using (FileStream stream = File.Create(@"C:/dataXml/file.xml"))
        //    {
        //        formatterXml.Serialize(stream, person);
        //    }
        //
        //
        //    using (FileStream stream = File.OpenRead(@"C:/dataXml/file.xml"))
        //    {
        //        var resultPerson = formatterXml.Deserialize(stream) as Person;
        //    }


            // json


            List<Person> people = new List<Person>
            {
                new Person
                {
                    FullName="Admin",
                    Age=35
                },
                new Person
                {
                    FullName="Admin1",
                    Age=35
                },
                new Person
                {
                    FullName="Admin2",
                    Age=35
                }
            };

            var reslutJson = JsonConvert.SerializeObject(people);

            var desirialize = JsonConvert.DeserializeObject<List<Person>>(reslutJson);

        }
    }
}
