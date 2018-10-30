using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PileManip
{
    class Program
    {
        // tester PileLimitée
        static void Main(string[] args)
        {
            // Nouvelle pileLimitée pour int, avec une capacité de 5 elements
            PileLimitée<int> pile = new PileLimitée<int>(5); 

            // Inérer 5 elements
            Console.WriteLine("Empiler 2, 4, 6, 8, 9");
            pile.Empiler(2);
            pile.Empiler(4);           
            pile.Empiler(6);
            pile.Empiler(8);
            pile.Empiler(9);

            // dépiler 1 element
            Console.WriteLine("Nombre elements avant dépiler : " + pile.NbÉléments());
            Console.WriteLine("dépiler : "); // doit etre 9
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("Nombre elements apres dépileer: " + pile.NbÉléments());

            // empiler 3 elements (devrons ecraser 2, 4, 6)
            Console.WriteLine("Empiler 10, 12, 14");
            pile.Empiler(10);
            pile.Empiler(12);
            pile.Empiler(14);

            // Dépiler le tout
            Console.WriteLine("Depiler");
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("Nombre elements : " + pile.NbÉléments());
            try
            {
                Console.WriteLine(pile.Dépiler());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("erreur gerée : " + e.Message);
            }

            //Empiler 7 elements ( les deux derniers devront ecraser les deux premiers
            Console.WriteLine("Empiler 5, 7, 9, 11, 13, 15, 17");
            pile.Empiler(5); // dervai etre écrasé par 15
            pile.Empiler(7);
            pile.Empiler(9);
            pile.Empiler(11);
            pile.Empiler(13);
            pile.Empiler(15);
            pile.Empiler(17);
            Console.WriteLine("dépiler : ");
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("dépiler : ");
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("dépiler : ");
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("dépiler : ");
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("dépiler : ");
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("Nombre elements : " + pile.NbÉléments());
            try
            {
                Console.WriteLine(pile.Dépiler());
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("erreur gerée : " + e.Message);
            }

            //Empiler 1 element
            Console.WriteLine("Empiler 30");
            pile.Empiler(30);
            Console.WriteLine("dépiler : ");
            Console.WriteLine(pile.Dépiler());
            Console.WriteLine("Nombre elements : " + pile.NbÉléments());

            Console.ReadKey();
        }
    }
}
