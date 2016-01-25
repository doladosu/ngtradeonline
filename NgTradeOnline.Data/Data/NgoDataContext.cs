using Microsoft.AspNet.Identity.EntityFramework;
using NgTradeOnline.Data.Auth;
using NgTradeOnline.Models.Db;

namespace NgTradeOnline.Data.Data
{
    using System.Data.Entity;

    public partial class NgoDataContext : IdentityDbContext<ApplicationUser>
    {
        public NgoDataContext()
            : base("name=NgoDataContext")
        {
        }

        public static NgoDataContext Create()
        {
            return new NgoDataContext();
        }

        public virtual DbSet<AccountProfile> AccountProfiles { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Companyprofile> Companyprofiles { get; set; }
        public virtual DbSet<dailypricelist> dailypricelists { get; set; }
        public virtual DbSet<Holding> Holdings { get; set; }
        public virtual DbSet<MailingList> MailingLists { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<UserProfile> UserProfiles { get; set; }
        public virtual DbSet<webpages_Membership> webpages_Membership { get; set; }
        public virtual DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public virtual DbSet<webpages_Roles> webpages_Roles { get; set; }
        public virtual DbSet<ApplicationType> ApplicationTypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Contest> Contests { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Quote>()
                .Property(e => e.Low)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Quote>()
                .Property(e => e.Open)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Quote>()
                .Property(e => e.Close)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Quote>()
                .Property(e => e.High)
                .HasPrecision(18, 4);

            modelBuilder.Entity<Quote>()
                .Property(e => e.CHANGE1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<UserProfile>()
                .Property(e => e.Balance)
                .HasPrecision(25, 2);

            modelBuilder.Entity<webpages_Roles>()
                .HasMany(e => e.UserProfiles)
                .WithMany(e => e.webpages_Roles)
                .Map(m => m.ToTable("webpages_UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<ApplicationType>()
               .Property(e => e.Name)
               .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Secret)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.AllowedOrigin)
                .IsUnicode(false);

            modelBuilder.Entity<Contest>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.Subject)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.ClientId)
                .IsUnicode(false);

            modelBuilder.Entity<RefreshToken>()
                .Property(e => e.ProtectedTicket)
                .IsUnicode(false);
        }
    }
}
