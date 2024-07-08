using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Delegati
{
    internal class Auta
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int GodinaProizvodnje { get; set; }

        public int Trzisna_Cijena { get; set; }
        public Auta()
        {
            Trzisna_Cijena = new Cijena();
           

        }

        private void Promijena_cijene(object sender, int nova_cijena)
        {
            Console.WriteLine($"Cijena je promijenjena na {nova_cijena}");
        }
    }
}
