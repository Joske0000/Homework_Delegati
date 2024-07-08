using System;

namespace Homework_Delegati
{
    internal class Artikli 
    {  
        public string id { get; set; }
        public string naziv { get; set; }
        public string vrsta { get; set;}
        public Cijena VeleprodajnaCijena { get; set; }
        public Cijena MaloprodajnaCijena { get; set; }

        public Artikli()
        {
            VeleprodajnaCijena = new Cijena();
            MaloprodajnaCijena = new Cijena();
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
