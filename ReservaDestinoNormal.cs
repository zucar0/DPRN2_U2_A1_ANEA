using System;
class ReservaDestinoNormal:Reservas{
    //Declaración de datos miembros    
    private double precioDelViaje=0.0;
    private int destinoElegido;
    private int paqueteDeViaje;
    // private double cargoExtra = 0.05;
    protected double descuento = 0.10;

    public ReservaDestinoNormal(int destinoTuristico, int numeroDePersonas, double precioDelViaje, int destinoElegido,
    int paqueteDeViaje, double descuento):base(destinoTuristico, numeroDePersonas)
        {
            this.precioDelViaje=precioDelViaje;
            this.destinoElegido=destinoElegido;
            this.paqueteDeViaje=paqueteDeViaje;
            this.descuento=descuento;
    }

    public void planearViajeNormal()
    {
        //Método heredado de la clase padre
        Informacion();
    }
    public void obtenerPrecioNormal()
    {
        //Método heredado de la clase padre
        Informacion();
    }
    public void limpiarPlaneacionNormal()
    {
        //Método heredado de la clase padre
        Informacion();
    }
    ~ReservaDestinoNormal() {
        destinoTuristico=0; 
        numeroDePersonas=0;
        precioDelViaje=0.00;
        destinoElegido=0;
        paqueteDeViaje=0;
        descuento=0.10;
        Console.Write("Los valores han sido reseteados");
    } 

}