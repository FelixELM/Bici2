using System;
using System.Collections.Generic;

namespace Bici
{
    class Program
    {
        static void Main(string[] args)
        {
        Bici bici1 = new Bici();
        bici1.init("Huffy", 8, 12);
        //bici.sube();
        bici1.print();

        Bici bici2 = new Bici();
        bici2.init("PineStar", 5, 10);
        bici2.print();

        Bici bici3 = new Bici();
        bici3.init("Apache", 9, 13);
        bici3.print();

        List<Bici> bicis = new List <Bici>();
        bicis.Add(bici1);
        bicis.Add(bici2);
        bicis.Add(bici3);
        //foreach 

        Persona usuario = new Persona();
        usuario.init("Felix","felixenriquelm45@gmail.com");
        usuario.print();
        }
    }

        class Persona
        {
            private string nombre;
            private string correo;

            public void init(string n, string c)
            {
                nombre = n;
                correo = c;
            }
            
            public void print()
            {
                Console.WriteLine("{0} {1}", nombre, correo);
            }
        }
    class Bici 
    {
        
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
