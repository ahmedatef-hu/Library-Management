using LibraryManagement_Final.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_Final.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borrowing> Borrowings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Member> Members { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder.Entity<Member>()
                .HasIndex(c => c.Email)
                .IsUnique();

            modelBuilder.Entity<Borrowing>()
                .Property(c => c.BorrowDate)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Book>()
                .Property(c => c.Price)
                .HasPrecision(10, 2);
                



            modelBuilder.Entity<Book>()
                .HasOne(c => c.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(c => c.CategoryId);


            modelBuilder.Entity<Book>()
                .HasMany(c => c.Borrowings)
                .WithOne(c => c.Book)
                .HasForeignKey(c => c.BookId);

            modelBuilder.Entity<Member>()
                .HasMany(c => c.Borrowings)
                .WithOne(c => c.Member)
                .HasForeignKey(c => c.MemberId);







            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Programming", Description = "Programming languages and fundamentals" },
                new Category { Id = 2, Name = "Databases", Description = "Database design and SQL" },
                new Category { Id = 3, Name = "Web Development", Description = "Frontend and backend web development" },
                new Category { Id = 4, Name = "Networking", Description = "Computer networks and protocols" },
                new Category { Id = 5, Name = "Cyber Security", Description = "Security and ethical hacking" },
                new Category { Id = 6, Name = "Artificial Intelligence", Description = "AI and machine learning" },
                new Category { Id = 7, Name = "Data Structures", Description = "Algorithms and data structures" },
                new Category { Id = 8, Name = "Operating Systems", Description = "Operating systems concepts" },
                new Category { Id = 9, Name = "Software Engineering", Description = "Software design and testing" },
                new Category { Id = 10, Name = "Mobile Development", Description = "Mobile application development" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "C# Basics", Author = "John Smith", ISBN = "ISBN001", Price = 250m, IsAvailable = true, CategoryId = 1 },
                new Book { Id = 2, Title = "C++ Programming", Author = "Bjarne Stroustrup", ISBN = "ISBN002", Price = 450m, IsAvailable = true, CategoryId = 1 },
                new Book { Id = 3, Title = "Clean Code", Author = "Robert Martin", ISBN = "ISBN003", Price = 600m, IsAvailable = true, CategoryId = 1 },
                new Book { Id = 4, Title = "Java Fundamentals", Author = "James Gosling", ISBN = "ISBN004", Price = 400m, IsAvailable = true, CategoryId = 1 },
                new Book { Id = 5, Title = "Advanced C#", Author = "Mark Price", ISBN = "ISBN005", Price = 700m, IsAvailable = false, CategoryId = 1 },
                new Book { Id = 6, Title = "SQL Fundamentals", Author = "John Carter", ISBN = "ISBN006", Price = 350m, IsAvailable = true, CategoryId = 2 },
                new Book { Id = 7, Title = "Database Design", Author = "Thomas Connolly", ISBN = "ISBN007", Price = 550m, IsAvailable = true, CategoryId = 2 },
                new Book { Id = 8, Title = "SQL Server Guide", Author = "Itzik Ben-Gan", ISBN = "ISBN008", Price = 650m, IsAvailable = true, CategoryId = 2 },
                new Book { Id = 9, Title = "Database Systems", Author = "Ramez Elmasri", ISBN = "ISBN009", Price = 500m, IsAvailable = true, CategoryId = 2 },
                new Book { Id = 10, Title = "Entity Framework Core", Author = "Jon Smith", ISBN = "ISBN010", Price = 750m, IsAvailable = true, CategoryId = 2 },
                new Book { Id = 11, Title = "HTML and CSS", Author = "Jon Duckett", ISBN = "ISBN011", Price = 300m, IsAvailable = true, CategoryId = 3 },
                new Book { Id = 12, Title = "JavaScript Guide", Author = "David Flanagan", ISBN = "ISBN012", Price = 480m, IsAvailable = false, CategoryId = 3 },
                new Book { Id = 13, Title = "React Essentials", Author = "Robin Wieruch", ISBN = "ISBN013", Price = 520m, IsAvailable = true, CategoryId = 3 },
                new Book { Id = 14, Title = "ASP.NET Core", Author = "Andrew Lock", ISBN = "ISBN014", Price = 800m, IsAvailable = true, CategoryId = 3 },
                new Book { Id = 15, Title = "Web API Design", Author = "Glenn Block", ISBN = "ISBN015", Price = 620m, IsAvailable = true, CategoryId = 3 },
                new Book { Id = 16, Title = "Computer Networks", Author = "Andrew Tanenbaum", ISBN = "ISBN016", Price = 550m, IsAvailable = true, CategoryId = 4 },
                new Book { Id = 17, Title = "Networking Basics", Author = "James Kurose", ISBN = "ISBN017", Price = 400m, IsAvailable = true, CategoryId = 4 },
                new Book { Id = 18, Title = "TCP IP Illustrated", Author = "Richard Stevens", ISBN = "ISBN018", Price = 700m, IsAvailable = true, CategoryId = 4 },
                new Book { Id = 19, Title = "Ethical Hacking", Author = "Kevin Beaver", ISBN = "ISBN019", Price = 650m, IsAvailable = false, CategoryId = 5 },
                new Book { Id = 20, Title = "Cyber Security Basics", Author = "Charles Brooks", ISBN = "ISBN020", Price = 500m, IsAvailable = true, CategoryId = 5 },
                new Book { Id = 21, Title = "Machine Learning", Author = "Tom Mitchell", ISBN = "ISBN021", Price = 900m, IsAvailable = true, CategoryId = 6 },
                new Book { Id = 22, Title = "Artificial Intelligence", Author = "Stuart Russell", ISBN = "ISBN022", Price = 950m, IsAvailable = true, CategoryId = 6 },
                new Book { Id = 23, Title = "Python for AI", Author = "Eric Matthes", ISBN = "ISBN023", Price = 580m, IsAvailable = true, CategoryId = 6 },
                new Book { Id = 24, Title = "Data Structures in C++", Author = "Adam Drozdek", ISBN = "ISBN024", Price = 620m, IsAvailable = true, CategoryId = 7 },
                new Book { Id = 25, Title = "Algorithms", Author = "Robert Sedgewick", ISBN = "ISBN025", Price = 850m, IsAvailable = false, CategoryId = 7 },
                new Book { Id = 26, Title = "Operating Systems", Author = "Abraham Silberschatz", ISBN = "ISBN026", Price = 700m, IsAvailable = true, CategoryId = 8 },
                new Book { Id = 27, Title = "Linux Fundamentals", Author = "Richard Blum", ISBN = "ISBN027", Price = 480m, IsAvailable = true, CategoryId = 8 },
                new Book { Id = 28, Title = "Software Engineering", Author = "Ian Sommerville", ISBN = "ISBN028", Price = 750m, IsAvailable = true, CategoryId = 9 },
                new Book { Id = 29, Title = "Design Patterns", Author = "Erich Gamma", ISBN = "ISBN029", Price = 680m, IsAvailable = true, CategoryId = 9 },
                new Book { Id = 30, Title = "Android Development", Author = "Bill Phillips", ISBN = "ISBN030", Price = 720m, IsAvailable = false, CategoryId = 10 }
            );

            modelBuilder.Entity<Member>().HasData(
                new Member { Id = 1, FullName = "Ahmed Hassan", Email = "ahmed1@example.com", Phone = "01000000001" },
                new Member { Id = 2, FullName = "Sara Mohamed", Email = "sara2@example.com", Phone = "01000000002" },
                new Member { Id = 3, FullName = "Omar Ali", Email = "omar3@example.com", Phone = "01000000003" },
                new Member { Id = 4, FullName = "Mona Ibrahim", Email = "mona4@example.com", Phone = "01000000004" },
                new Member { Id = 5, FullName = "Youssef Khaled", Email = "youssef5@example.com", Phone = "01000000005" },
                new Member { Id = 6, FullName = "Nour Adel", Email = "nour6@example.com", Phone = "01000000006" },
                new Member { Id = 7, FullName = "Mostafa Samir", Email = "mostafa7@example.com", Phone = "01000000007" },
                new Member { Id = 8, FullName = "Salma Tarek", Email = "salma8@example.com", Phone = "01000000008" },
                new Member { Id = 9, FullName = "Karim Ashraf", Email = "karim9@example.com", Phone = "01000000009" },
                new Member { Id = 10, FullName = "Hana Mahmoud", Email = "hana10@example.com", Phone = "01000000010" },
                new Member { Id = 11, FullName = "Ali Mostafa", Email = "ali11@example.com", Phone = "01000000011" },
                new Member { Id = 12, FullName = "Laila Hany", Email = "laila12@example.com", Phone = "01000000012" },
                new Member { Id = 13, FullName = "Ziad Amr", Email = "ziad13@example.com", Phone = "01000000013" },
                new Member { Id = 14, FullName = "Malak Wael", Email = "malak14@example.com", Phone = "01000000014" },
                new Member { Id = 15, FullName = "Adam Sherif", Email = "adam15@example.com", Phone = "01000000015" },
                new Member { Id = 16, FullName = "Farida Hossam", Email = "farida16@example.com", Phone = "01000000016" },
                new Member { Id = 17, FullName = "Amr Fathy", Email = "amr17@example.com", Phone = "01000000017" },
                new Member { Id = 18, FullName = "Jana Ahmed", Email = "jana18@example.com", Phone = "01000000018" },
                new Member { Id = 19, FullName = "Hassan Mahmoud", Email = "hassan19@example.com", Phone = "01000000019" },
                new Member { Id = 20, FullName = "Reem Mostafa", Email = "reem20@example.com", Phone = "01000000020" }
            );

            modelBuilder.Entity<Borrowing>().HasData(
                new Borrowing { Id = 1, MemberId = 1, BookId = 1, BorrowDate = new DateTime(2026, 1, 1), ReturnDate = new DateTime(2026, 1, 10) },
                new Borrowing { Id = 2, MemberId = 2, BookId = 2, BorrowDate = new DateTime(2026, 1, 2), ReturnDate = new DateTime(2026, 1, 12) },
                new Borrowing { Id = 3, MemberId = 3, BookId = 3, BorrowDate = new DateTime(2026, 1, 3), ReturnDate = new DateTime(2026, 1, 15) },
                new Borrowing { Id = 4, MemberId = 4, BookId = 4, BorrowDate = new DateTime(2026, 1, 4), ReturnDate = new DateTime(2026, 1, 14) },
                new Borrowing { Id = 5, MemberId = 5, BookId = 5, BorrowDate = new DateTime(2026, 10, 1), ReturnDate = null },
                new Borrowing { Id = 6, MemberId = 6, BookId = 6, BorrowDate = new DateTime(2026, 1, 6), ReturnDate = new DateTime(2026, 1, 20) },
                new Borrowing { Id = 7, MemberId = 7, BookId = 7, BorrowDate = new DateTime(2026, 1, 7), ReturnDate = new DateTime(2026, 1, 18) },
                new Borrowing { Id = 8, MemberId = 8, BookId = 8, BorrowDate = new DateTime(2026, 1, 8), ReturnDate = new DateTime(2026, 1, 19) },
                new Borrowing { Id = 9, MemberId = 9, BookId = 9, BorrowDate = new DateTime(2026, 1, 9), ReturnDate = new DateTime(2026, 1, 22) },
                new Borrowing { Id = 10, MemberId = 10, BookId = 10, BorrowDate = new DateTime(2026, 1, 10), ReturnDate = new DateTime(2026, 1, 25) },
                new Borrowing { Id = 11, MemberId = 11, BookId = 11, BorrowDate = new DateTime(2026, 2, 1), ReturnDate = new DateTime(2026, 2, 10) },
                new Borrowing { Id = 12, MemberId = 12, BookId = 12, BorrowDate = new DateTime(2026, 10, 5), ReturnDate = null },
                new Borrowing { Id = 13, MemberId = 13, BookId = 13, BorrowDate = new DateTime(2026, 2, 3), ReturnDate = new DateTime(2026, 2, 15) },
                new Borrowing { Id = 14, MemberId = 14, BookId = 14, BorrowDate = new DateTime(2026, 2, 4), ReturnDate = new DateTime(2026, 2, 16) },
                new Borrowing { Id = 15, MemberId = 15, BookId = 15, BorrowDate = new DateTime(2026, 2, 5), ReturnDate = new DateTime(2026, 2, 18) },
                new Borrowing { Id = 16, MemberId = 16, BookId = 16, BorrowDate = new DateTime(2026, 2, 6), ReturnDate = new DateTime(2026, 2, 20) },
                new Borrowing { Id = 17, MemberId = 17, BookId = 17, BorrowDate = new DateTime(2026, 2, 7), ReturnDate = new DateTime(2026, 2, 21) },
                new Borrowing { Id = 18, MemberId = 18, BookId = 18, BorrowDate = new DateTime(2026, 2, 8), ReturnDate = new DateTime(2026, 2, 22) },
                new Borrowing { Id = 19, MemberId = 19, BookId = 19, BorrowDate = new DateTime(2026, 10, 7), ReturnDate = null },
                new Borrowing { Id = 20, MemberId = 20, BookId = 20, BorrowDate = new DateTime(2026, 2, 10), ReturnDate = new DateTime(2026, 2, 25) },
                new Borrowing { Id = 21, MemberId = 1, BookId = 21, BorrowDate = new DateTime(2026, 3, 1), ReturnDate = new DateTime(2026, 3, 12) },
                new Borrowing { Id = 22, MemberId = 2, BookId = 22, BorrowDate = new DateTime(2026, 3, 2), ReturnDate = new DateTime(2026, 3, 14) },
                new Borrowing { Id = 23, MemberId = 3, BookId = 23, BorrowDate = new DateTime(2026, 3, 3), ReturnDate = new DateTime(2026, 3, 15) },
                new Borrowing { Id = 24, MemberId = 4, BookId = 24, BorrowDate = new DateTime(2026, 3, 4), ReturnDate = new DateTime(2026, 3, 16) },
                new Borrowing { Id = 25, MemberId = 5, BookId = 25, BorrowDate = new DateTime(2026, 10, 8), ReturnDate = null },
                new Borrowing { Id = 26, MemberId = 6, BookId = 26, BorrowDate = new DateTime(2026, 3, 6), ReturnDate = new DateTime(2026, 3, 18) },
                new Borrowing { Id = 27, MemberId = 7, BookId = 27, BorrowDate = new DateTime(2026, 3, 7), ReturnDate = new DateTime(2026, 3, 20) },
                new Borrowing { Id = 28, MemberId = 8, BookId = 28, BorrowDate = new DateTime(2026, 3, 8), ReturnDate = new DateTime(2026, 3, 22) },
                new Borrowing { Id = 29, MemberId = 9, BookId = 29, BorrowDate = new DateTime(2026, 3, 9), ReturnDate = new DateTime(2026, 3, 23) },
                new Borrowing { Id = 30, MemberId = 10, BookId = 30, BorrowDate = new DateTime(2026, 10, 10), ReturnDate = null },
                new Borrowing { Id = 31, MemberId = 11, BookId = 1, BorrowDate = new DateTime(2026, 4, 1), ReturnDate = new DateTime(2026, 4, 10) },
                new Borrowing { Id = 32, MemberId = 12, BookId = 2, BorrowDate = new DateTime(2026, 4, 2), ReturnDate = new DateTime(2026, 4, 12) },
                new Borrowing { Id = 33, MemberId = 13, BookId = 3, BorrowDate = new DateTime(2026, 4, 3), ReturnDate = new DateTime(2026, 4, 15) },
                new Borrowing { Id = 34, MemberId = 14, BookId = 4, BorrowDate = new DateTime(2026, 4, 4), ReturnDate = new DateTime(2026, 4, 16) },
                new Borrowing { Id = 35, MemberId = 15, BookId = 6, BorrowDate = new DateTime(2026, 4, 5), ReturnDate = new DateTime(2026, 4, 18) }
            );
        }
    }
    
}
