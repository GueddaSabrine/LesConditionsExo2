using System;

namespace LesConditionsExo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine(" Vous avez " + age + " ans, vous êtes donc majeur.e.");
            }
            else
            {
                Console.WriteLine("Vous avez" + age + "ans, vous êtes donc mineur.e.");
            }
        }
    }
}
