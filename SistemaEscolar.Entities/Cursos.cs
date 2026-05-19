namespace SistemaEscolar.Entities
{
    public class Cursos
    {
        public int id_curso { get; set; }
        public string Curso { get; set; }
        public int Creditos { get; set; }
        public string Carrera { get; set; }
        public int id_carrera { get; set; }
        public bool Activo { get; set; }
        public int id_curso_horario { get; set; }
        public string Docente { get; set; }
        public int id_docente { get; set; }
        public string Aula { get; set; }
        public int id_aula { get; set; }
        public string Horarios { get; set; }
        public int id_horario { get; set; }
        public string Periodo { get; set; }
        public int id_periodo { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Fin { get; set; }
    }


    
}
