class ReservaDestinoExtremo:Reservas{
    //Declaración de datos miembros
    private double precioDelViaje=0.0;
    private int destinoElegido;
    private int paqueteDeViaje;
    private double cargoExtra = 0.05;
    // protected double descuento = 0.10;
    public ReservaDestinoExtremo(string destinoTuristico, int numeroDePersonas, string tiempoDeViaje, double precioDelViaje, int destinoElegido, 
    int paqueteDeViaje, double cargoExtra):base(destinoTuristico, numeroDePersonas, tiempoDeViaje)
        {
            this.precioDelViaje=precioDelViaje;
            this.destinoElegido=destinoElegido;
            this.paqueteDeViaje=paqueteDeViaje;
            this.cargoExtra=cargoExtra;
    }
    public void calculoDestinoExtremo()
    {
        //Método heredado de la clase padre
        Informacion();

    }
}