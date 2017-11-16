namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstDEUtDeuda")]
    public partial class gstDEUtDeuda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gstDEUtDeuda()
        {
            gstDPGtDeudaPago = new HashSet<gstDPGtDeudaPago>();
            gstEXOtExoneracion = new HashSet<gstEXOtExoneracion>();
        }

        [Key]
        public int DEUcodigo { get; set; }

        public int ALMcodigo { get; set; }

        public int CUOcodigo { get; set; }

        public decimal DEUmonto { get; set; }

        [Required]
        [StringLength(250)]
        public string DEUdescripcion { get; set; }

        public virtual gstALMpAlumno gstALMpAlumno { get; set; }

        public virtual gstCUOtCuota gstCUOtCuota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstDPGtDeudaPago> gstDPGtDeudaPago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstEXOtExoneracion> gstEXOtExoneracion { get; set; }
    }
}
