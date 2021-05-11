
public class Reservas{
    //Constructor vacío. 
    public Reservas(){

    }
    //Declaración de datos miembro.
    protected int destinoTuristico;
    protected int numeroDePersonas;

    
    //Método Reservas con parámetros
    public Reservas(int destinoTuristico, int numeroDePersonas){
        this.destinoTuristico=destinoTuristico;
        this.numeroDePersonas=numeroDePersonas;
    }
    public void Informacion(){
        if(destinoTuristico==1)
        {
            System.Console.WriteLine("Destino turístico: "+ destinoTuristico +".- Tatooine.");
        }else if(destinoTuristico==2)
        {
            System.Console.WriteLine("Destino turístico: "+ destinoTuristico +".- Alderaan.");
        }
        else if(destinoTuristico==3)
        {
            System.Console.WriteLine("Destino turístico: "+ destinoTuristico +".- Yavin IV.");
        }
        else if(destinoTuristico==4)
        {
            System.Console.WriteLine("Destino turístico: "+ destinoTuristico +".- Hoth.");
        }
        System.Console.WriteLine("Número de personas: "+ numeroDePersonas);
    }

     //Interfaz para la cantidad de personas
    public int Personas{
        get{
            return numeroDePersonas;
        }
        set{
            if(value <= 0){
                numeroDePersonas=0;
            }
            else{
                numeroDePersonas=value;
            }
        }
    }
    //Interfaz para el destino turístico
    public int Destino{
        get{
            return destinoTuristico;
        }
        set{ 
            destinoTuristico = value;
        }
    }
    //Destructor
    ~Reservas() {
        destinoTuristico=0; 
        numeroDePersonas=0;
        // Console.Write("Este es el destructor ejecutándose para destruir el objeto de la clase Factura");
    } 
}