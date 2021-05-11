using System;
class ReservaDestinoExtremo:Reservas{
    //Declaración de datos miembros
    private double precioDelViaje=0.0;
    private int destinoElegido;
    private int paqueteDeViaje;
    private double cargoExtra = 0.05;
    // protected double descuento = 0.10;
    public ReservaDestinoExtremo(int destinoTuristico, int numeroDePersonas, double precioDelViaje, int destinoElegido, 
    int paqueteDeViaje, double cargoExtra):base(destinoTuristico, numeroDePersonas)
        {
            this.precioDelViaje=precioDelViaje;
            this.destinoElegido=destinoElegido;
            this.paqueteDeViaje=paqueteDeViaje;
            this.cargoExtra=cargoExtra;
    }
    public void planearViajeExtremo()
    {
        //Método heredado de la clase padre
        Informacion();
    }
    public void obtenerPrecioExtremo()
    {
        System.Console.WriteLine("****************************");
        System.Console.WriteLine("***** Destino extremo *****");
        System.Console.WriteLine("****************************");
        //Método heredado de la clase padre
        Informacion();
        if(paqueteDeViaje==1){
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("*****  Paquete Bronce  *****");
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("El costo por persona es de " + precioDelViaje);
            System.Console.WriteLine("El cargo extra por las " + Personas + " personas es de " + (precioDelViaje*numeroDePersonas)*0.05);
            double total = (precioDelViaje*numeroDePersonas)+((precioDelViaje * numeroDePersonas)*0.05);
            System.Console.WriteLine("El costo total es de "+total);
        }else if(paqueteDeViaje==2){
            double precioextra = 5000;
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("*****  Paquete Plata  *****");
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("El costo por persona es de " + precioDelViaje);
            System.Console.WriteLine("El precio Extra por persona es de " + (precioextra*numeroDePersonas));
            System.Console.WriteLine("El cargo extra por las " + Personas + " personas es de " + (precioDelViaje*numeroDePersonas)*0.05);
            double total = (precioDelViaje*numeroDePersonas)+((precioDelViaje * numeroDePersonas)*0.05)+(precioextra*numeroDePersonas);
            System.Console.WriteLine("El costo total es de "+total);
        }else if(paqueteDeViaje==3){
            double precioextra = 9000;
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("*****  Paquete Oro  *****");
            System.Console.WriteLine("****************************");
            System.Console.WriteLine("El costo por persona es de " + precioDelViaje);
            System.Console.WriteLine("El precio Extra por persona es de " + (precioextra*numeroDePersonas));
            System.Console.WriteLine("El cargo extra por las " + Personas + " personas es de " + (precioDelViaje*numeroDePersonas)*0.05);
            double total = (precioDelViaje*numeroDePersonas)+((precioDelViaje * numeroDePersonas)*0.05)+(precioextra*numeroDePersonas);
            System.Console.WriteLine("El costo total es de "+total);
        }

    }
    public void limpiarPlaneacionExtremo()
    {
        //Método heredado de la clase padre
        Informacion();
    }
    ~ReservaDestinoExtremo() {
        destinoTuristico=0; 
        numeroDePersonas=0;
        precioDelViaje=0.00;
        destinoElegido=0;
        paqueteDeViaje=0;
        cargoExtra=0.05;
        Console.Write("Los valores han sido reseteados");
    } 
}