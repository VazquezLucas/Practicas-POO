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

            Console.WriteLine(miCirculo.calculoArea(5));

            Circulo miCirculo2 = new Circulo();

            Console.WriteLine(miCirculo2.calculoArea(9));

        }
    }

    class Circulo
    {

        double pi = 3.1416;     //propiedad de la clase Circulo. campo de clase.

        public double calculoArea(int radio)   //método de clase. ¿que pueden hacer los objetos de tipo círculo?.
        {

            return pi * radio * radio;  

        }

    }
}