using Javeriana.Pica.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using static Javeriana.Pica.Core.Entidades.Enrollment;

namespace Javeriana.Pica.Core.Data
{
    public static class DbInitializer
    {
        public static void Initialize(EscuelaContext context)
        {
            context.Database.EnsureCreated();

            var estudiantes = new Estudiante[]
            {
                new Estudiante { Nombre = "Pepito", Apellido = "Perez", EnrollmentDate = DateTime.Now },
                new Estudiante { Nombre = "Juanito", Apellido = "Juarez", EnrollmentDate = DateTime.Now }
            };

            context.Estudiantes.AddRange(estudiantes);
            context.SaveChanges();

            var cursos = new Curso[]
            {
                new Curso { CursoID = 101, Titulo = "Pica" , Creditos = 3},
                new Curso { CursoID = 102, Titulo = "Net", Creditos = 4},
                new Curso { CursoID = 103, Titulo = "Modelado", Creditos= 5}
            };

            context.Cursos.AddRange(cursos);
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment { EstudianteID = 1, CursoID = 101, CalificacionFinal = Calificacion.A },
                new Enrollment { EstudianteID = 2, CursoID = 101, CalificacionFinal = Calificacion.B },
                new Enrollment { EstudianteID = 2, CursoID = 102, CalificacionFinal = Calificacion.B },
                new Enrollment { EstudianteID = 2, CursoID = 103,CalificacionFinal = Calificacion.B },
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
    }
}
