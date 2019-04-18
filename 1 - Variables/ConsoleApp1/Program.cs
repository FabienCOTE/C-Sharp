using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            Console.WriteLine("Créer 2 nombres a et b, puis leur attribuer une valeur.");
            Console.WriteLine("Afficher les valeurs de ces nombres dans la console, dans 2 phrases distinctes.");
            Console.WriteLine("Effectuer la somme des précédents nombres puis afficher le résultat dans la console, dans 1 phrase.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            int a = 5;
            int b = 10;
            Console.WriteLine("Le premier chiffre est " + a);
            Console.WriteLine("Le deuxième chiffre est " + b);
            Console.WriteLine("La somme des deux nombres est " + (a + b));
        }

        public void Exo2()
        {
            Console.WriteLine("Exercice 2");
            Console.WriteLine("Créer 3 nombres x, y et z en leur attribuant la valeur de votre choix.");
            Console.WriteLine("Afficher les valeurs de ces nombres dans la console, dans 1 phrase.");
            Console.WriteLine("Effectuer la somme des 2 premiers nombres puis effectuer le produit du résultat avec le dernier nombre.");
            Console.WriteLine("Afficher le résultat dans la console, dans 1 phrase.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            int x = 5;
            int y = 6;
            int z = 10;
            Console.WriteLine("La valeur du premier nombre est " + x + ", la valeur du deuxième nombre est " + y + " et la valeur du troisème nombre est " + z);
            int a = x + y;
            int b = a * z;
            Console.WriteLine("Le résultat est " + b);
        }

        public void Exo3()
        {
            Console.WriteLine("Exercice 3");
            Console.WriteLine("Créer 2 nombres a et b. Via la console, demander à l’utilisateur de renseigner ces nombres à l’aide de 2 phrases distinctes.");
            Console.WriteLine("Rajouter 33 au nombre a, et incrémenter de 1 le nombre b.");
            Console.WriteLine("Effectuer la division d’a par b.");
            Console.WriteLine("Afficher le résultat dans la console, dans 1 phrase.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Veuillez saisir un premier nombre et valider avec la touche \"Entrée\"");
            string numberA = Console.ReadLine();
            Console.WriteLine("Veuillez saisir un deuxième nombre et valider avec la touche \"Entrée\"");
            string numberB = Console.ReadLine();
            Console.WriteLine("Vous avez saisi : " + numberA + " et " + numberB);
            int.TryParse(numberA, out int a);
            int.TryParse(numberB, out int b);
            int c = a + 33;
            b++;
            Console.WriteLine("33 a été rajouté au nombre h, ce qui donne : " + c);
            Console.WriteLine("Incrémentation de 1 du nombre i, ce qui donne " + b);
            int d = c / b;
            Console.WriteLine("Le résultat de la division d'a par b est de " + d);
        }

        public void Exo4()
        {
            Console.WriteLine("Exercice 4");
            Console.WriteLine("Créer 3 variables contenant respectivement les éléments suivants :");
            Console.WriteLine("Monsieur");
            Console.WriteLine("Vincent");
            Console.WriteLine("1");
            Console.WriteLine("En utilisant les variables, faire en sorte que la console affiche le message suivant:");
            Console.WriteLine("« Bonjour Monsieur Vincent, vous êtes venu nous rendre visite 1 fois »");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            string gender = "Monsieur";
            string firstname = "Vincent";
            int visit = 1;
            Console.WriteLine("Bonjour " + gender + " " + firstname + ", vous êtes venu nous rendre visite " + visit + " fois");
        }

        public void Exo5()
        {
            Console.WriteLine("Exercice 5");
            Console.WriteLine("Via la console, demander à l’utilisateur de renseigner son nom et son prénom.");
            Console.WriteLine("Une fois tous les éléments renseignés, faire en sorte d’afficher dans la console la phrase suivante:");
            Console.WriteLine("« Bonjour Nom Prénom, nous sommes le jour date mois, comment allez - vous ? »");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Veuillez saisir votre nom et valider avec la touche \"Entrée\"");
            string lastname = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre prénom et valider avec la touche \"Entrée\"");
            string firstname = Console.ReadLine();
            Console.WriteLine("Bonjour " + lastname + " " + firstname + ", nous sommes le " + DateTime.Today.ToLongDateString() + ", comment allez-vous ?");
        }

        public void Exo6()
        {
            Console.WriteLine("Exercice 6");
            Console.WriteLine("Via la console, demande à l’utilisateur de renseigner son nom, son prénom et son année de naissance.");
            Console.WriteLine("Une fois tous les éléments renseignés, faire en sorte d’afficher à l’aide d’une seule commande:");
            Console.WriteLine("Fiches de renseignement");
            Console.WriteLine("Nom :");
            Console.WriteLine("Prénom:");
            Console.WriteLine("Age:");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Veuillez saisir votre nom et valider avec la touche \"Entrée\"");
            string lastname = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre prénom et valider avec la touche \"Entrée\"");
            string firstname = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre année de naissance et valider avec la touche \"Entrée\"");
            string birthdate = Console.ReadLine();
            int.TryParse(birthdate, out int ageNumber);
            int age = DateTime.Now.Year - ageNumber;
            Console.WriteLine("Fiches de renseignement\nNom : " + lastname + "\nPrénom : " + firstname + "\nAge : " + age);
        }

        public void Exo7()
        {
            Console.WriteLine("Exercice 7");
            Console.WriteLine("Soit un triangle ABC qui est rectangle en C.");
            Console.WriteLine("Définir 3 variables: AB, BC et CA.");
            Console.WriteLine("Via la console, demander à l’utilisateur de renseigner les valeurs de BC et de CA.");
            Console.WriteLine("Calculer la longueur de AB et afficher le résultat dans la console, dans 1 phrase.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Veuillez saisir les valeurs BC et valider avec la touche \"Entrée\"");
            string value1 = Console.ReadLine();
            Console.WriteLine("Veuillez saisir les valeurs CA et valider avec la touche \"Entrée\"");
            string value2 = Console.ReadLine();
            double.TryParse(value1, out double width);
            double.TryParse(value2, out double length);
            double hypo(double x, double y)
            {
                double z = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                return (z);
            }
            double value3 = hypo(width, length);
            Console.WriteLine("La longueur de AB est égal à : " + value3);
        }

        public void Exo8()
        {
            Console.WriteLine("Exercice 8");
            Console.WriteLine("Via la console, demander à l’utilisateur de renseigner le rayon r d’un cercle.");
            Console.WriteLine("Une fois le rayon renseigné, afficher dans la console, le périmètre et la surface du cercle, dans 2 phrases distinctes.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Veuillez saisir le rayon r d'un cercle");
            string value = Console.ReadLine();
            double.TryParse(value, out double rayon);
            double perimeter = rayon * 2 * Math.PI;
            double surface = Math.Pow(rayon, 2) * Math.PI;
            Console.WriteLine("Le périmètre du cercle est de " + perimeter);
            Console.WriteLine("La surface du cercle est de  " + surface);
        }
    }
}