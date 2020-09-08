using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TMRK.Entities;

namespace TMRK.Models
{
    public partial class TMRKLOGContext : DbContext
    {
        public TMRKLOGContext()
        {
        }

        public TMRKLOGContext(DbContextOptions<TMRKLOGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Request> Request { get; set; }
        public virtual DbSet<Response> Response { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         //   if (!optionsBuilder.IsConfigured)
         //   {
         ////       optionsBuilder.UseSqlServer("Server=.;Database=TMRKLOG;Trusted_Connection=True;");
         //   }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Request>(entity =>
            {
                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.CallTime).HasColumnType("datetime");

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MethodInput).IsUnicode(false);

                entity.Property(e => e.MethodOrginalName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PointerId).HasColumnName("PointerID");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceMethodId).HasColumnName("ServiceMethodID");

                entity.Property(e => e.SummeryData).IsUnicode(false);
            });

            modelBuilder.Entity<Response>(entity =>
            {
                entity.Property(e => e.ResponseId).HasColumnName("ResponseID");

                entity.Property(e => e.Exception).IsUnicode(false);

                entity.Property(e => e.InsertDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MethodOutput).IsUnicode(false);

                entity.Property(e => e.PointerId).HasColumnName("PointerID");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.ResponseTime).HasColumnType("datetime");

                entity.Property(e => e.ServiceId).HasColumnName("ServiceID");

                entity.Property(e => e.ServiceMethodId).HasColumnName("ServiceMethodID");

                entity.Property(e => e.SummeryData).IsUnicode(false);

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Response)
                    .HasForeignKey(d => d.RequestId)
                    .HasConstraintName("FK_Response_Request");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
