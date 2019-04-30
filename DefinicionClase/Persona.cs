using System;
using System.Collections.Generic;
using System.Text;

namespace DefinicionClase
{
    public class Persona
    {
        #region Propiedades
        public int Edad { get; set; }
        public string Nombre { get; set; }
        #endregion

        public void IngresarPersona()
        {
            Console.WriteLine("Ingrese su nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad");
            Edad = Convert.ToInt32(Console.ReadLine());
        }
        public void ListarPersonas(List<Persona> user)
        {
            foreach (var item in user)
            {
                Console.Write($"Nombre: {item.Nombre} Edad: {item.Edad} ");
            }
        }
    }
}
