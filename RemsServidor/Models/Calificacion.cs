//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RemsServidor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificacion
    {
        public int Id { get; set; }
        public string Notas { get; set; }
        public int EstudianteId { get; set; }
        public int AsignaturaId { get; set; }
    
        public virtual Estudiante Estudiante { get; set; }
        public virtual Asignatura Asignatura { get; set; }
    }
}
