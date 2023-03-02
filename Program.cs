using System;

namespace PracticasPOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Circulo miCirculo; //creacion de objeto de tipo circuo. Variable de tipo círculo.

            miCirculo = new Circulo(); //Iniciacion de variable/objeto de tipo circulo. Instaciar una clase.
            //Instanciación. Ejemplarizacion. Creación de ejemplar de clase.

            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.CalculoArea(9));

            Console.WriteLine(miCirculo.CalculoArea(10));
            
            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.cambiarValorEuro(1.45);

            Console.WriteLine(obj.convierte(50));

        }
    }

    class Circulo
    {

        private const double pi = 3.1416;     //propiedad de la clase Circulo. campo de clase.

        public double CalculoArea(int radio)   //método de clase. ¿que pueden hacer los objetos de tipo círculo?.
        {

            return pi * radio * radio;  

        }

    }

    class ConversorEuroDolar
    {

        private double euro = 1.253;

        public double convierte(double cantidad)
        {

            return cantidad * euro;

        }
         public void cambiarValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = 1.253;

            else
                euro = nuevoValor;

        }
    }

}