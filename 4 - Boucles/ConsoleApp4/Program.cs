using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Choice();
        }

        // Choix de l'exercice
        public static void Choice()
        {
            Console.WriteLine("indiquer l'excercice que vous voulez ouvrir :");
            Console.WriteLine("Exercice 1 à 8");
            string value = Console.ReadLine();
            int.TryParse(value, out int exo);
            if (exo >= 1 && exo <= 8)
            {
                switch (exo)
                {
                    case 1:
                        Exo1();
                        break;
                    case 2:
                        Exo2();
                        break;
                    case 3:
                        Exo3();
                        break;
                    case 4:
                        Exo4();
                        break;
                    case 5:
                        Exo5();
                        break;
                    case 6:
                        Exo6();
                        break;
                    case 7:
                        Exo7();
                        break;
                    case 8:
                        Exo8();
                        break;
                    default:
                        Console.WriteLine("Erreur");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Erreur");
            }
            Exit();
        }

        // Quitter la console
        public static void Exit()
        {
            Console.WriteLine("\nVoulez-vous quitter ? (y/n)");
            string exit = Console.ReadLine();
            if (exit == "y")
            {
                Environment.Exit(0);
            }
            else if (exit == "n")
            {
                Choice();
            }
            else
            {
                Console.WriteLine("Erreur, merci de recommencer");
                Exit();
            }
        }

        public static void Exo1()
        {
            Console.WriteLine("A l'aide de l'instruction while, faire en sorte d'afficher 10 fois le message suivant dans la console :");
            Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            int i = 0;
            while (i < 9)
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                i++;
            }
        }

        public static void Exo2()
        {
            Console.WriteLine("A l'aide de l'instruction while, faire en sorte d'afficher 10 fois le message suivant dans la console :");
            Console.WriteLine("Bonjour, je suis le message n°1.");
            Console.WriteLine("Bonjour, je suis le message n°2.");
            Console.WriteLine("Bonjour, je suis le message n°3.");
            Console.WriteLine("etc...");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Bonjour, je suis le message n°" + i);
                i++;
            }
        }

        public static void Exo3()
        {
            Console.WriteLine("A l'aide de l'instruction for, faire en sorte d'afficher 10 fois le message suivant dans la console :");
            Console.WriteLine("Bonjour, je suis un message généré à l'aide d'une boucle.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Bonjour, je suis un message généré à l'aide d'une boucle.");
            }
        }

        public static void Exo4()
        {
            Console.WriteLine("A l'aide de l'instruction for, faire en sorte d'afficher un décompte en partant de 10. Ex.");
            Console.WriteLine("10");
            Console.WriteLine("9");
            Console.WriteLine("8");
            Console.WriteLine("etc...");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            int i;
            for (i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Exo5()
        {
            Console.WriteLine("Créer un tableau 'week' contenant les jours de la semaine : Lundi, Mardi, Mercredi...");
            Console.WriteLine("A l’aide d'une boucle while ou for, faire en sorte d'afficher les éléments du tableau week dans la console:");
            Console.WriteLine("Lundi");
            Console.WriteLine("Mardi");
            Console.WriteLine("Mercredi");
            Console.WriteLine("etc ...");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }
        }

        public static void Exo6()
        {
            Console.WriteLine("Créer un tableau 'months' contenant les 12 mois de l'année : Janvier, Février, Mars ...");
            Console.WriteLine("A l'aide d'une boucle foreach, faire en sorte d'afficher les éléments du tableau months dans la console :");
            Console.WriteLine("Janvier");
            Console.WriteLine("Février");
            Console.WriteLine("Mars");
            Console.WriteLine("etc ...");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            string[] months = new string[] { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };
            foreach (string month in months)
            {
                Console.WriteLine(month);
            }
        }

        public static void Exo7()
        {
            Console.WriteLine("Créer un tableau 'numbers' contenant des chiffres de 1 jusqu'à 20 : 1, 2, 3, 4, 5 ...");
            Console.WriteLine("A l'aide d'une boucle, faire en sorte d'afficher uniquement les 10 premiers chiffres du tableau 'numbers'.");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("etc...");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void Exo8()
        {
            Console.WriteLine("Créer un tableau 'pairs' contenant des chiffres de 1 jusqu'à 20 : 1, 2, 3, 4, 5 ...");
            Console.WriteLine("A l'aide d'une boucle, faire en sorte d'afficher uniquement les chiffres pairs du tableau 'pairs'.");
            Console.WriteLine("2");
            Console.WriteLine("4");
            Console.WriteLine("6");
            Console.WriteLine("etc...");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            int[] pairs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine(pairs[i]);
            }
        }
    }
}