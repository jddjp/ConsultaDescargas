using System;
using ApiBack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsultaEstadosLogalty.Models
{
    public partial class ApiBckContext : DbContext
    {
        public ApiBckContext()
        {
        }

        public ApiBckContext(DbContextOptions<ApiBckContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CamposDesglose> CamposDesglose { get; set; }
        public virtual DbSet<CatEsatustransaccion> CatEsatustransaccion { get; set; }
        public virtual DbSet<CatEstatus> CatEstatus { get; set; }
        public virtual DbSet<ConsultaEstatusTransaccion> ConsultaEstatusTransaccion { get; set; }
        public virtual DbSet<ControlFirmaEnvio> ControlFirmaEnvio { get; set; }
        public virtual DbSet<DataResponse> DataResponse { get; set; }
        public virtual DbSet<DocumentoFirmaEnvio> DocumentoFirmaEnvio { get; set; }
        public virtual DbSet<DocumentosDescargaLogalty> DocumentosDescargaLogalty { get; set; }
        public virtual DbSet<GroupState> GroupState { get; set; }
        public virtual DbSet<ProcesoConciliacion> ProcesoConciliacion { get; set; }
        public virtual DbSet<ProcesoEnvioFirma> ProcesoEnvioFirma { get; set; }
        public virtual DbSet<SignatureState> SignatureState { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<ResultadoFeedback> ResultadoFeedback { get; set; }
    


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=192.168.200.207;Initial Catalog=LogaltyFirmaDigital_Copia;User ID=nvo.backoffice;Password=Nb4ck4pr;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CamposDesglose>(entity =>
            {
                entity.HasKey(e => e.IdDetalleConciliacion)
                    .HasName("PK__CamposDe__B5EF54E67C354C5B");

                entity.Property(e => e.IdDetalleConciliacion).ValueGeneratedNever();

                entity.Property(e => e.BinaryContenGroupId)
                    .HasColumnName("binary_Conten_Group_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComentarioAutorizador)
                    .HasColumnName("comentario_Autorizador")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComentariosFirma)
                    .HasColumnName("comentarios_Firma")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActualGrupo)
                    .HasColumnName("estado_Actual_Grupo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoActualTransaccion)
                    .HasColumnName("estado_Actual_Transaccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaFirma)
                    .HasColumnName("fecha_Firma")
                    .HasColumnType("date");

                entity.Property(e => e.GuId)
                    .HasColumnName("guId")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.IdFirma).HasColumnName("idFirma");

                entity.Property(e => e.IdProcesoConciliacion).HasColumnName("idProcesoConciliacion");

                entity.Property(e => e.ResultadoActualGrupo)
                    .HasColumnName("resultado_Actual_Grupo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResultadoFirma)
                    .HasColumnName("resultado_Firma")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RstadoFirma).HasColumnName("rstadoFirma");
            });

            modelBuilder.Entity<CatEsatustransaccion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cat_esatustransaccion");

                entity.Property(e => e.Codigo).HasColumnName("codigo");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100)
                    .IsFixedLength();
            });

            modelBuilder.Entity<CatEstatus>(entity =>
            {
                entity.HasKey(e => e.IdEstatus)
                    .HasName("PK__cat_esta__7339FA684EB9D639");

                entity.ToTable("cat_estatus");

                entity.Property(e => e.IdEstatus).HasColumnName("id_Estatus");

                entity.Property(e => e.ClaveEstatus).HasColumnName("clave_estatus");

                entity.Property(e => e.NombreEstatus)
                    .HasColumnName("nombreEstatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsultaEstatusTransaccion>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CancelCode)
                    .HasColumnName("cancel_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancelReason)
                    .HasColumnName("cancel_reason")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalId)
                    .HasColumnName("externalId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PkConsultaEstatusTransaccion)
                    .HasColumnName("pk_ConsultaEstatusTransaccion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateComment)
                    .HasColumnName("substate_comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateDate)
                    .HasColumnName("substate_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateValue)
                    .HasColumnName("substate_value")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlFirmaEnvio>(entity =>
            {
                entity.HasKey(e => e.PkControlFirmaEnvio);

                entity.Property(e => e.PkControlFirmaEnvio).HasColumnName("pk_ControlFirmaEnvio");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pagare)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataResponse>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__dataResp__15B69B8E94492240");

                entity.ToTable("dataResponse");

                entity.Property(e => e.Guid)
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocumentoFirmaEnvio>(entity =>
            {
                entity.HasKey(e => e.PkIdArchivo)
                    .HasName("PK__Document__A19414C12A241541");

                entity.Property(e => e.PkIdArchivo).HasColumnName("pk_IdArchivo");

                entity.Property(e => e.FechaDocumento).HasColumnType("datetime");

                entity.Property(e => e.IdCredi)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreArchivo).HasMaxLength(50);

                entity.Property(e => e.Pagare)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DocumentosDescargaLogalty>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Documento).IsRequired();

                entity.Property(e => e.Guid)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pagare)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupState>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("group_state");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.ResultDate)
                    .IsRequired()
                    .HasColumnName("result_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateComment)
                    .IsRequired()
                    .HasColumnName("substate_comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateDate)
                    .IsRequired()
                    .HasColumnName("substate_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateValue).HasColumnName("substate_value");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ProcesoConciliacion>(entity =>
            {
                entity.HasKey(e => e.IdProcesoConciliacion)
                    .HasName("PK__ProcesoC__EDD571E493DEC546");

                entity.Property(e => e.IdProcesoConciliacion).ValueGeneratedNever();

                entity.Property(e => e.FeedbackLogalty).HasColumnType("text");

                entity.Property(e => e.Nodeid).HasMaxLength(50);
            });

            modelBuilder.Entity<ProcesoEnvioFirma>(entity =>
            {
                entity.HasKey(e => e.IdProcesoEnvioFirma)
                    .HasName("PK__ProcesoE__FEE841E71DC15942");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasColumnName("CURP")
                    .HasMaxLength(18);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEnvio).HasColumnType("date");

                entity.Property(e => e.Guid)
                    .HasColumnName("guid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Monto)
                    .HasColumnName("monto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumControl)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCasa)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoCelular)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipoc)
                    .HasColumnName("tipoc")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SignatureState>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("signature_state");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverId).HasColumnName("receiver_id");

                entity.Property(e => e.RejectReason)
                    .IsRequired()
                    .HasColumnName("reject_reason")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Result).HasColumnName("result");

                entity.Property(e => e.ResultDate)
                    .IsRequired()
                    .HasColumnName("result_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RuleId).HasColumnName("rule_id");

                entity.Property(e => e.SubstateComment)
                    .IsRequired()
                    .HasColumnName("substate_comment")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateDate)
                    .IsRequired()
                    .HasColumnName("substate_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubstateValue).HasColumnName("substate_value");

                entity.Property(e => e.Value).HasColumnName("value");
            });

          

            modelBuilder.HasSequence("ProcFirmas");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
