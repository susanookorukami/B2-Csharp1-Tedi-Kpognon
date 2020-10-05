using System;
using System.Collections.Generic;

namespace Tedi_App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ville> Listville = new List<Ville>();
            
            while (true)
            {
                string choixUtilisateur = MenuVille();

                if (choixUtilisateur == "1")
                {
                    Ville V = CreateVille();
                    Listville.Add(V);
                }
                else if (choixUtilisateur == "2")
                {
                    affiche(Listville);
                }
                else if (choixUtilisateur == "3")
                {
                    affiche(Listville);
                    break;
                }
                else
                {
                    Console.WriteLine("Je n'ai pas compris");
                }
            }
            Console.ReadKey();

        }
        public static string MenuVille()
        {
            Console.WriteLine("que voulez vous faire?");
            Console.WriteLine("1.Cree une nouvelle ville");
            Console.WriteLine("2.afficher l'ensemble des villes");
            Console.WriteLine("3.Afficher le nombre total d'habitant");
            string MenuVille = Console.ReadLine();
            return MenuVille;
        }
        public static void affiche(List<Ville> Ville)
        {
            foreach (Ville V in Ville)
            {
                string message;
                message = Buildmessage(V);
                Console.WriteLine(message);
            }
        }

        public static Ville CreateVille()
        {
            //intentiation de locataire
            Ville V = new Ville();

            //demande de prenom
            V.Nom = NbLettre("Nom :");
            //demande de place
            V.CodePostal = NbEntier("Code Postal :");
            //temps de location
            V.Habitants = NbEntier("Habitant :");
            //crée le message
            //affiche le message
            
            return V;
        }

        public static string Buildmessage(Ville V)
        {
            string result;

            result = "--------------------"+
                "nom : "+ V.Nom + " Code Postal : " + V.CodePostal + 
                " Nombre d'habitant : " + V.Habitants + 
                "----------------------------------";
            return result;
        }

        public static string NbLettre(string message)
        {
            Console.WriteLine(message);
             string Nom;
             Nom = Console.ReadLine();
            int intville;
                if (int.TryParse(Nom, out intville))
                {
                    Console.WriteLine("la saisie est invalide");
                    Nom = Console.ReadLine();
                 }
                    return Nom;
           
        }
        public static int NbEntier(string message)
        {
            Console.WriteLine(message);
            string CodePostal;
            CodePostal = Console.ReadLine();
            int intValue;
            while (!int.TryParse(CodePostal, out intValue)&&intValue >=0)
            {
                Console.WriteLine("la saisie est invalide");
                CodePostal = Console.ReadLine();
            }
            return intValue;
        }
    }
}
    

    

    
