using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Direccion
    {
        int id = 0;
        string direccion = "";
        char codigo_postal;

        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public char Codigo_postal { get => codigo_postal; set => codigo_postal = value; }
    }
}
