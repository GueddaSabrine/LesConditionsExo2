using System;

namespace LesConditionsExo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //À l’aide de la console, inviter l’utilisateur à renseigner son âge.
            //Dans la console, selon son âge, afficher un des messages suivants:
            //« Vous avez … ans, vous êtes donc majeur.e. »
            //« Vous avez … ans, vous êtes donc mineur.e. »

            Console.WriteLine("Entrez votre age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine(" Vous avez " + age + " ans, vous êtes donc majeur.e.");
            }
            else
            {
                Console.WriteLine("Vous avez " + age + "ans, vous êtes donc mineur.e.");
            }
        }
    }
}
