using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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
            Console.WriteLine("Exercice 1 à 6");
            string value = Console.ReadLine();
            int.TryParse(value, out int exo);
            if (exo >= 1 && exo <= 6)
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
            Console.WriteLine("Exercice 1");
            Console.WriteLine("Créer une variable rainy, puis lui attribuer une valeur booléenne: vrai ou faux.");
            Console.WriteLine("Dans la console, selon la valeur de rainy, afficher un des messages suivants:");
            Console.WriteLine("« Bonjour, il ne pleut pas aujourd’hui, bonne journée. »");
            Console.WriteLine("« Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie. »");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            bool rainy = true;
            if (rainy)
            {
                Console.WriteLine("Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie.");
            }
            else
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd’hui, bonne journée.");
            }

        }

        public static void Exo2()
        {
            Console.WriteLine("Exercice 2");
            Console.WriteLine("A l’aide de la console, inviter l’utilisateur à renseigner son âge.");
            Console.WriteLine("Dans la console, selon son âge, afficher un des messages suivants:");
            Console.WriteLine("« Vous avez … ans, vous êtes donc majeur. »");
            Console.WriteLine("« Vous avez … ans, vous êtes donc mineur. »");
            Console.WriteLine("Prendre en compte l’âge de la majorité en France.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("Veuillez saisir votre âge");
            string value = Console.ReadLine();
            int.TryParse(value, out int age);
            if (age >= 18)
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
            }
            else
            {
                Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
            }
        }

        public static void Exo3()
        {
            Console.WriteLine("Exercice 3");
            Console.WriteLine("A l’aide de la console, inviter l’utilisateur à renseigner son âge et son sexe(homme ou femme).");
            Console.WriteLine("Dans la console, selon les informations renseignées, afficher un des messages suivants :");
            Console.WriteLine("« Vous êtes un homme et vous êtes majeur. »");
            Console.WriteLine("« Vous êtes un homme et vous êtes mineur. »");
            Console.WriteLine("« Vous êtes une femme et vous êtes majeure. »");
            Console.WriteLine("« Vous êtes une femme et vous êtes mineure. »");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("Veuillez saisir votre âge");
            string value = Console.ReadLine();
            int.TryParse(value, out int age);
            Console.WriteLine("Veuillez saisir votre sexe 'homme' ou 'femme'");
            string gender = Console.ReadLine();
            if (gender == "homme")
            {
                if (age >= 18)
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
                }
                else
                {
                    Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
                }
            }
            else if (gender == "femme")
            {
                if (age >= 18)
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
                }
                else
                {
                    Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
                }
            }
            else
            {
                Console.WriteLine("Erreur");
            }

        }

        public static void Exo4()
        {
            Console.WriteLine("Exercice 4");
            Console.WriteLine("Créer 2 variables: login et password, et leurs attribuer une valeur.");
            Console.WriteLine("A l’aide de la console, inviter l’utilisateur à renseigner un identifiant et un mot de passe.");
            Console.WriteLine("Dans la console, selon les informations renseignées, afficher un des messages suivants :");
            Console.WriteLine("« Mauvais identifiant ou mauvais mot de passe. »");
            Console.WriteLine("« Bienvenue à la Manu le Havre. »");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            string login = "fabien";
            string password = "azerty123";
            Console.WriteLine("Veuillez saisir votre identifiant");
            string value1 = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre mot de passe");
            string value2 = Console.ReadLine();
            if (login == value1 && password == value2)
            {
                Console.WriteLine("Bienvenue à la Manu le Havre.");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }

        }

        public static void Exo5()
        {
            Console.WriteLine("Exercice 5");
            Console.WriteLine("Créer le tableau 'fujita' suivant:");
            Console.WriteLine("Type Dégâts");
            Console.WriteLine("F0 Dégâts légers: certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres.");
            Console.WriteLine("F1 Dégâts modérés: les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés.");
            Console.WriteLine("F2 Dégâts importants: les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées.");
            Console.WriteLine("F3 Dégâts considérables: les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts");
            Console.WriteLine("F4 Dégâts dévastateurs: même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances.");
            Console.WriteLine("F5 Dégâts incroyables: les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits(parfois surnommé « le doigt de Dieu ».");
            Console.WriteLine("A l’aide de la console, inviter l’utilisateur à renseigner le type d’une tornade.");
            Console.WriteLine("Dans la console, selon le type renseigné, afficher la description des dégâts causés par le type de tornade à l’aide du tableau fujita préalablement créé.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            string[,] fujita = new string[,]
            {
                { "F0", "Dégâts légers: certains dommages sont subis par les cheminées, les antennes de télévision, les bardeaux, les arbres, les enseignes et les fenêtres." },
                { "F1", "Dégâts modérés: les automobiles sont renversées, les abris pour automobiles détruits et les arbres déracinés." },
                { "F2", "Dégâts importants: les toits sont arrachés par le vent, les hangars et les dépendances sont démolies et les maisons mobiles sont renversées." },
                { "F3", "Dégâts considérables: les murs extérieurs et les toits sont projetés dans les airs, les maisons et les bâtiments de métal s'effondrent ou subissent des dégâts" },
                { "F4", "Dégâts dévastateurs: même dans les habitations solides, l'essentiel des murs, sinon tous, s'effondrent; tels des missiles, de gros objets en acier ou en béton sont projetés à grandes distances." },
                { "F5", "Dégâts incroyables: les maisons sont rasées ou projetées sur de grandes distances. Les tornades F5 peuvent causer des dommages très importants à de grosses structures telles que les écoles et les motels et peuvent arracher les murs extérieurs et les toits(parfois surnommé « le doigt de Dieu »." }
            };
            Console.WriteLine("Veuillez saisir le type d'une tornade (F0 à F5)");
            string twister = Console.ReadLine();
            switch (twister)
            {
                case "F0":
                    Console.WriteLine(fujita[0,1]);
                    break;
                case "F1":
                    Console.WriteLine(fujita[1, 1]);
                    break;
                case "F2":
                    Console.WriteLine(fujita[2, 1]);
                    break;
                case "F3":
                    Console.WriteLine(fujita[3, 1]);
                    break;
                case "F4":
                    Console.WriteLine(fujita[4, 1]);
                    break;
                case "F5":
                    Console.WriteLine(fujita[5, 1]);
                    break;
                default:
                    Console.WriteLine("Erreur");
                    break;
            }
        }

        public static void Exo6()
        {
            Console.WriteLine("Exercice 6");
            Console.WriteLine("A l’aide de la console, inviter l’utilisateur à renseigner un mois parmi les 12 mois de disponibles.");
            Console.WriteLine("Dans la console, selon le mois renseigné, afficher un des messages suivants :");
            Console.WriteLine("« La saison du mois saisi est le PRINTEMPS. »");
            Console.WriteLine("« La saison du mois saisi est l'ETE. »");
            Console.WriteLine("« La saison du mois saisi est l'AUTOMNE. »");
            Console.WriteLine("« La saison du mois saisi est l'HIVER. »");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("Veuillez saisir un mois (Janvier à Décembre)");
            string month = Console.ReadLine();
            switch (month)
            {
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("C'est le printemps");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                    Console.WriteLine("C'est l'été");
                    break;
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("C'est l'automne");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("C'est l'hiver");
                    break;
                default:
                    Console.WriteLine("Erreur");
                    break;
            }
        }
    }
}
