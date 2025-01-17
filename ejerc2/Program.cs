using System;

namespace ejerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            // HACER UN PROGRAMA QUE SOLICITE 50 NUMEROS ENTEROS Y LOS GUARDE EN UN VECTOR.
            // LUEGO RECORRER TODOS LOS ELEMENTOS DEL VECTOR Y DETERMINAR CUAL ES EL VALOR MAXIMO Y SU 
            // POSICION DENTRO DEL VECTOR.
            
            int a, posicion, valormaximo;
            // sintaxis del vector:(vecto de 50 elementos)
            
            int[] numeros = new int[50];

            for(int x = 0; x < 50; x++){
                Console.WriteLine("INGRESE UN NUMERO");
                a = int.Parse(Console.ReadLine());
                numeros[x] = a;
            }
             
            valormaximo = numeros[0];
            posicion = 1;

            for(int x = 0; x < 50; x++){
                if(numeros[x] > valormaximo){
                    valormaximo = numeros[x];
                    posicion = x + 1;
                }
            }
            Console.WriteLine("EL NUMERO MAXIMO DE LOS 50 NUMEROS ES DE: " + valormaximo + "");
            Console.WriteLine("LA POSICION EN LA QUE FUE INGRESADO ES: " + posicion + "");

             




            
        }
    }
}
