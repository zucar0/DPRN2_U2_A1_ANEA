
public class Reservas{
    //Constructor vacío. 
    public Reservas(){

    }
    //Declaración de datos miembro.
    protected string destinoTuristico="1.Tatooine \n 2. Hoth \n 3.Alderaan \n 4. Yavin IV \n" ;
    protected int numeroDePersonas;
    protected string tiempoDeViaje="3 días y 4 noches (terrestres). *Sin opción de modificación.";

    
    //Método Reservas con parámetros
    public Reservas(string destinoTuristico, int numeroDePersonas, string tiempoDeViaje){
        this.destinoTuristico=destinoTuristico;
        this.numeroDePersonas=numeroDePersonas;
        this.tiempoDeViaje=tiempoDeViaje;
    }
    public void Informacion(){
        System.Console.WriteLine("Destino turístico: "+ destinoTuristico);
        System.Console.WriteLine("Número de persona: "+ numeroDePersonas);
        System.Console.WriteLine("Tiempo de viaje: "+ tiempoDeViaje);
    }
}