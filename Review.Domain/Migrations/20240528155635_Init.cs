using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Review.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grade = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RatingId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Ratings_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Ratings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8934), 2.8199999999999998, 3 },
                    { 2, new DateTime(2024, 3, 6, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8958), 1.8600000000000001, 1 },
                    { 3, new DateTime(2024, 5, 16, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8974), 2.8199999999999998, 3 },
                    { 4, new DateTime(2024, 5, 16, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8987), 2.6000000000000001, 7 },
                    { 5, new DateTime(2024, 2, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9000), 1.8600000000000001, 1 },
                    { 6, new DateTime(2024, 3, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9013), 1.8600000000000001, 1 },
                    { 7, new DateTime(2024, 3, 4, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9026), 1.8600000000000001, 1 },
                    { 8, new DateTime(2024, 4, 14, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9040), 2.8199999999999998, 3 },
                    { 9, new DateTime(2024, 4, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9082), 3.0800000000000001, 6 },
                    { 10, new DateTime(2024, 4, 15, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9095), 1.8600000000000001, 1 },
                    { 11, new DateTime(2024, 5, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9112), 2.6800000000000002, 8 },
                    { 12, new DateTime(2024, 3, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9126), 2.6000000000000001, 7 },
                    { 13, new DateTime(2024, 3, 28, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9141), 2.0, 5 },
                    { 14, new DateTime(2024, 2, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9153), 2.6000000000000001, 7 },
                    { 15, new DateTime(2024, 2, 28, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9169), 3.3599999999999999, 4 },
                    { 16, new DateTime(2024, 5, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9182), 2.6000000000000001, 7 },
                    { 17, new DateTime(2024, 4, 4, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9196), 2.8799999999999999, 9 },
                    { 18, new DateTime(2024, 5, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9213), 2.6800000000000002, 8 },
                    { 19, new DateTime(2024, 5, 15, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9226), 2.8799999999999999, 9 },
                    { 20, new DateTime(2024, 3, 16, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9241), 2.8199999999999998, 3 },
                    { 21, new DateTime(2024, 2, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9255), 2.8199999999999998, 3 },
                    { 22, new DateTime(2024, 3, 30, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9267), 2.6000000000000001, 7 },
                    { 23, new DateTime(2024, 2, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9309), 3.3599999999999999, 4 },
                    { 24, new DateTime(2024, 5, 2, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9322), 2.6000000000000001, 7 },
                    { 25, new DateTime(2024, 2, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9337), 3.0800000000000001, 6 },
                    { 26, new DateTime(2024, 5, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9350), 2.8799999999999999, 9 },
                    { 27, new DateTime(2024, 2, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9364), 2.0, 5 },
                    { 28, new DateTime(2024, 3, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9379), 2.7999999999999998, 2 },
                    { 29, new DateTime(2024, 2, 28, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9393), 2.0, 5 },
                    { 30, new DateTime(2024, 3, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9407), 3.0800000000000001, 6 },
                    { 31, new DateTime(2024, 5, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9421), 2.8199999999999998, 3 },
                    { 32, new DateTime(2024, 2, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9435), 3.3599999999999999, 4 },
                    { 33, new DateTime(2024, 3, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9448), 1.8600000000000001, 1 },
                    { 34, new DateTime(2024, 3, 9, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9462), 2.8199999999999998, 3 },
                    { 35, new DateTime(2024, 5, 12, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9478), 2.6800000000000002, 8 },
                    { 36, new DateTime(2024, 3, 11, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9491), 2.8199999999999998, 3 },
                    { 37, new DateTime(2024, 3, 4, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9533), 3.3599999999999999, 4 },
                    { 38, new DateTime(2024, 5, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9548), 2.6800000000000002, 8 },
                    { 39, new DateTime(2024, 4, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9562), 2.8799999999999999, 9 },
                    { 40, new DateTime(2024, 3, 8, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9576), 3.3599999999999999, 4 },
                    { 41, new DateTime(2024, 3, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9591), 2.7999999999999998, 2 },
                    { 42, new DateTime(2024, 3, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9604), 2.6000000000000001, 7 },
                    { 43, new DateTime(2024, 3, 6, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9617), 2.0, 5 },
                    { 44, new DateTime(2024, 5, 19, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9633), 2.7999999999999998, 2 },
                    { 45, new DateTime(2024, 2, 23, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9647), 2.7999999999999998, 2 },
                    { 46, new DateTime(2024, 3, 8, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9661), 2.7999999999999998, 2 },
                    { 47, new DateTime(2024, 3, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9675), 2.8199999999999998, 3 },
                    { 48, new DateTime(2024, 4, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9689), 2.8199999999999998, 3 },
                    { 49, new DateTime(2024, 4, 12, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9702), 1.8600000000000001, 1 },
                    { 50, new DateTime(2024, 4, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9715), 3.3599999999999999, 4 },
                    { 51, new DateTime(2024, 4, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9759), 3.0800000000000001, 6 },
                    { 52, new DateTime(2024, 4, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9773), 2.8199999999999998, 3 },
                    { 53, new DateTime(2024, 4, 27, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9789), 2.6800000000000002, 8 },
                    { 54, new DateTime(2024, 4, 27, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9802), 1.8600000000000001, 1 },
                    { 55, new DateTime(2024, 2, 19, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9815), 2.6000000000000001, 7 },
                    { 56, new DateTime(2024, 3, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9829), 3.3599999999999999, 4 },
                    { 57, new DateTime(2024, 5, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9843), 3.3599999999999999, 4 },
                    { 58, new DateTime(2024, 5, 17, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9858), 2.7999999999999998, 2 },
                    { 59, new DateTime(2024, 5, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9870), 2.6000000000000001, 7 },
                    { 60, new DateTime(2024, 2, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9884), 2.0, 5 },
                    { 61, new DateTime(2024, 4, 6, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9899), 2.6800000000000002, 8 },
                    { 62, new DateTime(2024, 5, 23, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9914), 2.6800000000000002, 8 },
                    { 63, new DateTime(2024, 5, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9958), 2.6800000000000002, 8 },
                    { 64, new DateTime(2024, 2, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9973), 3.3599999999999999, 4 },
                    { 65, new DateTime(2024, 5, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(9986), 1.8600000000000001, 1 },
                    { 66, new DateTime(2024, 4, 13, 18, 56, 26, 990, DateTimeKind.Local), 2.8199999999999998, 3 },
                    { 67, new DateTime(2024, 4, 5, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(14), 3.3599999999999999, 4 },
                    { 68, new DateTime(2024, 5, 14, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(29), 2.6800000000000002, 8 },
                    { 69, new DateTime(2024, 5, 3, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(44), 2.7999999999999998, 2 },
                    { 70, new DateTime(2024, 5, 16, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(57), 3.0800000000000001, 6 },
                    { 71, new DateTime(2024, 4, 23, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(71), 3.3599999999999999, 4 },
                    { 72, new DateTime(2024, 5, 6, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(86), 2.7999999999999998, 2 },
                    { 73, new DateTime(2024, 2, 28, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(99), 2.8799999999999999, 9 },
                    { 74, new DateTime(2024, 2, 26, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(113), 2.7999999999999998, 2 },
                    { 75, new DateTime(2024, 4, 17, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(127), 3.3599999999999999, 4 },
                    { 76, new DateTime(2024, 2, 23, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(140), 1.8600000000000001, 1 },
                    { 77, new DateTime(2024, 4, 23, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(180), 1.8600000000000001, 1 },
                    { 78, new DateTime(2024, 3, 15, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(193), 2.8799999999999999, 9 },
                    { 79, new DateTime(2024, 3, 16, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(206), 2.8799999999999999, 9 },
                    { 80, new DateTime(2024, 5, 16, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(220), 2.7999999999999998, 2 },
                    { 81, new DateTime(2024, 3, 28, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(234), 2.8199999999999998, 3 },
                    { 82, new DateTime(2024, 5, 10, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(247), 2.8799999999999999, 9 },
                    { 83, new DateTime(2024, 3, 1, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(261), 2.7999999999999998, 2 },
                    { 84, new DateTime(2024, 3, 11, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(274), 1.8600000000000001, 1 },
                    { 85, new DateTime(2024, 4, 26, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(288), 3.0800000000000001, 6 },
                    { 86, new DateTime(2024, 5, 1, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(301), 2.0, 5 },
                    { 87, new DateTime(2024, 4, 30, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(315), 3.0800000000000001, 6 },
                    { 88, new DateTime(2024, 2, 24, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(328), 1.8600000000000001, 1 },
                    { 89, new DateTime(2024, 2, 22, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(342), 3.3599999999999999, 4 },
                    { 90, new DateTime(2024, 5, 7, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(357), 2.6800000000000002, 8 },
                    { 91, new DateTime(2024, 4, 16, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(398), 2.8799999999999999, 9 },
                    { 92, new DateTime(2024, 3, 5, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(411), 1.8600000000000001, 1 },
                    { 93, new DateTime(2024, 5, 21, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(425), 2.8799999999999999, 9 },
                    { 94, new DateTime(2024, 4, 28, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(439), 2.7999999999999998, 2 },
                    { 95, new DateTime(2024, 3, 17, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(451), 1.8600000000000001, 1 },
                    { 96, new DateTime(2024, 2, 26, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(465), 2.7999999999999998, 2 },
                    { 97, new DateTime(2024, 3, 1, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(479), 3.3599999999999999, 4 },
                    { 98, new DateTime(2024, 4, 8, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(494), 2.6800000000000002, 8 },
                    { 99, new DateTime(2024, 3, 1, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(508), 2.8199999999999998, 3 },
                    { 100, new DateTime(2024, 3, 17, 18, 56, 26, 990, DateTimeKind.Local).AddTicks(522), 3.0800000000000001, 6 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 12, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8614), 2, 7, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 3 },
                    { 2, new DateTime(2024, 4, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8637), 5, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 9 },
                    { 3, new DateTime(2024, 4, 4, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8639), 2, 3, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing e", 3 },
                    { 4, new DateTime(2024, 4, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8641), 0, 5, 13, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 9 },
                    { 5, new DateTime(2024, 4, 12, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8643), 0, 4, 15, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod t", 6 },
                    { 6, new DateTime(2024, 4, 30, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8645), 3, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing e", 2 },
                    { 7, new DateTime(2024, 3, 14, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8646), 5, 5, 13, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor", 8 },
                    { 8, new DateTime(2024, 4, 2, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8648), 4, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", 8 },
                    { 9, new DateTime(2024, 5, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8650), 4, 3, 1, 0, "Lorem ipsum dolor sit amet, consectetur ad", 8 },
                    { 10, new DateTime(2024, 3, 11, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8651), 2, 5, 13, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ei", 6 },
                    { 11, new DateTime(2024, 4, 28, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8653), 0, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adi", 1 },
                    { 12, new DateTime(2024, 3, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8688), 5, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", 1 },
                    { 13, new DateTime(2024, 5, 1, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8690), 3, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", 8 },
                    { 14, new DateTime(2024, 5, 7, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8692), 5, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 6 },
                    { 15, new DateTime(2024, 5, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8694), 1, 5, 13, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, ", 8 },
                    { 16, new DateTime(2024, 2, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8696), 3, 4, 15, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid", 8 },
                    { 17, new DateTime(2024, 3, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8697), 3, 4, 15, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", 1 },
                    { 18, new DateTime(2024, 2, 23, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8698), 1, 4, 15, 0, "Lorem ipsum dolor sit amet, consectetur adip", 8 },
                    { 19, new DateTime(2024, 4, 3, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8700), 3, 5, 13, 0, "Lorem ipsum dolor sit amet, consectetu", 3 },
                    { 20, new DateTime(2024, 3, 11, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8701), 4, 4, 15, 0, "Lorem ipsum dolor sit am", 3 },
                    { 21, new DateTime(2024, 3, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8703), 0, 1, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", 7 },
                    { 22, new DateTime(2024, 2, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8704), 4, 4, 15, 1, "Lorem ipsum dolor sit amet, consectet", 5 },
                    { 23, new DateTime(2024, 3, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8706), 0, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adip", 7 },
                    { 24, new DateTime(2024, 4, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8707), 4, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor", 1 },
                    { 25, new DateTime(2024, 2, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8709), 0, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, se", 8 },
                    { 26, new DateTime(2024, 4, 8, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8710), 4, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do", 1 },
                    { 27, new DateTime(2024, 3, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8712), 1, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ", 7 },
                    { 28, new DateTime(2024, 5, 5, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8713), 5, 1, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, ", 9 },
                    { 29, new DateTime(2024, 3, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8715), 4, 9, 17, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 8 },
                    { 30, new DateTime(2024, 2, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8716), 3, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", 8 },
                    { 31, new DateTime(2024, 4, 15, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8717), 3, 6, 9, 1, "Lorem ipsum dolor sit amet, consec", 5 },
                    { 32, new DateTime(2024, 5, 27, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8719), 3, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipi", 8 },
                    { 33, new DateTime(2024, 3, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8720), 5, 6, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 5 },
                    { 34, new DateTime(2024, 5, 16, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8722), 5, 2, 28, 1, "Lorem ipsum dolor sit amet, consectetur adipisicin", 3 },
                    { 35, new DateTime(2024, 3, 11, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8723), 1, 8, 11, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit,", 6 },
                    { 36, new DateTime(2024, 5, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8725), 3, 1, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor", 9 },
                    { 37, new DateTime(2024, 4, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8726), 3, 3, 1, 0, "Lorem ipsum dolor sit ", 3 },
                    { 38, new DateTime(2024, 5, 13, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8727), 4, 4, 15, 1, "Lorem ipsum dolor sit amet, consectetur adipisicin", 3 },
                    { 39, new DateTime(2024, 5, 9, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8729), 4, 3, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit,", 5 },
                    { 40, new DateTime(2024, 3, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8730), 4, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor", 5 },
                    { 41, new DateTime(2024, 2, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8732), 5, 4, 15, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ei", 6 },
                    { 42, new DateTime(2024, 4, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8734), 3, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempo", 2 },
                    { 43, new DateTime(2024, 5, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8735), 4, 6, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempo", 1 },
                    { 44, new DateTime(2024, 5, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8736), 2, 7, 4, 0, "Lorem ipsum dolor sit amet, consectetur adip", 6 },
                    { 45, new DateTime(2024, 4, 19, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8738), 3, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid", 6 },
                    { 46, new DateTime(2024, 2, 23, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8739), 5, 6, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 9 },
                    { 47, new DateTime(2024, 4, 5, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8740), 0, 5, 13, 1, "Lorem ipsum dolor sit amet, consectetur adipis", 4 },
                    { 48, new DateTime(2024, 4, 30, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8742), 5, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 6 },
                    { 49, new DateTime(2024, 5, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8743), 5, 9, 17, 1, "Lorem ipsum dolor sit amet, consectetur", 1 },
                    { 50, new DateTime(2024, 5, 7, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8771), 4, 4, 15, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing el", 4 },
                    { 51, new DateTime(2024, 4, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8772), 3, 8, 11, 1, "Lorem ipsum dolor sit amet,", 2 },
                    { 52, new DateTime(2024, 3, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8774), 1, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inc", 1 },
                    { 53, new DateTime(2024, 2, 28, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8775), 0, 1, 2, 1, "Lorem ipsum dolor sit amet, consecte", 3 },
                    { 54, new DateTime(2024, 5, 15, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8777), 5, 8, 11, 0, "Lorem ipsum dolor sit amet, consectetur adi", 1 },
                    { 55, new DateTime(2024, 3, 9, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8778), 5, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 2 },
                    { 56, new DateTime(2024, 4, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8780), 3, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisi", 9 },
                    { 57, new DateTime(2024, 2, 19, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8781), 4, 9, 17, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, s", 3 },
                    { 58, new DateTime(2024, 3, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8782), 1, 8, 11, 1, "Lorem ipsum dolor sit", 1 },
                    { 59, new DateTime(2024, 2, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8784), 2, 5, 13, 1, "Lorem ipsum dolor sit amet,", 7 },
                    { 60, new DateTime(2024, 3, 8, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8786), 4, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 1 },
                    { 61, new DateTime(2024, 2, 19, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8787), 2, 4, 15, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", 2 },
                    { 62, new DateTime(2024, 3, 12, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8789), 3, 7, 4, 0, "Lorem ipsum dolor sit amet", 1 },
                    { 63, new DateTime(2024, 5, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8790), 0, 2, 28, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ei", 7 },
                    { 64, new DateTime(2024, 2, 23, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8792), 5, 8, 11, 1, "Lorem ipsum dolor sit amet, consecte", 7 },
                    { 65, new DateTime(2024, 3, 20, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8793), 0, 1, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 2 },
                    { 66, new DateTime(2024, 5, 17, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8794), 0, 2, 28, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", 9 },
                    { 67, new DateTime(2024, 3, 8, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8796), 0, 9, 17, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed ", 8 },
                    { 68, new DateTime(2024, 5, 12, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8797), 4, 8, 11, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor", 9 },
                    { 69, new DateTime(2024, 3, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8798), 1, 9, 17, 0, "Lorem ipsum dolor sit amet, consectetur adipisi", 4 },
                    { 70, new DateTime(2024, 4, 2, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8800), 4, 4, 15, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod ", 5 },
                    { 71, new DateTime(2024, 4, 6, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8801), 5, 9, 17, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 3 },
                    { 72, new DateTime(2024, 2, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8803), 1, 3, 1, 0, "Lorem ipsum dolor sit amet, consectetur ", 9 },
                    { 73, new DateTime(2024, 3, 30, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8804), 1, 1, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid", 5 },
                    { 74, new DateTime(2024, 3, 7, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8805), 3, 8, 11, 1, "Lorem ipsum dolor sit amet, cons", 2 },
                    { 75, new DateTime(2024, 3, 16, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8807), 2, 6, 9, 1, "Lorem ipsum dolor sit amet", 9 },
                    { 76, new DateTime(2024, 5, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8808), 4, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", 5 },
                    { 77, new DateTime(2024, 5, 8, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8810), 5, 4, 15, 0, "Lorem ipsum dolor sit amet, consectet", 6 },
                    { 78, new DateTime(2024, 3, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8812), 2, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ", 9 },
                    { 79, new DateTime(2024, 2, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8813), 3, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetu", 1 },
                    { 80, new DateTime(2024, 3, 23, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8814), 4, 9, 17, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 5 },
                    { 81, new DateTime(2024, 5, 26, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8816), 0, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", 4 },
                    { 82, new DateTime(2024, 3, 8, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8817), 0, 9, 17, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", 5 },
                    { 83, new DateTime(2024, 4, 13, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8818), 4, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 1 },
                    { 84, new DateTime(2024, 2, 24, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8820), 4, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidi", 2 },
                    { 85, new DateTime(2024, 3, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8821), 3, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisi", 4 },
                    { 86, new DateTime(2024, 4, 22, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8823), 5, 4, 15, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, se", 2 },
                    { 87, new DateTime(2024, 4, 6, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8824), 3, 2, 28, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", 9 },
                    { 88, new DateTime(2024, 4, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8826), 2, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 2 },
                    { 89, new DateTime(2024, 4, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8873), 2, 7, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing e", 1 },
                    { 90, new DateTime(2024, 2, 25, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8875), 2, 8, 11, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inc", 7 },
                    { 91, new DateTime(2024, 4, 10, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8876), 1, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 6 },
                    { 92, new DateTime(2024, 4, 13, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8877), 3, 5, 13, 1, "Lorem ipsum dolor sit", 6 },
                    { 93, new DateTime(2024, 4, 14, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8879), 2, 5, 13, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", 1 },
                    { 94, new DateTime(2024, 3, 23, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8881), 5, 6, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempo", 7 },
                    { 95, new DateTime(2024, 3, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8882), 3, 4, 15, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 7 },
                    { 96, new DateTime(2024, 5, 21, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8883), 0, 8, 11, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod ", 4 },
                    { 97, new DateTime(2024, 5, 11, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8885), 0, 3, 1, 1, "Lorem ipsum dolor sit amet, consectetur a", 1 },
                    { 98, new DateTime(2024, 2, 29, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8886), 4, 1, 2, 0, "Lorem ipsum dolor sit amet, consectetur ad", 6 },
                    { 99, new DateTime(2024, 5, 6, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8887), 0, 6, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor ", 7 },
                    { 100, new DateTime(2024, 3, 18, 18, 56, 26, 989, DateTimeKind.Local).AddTicks(8889), 4, 7, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt", 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RatingId",
                table: "Reviews",
                column: "RatingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Ratings");
        }
    }
}
