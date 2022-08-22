using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class StopWatch
    {

        public int tiempo;
        public int tiempoTotal = 0;
        public bool vuelta = true;




        public void Arrancar()
        {
            if (vuelta == true)
            {

                this.tiempo = numeroRandom();



                


            }
             
            this.tiempoTotal += this.tiempo;
            
        } 


        public string Parar()
        {
            this.vuelta = false;

            string output = null;

            output = "Time of Travel: " + this.tiempoTotal.ToString(@"dd\.hh\:mm\:ss");

            return output;


        }



        private int numeroRandom()
        {


            return new Random(Guid.NewGuid().GetHashCode()).Next(1, 60);


        }

    }
}
