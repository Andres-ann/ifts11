using System;

namespace Ejemplos_Clases
{

    struct Persona
    {
        /*
        Por ejemplo en el siguiente ejemplo se define una estructura para guardar cierta informacion relativa a las personas, por ejemplo para ser utilizadas en un instituto, en un sistema de
        gestion de turnos, etc.
        */
        string nombre;
        string apellido;
        int edad;
        string dni;
    };

    /*
    Para una aplicacion matematica que realice calculos con numeros complejos y operaciones sobres objetos geometricos podria definir 
    */
    struct NComplejo
    {
        int real;
        int imaginario;
    };
    struct Punto
    {
        int x;
        int y;
    };
    struct Circulo
    {
        Punto centro; // observar como una estructura puede incluir otras.
        int radio;
    };
    struct Rectangulo
    {
        int x1, y1;
        int x2, y2;
        int x3, y3;
        int x4, y4;
    };
    // otra forma incluyendo otras estructuras.
    struct RectanguloV2
    {
        Punto v1, v2, v3, v4;
    };

    /*
    En el siguiente ejemplo podria ser una estructura definida dentro de un programa que
    maneje las ventas de un local, en particular en este caso los datos de un cliente.
    */
    struct Fecha
    {
        short dia;
        short mes;
        short anio;
    };
    struct Cliente
    {
        Persona datosBasicos;
        float credito;
        float descuento;
        string preferencias;
        Fecha ultimaCompra;
        string opiniones;
        string email;
    };


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}