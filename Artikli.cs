using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegati
{
    internal class Artikli
    {
        public string id { get; set; }
        public string Naziv { get; set; }
        public string Vrsta { get; set;}
        public cijena VeleprodajnaCijena { get; set; }
        public cijena MaloprodajnaCijena { get; set; }

        public Artikli()
        {
            VeleprodajnaCijena = new cijena();
            MaloprodajnaCijena = new cijena();
            VeleprodajnaCijena.CijenaPromjenjena += VPC_CijenaPromjenjena;
            MaloprodajnaCijena.CijenaPromjenjena += MPC_CijenaPromjenjena;
        }
        
        private void VPC_CijenaPromjenjena(object sender, double e)
        {
            Console.WriteLine($"Nova VPC cijena je: {e}");
        }

        private void MPC_CijenaPromjenjena(object sender, double e)
        {
            Console.WriteLine($"Nova MPC cijena je: {e}");
        }
    }
}
