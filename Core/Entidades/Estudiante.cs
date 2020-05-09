using System;
using System.Collections.Generic;
using System.Text;

namespace Javeriana.Pica.Core.Entidades
{
    public class Estudiante
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
