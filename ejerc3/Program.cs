using System;

namespace ejerc3
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UN PROGRAMA QUE SOLICITE 100 NUMEROS ENTEROS Y LOS GUARDE EN UN VECTOR.
            // LUEGO RECORRER ESE VECTOR PARA CALCULAR EL PROMEDIO, MOSTRAR POR PANTALLA LOS VALORES DEL VECTOR
            // QUE SON MAYOR AL PROMEDIO CALCULADO.

            int a, PROMEDIO, acumulador;

            int[] numeros = new int[100];

            for(int x = 0; x < 100; x++){
                Console.WriteLine("INGRESE UN NUMERO POR FAVOR");
                a = int.Parse(Console.ReadLine());
                numeros[x] = a;
            }

            acumulador = 0;

            for(int x = 0; x < 100; x++){
                acumulador += numeros[x];
            }

            PROMEDIO = acumulador / 100;

            for(int x = 0; x < 100; x++){
                if( numeros[x] > PROMEDIO){
                     Console.WriteLine("ESTE VALOR ES MAYOR AL MAXIMO DEL PROMEDIO: " + numeros[x] + "");
                }

            }
        }
    }
}
