using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoNave
{
    class Juego
    {
       public void Inicio()
        {
            Console.WriteLine("JUEGO DE INVASORES DEL ESPACIO");
            Console.ReadKey();
        }
        List<Nave> listanave = new List<Nave>();
    
    }
    class Nave
    {
        
        public void navemala(List<Nave>)
        {
            List<Nave> listanaveinvasora = new List<Nave>();
        }
        public void mover ()
        { }
        public void borrar()
        { }
        public void visualizar()
        { }
        public void constructornaves ()
        { }



    }

    class Punto
    {
        public void balas()
        { }
        public void mover()
        { }
        public void colision()
        {
            // enlazar con borrar de nave
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Juego juego = new Juego();
            juego.Inicio();
        }
    }
}
