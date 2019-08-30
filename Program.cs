using System;

namespace Bici
{
    class Program
    {
        static void Main(string[] args)
        {
        Bici bici= new Bici();
        bici.init("Gallito", 8, 12);
        //bici.sube();
        bici.print();
        }
    }

    class Bici {
        
        private string marca; private int current_velocity;
        private int velocities;
        public void print()
        {
             Console.WriteLine("Marca:{0}, Velocity:{1}", marca, current_velocity);
        }
        
          
        public void init(string marca, int cv, int vs)
        {
            this.marca = marca;
            current_velocity = cv;
            velocities = vs; 

            if (cv>vs)
            {
                current_velocity = vs;
            }
               
            else
            {
                current_velocity = cv;
            }
               
        }
        
    }
}
