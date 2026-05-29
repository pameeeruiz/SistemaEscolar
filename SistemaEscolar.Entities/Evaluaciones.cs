using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entities
{
    public class Evaluaciones
    {
        public int id_evaluacion { get; set; }
        public int id_curso_horario { get; set; }
        public string Evaluacion { get; set; } = string.Empty;
        public decimal Porcentaje { get; set; }
    }
}
