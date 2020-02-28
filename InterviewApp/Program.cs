using System;
using InterviewApp.Services;

namespace InterviewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDivisibleNumberService service = new DivisibleNumberService();

            service.AddPair(3, "fizz");
            service.AddPair(5, "buzz");

            var values = service.GetAllValues(int.MaxValue);

            foreach(var value in values)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();

        }
    }
}
