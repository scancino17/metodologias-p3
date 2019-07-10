using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSineitor
{
    class Mensaje
    {
        int numero { get; set; }
        string mensaje { get; set; }

        Mensaje(int _numero, string _mensaje)
        {
            if (_numero >= 1000000000) throw new Exception("Número no válido");
            if(_mensaje.Length > 50) throw new Exception("Mensaje no válido");
            numero = _numero;
            mensaje = _mensaje;
        }

        public override string ToString()
        {
            return mensaje;
        }

    }
}
