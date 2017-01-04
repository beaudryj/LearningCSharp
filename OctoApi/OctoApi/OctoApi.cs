using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoApi
{
    class OctoApi
    {
        public static void Main(string[] args)
        {


            Program Octopus = new Program();

            Console.WriteLine("Methods to use");

            foreach (HttpVerb VerbList in Enum.GetValues(typeof(HttpVerb)))
            {
                Console.WriteLine(VerbList);
            }

            Console.WriteLine("Choose Method");
            string Method = Console.ReadLine();

            Method = Method.ToUpper();

            HttpVerb methodUsed = (HttpVerb)Enum.Parse(typeof(HttpVerb), Method);

            Console.WriteLine("Url to call against");
            string Host = Console.ReadLine();

            Octopus.Method = methodUsed;
            Octopus.EndPoint = Host;
            Octopus.ContentType = "application/json";
            Octopus.ApiKey = "";

            
            var Request = Octopus.MakeRequest();

            Console.WriteLine(Request);

            Console.ReadLine();




        }
    }
}
