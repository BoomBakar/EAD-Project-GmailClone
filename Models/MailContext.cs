using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication4.Models
{
    public partial class MailContext : DbContext
    {
        public MailContext()
        {
        }

        public MailContext(DbContextOptions<MailContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Thread> Threads { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Mail");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.DateAndTime)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverEmail)
                    .IsRequired()
                    .HasMaxLength(900)
                    .IsUnicode(false);

                entity.Property(e => e.SenderEmail)
                    .IsRequired()
                    .HasMaxLength(900)
                    .IsUnicode(false);

                entity.HasOne(d => d.ReceiverEmailNavigation)
                    .WithMany(p => p.MessageReceiverEmailNavigations)
                    .HasPrincipalKey(p => p.Email)
                    .HasForeignKey(d => d.ReceiverEmail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_ToTable_2");

                entity.HasOne(d => d.SenderEmailNavigation)
                    .WithMany(p => p.MessageSenderEmailNavigations)
                    .HasPrincipalKey(p => p.Email)
                    .HasForeignKey(d => d.SenderEmail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_ToTable_1");

                entity.HasOne(d => d.Thread)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ThreadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_ToTable");
            });

            modelBuilder.Entity<Thread>(entity =>
            {
                entity.ToTable("Thread");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(900)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverEmail)
                    .IsRequired()
                    .HasMaxLength(900)
                    .IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.ThreadEmailNavigations)
                    .HasPrincipalKey(p => p.Email)
                    .HasForeignKey(d => d.Email)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Thread_ToTable");

                entity.HasOne(d => d.ReceiverEmailNavigation)
                    .WithMany(p => p.ThreadReceiverEmailNavigations)
                    .HasPrincipalKey(p => p.Email)
                    .HasForeignKey(d => d.ReceiverEmail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Thread_ToTable_1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UniEmail")
                    .IsUnique();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }
        public override int SaveChanges()
        {
            var tracker = ChangeTracker;
            foreach (var entry in tracker.Entries())
            {
                if (entry.Entity is Entity)
                {
                    var referenceEntity = entry.Entity as Entity;
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedDate = DateTime.Now;
                            referenceEntity.CreatedByUser = "Abubakar";
                            break;
                        case EntityState.Deleted:
                        case EntityState.Modified:
                            referenceEntity.ModifiedDate = DateTime.Now;
                            referenceEntity.ModifiedByUser = "Abubakar";
                            break;
                        default:
                            break;
                    }
                }
            }
            return base.SaveChanges();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
