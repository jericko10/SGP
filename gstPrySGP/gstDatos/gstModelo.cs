namespace gstDatos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class gstModelo : DbContext
    {
        public gstModelo()
            : base("name=gstModelo")
        {
        }

        public virtual DbSet<gstALMpAlumno> gstALMpAlumno { get; set; }
        public virtual DbSet<gstCONpConcepto> gstCONpConcepto { get; set; }
        public virtual DbSet<gstCUOtCuota> gstCUOtCuota { get; set; }
        public virtual DbSet<gstDEUtDeuda> gstDEUtDeuda { get; set; }
        public virtual DbSet<gstDPGtDeudaPago> gstDPGtDeudaPago { get; set; }
        public virtual DbSet<gstEXOtExoneracion> gstEXOtExoneracion { get; set; }
        public virtual DbSet<gstFRAtFraccion> gstFRAtFraccion { get; set; }
        public virtual DbSet<gstRECtRecibo> gstRECtRecibo { get; set; }
        public virtual DbSet<gstUSUpUsuario> gstUSUpUsuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<gstALMpAlumno>()
                .Property(e => e.ALMdni)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .Property(e => e.ALMnombre)
                .IsUnicode(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .Property(e => e.ALMapellido)
                .IsUnicode(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .Property(e => e.ALMobservacion)
                .IsUnicode(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .Property(e => e.ALMnivel)
                .IsUnicode(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .Property(e => e.ALMseccion)
                .IsUnicode(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .Property(e => e.ALMestado)
                .IsUnicode(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .HasMany(e => e.gstDEUtDeuda)
                .WithRequired(e => e.gstALMpAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .HasMany(e => e.gstFRAtFraccion)
                .WithRequired(e => e.gstALMpAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstALMpAlumno>()
                .HasMany(e => e.gstRECtRecibo)
                .WithRequired(e => e.gstALMpAlumno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstCONpConcepto>()
                .Property(e => e.CONdescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gstCONpConcepto>()
                .Property(e => e.CONmonto)
                .HasPrecision(6, 2);

            modelBuilder.Entity<gstCONpConcepto>()
                .Property(e => e.CONtipo)
                .IsUnicode(false);

            modelBuilder.Entity<gstCONpConcepto>()
                .HasMany(e => e.gstCUOtCuota)
                .WithRequired(e => e.gstCONpConcepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstCUOtCuota>()
                .Property(e => e.CUOmes)
                .IsUnicode(false);

            modelBuilder.Entity<gstCUOtCuota>()
                .Property(e => e.CUOperiodo)
                .IsUnicode(false);

            modelBuilder.Entity<gstCUOtCuota>()
                .Property(e => e.CUOalcance)
                .IsUnicode(false);

            modelBuilder.Entity<gstCUOtCuota>()
                .HasMany(e => e.gstDEUtDeuda)
                .WithRequired(e => e.gstCUOtCuota)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstDEUtDeuda>()
                .Property(e => e.DEUmonto)
                .HasPrecision(6, 2);

            modelBuilder.Entity<gstDEUtDeuda>()
                .Property(e => e.DEUdescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gstDEUtDeuda>()
                .HasMany(e => e.gstDPGtDeudaPago)
                .WithRequired(e => e.gstDEUtDeuda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstDEUtDeuda>()
                .HasMany(e => e.gstEXOtExoneracion)
                .WithRequired(e => e.gstDEUtDeuda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstDPGtDeudaPago>()
                .Property(e => e.RECcodigo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gstDPGtDeudaPago>()
                .Property(e => e.DPGsubtotal)
                .HasPrecision(6, 2);

            modelBuilder.Entity<gstEXOtExoneracion>()
                .Property(e => e.EXOmotivo)
                .IsUnicode(false);

            modelBuilder.Entity<gstEXOtExoneracion>()
                .Property(e => e.EXOdescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<gstRECtRecibo>()
                .Property(e => e.RECcodigo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gstRECtRecibo>()
                .Property(e => e.RECtotal)
                .HasPrecision(6, 2);

            modelBuilder.Entity<gstRECtRecibo>()
                .HasMany(e => e.gstDPGtDeudaPago)
                .WithRequired(e => e.gstRECtRecibo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUdni)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUnombre)
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUapellido)
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUcontrasena)
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUnivel)
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUseccion)
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUestado)
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .Property(e => e.USUtipo)
                .IsUnicode(false);

            modelBuilder.Entity<gstUSUpUsuario>()
                .HasMany(e => e.gstRECtRecibo)
                .WithRequired(e => e.gstUSUpUsuario)
                .WillCascadeOnDelete(false);
        }
    }
}
