using SistemaEscolar.Data;
using SistemaEscolar.Entities;
using ZstdSharp.Unsafe;


namespace SistemaEscolar.Business
{
    public class Context
    {

        public List<Cursos> GetCursos()
        { DB dB = new DB();
            List<Cursos> cursos = dB.ConsultarStoreProcedure<Cursos>("spGetCursos");
            return cursos;
        }

        public List<Docentes> getDocentes()
        {
            DB db = new DB();
            List<Docentes> docentes = db.ConsultarStoreProcedure<Docentes>("spGetDocentes");
            return docentes;
        }

        public List<Horarios> getHorarios()
        {
            DB db = new DB();
            List<Horarios> horarios = db.ConsultarStoreProcedure<Horarios>("spGetHorarios");
            return horarios;
        }
        public List<Carreras> getCarreras()
        {
            DB db = new DB();
            List<Carreras> carreras = db.ConsultarStoreProcedure<Carreras>("spGetCarreras");
            return carreras;
        }

        public List<Aulas> getAulas()
        {
            DB db = new DB();
            List<Aulas> aulas = db.ConsultarStoreProcedure<Aulas>("spGetAulas");
            return aulas;
        }

        public List<Periodos> getPeriodos()
        {
            DB db = new DB();
            List<Periodos> peridos = db.ConsultarStoreProcedure<Periodos>("spGetPeriodos");
            return peridos;
        }

        public void AgregarCurso(Cursos curso)
        {
            DB db = new DB();
            db.EjecutarSPNoQuery("spInsCurso",
                    new Dictionary<string, object>
                    {
                { "_id_curso", curso.id_curso },
                { "_nombre", curso.Curso },
                { "_creditos", curso.Creditos },
                { "_id_carrera", curso.id_carrera },
                { "_id_docente", curso.id_docente },
                { "_id_aula", curso.id_aula },
                { "_id_horario", curso.id_horario },
                { "_id_periodo", curso.id_periodo },
                    }
                );
        }

        public void ActualizarCurso(Cursos curso)
        {
            DB db = new DB();

            db.EjecutarSPNoQuery(
                "spUpdCursos",
                new Dictionary<string, object>
                {
            { "_id_curso", curso.id_curso },
            { "_nombre", curso.Curso },
            { "_creditos", curso.Creditos },
            { "_id_carrera", curso.id_carrera },
            { "_id_curso_horario", curso.id_curso_horario },
            { "_id_docente", curso.id_docente },
            { "_id_aula", curso.id_aula },
            { "_id_horario", curso.id_horario },
            { "_id_periodo", curso.id_periodo }
                }
            );
        }

    }
}
