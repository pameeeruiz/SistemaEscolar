using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entities
{
    public class Alumnos
    {
        public int id_alumno { get; set; }
        public string nombre { get; set; }
        public string matricula { get; set; }
        public string correo { get; set; }
        public int id_carrera { get; set; }
    }

}
