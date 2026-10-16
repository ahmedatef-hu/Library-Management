using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement_Final.Migrations
{
    /// <inheritdoc />
    public partial class AddLibrarySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Borrowings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Programming languages and fundamentals", "Programming" },
                    { 2, "Database design and SQL", "Databases" },
                    { 3, "Frontend and backend web development", "Web Development" },
                    { 4, "Computer networks and protocols", "Networking" },
                    { 5, "Security and ethical hacking", "Cyber Security" },
                    { 6, "AI and machine learning", "Artificial Intelligence" },
                    { 7, "Algorithms and data structures", "Data Structures" },
                    { 8, "Operating systems concepts", "Operating Systems" },
                    { 9, "Software design and testing", "Software Engineering" },
                    { 10, "Mobile application development", "Mobile Development" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Email", "FullName", "Phone" },
                values: new object[,]
                {
                    { 1, "ahmed1@example.com", "Ahmed Hassan", "01000000001" },
                    { 2, "sara2@example.com", "Sara Mohamed", "01000000002" },
                    { 3, "omar3@example.com", "Omar Ali", "01000000003" },
                    { 4, "mona4@example.com", "Mona Ibrahim", "01000000004" },
                    { 5, "youssef5@example.com", "Youssef Khaled", "01000000005" },
                    { 6, "nour6@example.com", "Nour Adel", "01000000006" },
                    { 7, "mostafa7@example.com", "Mostafa Samir", "01000000007" },
                    { 8, "salma8@example.com", "Salma Tarek", "01000000008" },
                    { 9, "karim9@example.com", "Karim Ashraf", "01000000009" },
                    { 10, "hana10@example.com", "Hana Mahmoud", "01000000010" },
                    { 11, "ali11@example.com", "Ali Mostafa", "01000000011" },
                    { 12, "laila12@example.com", "Laila Hany", "01000000012" },
                    { 13, "ziad13@example.com", "Ziad Amr", "01000000013" },
                    { 14, "malak14@example.com", "Malak Wael", "01000000014" },
                    { 15, "adam15@example.com", "Adam Sherif", "01000000015" },
                    { 16, "farida16@example.com", "Farida Hossam", "01000000016" },
                    { 17, "amr17@example.com", "Amr Fathy", "01000000017" },
                    { 18, "jana18@example.com", "Jana Ahmed", "01000000018" },
                    { 19, "hassan19@example.com", "Hassan Mahmoud", "01000000019" },
                    { 20, "reem20@example.com", "Reem Mostafa", "01000000020" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "John Smith", 1, "ISBN001", 250m, "C# Basics" },
                    { 2, "Bjarne Stroustrup", 1, "ISBN002", 450m, "C++ Programming" },
                    { 3, "Robert Martin", 1, "ISBN003", 600m, "Clean Code" },
                    { 4, "James Gosling", 1, "ISBN004", 400m, "Java Fundamentals" },
                    { 5, "Mark Price", 1, "ISBN005", 700m, "Advanced C#" },
                    { 6, "John Carter", 2, "ISBN006", 350m, "SQL Fundamentals" },
                    { 7, "Thomas Connolly", 2, "ISBN007", 550m, "Database Design" },
                    { 8, "Itzik Ben-Gan", 2, "ISBN008", 650m, "SQL Server Guide" },
                    { 9, "Ramez Elmasri", 2, "ISBN009", 500m, "Database Systems" },
                    { 10, "Jon Smith", 2, "ISBN010", 750m, "Entity Framework Core" },
                    { 11, "Jon Duckett", 3, "ISBN011", 300m, "HTML and CSS" },
                    { 12, "David Flanagan", 3, "ISBN012", 480m, "JavaScript Guide" },
                    { 13, "Robin Wieruch", 3, "ISBN013", 520m, "React Essentials" },
                    { 14, "Andrew Lock", 3, "ISBN014", 800m, "ASP.NET Core" },
                    { 15, "Glenn Block", 3, "ISBN015", 620m, "Web API Design" },
                    { 16, "Andrew Tanenbaum", 4, "ISBN016", 550m, "Computer Networks" },
                    { 17, "James Kurose", 4, "ISBN017", 400m, "Networking Basics" },
                    { 18, "Richard Stevens", 4, "ISBN018", 700m, "TCP IP Illustrated" },
                    { 19, "Kevin Beaver", 5, "ISBN019", 650m, "Ethical Hacking" },
                    { 20, "Charles Brooks", 5, "ISBN020", 500m, "Cyber Security Basics" },
                    { 21, "Tom Mitchell", 6, "ISBN021", 900m, "Machine Learning" },
                    { 22, "Stuart Russell", 6, "ISBN022", 950m, "Artificial Intelligence" },
                    { 23, "Eric Matthes", 6, "ISBN023", 580m, "Python for AI" },
                    { 24, "Adam Drozdek", 7, "ISBN024", 620m, "Data Structures in C++" },
                    { 25, "Robert Sedgewick", 7, "ISBN025", 850m, "Algorithms" },
                    { 26, "Abraham Silberschatz", 8, "ISBN026", 700m, "Operating Systems" },
                    { 27, "Richard Blum", 8, "ISBN027", 480m, "Linux Fundamentals" },
                    { 28, "Ian Sommerville", 9, "ISBN028", 750m, "Software Engineering" },
                    { 29, "Erich Gamma", 9, "ISBN029", 680m, "Design Patterns" },
                    { 30, "Bill Phillips", 10, "ISBN030", 720m, "Android Development" }
                });

            migrationBuilder.InsertData(
                table: "Borrowings",
                columns: new[] { "Id", "BookId", "BorrowDate", "MemberId", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, new DateTime(2026, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, new DateTime(2026, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, new DateTime(2026, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, new DateTime(2026, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null },
                    { 6, 6, new DateTime(2026, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2026, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2026, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 8, new DateTime(2026, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2026, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 9, new DateTime(2026, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2026, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 10, new DateTime(2026, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2026, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 11, new DateTime(2026, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 12, new DateTime(2026, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, null },
                    { 13, 13, new DateTime(2026, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new DateTime(2026, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 14, new DateTime(2026, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2026, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 15, new DateTime(2026, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, 16, new DateTime(2026, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, 17, new DateTime(2026, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, new DateTime(2026, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, 18, new DateTime(2026, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, 19, new DateTime(2026, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null },
                    { 20, 20, new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, 21, new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, 22, new DateTime(2026, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2026, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, 23, new DateTime(2026, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2026, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, 24, new DateTime(2026, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2026, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, 25, new DateTime(2026, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null },
                    { 26, 26, new DateTime(2026, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2026, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, 27, new DateTime(2026, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, 28, new DateTime(2026, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, new DateTime(2026, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, 29, new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, new DateTime(2026, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, 30, new DateTime(2026, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, null },
                    { 31, 1, new DateTime(2026, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, new DateTime(2026, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, 2, new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, new DateTime(2026, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, 3, new DateTime(2026, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, 4, new DateTime(2026, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, new DateTime(2026, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, 6, new DateTime(2026, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Borrowings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Borrowings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
