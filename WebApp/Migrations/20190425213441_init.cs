using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    UID = table.Column<long>(nullable: false),
                    Group = table.Column<string>(nullable: true),
                    StudentCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ClassroomId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClassLabel = table.Column<string>(nullable: true),
                    ClassLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ClassroomId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<string>(nullable: false),
                    CourseName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.CreateTable(
                name: "NFCScans",
                columns: table => new
                {
                    ScanID = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UID = table.Column<long>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    DeviceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NFCScans", x => x.ScanID);
                });

            migrationBuilder.CreateTable(
                name: "Periods",
                columns: table => new
                {
                    PeriodId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PeriodStartTime = table.Column<TimeSpan>(nullable: false),
                    PeriodEndTime = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Periods", x => x.PeriodId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 127, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 127, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 127, nullable: false),
                    RoleId = table.Column<string>(maxLength: 127, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(maxLength: 127, nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 127, nullable: false),
                    Name = table.Column<string>(maxLength: 127, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DeviceIdReal = table.Column<int>(nullable: false),
                    ClassroomId = table.Column<int>(nullable: false, defaultValue: 9999)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                    table.ForeignKey(
                        name: "FK_Devices_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Timetables",
                columns: table => new
                {
                    TimetableId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CourseId = table.Column<string>(nullable: true),
                    PeriodId = table.Column<int>(nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    ClassroomId = table.Column<int>(nullable: false),
                    isVisited = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timetables", x => x.TimetableId);
                    table.ForeignKey(
                        name: "FK_Timetables_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Timetables_Periods_PeriodId",
                        column: x => x.PeriodId,
                        principalTable: "Periods",
                        principalColumn: "PeriodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Timetables_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "STUDENT", "5ce0e1c0-7966-4d7a-b41b-f94ebf3926e8", "STUDENT", "STUDENT" },
                    { "ADMIN", "7ab7706e-50dd-4d8a-8624-1d83be135a02", "ADMIN", "ADMIN" },
                    { "LECTURER", "b0f50de3-541d-49e6-bdac-45a800da7280", "LECTURER", "LECTURER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Group", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCode", "Surname", "TwoFactorEnabled", "UID", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd93440074", 0, "10cc7a1b-fbbc-42a2-b8a4-3443d883e427", "Vardas074.Pavarde074074@email.com", false, "IFF-4/8", false, null, "Vardas074", "VARDAS074.PAVARDE074074@EMAIL.COM", "VARPAV074", "AQAAAAEAACcQAAAAEPV9nTaU+067tGFbgaoRL88/ZQTdkyWPwSzZ9EbgRDOedCnKeSB3ln61jr9PuoGPJw==", null, false, "c235532c-6b08-4167-a276-12469116cc06", "C00074", "Pavarde074", false, 162799142L, "varpav074" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440073", 0, "fcd77cd2-3099-423f-8b58-1fd0f5d625c9", "Vardas073.Pavarde073073@email.com", false, "IFF-5/6", false, null, "Vardas073", "VARDAS073.PAVARDE073073@EMAIL.COM", "VARPAV073", "AQAAAAEAACcQAAAAEP9yWrGbG+thA1X/TwXLDsFdsbIg2rQYlZifWtCn6XMzBmmdhMnuhgbjy73m1J++tg==", null, false, "9107dc23-50f7-487f-82bd-ebd29347860b", "C00073", "Pavarde073", false, 178453773L, "varpav073" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440072", 0, "0f326693-d885-4c5a-a944-38407ecbc4eb", "Vardas072.Pavarde072072@email.com", false, "IFF-1/4", false, null, "Vardas072", "VARDAS072.PAVARDE072072@EMAIL.COM", "VARPAV072", "AQAAAAEAACcQAAAAEF+9gPTz0OKcMXzYnMk6QxsPpOXOft5V7qT7cCYHtT0QONFtfEvRe0KuS+kzf/xVLA==", null, false, "8d02473d-5e95-471b-a36a-15c93bc88e96", "C00072", "Pavarde072", false, 184579672L, "varpav072" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440071", 0, "37890f04-aa91-40af-941d-159b6cfb8e2e", "Vardas071.Pavarde071071@email.com", false, "IFF-4/7", false, null, "Vardas071", "VARDAS071.PAVARDE071071@EMAIL.COM", "VARPAV071", "AQAAAAEAACcQAAAAELIvtfpJDgCMmtCOx535bwbG36QUd25qOqTlWaTfIspqObjepFZk2RUMCSJ7UbP2IA==", null, false, "585e2118-fb57-4a81-84ea-c67f77383bc2", "C00071", "Pavarde071", false, 169678738L, "varpav071" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440070", 0, "bf4c14c6-c07f-4ec9-aeaa-8eda1a9d0c03", "Vardas070.Pavarde070070@email.com", false, "IFF-7/4", false, null, "Vardas070", "VARDAS070.PAVARDE070070@EMAIL.COM", "VARPAV070", "AQAAAAEAACcQAAAAEN2NNweOsKZDc4YTEb9MMgbXkGQAcFf45W8jpV5r7B92N785bB8kKwt5YoMFo6YMYQ==", null, false, "439c7753-bee2-4e88-baa0-4cbbfa2fa9f9", "C00070", "Pavarde070", false, 159618985L, "varpav070" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440069", 0, "860c50c4-e1cf-4449-8d54-5735fdd22db4", "Vardas069.Pavarde069069@email.com", false, "IFF-6/2", false, null, "Vardas069", "VARDAS069.PAVARDE069069@EMAIL.COM", "VARPAV069", "AQAAAAEAACcQAAAAEL/UZzBsHVRlqvo7Ugx6pHiB1baG/0Tk5Adrcdtx0HeT8DwfmraChJE9kwYT6HG3aQ==", null, false, "b8010e16-65b3-44dc-8f98-a57027f89dc5", "C00069", "Pavarde069", false, 138617632L, "varpav069" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440068", 0, "bd77d922-5ab7-493e-88b9-277d0d45e4af", "Vardas068.Pavarde068068@email.com", false, "IFF-1/2", false, null, "Vardas068", "VARDAS068.PAVARDE068068@EMAIL.COM", "VARPAV068", "AQAAAAEAACcQAAAAEGDNe3bddTMIIun+SHTFkUbdTtBZPAIm5tAm1BidmqmjQeb8H9yIknO1g05Ul1OaeQ==", null, false, "d055801f-7698-489d-a35c-8949f6f8bcb3", "C00068", "Pavarde068", false, 133031582L, "varpav068" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440067", 0, "0ecf91b4-0ade-48f3-b734-b86c8132053c", "Vardas067.Pavarde067067@email.com", false, "IFF-3/8", false, null, "Vardas067", "VARDAS067.PAVARDE067067@EMAIL.COM", "VARPAV067", "AQAAAAEAACcQAAAAEGbz5E2+sj06m3ZcjQbzDbE19Ko5a+3izdIoyhciVgxPLTIyS9+5Xxt93BcXRwJzGQ==", null, false, "175ce409-f85b-4d06-b2d7-fcc427443e22", "C00067", "Pavarde067", false, 132813453L, "varpav067" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440066", 0, "abe6132c-a7ba-46cc-b588-4510a87917f2", "Vardas066.Pavarde066066@email.com", false, "IFF-7/4", false, null, "Vardas066", "VARDAS066.PAVARDE066066@EMAIL.COM", "VARPAV066", "AQAAAAEAACcQAAAAEN1ebx6p5ogexCqNAm7fqUJdvrsKh9roVOtcVNcTT5+1vpRUHZxpvv5M1MLJYopD6g==", null, false, "3d64719f-167e-4630-b99b-0c3f60ca3094", "C00066", "Pavarde066", false, 164079630L, "varpav066" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440065", 0, "eb47d7b9-4ac0-4c55-bc1a-f07f6894ddbb", "Vardas065.Pavarde065065@email.com", false, "IFF-2/8", false, null, "Vardas065", "VARDAS065.PAVARDE065065@EMAIL.COM", "VARPAV065", "AQAAAAEAACcQAAAAEHJqj6bESuGrMX8YZ+JCTq19YSJ+rytuPudSYGBhfl9IFp1rBLMd4aAN/50h8rW9+A==", null, false, "021c05dd-97f1-45a8-8ff2-512ab7314117", "C00065", "Pavarde065", false, 109330230L, "varpav065" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440063", 0, "2ced1043-b337-4bad-80dd-c2045d22d068", "Vardas063.Pavarde063063@email.com", false, "IFF-3/7", false, null, "Vardas063", "VARDAS063.PAVARDE063063@EMAIL.COM", "VARPAV063", "AQAAAAEAACcQAAAAEHz4zFINp+kaCy2tuKQKlfGYPiOIPi5reQu8yvGgHS+jO4HmbKl2K/zMfuZo18xOIg==", null, false, "226bd6f8-ebe8-4ead-8834-9ebd825446b6", "C00063", "Pavarde063", false, 124022653L, "varpav063" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440075", 0, "f0825099-281a-4a79-85fa-ba0a5d721a4a", "Vardas075.Pavarde075075@email.com", false, "IFF-9/3", false, null, "Vardas075", "VARDAS075.PAVARDE075075@EMAIL.COM", "VARPAV075", "AQAAAAEAACcQAAAAEC7Xop6sqQ307/emKWIo++BOnXSuz+7F8e2ZgZ6xA3qrdIIw2CYaC9+9meLqHSmhLw==", null, false, "ca7e374b-100d-4ce2-8b23-c21f952cd650", "C00075", "Pavarde075", false, 155846782L, "varpav075" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440062", 0, "5f115557-eea0-4513-a5c0-08957f796054", "Vardas062.Pavarde062062@email.com", false, "IFF-2/9", false, null, "Vardas062", "VARDAS062.PAVARDE062062@EMAIL.COM", "VARPAV062", "AQAAAAEAACcQAAAAEBq50tcTgQIdHRkMZYtWn0V4xAxvnl59u0DZGQDP7O46Lj3IfpmP7Wdg5m4OWHgArg==", null, false, "690ee735-923d-4b01-a08e-8a934c03a1d7", "C00062", "Pavarde062", false, 188195770L, "varpav062" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440060", 0, "790f881c-4a6d-42bb-8985-4ff41913cc2f", "Vardas060.Pavarde060060@email.com", false, "IFF-4/9", false, null, "Vardas060", "VARDAS060.PAVARDE060060@EMAIL.COM", "VARPAV060", "AQAAAAEAACcQAAAAEKM6rW/XGWmc0AV6BTO3on7IR2XAHlFt3qr+YTJfUxX+SgLyebDwpqwK7cy2ISHDRQ==", null, false, "c93b5b27-a4cc-4ce8-a8d2-cf4596758c1a", "C00060", "Pavarde060", false, 149402631L, "varpav060" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440059", 0, "7c46028e-d510-42c8-b487-58f7c0a092fe", "Vardas059.Pavarde059059@email.com", false, "IFF-9/9", false, null, "Vardas059", "VARDAS059.PAVARDE059059@EMAIL.COM", "VARPAV059", "AQAAAAEAACcQAAAAEFC1kkGenLypBdeWtfeGy5n5hFCzP/vNDRqAW4QEE/T55lH41pIvPe1hGb3AgwoqIQ==", null, false, "3529131c-01bd-40e8-b8e1-8e71f30f2ff1", "C00059", "Pavarde059", false, 119437647L, "varpav059" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440058", 0, "24438145-1fcd-4f93-bc65-3984cb0ccb3c", "Vardas058.Pavarde058058@email.com", false, "IFF-7/4", false, null, "Vardas058", "VARDAS058.PAVARDE058058@EMAIL.COM", "VARPAV058", "AQAAAAEAACcQAAAAEAVPewwqk19LpVu7YXa3uhw7iVnEu3XzGemXdeD/kKu3LLwFFKdUj1xpye0ZOvPBGg==", null, false, "7536deef-0c96-49b8-80d4-68780ef68085", "C00058", "Pavarde058", false, 182473653L, "varpav058" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440057", 0, "1d65774b-dc05-486f-984e-07c39ba8f6e0", "Vardas057.Pavarde057057@email.com", false, "IFF-1/1", false, null, "Vardas057", "VARDAS057.PAVARDE057057@EMAIL.COM", "VARPAV057", "AQAAAAEAACcQAAAAEAmMy2MCgrd74i56yPRwbvmezAzUrF9VeR8C8TQUfepTcQId0hf6/pnTk5CP2JdepQ==", null, false, "a06a2318-6b84-4110-882d-4e3a65a7cb4d", "C00057", "Pavarde057", false, 192167109L, "varpav057" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440056", 0, "f0cbe398-2639-42cf-9e51-a14c32eada70", "Vardas056.Pavarde056056@email.com", false, "IFF-2/3", false, null, "Vardas056", "VARDAS056.PAVARDE056056@EMAIL.COM", "VARPAV056", "AQAAAAEAACcQAAAAEK/ozRTwg46EzMjZBmekX5/LklYB/ZeV+wzrZxP34zkj6/0kDElKMbN4Mn6IJNXnwg==", null, false, "4da5bc04-c3d4-4d8e-b303-7783481ef692", "C00056", "Pavarde056", false, 166702283L, "varpav056" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440055", 0, "fe83e357-8e7e-443d-86f4-aff15e474e3f", "Vardas055.Pavarde055055@email.com", false, "IFF-8/6", false, null, "Vardas055", "VARDAS055.PAVARDE055055@EMAIL.COM", "VARPAV055", "AQAAAAEAACcQAAAAEGVQm7McIgWCAib8wcAtme07mnaSfon5m+J40Gfo1ln5BsmxUiILtSho5azyZL8kWg==", null, false, "377f51a6-a050-4826-9156-49754c1919f9", "C00055", "Pavarde055", false, 132976806L, "varpav055" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440054", 0, "fa85b9d2-b9d8-42fa-9cfe-ca71025f66b5", "Vardas054.Pavarde054054@email.com", false, "IFF-6/1", false, null, "Vardas054", "VARDAS054.PAVARDE054054@EMAIL.COM", "VARPAV054", "AQAAAAEAACcQAAAAEKVqwW66QWFyLdlHhiOezFF9HeQnXGYjlI0lUP8LdH0UN1FbMIFrt9b/8ByYtmwzYg==", null, false, "0b1db88d-89aa-4b8a-9d57-de5f01acdc42", "C00054", "Pavarde054", false, 142294586L, "varpav054" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440053", 0, "834f9166-89c3-4935-8875-c1083145311f", "Vardas053.Pavarde053053@email.com", false, "IFF-2/7", false, null, "Vardas053", "VARDAS053.PAVARDE053053@EMAIL.COM", "VARPAV053", "AQAAAAEAACcQAAAAEE7aSc1go+cu9DxWUL3ccAdDcp33a9ySuPTuovahmdQwcNz823udCEg0cXt5iQHPUQ==", null, false, "b0fd6a33-8513-426b-9327-9af4ecaf259e", "C00053", "Pavarde053", false, 189299679L, "varpav053" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440064", 0, "b33faa03-e417-455a-8c1c-2b6355628bab", "Vardas064.Pavarde064064@email.com", false, "IFF-8/7", false, null, "Vardas064", "VARDAS064.PAVARDE064064@EMAIL.COM", "VARPAV064", "AQAAAAEAACcQAAAAEBb4b/IbXJD9MIN4Y4NfI38VhL/N6FIYGccWHi7L5QsIdM4RnJfco1tb3d6PiHMQPw==", null, false, "06923bab-ac1f-490d-be1b-0aaeb1b3b6dd", "C00064", "Pavarde064", false, 100890762L, "varpav064" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440076", 0, "72e76bca-4b01-4bb2-9ecd-37dc02a9160c", "Vardas076.Pavarde076076@email.com", false, "IFF-7/6", false, null, "Vardas076", "VARDAS076.PAVARDE076076@EMAIL.COM", "VARPAV076", "AQAAAAEAACcQAAAAEKRNm+ina2KYWVTLhP9EYzj2aSe6GYUcvVxM9KmMm5WHuvfrwH51U2BKI77OPgLqLQ==", null, false, "3abf1c9e-b5bc-40cb-b78d-789ecc5d5559", "C00076", "Pavarde076", false, 136118996L, "varpav076" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440078", 0, "3a38d0a6-84e1-419a-9118-eec7fabe08a7", "Vardas078.Pavarde078078@email.com", false, "IFF-2/2", false, null, "Vardas078", "VARDAS078.PAVARDE078078@EMAIL.COM", "VARPAV078", "AQAAAAEAACcQAAAAEJbbxH8S9htPec94VkW5pvOaR+B3gHOl/X59z/bRp62nDLyXtWt63+UnUUyHrJM0Gw==", null, false, "7ee5cf4a-9898-4865-8a66-34644e237d5d", "C00078", "Pavarde078", false, 153890652L, "varpav078" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440052", 0, "56d85c8f-4600-4818-8aa2-8bff35f53f92", "Vardas052.Pavarde052052@email.com", false, "IFF-3/6", false, null, "Vardas052", "VARDAS052.PAVARDE052052@EMAIL.COM", "VARPAV052", "AQAAAAEAACcQAAAAEKcFXzGZunmb5BoVx80cnCOo9pkyO27mkKUQAeW4czWEWsQZ8L1pt4Y9iuLCMc0x+g==", null, false, "7be96d0c-054e-47c7-8374-13799a630261", "C00052", "Pavarde052", false, 193495428L, "varpav052" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440100", 0, "2fdec1fd-deac-4279-a53f-bf15afe1fe18", "Vardas100.Pavarde100100@email.com", false, "IFF-2/2", false, null, "Vardas100", "VARDAS100.PAVARDE100100@EMAIL.COM", "VARPAV100", "AQAAAAEAACcQAAAAEDf8uQsQh6J6fCK/f634/kqq/OfXcsyShA8QBJGcXSxe8X76oP48ur/MG97JMHGHKA==", null, false, "ef7ec324-ff75-4c70-a805-baaf0497e5b5", "C00100", "Pavarde100", false, 140103532L, "varpav100" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440099", 0, "20521db3-75ec-44e2-ade6-b85e2bf03936", "Vardas099.Pavarde099099@email.com", false, "IFF-2/6", false, null, "Vardas099", "VARDAS099.PAVARDE099099@EMAIL.COM", "VARPAV099", "AQAAAAEAACcQAAAAEGcrshnFc7hezGy22ca/Y0k7TMXg4MO2WmECigADjG1n9z5pp8Zi4Ca5P/JvqIFoiA==", null, false, "f0eff186-c9f1-4535-b58a-e0360d812c1b", "C00099", "Pavarde099", false, 167345242L, "varpav099" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440098", 0, "3c39585e-12ac-4054-b803-9e96ddc33c1c", "Vardas098.Pavarde098098@email.com", false, "IFF-1/5", false, null, "Vardas098", "VARDAS098.PAVARDE098098@EMAIL.COM", "VARPAV098", "AQAAAAEAACcQAAAAEKvEad1omMIARA6GslDPGhdTfSYtEv+siEOipiUShJKijVsazx/KGgf5hWYceGMSUg==", null, false, "89c1c4b1-027c-4ee2-b5c3-dbc2a9f373e4", "C00098", "Pavarde098", false, 105596481L, "varpav098" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440097", 0, "34517579-b007-4c61-9ae1-334bb5edbdc7", "Vardas097.Pavarde097097@email.com", false, "IFF-2/3", false, null, "Vardas097", "VARDAS097.PAVARDE097097@EMAIL.COM", "VARPAV097", "AQAAAAEAACcQAAAAEAGttcSn/LXU3NnUV995fj92w8CL7IluV8YbsTj6Zt0IVM8+90+3Rxw+CyUt8dl1+Q==", null, false, "576dd8ae-ba8e-41d0-afbc-f3e8a9b31615", "C00097", "Pavarde097", false, 137326205L, "varpav097" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440096", 0, "ae82ac81-aa3d-4bc0-be1a-a3c4f22f2c26", "Vardas096.Pavarde096096@email.com", false, "IFF-8/5", false, null, "Vardas096", "VARDAS096.PAVARDE096096@EMAIL.COM", "VARPAV096", "AQAAAAEAACcQAAAAEDoquIrEkwLfKgPFMOSgp8HxT9DkbKYoBQGGlZM3O1qlC+fkKkkQ7x3NmYCKa0/DZQ==", null, false, "a1d5fb1e-9c90-4464-ae9b-285eef5410f1", "C00096", "Pavarde096", false, 192939174L, "varpav096" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440095", 0, "d16f247b-dc93-472e-9f35-f80cd59b905b", "Vardas095.Pavarde095095@email.com", false, "IFF-3/7", false, null, "Vardas095", "VARDAS095.PAVARDE095095@EMAIL.COM", "VARPAV095", "AQAAAAEAACcQAAAAEJMuY8v7wxFQMy9vEmKpSW3GHCQIVXoUYG5d4+Cqic4aD33ZaTGAhKtlnH9ERcUQDA==", null, false, "24716874-01b3-4169-a22f-d3ab04c1a0c3", "C00095", "Pavarde095", false, 149617583L, "varpav095" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440094", 0, "32c7831e-9f71-4c0b-b328-d82ceda68c81", "Vardas094.Pavarde094094@email.com", false, "IFF-3/5", false, null, "Vardas094", "VARDAS094.PAVARDE094094@EMAIL.COM", "VARPAV094", "AQAAAAEAACcQAAAAEEiHIs+epkazbnlZaIlL/l93zlGY0/5DDitCncy/I645JfRbzNsRZZP051At4P5LWw==", null, false, "7a46f3f1-c37f-4785-9423-35be56169df2", "C00094", "Pavarde094", false, 177689040L, "varpav094" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440093", 0, "661b271e-4c3b-473e-96b5-7d1844539e58", "Vardas093.Pavarde093093@email.com", false, "IFF-2/6", false, null, "Vardas093", "VARDAS093.PAVARDE093093@EMAIL.COM", "VARPAV093", "AQAAAAEAACcQAAAAEAWgXMHq+410Z7SSQQlQUOOBx6XRm9oL29L80pVieAdXuBgdxAmMNyrKKkbQWBsc5A==", null, false, "2536f80d-63bb-4137-b61c-a1fa4ab66ba3", "C00093", "Pavarde093", false, 125478950L, "varpav093" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440092", 0, "2212fc9c-dea6-47f9-b0b9-5518fde95b5b", "Vardas092.Pavarde092092@email.com", false, "IFF-8/8", false, null, "Vardas092", "VARDAS092.PAVARDE092092@EMAIL.COM", "VARPAV092", "AQAAAAEAACcQAAAAEDAS2mkR6ITflavSh2ao/phDT2T9OmG/NS4WxV2WZjmw6Gq4Pepn/IaFpwwR3bg84w==", null, false, "59ca0649-3f5d-4f1a-bbb4-efdf95dabbe9", "C00092", "Pavarde092", false, 109490525L, "varpav092" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440091", 0, "1d77be7a-8b96-4aeb-8e86-f03cfe033f54", "Vardas091.Pavarde091091@email.com", false, "IFF-7/9", false, null, "Vardas091", "VARDAS091.PAVARDE091091@EMAIL.COM", "VARPAV091", "AQAAAAEAACcQAAAAEE81FypUzVz0/44bIAjb32Cvo9GCRg97OIc7LUUpGKWP2zfJkGLYn1k/fkcCqw3sfQ==", null, false, "22340a63-14ab-4800-8462-3fe76accda4e", "C00091", "Pavarde091", false, 127101734L, "varpav091" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440077", 0, "e838d755-d530-4855-a3c5-3b1dd6370297", "Vardas077.Pavarde077077@email.com", false, "IFF-5/2", false, null, "Vardas077", "VARDAS077.PAVARDE077077@EMAIL.COM", "VARPAV077", "AQAAAAEAACcQAAAAEDuJBLIcJxNELfoSXLU7FmMuFeHCTcd2YbVxi+pZKa/JHgtldIE03p1B4u4I23I/xQ==", null, false, "2d607724-cb83-4b26-8988-7837be09c331", "C00077", "Pavarde077", false, 161501067L, "varpav077" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440090", 0, "3544a2be-7090-4305-8712-c595c43b2ef6", "Vardas090.Pavarde090090@email.com", false, "IFF-7/9", false, null, "Vardas090", "VARDAS090.PAVARDE090090@EMAIL.COM", "VARPAV090", "AQAAAAEAACcQAAAAECxcB2gIceD3B/v6Zpzpuo4L49+7s//LifybGK3pxgbkvJTnTeBrzA+y/eAc/+gWLQ==", null, false, "28a8b376-49d7-4514-89cf-71582d1fa13d", "C00090", "Pavarde090", false, 148456786L, "varpav090" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440088", 0, "a97c0879-9f8d-4f73-bfb1-7d09d0d558a8", "Vardas088.Pavarde088088@email.com", false, "IFF-9/2", false, null, "Vardas088", "VARDAS088.PAVARDE088088@EMAIL.COM", "VARPAV088", "AQAAAAEAACcQAAAAEPeJBGMwUfOLFXMzagnXbaFwmp1yh9koH0nv4zHU3RukMcWifXs1tSgq9CynpOi0VQ==", null, false, "a8abaf4b-bf28-433d-a220-27d7d3978c2d", "C00088", "Pavarde088", false, 160794045L, "varpav088" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440087", 0, "629d0e49-d559-4e17-88d1-24db8162c2ea", "Vardas087.Pavarde087087@email.com", false, "IFF-1/8", false, null, "Vardas087", "VARDAS087.PAVARDE087087@EMAIL.COM", "VARPAV087", "AQAAAAEAACcQAAAAEAqvFHy2OnstmV7jLsLhE1XAuSnCwSe0xVY0biEmeX9zX+qF/gnxY0IopN0AHzkRcg==", null, false, "7dfe0665-264f-4bb2-bcbc-8d17fc2e231d", "C00087", "Pavarde087", false, 198157789L, "varpav087" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440086", 0, "f6b6fa6e-b55e-4818-8350-b497f2c57295", "Vardas086.Pavarde086086@email.com", false, "IFF-7/1", false, null, "Vardas086", "VARDAS086.PAVARDE086086@EMAIL.COM", "VARPAV086", "AQAAAAEAACcQAAAAECVIxlJ+ZH0j1jcD7O++Yzo0G0Pq2m8UO1sgCJDLOetqkrUnUOn9MIrhPANiOL8zbg==", null, false, "bdab52d4-5c4b-46bc-97ec-6339ecb3855a", "C00086", "Pavarde086", false, 196303868L, "varpav086" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440085", 0, "d94625be-0911-4d2c-bde2-c923ce022436", "Vardas085.Pavarde085085@email.com", false, "IFF-7/8", false, null, "Vardas085", "VARDAS085.PAVARDE085085@EMAIL.COM", "VARPAV085", "AQAAAAEAACcQAAAAEFHXcIL9VW7oqKn6u87APYALhoLzkDe6myoclc3nflkqRZRldOdg66OZvig6fVXoKg==", null, false, "419788ed-40b2-4cf4-85f1-0b2ae14ad2a4", "C00085", "Pavarde085", false, 175096473L, "varpav085" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440084", 0, "87b3a9f3-a035-4bc8-8570-a69a377eefdd", "Vardas084.Pavarde084084@email.com", false, "IFF-8/3", false, null, "Vardas084", "VARDAS084.PAVARDE084084@EMAIL.COM", "VARPAV084", "AQAAAAEAACcQAAAAEPl/qCL5wuRkx25tuN+X0nzhF96SqqImqJN/CRC6d6bOaMIEnq6gobXwyYnIkIIA+g==", null, false, "081b8bb1-0ee1-4f68-b7ad-9c1830b38d41", "C00084", "Pavarde084", false, 134786782L, "varpav084" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440083", 0, "8c211109-d2f7-4ce4-bbff-9321e546789e", "Vardas083.Pavarde083083@email.com", false, "IFF-3/2", false, null, "Vardas083", "VARDAS083.PAVARDE083083@EMAIL.COM", "VARPAV083", "AQAAAAEAACcQAAAAEFa1rjAOnjHhD/QVWKTHEH/H4+asTI/uwbSUNA6U8XmtJU2/UzNOvau9FT3We87vng==", null, false, "4a59c406-4d89-4d43-a9aa-ce6dd7aca172", "C00083", "Pavarde083", false, 106993590L, "varpav083" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440082", 0, "56a8ba54-83f1-4442-8e12-513ded30c715", "Vardas082.Pavarde082082@email.com", false, "IFF-3/5", false, null, "Vardas082", "VARDAS082.PAVARDE082082@EMAIL.COM", "VARPAV082", "AQAAAAEAACcQAAAAEAJiBuN4feoTrx5jFRv1JDE1+dRN8avUBo4frgg/Ml+L+rALsQqMkV/bZ1DWnglHPg==", null, false, "151006e1-f4ba-41b0-9bf5-dee2ff5937e9", "C00082", "Pavarde082", false, 136361536L, "varpav082" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440081", 0, "d5f8ab28-223d-4f7d-bba2-0ae19323b517", "Vardas081.Pavarde081081@email.com", false, "IFF-6/6", false, null, "Vardas081", "VARDAS081.PAVARDE081081@EMAIL.COM", "VARPAV081", "AQAAAAEAACcQAAAAEC8XyfU7WzCGemZVqEWmPcc4/ftDfTw9p+lU1yZHXPQLCAnhbMBG1rRvVnEQw6X8/Q==", null, false, "e1668417-a861-41e2-ba8b-1337f83a3e5d", "C00081", "Pavarde081", false, 177010066L, "varpav081" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440080", 0, "bf24fcb1-9d29-4614-a9ab-be2e38bd3788", "Vardas080.Pavarde080080@email.com", false, "IFF-5/6", false, null, "Vardas080", "VARDAS080.PAVARDE080080@EMAIL.COM", "VARPAV080", "AQAAAAEAACcQAAAAENppZE35mgojlonhFULahGx74dZxDjJKX3PF/S8pq/XREcYKtnVux3GgDfTf2fj/Pw==", null, false, "b71dc20b-d34a-4564-8dfa-78282960bb42", "C00080", "Pavarde080", false, 105888365L, "varpav080" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440079", 0, "d7c7780e-650b-4ffa-bf0f-0f122cf72508", "Vardas079.Pavarde079079@email.com", false, "IFF-1/2", false, null, "Vardas079", "VARDAS079.PAVARDE079079@EMAIL.COM", "VARPAV079", "AQAAAAEAACcQAAAAEAzHzrmfatM2M3YGPFVfJ0sUCys+IWdzCzacjGjH+rPy4OR+1yp+uNWWbokkOQKdqg==", null, false, "44cb425b-70e4-4a5d-a3b3-9c015decfdea", "C00079", "Pavarde079", false, 109947516L, "varpav079" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440089", 0, "44a3d4af-3b7b-4708-b350-a26d9154bd76", "Vardas089.Pavarde089089@email.com", false, "IFF-2/3", false, null, "Vardas089", "VARDAS089.PAVARDE089089@EMAIL.COM", "VARPAV089", "AQAAAAEAACcQAAAAEF1l1zGLkfSpOxpBSy/iK1OcklC+1SW3PyWHGQVFOgbKWV537ctq2VW/XFQHkKwayg==", null, false, "b22dc94f-ef6c-46fc-83c6-deae170090f0", "C00089", "Pavarde089", false, 116857406L, "varpav089" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440051", 0, "e906a0eb-0e77-43a6-9494-a0a85cbbae2a", "Vardas051.Pavarde051051@email.com", false, "IFF-9/9", false, null, "Vardas051", "VARDAS051.PAVARDE051051@EMAIL.COM", "VARPAV051", "AQAAAAEAACcQAAAAEHSFRiQ6Taq0P9k2qh7ON5QmfItVecoqmPPtyLYjap9xrR4rhWhIrqrVYHJjkX4uTg==", null, false, "bf7ab69f-12f5-4811-8b81-08310e199771", "C00051", "Pavarde051", false, 144215756L, "varpav051" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440061", 0, "07e5f8ab-1aba-40eb-8bc2-28a330cd212c", "Vardas061.Pavarde061061@email.com", false, "IFF-2/3", false, null, "Vardas061", "VARDAS061.PAVARDE061061@EMAIL.COM", "VARPAV061", "AQAAAAEAACcQAAAAELBV1TypISWpZns4/DkVBXjsROca5BntxpPv+lo1pGL+UjLswC0tsX1gZe/hKYJe4w==", null, false, "295a0a9c-d3ee-4ea6-806f-adf355f0cd17", "C00061", "Pavarde061", false, 141303750L, "varpav061" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440049", 0, "455e64d7-e9d1-48b7-a794-2f89fa062418", "Vardas049.Pavarde049049@email.com", false, "IFF-9/6", false, null, "Vardas049", "VARDAS049.PAVARDE049049@EMAIL.COM", "VARPAV049", "AQAAAAEAACcQAAAAEDWwij9bVhjiKkq7Dv+3wvAi720v/k4K2DJyqKAX8x512Iiq+P4MvDi/FcebY4/lcA==", null, false, "a0d3a54a-affa-4f46-a689-e73d72053f42", "C00049", "Pavarde049", false, 191450887L, "varpav049" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440022", 0, "8c8a45f4-815f-4530-9e8e-7ed4550feb60", "Vardas022.Pavarde022022@email.com", false, "IFF-2/6", false, null, "Vardas022", "VARDAS022.PAVARDE022022@EMAIL.COM", "VARPAV022", "AQAAAAEAACcQAAAAEF8AMkc2BJ0W4FiTzL+G5CPJUiBIvB8UsenBwUP15v/8mOMOy5Pp5vyKMiMeETo5aw==", null, false, "2cb1dea6-4890-45fe-b3b1-8ac9937521ac", "C00022", "Pavarde022", false, 199324310L, "varpav022" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440021", 0, "30d0919e-8ee2-4594-a754-c8b7d72b993f", "Vardas021.Pavarde021021@email.com", false, "IFF-2/3", false, null, "Vardas021", "VARDAS021.PAVARDE021021@EMAIL.COM", "VARPAV021", "AQAAAAEAACcQAAAAEESOykU4jfjMFrm8h2sQ9rq3wZ77PO0X5uATx4YnIZNfMlFJzFyYlnnsbJcAdaQPTw==", null, false, "dd762ad0-0c87-4282-8feb-cc7984ffb470", "C00021", "Pavarde021", false, 132237601L, "varpav021" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440020", 0, "a489e391-4dce-4454-8e72-3ea9d8b35f11", "Vardas020.Pavarde020020@email.com", false, "IFF-1/9", false, null, "Vardas020", "VARDAS020.PAVARDE020020@EMAIL.COM", "VARPAV020", "AQAAAAEAACcQAAAAEP9H8uFQ+iMqyTdlCRxmo65tM9kx+ahPo8VDO/2PwJY4F1O2dRAbUrAwF0VP85PUcQ==", null, false, "aafbb6a1-0c0c-4821-b576-4f501cc974d5", "C00020", "Pavarde020", false, 136927559L, "varpav020" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440019", 0, "b3dfd663-76ef-44a3-a345-fad82f326bf2", "Vardas019.Pavarde019019@email.com", false, "IFF-9/5", false, null, "Vardas019", "VARDAS019.PAVARDE019019@EMAIL.COM", "VARPAV019", "AQAAAAEAACcQAAAAEPB64strmelXBP2WP9tgDPcBVSEMejhG4xXFVreuQxnxFfQYpJcp8LefbxGp+GMm2Q==", null, false, "d334ef93-5141-4529-893d-116a14ee54b2", "C00019", "Pavarde019", false, 171477695L, "varpav019" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440018", 0, "b57a0ffd-7159-4588-adfc-dfb55501e95e", "Vardas018.Pavarde018018@email.com", false, "IFF-6/2", false, null, "Vardas018", "VARDAS018.PAVARDE018018@EMAIL.COM", "VARPAV018", "AQAAAAEAACcQAAAAELQZVbE4qu8pZdr2xaguewx5wV9JSQ9r8q0KHM3noFiPwWnSLEUaUcuK75VkPYjj5Q==", null, false, "b5d3728d-e7df-4364-83a7-9b09554bacd2", "C00018", "Pavarde018", false, 129720128L, "varpav018" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440017", 0, "d4d9f327-625b-4a26-a06c-cbed551d850a", "Vardas017.Pavarde017017@email.com", false, "IFF-3/4", false, null, "Vardas017", "VARDAS017.PAVARDE017017@EMAIL.COM", "VARPAV017", "AQAAAAEAACcQAAAAEBAljEUwUmmeO/lGsRPLFKLCYYRyVVftLx+ydLkoQIFIb1QVXTVB3XTey12hwnoenQ==", null, false, "8c177dec-8d97-4219-9d0c-25689ed55212", "C00017", "Pavarde017", false, 192868781L, "varpav017" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440016", 0, "0b42dc35-a6bd-4acd-b666-a8f302d90fb3", "Vardas016.Pavarde016016@email.com", false, "IFF-3/6", false, null, "Vardas016", "VARDAS016.PAVARDE016016@EMAIL.COM", "VARPAV016", "AQAAAAEAACcQAAAAEOrJUcFpanAGOkuhc36e6IcxPb3YQjAIDLoQdi62q1Snq+YZeKxMn2HsaWPiAYpwIg==", null, false, "b33bfe30-36f8-4f55-a03d-9a2f804724a7", "C00016", "Pavarde016", false, 168919844L, "varpav016" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440015", 0, "83d3085f-35ae-4bc8-a5f0-0113591aef85", "Vardas015.Pavarde015015@email.com", false, "IFF-1/8", false, null, "Vardas015", "VARDAS015.PAVARDE015015@EMAIL.COM", "VARPAV015", "AQAAAAEAACcQAAAAEJv3dGMzjUGVGLd+XxMPXs6uxqlAy026rdQUS/7YbPhgSqVcxpPa/qhvcWPQJDud9Q==", null, false, "3197fced-d15e-4112-b315-209426089cbe", "C00015", "Pavarde015", false, 180507000L, "varpav015" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440014", 0, "d963b6c9-7c98-4f8a-b93d-ceffbd38909f", "Vardas014.Pavarde014014@email.com", false, "IFF-3/5", false, null, "Vardas014", "VARDAS014.PAVARDE014014@EMAIL.COM", "VARPAV014", "AQAAAAEAACcQAAAAEGnRviyRQ66qMrzk1AaJ50VgFOMme6J4J5OGc8beUKohn2fRhGE18ewOXZ0aXOdBRA==", null, false, "dfdd51ff-6df0-4f47-bfdb-eb69a96e5437", "C00014", "Pavarde014", false, 179625650L, "varpav014" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440050", 0, "bdc32d50-f131-4468-852b-152acd796da7", "Vardas050.Pavarde050050@email.com", false, "IFF-3/5", false, null, "Vardas050", "VARDAS050.PAVARDE050050@EMAIL.COM", "VARPAV050", "AQAAAAEAACcQAAAAEBey6ZhZsgsWH/g7fgw4A3BufBSXzifiZiY9xUS9kGuUvJ+iPYNtieoU12pH7nFlcw==", null, false, "241f2ecd-a8f4-420b-87a9-934aeef54325", "C00050", "Pavarde050", false, 194532713L, "varpav050" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440023", 0, "b59bc968-0218-4760-8987-e521ea425ddf", "Vardas023.Pavarde023023@email.com", false, "IFF-9/2", false, null, "Vardas023", "VARDAS023.PAVARDE023023@EMAIL.COM", "VARPAV023", "AQAAAAEAACcQAAAAEFxOTd7vwStzhohX952ZGv/p7+6ZF544covQJDVhsPUq7VLD9BvD/4JHYywQpcoigQ==", null, false, "848cb768-1ef2-4fff-a210-c91339edf8b7", "C00023", "Pavarde023", false, 186746580L, "varpav023" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440012", 0, "ab0c16c2-b26b-4d18-960e-a42d083189d3", "Vardas012.Pavarde012012@email.com", false, "IFF-7/9", false, null, "Vardas012", "VARDAS012.PAVARDE012012@EMAIL.COM", "VARPAV012", "AQAAAAEAACcQAAAAEBgVIgPRAI5OC2fT3ax3Eg96Q8NOKSXPObPBrwTPBqtxv3fbyTyVVh5EC1MhDpRrEQ==", null, false, "d1d1b968-a685-424e-be20-8547a0e3b949", "C00012", "Pavarde012", false, 120958363L, "varpav012" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440010", 0, "2563bad0-335c-44bf-9f09-e4ec297388bc", "Vardas010.Pavarde010010@email.com", false, "IFF-3/6", false, null, "Vardas010", "VARDAS010.PAVARDE010010@EMAIL.COM", "VARPAV010", "AQAAAAEAACcQAAAAEBQqvsXkhyCNXFVJzxDo5GxUwxApDCUxsnkW/U5//u4Pl2gnnIwyBLfOYXDXCYjPnQ==", null, false, "06660bde-3604-4b09-aa08-a49e61bc138f", "C00010", "Pavarde010", false, 140688718L, "varpav010" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440009", 0, "89610499-850f-45de-be65-9fad9550cd83", "Vardas009.Pavarde009009@email.com", false, "IFF-4/9", false, null, "Vardas009", "VARDAS009.PAVARDE009009@EMAIL.COM", "VARPAV009", "AQAAAAEAACcQAAAAEKDGsBM/KkuuVZnJttdgZjWyBdsoLba07UbnsZivqiYqq+5ixOPCjN5ffjQr5EwI8w==", null, false, "d4d1244b-6790-4827-9931-9004ad922387", "C00009", "Pavarde009", false, 116084181L, "varpav009" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440008", 0, "52ef0135-05b8-41c0-a532-1e63766a40a9", "Vardas008.Pavarde008008@email.com", false, "IFF-2/9", false, null, "Vardas008", "VARDAS008.PAVARDE008008@EMAIL.COM", "VARPAV008", "AQAAAAEAACcQAAAAEMsM2NZL+a/xO08xQxkck2r9Gjs2UCMJdwyxVFTNVb16HyBmN72Ayp69uNWKR2PTww==", null, false, "a72714e1-59c6-4f51-8f5f-3f850d4092cc", "C00008", "Pavarde008", false, 185406648L, "varpav008" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440007", 0, "29fb8a94-5fbd-4e1d-89d2-201e12d45bd2", "Vardas007.Pavarde007007@email.com", false, "IFF-9/6", false, null, "Vardas007", "VARDAS007.PAVARDE007007@EMAIL.COM", "VARPAV007", "AQAAAAEAACcQAAAAEMeZS3aAo+nzVdiJ8c32fz8SkdxC+L3ZvpFj1W9C173L5OsGsRWaAxbTTUp88CnEag==", null, false, "6fc54679-1969-42eb-bd2c-a9f9dd05bf24", "C00007", "Pavarde007", false, 164791657L, "varpav007" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440006", 0, "dfa49293-29c6-40f3-bae2-2333182b33f5", "Vardas006.Pavarde006006@email.com", false, "IFF-2/7", false, null, "Vardas006", "VARDAS006.PAVARDE006006@EMAIL.COM", "VARPAV006", "AQAAAAEAACcQAAAAECC5S73ja2pdmTxxJT74xin/dl80rQMYF6B2XzOuI6P/JozgWiYDNQ4jL15ICQwH+Q==", null, false, "0ee6d271-826c-46ca-8fa8-7e21d9d401b4", "C00006", "Pavarde006", false, 108001308L, "varpav006" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440005", 0, "824d35a5-c9b8-4b1f-9fd4-8f6fa2990f02", "Vardas005.Pavarde005005@email.com", false, "IFF-9/3", false, null, "Vardas005", "VARDAS005.PAVARDE005005@EMAIL.COM", "VARPAV005", "AQAAAAEAACcQAAAAEEUlSdFnnMKBg4VVWOlizkazWd1VxFL39v5tGkddykk5toMY/mfU/cxWEU0QvOkrxQ==", null, false, "ea43296c-5f91-456f-a73a-4834f6723fa6", "C00005", "Pavarde005", false, 114173252L, "varpav005" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440004", 0, "a48c36cc-ac50-468f-aa64-97e4b82b4ade", "Vardas004.Pavarde004004@email.com", false, "IFF-9/7", false, null, "Vardas004", "VARDAS004.PAVARDE004004@EMAIL.COM", "VARPAV004", "AQAAAAEAACcQAAAAEJr0TC82hjTma3JpgkEUIOhnVxYgn47uqHDebpfFX46wKSh6TvR0LlgXayZuz2ZPGA==", null, false, "8f6ec2b2-dcfb-4278-acc5-c2bd1982e70b", "C00004", "Pavarde004", false, 181126377L, "varpav004" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440003", 0, "3efec7b9-713c-440d-b2c2-f3f9d98efffa", "Vardas003.Pavarde003003@email.com", false, "IFF-6/6", false, null, "Vardas003", "VARDAS003.PAVARDE003003@EMAIL.COM", "VARPAV003", "AQAAAAEAACcQAAAAEFLaMaIjV0YAXQdSAZr4BE6M59ZyL77a97T8AUi5vUvuv+SVz2Z3xlfeW2ITPozA6Q==", null, false, "04d22aa1-cfeb-431f-8afb-7b7d8d755545", "C00003", "Pavarde003", false, 155425846L, "varpav003" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440002", 0, "1a35e15f-42c6-40c2-9946-37c409a54974", "Vardas002.Pavarde002002@email.com", false, "IFF-3/3", false, null, "Vardas002", "VARDAS002.PAVARDE002002@EMAIL.COM", "VARPAV002", "AQAAAAEAACcQAAAAEMuD9Cs3YU0hlw4BtOutH8b3Z4bTD+/FzZZnu9PC+NTRuFAZvRJgJw+LjIdHjLUntg==", null, false, "a980d1d9-3701-4bcf-a127-5f3f07418247", "C00002", "Pavarde002", false, 120406698L, "varpav002" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440001", 0, "1751ca9f-8a6c-407e-89a0-7a17ad27d345", "Vardas001.Pavarde001001@email.com", false, "IFF-6/4", false, null, "Vardas001", "VARDAS001.PAVARDE001001@EMAIL.COM", "VARPAV001", "AQAAAAEAACcQAAAAEG0K+9fgD/TiSPysbTA1qFQePJcy1dLYwfSVU+rDnRl0h6KeCYQrXagLojiq/byPNw==", null, false, "33520f28-8948-4d81-869d-1519d3d10565", "C00001", "Pavarde001", false, 180725540L, "varpav001" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440011", 0, "e3a1f99d-8913-44d8-9f22-6d881790f7e0", "Vardas011.Pavarde011011@email.com", false, "IFF-3/8", false, null, "Vardas011", "VARDAS011.PAVARDE011011@EMAIL.COM", "VARPAV011", "AQAAAAEAACcQAAAAEAofYbDZM0nyWLGUGCIHFND2fjw/HaAa2+YQHHDbUEwlGJmi/FdOOj43cExY5tEgSw==", null, false, "3b94cc63-9c51-43ed-b6e6-74f2d849ea76", "C00011", "Pavarde011", false, 160937489L, "varpav011" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440024", 0, "20ce4132-0524-474a-b30d-44d10acec659", "Vardas024.Pavarde024024@email.com", false, "IFF-8/6", false, null, "Vardas024", "VARDAS024.PAVARDE024024@EMAIL.COM", "VARPAV024", "AQAAAAEAACcQAAAAEGh7F60IPjOfNzlNjEHti8VsSfxfrmuNl6zT0TKB6YLXf7qsObzkX9AoQczg8yyJ3Q==", null, false, "b4d2d735-c3c3-498f-90e5-5a412a1ec0ca", "C00024", "Pavarde024", false, 129492386L, "varpav024" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440013", 0, "7bc93158-793a-4c94-8949-6844a9805bf9", "Vardas013.Pavarde013013@email.com", false, "IFF-6/1", false, null, "Vardas013", "VARDAS013.PAVARDE013013@EMAIL.COM", "VARPAV013", "AQAAAAEAACcQAAAAEHVONPO/3WQJSA0zy1AzeXPX04aVXfOM6QzcvpWTb7OLJrfQ13rotM3YlCHJNJop8w==", null, false, "11a22107-c66b-4573-9e87-9979be7a15d1", "C00013", "Pavarde013", false, 121475051L, "varpav013" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440026", 0, "601dfe3d-5d7b-4290-8492-ee1623d6dbcb", "Vardas026.Pavarde026026@email.com", false, "IFF-1/1", false, null, "Vardas026", "VARDAS026.PAVARDE026026@EMAIL.COM", "VARPAV026", "AQAAAAEAACcQAAAAEInsZg2BqrOP42o5vimYVdTLa9YfbJ8pt6yG6DGBO27Mr2dGkKgjHyGwbvKaSMaGdg==", null, false, "4f6aa93f-fc02-413f-a7ab-d8b7fd2e07ac", "C00026", "Pavarde026", false, 116328620L, "varpav026" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440025", 0, "b5cede0e-4530-4c2c-b0e6-680730ebe20a", "Vardas025.Pavarde025025@email.com", false, "IFF-8/7", false, null, "Vardas025", "VARDAS025.PAVARDE025025@EMAIL.COM", "VARPAV025", "AQAAAAEAACcQAAAAEAdRdsFbu9SGKeAIt4R4i24n8E7U8B5AE2N1gIx0qy4ZCpK6qTS0cMKD3xptAOoWtA==", null, false, "57934de7-bce2-41a3-82b7-a696b503efc8", "C00025", "Pavarde025", false, 168036646L, "varpav025" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440048", 0, "6a8c1dc8-f546-4159-83af-ece745e84099", "Vardas048.Pavarde048048@email.com", false, "IFF-3/9", false, null, "Vardas048", "VARDAS048.PAVARDE048048@EMAIL.COM", "VARPAV048", "AQAAAAEAACcQAAAAEJgmjxeDS09AVw4PocXKKo99zaItqLOX2qT602+PQDsfEFxb98CQyJeuR9zH8cOAkw==", null, false, "46e58d59-3f6e-4d03-95d2-d4b15c781464", "C00048", "Pavarde048", false, 103396374L, "varpav048" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440047", 0, "1d993370-d68f-4d37-998c-70652c5ba361", "Vardas047.Pavarde047047@email.com", false, "IFF-4/7", false, null, "Vardas047", "VARDAS047.PAVARDE047047@EMAIL.COM", "VARPAV047", "AQAAAAEAACcQAAAAEDB6jjKdvTwL/V3NRDADWGR3GewCJy2fJnNiDfBtgSs6HPQPfJx1elf6wtMLsByWQg==", null, false, "392d8b6e-60a5-4656-a057-02a2629debc8", "C00047", "Pavarde047", false, 154582721L, "varpav047" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440046", 0, "cb63fba0-87c6-4407-b95f-9bc458ca83d5", "Vardas046.Pavarde046046@email.com", false, "IFF-8/8", false, null, "Vardas046", "VARDAS046.PAVARDE046046@EMAIL.COM", "VARPAV046", "AQAAAAEAACcQAAAAEKQmkm65N7Cx4UKo9dA2eviEXcsDfyL/iL5x1hpXX9dFue8EDayH1dp5g4xCWCCYCg==", null, false, "643bf682-77cd-4c59-8e08-64a5d55fa4d2", "C00046", "Pavarde046", false, 174462007L, "varpav046" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440045", 0, "cc83b27d-26e7-4e01-b014-be6c6f9efc5e", "Vardas045.Pavarde045045@email.com", false, "IFF-9/6", false, null, "Vardas045", "VARDAS045.PAVARDE045045@EMAIL.COM", "VARPAV045", "AQAAAAEAACcQAAAAECbNx50zHk60vIP9ATSy+mxoOoafBQHmnsAhjKaGDG/bbp7SX36/n59Yt+jw62EWaw==", null, false, "72cbc2e3-4d6f-46fb-b2ef-b1266604be58", "C00045", "Pavarde045", false, 126356513L, "varpav045" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440044", 0, "11cb9f4e-fba3-461b-a483-26c613960787", "Vardas044.Pavarde044044@email.com", false, "IFF-9/3", false, null, "Vardas044", "VARDAS044.PAVARDE044044@EMAIL.COM", "VARPAV044", "AQAAAAEAACcQAAAAEHZtJ33NTVPwHv2DGpaUtCRwmqCYt3PUzcsGSI09yRv36i+Jcsg+Y5wEF/VQfK9b+A==", null, false, "9fa77e82-aff5-4328-9e99-500b0cda2bc6", "C00044", "Pavarde044", false, 161901777L, "varpav044" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440043", 0, "5589758d-b796-4692-bfbd-2e6e5a222e66", "Vardas043.Pavarde043043@email.com", false, "IFF-6/4", false, null, "Vardas043", "VARDAS043.PAVARDE043043@EMAIL.COM", "VARPAV043", "AQAAAAEAACcQAAAAEMdVA1VaNmg5g+aq2VMR4X3GFVVzKD4VErl2I4G1pV4BBoxN9Ibn1evVkMTFrXXIxg==", null, false, "61493c78-191c-4791-a1fa-3ab5108a1fe4", "C00043", "Pavarde043", false, 113584055L, "varpav043" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440042", 0, "a149d717-0295-4166-9c10-f47f1e1bd5aa", "Vardas042.Pavarde042042@email.com", false, "IFF-8/1", false, null, "Vardas042", "VARDAS042.PAVARDE042042@EMAIL.COM", "VARPAV042", "AQAAAAEAACcQAAAAECE85nxXuHe5T68m3HrBs+UmNxLDV8YdeSJ9MWP4+no1k2WBF2HAe1RKA0BfzKjZqg==", null, false, "df2bdf07-86fd-4761-b7db-572f87b7bc89", "C00042", "Pavarde042", false, 135594674L, "varpav042" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440041", 0, "17cc9558-d63a-4592-b366-9b41a024e3db", "Vardas041.Pavarde041041@email.com", false, "IFF-2/4", false, null, "Vardas041", "VARDAS041.PAVARDE041041@EMAIL.COM", "VARPAV041", "AQAAAAEAACcQAAAAENEz2HQzHrRZweuIU9FvP5PRZlQFgZe1GNSMyzeY2+aQsG2RDf4ZtmJ3grxJ5AOB6A==", null, false, "f4c7464f-d1f3-4823-b00c-163fce017f53", "C00041", "Pavarde041", false, 192393649L, "varpav041" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440039", 0, "3e98e65d-91c1-44ca-97df-af6d21d9e89a", "Vardas039.Pavarde039039@email.com", false, "IFF-9/7", false, null, "Vardas039", "VARDAS039.PAVARDE039039@EMAIL.COM", "VARPAV039", "AQAAAAEAACcQAAAAEGCDzi/QFDk0lz1ZjAwybblNe/V+a8xdHJEllPeT7qtbMnDnlaLg6lh6KbW+GUhuhQ==", null, false, "4b837901-bd9d-4f1c-a2b6-ce964977bafc", "C00039", "Pavarde039", false, 182578655L, "varpav039" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440038", 0, "af514e98-77ae-41ff-b456-2147a35f3b8c", "Vardas038.Pavarde038038@email.com", false, "IFF-3/6", false, null, "Vardas038", "VARDAS038.PAVARDE038038@EMAIL.COM", "VARPAV038", "AQAAAAEAACcQAAAAEINTcT1/iny2tx7usyv9MnD3QJ4hyDDg4B4sX1VpAOgeCjNnmkPBBgdkSqUcyN1o8w==", null, false, "ea2d582a-59a9-46e2-bcc7-4413217a382c", "C00038", "Pavarde038", false, 143499845L, "varpav038" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440040", 0, "1674750f-74ac-4847-972b-6095bf9ed447", "Vardas040.Pavarde040040@email.com", false, "IFF-8/9", false, null, "Vardas040", "VARDAS040.PAVARDE040040@EMAIL.COM", "VARPAV040", "AQAAAAEAACcQAAAAEBDkm0HtbEdbqkqBDp74ZPwpm79mZi8b0QDQ7r3bLylr6MF9Zb/g1n5leVk8E+lX2Q==", null, false, "e4e77af4-8c65-4282-b0d9-1fa6293b3eb0", "C00040", "Pavarde040", false, 127785738L, "varpav040" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440036", 0, "3c8afb47-4c61-462b-93fb-e91ec0ce8dc4", "Vardas036.Pavarde036036@email.com", false, "IFF-6/7", false, null, "Vardas036", "VARDAS036.PAVARDE036036@EMAIL.COM", "VARPAV036", "AQAAAAEAACcQAAAAEJB+mQ1KEYaUEur6vOoXSY8O/Kdw9/pXfpYiLB/qw5KOm3qlD7dQqHbTVMagc8utRg==", null, false, "ffdb4ddf-4635-471f-8c36-0f7ce9928af8", "C00036", "Pavarde036", false, 176422864L, "varpav036" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440027", 0, "d51a5a3c-097f-4331-bc20-5d61dc006385", "Vardas027.Pavarde027027@email.com", false, "IFF-5/1", false, null, "Vardas027", "VARDAS027.PAVARDE027027@EMAIL.COM", "VARPAV027", "AQAAAAEAACcQAAAAEBcg3H03SQsxZug6UFucC7kJvo/4JcYdeVu2JxYuQQircI90/yFEA91LdHE9b1GOVw==", null, false, "39eed4d1-f29f-4501-ba87-1ccc776d0bc0", "C00027", "Pavarde027", false, 113055084L, "varpav027" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440028", 0, "a806892b-358a-4a80-a21c-3d609bda3c52", "Vardas028.Pavarde028028@email.com", false, "IFF-5/9", false, null, "Vardas028", "VARDAS028.PAVARDE028028@EMAIL.COM", "VARPAV028", "AQAAAAEAACcQAAAAEH3quUtlmhH1jf4lkNezDgUOykjOihcoJMLkOtn49snvH0CMxyU+cCrRP0BD8J8nCA==", null, false, "8e03f8b5-972a-4bfb-b8d8-66190e3edced", "C00028", "Pavarde028", false, 134431737L, "varpav028" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440029", 0, "4d9f0978-f938-457a-a92d-c0599f60762f", "Vardas029.Pavarde029029@email.com", false, "IFF-3/7", false, null, "Vardas029", "VARDAS029.PAVARDE029029@EMAIL.COM", "VARPAV029", "AQAAAAEAACcQAAAAELPxT7bQPC8pNyOvMi7itfb/wTH0BSQFTl05v7mAdskN7JlW73Ys4R/Ct0H+lCaBnw==", null, false, "e1f563eb-a496-4220-b79e-503b3dc08285", "C00029", "Pavarde029", false, 117835928L, "varpav029" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440037", 0, "707b786f-b53f-425d-b139-0b112ba79708", "Vardas037.Pavarde037037@email.com", false, "IFF-5/9", false, null, "Vardas037", "VARDAS037.PAVARDE037037@EMAIL.COM", "VARPAV037", "AQAAAAEAACcQAAAAEO5V+14VD3rmbzDNlAzrWT/RjcKfgpE6vYU1u0ulNoiAp6yknbB9o/Ffwsrx9rYZZA==", null, false, "8c758733-4a80-47f1-8981-feba6dea68c7", "C00037", "Pavarde037", false, 145022243L, "varpav037" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440031", 0, "d32ec7f5-4b72-4563-bab3-f46866d75eeb", "Vardas031.Pavarde031031@email.com", false, "IFF-8/5", false, null, "Vardas031", "VARDAS031.PAVARDE031031@EMAIL.COM", "VARPAV031", "AQAAAAEAACcQAAAAEMMTs0MN23I8GvcoLXgb5qegswIXEfdGvH/XwLFcM6aJLoHdG7/3lny/3KsmEEqt3g==", null, false, "604684b2-0765-4dac-8fb5-579d3829e9c5", "C00031", "Pavarde031", false, 141229298L, "varpav031" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440030", 0, "385c540b-f3e0-437d-bf63-627a46ec3b27", "Vardas030.Pavarde030030@email.com", false, "IFF-5/8", false, null, "Vardas030", "VARDAS030.PAVARDE030030@EMAIL.COM", "VARPAV030", "AQAAAAEAACcQAAAAEP3Y8eIIfjWS8LEL7cLQ4OxGl3/+d9+EwoXcSqHWVVsCD3i95TE5IsoKQM9kO7U7Kg==", null, false, "50d47330-1c60-41da-973c-7e8531bc5cd1", "C00030", "Pavarde030", false, 168673626L, "varpav030" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440033", 0, "be5d9a2d-dc8f-41e0-a213-f663e6ee74a3", "Vardas033.Pavarde033033@email.com", false, "IFF-8/8", false, null, "Vardas033", "VARDAS033.PAVARDE033033@EMAIL.COM", "VARPAV033", "AQAAAAEAACcQAAAAED6XLOy6DvDjAZXODVDMs10zcVZ+bNOzumLS94Q99j6ucqcKQMJklB5BqCKV/cvB8A==", null, false, "60d9b02d-fd61-439b-882e-63db7083edd3", "C00033", "Pavarde033", false, 122697682L, "varpav033" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440034", 0, "2cefca84-04c6-4e98-bb37-c9f592f0f034", "Vardas034.Pavarde034034@email.com", false, "IFF-8/3", false, null, "Vardas034", "VARDAS034.PAVARDE034034@EMAIL.COM", "VARPAV034", "AQAAAAEAACcQAAAAEEjhDPaa/59uUd3AYzBqVy0ok+jo3Zw8tluIlyBw3WRQuSHo0X8D1LJm4ItFRRrEgg==", null, false, "dcf21537-b729-4b04-a3b1-ce368f8cd609", "C00034", "Pavarde034", false, 116826042L, "varpav034" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440035", 0, "e6c9a591-ec64-4ec1-a7b8-2cde2cb0851b", "Vardas035.Pavarde035035@email.com", false, "IFF-6/4", false, null, "Vardas035", "VARDAS035.PAVARDE035035@EMAIL.COM", "VARPAV035", "AQAAAAEAACcQAAAAECeyJAnZXaxMBu/Fat8YppNXa6Bk3OinL0XPtEg6vPNmq+jkPeiHo99J3bIA3oDWkQ==", null, false, "dd506e49-da44-4ab0-a90e-8ce8b6ff6e66", "C00035", "Pavarde035", false, 147590426L, "varpav035" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440032", 0, "558fc5aa-56ff-458c-9dd0-3997dbdd320e", "Vardas032.Pavarde032032@email.com", false, "IFF-5/2", false, null, "Vardas032", "VARDAS032.PAVARDE032032@EMAIL.COM", "VARPAV032", "AQAAAAEAACcQAAAAEGlcxy6GeSOKiXovRRm48z/EUQjBKk6emqoy+aV/JXv/kYoriHk7MRpsftn10j3H0A==", null, false, "eb0e35bb-051e-4ff9-ba19-9afadee1c22e", "C00032", "Pavarde032", false, 111807414L, "varpav032" }
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "ClassroomId", "ClassLabel", "ClassLocation" },
                values: new object[,]
                {
                    { 9, "152", "XII" },
                    { 14, "108", "B2" },
                    { 13, "103KL", "IX" },
                    { 12, "103CD", "IX" },
                    { 11, "103AB", "IX" },
                    { 10, "153", "XII" },
                    { 7, "151", "XII" },
                    { 9999, "DummmyClassroom", "Moon, in a far galaxy away" },
                    { 5, "215", "XI" },
                    { 4, "518", "XI" },
                    { 3, "103", "XI" },
                    { 2, "102", "XI" },
                    { 1, "101", "XI" },
                    { 6, "150", "XII" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[,]
                {
                    { "PB0005", "Anglų kalba" },
                    { "PB0004", "Programavimo kalbų teorija" },
                    { "PB0003", "Programų sistemų inžinerija" },
                    { "PB0002", "Semestro projektas" },
                    { "PB0000", "Algoritmų analizė ir sudarymas" },
                    { "PB0001", "Duomenų bazės" }
                });

            migrationBuilder.InsertData(
                table: "Periods",
                columns: new[] { "PeriodId", "PeriodEndTime", "PeriodStartTime" },
                values: new object[,]
                {
                    { 4, new TimeSpan(0, 17, 0, 0, 0), new TimeSpan(0, 15, 30, 0, 0) },
                    { 1, new TimeSpan(0, 10, 30, 0, 0), new TimeSpan(0, 9, 0, 0, 0) },
                    { 2, new TimeSpan(0, 12, 30, 0, 0), new TimeSpan(0, 11, 0, 0, 0) },
                    { 3, new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 13, 30, 0, 0) },
                    { 5, new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 30, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd93440001", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440074", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440073", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440072", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440071", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440070", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440069", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440068", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440067", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440066", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440065", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440064", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440063", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440062", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440061", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440060", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440059", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440058", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440057", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440056", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440055", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440054", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440075", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440076", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440077", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440078", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440100", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440099", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440098", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440097", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440096", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440095", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440094", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440093", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440092", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440091", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440052", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440090", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440088", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440087", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440086", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440085", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440084", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440083", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440082", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440081", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440080", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440079", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440089", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440051", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440053", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440049", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440050", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440022", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440021", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440020", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440019", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440018", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440017", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440016", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440015", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440014", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440024", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440013", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440011", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440010", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440009", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440008", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440007", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440006", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440005", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440004", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440003", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440002", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440012", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440025", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440023", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440027", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440048", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440047", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440046", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440045", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440044", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440043", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440042", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440026", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440040", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440039", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440041", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440037", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440028", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440038", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440030", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440031", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440029", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440033", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440034", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440035", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440036", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440032", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "ClassroomId", "DeviceIdReal" },
                values: new object[,]
                {
                    { 2, 5, 2 },
                    { 4, 9999, 4 },
                    { 5, 9999, 5 },
                    { 6, 9999, 6 },
                    { 1, 3, 1 },
                    { 3, 13, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devices_ClassroomId",
                table: "Devices",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_ClassroomId",
                table: "Timetables",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_CourseId",
                table: "Timetables",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_PeriodId",
                table: "Timetables",
                column: "PeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Timetables_StudentId",
                table: "Timetables",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "NFCScans");

            migrationBuilder.DropTable(
                name: "Timetables");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Classrooms");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Periods");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
