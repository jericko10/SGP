namespace gstDatos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("gstDPGtDeudaPago")]
    public partial class gstDPGtDeudaPago
    {
        [Key]
        public int DPGcodigo { get; set; }

        [Required]
        [StringLength(10)]
        public string RECcodigo { get; set; }

        public int DEUcodigo { get; set; }

        public decimal DPGsubtotal { get; set; }

        public virtual gstDEUtDeuda gstDEUtDeuda { get; set; }

        public virtual gstRECtRecibo gstRECtRecibo { get; set; }
    }
}
