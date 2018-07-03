using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Usuario
    {
        string Nombre;
        int Puntaje;
        int Tiempo;

        public Usuario(string miNombre, int miPuntaje, int miTiempo)
        {
            Nombre = miNombre;
            Puntaje = miPuntaje;
            Tiempo = miTiempo;
        }
    }
}
