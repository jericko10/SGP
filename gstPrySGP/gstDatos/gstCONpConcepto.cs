namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstCONpConcepto")]
    public partial class gstCONpConcepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gstCONpConcepto()
        {
            gstCUOtCuota = new HashSet<gstCUOtCuota>();
        }

        [Key]
        public int CONcodigo { get; set; }

        [Required]
        [StringLength(250)]
        public string CONdescripcion { get; set; }

        public decimal CONmonto { get; set; }

        [Required]
        [StringLength(20)]
        public string CONtipo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstCUOtCuota> gstCUOtCuota { get; set; }
    }
}
