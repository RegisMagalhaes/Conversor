using System;
using POO_Static.Classes;

namespace POO_Static
{
    class Program
    {
        static void Main(string[] args)
        {

            Conversor calculadora = new Conversor();

            // Classes estáticas não podem ser instanciadas

            // Em que momento usamos classes estáticas?
            // Quando precisamos de uma solução que pode servir para qualquer aplicação
            //Em que momento não usamos classes estáticas? 
            //Quando tivermos objetos/classes em que são específicas de um tipo de aplicação


            Console.WriteLine(Conversor.ConverterDolarparaReal(35f));
            Console.WriteLine(Conversor.ConverterRealparaDolar(12f));
           
            

            //este método tbm tem que ser static em sua declaração

            
        }

        static void Testar(){

        }
    }
}
