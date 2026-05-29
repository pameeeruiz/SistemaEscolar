using SistemaEscolar.Data;
using SistemaEscolar.Entities;
using ZstdSharp.Unsafe;
using System.Collections.Generic;

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

        public List<Alumnos> GetAlumnos()
        {
            DB db = new DB();
            // Pasamos explícitamente el parámetro _nombre como NULL para que el SP lo reciba
            var parametros = new Dictionary<string, object>
            {
                { "_nombre", DBNull.Value }
            };
            List<Alumnos> alumnos = db.ConsultarStoreProcedure<Alumnos>("spGetAlumnos", parametros);
            return alumnos;
        }
        public List<AlumnosInscritos> GetAlumnosInscritos(int idCursoHorario)
        {
            DB db = new DB();

            List<AlumnosInscritos> lista =
                db.ConsultarStoreProcedure<AlumnosInscritos>(
                    "spGetAlumnosInscritos",
                    new Dictionary<string, object>
                    {
                { "_id_curso_horario", idCursoHorario }
                    }
                );

            return lista;
        }
        public void InscribirAlumno(int idAlumno, int idCursoHorario)
        {
            DB db = new DB();

            db.EjecutarSPNoQuery(
                "spInscribirAlumno",
                new Dictionary<string, object>
                {
            { "_id_alumno", idAlumno },
            { "_id_curso_horario", idCursoHorario }
                }
            );
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


        public void AgregarAlumno(Alumnos alumno)
        {
            DB db = new DB();

            db.EjecutarSPNoQuery(
                "spInsAlumnos",
                new Dictionary<string, object>
                {
            { "_nombre", alumno.nombre },
            { "_matricula", alumno.matricula },
            { "_correo", alumno.correo },
            { "_id_carrera", alumno.id_carrera }
                }
            );
        }

        public void ActualizarAlumno(Alumnos alumno)
        {
            DB db = new DB();

            db.EjecutarSPNoQuery(
                "spUpdAlumnos",
                new Dictionary<string, object>
                {
            { "_id_alumno", alumno.id_alumno },
            { "_nombre", alumno.nombre },
            { "_matricula", alumno.matricula },
            { "_correo", alumno.correo },
            { "_id_carrera", alumno.id_carrera },
            { "_estatus", alumno.Estatus }
                }
            );
        }

        public void EliminarAlumno(int idAlumno)
        {
            DB db = new DB();

            db.EjecutarSPNoQuery(
                "spDelAlumnos",
                new Dictionary<string, object>
                {
            { "_id_alumno", idAlumno }
                }
            );
        }

        public List<Alumnos> BuscarAlumno(string nombre)
        {
            DB db = new DB();

            return db.ConsultarStoreProcedure<Alumnos>(
                "spGetAlumno",
                new Dictionary<string, object>
                {
            { "_nombre", nombre }
                }
            );
        }




        public List<Evaluaciones> GetEvaluaciones(int idCursoHorario)
        {
            DB db = new DB();

            var evaluaciones = db.ConsultarStoreProcedure<Evaluaciones>(
                "spGetEvaluaciones",
                new Dictionary<string, object>
                {
            { "_id_curso_horario", idCursoHorario }
                }
            );

            if (evaluaciones == null || evaluaciones.Count == 0)
            {
                evaluaciones = new List<Evaluaciones>
        {
            new Evaluaciones { id_evaluacion = 0, id_curso_horario = idCursoHorario, Evaluacion = "Parcial 1", Porcentaje = 0.25m },
            new Evaluaciones { id_evaluacion = 0, id_curso_horario = idCursoHorario, Evaluacion = "Parcial 2", Porcentaje = 0.25m },
            new Evaluaciones { id_evaluacion = 0, id_curso_horario = idCursoHorario, Evaluacion = "Parcial 3", Porcentaje = 0.25m },
            new Evaluaciones { id_evaluacion = 0, id_curso_horario = idCursoHorario, Evaluacion = "Ordinario", Porcentaje = 0.25m }
        };
            }

            return evaluaciones;
        }

        public List<CalificacionesXCurso> GetCalificacionesXCurso(int idCurso)
        {
            DB db = new DB();

            return db.ConsultarStoreProcedure<CalificacionesXCurso>(
                "spGetCalificacionesXCurso",
                new Dictionary<string, object>
                {
            { "_id_curso", idCurso }
                }
            );
        }

        public void ActualizarCalificacion(int idInscripcion, int idEvaluacion, decimal calificacion)
        {
            DB db = new DB();

            db.EjecutarSPNoQuery(
                "spInsUpdCalificaciones",
                new Dictionary<string, object>
                {
            { "_id_inscripcion", idInscripcion },
            { "_id_evaluacion", idEvaluacion },
            { "_calificacion", calificacion }
                }
            );
        }
    }
}
