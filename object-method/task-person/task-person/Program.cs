using System;

namespace task_person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personJouni = new Person();
            personJouni.Name = "Jouni K";
            personJouni.GrowOld();
            Console.WriteLine($"Jounin ikä: {personJouni.GetAge()}");

            personJouni.GrowOld(500);
            personJouni.PrintPersonInfo();
            

            Person newPerson = new Person("Joe Doe", 17);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();
        }
    }
}
