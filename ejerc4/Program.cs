using System;

namespace ejerc4
{
    class Program
    {
        static void Main(string[] args)
        {
            // DADA UNA LISTA DE 10 NUMEROS ENTEROS, CARGALOS EN UN VECTOR. LUEGO DETERMINAR E INFORMAR 
            // SI EL VECTOR ESTA ORDENADO DE FORMA CRECIENTE.

            int a, BANDERA, MAXIMO;

            int[] numeros = new int[10];

            for(int x = 0; x < 10; x++){
                Console.WriteLine("INGRESE UN NUMERO POR FAVOR");
                a = int.Parse(Console.ReadLine());
                numeros[x] = a;
            }
            
            BANDERA = 1;
            MAXIMO = numeros[0];

            for(int x = 0; x < 10; x++){
                if(numeros[x] >= MAXIMO){
                    MAXIMO = numeros[x];
                }else{
                    BANDERA = 0;
                }
            }

            if(BANDERA == 1){
                Console.WriteLine("LOS VALORES SI ESTAN ORDENADOS DE FORMA CRECIENTE");
            }else{
                Console.WriteLine("LOS VALORES NO ESTAN ORDENADOS DE FORMA CRECIENTE");
            }


        }
    }
}
