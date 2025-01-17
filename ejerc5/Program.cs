using System;

namespace ejerc5
{
    class Program
    {
        static void Main(string[] args)
        {
            // hacer un programa que solicite una serie de valores de tipo char (caracteres)
            //se entiende por caracter a cada elemento que se obtiene de presionar una tecla. por ejemplo el valor 
            // "25" tiene dos caracteres, si quisieramos guardalas en variables enteras nos alcanzaria con solo una,
            //pero si queremos guardalas en variables char, necesitariamos dos; la frase: ludmila hermosa tiene 15, 
            // ya que el espacio cuanta como un caracter.
            // la cantidad de valores sera como maximo 50, pero el programa puede cortar antes si se ingresa el caracter "."
            //una vez cargado el vector de char, recorrerlo y remplazar todas las apariciones de la letra "a" por "e".
            // finalmente mostrar el resultado en pantalla.
            // nota: necesitamos un vector de char de 50, pero no lo cargamos con for.

            char[] oraciones = new char[50];

            char letras;
            int L;

            
            Console.WriteLine("ingrese letra por letra, y cortas con un punto");
            letras = char.Parse(Console.ReadLine());

            L = 0;

            while (letras != '.' && L <= 50){
                oraciones[L] = letras;
                letras = char.Parse(Console.ReadLine());
                L++;
            }

            for (int x = 0; x < 50; x++){
                if(oraciones[x] == 'a'){

                   oraciones[x] = 'e';
                }
                
            }

            L = 0;

            while (oraciones[L] != '.' && L < 50){

            Console.WriteLine(oraciones[L]);

            L++;
            }

        }
    }
}
