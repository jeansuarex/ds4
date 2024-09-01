using System;

namespace Laboratorio_2
{
    internal class VarInstaciaFullName
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Jean";
            client.LastName = "Suarez";
            client.Age = 20;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }

    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
