using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SystemApi.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "PostId", "Rate" },
                values: new object[,]
                {
                    { 1, "Good post", 1, 4 },
                    { 2, "Excellent post", 2, 5 },
                    { 3, "Average post", 3, 3 },
                    { 4, "Poor post", 4, 2 },
                    { 5, "Terrible post", 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Omar" },
                    { 2, "Ahmed" },
                    { 3, "Karim" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Name", "PostId", "UserId" },
                values: new object[,]
                {
                    { 6, "post6", null, 1 },
                    { 7, "post7", null, 1 },
                    { 8, "post8", null, 1 },
                    { 9, "post9", null, 1 },
                    { 10, "post10", null, 2 },
                    { 11, "post11", null, 2 },
                    { 12, "post12", null, 2 },
                    { 13, "post13", null, 3 },
                    { 14, "post14", null, 3 },
                    { 15, "post15", null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Stories",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "story1", 3 },
                    { 2, "story2", 3 },
                    { 3, "story3", 3 },
                    { 4, "story4", 1 },
                    { 5, "story5", 1 },
                    { 6, "story6", 1 },
                    { 7, "story7", 1 },
                    { 8, "story8", 1 },
                    { 9, "story9", 1 },
                    { 10, "story10", 2 },
                    { 11, "story11", 2 },
                    { 12, "story12", 2 },
                    { 13, "story13", 2 },
                    { 14, "story14", 2 },
                    { 15, "story15", 3 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "PostId", "Rate" },
                values: new object[,]
                {
                    { 6, "Good post", 6, 4 },
                    { 7, "Excellent post", 7, 5 },
                    { 8, "Average post", 8, 3 },
                    { 9, "Poor post", 9, 2 },
                    { 10, "Terrible post", 10, 1 },
                    { 11, "Good post", 11, 4 },
                    { 12, "Excellent post", 12, 5 },
                    { 13, "Average post", 13, 3 },
                    { 14, "Poor post", 14, 2 },
                    { 15, "Terrible post", 15, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostId",
                table: "Posts",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_PostId",
                table: "Reviews",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Stories_UserId",
                table: "Stories",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Stories");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
