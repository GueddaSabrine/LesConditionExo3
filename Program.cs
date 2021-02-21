using System;

namespace LesConditionExo3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///À l’aide de la console, inviter l’utilisateur à renseigner son âge et son sexe.
            /// Dans la console, selon les informations renseignées, afficher un des messages suivants :
            ///« Vous êtes un homme et vous êtes majeur. »
            ///« Vous êtes un homme et vous êtes mineur. »
            ///« Vous êtes une femme et vous êtes majeure. »
            ///« Vous êtes une femme et vous êtes mineure. »
            ///

            Console.WriteLine("Entrez votre âge : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez votre sexe : ");
            string sexe = Console.ReadLine().ToLowerInvariant();

            if (age >= 18 && sexe == "h")
            {
                Console.WriteLine(" Vous êtes un homme et vous êtes majeur.");
            }
            else if ((age >= 18 && sexe == "f"))
            {
                Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            }
            else if ((age <= 18 && sexe == "h"))
            {
                Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            }
            else if ((age <= 18 && sexe == "f"))
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
            }
        }
    }
}
