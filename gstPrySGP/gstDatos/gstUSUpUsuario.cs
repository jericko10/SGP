namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstUSUpUsuario")]
    public partial class gstUSUpUsuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gstUSUpUsuario()
        {
            gstRECtRecibo = new HashSet<gstRECtRecibo>();
        }

        [Key]
        public int USUcodigo { get; set; }

        [Required]
        [StringLength(8)]
        public string USUdni { get; set; }

        [Required]
        [StringLength(250)]
        public string USUnombre { get; set; }

        [Required]
        [StringLength(250)]
        public string USUapellido { get; set; }

        [Required]
        [StringLength(20)]
        public string USUcontrasena { get; set; }

        public int USUperiodo { get; set; }

        [Required]
        [StringLength(15)]
        public string USUnivel { get; set; }

        public int USUgrado { get; set; }

        [Required]
        [StringLength(1)]
        public string USUseccion { get; set; }

        [Required]
        [StringLength(20)]
        public string USUestado { get; set; }

        [Required]
        [StringLength(15)]
        public string USUtipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstRECtRecibo> gstRECtRecibo { get; set; }
    }
}
