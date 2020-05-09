using System.Text.Json.Serialization;

namespace Javeriana.Pica.Core.Entidades
{
    public class Enrollment
    {
        public enum Calificacion
        {
            A,B,C,D,F
        }

        public int EnrollmentID { get; set; }

        public int CursoID { get; set; }

        public int EstudianteID { get; set; }

        public Calificacion CalificacionFinal { get; set; }

        public Curso Curso { get; set; }

        [JsonIgnore]
        public Estudiante Estudiante { get; set; }

    }
}