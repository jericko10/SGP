namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstRECtRecibo")]
    public partial class gstRECtRecibo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gstRECtRecibo()
        {
            gstDPGtDeudaPago = new HashSet<gstDPGtDeudaPago>();
        }

        [Key]
        [StringLength(10)]
        public string RECcodigo { get; set; }

        public int ALMcodigo { get; set; }

        public int USUcodigo { get; set; }

        [Column(TypeName = "date")]
        public DateTime RECfecha { get; set; }

        public decimal RECtotal { get; set; }

        public virtual gstALMpAlumno gstALMpAlumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstDPGtDeudaPago> gstDPGtDeudaPago { get; set; }

        public virtual gstUSUpUsuario gstUSUpUsuario { get; set; }
    }
}
