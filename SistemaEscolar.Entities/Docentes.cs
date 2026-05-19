using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entities
{
    public class Docentes
    {
        public int id_docente { get; set; }

        public string nombre { get; set; }

        public string correo { get; set; }

        public string telefono { get; set; }

        public int id_departamento { get; set; }
    }
}
