using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Busreservation.Models
{
    public partial class BusReservationContext : DbContext
    {
        public BusReservationContext()
        {
        }

        public BusReservationContext(DbContextOptions<BusReservationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BusMaster> BusMasters { get; set; }
        public virtual DbSet<BusRoute> BusRoutes { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Pnrdetail> Pnrdetails { get; set; }
        public virtual DbSet<TransactDetail> TransactDetails { get; set; }
        public virtual DbSet<TripDetail> TripDetails { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<Wallet> Wallets { get; set; }
        public virtual DbSet<WalletTransc> WalletTranscs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=DESKTOP-6N8A1B9\\MASQLEXPRESS;Database=BusReservation;User Id=sa;Password=manoj;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<BusMaster>(entity =>
            {
                entity.HasKey(e => e.BusId)
                    .HasName("PK__BusMaste__6A0F6095A0BB4ABE");

                entity.ToTable("BusMaster");

                entity.HasIndex(e => e.RegistrationNo, "UQ__BusMaste__80BF854675F3D55E")
                    .IsUnique();

                entity.Property(e => e.BusId)
                    .ValueGeneratedNever()
                    .HasColumnName("BusID");

                entity.Property(e => e.BusCondition)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.BusName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationNo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Registration_No");
            });

            modelBuilder.Entity<BusRoute>(entity =>
            {
                entity.HasKey(e => e.RouteId)
                    .HasName("PK__BusRoute__80979AADCDAAAFE1");

                entity.ToTable("BusRoute");

                entity.Property(e => e.RouteId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("RouteID");

                entity.Property(e => e.BusDestination)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Bus_destination");

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.BusSource)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Bus_Source");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.BusRoutes)
                    .HasForeignKey(d => d.BusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BusRoute__BusID__2FCF1A8A");
            });

            modelBuilder.Entity<Driver>(entity =>
            {
                entity.ToTable("Driver");

                entity.Property(e => e.DriverId).ValueGeneratedNever();

                entity.Property(e => e.DriverAge).HasColumnName("Driver_age");

                entity.Property(e => e.DriverGender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Driver_gender");

                entity.Property(e => e.DriverName)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("Driver_Name");
            });

            modelBuilder.Entity<Pnrdetail>(entity =>
            {
                entity.HasKey(e => e.PnrNo)
                    .HasName("PK__PNRdetai__20E30397E0BE70E4");

                entity.ToTable("PNRdetails");

                entity.Property(e => e.PnrNo).HasColumnName("PNR_no");

                entity.Property(e => e.BookedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Booked_on");

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.Doj)
                    .HasColumnType("date")
                    .HasColumnName("DOJ");

                entity.Property(e => e.Fare).HasColumnName("fare");

                entity.Property(e => e.PassAge).HasColumnName("passAge");

                entity.Property(e => e.PassGender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("passGender");

                entity.Property(e => e.PassName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("passName");

                entity.Property(e => e.Seatno)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TravelFrom)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Travel_From");

                entity.Property(e => e.TravelTo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Travel_To");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.Pnrdetails)
                    .HasForeignKey(d => d.BusId)
                    .HasConstraintName("FK__PNRdetail__BusID__3F115E1A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pnrdetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__PNRdetail__UserI__3E1D39E1");
            });

            modelBuilder.Entity<TransactDetail>(entity =>
            {
                entity.HasKey(e => e.TransactId)
                    .HasName("PK__transact__4400DE75B2D35A05");

                entity.ToTable("transactDetails");

                entity.Property(e => e.TransactId).HasColumnName("TransactID");

                entity.Property(e => e.PaymentOption)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("payment_option");

                entity.Property(e => e.Paymentstatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("paymentstatus");

                entity.Property(e => e.PnrNo).HasColumnName("PNR_No");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.TransactTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Transact_Time");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.PnrNoNavigation)
                    .WithMany(p => p.TransactDetails)
                    .HasForeignKey(d => d.PnrNo)
                    .HasConstraintName("FK__transactD__PNR_N__42E1EEFE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TransactDetails)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__transactD__UserI__41EDCAC5");
            });

            modelBuilder.Entity<TripDetail>(entity =>
            {
                entity.HasKey(e => e.TripCode)
                    .HasName("PK__TripDeta__4992CD1744A74806");

                entity.Property(e => e.TripCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BusId).HasColumnName("BusID");

                entity.Property(e => e.DriverId).HasColumnName("driverId");

                entity.Property(e => e.RouteId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TripDate).HasColumnType("datetime");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.TripDetails)
                    .HasForeignKey(d => d.BusId)
                    .HasConstraintName("FK__TripDetai__BusID__4F47C5E3");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.TripDetails)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK__TripDetai__drive__503BEA1C");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.TripDetails)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK__TripDetai__Route__4E53A1AA");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserDeta__1788CCAC6AEF6BA6");

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("User_address");

                entity.Property(e => e.UserDoB).HasColumnType("date");

                entity.Property(e => e.UserMail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("User_mail");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserPhn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("User_phn");
            });

            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.ToTable("wallet");

                entity.Property(e => e.WalletId).ValueGeneratedNever();

                entity.Property(e => e.UserId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.WalletBalance).HasColumnName("Wallet_balance");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Wallets)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__wallet__UserId__32AB8735");
            });

            modelBuilder.Entity<WalletTransc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("walletTransc");

                entity.Property(e => e.CreditOrDebit)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("credit_OR_debit");

                entity.Property(e => e.TransactId).HasColumnName("TransactID");

                entity.Property(e => e.TransactionDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Transaction_date");

                entity.HasOne(d => d.Transact)
                    .WithMany()
                    .HasForeignKey(d => d.TransactId)
                    .HasConstraintName("FK__walletTra__Trans__44CA3770");

                entity.HasOne(d => d.Wallet)
                    .WithMany()
                    .HasForeignKey(d => d.WalletId)
                    .HasConstraintName("FK__walletTra__Walle__607251E5");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
