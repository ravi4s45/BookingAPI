using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DeskAPI.Models
{
    public partial class ProfilesDBContext : DbContext
    {
        public ProfilesDBContext()
        {
        }

        public ProfilesDBContext(DbContextOptions<ProfilesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookedDesk> BookedDesks { get; set; } = null!;
        public virtual DbSet<BookedMeetingRoom> BookedMeetingRooms { get; set; } = null!;
        public virtual DbSet<Desk> Desks { get; set; } = null!;
        public virtual DbSet<MeetingRoom> MeetingRooms { get; set; } = null!;
        public virtual DbSet<ProfilesTb> ProfilesTbs { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=USHYDRAVISING1;Initial Catalog=ProfilesDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookedDesk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BookedDesk");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DeskBookingId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeskId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timeslot)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BookedMeetingRoom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BookedMeetingRoom");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingBookingId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoomId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Desk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Desk");

                entity.Property(e => e.DeskId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DeskID");

                entity.Property(e => e.Pc).HasColumnName("PC");
            });

            modelBuilder.Entity<MeetingRoom>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MeetingRoom");

                entity.Property(e => e.MeetingId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MeetingID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProfilesTb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProfilesTB");

                entity.Property(e => e.Email)
                    .HasMaxLength(30)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                //entity.HasNoKey();

                entity.Property(e => e.Designation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
