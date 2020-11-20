using System;

namespace Net12FinalExam
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPerson[] array = new IPerson[]
            {
                new Adult()
                { FirstName = "Haritha", LastName = "M" },
                new Child()
                { FirstName = "Ishaan", LastName = "K" }
            };

            foreach (IPerson item in array)
            {
                Console.WriteLine("First Name: " + item.FirstName + ", Last Name: " + item.LastName);
            }
        }
    }
}
