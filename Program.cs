using System;
using static System.Console;

namespace maquinaMonedas {
    class Program {
        static void Main (string[] args) {
            int precioArticulo = 0;
            int resta = 0;
            int cantidadPeso = 0;
            int moneda1 = 100;
            int moneda2 = 50;
            int moneda3 = 25;
            int moneda4 = 5;
            int moneda5 = 1;
            WriteLine ("¿Cuál es el precio del artículo que usted desea?");
            precioArticulo = Convert.ToInt32 (ReadLine ());
            WriteLine ("Ingrese el dinero a pagar");
            cantidadPeso = Convert.ToInt32 (ReadLine ());
            if (cantidadPeso == precioArticulo) {
                WriteLine ("No tiene vuelta");
            } else if (cantidadPeso < precioArticulo) {
                WriteLine ("El dinero ingresado no es suficiente");
            } else if (cantidadPeso > precioArticulo) {
                resta = cantidadPeso - precioArticulo;
                WriteLine ("Le resta:" + resta);
                for (int i = 0; i <= resta; i++) {
                    if (moneda1 <= resta) {
                        resta = resta - moneda1;
                        WriteLine (moneda1);
                    }
                    if (moneda2 <= resta) {
                        resta = resta - moneda2;
                        WriteLine (moneda2);
                    }
                        if (moneda3 <= resta) {
                            resta = resta - moneda3;
                            WriteLine (moneda3);
                        }
                        if (moneda4 <= resta) {
                            resta = resta - moneda4;
                            WriteLine (moneda4);
                        }
                        if (moneda5 <= resta) {
                            resta = resta - moneda5;
                            WriteLine (moneda5);
                        }
                    }
                }
            }
        }
    }
