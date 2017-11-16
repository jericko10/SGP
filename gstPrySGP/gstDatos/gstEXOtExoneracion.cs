namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstEXOtExoneracion")]
    public partial class gstEXOtExoneracion
    {
        [Key]
        public int EXOcodigo { get; set; }

        public int DEUcodigo { get; set; }

        [Required]
        [StringLength(100)]
        public string EXOmotivo { get; set; }

        [StringLength(250)]
        public string EXOdescripcion { get; set; }

        public virtual gstDEUtDeuda gstDEUtDeuda { get; set; }
    }
}
