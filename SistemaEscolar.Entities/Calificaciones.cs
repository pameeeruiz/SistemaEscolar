using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entities
{
    public class Calificaciones
    {
        public int id_calificacion { get; set; }
        public int id_inscripcion { get; set; }
        public int id_evaluacion { get; set; }
        public decimal Calificacion { get; set; }
    }
}
