using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Usuario
    {
        string Nombre;
     
        

        public Usuario(string miNombre)
        {
            Nombre = miNombre;
           
        }
    }
}
