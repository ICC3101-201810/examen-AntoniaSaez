using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Registro
    {
        List<Usuario> usuarios;
        List<ElementosPacman> elementos;
        List<PosicionElemento> posicionesElemento;
        List<PosicionUsuario> posicionesUsuario;

        public Registro()
        {
            usuarios = new List<Usuario>();
            posicionesElemento = new List<PosicionElemento>();
            posicionesUsuario = new List<PosicionUsuario>();
            elementos = new List<ElementosPacman>();
        }

        public void AgregarElemento(ElementosPacman nuevoelemento)
        {
            elementos.Add(nuevoelemento);
        }

        public void AgregarUsuario(Usuario nuevousuario)
        {
            usuarios.Add(nuevousuario);
        }
    }
}
