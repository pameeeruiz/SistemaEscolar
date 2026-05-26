using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entities
{
    public class AlumnosInscritos
    {
        public int id_alumno { get; set; }
        public string Alumno { get; set; }
        public string Matricula { get; set; }
        public string Correo { get; set; }
        public int id_carrera { get; set; }
        public string Carrera { get; set; }
        public int id_inscripcion { get; set; }
        public int id_curso_horario { get; set; }
    }
}
