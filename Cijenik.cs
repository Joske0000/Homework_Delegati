using System;

namespace Homework_Delegati 
{
    internal class Cijena 
    {
       public event EventHandler<double> CijenaPromjenjena;

        private static double _vrijednostMPC;
        private double VrijednostMPC
        {
            get { return _vrijednostMPC; }
            set {
                _vrijednostMPC = value;
                CijenaPromjenjena?.Invoke(this, value);
            }
        }
        private static double _vrijednostVPC;
        public double VrijednostVPC {
               get { return _vrijednostVPC; }
               set {
                   _vrijednostVPC = value;
                   CijenaPromjenjena?.Invoke(this, value);
               } 
        } 
        
        public void PovecajMaloprodajnuCijenu (double novaCijena)
        {
            VrijednostMPC += novaCijena;
        }
        public void PovecajVeleprodajnuCijenu (double novaCijena)
        {
            VrijednostVPC += novaCijena;
        }
    }
}
