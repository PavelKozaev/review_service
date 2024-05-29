﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Review.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Initialization : Migration
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
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "Id", "Password", "UserName" },
                values: new object[] { 1, "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreateDate", "Grade", "ProductId", "Status", "Text", "UserId" },
                values: new object[,]
                {
                    { new Guid("001b7718-71af-45e5-8560-ef695882defd"), new DateTime(2024, 5, 8, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5536), 1, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed ", new Guid("0ca943d5-c1a4-4840-baf5-3bc365a868cf") },
                    { new Guid("00d3bb7d-0887-4cf8-b1e5-67b2ab7ec1d1"), new DateTime(2024, 5, 1, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5439), 3, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 1, "Lorem ipsum dolor sit amet, consectetur adipis", new Guid("0e4ca155-aed3-4c0e-85cf-92205eaf3431") },
                    { new Guid("017638ec-a6ea-40e7-b9c8-aea4119a4350"), new DateTime(2024, 5, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5480), 2, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 2, "Lorem ipsum dolor sit amet, consectetur adip", new Guid("5fbd549a-3364-443a-90ce-208459bde5d8") },
                    { new Guid("020e642e-80bc-43e7-af95-66bcf05f5b4a"), new DateTime(2024, 2, 20, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5421), 5, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", new Guid("71fdec9e-02eb-4a88-a6cd-3ebafc5b287a") },
                    { new Guid("0238a886-ed7f-4271-a72b-649d643b1998"), new DateTime(2024, 5, 18, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5446), 2, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", new Guid("54dea803-fcda-4d97-a483-90903a32ea00") },
                    { new Guid("08100bc8-00c3-4cd0-a639-fc3de763d433"), new DateTime(2024, 4, 3, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5546), 2, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", new Guid("ff39f1d0-d2cf-4f62-83ef-ebba436fb3e2") },
                    { new Guid("094adde6-ce41-4782-9c3c-029d7ef24663"), new DateTime(2024, 5, 15, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5655), 4, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 1, "Lorem ipsum dolor si", new Guid("3778be8c-cf5a-4d22-b567-f21d53b066c9") },
                    { new Guid("0c8a9238-f914-4ed2-b750-b2eeda8ac367"), new DateTime(2024, 2, 24, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5407), 3, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", new Guid("19384498-25dc-4d8a-9862-8fc046770fc5") },
                    { new Guid("0d35c01a-4dcd-48fe-bda1-1cce1964c5b0"), new DateTime(2024, 2, 28, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5607), 3, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 2, "Lorem ipsum dolor sit amet, conse", new Guid("b3165d8e-e779-475c-8808-a6effd24b6f1") },
                    { new Guid("0d9929a3-5a2e-4227-896d-e182fa43a3a9"), new DateTime(2024, 3, 15, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5669), 4, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 2, "Lorem ipsum dolor sit amet, cons", new Guid("79836b32-9729-4a7f-aa52-93eb8f51c84e") },
                    { new Guid("0e926e8c-0c62-4389-9a6a-606d2886a825"), new DateTime(2024, 2, 27, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5569), 5, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 1, "Lorem ipsum dolor si", new Guid("42991d68-a633-4acb-b7da-02b128f32861") },
                    { new Guid("0fea57e1-faa0-4759-8abd-f004663b14a7"), new DateTime(2024, 5, 5, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5571), 3, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incid", new Guid("9dc5f8fa-fc1c-4c7e-a818-bdc7372f999f") },
                    { new Guid("10d08adb-085b-4ab1-a6f7-06b8a9abd6ef"), new DateTime(2024, 2, 24, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5532), 2, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet, consectetur ad", new Guid("0e03d9c3-b973-44f8-8fae-9284083269b6") },
                    { new Guid("125bc190-53d3-4057-811f-e9c487bc1d03"), new DateTime(2024, 2, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5436), 2, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit amet, consectet", new Guid("18756ba3-b093-45c3-98a0-e2f9748829d2") },
                    { new Guid("169f0ea0-b517-4b89-9585-e793640c2e2e"), new DateTime(2024, 5, 17, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5410), 4, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 2, "Lorem ipsum dolor sit amet, consectetur", new Guid("2a397ad2-1855-4170-99b5-a2084391e28a") },
                    { new Guid("16d83ab3-9af5-46c8-8691-219e94980c71"), new DateTime(2024, 4, 7, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5598), 4, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ei", new Guid("c2a65882-83a3-44a0-a068-1729ce7ed520") },
                    { new Guid("19ec613c-a78a-4ca7-bdb8-52147b305061"), new DateTime(2024, 4, 14, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5667), 3, new Guid("a836a521-34a5-46c1-8186-1351e1baeee1"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do", new Guid("f9e17ce4-9d9c-4191-9752-01ca889050fc") },
                    { new Guid("1e1f4971-bbae-47d7-bde4-2e828af1b709"), new DateTime(2024, 5, 15, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5364), 4, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 1, "Lorem ipsum dolor sit amet, consectetur", new Guid("a1a72c58-8740-4322-833b-50aa1335c2df") },
                    { new Guid("20b153ca-db0a-4998-bbb6-ed808a58eeee"), new DateTime(2024, 5, 25, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5592), 4, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed ", new Guid("28523e6b-f952-42d3-93cf-0668305b515e") },
                    { new Guid("2223aab6-c800-4973-956d-f473615b2e05"), new DateTime(2024, 4, 26, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5675), 2, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 1, "Lorem ipsum dolor sit amet, consectetur adip", new Guid("f73198b8-6989-4a6b-afd3-9021b719effd") },
                    { new Guid("2369896d-b2bf-455f-938d-e820666d32c4"), new DateTime(2024, 2, 23, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5336), 2, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit amet, conse", new Guid("10dfa50d-f2b3-4497-aa73-7f079a92d817") },
                    { new Guid("27a7e7b8-6fce-467a-bbe6-70e665f32959"), new DateTime(2024, 4, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5574), 3, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit amet, consect", new Guid("9138d483-fac3-4cbd-80c0-521c8e356237") },
                    { new Guid("2a26eb7f-ba24-48b2-b4ee-51b34cf4b392"), new DateTime(2024, 3, 20, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5645), 5, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing eli", new Guid("3b78decd-10cc-47f0-9ac9-f83c053ec3a4") },
                    { new Guid("2c027bcb-0ffe-42e6-a1ef-26f72f617875"), new DateTime(2024, 4, 29, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5677), 3, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 2, "Lorem ipsum dolor sit amet, co", new Guid("82c81fde-ce63-48a0-a76d-4cc54b63aca4") },
                    { new Guid("2ed1ad1c-be80-4e5b-ac28-83aa795036a3"), new DateTime(2024, 3, 1, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5425), 1, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", new Guid("32a572c4-0e62-4a88-8659-bee8820a9e21") },
                    { new Guid("33029a29-650c-48d0-af26-791d64bfbf74"), new DateTime(2024, 2, 27, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5639), 3, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", new Guid("d4ba9940-2760-40ea-b3ba-24e62c225dcf") },
                    { new Guid("330e0290-9f99-494f-8ef5-51643df4e314"), new DateTime(2024, 5, 6, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5460), 2, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inc", new Guid("cf1e064a-7b56-4a2f-aa9d-6dc3a0994c28") },
                    { new Guid("38463616-62f1-441d-a801-f7e0eaab46a7"), new DateTime(2024, 5, 24, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5582), 3, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet, consectetu", new Guid("cdc3b9e3-e0e6-4269-bac2-d3557059e186") },
                    { new Guid("3a287814-992c-4b88-bdef-1f6fec3a2ef6"), new DateTime(2024, 5, 2, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5594), 1, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", new Guid("dd106783-df3a-4b29-8e28-dafc37cdf2a4") },
                    { new Guid("3b914105-b532-4e1d-b503-08f0bd7f55ff"), new DateTime(2024, 4, 6, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5567), 3, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 1, "Lorem ipsum dolor sit ", new Guid("7edf1270-b8e6-488f-9c95-19460c66d9ab") },
                    { new Guid("3de10db5-17ab-4f54-872e-7c1180628e94"), new DateTime(2024, 4, 15, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5462), 4, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet,", new Guid("79ea0d48-c21d-45bd-8a75-f3322beed8a4") },
                    { new Guid("3f336f26-47ee-4549-b3f9-df46a617dd62"), new DateTime(2024, 3, 16, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5601), 5, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing el", new Guid("35188487-1df5-4804-b98f-7311ecd738bf") },
                    { new Guid("409daff2-81e7-44f7-a196-c3180f74f9b0"), new DateTime(2024, 2, 24, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5403), 4, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 2, "Lorem ipsum dolor sit amet, consectet", new Guid("df0cf9b4-c070-4511-ba0f-0be12ca4605e") },
                    { new Guid("414e0d94-5c42-4351-84d7-a5b673063c0e"), new DateTime(2024, 2, 19, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5550), 4, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i", new Guid("03aac841-0a20-435e-81b6-c4e3d14d5fdd") },
                    { new Guid("417934e8-f26d-4bfa-aa6c-f3623c495818"), new DateTime(2024, 4, 18, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5584), 3, new Guid("a836a521-34a5-46c1-8186-1351e1baeee1"), 2, "Lorem ipsum dolor sit amet, consectetur a", new Guid("720d8317-24fb-4a93-be42-4fadcf4f847c") },
                    { new Guid("42d39cb6-ba10-4504-93fd-42b5992dbd40"), new DateTime(2024, 4, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5466), 4, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", new Guid("1ac7ee12-ea57-4a1a-8c06-663b87f96ea2") },
                    { new Guid("45f7b199-831d-40da-8b51-2878450f8401"), new DateTime(2024, 3, 1, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5456), 4, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut", new Guid("f3045f89-7cfa-4283-9e99-687968a93505") },
                    { new Guid("463d8bc0-22d4-453f-9d70-22482e97b22c"), new DateTime(2024, 3, 11, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5651), 4, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 1, "Lorem ipsum dolor sit amet, ", new Guid("309597ea-37b0-4348-b5f9-5681155ab95f") },
                    { new Guid("4d0236d6-8157-4217-9d59-39485c983d9f"), new DateTime(2024, 3, 17, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5538), 1, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 1, "Lorem ipsum dolor sit amet, consectetur ", new Guid("5a6d5ccb-d547-4148-87fc-5c50a497324f") },
                    { new Guid("51eec77f-769b-4a48-a6a4-131c041ce22c"), new DateTime(2024, 4, 5, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5687), 2, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut lab", new Guid("d1f0d28f-66f8-42b6-8386-63e2fbde7f50") },
                    { new Guid("5929a4e7-ac28-431b-af7d-c8e0d1ea267c"), new DateTime(2024, 3, 1, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5659), 1, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 1, "Lorem ipsum dolor sit amet, co", new Guid("24e089b8-6810-4ee2-9135-fbf2679f1604") },
                    { new Guid("5b05b598-be76-4949-b710-24c986da6792"), new DateTime(2024, 2, 22, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5464), 4, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 1, "Lorem ipsum dolor sit am", new Guid("231b5a3d-a7f5-4ade-b8ed-6104587b2358") },
                    { new Guid("5cc0849d-4e3d-4522-8bc9-9a183f5034d0"), new DateTime(2024, 4, 24, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5484), 3, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 2, "Lorem ipsum dolor sit amet, consectetu", new Guid("d79780c6-dde6-4d17-ba91-ee3059657b95") },
                    { new Guid("5d4b2c43-a220-46d5-8994-821f4c613c0b"), new DateTime(2024, 3, 27, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5548), 5, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", new Guid("7b5817d2-6dd0-42e0-8b89-ff2ec7839250") },
                    { new Guid("6301515c-a7b7-46b1-a410-48dab6d9fa18"), new DateTime(2024, 4, 2, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5474), 1, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i", new Guid("b1e0cf80-30e8-49d1-8fe3-43e8cd0e49c1") },
                    { new Guid("63d50758-4aec-44dd-8865-9c069b914e37"), new DateTime(2024, 4, 10, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5681), 5, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidi", new Guid("812383ff-f29d-47cf-94fe-453b500c0612") },
                    { new Guid("648e1157-ff4c-479f-9f25-595c8d4ae3ac"), new DateTime(2024, 4, 1, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5661), 4, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 2, "Lorem ipsum dolor sit", new Guid("0218daf5-65bb-4a70-bbf9-1135021eb904") },
                    { new Guid("69439003-85c3-46ff-a457-94c5bb03caac"), new DateTime(2024, 3, 26, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5657), 5, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 1, "Lorem ipsum dolor sit amet,", new Guid("b5344208-4906-4b7a-a385-e569c22bd1e9") },
                    { new Guid("6945a40f-4680-4f18-ab3e-1be677d59d7f"), new DateTime(2024, 2, 20, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5454), 2, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", new Guid("746678a7-9eff-430e-a614-9d8dd878e552") },
                    { new Guid("6a60b5ce-a69b-4453-856a-4f6553b97b21"), new DateTime(2024, 3, 17, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5472), 5, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut la", new Guid("0f126ef2-f398-4b79-b9ce-3a0d043754d2") },
                    { new Guid("6c8c53d1-a637-41fd-b458-640106d14e31"), new DateTime(2024, 3, 8, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5691), 1, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod t", new Guid("846369b7-691c-492b-a211-5db406167c88") },
                    { new Guid("6df8254a-2a0d-48e4-a626-585337735ddd"), new DateTime(2024, 5, 6, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5470), 5, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod te", new Guid("32f5ef26-961b-4957-afac-e0fa248d065c") },
                    { new Guid("6e6ca3f6-14e9-46de-86ca-13130d160cf4"), new DateTime(2024, 3, 9, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5560), 2, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing eli", new Guid("04527b69-af23-4d00-b2fc-87ea99a6c6ec") },
                    { new Guid("7699b4ee-238d-4f64-b01f-8fd9c39412c3"), new DateTime(2024, 3, 25, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5695), 3, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", new Guid("90ccb416-1d55-46eb-a2cf-1fdb7f49d7d8") },
                    { new Guid("7c409ff0-43a0-4591-b429-91a914c1611b"), new DateTime(2024, 5, 9, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5685), 3, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 1, "Lorem ipsum dolor sit amet, cons", new Guid("f218e792-15b3-4d7c-b9e3-cd70264aec42") },
                    { new Guid("7c85f1ce-17f1-47ea-b588-e294d7b59f15"), new DateTime(2024, 5, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5434), 3, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt u", new Guid("cddede80-9008-4ab9-950a-0c118d0a2c6a") },
                    { new Guid("802a7f0f-b40c-4c28-a76d-e4d135a92570"), new DateTime(2024, 3, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5450), 2, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ", new Guid("c5fadffb-63df-450c-a224-ca35f41b6e94") },
                    { new Guid("8206d229-a577-4176-8d00-4c8a9f3074cb"), new DateTime(2024, 2, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5519), 2, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 1, "Lorem ipsum dolor sit amet, consectetur", new Guid("82d81abd-f2cc-46dd-b3a6-ded39b094a2d") },
                    { new Guid("88d58769-4f27-4c94-ace9-c4eda5fdf2b5"), new DateTime(2024, 3, 11, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5486), 3, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", new Guid("07d6a95d-58ed-47a7-9b60-6f491cce55ef") },
                    { new Guid("8d0b622c-6712-4ed4-a175-550617b1ccf6"), new DateTime(2024, 4, 16, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5356), 1, new Guid("a836a521-34a5-46c1-8186-1351e1baeee1"), 1, "Lorem ipsum dolor sit amet, consec", new Guid("e9ac5bc6-0117-414f-a6a0-4e4f8f6cf487") },
                    { new Guid("9409e8e5-befa-4074-859a-264548f06869"), new DateTime(2024, 4, 25, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5452), 5, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing el", new Guid("45c3c97f-c5dc-40fa-82d5-907b63d09c26") },
                    { new Guid("94dd2767-b79f-4360-ad46-b9bc638f3294"), new DateTime(2024, 5, 14, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5522), 2, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", new Guid("2f22ad24-7e43-4e40-8127-328444c0f7e8") },
                    { new Guid("9657105b-79dc-4c67-8976-927c9b34967c"), new DateTime(2024, 3, 13, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5444), 2, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing el", new Guid("e7339337-d799-4ad9-9b21-411302d45747") },
                    { new Guid("9e969711-ef38-4a64-a54e-267e4c52f55f"), new DateTime(2024, 4, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5578), 4, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, s", new Guid("a74c14f4-0dd9-40e8-be0a-df37deb24d9d") },
                    { new Guid("a020b3f8-8cd9-41a9-90b0-12cc4d87bf2f"), new DateTime(2024, 3, 1, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5423), 4, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", new Guid("35ff11aa-3c25-4b6c-9786-44b96dad39e2") },
                    { new Guid("a3ec58ca-b373-498c-b4e8-475afc4379b2"), new DateTime(2024, 4, 29, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5580), 3, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod temp", new Guid("174b05db-05ca-46d2-b315-a78e51c1e99a") },
                    { new Guid("a577415f-4271-497e-9b05-a41b206cfa1b"), new DateTime(2024, 3, 28, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5679), 1, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", new Guid("b89a5ed2-cefd-4801-ad82-52e5c98d5324") },
                    { new Guid("a62b3df0-fb3b-4762-b2ea-bcc7ff452417"), new DateTime(2024, 4, 7, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5413), 2, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor ", new Guid("7c4bc97b-5fa3-4ce8-b574-b2df5e3841e7") },
                    { new Guid("aa63c99d-7e7e-49f0-9c49-6ec428122e30"), new DateTime(2024, 4, 11, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5558), 4, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", new Guid("d57c4fd8-2893-4441-9fed-ccf891475590") },
                    { new Guid("aaa41f71-4b34-4327-ac7b-a777fdf10fd2"), new DateTime(2024, 5, 12, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5641), 1, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 2, "Lorem ipsum dolor sit amet, consectetur a", new Guid("5859e842-5be9-4b5e-9fcf-cbf52272042c") },
                    { new Guid("adc9349e-098d-4b0d-9ea7-4f0d1cdaeea4"), new DateTime(2024, 3, 10, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5528), 1, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 1, "Lorem ipsum dolor sit ", new Guid("f60e8810-b2b5-4c51-8a20-6ef014310f56") },
                    { new Guid("b1bfe8f1-e325-419b-959c-853fe98ecd5c"), new DateTime(2024, 5, 5, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5432), 5, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 2, "Lorem ipsum dolor sit amet, consectetur ", new Guid("7a2a106b-0f95-4436-804d-86707d0f9b5f") },
                    { new Guid("ba2a4a9c-d674-4e8a-8551-2e4e028b33d6"), new DateTime(2024, 3, 3, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5588), 1, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 2, "Lorem ipsum dolor sit amet, consectetur adipi", new Guid("12d74c2f-2dfa-47da-b73f-0e6b099c6dd0") },
                    { new Guid("bcbd6039-4ae6-4500-b7c9-5203c4cae83a"), new DateTime(2024, 3, 2, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5476), 3, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 1, "Lorem ipsum dolor sit amet, consectetur ad", new Guid("6a64c827-ccff-4981-8b65-2f27b026bb6f") },
                    { new Guid("bd4824b3-dd2c-4ba9-963a-60f4ab97d7f4"), new DateTime(2024, 5, 2, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5697), 4, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed", new Guid("b10d1e75-18ca-45f6-9622-01ee975188bd") },
                    { new Guid("befabcb2-be6d-45cd-ab5d-04c0516a2f62"), new DateTime(2024, 4, 21, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5526), 5, new Guid("1815a109-0fd3-4726-bb3c-c659498982b2"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", new Guid("245b761a-0f08-42f4-b59a-1f3b87b8751b") },
                    { new Guid("c1df0789-3e46-4681-b008-0def1c619c57"), new DateTime(2024, 4, 17, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5490), 5, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 1, "Lorem ipsum dolor sit amet, cons", new Guid("3d4d9e15-513b-4787-aeff-0b9141a0f0b8") },
                    { new Guid("c23a4fb4-3ae2-4273-87ea-4a7c29fbb59a"), new DateTime(2024, 3, 15, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5589), 1, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidi", new Guid("543a669d-5305-4ff2-99fa-708f145f19dc") },
                    { new Guid("c2bfa8b0-1ebe-4929-ac59-1babac550502"), new DateTime(2024, 5, 10, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5603), 4, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing ", new Guid("0fc3b46b-2216-4f5a-905f-206c2cd09f7a") },
                    { new Guid("c65b46b8-a916-40c0-a9bb-a53370df0f78"), new DateTime(2024, 3, 29, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5689), 4, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", new Guid("0936d415-8f38-4b67-85a7-92e78a85feab") },
                    { new Guid("c89abfc7-ebd3-4916-9185-689f7f757468"), new DateTime(2024, 4, 30, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5540), 5, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit a", new Guid("fe1f480a-f916-425e-893e-3b59c6cde48b") },
                    { new Guid("cb09016d-e3f8-4477-a11e-130cf67abb75"), new DateTime(2024, 5, 26, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5637), 3, new Guid("a836a521-34a5-46c1-8186-1351e1baeee1"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit", new Guid("5b8564fd-083f-4ea0-8d0b-483e0d38a795") },
                    { new Guid("cd3e5130-b282-4058-bd6a-975e153c568d"), new DateTime(2024, 4, 19, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5556), 3, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusm", new Guid("ec28cb41-9cd6-443e-8536-499ad9352b53") },
                    { new Guid("d2318b1d-5c7a-424f-8640-581801142747"), new DateTime(2024, 3, 4, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5671), 4, new Guid("f1a2100e-3a8f-45b6-b397-f978fce8216d"), 2, "Lorem ipsum dolor sit amet, cons", new Guid("b2b96090-5817-4dff-8fd3-c6db6c0cd541") },
                    { new Guid("d251bd62-fb7f-4b2c-9ca4-3288819b113a"), new DateTime(2024, 3, 7, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5699), 1, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit,", new Guid("c0676977-80fd-40db-8e4e-a5aec983b96f") },
                    { new Guid("d36fae14-fa51-448c-8d6a-63946dab0938"), new DateTime(2024, 2, 29, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5563), 4, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 2, "Lorem ipsum dolor sit ame", new Guid("bbaa0c58-d851-46dd-b436-9883a01a5355") },
                    { new Guid("d560dbf6-1979-468f-a8a5-de0db0dc9e6a"), new DateTime(2024, 5, 14, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5553), 5, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labor", new Guid("39e60881-f13b-4152-8747-7115aac6cc87") },
                    { new Guid("d76253ea-2d1d-4229-93c2-5ced253cdde2"), new DateTime(2024, 5, 27, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5664), 4, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiu", new Guid("b14662f6-5a52-47b8-8146-bb77190ea5e0") },
                    { new Guid("dae679e3-c439-4dab-85da-f5ee5672c754"), new DateTime(2024, 2, 23, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5415), 4, new Guid("c456ab44-818f-42f7-be07-b3cb2d64da94"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", new Guid("533f6881-ca66-4431-bd9c-28a40c7bf539") },
                    { new Guid("dae79471-e686-48bc-bf2c-60d55555f976"), new DateTime(2024, 4, 16, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5599), 3, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit,", new Guid("df507280-7358-4692-bd15-d94193f5f403") },
                    { new Guid("de9c0f75-505b-4149-8ab3-257a7185917b"), new DateTime(2024, 4, 23, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5649), 5, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tem", new Guid("1e8eabf4-282a-494e-9868-53cc8682f4aa") },
                    { new Guid("df3f4bf1-febc-44b4-b1cc-6fc7c63f8b02"), new DateTime(2024, 3, 16, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5482), 2, new Guid("ed7b347e-04ae-49a5-a24c-7b88834acef4"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor inci", new Guid("05d4c1f5-aec8-4397-8572-8fd58fd40c55") },
                    { new Guid("e173a26c-2357-4a4f-a1ad-e33aa5b3aafe"), new DateTime(2024, 3, 31, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5517), 5, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing el", new Guid("207b3f62-d913-461f-914f-1c42b1bbb1f3") },
                    { new Guid("e34d4ef3-e987-41ab-b18e-fef562a9ae13"), new DateTime(2024, 5, 17, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5530), 1, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 2, "Lorem ipsum dolor sit amet, consectetur adipi", new Guid("82301f85-7a32-4d8b-a971-0128aa9233a2") },
                    { new Guid("e4b8ce17-21ca-41bc-bea5-4f98f5318ad3"), new DateTime(2024, 4, 15, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5429), 1, new Guid("35533d3a-6e12-440e-8d33-96b7330b89e7"), 2, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eius", new Guid("278425db-0512-4cb6-8c48-beefc59f76d2") },
                    { new Guid("e61577c4-173d-4681-b2d6-5add659b087d"), new DateTime(2024, 3, 27, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5647), 3, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing", new Guid("9936d0f7-6b17-445c-943a-137eac3ae31e") },
                    { new Guid("e9b1f847-8954-4759-a901-1a14b85309a1"), new DateTime(2024, 3, 1, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5442), 1, new Guid("0158b22b-8305-481c-a3f9-b2b22d8ec69d"), 2, "Lorem ipsum dolor sit amet, consectet", new Guid("2e41268c-d939-4c07-9a04-f40c28f13fd7") },
                    { new Guid("ecf54212-7efe-4763-a6ed-c64eeb7775aa"), new DateTime(2024, 4, 18, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5419), 3, new Guid("7aec802d-b2b9-4abb-b656-5569def4b9fb"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor in", new Guid("264c5813-111c-444a-a443-d92913fb3969") },
                    { new Guid("f029b8b9-26de-4070-b0c3-87f0245cc586"), new DateTime(2024, 5, 25, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5542), 1, new Guid("d23185fe-218f-4eb4-b2d5-45581ec8f0bf"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do ", new Guid("553e51d0-b9b9-4d76-95e1-cddecaf60fb1") },
                    { new Guid("f8fd6a14-f3b6-4af8-aee6-96a514e362bb"), new DateTime(2024, 4, 29, 18, 42, 35, 21, DateTimeKind.Local).AddTicks(5366), 3, new Guid("4f121860-0451-413f-86dd-5369ab56104b"), 1, "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod t", new Guid("136dadc5-6997-4df5-b9b4-c2e268ca9229") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}