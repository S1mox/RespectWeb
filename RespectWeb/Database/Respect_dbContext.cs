using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RespectWeb.Database
{
    public partial class Respect_dbContext : DbContext
    {
        public Respect_dbContext()
        {
        }

        public Respect_dbContext(DbContextOptions<Respect_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Points> Points { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:respect.database.windows.net,1433;Initial Catalog=Respect_db;Persist Security Info=False;User ID=seamo_respect;Password=SqlProject2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IdReceiver).HasColumnName("Id_receiver");

                entity.Property(e => e.IdRoom).HasColumnName("Id_room");

                entity.Property(e => e.IdSender).HasColumnName("Id_sender");
            });

            modelBuilder.Entity<Points>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.RoomId).HasColumnName("Room_id");

                entity.Property(e => e.UserId).HasColumnName("User_id");
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InviteKey).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Login).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
