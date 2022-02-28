using System;

namespace EjercicioAleatorio
{
    class program
    {
        public const int contador = 3;



        public static void Main()
        {
            
            int aleatorio;
            int introducido;
            int contador;
            Random Generador = new Random();
            aleatorio = Generador.Next(0, 16);

            Console.Write("*******BIENVENIDO AL JUEGO DE LA RULETA********");
            contador = 3;
            Console.WriteLine("\n\n ******GIRANDO LA RULETA******");

            do
            {
                //Pedir Numero
                Console.Write("\n \n Intentos restantes:" + contador);
                Console.WriteLine("\n\nApuesta a un numero:");
                Console.WriteLine("\nNumero");
                introducido = Convert.ToInt32(Console.ReadLine());

                

                //Si introducido>aleatorio,Escribir "El numero introducido es mayor que el Generado"
                if (introducido > aleatorio)
                {
                    Console.WriteLine("Te has pasado:");

                }
                //Si introducido>aleatorio,Escribir "El numero introducido es menor que el Generado"
                if (introducido < aleatorio)
                {
                    Console.WriteLine("Te quedaste corto:");
                }

                contador--;
            }
            //Hasta que el introducido =aleatorio o contador=0
            while ((introducido!=aleatorio) && (contador>0));
            
            //Si  introducido == aleatorio ,felicidades
            if(introducido==aleatorio)
            {
                Console.WriteLine("Enhorabuena ,el numero era;" + aleatorio);

            }
            //Si introducido es != aleatorio mostrar por pantalla el numero aleatorio
            else
            {
                Console.WriteLine("El numero era:" + aleatorio);
            }
            
            
            











        }

    }
}
