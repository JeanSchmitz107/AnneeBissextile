namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.
        
        //bool use_continuous = true;
        //while (use_continuous = true)
        //{

        //}

        Console.WriteLine("Entrez une année !");
        int annee = Convert.ToInt32(Console.ReadLine());
        
        if(annee < 1582)
        {
            Console.WriteLine("Veillez entrez une année grégorien (Min 1582) !");
        } 
        else if((annee % 4) == 0 || (annee % 400) == 0)
        {
            Console.WriteLine("L'année " + annee + " est bissextiles !");
        }
        else
        {
            Console.WriteLine("L'année " + annee + " n'est pas bissextiles !");
        }
    }
}