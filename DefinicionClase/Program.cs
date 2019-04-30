using System;
using System.Collections.Generic;

namespace DefinicionClase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona persona = new Persona();
            Persona per = new Persona();
            Persona pers = new Persona();

            List<Persona> personas = new List<Persona>();
            persona.Nombre = "Dario";
            persona.Edad = 15;
            Console.WriteLine($"Nombre: {persona.Nombre} Edad: {persona.Edad}");
            Console.WriteLine("Ingrese su nombre");
            per.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            per.Edad = Convert.ToInt32(Console.ReadLine());
            pers.IngresarPersona();
            Console.WriteLine($"Nombre: {per.Nombre} Edad: {per.Edad}");
            personas.Add(persona);
            personas.Add(per);
            personas.Add(pers);
            foreach (var item in personas)
            {
                Console.Write($"Nombre: {item.Nombre} Edad: {item.Edad} ");
            }

            Console.WriteLine("Desea ingresar persona? s/n");
            var res = Console.ReadLine();
            while (res == "s")
            {
                Persona person = new Persona();
                person.IngresarPersona();
                personas.Add(person);
                Console.WriteLine("Desea ingresar persona? s/n");
                res = Console.ReadLine();
            }
            Persona perso = new Persona();
            perso.ListarPersonas(personas);
            Console.ReadLine();*/
            bool result;
            int num;
            try
            {
                Console.WriteLine("Ingrese la letra");
                var letra = Console.ReadLine();                
                result = int.TryParse(letra, out num);
                Console.WriteLine($"Letra es {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error");
            }
            Console.ReadLine();
        }
    }
}
