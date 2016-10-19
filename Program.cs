using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsTest3
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("entrez un entier");
            string vsInt = Console.ReadLine();
            int vInt = Convert.ToInt32(vsInt);
            intContainer ic = new intContainer(vInt);
            intListener il = new intListener();
            il.assignTo(ic); // sans cette assignation , l'entier ne peut pas être évalué
            string result = ic.evaluation();
            Console.WriteLine(result);
            Console.ReadLine();
            goto start;
        }
    }
}
