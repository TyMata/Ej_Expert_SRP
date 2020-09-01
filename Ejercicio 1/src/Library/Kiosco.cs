using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Convertidor c= new Convertidor();
            Double pesos = c.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioAlfajor();
        }
    }
}