using System;
using System.Globalization;

namespace área_de_um_retangulo {
    class Retangulo {

       public Retangulo() {
            this.Altura = 0;
            this.Base = 0;
        }

        private int baseret; 

        public int Base {
            get { return baseret; }
            set {
                if (value >= 0) baseret = value;
                else baseret = 0;
            }   
            
            
        }

        private int altret;

        public int Altura {
            get { return altret; }
            set {
                if (value >= 0) altret = value;
                else altret = 0;
            }
        }

        public int Area {
            get { return altret* baseret; }
        }

        public void ExibeDados() {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
        }

        
    }
}
