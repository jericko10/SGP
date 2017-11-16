namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstCUOtCuota")]
    public partial class gstCUOtCuota
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public gstCUOtCuota()
        {
            gstDEUtDeuda = new HashSet<gstDEUtDeuda>();
        }

        [Key]
        public int CUOcodigo { get; set; }

        public int CONcodigo { get; set; }

        [Column(TypeName = "date")]
        public DateTime CUOano { get; set; }

        [Required]
        [StringLength(15)]
        public string CUOmes { get; set; }

        [Required]
        [StringLength(30)]
        public string CUOperiodo { get; set; }

        [Required]
        [StringLength(30)]
        public string CUOalcance { get; set; }

        public virtual gstCONpConcepto gstCONpConcepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<gstDEUtDeuda> gstDEUtDeuda { get; set; }
    }
}
