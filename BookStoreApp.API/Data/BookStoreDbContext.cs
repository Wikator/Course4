using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.API.Data;

public class BookStoreDbContext : IdentityDbContext<ApiUser>
{
    public BookStoreDbContext()
    {
    }

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {
    }

    public virtual required DbSet<Author> Authors { get; set; }

    public virtual required DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Authors__3214EC076F972ED6");

            entity.Property(e => e.Bio).HasMaxLength(250);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Books__3214EC075B928F92");

            entity.HasIndex(e => e.Isbn, "UQ__Books__447D36EA093A46B2").IsUnique();

            entity.Property(e => e.Image).HasMaxLength(50);
            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasColumnName("ISBN");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Summary).HasMaxLength(250);
            entity.Property(e => e.Title).HasMaxLength(50);

            entity.HasOne(d => d.Author).WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId)
                .HasConstraintName("FK_Books_ToTable");
        });

        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "d27cdc26-1a3a-4b32-af01-4d43511a0754",
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "0408737f-a17b-4595-b79b-fd3511b21fb1",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            });

        var hasher = new PasswordHasher<ApiUser>();
        var adminUser = new ApiUser
        {
            Id = "99296e6f-9761-43ec-b489-8d0c8596e1ac",
            Email = "admin@bookstore.com",
            NormalizedEmail = "ADMIN@BOOKSTORE.COM",
            UserName = "admin@bookstore.com",
            NormalizedUserName = "ADMIN@BOOKSTORE.COM",
            FirstName = "System",
            LastName = "Admin"
        };
        var userUser = new ApiUser
        {
            Id = "0f5737cc-1778-491c-82a0-d27c4213d940",
            Email = "user@bookstore.com",
            NormalizedEmail = "USER@BOOKSTORE.COM",
            UserName = "user@bookstore.com",
            NormalizedUserName = "USER@BOOKSTORE.COM",
            FirstName = "System",
            LastName = "User"
        };
        adminUser.PasswordHash = hasher.HashPassword(adminUser, "Pa$$w0rd");
        userUser.PasswordHash = hasher.HashPassword(userUser, "Pa$$w0rd");
        modelBuilder.Entity<ApiUser>().HasData(adminUser, userUser);

        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "0408737f-a17b-4595-b79b-fd3511b21fb1",
                UserId = "99296e6f-9761-43ec-b489-8d0c8596e1ac"
            },
            new IdentityUserRole<string>
            {
                RoleId = "d27cdc26-1a3a-4b32-af01-4d43511a0754",
                UserId = "0f5737cc-1778-491c-82a0-d27c4213d940"
            });
    }
}
