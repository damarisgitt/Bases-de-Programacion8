using System;

namespace ejerc7
{
    class Program
    {
        static void Main(string[] args)
        {
            // UNA EMPRESA COMIERZALIZA 15 TIPOS DE ARTICULOS Y POR CADA VENTA REALIZADA
            // GENERA UN REGISTO CON LOS SIGUIENTES DATOS:
            // *NUMERO DE ARTICULO (1 A 15)
            // *CANTIDAD VENDIDA.
            // PUEDEN HABER VARIOS REGISTROS PARA EL MISMO ARTICULOS Y EL ULTIMO SE INDICA
            // NUMERO DE ARTICULO IGUAL A CERO.
            // SE PIDE DETERMINAR E INFORMAR:
            // *EL NUMERO DE ARTICULO QUE MAS SE VENDIO EN TOTAL.
            // *LOS NUMEROS DE ARTICULOS QUE NO REGISTRARON VENTAS.
            // *LA CANTIDAD DE UNIDADES VENDIDAS PARA EL ARTICULO NUMERO 10.
            // NOTA: TENE EN CUANTA EL CONCEPTO DE REGISTRO Y EL PLANTEO DE ESTRUCTURA PRINCIPAL SEPARADO 
            // DE CONSIGNAS(VER VIDEOS DE CICLOS COMBINADOS Y EJERCICIOS RESUELTOS DE CICLOS COMBINADOS).

            int[] articulos = new int[15];
            // inicializamos 15 acumuladores en 0.
            for(int x = 0; x < 15; x++){
                articulos[x] = 0;
            }
             
            int articulo, cantidadvendida, numerodearticulo, ventamaxima;
            
            
            Console.WriteLine("ingrese el numero de articulo (1-15)");
            articulo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad vendida de este articulo");
            cantidadvendida = int.Parse(Console.ReadLine());

            while(articulo != 0){
             articulos[articulo - 1] += cantidadvendida;

             Console.WriteLine("ingrese el numero de articulo (1-15)");
             articulo = int.Parse(Console.ReadLine());
             Console.WriteLine("ingrese la cantidad vendida de este articulo");
             cantidadvendida = int.Parse(Console.ReadLine());
            }
             // punto a: 
             ventamaxima = articulos[0];
             numerodearticulo = 1;

            for(int x = 0; x < 15; x++){
                if(articulos[x] > ventamaxima){
                    ventamaxima = articulos[x];
                    numerodearticulo = x + 1;
                }
            }
             // punto b
            for(int x = 0; x < 15; x++){
                if(articulos[x] == 0){
                   Console.WriteLine("el articulo " + (x + 1) + " no tuvo ventas");
                }
            }

            Console.WriteLine("EL NUMERO DE ARTICULO QUE MAS SE VENDIO EN TOTAL FUE: " + numerodearticulo + "");
            Console.WriteLine("LA CANTIDAD DE UNIDADES QUE SE VENDIO PARA EL ARTICULO NUMERO 10 FUE DE: " + articulos[9] + "");

        }
    }    
}
