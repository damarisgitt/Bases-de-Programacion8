using System;

namespace ejerc6
{
    class Program
    {
        static void Main(string[] args)
        {
            // DADA UNA LISTA DE 10 NUMEROS, CARGALOS EN UN VECTOR. LUEGO DETECTAR SI EN EL VECTOR HAY ALGUN
            // ELEMENTOS REPETIDO.DE HABERLO, INDICARLO CON UN CARTEL ACLARATORIO "HAY REPETIDOS".
            // PISTA: USAS CICLOS COMBIANDOS.
            
            int num, R, BANDERITA, cont;

            int[] numeros = new int[10];

            
           for(int x = 0; x < 10; x++){
                 Console.WriteLine("carge la lista de 10 numeros");
                 num = int.Parse(Console.ReadLine());

                 numeros[x] = num;
            }
             
            BANDERITA = 0;

            for(int x = 0; x < 10; x++){
                 cont = 0;
                 R = numeros[x];

                for(int y = 0; y < 10; y++){
                    if(R == numeros[y]){
                        cont++;
                    }
                } 
                if(cont >= 2){
                    BANDERITA = 1;
                }
                if(BANDERITA == 1){
                    x = 11;
                }
            }

            if(BANDERITA == 1){
                Console.WriteLine("SI HAY REPETICIONES");
            }else{
                Console.WriteLine("NO HAY REPETICIONES");
            }


        }
    }
}
