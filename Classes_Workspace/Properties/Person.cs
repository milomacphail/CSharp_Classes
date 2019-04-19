using System;
namespace Classes_Workspace
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName " " + LastName);
        }

    }
}
