using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Program();
            test.Choice();
        }

        // Choix de l'exercice
        public void Choice()
        {
            var test = new Program();
            Console.WriteLine("indiquer l'excercice que vous voulez ouvrir :");
            Console.WriteLine("Exercice 1 à 8");
            string value = Console.ReadLine();
            int.TryParse(value, out int exo);
            if (exo >= 1 && exo <= 8)
            {
                switch (exo)
                {
                    case 1:
                        test.Exo1();
                        break;
                    case 2:
                        test.Exo2();
                        break;
                    case 3:
                        test.Exo3();
                        break;
                    case 4:
                        test.Exo4();
                        break;
                    case 5:
                        test.Exo5();
                        break;
                    case 6:
                        test.Exo6();
                        break;
                    case 7:
                        test.Exo7();
                        break;
                    case 8:
                        test.Exo8();
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
            test.Exit();
        }

        // Quitter la console
        public void Exit()
        {
            var test = new Program();
            Console.WriteLine("\nVoulez-vous quitter ? (y/n)");
            string exit = Console.ReadLine();
            if (exit == "y")
            {
                Environment.Exit(0);
            }
            else if (exit == "n")
            {
                test.Choice();
            }
            else
            {
                Console.WriteLine("Erreur, merci de recommencer");
                test.Exit();
            }
        }

        public void Exo1()
        {
            Console.WriteLine("Exercice 1");
            Console.WriteLine("Créer un tableau « week » contenant les jours suivant :");
            Console.WriteLine("Lundi");
            Console.WriteLine("Mardi");
            Console.WriteLine("Mercredi");
            Console.WriteLine("Jeudi");
            Console.WriteLine("Vendredi");
            Console.WriteLine("Samedi");
            Console.WriteLine("Dimanche");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
        }

        public void Exo2()
        {
            Console.WriteLine("Exercice 2");
            Console.WriteLine("Créer un tableau « week » contenant les jours suivant :");
            Console.WriteLine("Lundi");
            Console.WriteLine("Mardi");
            Console.WriteLine("Mercredi");
            Console.WriteLine("Jeudi");
            Console.WriteLine("Vendredi");
            Console.WriteLine("Samedi");
            Console.WriteLine("Dimanche");
            Console.WriteLine("Afficher le contenu de l’indice 1 et 4 du tableau dans la console sur 2 lignes différentes.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };
            Console.WriteLine(week[1]);
            Console.WriteLine(week[4]);
        }

        public void Exo3()
        {
            Console.WriteLine("Exercice 3");
            Console.WriteLine("Créer un tableau « week » contenant les jours suivant :");
            Console.WriteLine("Lundi");
            Console.WriteLine("Mardi");
            Console.WriteLine("Mercredi");
            Console.WriteLine("Jeudi");
            Console.WriteLine("Jeudi");
            Console.WriteLine("Samedi");
            Console.WriteLine("Dimanche");
            Console.WriteLine("Afficher le tableau dans la console(sans utiliser de boucle).");
            Console.WriteLine("Remplacer la 2ème valeur « Jeudi » par la valeur suivante : « Vendredi ».");
            Console.WriteLine("Afficher le tableau modifié dans la console(sans utiliser de boucle).");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jeudi", "Jeudi", "Samedi", "Dimanche" };
            Console.WriteLine(week[0]);
            Console.WriteLine(week[1]);
            Console.WriteLine(week[2]);
            Console.WriteLine(week[3]);
            Console.WriteLine(week[4]);
            Console.WriteLine(week[5]);
            Console.WriteLine(week[6]);
            week[4] = "Vendredi";
            Console.WriteLine("\n");
            Console.WriteLine(week[0]);
            Console.WriteLine(week[1]);
            Console.WriteLine(week[2]);
            Console.WriteLine(week[3]);
            Console.WriteLine(week[4]);
            Console.WriteLine(week[5]);
            Console.WriteLine(week[6]);
        }

        public void Exo4()
        {
            Console.WriteLine("Exercice 4");
            Console.WriteLine("Créer une liste « shopping » contenant les éléments suivants :");
            Console.WriteLine("Carottes");
            Console.WriteLine("Oignons");
            Console.WriteLine("Pommes de terre");
            Console.WriteLine("Salade");
            Console.WriteLine("Tomate");
            Console.WriteLine("Afficher le 3ème élément de la liste.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            List<string> shopping = new List<string> { "Carottes", "Oignons", "Pommes de terre", "Salade", "Tomate" };
            Console.WriteLine(shopping[2]);
        }

        public void Exo5()
        {
            Console.WriteLine("Exercice 5");
            Console.WriteLine("Créer une liste « numbers » contenant les éléments suivants :");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("Afficher la liste dans la console(sans utiliser de boucle).");
            Console.WriteLine("Rajouter l’élément « 1 » en tête de liste, puis rajouter « 7 » en fin de liste.");
            Console.WriteLine("Afficher la liste modifiée dans la console(sans utiliser de boucle).");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            var numbers = new List<int> { 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            numbers.Insert(0, 1);
            numbers.Add(7);
            Console.WriteLine("\n");
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);
        }

        // Enumération pour les exercices 6, 7 et 8
        enum week
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        enum weekModif
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }

        public void Exo6()
        {
            Console.WriteLine("Exercice 6");
            Console.WriteLine("Créer une énumération « week » contenant les éléments suivants :");
            Console.WriteLine("Lundi");
            Console.WriteLine("Mardi");
            Console.WriteLine("Mercredi");
            Console.WriteLine("Jeudi");
            Console.WriteLine("Vendredi");
            Console.WriteLine("Samedi");
            Console.WriteLine("Dimanche");
            Console.WriteLine("Afficher tous les éléments de « week » dans la console(sans utiliser de boucle).");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine(week.Lundi);
            Console.WriteLine(week.Mardi);
            Console.WriteLine(week.Mercredi);
            Console.WriteLine(week.Jeudi);
            Console.WriteLine(week.Vendredi);
            Console.WriteLine(week.Samedi);
            Console.WriteLine(week.Dimanche);
        }

        public void Exo7()
        {
            Console.WriteLine("Exercice 7");
            Console.WriteLine("Créer une énumération « week » contenant les éléments suivants :");
            Console.WriteLine("Lundi");
            Console.WriteLine("Mardi");
            Console.WriteLine("Mercredi");
            Console.WriteLine("Jeudi");
            Console.WriteLine("Vendredi");
            Console.WriteLine("Samedi");
            Console.WriteLine("Dimanche");
            Console.WriteLine("Afficher tous les éléments de « week » dans la console(sans utiliser de boucle).");
            Console.WriteLine("Dans une nouvelle ligne, afficher la valeur 4 de l’énumération « week ».");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine(week.Lundi);
            Console.WriteLine(week.Mardi);
            Console.WriteLine(week.Mercredi);
            Console.WriteLine(week.Jeudi);
            Console.WriteLine(week.Vendredi);
            Console.WriteLine(week.Samedi);
            Console.WriteLine(week.Dimanche);
            Console.WriteLine(Enum.GetName(typeof(week), 4));
        }

        public void Exo8()
        {
            Console.WriteLine("Exercice 8");
            Console.WriteLine("Créer une énumération « week » contenant les éléments suivants :");
            Console.WriteLine("Lundi");
            Console.WriteLine("Mardi");
            Console.WriteLine("Mercredi");
            Console.WriteLine("Jeudi");
            Console.WriteLine("Vendredi");
            Console.WriteLine("Samedi");
            Console.WriteLine("Dimanche");
            Console.WriteLine("Modifier la valeur de « lundi » par 1.");
            Console.WriteLine("Afficher la valeur 4 de l’énumération « week ».");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine(Enum.GetName(typeof(weekModif), 4));

        }
    }
}
