using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercice 1 : code C# calculant la surface et le volume d'une sphere
            double rayonSphere = 7.5;
            // Surface de la sphere
            double surfaceSphere = 4 * Math.PI * (rayonSphere * 2);
            // Volume de la sphere (4π/3) × R3 
            double volumeSphere = (4*Math.PI / 3) * (rayonSphere * rayonSphere * rayonSphere);

            // Résultats
            Console.WriteLine("La surface d'un sphere de radiant 7.5 est de : " + surfaceSphere);
            Console.WriteLine("Le volume de sphere de radiant 7.5 est de : " + volumeSphere + "\n\n");

            // Exercice 2 : 
            Console.WriteLine("x value        y value        expression                result");
            Console.WriteLine("10             5              x=y+3                     x=8");
            Console.WriteLine("10             5              x=y-2                     x=3");
            Console.WriteLine("10             5              x=y*5                     x=25");
            Console.WriteLine("10             5              x=x/y                     x=2");
            Console.WriteLine("10             5              x=x%y                     x=0\n");

            // Exercice 3 : Valeur absolue d'un nombre donné
            Console.Write("Donnez un nombre réel : ");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 0)
                Console.WriteLine("La valeur absolue de {0} est {1}\n", x, x);
            else
                Console.WriteLine("La valeur absolue de {0} est {1}\n", x, -x);

            // Exercice 4 :
            Console.Write("Première valeur entière : ");
            int entier1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Deuxième valeur entière : ");
            int entier2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Troisième valeur entière : ");
            int entier3 = Convert.ToInt32(Console.ReadLine());

            int[] tabEntiers = new int[] { entier1, entier2, entier3 };
            Array.Sort(tabEntiers);
            Console.WriteLine("La valeur la plus grande rentrée est : {0}\n", tabEntiers[tabEntiers.Length-1]);

            // Exercice 5 : division de deux nombres
            Console.Write("Je souhaite diviser : ");
            double dividende = Convert.ToDouble(Console.ReadLine());
            Console.Write("Par : ");
            double diviseur = Convert.ToDouble(Console.ReadLine());
            if (diviseur == 0)
            {
                Console.WriteLine("ERROR : Division par zéro\n");
            }
            else
            {
                double resDivision = dividende / diviseur;
                Console.WriteLine("Résultat de la division de {0} par {1} est de : {2}\n", dividende, diviseur, resDivision);
            }

            // Exercice 6 : opérations sur des integers
            Console.Write("Premier entier : ");
            int firstInt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Opérateur [+], [-], [*], [/] : ");
            string operation = Console.ReadLine();
            Console.Write("Deuxième entier : ");
            int SecondInt = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            if (operation == "+")
            {
                res = firstInt + SecondInt;
            }
            else if (operation == "-")
            {
                res = firstInt - SecondInt;
            }
            else if (operation == "*")
            {
                res = firstInt * SecondInt;
            }
            else if (operation == "/")
            {
                res = firstInt / SecondInt;
            }
            Console.WriteLine("{0} {1} {2} = {3}\n", firstInt, operation, SecondInt, res);

            // Exercice 7 : opérations sur des flottants
            Console.Write("Premier flottant : ");
            float firstFloat = float.Parse(Console.ReadLine());
            Console.Write("Opérateur [+], [-], [*], [/] : ");
            operation = Console.ReadLine();
            Console.Write("Deuxième flottant : ");
            float secondFloat = float.Parse(Console.ReadLine());
            float resFloat = 0;
            switch(operation)
            {
                case "+":
                    resFloat = firstFloat + secondFloat;
                    break;
                case "-":
                    resFloat = firstFloat - secondFloat;
                    break;
                case "*":
                    resFloat = firstFloat * secondFloat;
                    break;
                case "/":
                    resFloat = firstFloat / secondFloat;
                    break;
            }
            Console.WriteLine("{0} {1} {2} = {3}\n", firstFloat, operation, secondFloat, resFloat);


            // Exercice 8 : résolution d'une équation du second degré
            Console.WriteLine("Résolution de l'équation du second degré pour a = 2, b = 4 et c = 1");
            int delta = (4 * 4) - 4 * 2 * 1;
            if (delta == 0)
            {
                Console.WriteLine("x = {0}", (-4 / (2*2)));
            }
            else if (delta > 0)
            {
                Console.WriteLine("x1 = {0}; x2 = {1}", (-4 - Math.Sqrt(delta)) / (2*2), (-4 + Math.Sqrt(delta)) / (2 * 2));
            }
            else
            {
                Console.WriteLine("Pas de solution");
            }

            // Exercice 9 : code C# calculant la moyenne pondérée
            double[] tabNotes = new double[] { 2.4, 3.7, 2.5, 5.6, 4.5, 5, 4, 5.8, 6 };
            double somme = 0;
            int moyInt = 0;
            for (int i = 0; i < tabNotes.Length; i++)
            {
                somme += tabNotes[i];
            }
            double moy = somme / tabNotes.Length;
            if (moy%2 > 0)
            {
                moyInt = Convert.ToInt32(moy) + 1;
            }
            else
            {
                moyInt = Convert.ToInt32(moy);
            }
            Console.WriteLine("Moyenne des notes : {0}\n", moyInt);

            // Exercice 10 : table de multiplication
            Console.Write("Table de multiplication de : ");
            int promptMulti = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", promptMulti, i, promptMulti * i);
            }

            Console.WriteLine();

            // Exercice 11 : étoiles
            for (int i = 7; i > 0; i--)
            {
                string resExo = "";
                for (int j = 0; j < i; j++)
                {
                    resExo += "*";
                }
                Console.WriteLine(resExo);
            }

            Console.WriteLine();

            // Exercice 12 : étoiles + chiffres
            for (int i = 2; i < 9; i++)
            {
                string resExo = "";
                for (int j = 1; j < i; j++)
                {
                    resExo += j;
                }
                for (int k = i; k < 8; k++)
                {
                    resExo += "*";
                }
                Console.WriteLine(resExo);
            }

            Console.WriteLine();

            // Exercice 13 :
            int countPos = 0;
            int countNeg = 0;
            for (int i = 1; i < 11; i++)
            {
                Console.Write("Entrez un entier {0} : ", i);
                int entierExo = Convert.ToInt32(Console.ReadLine());
                if (entierExo < 0)
                {
                    countNeg++;
                }
                else
                {
                    countPos++;
                }
            }
            Console.WriteLine("Compteur négatif : {0} || compteur positif : {1}\n", countNeg, countPos);
            
            // Exercice 14 : jeu du pendu
            Console.Write("Entrez un mot (longueur 6) en minuscule : ");
            string motATrouve = Console.ReadLine();
            int lettreTrouvee = 0;
            int essais = 10;
            char[] motIndice = new char[6] { '_', '_', '_', '_', '_', '_' };
            while (lettreTrouvee < 6 && essais > 0)
            {
                Console.Write("Entrez une lettre en minuscule : ");
                essais--;
                char lettreProposee = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < 6; i++)
                {
                    if(motATrouve[i] == lettreProposee && motIndice[i] != lettreProposee)
                    {
                        lettreTrouvee++;
                        motIndice[i] = lettreProposee;
                    }
                }
                Console.Write("Il vous reste {0} essai(s), pour l'instant vous avez trouvé ce mot : ", essais);
                Console.Write(motIndice);
                Console.WriteLine();
            }
            if (lettreTrouvee == 6)
                Console.WriteLine("Bravo vous avez trouvé le mot {0} !\n", motATrouve);
            else
                Console.WriteLine("Vous n'avez pas trouvé le mot en 10 essais :( il fallait trouvé : {0}\n", motATrouve);
            
            // Exercice 15
            int[] loto = new int[6];
            int[] resLoto = new int[6];
            Random rd = new Random();
            int bonNumero = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Entrez un numéro entre 1 et 50 pour le loto : ");
                loto[i] = Convert.ToInt32(Console.ReadLine());
                int rn = rd.Next(1, 51);
                for (int j = 0; j < resLoto.Length; j++) // Permet l'unicité des nombres aléatoires du loto
                {
                    while (rn == resLoto[j])
                    {
                        rn = rd.Next(1, 51);
                    }
                }
                resLoto[i] = rn;
            }
            Array.Sort(resLoto); // Range le tirage pour l'affichage
            Console.Write("Les résultats du loto sont : |{0}|{1}|{2}|{3}|{4}|{5}|\n", resLoto[0], resLoto[1], resLoto[2], resLoto[3], resLoto[4], resLoto[5]);
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (loto[i] == resLoto[j])
                    {
                        bonNumero++;
                    }
                }
            }
            Console.WriteLine("Vous avez {0} bon(s) numéro(s) sur 6.", bonNumero);

            // Exercice 16
            string loginSaved = "test";
            string passwordSaved = "test";
            ConsoleKeyInfo key;
            bool logOk = false;
            int tries = 0;
            while (logOk == false && tries < 3)
            {
                string passwordGiven = "";
                Console.Write("Login : ");
                string loginGiven = Console.ReadLine();
                Console.Write("Password : ");
                // https://msdn.microsoft.com/en-us/library/system.security.securestring.aspx un peu modifié permet de remplace les caractères par des astérisques
                do
                {
                    key = Console.ReadKey(true);

                    if (((int)key.Key) >= 65 && ((int)key.Key <= 90))
                    {
                        passwordGiven += key.KeyChar;
                        Console.Write("*");
                    }
                } while (key.Key != ConsoleKey.Enter);
                Console.WriteLine();
                if (loginGiven == loginSaved && passwordGiven == passwordSaved)
                {
                    logOk = true;
                    Console.WriteLine("Connexion...");
                }
                else
                {
                    tries++;
                }
            }
            if (logOk)
            {
                Console.WriteLine("Bienvenue !\n");
            }
            else
            {
                Console.WriteLine("Essayez 'mot de passe oublié' ou créer un compte !\n");
            }


            Console.ReadLine();
        }
    }
}
