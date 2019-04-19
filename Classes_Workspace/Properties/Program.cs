using System;

namespace Classes_Workspace
{
    class Solution
    {
        static void Main(String[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();
        }
    }
}