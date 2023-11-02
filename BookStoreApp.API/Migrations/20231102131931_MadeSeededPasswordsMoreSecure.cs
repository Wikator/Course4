using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class MadeSeededPasswordsMoreSecure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f5737cc-1778-491c-82a0-d27c4213d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2c5ec74-339a-4d21-99a6-497996d4e14f", "AQAAAAIAAYagAAAAEA0us98La4rJr61HLD/S/O5UnGrMAo4qnRyhnJmD1ofpemYPSfYILlEL3dX3KapEXw==", "32f3705a-2a42-434b-8209-c9230e19224e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99296e6f-9761-43ec-b489-8d0c8596e1ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ce32db8-699a-4b1d-b5c9-31488d87e7e1", "AQAAAAIAAYagAAAAED7PkxyYAdyPCyOYRYVYzsQT7s8zkmErJXuorJo4W4LFv8E34rTjR+ZhI9eu4kILhg==", "7d8a09b7-fcfc-4b1f-84f1-da7b272ca340" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f5737cc-1778-491c-82a0-d27c4213d940",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d28c4ab-6891-4a8a-bed7-8f02ad207800", "AQAAAAIAAYagAAAAEO3O4cqUZE9M91dLOXVNtOKiI+Fkbjg0aCv5ag4MGhElw1ce2uRjWIAC0VV8tAgIAA==", "cd31a67e-63b3-4b6c-bfe4-52f21d2cf8ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99296e6f-9761-43ec-b489-8d0c8596e1ac",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e0c0ca-e9d9-448e-98ff-7685dab920d3", "AQAAAAIAAYagAAAAEI3EzW205wIgnF4dzA55c4VCQ3s1dqnoqgTRGyuSWEH03eD2Qe2gsN31EBlEngT5gA==", "b477d466-96fc-4daf-b1c9-b3f090d93ecc" });
        }
    }
}
