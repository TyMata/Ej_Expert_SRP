using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }// No cumple con el patron Expert ya que esta responsabilidad no le pertenece al libro le pertenece a otra clase
        public string EstanteBiblioteca { get ; set; }// No cumple con el patron Expert ya que esta responsabilidad no le pertenece al libro le pertenece a otra clase

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante) //Esto deberia ir en otra clase ya que no cumple con el patron SRP
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
