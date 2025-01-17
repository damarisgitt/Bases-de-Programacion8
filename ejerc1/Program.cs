using System;

namespace ejerc1
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UN PROGRAMA QUE SOLICITE 50 NUMEROS ENTEROS, Y LOS GUARDE EN UN VECTOR.
            //LUEGO RECORRER EL VECTOR Y DETERMINAR E INFORMAR CUAL ES LA SUMA DE LOS VALORES DEL MISMO.

            // vamos a trabajar con vectores
            // asigamos la variable:
            int a;
            // sintaxis del vector:
            int[] numeros = new int[50];

            for(int x = 0; x < 50; x++){
                Console.WriteLine("INGRESE UN NUMERO POR FAVOR");
                a = int.Parse(Console.ReadLine());
                numeros[x] = a;
                }

            int acumulador = 0;

            for(int x = 0; x < 50; x++){
                acumulador += numeros[x];
                }

            Console.WriteLine("LA SUMA DE TODOS LOS NUMEROS INGRESADOS ES DE: " + acumulador + "");
        }
    }
}
