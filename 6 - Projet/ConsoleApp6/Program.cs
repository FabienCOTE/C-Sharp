using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int error = 0;
            Console.WriteLine("Projet Application console");
            Console.WriteLine("Une agence de recrutement souhaite réaliser de nouveaux tests pour ses candidats afin de vérifier leur connaissance en C# et principalement en application console. Pour cela, elle missionne votre équipe de réaliser un quizz qui répondra à ses besoins.");
            Console.WriteLine("Le quizz devra comporter 10 questions portant sur le langage C# utilisé dans le cadre d'applications consoles.");
            Console.WriteLine("Les candidats auront le choix entre 4 réponses, 1 seule étant correcte.");
            Console.WriteLine("L'agence de recrutement vous demande de réaliser ce quizz avec une application console qui sera stylisée avec des couleurs, des espacements de texte... tout ce qui pourrait améliorer l'expérience utilisateur.");
            Console.WriteLine("A la fin du quizz, vous devrez afficher un récapitulatif en donnant le score du candidat et les bonnes réponses.");
            Console.WriteLine("Votre équipe pourra faire une proposition plus complète à l'agence de recrutement si vous le souhaitez. Celle-ci tiendra compte de vos efforts.");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("Pour commencer appuyer sur une touche");
            Console.ReadKey();
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°1\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Qu'est-ce que le C# ?");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - Un compilateur qui transforme du code intermédiaire en binaire");
            Console.WriteLine("B - Un langage de programmation permettant de réaliser des applications informatiques");//
            Console.WriteLine("C - Un framework permettant de réaliser des applications de toutes sortes");
            Console.WriteLine("D - Je ne sais pas");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer1 = Console.ReadLine().ToUpper();
            Exit(answer1);
            if (answer1 != "B")
            {

                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'B' - Un langage de programmation permettant de réaliser des applications informatiques");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°2\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Qu’est-ce que Visual Studio ?");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - Un compilateur qui transforme du code intermédiaire en binaire");
            Console.WriteLine("B - Un framework permettant de réaliser des applications de toutes sortes");
            Console.WriteLine("C - Un environnement de développement permettant de développer en C#");//
            Console.WriteLine("D - Je ne sais pas");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer2 = Console.ReadLine().ToUpper();
            Exit(answer2);
            if (answer2 != "C")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'C' - Un environnement de développement permettant de développer en C#");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°3\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("L'instruction suivante est-elle correcte syntaxiquement ?");
            Console.WriteLine("Console.WriteLine(\"Hello World!!\") //Affiche Hello World");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - Non, il manque un point virgule à la fin de la ligne");//
            Console.WriteLine("B - Oui, elle affiche une ligne à l’écran");
            Console.WriteLine("C - Oui, mais elle n’affiche rien car la ligne est en commentaires");
            Console.WriteLine("D - Je ne sais pas");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer3 = Console.ReadLine().ToUpper();
            Exit(answer3);
            if (answer3 != "A")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'A' - Non, il manque un point virgule à la fin de la ligne");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°4\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Quelle est la syntaxe correcte pour déclarer le nom Nicolas dans une variable ?");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - string nom = Nicolas;");
            Console.WriteLine("B - int nom=\"Nicolas\";");
            Console.WriteLine("C - string nom=\"Nicolas\";");//
            Console.WriteLine("D - Je ne sais pas");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer4 = Console.ReadLine().ToUpper();
            Exit(answer4);
            if (answer4 != "C")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'C' - string nom=\"Nicolas\";");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°5\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Quel est le résultat des instructions ci-dessous ?");
            Console.WriteLine("int i = 10 * 2;");
            Console.WriteLine("i++;");
            Console.WriteLine("i = i / 2;");
            Console.WriteLine("Console.WriteLine(i);");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - 10");//
            Console.WriteLine("B - 11");
            Console.WriteLine("C - Ce code ne compile pas");
            Console.WriteLine("D - Je ne sais pas");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer5 = Console.ReadLine().ToUpper();
            Exit(answer5);
            if (answer5 != "A")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'A' - 10");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°6\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Quel est le résultat des instructions ci-dessous ?");
            Console.WriteLine("string chaine = \"c:\\repertoire\\\";");
            Console.WriteLine("chaine += \"fichier.txt\";");
            Console.WriteLine("Console.WriteLine(chaine);");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - c:\\repertoire\\");
            Console.WriteLine("B - c:\\repertoire\\fichier.txt");
            Console.WriteLine("C - Ce code ne compile pas");//
            Console.WriteLine("D - Je ne sais pas");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer6 = Console.ReadLine().ToUpper();
            Exit(answer6);
            if (answer6 != "C")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'C' - Ce code ne compile pas");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°7\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Qu'affiche le code suivant ?");
            Console.WriteLine("int i = 5;");
            Console.WriteLine("int j = 3;");
            Console.WriteLine("if (i > 5 && j <= 3)");
            Console.WriteLine("{");
            Console.WriteLine("    Console.WriteLine(\"ici\");");
            Console.WriteLine("}");
            Console.WriteLine("else");
            Console.WriteLine("{");
            Console.WriteLine("    if (i < 3 || j >= 3)");
            Console.WriteLine("    {");
            Console.WriteLine("        Console.WriteLine(\"là\");");
            Console.WriteLine("    }");
            Console.WriteLine("    else");
            Console.WriteLine("    {");
            Console.WriteLine("        Console.WriteLine(\"plutôt là\");");
            Console.WriteLine("    }");
            Console.WriteLine("}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - ici");
            Console.WriteLine("B - là");//
            Console.WriteLine("C - plutôt là");
            Console.WriteLine("D - Le code n'affiche rien");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer7 = Console.ReadLine().ToUpper();
            Exit(answer7);
            if (answer7 != "B")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'B' - Là");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°8\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Parmi ces types de variables, lequel doit-on utiliser pour indiquer qu'une méthode ne renvoie rien ?");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - return");
            Console.WriteLine("B - string.empty");
            Console.WriteLine("C - void");//
            Console.WriteLine("D - int");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer8 = Console.ReadLine();
            Exit(answer8);
            if (answer8 != "C")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'C' - void");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°9\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Qu'affiche le code suivant ?");
            Console.WriteLine("static void Main(string[] args)");
            Console.WriteLine("{");
            Console.WriteLine("    int i = Somme(3, Somme(4, 5));");
            Console.WriteLine("    Console.WriteLine(i);");
            Console.WriteLine("}");
            Console.WriteLine("private static int Somme(int a, int b)");
            Console.WriteLine("{");
            Console.WriteLine("    if (a == 5)");
            Console.WriteLine("        return 1;");
            Console.WriteLine("    else");
            Console.WriteLine("        return a + b;");
            Console.WriteLine("}");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - 0");
            Console.WriteLine("B - 4");
            Console.WriteLine("C - 8");
            Console.WriteLine("D - 12");//
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer9 = Console.ReadLine();
            Exit(answer9);
            if (answer9 != "D")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'D' - 12");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Question n°10\n\n");
            TexteRight("Saisir 'exit' pour quitter la console\n");
            Console.WriteLine("Qu'affiche le code suivant ?");
            Console.WriteLine("int[] tab = new int[] { 1, 2, 3, 4 };");
            Console.WriteLine("int resultat = tab[1] + tab[2];");
            Console.WriteLine("Console.WriteLine(resultat);");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");
            Console.WriteLine("A - 1");
            Console.WriteLine("B - 3");
            Console.WriteLine("C - 5");//
            Console.WriteLine("D - 7");
            Console.WriteLine("\nInscrivez votre réponse (A, B, C ou D");
            string answer10 = Console.ReadLine();
            Exit(answer10);
            if (answer10 != "C")
            {
                WrongAnswer();
                Console.WriteLine("La bonne réponse est la 'C' - 5");
                error++;
                Console.WriteLine("Appuyer sur une touche pour continuer");
                Console.ReadKey();
            }
            Console.Clear();
            TexteCenter("Quizz C#\n");
            TexteCenter("Réponses\n\n");// 1B 2C 3A 4C 5A 6C 7B 8C 9D 10C
            Console.WriteLine("Vous avez fait " + error + " erreur(s) !");
            Console.WriteLine("Question n°1 :");
            if (answer1 == "B")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°2 :");
            if (answer2 == "C")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°3 :");
            if (answer3 == "A")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°4 :");
            if (answer4 == "C")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°5 :");
            if (answer5 == "A")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°6 :");
            if (answer6 == "C")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°7 :");
            if (answer7 == "B")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°8 :");
            if (answer8 == "C")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°9 :");
            if (answer9 == "D")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Question n°10 :");
            if (answer10 == "C")
            {
                RightAnswer();
            }
            else
            {
                WrongAnswer();
            }
            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadKey();
        }

        private static void TexteCenter(string texte)
        {
            int nbSpace = (Console.WindowWidth - texte.Length) / 2;
            Console.SetCursorPosition(nbSpace, Console.CursorTop);
            Console.WriteLine(texte);
        }

        private static void TexteRight(string texte)
        {
            int nbEspaces = (Console.WindowWidth - texte.Length);
            Console.SetCursorPosition(nbEspaces, Console.CursorTop);
            Console.WriteLine(texte);
        }

        private static void Exit(string value)
        {
            if (value == "EXIT")
            {
                Environment.Exit(0);
            }
        }

        private static void RightAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nBonne réponse !\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void WrongAnswer()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nMauvaise réponse !\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
