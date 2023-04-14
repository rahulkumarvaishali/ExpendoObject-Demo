using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ExpendoObject_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<String, object> dict = new Dictionary<string, object>();
            //Dictionary<String, object> address = new Dictionary<string, object>();
            //dict["Address"] = address;
            //address["State"] = "WA";
            //Console.WriteLine(((Dictionary<string, object>)dict["Address"])["State"]);

            //dynamic expando = new ExpandoObject();
            //expando.Address = new ExpandoObject();
            //expando.Address.State = "WA";
            //Console.WriteLine(expando.Address.State);

            dynamic person = new ExpandoObject();
            person.FirstName = "Dino";
            person.LastName = "Esposito";

            person.GetFullName = (Func<String>)(() => {
                return String.Format("{0}, {1}",
                  person.LastName, person.FirstName);
            });

            var name = person.GetFullName();
            Console.WriteLine(name);


            //var expando = new ExpandoObject() as IDictionary<string, object>;


            //foreach (DataColumn col in self.Columns)
            //{
            //    if (row != null)
            //    {
            //        expando.Add(col.ColumnName, row[col.ColumnName]);
            //    }
            //    else
            //    {
            //        expando.Add(col.ColumnName, "");
            //    }
            //}
            //return expando;
        }
    }
}
