using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
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
            Console.WriteLine("indiquer le TP que vous voulez ouvrir :");
            Console.WriteLine("TP 1 à 2");
            string value = Console.ReadLine();
            int.TryParse(value, out int exo);
            if (exo >= 1 && exo <= 2)
            {
                switch (exo)
                {
                    case 1:
                        test.TP1();
                        break;
                    case 2:
                        test.TP2();
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

        public void TP1()
        {
            Console.WriteLine("TP 1");
            Console.WriteLine("Faire une application console pour calculer l'IMC de l'utilisateur.");
            Console.WriteLine("Se servir des éléments suivants:");
            Console.WriteLine("L'indice de masse corporelle est calculé en divisant le poids par la taille au carré.");
            Console.WriteLine("IMC Interprétation");
            Console.WriteLine("moins de 16,5   Dénutrition");
            Console.WriteLine("16,5 à 18,5     Maigreur");
            Console.WriteLine("18,5 à 25   Corpulence normale");
            Console.WriteLine("25 à 30     Surpoids");
            Console.WriteLine("30 à 35     Obésité modérée");
            Console.WriteLine("35 à 40     Obésité sévère");
            Console.WriteLine("plus de 40  Obésité morbide ou massive");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("Veuillez saisir votre poids");
            string value1 = Console.ReadLine();
            double.TryParse(value1, out double weight);
            Console.WriteLine("Veuillez saisir votre taille en cm");
            string value2 = Console.ReadLine();
            double.TryParse(value2, out double size);
            double imc = (weight / (size * size)) * 10000;
            string[,] info = new string[,]
            {
                { "moins de 16,5", "Dénutrition" },
                { "16,5 à 18,5", "Maigreur" },
                { "18,5 à 25", "Corpulence normale" },
                { "25 à 30", "Surpoids" },
                { "30 à 35" , "Obésité modérée"},
                { "35 à 40", "Obésité sévère" },
                { "plus de 40", "Obésité morbide ou massive" }
            };
            if (imc < 16.5)
            {
                Console.WriteLine(info[0, 1]);
            }
            else if (imc >= 16.5 && imc <= 18.5)
            {
                Console.WriteLine(info[1, 1]);
            }
            else if (imc > 18.5 && imc <= 25)
            {
                Console.WriteLine(info[2, 1]);
            }
            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine(info[3, 1]);
            }
            else if (imc > 30 && imc <= 35)
            {
                Console.WriteLine(info[4, 1]);
            }
            else if (imc > 35 && imc <= 40)
            {
                Console.WriteLine(info[5, 1]);
            }
            else
            {
                Console.WriteLine(info[6, 1]);
            }
        }

        public void TP2()
        {
            var test = new Program();
            int count = 1;
            bool answer = false;
            Console.WriteLine("TP 2");
            Console.WriteLine("Faire une application console pour faire deviner un nombre entre 1 et 50 à l'utilisateur.");
            Console.WriteLine("Le nombre sera préalablement choisi par vous. (BONUS: Faites en sorte que le nombre se génère de manière aléatoire).");
            Console.WriteLine("L'application donnera des indications sous forme de messages :");
            Console.WriteLine("Le nombre à deviner est plus grand... ou plus petit.");
            Console.WriteLine("Bravo, vous avez trouvé!(BONUS: Affichez le nombre de tentative - s).");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Random number = new Random();
            int game = number.Next(1, 50);

            while (!answer)
            {
                int result = test.Message();

                if (result == game)
                {
                    Console.WriteLine("\nBravo, vous avez trouvé !");
                    Console.WriteLine("Nombre de tentative : " + count);
                    answer = true;
                }
                else if (result > game)
                {
                    Console.WriteLine("Le nombre est plus petit\n");
                    count++;
                }
                else
                {
                    Console.WriteLine("Le nombre est plus grand\n");
                    count++;
                }
            }
        }

        public int Message()
        {
            Console.WriteLine("Veuillez saisir un nombre entre 1 et 50");
            string value = Console.ReadLine();
            int.TryParse(value, out int result);
            return result;
        }
    }
}
