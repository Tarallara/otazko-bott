

using System;

namespace otazko_bott
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("?: Ahoj, jak se jmenujes? ");    //gramatice chybi casrky a haxky, jelikoz ceska klavesnice je na nic pproto aj
            Console.WriteLine(" ");
            Console.WriteLine("?: ");
            string jmeno = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("?: hmmm "+jmeno + ", ja jsem Task. ");
            Console.WriteLine("Task: rad te Poznavam");

            Console.WriteLine("Task: kolik ti je");
            Console.WriteLine(" ");
            
            // int vek = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(" ");
            int vek;

            do
            {
                vek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(jmeno + ": ");
                Console.WriteLine(" ");
                if (vek < 0)
                {
                    Console.WriteLine("Task: jsi cestovatel casem ? Ne nejsi");
                    Console.WriteLine("Task: takze kolik ti je");
                }
                else if (vek > 120)
                {
                    Console.WriteLine("Task: ahoj zombie, nebo upir? tak jeste jednou?");
                    Console.WriteLine("Task: takze kolik ti je");
                }
                else
                {
                    Console.WriteLine("Task: gratuluji, jsi na zivu, aleson doufam");
                }

            } while (vek < 0 || vek > 120);

  

            Console.WriteLine("Task: uznavam, tyhle odpovedi sjou zle xd, no co nadelame");
            Console.WriteLine("Task: tak muzeme pokracovat se zakladnimi otazky");
            Console.WriteLine("Task: co je tva oblibena barva");
            Console.WriteLine(" ");
            Console.WriteLine(jmeno + ": ");
            string barva = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Task: kdzy tvoje " + barva + "tak moje zelena");

            Console.WriteLine("Task: dobry chapu, budou zajimavejsi otazky");

            Console.WriteLine("Task: tvuj oblibeny hudebni zanr?");
            Console.WriteLine(" ");
            Console.WriteLine(jmeno + ": ");
            string hudba = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Task: " + hudba + " ok, nice, ja miluju pop punk");

            Console.WriteLine("Task: kdyz uz ser bavime o hudbe, co takhle oblibene kapely nebo interprety");
            Console.WriteLine(" ");
            Console.WriteLine(jmeno + ": ");
            string kapela = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Task: musim uznat ze zajimavy viber kdyz rikas " + kapela );
            Console.WriteLine("Task: ale ppro me to asi stejne vzdy budou Blink-182, sum 41, MCR a MGK");

            Console.WriteLine("Task: no nic " + jmeno + ", rad jsem te poznal");
            Console.WriteLine("Task: zbohem");


            //tvurci kryze be like
            //prisaham ze umim i leposi ale art block je zlej
















        }

    }
}
