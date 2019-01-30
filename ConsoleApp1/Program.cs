using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.Write("Hey, you with the teeth... What is your first name?" );
            firstName = System.Console.ReadLine();

            System.Console.Write("I pity fools named " + firstName + "What is your middle inital?");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("Quit yo jibber-jabber and tell me your last name!");
            lastName = System.Console.ReadLine();

            fullName = firstName + middleInitial + lastName;

            System.Console.Write("Ok, " + fullName + "I'm Mr. T and I'm a Night Elf Mohawk");

        }
    }
}