namespace POO_Static.Classes
{
    public class Conversor
    {
        public static float cotacaoDolar = 5.30f;

        public static float valorUsuario;

        public static float ConverterDolarparaReal(float valorUsuario){

            return valorUsuario * cotacaoDolar;

        }

        public static float ConverterRealparaDolar(float valorUsuario){

            return valorUsuario / cotacaoDolar;
        }
    }
}