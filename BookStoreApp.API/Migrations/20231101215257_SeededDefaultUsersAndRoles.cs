using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0408737f-a17b-4595-b79b-fd3511b21fb1", null, "Administrator", "ADMINISTRATOR" },
                    { "d27cdc26-1a3a-4b32-af01-4d43511a0754", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f5737cc-1778-491c-82a0-d27c4213d940", 0, "6d28c4ab-6891-4a8a-bed7-8f02ad207800", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEO3O4cqUZE9M91dLOXVNtOKiI+Fkbjg0aCv5ag4MGhElw1ce2uRjWIAC0VV8tAgIAA==", null, false, "cd31a67e-63b3-4b6c-bfe4-52f21d2cf8ff", false, "user@bookstore.com" },
                    { "99296e6f-9761-43ec-b489-8d0c8596e1ac", 0, "53e0c0ca-e9d9-448e-98ff-7685dab920d3", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEI3EzW205wIgnF4dzA55c4VCQ3s1dqnoqgTRGyuSWEH03eD2Qe2gsN31EBlEngT5gA==", null, false, "b477d466-96fc-4daf-b1c9-b3f090d93ecc", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d27cdc26-1a3a-4b32-af01-4d43511a0754", "0f5737cc-1778-491c-82a0-d27c4213d940" },
                    { "0408737f-a17b-4595-b79b-fd3511b21fb1", "99296e6f-9761-43ec-b489-8d0c8596e1ac" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d27cdc26-1a3a-4b32-af01-4d43511a0754", "0f5737cc-1778-491c-82a0-d27c4213d940" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0408737f-a17b-4595-b79b-fd3511b21fb1", "99296e6f-9761-43ec-b489-8d0c8596e1ac" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0408737f-a17b-4595-b79b-fd3511b21fb1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d27cdc26-1a3a-4b32-af01-4d43511a0754");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f5737cc-1778-491c-82a0-d27c4213d940");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99296e6f-9761-43ec-b489-8d0c8596e1ac");
        }
    }
}
