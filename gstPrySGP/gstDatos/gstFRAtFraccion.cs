namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstFRAtFraccion")]
    public partial class gstFRAtFraccion
    {
        [Key]
        public int FRAcodigo { get; set; }

        public int CUOcodigo { get; set; }

        public int ALMcodigo { get; set; }

        public virtual gstALMpAlumno gstALMpAlumno { get; set; }
    }
}
