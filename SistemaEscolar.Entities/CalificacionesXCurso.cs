using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar.Entities
{
    public class CalificacionesXCurso
    {
        public string Alumno { get; set; } = string.Empty;
        public int id_inscripcion { get; set; }

        public decimal Parcial1 { get; set; }
        public decimal pParcial1 { get; set; }

        public decimal Parcial2 { get; set; }
        public decimal pParcial2 { get; set; }

        public decimal Parcial3 { get; set; }
        public decimal pParcial3 { get; set; }

        public decimal Ordinario { get; set; }
        public decimal pOrdinario { get; set; }

        public decimal Final { get; set; }
    }
}
