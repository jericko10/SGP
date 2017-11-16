namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstALMpAlumno")]
    public partial class gstALMpAlumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gstALMpAlumno()
        {
            gstDEUtDeuda = new HashSet<gstDEUtDeuda>();
            gstFRAtFraccion = new HashSet<gstFRAtFraccion>();
            gstRECtRecibo = new HashSet<gstRECtRecibo>();
        }

        [Key]
        public int ALMcodigo { get; set; }

        [Required]
        [StringLength(8)]
        public string ALMdni { get; set; }

        [Required]
        [StringLength(250)]
        public string ALMnombre { get; set; }

        [Required]
        [StringLength(250)]
        public string ALMapellido { get; set; }

        [StringLength(250)]
        public string ALMobservacion { get; set; }

        public int ALMperiodo { get; set; }

        [Required]
        [StringLength(15)]
        public string ALMnivel { get; set; }

        public int ALMgrado { get; set; }

        [Required]
        [StringLength(1)]
        public string ALMseccion { get; set; }

        [Required]
        [StringLength(20)]
        public string ALMestado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstDEUtDeuda> gstDEUtDeuda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstFRAtFraccion> gstFRAtFraccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstRECtRecibo> gstRECtRecibo { get; set; }
    }
}
