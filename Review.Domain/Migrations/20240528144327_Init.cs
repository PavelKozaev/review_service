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
                    { 1, new DateTime(2024, 4, 29, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8782), 2.0699999999999998, 9 },
                    { 2, new DateTime(2024, 3, 27, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8803), 2.0699999999999998, 9 },
                    { 3, new DateTime(2024, 2, 19, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8821), 2.7999999999999998, 7 },
                    { 4, new DateTime(2024, 4, 29, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8836), 2.0699999999999998, 9 },
                    { 5, new DateTime(2024, 3, 9, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8852), 2.0800000000000001, 6 },
                    { 6, new DateTime(2024, 5, 8, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8895), 3.0800000000000001, 8 },
                    { 7, new DateTime(2024, 4, 12, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8911), 2.0699999999999998, 9 },
                    { 8, new DateTime(2024, 3, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8926), 2.1200000000000001, 5 },
                    { 9, new DateTime(2024, 5, 27, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8940), 2.1200000000000001, 5 },
                    { 10, new DateTime(2024, 3, 25, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8955), 1.6399999999999999, 1 },
                    { 11, new DateTime(2024, 3, 17, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8969), 1.71, 4 },
                    { 12, new DateTime(2024, 2, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8985), 3.1800000000000002, 3 },
                    { 13, new DateTime(2024, 3, 21, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9001), 2.0699999999999998, 9 },
                    { 14, new DateTime(2024, 5, 13, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9015), 2.0699999999999998, 9 },
                    { 15, new DateTime(2024, 4, 14, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9030), 3.1800000000000002, 3 },
                    { 16, new DateTime(2024, 4, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9043), 1.71, 4 },
                    { 17, new DateTime(2024, 5, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9058), 2.1200000000000001, 5 },
                    { 18, new DateTime(2024, 5, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9072), 2.8799999999999999, 2 },
                    { 19, new DateTime(2024, 3, 1, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9085), 2.1200000000000001, 5 },
                    { 20, new DateTime(2024, 2, 19, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9099), 2.8799999999999999, 2 },
                    { 21, new DateTime(2024, 4, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9168), 3.0800000000000001, 8 },
                    { 22, new DateTime(2024, 4, 17, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9183), 2.8799999999999999, 2 },
                    { 23, new DateTime(2024, 5, 1, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9199), 2.0800000000000001, 6 },
                    { 24, new DateTime(2024, 4, 25, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9212), 1.71, 4 },
                    { 25, new DateTime(2024, 3, 7, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9226), 2.8799999999999999, 2 },
                    { 26, new DateTime(2024, 3, 29, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9240), 1.71, 4 },
                    { 27, new DateTime(2024, 3, 30, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9253), 2.1200000000000001, 5 },
                    { 28, new DateTime(2024, 5, 25, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9269), 2.7999999999999998, 7 },
                    { 29, new DateTime(2024, 2, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9283), 1.71, 4 },
                    { 30, new DateTime(2024, 5, 9, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9298), 2.0699999999999998, 9 },
                    { 31, new DateTime(2024, 5, 11, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9311), 2.1200000000000001, 5 },
                    { 32, new DateTime(2024, 3, 15, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9326), 2.7999999999999998, 7 },
                    { 33, new DateTime(2024, 5, 16, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9341), 2.0800000000000001, 6 },
                    { 34, new DateTime(2024, 5, 6, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9357), 2.0699999999999998, 9 },
                    { 35, new DateTime(2024, 4, 9, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9372), 3.0800000000000001, 8 },
                    { 36, new DateTime(2024, 4, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9385), 2.1200000000000001, 5 },
                    { 37, new DateTime(2024, 3, 15, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9429), 3.0800000000000001, 8 },
                    { 38, new DateTime(2024, 5, 5, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9443), 1.71, 4 },
                    { 39, new DateTime(2024, 5, 13, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9458), 3.1800000000000002, 3 },
                    { 40, new DateTime(2024, 5, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9473), 2.0800000000000001, 6 },
                    { 41, new DateTime(2024, 3, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9488), 3.0800000000000001, 8 },
                    { 42, new DateTime(2024, 4, 16, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9502), 2.0800000000000001, 6 },
                    { 43, new DateTime(2024, 5, 21, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9517), 1.6399999999999999, 1 },
                    { 44, new DateTime(2024, 5, 9, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9532), 2.0800000000000001, 6 },
                    { 45, new DateTime(2024, 4, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9545), 2.8799999999999999, 2 },
                    { 46, new DateTime(2024, 5, 1, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9560), 2.7999999999999998, 7 },
                    { 47, new DateTime(2024, 5, 14, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9575), 2.0699999999999998, 9 },
                    { 48, new DateTime(2024, 3, 4, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9590), 2.7999999999999998, 7 },
                    { 49, new DateTime(2024, 4, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9605), 3.0800000000000001, 8 },
                    { 50, new DateTime(2024, 3, 27, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9618), 2.1200000000000001, 5 },
                    { 51, new DateTime(2024, 5, 26, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9669), 2.0699999999999998, 9 },
                    { 52, new DateTime(2024, 5, 5, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9684), 2.0800000000000001, 6 },
                    { 53, new DateTime(2024, 3, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9699), 2.0699999999999998, 9 },
                    { 54, new DateTime(2024, 4, 18, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9713), 2.0800000000000001, 6 },
                    { 55, new DateTime(2024, 3, 4, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9728), 3.1800000000000002, 3 },
                    { 56, new DateTime(2024, 2, 29, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9743), 1.6399999999999999, 1 },
                    { 57, new DateTime(2024, 4, 3, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9758), 2.0699999999999998, 9 },
                    { 58, new DateTime(2024, 4, 11, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9772), 2.1200000000000001, 5 },
                    { 59, new DateTime(2024, 3, 2, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9787), 3.0800000000000001, 8 },
                    { 60, new DateTime(2024, 4, 14, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9802), 1.6399999999999999, 1 },
                    { 61, new DateTime(2024, 4, 25, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9817), 2.0699999999999998, 9 },
                    { 62, new DateTime(2024, 3, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9832), 2.7999999999999998, 7 },
                    { 63, new DateTime(2024, 3, 12, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9847), 2.0699999999999998, 9 },
                    { 64, new DateTime(2024, 4, 9, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9862), 3.0800000000000001, 8 },
                    { 65, new DateTime(2024, 5, 2, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9904), 1.6399999999999999, 1 },
                    { 66, new DateTime(2024, 5, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9919), 1.6399999999999999, 1 },
                    { 67, new DateTime(2024, 5, 8, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9932), 2.1200000000000001, 5 },
                    { 68, new DateTime(2024, 4, 17, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9947), 2.7999999999999998, 7 },
                    { 69, new DateTime(2024, 4, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9962), 3.0800000000000001, 8 },
                    { 70, new DateTime(2024, 3, 29, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9977), 3.0800000000000001, 8 },
                    { 71, new DateTime(2024, 4, 30, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(9991), 2.1200000000000001, 5 },
                    { 72, new DateTime(2024, 2, 27, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(5), 2.1200000000000001, 5 },
                    { 73, new DateTime(2024, 3, 24, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(19), 2.0800000000000001, 6 },
                    { 74, new DateTime(2024, 5, 14, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(34), 2.0800000000000001, 6 },
                    { 75, new DateTime(2024, 3, 14, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(47), 2.1200000000000001, 5 },
                    { 76, new DateTime(2024, 3, 25, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(61), 2.8799999999999999, 2 },
                    { 77, new DateTime(2024, 2, 29, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(75), 2.8799999999999999, 2 },
                    { 78, new DateTime(2024, 4, 26, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(89), 2.0800000000000001, 6 },
                    { 79, new DateTime(2024, 3, 26, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(104), 2.0699999999999998, 9 },
                    { 80, new DateTime(2024, 2, 25, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(144), 2.1200000000000001, 5 },
                    { 81, new DateTime(2024, 3, 13, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(158), 1.71, 4 },
                    { 82, new DateTime(2024, 4, 18, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(173), 1.6399999999999999, 1 },
                    { 83, new DateTime(2024, 3, 17, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(187), 1.6399999999999999, 1 },
                    { 84, new DateTime(2024, 4, 15, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(202), 1.6399999999999999, 1 },
                    { 85, new DateTime(2024, 5, 23, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(217), 3.0800000000000001, 8 },
                    { 86, new DateTime(2024, 3, 3, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(230), 1.71, 4 },
                    { 87, new DateTime(2024, 4, 16, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(246), 2.0699999999999998, 9 },
                    { 88, new DateTime(2024, 3, 26, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(260), 1.6399999999999999, 1 },
                    { 89, new DateTime(2024, 4, 24, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(274), 2.8799999999999999, 2 },
                    { 90, new DateTime(2024, 5, 17, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(287), 2.8799999999999999, 2 },
                    { 91, new DateTime(2024, 3, 31, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(302), 2.0800000000000001, 6 },
                    { 92, new DateTime(2024, 5, 14, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(316), 1.6399999999999999, 1 },
                    { 93, new DateTime(2024, 5, 9, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(332), 2.0699999999999998, 9 },
                    { 94, new DateTime(2024, 3, 25, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(383), 2.7999999999999998, 7 },
                    { 95, new DateTime(2024, 5, 15, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(398), 1.6399999999999999, 1 },
                    { 96, new DateTime(2024, 3, 26, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(413), 2.0699999999999998, 9 },
                    { 97, new DateTime(2024, 2, 24, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(427), 1.71, 4 },
                    { 98, new DateTime(2024, 5, 14, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(440), 1.71, 4 },
                    { 99, new DateTime(2024, 4, 27, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(455), 2.0800000000000001, 6 },
                    { 100, new DateTime(2024, 4, 6, 17, 43, 17, 924, DateTimeKind.Local).AddTicks(470), 2.7999999999999998, 7 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId", "RatingId", "Status", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 18, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8358), 2, 9, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ", 1 },
                    { 2, new DateTime(2024, 5, 19, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8375), 5, 5, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 4 },
                    { 3, new DateTime(2024, 4, 19, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8377), 0, 1, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 5 },
                    { 4, new DateTime(2024, 4, 15, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8440), 2, 2, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisic", 9 },
                    { 5, new DateTime(2024, 4, 8, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8442), 4, 3, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i", 6 },
                    { 6, new DateTime(2024, 3, 21, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8444), 0, 2, 8, 0, "Lorem ipsum dolor sit amet, consectetur adi", 6 },
                    { 7, new DateTime(2024, 2, 19, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8446), 4, 8, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 3 },
                    { 8, new DateTime(2024, 5, 5, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8448), 4, 9, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", 2 },
                    { 9, new DateTime(2024, 4, 3, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8449), 4, 3, 4, 1, "Lorem ipsum dolor sit amet, consectetur ", 3 },
                    { 10, new DateTime(2024, 2, 25, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8451), 0, 9, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 6 },
                    { 11, new DateTime(2024, 5, 16, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8452), 1, 6, 4, 1, "Lorem ipsum dolor sit ", 6 },
                    { 12, new DateTime(2024, 2, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8454), 1, 9, 1, 0, "Lorem ipsum dolor sit ame", 2 },
                    { 13, new DateTime(2024, 3, 29, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8456), 4, 7, 1, 0, "Lorem ipsum dolor sit am", 2 },
                    { 14, new DateTime(2024, 5, 6, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8457), 2, 4, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 1 },
                    { 15, new DateTime(2024, 5, 7, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8459), 5, 2, 5, 0, "Lorem ipsum dolor sit am", 8 },
                    { 16, new DateTime(2024, 4, 5, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8460), 3, 6, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 4 },
                    { 17, new DateTime(2024, 4, 7, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8462), 5, 2, 8, 1, "Lorem ipsum dolor sit amet", 2 },
                    { 18, new DateTime(2024, 3, 21, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8464), 2, 5, 5, 1, "Lorem ipsum dolor sit amet, consect", 4 },
                    { 19, new DateTime(2024, 3, 8, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8465), 1, 7, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 7 },
                    { 20, new DateTime(2024, 4, 3, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8466), 4, 3, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", 1 },
                    { 21, new DateTime(2024, 5, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8468), 1, 6, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", 9 },
                    { 22, new DateTime(2024, 5, 27, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8469), 2, 1, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, ", 6 },
                    { 23, new DateTime(2024, 3, 12, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8471), 0, 6, 8, 1, "Lorem ipsum dolor sit amet, con", 2 },
                    { 24, new DateTime(2024, 5, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8473), 1, 2, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", 7 },
                    { 25, new DateTime(2024, 2, 26, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8474), 2, 3, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", 2 },
                    { 26, new DateTime(2024, 5, 14, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8476), 0, 4, 4, 0, "Lorem ipsum dolor sit a", 6 },
                    { 27, new DateTime(2024, 4, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8478), 1, 5, 9, 1, "Lorem ipsum dolor sit a", 6 },
                    { 28, new DateTime(2024, 5, 9, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8479), 3, 6, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 7 },
                    { 29, new DateTime(2024, 3, 4, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8481), 0, 9, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 6 },
                    { 30, new DateTime(2024, 5, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8483), 2, 9, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 5 },
                    { 31, new DateTime(2024, 3, 3, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8484), 0, 1, 1, 1, "Lorem ipsum dolor sit amet,", 4 },
                    { 32, new DateTime(2024, 2, 28, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8486), 0, 5, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod ", 5 },
                    { 33, new DateTime(2024, 5, 6, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8487), 0, 9, 3, 0, "Lorem ipsum dolor si", 5 },
                    { 34, new DateTime(2024, 3, 5, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8489), 0, 8, 7, 1, "Lorem ipsum dolor sit amet, consectetur ", 7 },
                    { 35, new DateTime(2024, 4, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8490), 2, 6, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 8 },
                    { 36, new DateTime(2024, 3, 12, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8492), 0, 8, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor in", 5 },
                    { 37, new DateTime(2024, 3, 11, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8493), 3, 6, 8, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, se", 9 },
                    { 38, new DateTime(2024, 3, 28, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8495), 1, 3, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", 6 },
                    { 39, new DateTime(2024, 3, 2, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8496), 3, 9, 3, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididu", 6 },
                    { 40, new DateTime(2024, 3, 7, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8498), 4, 3, 6, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 4 },
                    { 41, new DateTime(2024, 4, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8499), 5, 2, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", 5 },
                    { 42, new DateTime(2024, 3, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8500), 2, 8, 1, 1, "Lorem ipsum dolor sit amet, consect", 8 },
                    { 43, new DateTime(2024, 3, 26, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8502), 2, 1, 1, 0, "Lorem ipsum dolor sit amet, co", 5 },
                    { 44, new DateTime(2024, 3, 5, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8504), 4, 8, 8, 1, "Lorem ipsum dolor sit amet", 3 },
                    { 45, new DateTime(2024, 5, 26, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8587), 1, 4, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing e", 5 },
                    { 46, new DateTime(2024, 3, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8589), 3, 1, 6, 1, "Lorem ipsum dolor sit amet, consecte", 5 },
                    { 47, new DateTime(2024, 3, 12, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8591), 2, 6, 5, 0, "Lorem ipsum dolor sit a", 1 },
                    { 48, new DateTime(2024, 5, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8592), 2, 7, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisi", 8 },
                    { 49, new DateTime(2024, 5, 26, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8594), 1, 5, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", 5 },
                    { 50, new DateTime(2024, 3, 4, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8595), 5, 4, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed d", 5 },
                    { 51, new DateTime(2024, 5, 11, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8596), 4, 5, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, se", 8 },
                    { 52, new DateTime(2024, 5, 4, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8598), 3, 7, 3, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inc", 7 },
                    { 53, new DateTime(2024, 4, 4, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8599), 5, 3, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 1 },
                    { 54, new DateTime(2024, 5, 25, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8601), 1, 4, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmo", 3 },
                    { 55, new DateTime(2024, 5, 2, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8602), 4, 1, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", 5 },
                    { 56, new DateTime(2024, 3, 21, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8604), 5, 7, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut ", 1 },
                    { 57, new DateTime(2024, 5, 27, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8605), 2, 4, 6, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit,", 1 },
                    { 58, new DateTime(2024, 5, 18, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8607), 3, 8, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 1 },
                    { 59, new DateTime(2024, 4, 12, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8608), 4, 9, 5, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 1 },
                    { 60, new DateTime(2024, 4, 8, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8609), 0, 3, 5, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 5 },
                    { 61, new DateTime(2024, 3, 7, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8611), 0, 1, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 3 },
                    { 62, new DateTime(2024, 5, 3, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8612), 3, 5, 1, 1, "Lorem ipsum dolor sit amet, consectetur", 3 },
                    { 63, new DateTime(2024, 4, 17, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8614), 3, 7, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", 5 },
                    { 64, new DateTime(2024, 2, 27, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8615), 2, 9, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidi", 1 },
                    { 65, new DateTime(2024, 4, 5, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8617), 3, 7, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipi", 2 },
                    { 66, new DateTime(2024, 5, 23, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8618), 4, 8, 2, 1, "Lorem ipsum dolor sit amet, consectetur adi", 5 },
                    { 67, new DateTime(2024, 4, 21, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8619), 1, 9, 4, 0, "Lorem ipsum dolor sit amet, consectet", 5 },
                    { 68, new DateTime(2024, 5, 3, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8621), 1, 7, 6, 0, "Lorem ipsum dolor sit amet, consectetur adi", 4 },
                    { 69, new DateTime(2024, 2, 18, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8623), 4, 3, 9, 1, "Lorem ipsum dolor sit am", 4 },
                    { 70, new DateTime(2024, 4, 2, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8624), 2, 2, 5, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do", 8 },
                    { 71, new DateTime(2024, 4, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8625), 3, 8, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", 2 },
                    { 72, new DateTime(2024, 5, 21, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8627), 3, 8, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod ", 6 },
                    { 73, new DateTime(2024, 5, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8628), 2, 1, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 9 },
                    { 74, new DateTime(2024, 4, 4, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8630), 1, 9, 9, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 4 },
                    { 75, new DateTime(2024, 5, 25, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8631), 2, 6, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", 3 },
                    { 76, new DateTime(2024, 3, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8632), 5, 9, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do e", 8 },
                    { 77, new DateTime(2024, 2, 26, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8634), 3, 2, 3, 1, "Lorem ipsum dolor sit amet, consectetur ad", 8 },
                    { 78, new DateTime(2024, 4, 28, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8635), 2, 1, 7, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor ", 7 },
                    { 79, new DateTime(2024, 3, 12, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8637), 5, 9, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", 4 },
                    { 80, new DateTime(2024, 3, 31, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8638), 2, 7, 6, 0, "Lorem ipsum dolor sit amet, consect", 5 },
                    { 81, new DateTime(2024, 3, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8639), 4, 8, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", 1 },
                    { 82, new DateTime(2024, 4, 26, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8640), 5, 8, 4, 0, "Lorem ipsum dolor sit amet, consectetur ", 6 },
                    { 83, new DateTime(2024, 4, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8690), 3, 3, 3, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", 3 },
                    { 84, new DateTime(2024, 3, 28, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8692), 4, 7, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incid", 1 },
                    { 85, new DateTime(2024, 2, 20, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8693), 1, 7, 3, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing e", 7 },
                    { 86, new DateTime(2024, 5, 14, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8695), 5, 6, 4, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ", 5 },
                    { 87, new DateTime(2024, 3, 31, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8696), 0, 1, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor in", 7 },
                    { 88, new DateTime(2024, 4, 15, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8698), 5, 8, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing ", 5 },
                    { 89, new DateTime(2024, 5, 24, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8699), 2, 7, 8, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod", 1 },
                    { 90, new DateTime(2024, 3, 1, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8701), 1, 5, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", 8 },
                    { 91, new DateTime(2024, 3, 13, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8703), 4, 7, 8, 0, "Lorem ipsum dolor sit am", 8 },
                    { 92, new DateTime(2024, 5, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8704), 3, 8, 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", 3 },
                    { 93, new DateTime(2024, 4, 17, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8705), 3, 1, 8, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor ", 1 },
                    { 94, new DateTime(2024, 5, 7, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8707), 1, 6, 9, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 8 },
                    { 95, new DateTime(2024, 4, 17, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8708), 3, 7, 2, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit,", 1 },
                    { 96, new DateTime(2024, 3, 15, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8710), 1, 9, 7, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod t", 5 },
                    { 97, new DateTime(2024, 4, 10, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8711), 2, 6, 1, 0, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", 5 },
                    { 98, new DateTime(2024, 5, 2, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8712), 4, 3, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing el", 1 },
                    { 99, new DateTime(2024, 3, 30, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8714), 1, 4, 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod ", 4 },
                    { 100, new DateTime(2024, 4, 22, 17, 43, 17, 923, DateTimeKind.Local).AddTicks(8715), 4, 7, 6, 0, "Lorem ipsum dolor sit amet, consectetu", 1 }
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
