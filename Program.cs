using System.Security.Cryptography.X509Certificates;

namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

        bool use_continuous = true;
        while (use_continuous = true)
        {
            Console.WriteLine("Entrez une année !");
            int annee = Convert.ToInt32(Console.ReadLine());
        
            if(annee < 1582)
            {
                while(annee < 1582)
                {
                    Console.WriteLine("Veillez entrez une année grégorien (Min 1582) !");
                    annee = Convert.ToInt32(Console.ReadLine());
                }
                if ((annee % 4) == 0 || (annee % 400) == 0)
                {
                    Console.WriteLine("L'année " + annee + " est bissextiles !");
                }
                else
                {
                    Console.WriteLine("L'année " + annee + " n'est pas bissextiles !");
                }
            } 
            else if((annee % 4) == 0 || (annee % 400) == 0)
            {
                Console.WriteLine("L'année " + annee + " est bissextiles !");
            }
            else
            {
                Console.WriteLine("L'année " + annee + " n'est pas bissextiles !");
            }


            Console.WriteLine("Voulez vous entrez encore une année ! oui/non");
            string use_O_Or_N = Console.ReadLine();

            while(use_O_Or_N is not "non" and not "Non" and not "oui" and not "Oui")
            {
                Console.WriteLine("je n'ai pas compris votre demande.");

                Console.WriteLine("Voulez vous entrez encore une année ! oui/non");
                use_O_Or_N = Console.ReadLine();
            }

            if (use_O_Or_N is "oui" or "Oui")
            {
                use_continuous = true;
            }
            else if (use_O_Or_N is "non" or "Non")
            {
                use_continuous = false;
            }
            else
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\nError\n\n\n\n\n\n\n\n\n\n");
            }

        }

        
    }
}