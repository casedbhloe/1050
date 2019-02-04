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

            System.Console.Write("Hey, you with the teeth... What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("I pity fools named " + firstName + ". What is your middle inital? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("Quit yo jibber-jabber and tell me your last name! ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + " " + lastName;

            System.Console.Write("Ok, " + fullName + " I'm Mr. T and I'm a Night Elf Mohawk. ");
            System.Console.Write("How many feet tall are you " + firstName + " ?");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("Thanks fool. How many inches go with that? ");
            heightInches = int.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

            System.Console.Write(firstName + ", how old are you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? TRUE OR FALSE FOOL ");
            isCitizen = bool.Parse(System.Console.ReadLine());

            if (age < 18)
            {
                canVote = false;
            }
            
            if (age >= 18)
                if (isCitizen = true)
            {
                    canVote = true;
            }
            else
                {
                    canVote = false;
                }

            System.Console.Write(fullName + " " + totalHeightCM + " " + canVote);
        }
    }
}