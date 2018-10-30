using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Agregation
{
    class Program
    {
        static void Main(string[] args)
        {
            NouvelleDAO nouvelleDao = new NouvelleDAO();

            List<NouvelleTechnologique> liste = nouvelleDao.listerNouvelles();
            //foreach(NouvelleTechnologique nouvelle in liste)
            //{
            //    Console.WriteLine(nouvelle.titre + "\n");
            //}
            Console.ReadKey(true);


        }
    }
}
