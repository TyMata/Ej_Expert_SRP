using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(Double precioMasa, Double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}

        public Double PrecioAlfajor()
        {
            return this.PrecioDulce + this.PrecioMasa;
        }
    }
}