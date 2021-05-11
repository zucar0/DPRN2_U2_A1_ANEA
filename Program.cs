using System;

namespace DPRN2_U2_A1_ANEA
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion=0;
            while(eleccion==0||eleccion==1||eleccion==2||eleccion==3||eleccion==4){
                do{
                    Console.WriteLine("*******************************************\nBienvenido al inicio de tu viaje espacial\n*******************************************");
                    Console.WriteLine("Las fechas de viaje son de tiempo definido en 3 días y 4 noches (terrestres) sin opción a modificación");
                    Console.WriteLine("Por favor elige qué deseas realizar:\n1.- Planear un viaje\n2.- Obtener precio\n3.- Limpiar planeación\n4.- Salir");
                    var opcion = Console.ReadLine();
                    eleccion = int.Parse(opcion);
                    switch(eleccion)
                    {
                        case 1 when (eleccion==1):
                        System.Console.WriteLine("Haz elegido Planear un viaje. Felicidades");
                        System.Console.WriteLine("Por favor elige alguno de los destinos disponibles son los siguientes:");
                        System.Console.WriteLine("1.-Tatooine\n2.-Alderaan\n3.-Yavin IV\n4.-Hoth");
                        var destinoseleccionado = Console.ReadLine();
                        int destine = int.Parse(destinoseleccionado);
                        if(destine==1){
                            System.Console.WriteLine("Los paquetes para Tatooine son los siguientes: ");
                            System.Console.WriteLine("1.-Bronce\n2.-Plata\n3.-Oro\nElige el paquete deseado.");
                            var paquete = Console.ReadLine();
                            int package = int.Parse(paquete);
                            System.Console.WriteLine("¿Cuántas personas viajarán?");
                            var personas = Console.ReadLine();
                            int person = int.Parse(personas);
                            double precioporpersona = 9600.00;
                            // double total = (precioporpersona * person)*0.05;
                            ReservaDestinoExtremo reservaextremo = new ReservaDestinoExtremo(1,person,precioporpersona,1,package,0.05);
                            reservaextremo.obtenerPrecioExtremo();
                        }else if(destine==2){
                            System.Console.WriteLine("Los paquetes para Aldreaan son los siguientes: ");
                            System.Console.WriteLine("1.-Bronce\n2.-Plata\n3.-Oro\nElige el paquete deseado.");
                            var paquete = Console.ReadLine();
                            int package = int.Parse(paquete);
                            
                        }else if(destine==3){
                            System.Console.WriteLine("Los paquetes para Yavin son los siguientes: ");
                            System.Console.WriteLine("1.-Bronce\n2.-Plata\n3.-Oro\nElige el paquete deseado.");
                            var paquete = Console.ReadLine();
                            int package = int.Parse(paquete);
                        }else if(destine==4){
                            System.Console.WriteLine("Los paquetes para Hoth son los siguientes: ");
                            System.Console.WriteLine("1.-Bronce\n2.-Plata\n3.-Oro\nElige el paquete deseado.");
                            var paquete = Console.ReadLine();
                            int package = int.Parse(paquete);
                            System.Console.WriteLine("¿Cuántas personas viajarán?");
                            var personas = Console.ReadLine();
                            int person = int.Parse(personas);
                            double precioporpersona = 8790.00;
                            //double total = (precioporpersona * person)*0.05;
                            ReservaDestinoExtremo reservaextremo = new ReservaDestinoExtremo(4,person,precioporpersona,4,package,0.05);
                            reservaextremo.obtenerPrecioExtremo();
                        }else{
                            System.Console.WriteLine("Por favor elige un destino dentro de nuestras cuatro opciones.");
                        }
                            break;
                        case 2 when (eleccion==2):
                        System.Console.WriteLine("Haz elegido obtener un precio");
                            break;
                        case 3 when (eleccion==3):
                        System.Console.WriteLine("Has limpiado los valores de la planeación");
                        System.Console.WriteLine("¿Qué deseas hacer?\n1.- Planear otro viaje\n2.- Obtener precio\n3.- Limpiar planeación\n4.- Salir");
                        var nuevaopcion = Console.ReadLine();
                        eleccion = int.Parse(nuevaopcion);
                        if(eleccion==3){
                            eleccion=0;
                        }
                        else if(eleccion==4){
                            System.Console.WriteLine("Haz elegido salir. Hasta luego.");
                        }
                        break;
                        case 4 when (eleccion==4):
                        System.Console.WriteLine("Has elegido salir. ¡Hasta luego!");
                        break;
                        default:
                            Console.WriteLine("Error: Elige una opción válida.");
                            break;
                    }
                    if(eleccion==1 || eleccion==2){
                        System.Console.WriteLine("¿Qué deseas hacer?\n1.- Planear otro viaje\n2.- Obtener precio\n3.- Limpiar planeación");
                        var quedesea = Console.ReadLine();
                        var nuevaeleccion = int.Parse(quedesea);
                        if(nuevaeleccion==1){
                            eleccion = nuevaeleccion;
                        }
                        else if(nuevaeleccion==2){
                            eleccion =nuevaeleccion;
                        }
                        else if (nuevaeleccion==3){
                            System.Console.WriteLine("Se han reseteado los valores");
                        }
                    }else if(eleccion==4){
                        Environment.Exit(0);
                    }
                }while(eleccion==1||eleccion==2||eleccion==3);
            }
        }
    }
}
