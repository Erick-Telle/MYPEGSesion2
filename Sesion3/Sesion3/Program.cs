using Sesion3.Clases;

namespace Sesion3
{
    internal class Program
    {
        //Calcular la edad de una persona y decir si es mayor o menor de edad
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            string nombre;
            DateTime fechaNac;
            Console.WriteLine("Nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Fecha de nacimiento: ");
            fechaNac = DateTime.Parse(Console.ReadLine());
            persona.Nombre = nombre;
            persona.FechaNaci = fechaNac;
            Console.WriteLine(persona.EvaluarEdad());

        }
    }
}
