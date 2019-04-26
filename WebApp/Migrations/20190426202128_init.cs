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
                    ScanId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UID = table.Column<long>(nullable: false),
                    TimeStamp = table.Column<DateTime>(nullable: false),
                    DeviceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NFCScans", x => x.ScanId);
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
                    PendingDeviceId = table.Column<int>(nullable: false),
                    updatePending = table.Column<bool>(nullable: false),
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
                    isVisited = table.Column<bool>(nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    LectureType = table.Column<string>(nullable: false)
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
                    { "STUDENT", "4ef1b4bd-42f6-4716-a63f-7866b7d0c509", "STUDENT", "STUDENT" },
                    { "ADMIN", "59438f77-c808-46b2-8ed6-39d9ceda971b", "ADMIN", "ADMIN" },
                    { "LECTURER", "51797a7c-a3f2-4a41-bdb7-b09e069a1b78", "LECTURER", "LECTURER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Group", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCode", "Surname", "TwoFactorEnabled", "UID", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd93440074", 0, "dde9d1ad-b5ae-4d38-b102-100700dc8d3e", "Vardas074.Pavarde074074@email.com", false, "IFF-1/6", false, null, "Vardas074", "VARDAS074.PAVARDE074074@EMAIL.COM", "VARPAV074", "AQAAAAEAACcQAAAAENK1f4O9FW/ANINc0XmCQKGaSHg7lC9R0K1IihNEuMOH4E/f44PIvjKbrXoAEIvs/g==", null, false, "f324f73c-0b50-42b9-a074-e3c86e0e78c8", "C00074", "Pavarde074", false, 185285606L, "varpav074" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440073", 0, "163a6a86-35a8-4f99-bb81-72466013f282", "Vardas073.Pavarde073073@email.com", false, "IFF-3/3", false, null, "Vardas073", "VARDAS073.PAVARDE073073@EMAIL.COM", "VARPAV073", "AQAAAAEAACcQAAAAEN8jJkdLhFgqHDsaP0IeQy+mdlSsdm8r/FbWVEp+VLSJRu3VfXQUW8at7LntahVzww==", null, false, "7acc447e-7733-4abd-ae90-64a8da16050b", "C00073", "Pavarde073", false, 121160559L, "varpav073" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440072", 0, "d19baa47-083e-4a1c-a889-395cf4105656", "Vardas072.Pavarde072072@email.com", false, "IFF-7/9", false, null, "Vardas072", "VARDAS072.PAVARDE072072@EMAIL.COM", "VARPAV072", "AQAAAAEAACcQAAAAEJV/AITs46lKczzbGl5vKh0acodAIJGJjeTAzKHwxrteHTJbzqF8JoQy09LdP3JdCg==", null, false, "e1b6529e-1367-47aa-abae-922caf4fdbd7", "C00072", "Pavarde072", false, 127041034L, "varpav072" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440071", 0, "064dfb60-942c-4643-9685-99c3d40f972a", "Vardas071.Pavarde071071@email.com", false, "IFF-5/7", false, null, "Vardas071", "VARDAS071.PAVARDE071071@EMAIL.COM", "VARPAV071", "AQAAAAEAACcQAAAAEJfgQ2mSkzpJvOBpXOg1z1hmonGsT0EWd9foEBJkRxR35dhHlk9UusahWmAkEgKiYg==", null, false, "d43d3e4a-d52c-440d-b550-63ebe607bc83", "C00071", "Pavarde071", false, 196565791L, "varpav071" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440070", 0, "127a45e1-c0ff-4f35-82c6-b52ef194e7e7", "Vardas070.Pavarde070070@email.com", false, "IFF-7/1", false, null, "Vardas070", "VARDAS070.PAVARDE070070@EMAIL.COM", "VARPAV070", "AQAAAAEAACcQAAAAEI4sQsYnUzdBrFHusBPt3/x5eaWS9mYc+0S+RgiFRvJ27ggTKVdUgR2E93ipFwMbPA==", null, false, "e585772a-0c74-435a-9f49-37f4fc765f70", "C00070", "Pavarde070", false, 148329032L, "varpav070" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440069", 0, "cd075492-e682-4970-bae5-362386bd93ed", "Vardas069.Pavarde069069@email.com", false, "IFF-4/1", false, null, "Vardas069", "VARDAS069.PAVARDE069069@EMAIL.COM", "VARPAV069", "AQAAAAEAACcQAAAAEIHWSLgm3cVJwZhMF+6ifDLjtGExgKmWu0pMwViof89+2SjL5xv5XJqq/+yxRQ78Ww==", null, false, "919538cc-47c1-4e1e-acca-891145d069bb", "C00069", "Pavarde069", false, 121700514L, "varpav069" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440068", 0, "1a44c86e-693a-464d-9092-64b51c662e82", "Vardas068.Pavarde068068@email.com", false, "IFF-1/6", false, null, "Vardas068", "VARDAS068.PAVARDE068068@EMAIL.COM", "VARPAV068", "AQAAAAEAACcQAAAAEJ2khg++k97/lI48IYaQalAMmCQF6QuHg3w9zjYt8acEgpTWXKSOeFSGxahgblqqMw==", null, false, "906bc128-1143-4687-ad24-3a92c210002b", "C00068", "Pavarde068", false, 176007039L, "varpav068" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440067", 0, "d469594c-1732-4dea-a8fe-2e002840931d", "Vardas067.Pavarde067067@email.com", false, "IFF-5/3", false, null, "Vardas067", "VARDAS067.PAVARDE067067@EMAIL.COM", "VARPAV067", "AQAAAAEAACcQAAAAEK5w7A3NyFvbRWNFGgZeyynnSpSFAE/Pi86bDtWRVYzZ6eTPL4W8O65QcO5qDvYvyA==", null, false, "69d1ecbc-b9e5-49e7-b6e2-07accd0464e7", "C00067", "Pavarde067", false, 183542631L, "varpav067" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440066", 0, "ae45cc1a-2534-4847-8c93-69c5bc2d0801", "Vardas066.Pavarde066066@email.com", false, "IFF-4/3", false, null, "Vardas066", "VARDAS066.PAVARDE066066@EMAIL.COM", "VARPAV066", "AQAAAAEAACcQAAAAEFKDqBVSlk7Ll2tm1+Pg8Zn5XJjODRCodzCxtnt4j1Bid6SQHjsM6Rvisq1H4Zr8og==", null, false, "08cf8de7-7492-4a63-9e13-3768eac7eecc", "C00066", "Pavarde066", false, 157885644L, "varpav066" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440065", 0, "03bac1a0-2029-4e81-b112-425a994e47e0", "Vardas065.Pavarde065065@email.com", false, "IFF-1/4", false, null, "Vardas065", "VARDAS065.PAVARDE065065@EMAIL.COM", "VARPAV065", "AQAAAAEAACcQAAAAEC9n58FBtoYZtF87GNqgy6lrc3maQWd3/d3lJS9CSygky2LGCoO1Vue88yu9DbjmwA==", null, false, "4288bea2-347b-45dc-ad40-5241afca7174", "C00065", "Pavarde065", false, 124383347L, "varpav065" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440063", 0, "09c39b08-4685-4b61-82cb-ae56558ea0c8", "Vardas063.Pavarde063063@email.com", false, "IFF-6/9", false, null, "Vardas063", "VARDAS063.PAVARDE063063@EMAIL.COM", "VARPAV063", "AQAAAAEAACcQAAAAEIhg29R+aZaE2cCua8KsR6N/ohoEg9Sx8NbwhNLZpQyz/MxZck30GGmdkhMng6tY9g==", null, false, "f026af1c-0325-47fe-afc4-14365e105136", "C00063", "Pavarde063", false, 130206954L, "varpav063" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440075", 0, "c47ea049-775a-4cd7-8a6e-40730ae11bc5", "Vardas075.Pavarde075075@email.com", false, "IFF-9/5", false, null, "Vardas075", "VARDAS075.PAVARDE075075@EMAIL.COM", "VARPAV075", "AQAAAAEAACcQAAAAEAzIjaJpVfIzlJwHtVlYJLwyHV79NBvyp0Uun5N49gzIJTk3VCVlG/m6Pc0El+jlkg==", null, false, "a439ae16-6f61-465e-9cf1-52690cc94440", "C00075", "Pavarde075", false, 118701302L, "varpav075" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440062", 0, "15fbb88e-bb36-4b42-8033-5f8fed2adb3a", "Vardas062.Pavarde062062@email.com", false, "IFF-6/3", false, null, "Vardas062", "VARDAS062.PAVARDE062062@EMAIL.COM", "VARPAV062", "AQAAAAEAACcQAAAAEFcILgA47wVuHcKH/GU48VIFnZe6Sj9OyUiLxzPw0Sz9yqrEH4E8PZvV95VHy8fR/g==", null, false, "45680121-c99a-414c-92da-9a9840edeff9", "C00062", "Pavarde062", false, 146566210L, "varpav062" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440060", 0, "4c813de3-38c2-4bc6-9431-1d6b9caad53e", "Vardas060.Pavarde060060@email.com", false, "IFF-7/6", false, null, "Vardas060", "VARDAS060.PAVARDE060060@EMAIL.COM", "VARPAV060", "AQAAAAEAACcQAAAAEFljvrLH1weU+Nkc10zQK4BKC9IzNKCHWj/d55GHTIeSqStlcpY0w0VMQwOGEyLgMg==", null, false, "08201801-16e9-45e1-9276-867e8453f104", "C00060", "Pavarde060", false, 135634699L, "varpav060" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440059", 0, "84818fca-a6d5-4b5e-be63-e1734c9d0af2", "Vardas059.Pavarde059059@email.com", false, "IFF-5/4", false, null, "Vardas059", "VARDAS059.PAVARDE059059@EMAIL.COM", "VARPAV059", "AQAAAAEAACcQAAAAEBK2e1mUOx6QTEqwudL6+Cgzc9rCfjNtJ3Ef+5SK8480daOKmzpllLEEREKkivNkmw==", null, false, "fd31a441-0de6-4f7e-806d-1e51980a2397", "C00059", "Pavarde059", false, 162855153L, "varpav059" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440058", 0, "718d5232-2e2b-4ac4-ba5f-edb41aeff31c", "Vardas058.Pavarde058058@email.com", false, "IFF-7/6", false, null, "Vardas058", "VARDAS058.PAVARDE058058@EMAIL.COM", "VARPAV058", "AQAAAAEAACcQAAAAEITJ4A0vBr0kDi+/DdVwjlqT/9/lNvPfXx78wU3LABCOOKzmWTw2raO/1xYe3FirzA==", null, false, "3479bb25-224c-47d1-aff7-67a231b86aae", "C00058", "Pavarde058", false, 149656270L, "varpav058" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440057", 0, "2cec69fa-35ea-4a06-a60d-d5d6039ae20a", "Vardas057.Pavarde057057@email.com", false, "IFF-1/2", false, null, "Vardas057", "VARDAS057.PAVARDE057057@EMAIL.COM", "VARPAV057", "AQAAAAEAACcQAAAAEFsTcHxDyYaqRr3Ur04Jj9j50eujQ/Y98DLHzqOXEoG2ngXoJ0dqbKF3wJjElNrtMQ==", null, false, "93a3f961-f01a-4948-b971-581910620706", "C00057", "Pavarde057", false, 186731673L, "varpav057" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440056", 0, "56778ef8-3d93-4096-aa52-89de931a1aae", "Vardas056.Pavarde056056@email.com", false, "IFF-3/1", false, null, "Vardas056", "VARDAS056.PAVARDE056056@EMAIL.COM", "VARPAV056", "AQAAAAEAACcQAAAAEDuN296MnD2SLsewfydqv+nBGfUPTtC4gOcG5/enezmjm9AlraXEwgpuEAOENjqmQA==", null, false, "1bed9788-0a37-40ca-a3e9-c72158f2068e", "C00056", "Pavarde056", false, 134478141L, "varpav056" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440055", 0, "576cb6b8-3b4e-4d22-b887-9b05e21c5171", "Vardas055.Pavarde055055@email.com", false, "IFF-9/2", false, null, "Vardas055", "VARDAS055.PAVARDE055055@EMAIL.COM", "VARPAV055", "AQAAAAEAACcQAAAAEFsVqwS49JafkAgLgMHDtNiP2UVw2eMHuXzErs1S+IckYhnq6Nna5bSxdKxJQhsKUA==", null, false, "acb50f11-8891-405a-9b0c-795abbadf8c2", "C00055", "Pavarde055", false, 175106816L, "varpav055" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440054", 0, "498e8579-5354-4191-8309-1affb24527c9", "Vardas054.Pavarde054054@email.com", false, "IFF-1/4", false, null, "Vardas054", "VARDAS054.PAVARDE054054@EMAIL.COM", "VARPAV054", "AQAAAAEAACcQAAAAELpbB+JtfV4Owi7YhD6GUEQrfHxGBVx6JLDZKZwMfZxKo57J35AYHmtDGfkV3xZSfg==", null, false, "4d821809-3f6d-45eb-9740-0a6df241f8af", "C00054", "Pavarde054", false, 133144618L, "varpav054" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440053", 0, "10228753-a73e-4000-a1e0-23e061dab070", "Vardas053.Pavarde053053@email.com", false, "IFF-5/8", false, null, "Vardas053", "VARDAS053.PAVARDE053053@EMAIL.COM", "VARPAV053", "AQAAAAEAACcQAAAAEDBN93fy6dGC5IIym9oc4Gt4rwJCiVfMFgTzzOZq1BFNfogQIVKHXDa5Fhxn6Y+tFg==", null, false, "a22545c0-9032-4cdb-9991-dd71b0090c85", "C00053", "Pavarde053", false, 189971445L, "varpav053" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440064", 0, "4d8547d8-14f3-469a-92f2-bc4d6dc31135", "Vardas064.Pavarde064064@email.com", false, "IFF-6/2", false, null, "Vardas064", "VARDAS064.PAVARDE064064@EMAIL.COM", "VARPAV064", "AQAAAAEAACcQAAAAEDJv45n7FdPIBF7AgeHmHOuRvG5+zmkEy3eYDSyu02MJscA2HzWEjuCUaiHXpguQ+A==", null, false, "1141482b-97bb-4bee-81e7-dd9779aa2064", "C00064", "Pavarde064", false, 194815079L, "varpav064" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440076", 0, "8ba95f10-0506-4156-9fdd-6d37ea5369c4", "Vardas076.Pavarde076076@email.com", false, "IFF-3/7", false, null, "Vardas076", "VARDAS076.PAVARDE076076@EMAIL.COM", "VARPAV076", "AQAAAAEAACcQAAAAEH2kt5MGn+jWyFB2B0wVscOCDCuCtdazU9+sG4/xwdyXhaK/CayuyYaoY3w9+pJstQ==", null, false, "262a65d6-caa5-401a-a4e7-e115da6cb5ca", "C00076", "Pavarde076", false, 194177638L, "varpav076" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440078", 0, "965f9b44-ccc0-485d-892b-81f2b0b300f6", "Vardas078.Pavarde078078@email.com", false, "IFF-5/2", false, null, "Vardas078", "VARDAS078.PAVARDE078078@EMAIL.COM", "VARPAV078", "AQAAAAEAACcQAAAAEDccuQxA+GpAWiwQXCsufJsJksW3ZgECMyVuasoMORfKEiiXcp4i32sC1wsQXA2Iig==", null, false, "b8810433-a1c0-4664-84b4-1ff44e9615c9", "C00078", "Pavarde078", false, 113067906L, "varpav078" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440052", 0, "ff9e8afa-92cd-4a05-bbde-ee5a7de3f16c", "Vardas052.Pavarde052052@email.com", false, "IFF-6/3", false, null, "Vardas052", "VARDAS052.PAVARDE052052@EMAIL.COM", "VARPAV052", "AQAAAAEAACcQAAAAEHn1VZCTLIC5m/OFf8il/WX4DHsv0p9lToTsHzyolBVmo6SAYnXr1qBr2hinDQn3MA==", null, false, "91aa564e-f832-431e-85ca-5f7b00eabffa", "C00052", "Pavarde052", false, 138366701L, "varpav052" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440100", 0, "34ebabe2-c730-4a51-8581-21b9fa34b768", "Vardas100.Pavarde100100@email.com", false, "IFF-8/2", false, null, "Vardas100", "VARDAS100.PAVARDE100100@EMAIL.COM", "VARPAV100", "AQAAAAEAACcQAAAAEClsJYbNt4g8rl10KHUmyxnBbtKiaV4aVqEGCfkOWJFc623BVWgIInHkexZNrrIoIw==", null, false, "fe9b3c13-fbd9-4dbe-b03f-449da17ab37f", "C00100", "Pavarde100", false, 117764558L, "varpav100" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440099", 0, "958e6b32-cdf4-4d99-becd-29daf4104f37", "Vardas099.Pavarde099099@email.com", false, "IFF-9/5", false, null, "Vardas099", "VARDAS099.PAVARDE099099@EMAIL.COM", "VARPAV099", "AQAAAAEAACcQAAAAEOhwvEWtfGEyA2ctqa0HF6mUT5TkK+GSe7JGqORhf4IWOBSzN+fPeYYgoK2aJKuhgQ==", null, false, "58d85f2a-df18-4a1e-9f9e-5e29f2cec89b", "C00099", "Pavarde099", false, 101471737L, "varpav099" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440098", 0, "4e7d6fb0-67ee-442f-a1cc-5cc196921a39", "Vardas098.Pavarde098098@email.com", false, "IFF-4/9", false, null, "Vardas098", "VARDAS098.PAVARDE098098@EMAIL.COM", "VARPAV098", "AQAAAAEAACcQAAAAEC3KbB9mm0g1gvYX12upW7CGev4KaxXK740zIhTAx+2tN0mdd0P0OFrBL1oNwff3eA==", null, false, "ef389a99-a4dc-4767-8c34-cc508828f9d9", "C00098", "Pavarde098", false, 188918485L, "varpav098" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440097", 0, "7f507131-2a1b-41c0-843d-3fe339372e66", "Vardas097.Pavarde097097@email.com", false, "IFF-7/3", false, null, "Vardas097", "VARDAS097.PAVARDE097097@EMAIL.COM", "VARPAV097", "AQAAAAEAACcQAAAAEGnT8uoRmO/xP3Sjz66d7vCrgO9QIvr6vTO+cA8kxiSzr21rIUWtwG3wyJEamOD8xg==", null, false, "00c8ceb1-1670-4c4d-9230-3b295bf0cd11", "C00097", "Pavarde097", false, 169842317L, "varpav097" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440096", 0, "8237c364-13b8-4a39-a6e0-f4325ac2c0d1", "Vardas096.Pavarde096096@email.com", false, "IFF-2/5", false, null, "Vardas096", "VARDAS096.PAVARDE096096@EMAIL.COM", "VARPAV096", "AQAAAAEAACcQAAAAEBnRjPOIHq7v9f3t9B1FC/kEIO3ruRWbPvGMJQUmeZgt7Ssifm9Pp0S6gFlo6Xg4tg==", null, false, "5dd03960-2594-4966-8aac-fde8abfd1066", "C00096", "Pavarde096", false, 198826723L, "varpav096" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440095", 0, "ba30e331-a13d-4790-8ba9-18e22b7c4df2", "Vardas095.Pavarde095095@email.com", false, "IFF-7/7", false, null, "Vardas095", "VARDAS095.PAVARDE095095@EMAIL.COM", "VARPAV095", "AQAAAAEAACcQAAAAEL/6lw1qqVGv1Cdz5DL+Dlww3lX0mu8BwQi0tXRKxvG18dqYOlMok8RORd8/SoJo9g==", null, false, "fca1ff8f-5f08-42fe-baca-d163d694cd92", "C00095", "Pavarde095", false, 130902215L, "varpav095" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440094", 0, "703386e2-2233-4217-8724-8b3e80e3f5b4", "Vardas094.Pavarde094094@email.com", false, "IFF-5/3", false, null, "Vardas094", "VARDAS094.PAVARDE094094@EMAIL.COM", "VARPAV094", "AQAAAAEAACcQAAAAEDGgZ0u5A0AlcN+7pjNGP5hNYdnwCGWtwLWBceoGj6hXa5F3AGbMxNJC3mobT9JI+Q==", null, false, "81a17ddf-ab92-4a47-89b5-02d89e589ed0", "C00094", "Pavarde094", false, 138109241L, "varpav094" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440093", 0, "df016b4f-598f-41a0-bea1-cbff87d6be49", "Vardas093.Pavarde093093@email.com", false, "IFF-4/9", false, null, "Vardas093", "VARDAS093.PAVARDE093093@EMAIL.COM", "VARPAV093", "AQAAAAEAACcQAAAAEJb32sIUTslSSj6Tq//m90ePurqVCYrAGqrsW7yIM+adSNZYs4V2gFyexaMyLUKXGg==", null, false, "235141f4-69c8-4e0b-9631-9171b34dddaa", "C00093", "Pavarde093", false, 174733212L, "varpav093" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440092", 0, "e3911f4c-5654-4c9d-b187-c94ce382e0a9", "Vardas092.Pavarde092092@email.com", false, "IFF-5/3", false, null, "Vardas092", "VARDAS092.PAVARDE092092@EMAIL.COM", "VARPAV092", "AQAAAAEAACcQAAAAEDsbjGyY/i+VuZ6Xx9CmHw7ZA3fDfttavmkUFdfpaGr8C1Oqk8rnOcJlnlJyugvIyw==", null, false, "0ee58042-4443-46d7-bfe9-768c9caad3a6", "C00092", "Pavarde092", false, 106126132L, "varpav092" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440091", 0, "c9ada3a0-eb0f-423e-b851-dcdf899fd5a5", "Vardas091.Pavarde091091@email.com", false, "IFF-6/1", false, null, "Vardas091", "VARDAS091.PAVARDE091091@EMAIL.COM", "VARPAV091", "AQAAAAEAACcQAAAAEEZ1dab73mRnwKLmXfcZPnJJ94V9HaDDpn5RqODxTshgpsKAl0GrTkigrtf8ojZYjQ==", null, false, "f363e94c-b0fb-4d37-9a6a-1f8f86cb4f30", "C00091", "Pavarde091", false, 189999163L, "varpav091" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440077", 0, "d7ce3412-1f1b-49a8-892d-6fa00318519e", "Vardas077.Pavarde077077@email.com", false, "IFF-1/2", false, null, "Vardas077", "VARDAS077.PAVARDE077077@EMAIL.COM", "VARPAV077", "AQAAAAEAACcQAAAAEGXTM3sjEktmQPNv96hUHfNg32LC1PERGzu3uTO1ozBcgvK0fBsvjiSewenGYsYBrg==", null, false, "bd597657-7723-4c96-9954-3a7d7612e001", "C00077", "Pavarde077", false, 120648076L, "varpav077" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440090", 0, "361242b2-c9de-49ef-bffd-6a07832deadc", "Vardas090.Pavarde090090@email.com", false, "IFF-9/8", false, null, "Vardas090", "VARDAS090.PAVARDE090090@EMAIL.COM", "VARPAV090", "AQAAAAEAACcQAAAAEJ4XAedXjONn09Z+vxs7X2MsAoMGqpdKYLjMo7XsQ2FSyHMA1WICtTPE8aFTrcSUbA==", null, false, "9cc3e0bb-8bd4-42d0-9d10-aa3648463e26", "C00090", "Pavarde090", false, 153740045L, "varpav090" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440088", 0, "8643f1ac-24dc-484a-be6b-cf794be94bd3", "Vardas088.Pavarde088088@email.com", false, "IFF-3/7", false, null, "Vardas088", "VARDAS088.PAVARDE088088@EMAIL.COM", "VARPAV088", "AQAAAAEAACcQAAAAEFay7uQRcfn/fnTsFn/ZmbbrO5yVbfXvwjB38eCzSQNudJ/f2lPp4vWZWp9KB6Wv+A==", null, false, "f11ae467-f192-4abd-a456-743b31eb995e", "C00088", "Pavarde088", false, 134696561L, "varpav088" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440087", 0, "610eca8a-90db-4957-8d8c-b6722196d2a9", "Vardas087.Pavarde087087@email.com", false, "IFF-3/2", false, null, "Vardas087", "VARDAS087.PAVARDE087087@EMAIL.COM", "VARPAV087", "AQAAAAEAACcQAAAAEB8rZAbfrW/tB3qddg1dN32S1Ejs993h0yyiJI/zrgiQGV5t44zITQiUk5qzoMSFsA==", null, false, "5f557fc0-6b7d-405a-9add-3dd3c12cdb82", "C00087", "Pavarde087", false, 114166833L, "varpav087" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440086", 0, "b3745f86-ab62-4a32-8b84-0b30033676ad", "Vardas086.Pavarde086086@email.com", false, "IFF-6/2", false, null, "Vardas086", "VARDAS086.PAVARDE086086@EMAIL.COM", "VARPAV086", "AQAAAAEAACcQAAAAEAjwEf7xDIb+USJM8+8dKimMDkwSqvxZnD6wNxFltbOGcr7VZ5UD4fkVfY6c44jteA==", null, false, "f410e8b1-2850-4b97-a82d-23b68f488b03", "C00086", "Pavarde086", false, 161424476L, "varpav086" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440085", 0, "1b102c8c-ba8f-46bf-8bf0-19070b91d629", "Vardas085.Pavarde085085@email.com", false, "IFF-9/5", false, null, "Vardas085", "VARDAS085.PAVARDE085085@EMAIL.COM", "VARPAV085", "AQAAAAEAACcQAAAAEOSZV1bDyS6Xe1qncZE6a2yVBfrC5SCCrt6B79ALtNv0AIUVHAnwD6CtUqojJHSNnA==", null, false, "efe657c4-24cb-45ff-8113-628eaccbe988", "C00085", "Pavarde085", false, 196290491L, "varpav085" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440084", 0, "69acae7c-6fb4-4acc-8bc6-34a721fa0ba8", "Vardas084.Pavarde084084@email.com", false, "IFF-4/2", false, null, "Vardas084", "VARDAS084.PAVARDE084084@EMAIL.COM", "VARPAV084", "AQAAAAEAACcQAAAAEKQ0ai1IHgB4sHk1JXwMDBYKrHG5d7piiQcZnMzvwro3ojMrM0bqgCdPojh9YzFq9w==", null, false, "85e11069-ac75-4604-bd18-b70661520f05", "C00084", "Pavarde084", false, 143761617L, "varpav084" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440083", 0, "9696d437-c868-44f4-b98c-2240d6ee0fab", "Vardas083.Pavarde083083@email.com", false, "IFF-9/4", false, null, "Vardas083", "VARDAS083.PAVARDE083083@EMAIL.COM", "VARPAV083", "AQAAAAEAACcQAAAAEFQHgsssGCbgtzDAg9pMaFNC5kiSXBWfkZGR5rMNQh7qaE/oSY8UekCVJ5OBppwLzQ==", null, false, "8c2b26a0-8362-4aea-9e68-deed24df8fdb", "C00083", "Pavarde083", false, 142498536L, "varpav083" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440082", 0, "7031d955-9b68-44d1-b6f0-fda7795027f0", "Vardas082.Pavarde082082@email.com", false, "IFF-9/1", false, null, "Vardas082", "VARDAS082.PAVARDE082082@EMAIL.COM", "VARPAV082", "AQAAAAEAACcQAAAAENqVhF/pRMT0+Fk4TmNMpEJGB4nAjxHbNF0z6Sd7qhrUPRJ92gaweNgpctdJRlTpmQ==", null, false, "2c77f89c-bb90-4555-86c8-887e2c1cb46b", "C00082", "Pavarde082", false, 183495841L, "varpav082" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440081", 0, "c6eec202-7cca-4806-b452-0509c6e8b7bb", "Vardas081.Pavarde081081@email.com", false, "IFF-8/8", false, null, "Vardas081", "VARDAS081.PAVARDE081081@EMAIL.COM", "VARPAV081", "AQAAAAEAACcQAAAAEHtBoiw/eo/BJULBlO3CYsPH2DSld8dnIBmzb+k+g3B9WiNt6vUGIEgoU9Sq/0vUTw==", null, false, "8749a361-e26f-475f-a53d-ecd9dac1b50c", "C00081", "Pavarde081", false, 129885552L, "varpav081" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440080", 0, "6387beff-bf0e-4d54-b303-98113c7fadef", "Vardas080.Pavarde080080@email.com", false, "IFF-3/2", false, null, "Vardas080", "VARDAS080.PAVARDE080080@EMAIL.COM", "VARPAV080", "AQAAAAEAACcQAAAAEHkyTjRxAafz0RrVr3AXmz2GmdQlkI9JDuTcFcnozuHaBZlpBRelCz8HoJG/qcQxMg==", null, false, "cda9feca-79bd-42af-b843-040b88b25e88", "C00080", "Pavarde080", false, 157148923L, "varpav080" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440079", 0, "7a08edc6-c21a-45e7-a3a2-43b86afffe28", "Vardas079.Pavarde079079@email.com", false, "IFF-8/1", false, null, "Vardas079", "VARDAS079.PAVARDE079079@EMAIL.COM", "VARPAV079", "AQAAAAEAACcQAAAAEDO2kNobLaago9xmSBBy3Y8zsNAnO3hbhldvxXmMpRBfLtJHDw/dUCcLqZ9Bur8kmg==", null, false, "90b11926-672a-498e-b3a3-032377125f39", "C00079", "Pavarde079", false, 137282715L, "varpav079" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440089", 0, "9271da27-b927-40d2-9d63-5f98afc216a8", "Vardas089.Pavarde089089@email.com", false, "IFF-8/1", false, null, "Vardas089", "VARDAS089.PAVARDE089089@EMAIL.COM", "VARPAV089", "AQAAAAEAACcQAAAAEN+AbuxMxFsUkii5eOxPwO5jrAKSFf+JDrJ+Jhaxiawu6XOV96aKTnalbti8Bos52A==", null, false, "47f5744b-b4a7-4f95-9800-b7d8f6098005", "C00089", "Pavarde089", false, 195002474L, "varpav089" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440051", 0, "333c2cec-8d94-407f-b38a-04e6994d3ce4", "Vardas051.Pavarde051051@email.com", false, "IFF-7/1", false, null, "Vardas051", "VARDAS051.PAVARDE051051@EMAIL.COM", "VARPAV051", "AQAAAAEAACcQAAAAEOrZIrJfG4RUYJ+v7Cm+jjStV2N/35Hu8k/NL7ERV3C+DU2ouPlZiVEUBNLNOpXr5A==", null, false, "9b3e7555-ee32-4f40-96d4-c12f6dcc384f", "C00051", "Pavarde051", false, 193264865L, "varpav051" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440061", 0, "d77c2bca-e610-42e6-8868-e3de775f3bca", "Vardas061.Pavarde061061@email.com", false, "IFF-1/2", false, null, "Vardas061", "VARDAS061.PAVARDE061061@EMAIL.COM", "VARPAV061", "AQAAAAEAACcQAAAAEPsUBHWYDzzeqfH+8+YoIerdWETGrcPdk6/pqp1htSmjYtS/sTR9FhlBtHBdWIUfbQ==", null, false, "2acef57e-329e-43a5-9186-775b16391972", "C00061", "Pavarde061", false, 164779271L, "varpav061" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440049", 0, "91a2bc8f-4a66-4e41-a96f-a8e1a3901bc9", "Vardas049.Pavarde049049@email.com", false, "IFF-5/8", false, null, "Vardas049", "VARDAS049.PAVARDE049049@EMAIL.COM", "VARPAV049", "AQAAAAEAACcQAAAAEK7xaT6EDgelLyZ/ZiE5mdoFhNndrv+WiZ4K5O2MGndMW2icxhGD2kU67NcMfUVQQw==", null, false, "d2af0315-6cb7-4ded-b506-a9a1a2afb121", "C00049", "Pavarde049", false, 189929519L, "varpav049" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440022", 0, "07b1975e-b45b-49cb-9e5a-dd0222913559", "Vardas022.Pavarde022022@email.com", false, "IFF-8/5", false, null, "Vardas022", "VARDAS022.PAVARDE022022@EMAIL.COM", "VARPAV022", "AQAAAAEAACcQAAAAEJBUsXayEFJxsijLQCcgTMMFyl/uS/BaCWBKRwNABYHX1mOuEcLDw+slPA+LpYIL+A==", null, false, "16350818-75a6-4986-9ea4-b9d13673984f", "C00022", "Pavarde022", false, 131296926L, "varpav022" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440021", 0, "b53f6c6c-1e83-47ff-ac64-f71499dae429", "Vardas021.Pavarde021021@email.com", false, "IFF-8/4", false, null, "Vardas021", "VARDAS021.PAVARDE021021@EMAIL.COM", "VARPAV021", "AQAAAAEAACcQAAAAECHnCe7s+LpJQ1o/Dvn2AYLrrvKDqxYMLzMYiwBpAkO3BBbh0vZ2z68qro6WfjjKpA==", null, false, "0db801a0-98a6-410e-b17e-397f93aa2be0", "C00021", "Pavarde021", false, 166073672L, "varpav021" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440020", 0, "85429c64-2c45-4953-bd32-eb1dea91698d", "Vardas020.Pavarde020020@email.com", false, "IFF-2/4", false, null, "Vardas020", "VARDAS020.PAVARDE020020@EMAIL.COM", "VARPAV020", "AQAAAAEAACcQAAAAELXefzhwHNz9+Ngkq925AA4RPt/RO5dAhQPqeA9Cc94g6iVwHW5N89vNZ0WdkMQnFQ==", null, false, "6bacaaaf-3546-45df-9688-5db26b4da32f", "C00020", "Pavarde020", false, 156142141L, "varpav020" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440019", 0, "6b751099-3477-4045-8873-51b66bb7dd83", "Vardas019.Pavarde019019@email.com", false, "IFF-1/3", false, null, "Vardas019", "VARDAS019.PAVARDE019019@EMAIL.COM", "VARPAV019", "AQAAAAEAACcQAAAAELgLa0xISc8H59X/vN6hN42jQDI9dGFxvjOQTdxfDyQXBJaj/THLCztuLmPig29oPg==", null, false, "0428113d-a535-4dad-8b35-1e1c11ed35a4", "C00019", "Pavarde019", false, 130300504L, "varpav019" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440018", 0, "4db72b1c-30b6-4274-8d79-34d0c0827f59", "Vardas018.Pavarde018018@email.com", false, "IFF-5/6", false, null, "Vardas018", "VARDAS018.PAVARDE018018@EMAIL.COM", "VARPAV018", "AQAAAAEAACcQAAAAEAwZQFAOlM+a5jBjy8jy0xlkqlkY7DUyOShY/LJBcMGilqfQJEJe1AIebQTy31in9w==", null, false, "35e0667f-f891-4002-8b80-ee704e5a922d", "C00018", "Pavarde018", false, 153927409L, "varpav018" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440017", 0, "ef57ef82-f043-4715-9ba7-f8a77684b280", "Vardas017.Pavarde017017@email.com", false, "IFF-8/1", false, null, "Vardas017", "VARDAS017.PAVARDE017017@EMAIL.COM", "VARPAV017", "AQAAAAEAACcQAAAAEMR09g3rFLrD3ekF7dT7xN9UOH6HwzmQG1n8B+2zBnOju/kF27yDszl3BwdeezrT0A==", null, false, "b3e4e1c1-a0df-4d45-917f-d85879fd324e", "C00017", "Pavarde017", false, 195291546L, "varpav017" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440016", 0, "38d95207-dfcb-4c03-9781-c189bc31a16d", "Vardas016.Pavarde016016@email.com", false, "IFF-9/4", false, null, "Vardas016", "VARDAS016.PAVARDE016016@EMAIL.COM", "VARPAV016", "AQAAAAEAACcQAAAAELeSxsiWlPOPdnQ4qTtT2BtR81JgJsVr00eYRBGvrkuQJVXf434HaSs+Zx+3M8ZfNA==", null, false, "c3fe28aa-1840-4e63-96be-6f2206cd90eb", "C00016", "Pavarde016", false, 183192759L, "varpav016" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440015", 0, "ccafd3e8-5fbc-4674-9a64-e531a70900e2", "Vardas015.Pavarde015015@email.com", false, "IFF-8/8", false, null, "Vardas015", "VARDAS015.PAVARDE015015@EMAIL.COM", "VARPAV015", "AQAAAAEAACcQAAAAENEbXt3vOMt7kiee3X/2h44Gh/xZ+OPh6mZMlDWSkm6ysLlZJJLL+6gNd1s+ts3mmw==", null, false, "c9e22e46-3025-4e2e-b56c-d8b5382a4d9d", "C00015", "Pavarde015", false, 130260446L, "varpav015" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440014", 0, "c165e05d-8e94-470f-b911-8579f9363079", "Vardas014.Pavarde014014@email.com", false, "IFF-4/3", false, null, "Vardas014", "VARDAS014.PAVARDE014014@EMAIL.COM", "VARPAV014", "AQAAAAEAACcQAAAAEHqyvUWf7ZGEqPum6R5/7M0Fz1GorepJ2gonMd7Xb1N+fey4HAG8w5LDBa5lrO+/qw==", null, false, "15c1a780-457d-4eee-a599-368baf3ee852", "C00014", "Pavarde014", false, 179149192L, "varpav014" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440050", 0, "eddff634-ad03-481d-95e9-2266fcca4106", "Vardas050.Pavarde050050@email.com", false, "IFF-7/3", false, null, "Vardas050", "VARDAS050.PAVARDE050050@EMAIL.COM", "VARPAV050", "AQAAAAEAACcQAAAAELHtTJc3LlaxsGMn5BmcpFPyCZRCfZgKHzepCxL5JI0huq8bX5xWxeh98vBPg8yR+Q==", null, false, "bbe4d5ed-c6d4-45d1-892a-c4a6119b05ef", "C00050", "Pavarde050", false, 192239567L, "varpav050" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440023", 0, "b086c9fc-22ae-4ca2-b09c-6c131e071769", "Vardas023.Pavarde023023@email.com", false, "IFF-7/3", false, null, "Vardas023", "VARDAS023.PAVARDE023023@EMAIL.COM", "VARPAV023", "AQAAAAEAACcQAAAAEOyfZBbZc5hSAYd9Xi6m6F091ZUuTHdvTI8IdaipNriv1gOo/8aoi3yL6dvrGo4i9A==", null, false, "7c89e64d-9046-48ed-839c-ea8bac390b2f", "C00023", "Pavarde023", false, 104469511L, "varpav023" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440012", 0, "d5f9ed1b-62e6-477d-93e0-36d07280b376", "Vardas012.Pavarde012012@email.com", false, "IFF-6/1", false, null, "Vardas012", "VARDAS012.PAVARDE012012@EMAIL.COM", "VARPAV012", "AQAAAAEAACcQAAAAEJqr0Flhvb5vR6onePP9M0T0MCsSi6lssm25fQ24+0CKUMU78iHIH9anjX4KDvFyYA==", null, false, "c0915609-8f67-4f4f-bd15-f73f315de7d1", "C00012", "Pavarde012", false, 161007823L, "varpav012" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440010", 0, "b106f87f-6fef-4bd5-9c16-326cb158b6a4", "Vardas010.Pavarde010010@email.com", false, "IFF-1/4", false, null, "Vardas010", "VARDAS010.PAVARDE010010@EMAIL.COM", "VARPAV010", "AQAAAAEAACcQAAAAEMs+ApSF7FETJ0iRfsnFU+OuZnymqf6AA8ZZZSWtMxxAcjkIdb0YDuhChvFj86+TnA==", null, false, "186fc594-d232-4b57-bd33-0441231a350f", "C00010", "Pavarde010", false, 110320204L, "varpav010" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440009", 0, "ff1c9665-0aca-461f-b38d-bd8859611962", "Vardas009.Pavarde009009@email.com", false, "IFF-7/3", false, null, "Vardas009", "VARDAS009.PAVARDE009009@EMAIL.COM", "VARPAV009", "AQAAAAEAACcQAAAAEAzAADVTD5SpfWfW9ozT03lxClgIyet+Zh3Ihe4hmdcedKVs8V/MfJeHV/PS06OmPQ==", null, false, "25ff27a4-cc12-4a98-a601-29af1eb647cf", "C00009", "Pavarde009", false, 188588820L, "varpav009" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440008", 0, "ae43a223-a292-4bb1-bfa9-c427a5d69bbd", "Vardas008.Pavarde008008@email.com", false, "IFF-8/7", false, null, "Vardas008", "VARDAS008.PAVARDE008008@EMAIL.COM", "VARPAV008", "AQAAAAEAACcQAAAAEOC+JdwAilECvvnuooAVBFU8cnl0u/DntPGpTcUffCuPbYNAlE0fx+y2YKp7/AF4Tg==", null, false, "99291754-61fb-4ca3-a6bc-0c66d1342b4f", "C00008", "Pavarde008", false, 164678597L, "varpav008" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440007", 0, "31ab5e8b-3f1a-4db8-88fe-76097ba23331", "Vardas007.Pavarde007007@email.com", false, "IFF-5/3", false, null, "Vardas007", "VARDAS007.PAVARDE007007@EMAIL.COM", "VARPAV007", "AQAAAAEAACcQAAAAEPyxo1LwNKQpoxmojdFvJ6Cc6dyzo9Op0+wMmoIpONcJu1JsliXtezqVFKZ0pex2lg==", null, false, "7341aec1-0a6e-4702-942b-55e605e8cd96", "C00007", "Pavarde007", false, 171930170L, "varpav007" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440006", 0, "68d0f161-004d-4c43-b020-27971992d967", "Vardas006.Pavarde006006@email.com", false, "IFF-3/1", false, null, "Vardas006", "VARDAS006.PAVARDE006006@EMAIL.COM", "VARPAV006", "AQAAAAEAACcQAAAAEKbgFQP117oMI/BdcEQPByfioamNL98XhnWmET93qt/cAglac/UvW1J8bsEj4RmiYQ==", null, false, "cd33c156-1584-4a0d-bbf3-3f39a6bbcbda", "C00006", "Pavarde006", false, 108863917L, "varpav006" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440005", 0, "1e88cd7a-0126-4121-ae38-b9d5a250d000", "Vardas005.Pavarde005005@email.com", false, "IFF-9/1", false, null, "Vardas005", "VARDAS005.PAVARDE005005@EMAIL.COM", "VARPAV005", "AQAAAAEAACcQAAAAEOQdb1ZaUA8rDnUwIWdEUPLEX7nKVetqUFAD2tw+4pLBb+BGRf3UUOe4fyxG0gm9gw==", null, false, "b8f2cd87-e2cb-4a9d-8e51-a3106cd9a049", "C00005", "Pavarde005", false, 129208103L, "varpav005" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440004", 0, "db99e10a-fdd7-494a-8eb0-8abd6afc2707", "Vardas004.Pavarde004004@email.com", false, "IFF-6/2", false, null, "Vardas004", "VARDAS004.PAVARDE004004@EMAIL.COM", "VARPAV004", "AQAAAAEAACcQAAAAECWlKufLfuB307YdTDQzeUWeD88bahSYB38eJLuXL1thyB26pxteYSTjdN7w2oOv0w==", null, false, "3e450dad-931c-40fb-97e3-e22211402fea", "C00004", "Pavarde004", false, 167423359L, "varpav004" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440003", 0, "0a3b9031-9117-4260-ade6-42d682305af4", "Vardas003.Pavarde003003@email.com", false, "IFF-5/7", false, null, "Vardas003", "VARDAS003.PAVARDE003003@EMAIL.COM", "VARPAV003", "AQAAAAEAACcQAAAAEKqqrw2OyvxKAtsEahpde5fVYwoysw4zLmJhMUPER4YCK5P1WTfA+PeHw4nhK6U9HQ==", null, false, "b39cefac-09f4-4a13-8023-bed0355854f0", "C00003", "Pavarde003", false, 188176511L, "varpav003" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440002", 0, "8f6cefd6-c85c-427e-9b23-5efefe06c566", "Vardas002.Pavarde002002@email.com", false, "IFF-2/9", false, null, "Vardas002", "VARDAS002.PAVARDE002002@EMAIL.COM", "VARPAV002", "AQAAAAEAACcQAAAAEDeEh/6rmj73dpL4zxfDg5FTwCzMPJpDvE1f2stR+cyRS08q7+KBzj2rJcem6FgPpw==", null, false, "c8b93215-f38e-4571-a0c4-c8224019a1df", "C00002", "Pavarde002", false, 107389369L, "varpav002" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440001", 0, "8b9a0ae9-46dd-4bc2-89ab-89ee4af1d71c", "Vardas001.Pavarde001001@email.com", false, "IFF-2/3", false, null, "Vardas001", "VARDAS001.PAVARDE001001@EMAIL.COM", "VARPAV001", "AQAAAAEAACcQAAAAEMMtUkeRQfAGsvBXYkAURdZXM3eNELa2BfQppgl66G4mL/j7D3yn5QEYbVQ4crCUNQ==", null, false, "de585b52-25dc-4ddd-ae75-b2b631dc5a2e", "C00001", "Pavarde001", false, 169029520L, "varpav001" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440011", 0, "0a18a4fa-1b79-435e-b9bd-b79da1e4866a", "Vardas011.Pavarde011011@email.com", false, "IFF-2/2", false, null, "Vardas011", "VARDAS011.PAVARDE011011@EMAIL.COM", "VARPAV011", "AQAAAAEAACcQAAAAELUba1LI1ilDxDmXVBQMDcN+mseTJIdM9+fAfcWtHg2bpNnqNegxFXfu6uiPLgEWmQ==", null, false, "12d072d6-b488-4300-bab9-eab4e77fb948", "C00011", "Pavarde011", false, 180559823L, "varpav011" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440024", 0, "6737ccb5-71e1-4f5e-869c-bb402e7c2e83", "Vardas024.Pavarde024024@email.com", false, "IFF-1/1", false, null, "Vardas024", "VARDAS024.PAVARDE024024@EMAIL.COM", "VARPAV024", "AQAAAAEAACcQAAAAEFBHk3ipnTcZbMQhwjE4SNYv1/KwukBkimiRZki/jFHZwX2bCc4eXchPcbTcUd1YQQ==", null, false, "1d1cfb63-bb5c-41d7-a539-981100d52d2d", "C00024", "Pavarde024", false, 193434271L, "varpav024" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440013", 0, "abfb6f67-52b0-476f-aaf3-73dae7b928f9", "Vardas013.Pavarde013013@email.com", false, "IFF-3/8", false, null, "Vardas013", "VARDAS013.PAVARDE013013@EMAIL.COM", "VARPAV013", "AQAAAAEAACcQAAAAEGwHfMuYaE8QvyU4lwWNPdL+auFhLLEOz1gI2medMz0wKlcE/y5qMJnVcPhgwoH2Rg==", null, false, "1575f8de-8758-4459-93e5-6179ea2ea885", "C00013", "Pavarde013", false, 107067990L, "varpav013" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440026", 0, "68522f26-f9ea-4fb4-9a50-e9a9a9a5b30f", "Vardas026.Pavarde026026@email.com", false, "IFF-4/1", false, null, "Vardas026", "VARDAS026.PAVARDE026026@EMAIL.COM", "VARPAV026", "AQAAAAEAACcQAAAAEGpFewG14G5H7eRxdtpCPZTULmxUcgYiXnUPlo8GsPh03GvJ/Zs7IJKO74X5B3XODw==", null, false, "1e29c67d-3c14-43b9-a2d4-2bfaa6fb2c50", "C00026", "Pavarde026", false, 101451445L, "varpav026" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440025", 0, "32a0220e-0b70-4954-b460-b0940ba5623d", "Vardas025.Pavarde025025@email.com", false, "IFF-9/2", false, null, "Vardas025", "VARDAS025.PAVARDE025025@EMAIL.COM", "VARPAV025", "AQAAAAEAACcQAAAAEGZaILZ5nk1bZP7qEy38JcOUgpGtEYIHwynRz7g5GPCBB6if63/lYYPrSdOhGLoSyw==", null, false, "d1c83212-fdfc-4fa5-96c8-52047f6bab3e", "C00025", "Pavarde025", false, 124670962L, "varpav025" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440048", 0, "83048083-8508-4503-a916-cab8ab24ccd6", "Vardas048.Pavarde048048@email.com", false, "IFF-2/1", false, null, "Vardas048", "VARDAS048.PAVARDE048048@EMAIL.COM", "VARPAV048", "AQAAAAEAACcQAAAAEGCuQhAWLilyRUGPc8e9Wxtdjx2XcB+b1+RrIk8WX7RH2RluDEs9ugTkLFsc7lDiwg==", null, false, "fe5278ec-6628-4582-b6d7-0d9606d0e72e", "C00048", "Pavarde048", false, 117704848L, "varpav048" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440047", 0, "08d52890-5886-40df-b563-291cc3db4b7d", "Vardas047.Pavarde047047@email.com", false, "IFF-4/9", false, null, "Vardas047", "VARDAS047.PAVARDE047047@EMAIL.COM", "VARPAV047", "AQAAAAEAACcQAAAAEMJTmKuU4ObwvXP4TqMxXv4TAXtfSpZ6dZ2H0kl0hCNCnQiB57PxI6+mwL2eBIlRfg==", null, false, "e9d9f90f-097c-4ab5-b696-bed036c9eb46", "C00047", "Pavarde047", false, 139055655L, "varpav047" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440046", 0, "135d2cfa-7d01-496e-b0b8-c0249a6254bb", "Vardas046.Pavarde046046@email.com", false, "IFF-7/2", false, null, "Vardas046", "VARDAS046.PAVARDE046046@EMAIL.COM", "VARPAV046", "AQAAAAEAACcQAAAAEMyKFKn2DmHRVhqHXZWWFAA+YKHMnTq/qVcDUqGPBj3TF9L0coo5w7oWAldmW0MzIw==", null, false, "83dcef51-7f5f-4b75-a9e2-9f5a04baa1bc", "C00046", "Pavarde046", false, 153212958L, "varpav046" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440045", 0, "edb9a684-546f-4a96-8868-635122a1b333", "Vardas045.Pavarde045045@email.com", false, "IFF-5/3", false, null, "Vardas045", "VARDAS045.PAVARDE045045@EMAIL.COM", "VARPAV045", "AQAAAAEAACcQAAAAEHdxKuw6IOk1aXpSMIaqwfw7P9nTsZHqKF/4CUx49Dclz6yPwfc3S2NQqYOM0D1TQQ==", null, false, "f249cb14-4de0-49c2-9908-7678e3938f1e", "C00045", "Pavarde045", false, 102184845L, "varpav045" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440044", 0, "c673cb47-53bf-48be-ac88-1930d8555cfd", "Vardas044.Pavarde044044@email.com", false, "IFF-1/4", false, null, "Vardas044", "VARDAS044.PAVARDE044044@EMAIL.COM", "VARPAV044", "AQAAAAEAACcQAAAAEEoyc/yitfoRTtSPghTsdSEM89y+6pOEN1OBJS68Jh5NFESqLYGUYQQ7K68BaOmkpg==", null, false, "e9365042-e589-4f79-93cc-1ada94af91d0", "C00044", "Pavarde044", false, 156680870L, "varpav044" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440043", 0, "73d5a392-49ee-49c4-8403-2d3258768de2", "Vardas043.Pavarde043043@email.com", false, "IFF-9/8", false, null, "Vardas043", "VARDAS043.PAVARDE043043@EMAIL.COM", "VARPAV043", "AQAAAAEAACcQAAAAEExc9H18/MvGzgYKNGRtfhgW+mHwMpMkll8UD7gaGeTUT1HODT6aBDvG4KTlFx/JXA==", null, false, "a4d7fb98-b838-45cb-b33d-b8eb7b8d3c9c", "C00043", "Pavarde043", false, 100257250L, "varpav043" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440042", 0, "b0e6eae0-03fd-44a1-90d1-23a705ff0eac", "Vardas042.Pavarde042042@email.com", false, "IFF-2/5", false, null, "Vardas042", "VARDAS042.PAVARDE042042@EMAIL.COM", "VARPAV042", "AQAAAAEAACcQAAAAEKksZRvc3TjjQerM3gSG3D4p2aTUECkjP421AWPMfrmtlp3RwC5TVOK5+fDeCnV6PQ==", null, false, "eda0054b-5021-4298-bd62-f7db0bb187a0", "C00042", "Pavarde042", false, 166403411L, "varpav042" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440041", 0, "34cb3139-d069-46a5-9f3b-1d8958b52beb", "Vardas041.Pavarde041041@email.com", false, "IFF-5/4", false, null, "Vardas041", "VARDAS041.PAVARDE041041@EMAIL.COM", "VARPAV041", "AQAAAAEAACcQAAAAEHf+Dw7ZhD98t5RhLzx2AiO3YIzUme8sTgf3rTcUaOjpgayTfDRgNHz+GURdNWTfjg==", null, false, "2aa8537e-ad45-41eb-acc3-3d2a0b9e1db2", "C00041", "Pavarde041", false, 173187026L, "varpav041" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440039", 0, "e73726f8-25d4-4a81-aa14-a43346e25eb2", "Vardas039.Pavarde039039@email.com", false, "IFF-8/6", false, null, "Vardas039", "VARDAS039.PAVARDE039039@EMAIL.COM", "VARPAV039", "AQAAAAEAACcQAAAAELZ/yWax3JwjGZ9EE3mLQhgDXD6uuF+PRzF4aGgP3dElobMZhrGPbfZz1Z9Fi1ZQZA==", null, false, "24266898-eda6-4859-bb5a-bf69be6c6c41", "C00039", "Pavarde039", false, 163468477L, "varpav039" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440038", 0, "7f945c72-2eec-4787-9848-48dab7fab7fd", "Vardas038.Pavarde038038@email.com", false, "IFF-6/2", false, null, "Vardas038", "VARDAS038.PAVARDE038038@EMAIL.COM", "VARPAV038", "AQAAAAEAACcQAAAAEEf8fexLpbgywL5KE8e7fk5fvD1w5SLqBnEmaatTqxGs5dlrjRj0+Aab6uJUZWuqtA==", null, false, "4c8183b9-71e0-4a3e-b63c-e73011e755a8", "C00038", "Pavarde038", false, 129042796L, "varpav038" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440040", 0, "8327af62-aa2b-473d-a4fa-f259ead06e1f", "Vardas040.Pavarde040040@email.com", false, "IFF-9/6", false, null, "Vardas040", "VARDAS040.PAVARDE040040@EMAIL.COM", "VARPAV040", "AQAAAAEAACcQAAAAEEKBYiqOQfOTgB/1lgD4ODuKNkOe+glw6JxGHEdc7hViyBGLQDUfdxgfe+9BvvsqfA==", null, false, "efa2a1c6-9cda-442d-9096-b0085ae523bc", "C00040", "Pavarde040", false, 113414600L, "varpav040" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440036", 0, "3c1d7a57-7d39-40f1-9733-e0a0e54cda06", "Vardas036.Pavarde036036@email.com", false, "IFF-3/5", false, null, "Vardas036", "VARDAS036.PAVARDE036036@EMAIL.COM", "VARPAV036", "AQAAAAEAACcQAAAAEK9fyGUd+wMvKhAY4hKCguFFeQ4HWMJE/suHBR13cvhgwEluZdyonY11/ovVUM71xA==", null, false, "ea89eec4-2574-4873-a49f-4babbb66880c", "C00036", "Pavarde036", false, 100783882L, "varpav036" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440027", 0, "aa586313-fd89-4431-b4e4-6e44acaf7d0b", "Vardas027.Pavarde027027@email.com", false, "IFF-1/8", false, null, "Vardas027", "VARDAS027.PAVARDE027027@EMAIL.COM", "VARPAV027", "AQAAAAEAACcQAAAAEH8WnDXcK+vvjUKA/pxdvGdaW9n94YEuaXRpEzHH/uhKb5TXB8k8FJvO/1/0xnB+Qg==", null, false, "a04a4a23-00c8-4ae0-8338-e08b5dca6227", "C00027", "Pavarde027", false, 191307101L, "varpav027" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440028", 0, "487d01b7-15a5-4c54-8ede-5a8fc89f67fc", "Vardas028.Pavarde028028@email.com", false, "IFF-2/3", false, null, "Vardas028", "VARDAS028.PAVARDE028028@EMAIL.COM", "VARPAV028", "AQAAAAEAACcQAAAAEDP1Z0uDm1BflBN78p2jDs+dIGwSCuiopSHzjZZy+EkRPNhBgM0TWGyOrkAvbN/8FA==", null, false, "aff81572-b97b-4303-a53e-151648cd4c55", "C00028", "Pavarde028", false, 186137399L, "varpav028" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440029", 0, "438c5a6b-c273-40a9-8a7e-68120b57ccb6", "Vardas029.Pavarde029029@email.com", false, "IFF-3/7", false, null, "Vardas029", "VARDAS029.PAVARDE029029@EMAIL.COM", "VARPAV029", "AQAAAAEAACcQAAAAENuV2MDHjK5j68ERUxTy3pT5TwYFTgOiwoL5T4RMVPnbbhkKX3kVQK3IMuzauVy0rQ==", null, false, "5d1f14fa-8a26-429b-af58-ca4545349688", "C00029", "Pavarde029", false, 137581082L, "varpav029" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440037", 0, "6d2b745f-52a8-4cc6-a453-6d1f41365b38", "Vardas037.Pavarde037037@email.com", false, "IFF-3/7", false, null, "Vardas037", "VARDAS037.PAVARDE037037@EMAIL.COM", "VARPAV037", "AQAAAAEAACcQAAAAEJ6UEBeMQG6enVPL04AsNAGMYM52Zv6mFJnzgruBPq/D7Ukk8xx5c5MHC7MDB4smtg==", null, false, "090cacf2-81f6-446a-9907-95c37a626cef", "C00037", "Pavarde037", false, 146030415L, "varpav037" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440031", 0, "930fdec1-c12c-420f-ba53-f9768d56ed7b", "Vardas031.Pavarde031031@email.com", false, "IFF-5/1", false, null, "Vardas031", "VARDAS031.PAVARDE031031@EMAIL.COM", "VARPAV031", "AQAAAAEAACcQAAAAEDJ8NP0sglMclzMMqKl0AJPBB9gPA3Vyzc6zn6sYHW/1fsy1Wgqy/rqVeejcS0nrXQ==", null, false, "6bd766ad-2837-4910-9035-f2ad1e225730", "C00031", "Pavarde031", false, 180365033L, "varpav031" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440030", 0, "562435a5-1c92-49ad-b102-01457867865a", "Vardas030.Pavarde030030@email.com", false, "IFF-3/6", false, null, "Vardas030", "VARDAS030.PAVARDE030030@EMAIL.COM", "VARPAV030", "AQAAAAEAACcQAAAAEIq1a2wEcuj58leg79krnMga8UWUJ+w+5MN/o2DEnDMCi9BVSobBInNWhvtX8+FZTw==", null, false, "31a35bb2-16ff-44e7-a76e-00d59b9c5deb", "C00030", "Pavarde030", false, 157603993L, "varpav030" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440033", 0, "696e3cb8-5819-46ea-b7f9-106b7ec8ae96", "Vardas033.Pavarde033033@email.com", false, "IFF-9/9", false, null, "Vardas033", "VARDAS033.PAVARDE033033@EMAIL.COM", "VARPAV033", "AQAAAAEAACcQAAAAEDlqSb/k91xpDdqS/Hic/yYcOBnEnm5v2f5fvgWlEufa4qvPcw5MO63mlli9Eh9lxA==", null, false, "035d2ea6-f138-472a-b73f-1022fadf24c5", "C00033", "Pavarde033", false, 190918011L, "varpav033" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440034", 0, "7f5658da-3bfc-4d3f-9307-b81bceb7f1b9", "Vardas034.Pavarde034034@email.com", false, "IFF-8/3", false, null, "Vardas034", "VARDAS034.PAVARDE034034@EMAIL.COM", "VARPAV034", "AQAAAAEAACcQAAAAEKbjqiEhPwgoI16p65O6El06ZNhQD7pLMFRCFlPQ7iCYUmnO0pk8TV+bz2M5WwaHJA==", null, false, "67d64a27-49f2-4724-8d25-2b0e4dadcede", "C00034", "Pavarde034", false, 136555831L, "varpav034" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440035", 0, "39d5dc1e-0fd4-4445-a11b-268050f9eb23", "Vardas035.Pavarde035035@email.com", false, "IFF-1/8", false, null, "Vardas035", "VARDAS035.PAVARDE035035@EMAIL.COM", "VARPAV035", "AQAAAAEAACcQAAAAEJ7Pcw6VgJ94UAALp3Tt2q0cKzcPNQskTURCEcC+FI3vKoDvhn5+OpnluAWgZ+Dszg==", null, false, "514b4349-e6ab-44f2-9a25-f0048d1efb18", "C00035", "Pavarde035", false, 117639859L, "varpav035" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440032", 0, "64be3881-0c6c-43b3-b8a1-89227e917ac2", "Vardas032.Pavarde032032@email.com", false, "IFF-2/6", false, null, "Vardas032", "VARDAS032.PAVARDE032032@EMAIL.COM", "VARPAV032", "AQAAAAEAACcQAAAAEE/NoA7Gq8N/hglap4MbgKjeZbZjPtULymdqreNUqp80a7/u2tbjIvCmvUPXLIVG6w==", null, false, "8b6a2b70-cfa2-4a7b-9c2f-91273cf15a26", "C00032", "Pavarde032", false, 134904838L, "varpav032" }
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
                    { "a18be9c0-aa65-4af8-bd17-00bd93440058", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440057", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440056", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440055", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440054", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440053", "STUDENT" },
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
                    { "a18be9c0-aa65-4af8-bd17-00bd93440059", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440049", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440023", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440022", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440021", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440020", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440019", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440050", "STUDENT" },
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
                    { "a18be9c0-aa65-4af8-bd17-00bd93440018", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440027", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440048", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440047", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440046", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440026", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440044", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440043", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440042", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440041", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440040", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440039", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440045", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440037", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440036", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440035", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440034", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440033", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440032", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440031", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440030", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440029", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440028", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440038", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "ClassroomId", "DeviceIdReal", "PendingDeviceId", "updatePending" },
                values: new object[,]
                {
                    { 3, 13, 3, 3, false },
                    { 2, 5, 2, 2, false },
                    { 7, 4, 7, 7, false },
                    { 6, 9999, 6, 6, false },
                    { 5, 9999, 5, 5, false },
                    { 4, 9999, 4, 4, false },
                    { 1, 3, 1, 1, false }
                });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "ClassroomId", "CourseId", "Date", "LectureType", "PeriodId", "StudentId", "isVisited" },
                values: new object[,]
                {
                    { 9, 4, "PB0001", new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 1, 9999, "PB0000", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 1, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 6, 5, "PB0005", new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 1, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 2, 3, "PB0001", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 2, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 3, 5, "PB0002", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 3, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 4, 3, "PB0002", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 4, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 5, 3, "PB0001", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 7, 4, "PB0004", new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 8, 13, "PB0005", new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 10, 5, "PB0001", new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440002", false }
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
