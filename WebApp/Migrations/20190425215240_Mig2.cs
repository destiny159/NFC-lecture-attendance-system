using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Timetables",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LectureType",
                table: "Timetables",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "71fcabb2-c948-4413-9163-1b817336fa82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "d7bfade1-991e-4fef-a83d-10476e4471c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "4010d534-9bce-484a-b044-7695d5b26ff6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440001",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b2e3a0aa-4b70-43b9-8959-cc0b5bf175eb", "IFF-1/5", "AQAAAAEAACcQAAAAEHkjw10+3pJn7Q1l3Ay0yBE+gAGaatXid7NQcvKqFQnGu/HV/rmd2Ed3ecqDaLOFbg==", "62fc8536-2dee-45a4-ab76-977c13c9c119", 183302670L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440002",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9a9b6656-70e2-417f-bd0c-d54ac9c24dcc", "IFF-6/9", "AQAAAAEAACcQAAAAELP6QwhbPH+mECeoOhylfnOXSTmfmZKxdj6y13xTYodAM93ih4wprzQfYRbBxcIPXA==", "3d555451-1b62-4804-bbdb-a3d7c62ce223", 100933322L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440003",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fe1a1d08-f268-4bf5-9a5b-10bcae2b5476", "IFF-1/2", "AQAAAAEAACcQAAAAEIxFyqJ8rKrS8WztTU484JWZT2h4gzucwuuSvs4bzJkgG+BNZ0VrgJjrDakER4qchw==", "3f919277-2dcc-41f7-9951-92b96275d332", 130784421L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440004",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ff294167-9856-4282-bf42-fa76e9b7784b", "IFF-9/5", "AQAAAAEAACcQAAAAEMRmReEcQuYrZ29d415wVsUr3Xp881qh2npq+CKHsRtMXO3bkZhXaFVvSLpOgO+fMg==", "861493bc-e1e7-4ae9-ba13-ddb90d12970f", 155022852L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440005",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bb2fa736-3cfa-4c23-af0e-137d922c38cc", "IFF-8/9", "AQAAAAEAACcQAAAAEL/CAqK6W7BPUs62NLwXq5dYjvuqD+QvXZs60mgatUbvyJYXYEGbmrUsYepDBsX6YA==", "0f354895-6471-4c7f-83f0-4b14c685d509", 106224340L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440006",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a0fb897f-4513-4dbf-aa83-8a210e2fcf77", "IFF-6/1", "AQAAAAEAACcQAAAAEPf9bkMP0VNEMTH9M0LJLxxNsjhNl2ELIzfcqzRwzurqHpaVPwgo4zEh9yEXoFt+Ag==", "b1ddeff9-7325-42ce-93e7-9198eca91297", 143940699L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440007",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "72d14aed-fd63-4638-9b64-9fea30621725", "IFF-3/8", "AQAAAAEAACcQAAAAEALeDGs07qoYLX0hOpccpc7ly9iJT351AEUAqK1KbLooqfflxHl8BD9XkvSOxKI0vw==", "50aaa450-91f5-4052-a5e1-86e199ac69e0", 180776443L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440008",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1528027f-5397-49b6-b7b9-6ca86c8aa778", "IFF-4/7", "AQAAAAEAACcQAAAAEFju0GYiIWr0H/M8K9ttH0+bqqpYwxx43e9W3WM44R2d0Qpw1/JDcZ4XDIpSxsLXVA==", "b5939347-2a2f-4a52-aa04-d39aba7c0706", 127833328L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440009",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "56865702-565a-40f0-92b1-58dfe8ccbe6a", "IFF-3/4", "AQAAAAEAACcQAAAAEJxkj3SDNlmVzWZ5s/6MelK9nFd6btWgfkw6+NSwv2L9Vuhts0VdlLOL8SxBTVV1fw==", "17e98232-df93-4339-8262-22441a4d01e7", 158545688L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440010",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0d2806cd-03dc-4b4b-8527-9607ecc887dd", "IFF-8/2", "AQAAAAEAACcQAAAAEJrgdvLjCeuL0ErBMWYguVB10xKKCQqdaPcma+LLZPeCIYJi91jQopx1XfKa5qQs9A==", "bab85186-c42d-45c0-b601-7525ec084a7e", 189590958L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440011",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "de6ceacf-8e08-490b-bdca-4937ae2de428", "IFF-4/4", "AQAAAAEAACcQAAAAEKImbl3yjlKsxSwLSFRNBpT3KdomjyginIx0WJJcwF3fyPc9KAq0SNptdcYUEHQLUg==", "df595ecf-162c-44ce-9894-c44b198ace6a", 101976848L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440012",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7d16b6e9-d7fa-4344-abb7-097420180662", "IFF-8/5", "AQAAAAEAACcQAAAAED0Ahc+xZDZAicjBLKkeh9WD0XwsOP7xoIWYQVFPHUOK0apBA9gBXr5eRalblmVUtQ==", "4d24eda5-f815-4cbf-895f-bb81e336e0ef", 151029106L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440013",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "92e7c8bd-4a6c-4ed2-8b53-2ff3bd121890", "IFF-9/8", "AQAAAAEAACcQAAAAEI5jfYiEE10FZHRRYLYb6L0OCw+sf/tt2HPoRxe+5KHsiwOpOvpEIMeDN1acng07vQ==", "47f394c0-fe07-488a-9a32-5fad56cc9e60", 180785622L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440014",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c4b0606c-23bf-4dc7-a792-9d7bf2dd9581", "IFF-3/3", "AQAAAAEAACcQAAAAEFzRwXMVuHxAMpdWHAiPBsqFWG3sM0WbpMt+FrtAQnytWCEmt6fpOS7PfvpXpKb3ZQ==", "17c08bcc-f445-48e3-b718-933bb3b801e2", 140103643L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3f27d24b-6661-47ff-9de6-26522d8e12e9", "AQAAAAEAACcQAAAAEMPFgz21c7bNG5YvZf/ZTJ3bBwY6IFEvIeH47Ae95B3QXO/e4+EUmOJdjW8u74r82w==", "32c5f8b8-c97b-46f4-8961-7ea3896e5552", 146791232L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440016",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8cbdebe3-28e2-4f28-aa60-328ccda89dca", "IFF-4/4", "AQAAAAEAACcQAAAAEO3bb4QXP7++u8BeGR5LgzYQQeeX0h/B32m9UYl5BbqQHT3WiUmn3u0PTsOpy3Y+bg==", "c0977445-169f-430c-8e48-39369b5ff152", 186614087L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440017",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "33a82d2b-cbde-4fcd-9693-bc11c570460a", "IFF-2/9", "AQAAAAEAACcQAAAAEGylYwDkvQwbFOGfJRwL6DrzkwdeAApYwZj2VOxrbuSx3K3dJFjWUaznI3/A8junTA==", "809120cd-abb4-4ea3-aaf5-20e06464eda5", 173022434L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440018",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "78ed3bca-158b-478b-8fc7-8134476c2dfd", "IFF-8/1", "AQAAAAEAACcQAAAAEJl1F/dxIp5XM6GjTwbU8Ncdd+/aPZHk7XP4byaK47/bhDShXC/IPQeWIQdrsowNYA==", "8797bcfe-284d-4f28-baf6-987d7b84c1a9", 196846334L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440019",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0aa9f08f-7acc-4ce5-b85f-e5440c039636", "IFF-5/7", "AQAAAAEAACcQAAAAEDNvZd4NVgh6HAQWY5YUUK7d/w8BEb2W5eFaQYrF5daW3fLzPx3sTZS3tBymjIKnMA==", "d8ea7b5f-4742-4ad4-b5f5-c0b8135e39b6", 106568029L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440020",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6d7b3452-9159-4f4a-994c-e3ed9804577d", "IFF-4/3", "AQAAAAEAACcQAAAAEK+dqAdSXM4JDBvxt2DXz4ThcoNLq3G6YUGYruZ6NionloGL0VUmsN30uFVVCKn/zw==", "42d623e1-64f9-4fd4-9520-d0726fa525f6", 174359853L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440021",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6d0a8983-4438-4e51-8e66-39bfd913d171", "IFF-4/3", "AQAAAAEAACcQAAAAEE5xacOV9QnI848/lmZQ2rur1+aou1qO5mlVHohzTOZFuBS7dcD6NW5jNq0zRstlwA==", "200092b6-cea1-42be-8abe-79eb96ca27a3", 151884473L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440022",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4afb506d-9153-47f7-99fc-049fa73265bc", "IFF-5/5", "AQAAAAEAACcQAAAAEISBXXn5p9xJd5zLey5jRTUsTqDZvVp50NrRMpHsKIsiHVCpvg6FWbpE92hOc0vQMw==", "67299810-07ec-4223-992a-d777a95b72ba", 198856186L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440023",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "80cb6fa9-8705-4057-a5d1-a175e29ddc76", "IFF-5/1", "AQAAAAEAACcQAAAAEB/oHz2jhB0K03WrUYZ1i8RP3ZkraRPAdHGqqNbrDImQQNVgWbDgjrbesVmn1kj9Ww==", "64dc64cd-f7ff-4ebf-9dd0-995564fb5deb", 105129500L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440024",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "20e1b2b1-8ad2-45da-9f0c-d30d0975ed92", "IFF-6/7", "AQAAAAEAACcQAAAAEArQORcM4Gamydxkv+M9BooOv7dleLx+xorbzhFKpU8t9oifaAgtAGVT9TA7evb6iw==", "15812d4b-677c-4b01-9be2-85cd276d6c33", 146314710L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440025",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "878b02f1-6873-439a-b629-a27285b575cf", "IFF-4/1", "AQAAAAEAACcQAAAAENXXvnWxJDMI9wIlhrfuVjh8TsmthyrEYVmDuKpW2dMnDHJZlmAhg/+LgKKXApELxQ==", "1399c8f6-973e-4830-adca-056c81e68ffe", 121125763L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440026",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "69af4ece-06b8-44ee-96cf-5c1d8a670d81", "IFF-8/4", "AQAAAAEAACcQAAAAENvgs3YFjRn0mNH/e0aOTP0Waw30YeH4JC8xi7R/WxdP97kNUdVo+JJ9Z6yZzoqabg==", "cd74289a-3b27-4680-bcdd-d3b7d95e536a", 162324999L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440027",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d7b98343-af31-498f-ae9f-dce6597915fa", "IFF-7/9", "AQAAAAEAACcQAAAAENnj76dBXjTxiHPat09dVpKxqnzLH0gc8NgotZ4nb+lvaqaYDPcLDb7wsBAi/w0RMg==", "2e584831-fc35-4f1f-8faa-25c022d05afd", 196022801L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440028",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "64ece68c-ed00-48f3-8612-b6713d24877c", "IFF-2/6", "AQAAAAEAACcQAAAAEHUYyfYkQg4VNFCJgJD3Xw8URKLKHlq5pi0DqCu3iifPBJSF78JXia5GbBJmCCpALw==", "2336fa31-ab24-4191-8439-8470c9583afa", 100448645L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440029",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3c61a925-0dc4-4447-8491-01e191884239", "IFF-1/6", "AQAAAAEAACcQAAAAEGlgU2BfV5YpeWvGjShiev6qFYY40ncAcCrOcYBjUm88D+xjogSlZBDoB+wt9lWmgQ==", "70ea60a6-eda3-48c6-896b-c29523253a06", 119519396L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440030",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "11a02c31-376c-446b-a40d-6d2cbcecd98a", "IFF-5/3", "AQAAAAEAACcQAAAAEDZcnpi0edzXU1UlozlNQ7P6/rGFkf9rkd9KedeJ3wjSD2zpsMWuxNY994tkt72+zQ==", "3510c2ad-d111-4dcf-8916-6eefd57cd482", 138792885L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440031",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3962d6c0-456b-46e3-b0fc-b6f9b9767b05", "IFF-1/5", "AQAAAAEAACcQAAAAEJRSr+eVLfLLmgW3HxLF9gWiZAiInjJ7MSItp0vsKNBiCijzJZ4xc2m0GZltZIRVXg==", "f3583279-817b-4c82-b842-49363266fea5", 183210745L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440032",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3b7defc6-cb45-4ffb-a938-1315f3db798f", "IFF-8/8", "AQAAAAEAACcQAAAAEIim/TFTtXGuhykHOmBWQNET6nPuuApUOgYNbgiBmg5ph9N50KqXR+CN/cHVL08LHQ==", "1ff513f2-b727-4551-9d41-c6fc66165187", 148341906L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440033",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "93f67154-74f0-4fb4-918d-b6a7d0206454", "IFF-5/5", "AQAAAAEAACcQAAAAEGEdciZhnDvTYpmBksowmEtfBc5laRJ+85KPBl5Z2aOCUa8R4x+N2gts102bVe9NRg==", "13461876-fabf-4796-8861-44fa5b1f7c51", 197008616L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440034",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fd31232e-af65-42af-a0a8-3ab45bcec3bb", "IFF-8/8", "AQAAAAEAACcQAAAAECuGvW/59Hb8cc7v7tgcog3VT/tLp3dL5owQOEOZOSe5kfqyAzTv+1uyPWW9+NjKcg==", "5fce37de-b9f3-4cfe-839a-56404c4c20a4", 129973915L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440035",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "711d67ce-1ffa-4c54-a620-1805bbba0fce", "IFF-3/5", "AQAAAAEAACcQAAAAEGrs6EYIVNx+Dpxck9Qe35zX4KXhGFekENo5ICbPfx4hjZPmWzGIF+EJMDIBxnytdg==", "b437579c-6434-4a2c-bae5-f3824f66e0a6", 131720435L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440036",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f69d4d32-aa62-4b5f-ae51-66d1f333cf07", "IFF-7/4", "AQAAAAEAACcQAAAAEJINkOdwN35PS5qfw9oVp6r2+1y3ZOmgGOrvOatr+nEyiJFQCj0VPMuzRCP8RhTVgA==", "5b841fbc-8757-4844-8b13-7dec9c36f25e", 126582216L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440037",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c626ce70-edb0-44f7-b99d-a8dfce778970", "IFF-4/7", "AQAAAAEAACcQAAAAEIpgbkLot367LSsZrDPHys2PQBjRiUULAL7lOvNC9F13OLRdDeNTJTGGBNTxy34rMA==", "0bd1c578-5416-489b-89b0-40ab2ed550f5", 100077894L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440038",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5608920d-df27-40e5-847b-a07ea5b4182b", "IFF-8/7", "AQAAAAEAACcQAAAAEGkzt0XmEJmOUWPjcW6ai7FY3R37fjGv49WEo1fFph9xbFDeZwrcfSMpmzBbPYiozw==", "421f1d04-12ec-4c40-96ee-f770529c7e37", 134114176L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440039",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "55ffe0df-22d8-4f01-80f6-ab26e5d7d5bc", "IFF-5/3", "AQAAAAEAACcQAAAAEBgjbTJKVxee5o1zpR/nNOKaUI+UVWujtuMxwIWmmays8t7t05fK/GPTv/EVAAANyg==", "202be87a-b03c-46f6-be4a-eba7e02d2a05", 140172519L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440040",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "dae5da4c-f381-42e9-af54-0fdde87bf90a", "IFF-8/5", "AQAAAAEAACcQAAAAEGePOs1P/WRDPneEe3JyLrc2VDeBEhrFTndFeqjwC3Lo4527uONDaa5aH4KQaDcQZw==", "ad15a6fe-7ec7-40c1-b95f-098dbb4358cb", 160734126L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440041",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2e2241c4-8aaf-438a-9b1b-7bac483ac851", "IFF-6/1", "AQAAAAEAACcQAAAAEJhH6MhXUT52f19N87hMjOxMp8dcY4JNh9iZw7zR4dP/LG4QeCCAoqegpLFYDQpINA==", "a83e4cc9-6131-40bd-b5f8-075a2675e0a6", 186995213L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440042",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d9adea27-cb50-4195-8c09-d085615cf534", "IFF-6/6", "AQAAAAEAACcQAAAAEJiZfnEEu6r15Qv/8hzZ/agh/Fn8i2WnWKTZDKKOIHV8skSgj9BLw7xF9chAnRZIeQ==", "9412fd76-1cdf-4ae1-a941-f6181efaca9d", 184018663L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440043",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "707b130c-6ffe-49ae-93cb-3b26e3fd340d", "IFF-7/5", "AQAAAAEAACcQAAAAEDrU/RaJP2zthV95W4kZLbA+mwddsWs3yYAuJBXB+A+4LZKotY8z5CRFv04lSAHJfQ==", "79ebb9b9-4f77-4c45-9376-754f2411151d", 113354610L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440044",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5f2d17a4-c264-471b-b4a6-a8518c7162f6", "IFF-6/3", "AQAAAAEAACcQAAAAEDqsbzSYSZnkQxmMuXFTaAygAO/o+jrZ5E4Xg+olKLQyoVY6BdVzOt38mTOl3Dc1Hw==", "0772f73d-41f0-4950-883e-83cf2752ab66", 115162330L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440045",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3771200a-f4b0-481b-bbf0-064ae7423535", "IFF-6/9", "AQAAAAEAACcQAAAAEOkhVlVqXP+1FX/eRnfN7xAO8ZlO3jD3ohNYzrJh/RJYtJUpKNPEqbb5XjHIQDepsA==", "3d2a695c-7ff7-4ef4-a854-7b46c34591f7", 187984782L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440046",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d236712e-6c63-4e6d-94b4-33ec25a213fb", "IFF-7/9", "AQAAAAEAACcQAAAAEKAfYOmKWI2EmNxU/lB4OpqLe7etTLt78pFA61MyP1QR+w6OKx7qxEF+YgMMQNwbTg==", "6b80d4c6-ebe8-4ecb-9db8-02badc8370e2", 105820520L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440047",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "535d2dde-f43c-4309-98bd-71b4f74fc122", "IFF-9/3", "AQAAAAEAACcQAAAAEPMD2JTvZXqohclWGwMqziXYy9eTvsul0WXWggXYVZuTrceO8j3CTi05BIDyfVgaLg==", "ca84ba52-2e72-4c5e-95dc-88bee77f70a4", 114353851L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440048",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2df1337a-aa62-4599-a439-92bb68962a62", "IFF-4/1", "AQAAAAEAACcQAAAAEAOBBqssux+uStYyQeDdfbnMe232Mw/K5eYy4X4b8/foyJk5FmN+DFlx1xQc0s3v9g==", "6f90aa69-f10e-4c27-9cd4-9c36d78b5753", 121667378L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440049",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1571b920-5d72-4f9b-b4b6-82a0f163f0ee", "IFF-5/3", "AQAAAAEAACcQAAAAEPppKlchvgiSPkEJJQUVmDzr531r5UQ+x+5wl5EqObNu0yyk7wPpGEiS2VJXyoBz1w==", "05206d57-8537-4fae-a3ed-d002c9de9e0e", 149153162L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440050",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "861dbefe-4f77-406b-8ad8-311a88647076", "IFF-1/4", "AQAAAAEAACcQAAAAEASsysYRJ2H3BBzdPGE8IHJD7O3akN9PVc/km5aaiO4YPlrJFG8OCmZ+P3Wq8QZp4Q==", "c55b0e2d-45fe-492d-9fe9-70e35eecf72a", 183443290L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440051",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "60955d3b-2912-4e81-8177-bfb62100e0bb", "IFF-4/7", "AQAAAAEAACcQAAAAEG9jX3EyAVkHI+ueFOjxSEHQG3pQT9aYzHB58Gh+ftEmjOiXG5Y+gwEEUGPhTJj0Qg==", "1815474a-5f6a-4142-a4cd-a316eca0a7e6", 163667133L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440052",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2c77b0ed-f953-44ac-b678-a7947e26eb90", "IFF-4/2", "AQAAAAEAACcQAAAAEBDONGdyHAXgA4+ZtH2N56XniDUTpv6af3XTV1LAfwxH5w7/Xv/oZiRmozKwDvp/6A==", "bfd8f4c5-d675-47ab-8676-578352e15d50", 199828726L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440053",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c8127296-18c7-4bd9-9662-a7812c237353", "IFF-5/6", "AQAAAAEAACcQAAAAEHBvePoFCJTE4YYh4KI6jj6lQX8dtFzTdBSvHORUaWjjN8nfZICrNjzZ8PL5VlVzqA==", "03f7ce2d-caab-4f13-b62e-85d335909b7b", 174656425L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440054",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a125e548-d8fb-4bf2-9d1a-d5f95fef4480", "IFF-2/1", "AQAAAAEAACcQAAAAEEygMQz2EFr/UdMqz1fdQGQcTcszHt55ZkHfyeMrZslH1k8QamXPvKRo5KEWhjb70A==", "071c7c1d-6853-4b43-b4f6-ddd70fe64fbf", 194897136L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440055",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "99d010cc-4bf9-401c-bbd1-0dd73b047581", "IFF-8/8", "AQAAAAEAACcQAAAAEKzDFcjRqyW8p5Sw/cbF3Q//yM9U7HpgtHLHJ6n6z/wIR6xNh/KpVy0koiCIxJttMA==", "a841a3c0-7de8-4b43-873a-bef1d078af1d", 187023930L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440056",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f53a4d19-de15-4d3d-8220-93afbc70a2f4", "IFF-5/2", "AQAAAAEAACcQAAAAEMOlJnyhi5BHdSoa3UQEiUFTI+sbubTFgiDkTsj8e+vVdUmJ1vjNg2cApkaRLCxGjw==", "cb378881-fc15-4101-903a-9a359122556d", 141320197L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440057",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d3768121-6f33-427d-b4ed-1638a4d7503a", "IFF-4/8", "AQAAAAEAACcQAAAAEEFTSvXDOYIFGjdoogQajfrdsMVAKJPKPnW1VQ5L1MfQDllo2n8XFHcB/3Tj+E7ubg==", "104545ff-9685-44d1-af67-a3557dbfd848", 180009019L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440058",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fcf83100-1fd3-41b3-af7c-e5b60a755d55", "IFF-5/8", "AQAAAAEAACcQAAAAEFBonxB3dFExH51tRnAH8Dt3bLA5tQqU4aZP08Af+6p0QbiuPkA6bbrrZK4qEYFJVQ==", "19e65847-a307-4e86-a85e-99320e399e4f", 134764136L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440059",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "003769df-1f8f-4fde-80ef-55f6a667ca8e", "IFF-6/3", "AQAAAAEAACcQAAAAEDp4LHvvBdBQ3SCVzoyk2hrxcMq1PEYr5vBt+qj7l7cV4TZ8QCOgVBisaYdMLJev+w==", "0e5497be-0c4c-452e-955e-a0f4db3bbf83", 118505555L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440060",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f8686dbd-88e1-436d-81ab-565f6d5efdac", "IFF-4/2", "AQAAAAEAACcQAAAAEAcJmicpEi/O1yB8TZXHM9YokzKQm4FY3WvO2eRtvWEZ2StvqvmeCCJ2JSFQmRtZeQ==", "e8f979ba-a5cd-4ace-afaf-083fc957eb12", 110516106L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440061",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "03ece4ea-7b47-4db9-be64-1be4a078780a", "IFF-3/6", "AQAAAAEAACcQAAAAELAI6omlQPnHGaM/lKhx2ljLpyjrtGszWKpeCtog07d7rML767AzFUhfYeYZ7EcSJg==", "bf0e9fca-1257-47dd-8284-3003742ea204", 128640592L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440062",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f744cf9e-846e-439a-b91e-115c52a29439", "IFF-5/3", "AQAAAAEAACcQAAAAEKOBKrFe8qRlHfGmE1udQ7lL7OXDMOPGiW3mB/njPZd00DsOueIcStsSyw6xZrgo3Q==", "af865747-1938-4c4e-af87-a0b8d550094e", 115670289L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440063",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "97789760-2ae9-4106-9108-b346dbcaf8bd", "IFF-8/3", "AQAAAAEAACcQAAAAEDKqDsavDJT5dN2eNh1dDhL5Ux4aJgkwkXRKayZ7W01E56tmF/BegLi9Zu5RsI6a8A==", "1b783e02-5e49-41a9-be3d-5f35c15ab762", 164508796L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440064",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f7b34810-bf40-43c9-a8a1-ed9fa0ec4f18", "IFF-3/2", "AQAAAAEAACcQAAAAEEfhr2vMBtgqBmaPGWym0V7tTkcVYOIHmFs5qsVCphMHeNLAjMgVZ4qMHyFW3CSyCA==", "1bc0ceb6-af4f-434b-8480-4743c21bc6bc", 175299037L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440065",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3086ba83-066a-413d-98e6-a4797f4383fe", "AQAAAAEAACcQAAAAECyJfOAWVt8pbQ8qzK41oJnQFtQthnHN+c1MBDmCRkC4Ohy6rNnnBJyqDXlmzaStEg==", "9b026045-5e0f-4e72-937c-0faa1bf092e2", 126257040L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440066",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e117c800-bbac-44ff-8cb6-05a380814180", "IFF-4/5", "AQAAAAEAACcQAAAAEEhpx0/kwCrnDkLmShwwHCe03OabHf1MQuHxGxRacyh0QT4X/xZp8BFkCaRxmEJ7IA==", "ff4d74d7-cd79-4034-9105-019b19e9ec52", 126473222L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440067",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f6ccc323-e391-437e-9aa4-4f2a850e4553", "IFF-1/1", "AQAAAAEAACcQAAAAEFU4WV+HA1pBUWk3oUx3STf8PBhzn8/CVHwUbXuoifKI7oC/f33RZ7xplMTv8Alzjw==", "9606367e-e4d7-49d5-a3f9-22c2a40c4dc2", 121291402L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440068",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7068c2e5-dc34-43f3-8f5c-1b1d664acd74", "IFF-1/7", "AQAAAAEAACcQAAAAEEtWKPyZQKtXagLMqZOjr4HZ9Us6msnJENnIAMCThLhOkVxJbV2tOPUkS+vtNROm7A==", "11e90d0a-a57a-4b6a-9f51-d0aed901edfe", 115800553L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440069",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "75cbb5bb-2c1c-4d9f-baab-bdbd5982601e", "IFF-3/9", "AQAAAAEAACcQAAAAEFXCRzK2fD0/N0Qgw4jPQK3H2TgYv/2j1tek9ENyQNVecR0nD9kd5JrfQv7A+0ykJw==", "723317ee-4673-4156-91e1-c55ae65fa840", 154075723L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440070",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "57d8da99-03a8-46fe-b601-0e86b93d46f3", "IFF-8/7", "AQAAAAEAACcQAAAAEFT94oLYUIDxTOJl28Zo17D6jk6iRslkQvDtQwPTuiB65AaMAs6+A/Ve4UYbl1lNEg==", "7dfd674e-7617-48f2-86ff-a0ece1ad8b33", 182198639L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440071",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6758e487-b9b6-42d5-9e79-9553c6cbbb30", "IFF-6/2", "AQAAAAEAACcQAAAAELvTl0zsJUoyCx6P01bYKDFfLnVWNpCYc0KB2zblg7/dRVZOt/hkGkz/xtJo5+kxYA==", "981dabf8-01b8-41ed-8337-ca9869c02db4", 187526351L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440072",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "898d6a6b-adf4-4b6d-975a-1de7cbad5af3", "IFF-6/8", "AQAAAAEAACcQAAAAELlvDpVbJ1SNlg8KbEDcchDSY9HzULPkzugfBrhF35YYfrhOh4azkKkUVItY9p43+A==", "4b529831-9157-4377-9aac-06ddff25e288", 149596366L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440073",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2cdb66c9-77bf-4cdc-96dd-6da58fe4f6af", "IFF-7/4", "AQAAAAEAACcQAAAAECJXePO35lkS32Bp/NxoxFqO64iHFfG0UPy+i15VA4QriEkLJ9tMk/EddDHIThraOQ==", "913bbc16-ae05-48aa-9d20-ade4fe749691", 138322247L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440074",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7ba835e6-1396-4b66-b1ad-2cc635a91e71", "IFF-7/6", "AQAAAAEAACcQAAAAEOkwSNU8HRY5tcIMBF2QyZsstTmFPVM9hHLiBGoT2O3Hza8IkG4xULhu5fzoaST46g==", "839633a4-5693-412d-a2ab-15a21eed9451", 149884755L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440075",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "27362aec-b4e7-4a4d-83ab-4ede8ec83235", "IFF-1/1", "AQAAAAEAACcQAAAAEGsYEatxmIEArI0XkDqPmuUxQElhV/kZzgzgLMZx6ilTKevMu+3PC3cdoK1k2KJJ4g==", "12399650-683d-4c29-adde-c05698f2cbda", 189217976L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440076",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "aa261319-f4ca-44a3-a6cd-c8757b3a08de", "IFF-1/3", "AQAAAAEAACcQAAAAECsq+YAcLKeJ2ematvwmgbfZuJFNbtXRkomCU44wp/7tFsWWIuoDWZQf1IxuOZwjLQ==", "f511ac39-37c9-4770-aaa9-b5b11692aae2", 161681178L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440077",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5e80a2e0-0e79-4f74-a674-dc325f5d37e5", "IFF-9/3", "AQAAAAEAACcQAAAAEJfhAurhM40UUx0qjwrcCxY7ywOSKHy40RQA2vuDaFI52IY7jCI5erPuzZ8W4HIUlw==", "10de97c1-f316-4e73-baaa-5703179feb76", 106690041L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440078",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "214cf85b-8095-47e0-9f3b-bb294a959151", "IFF-9/3", "AQAAAAEAACcQAAAAEHDP3FuVmYgklcnBtFbmOa8wyZdTgVkzAZ7KQIjGIxA02jhWSWO+uiMa70Z91W8CbQ==", "bea56d31-29fb-40df-b576-8dc49235dc73", 173822191L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440079",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "cab6fe54-1351-46fc-ac15-ae3290b90be6", "IFF-2/3", "AQAAAAEAACcQAAAAEJXGzTchmsJkOu/AyaxO7ght4jVgQF1zi/ORd6x1k0D88ilF/u8B/af9WdJAs2TE5g==", "2cb9382f-d05d-4199-95e7-de3dcc7c9d82", 111040217L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440080",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "297b8891-06b3-4ec5-a2fb-d8d027f0cdf8", "IFF-6/3", "AQAAAAEAACcQAAAAEMUa8AUtUbeChOfchgOxC/pIxbk/tcvAkyGZbb8HsDP9HA9E9498p97A/LTP5h/1Mg==", "2fb32784-d9e9-4531-9028-76a0294bd135", 190797080L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440081",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e7023d2b-9321-4474-b7ab-781d7d889355", "IFF-8/1", "AQAAAAEAACcQAAAAEBYxk8NLWvI2wxwhq4PnhihcrtOhv2Xhm54mWl7COkz+GUCSGcHB02jliptY4l2now==", "1d38daed-4645-46e1-819e-13f857d40c83", 139147677L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440082",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d8cbad8a-7fa0-43a8-a093-68390a048365", "IFF-8/7", "AQAAAAEAACcQAAAAEEIXMn1/sOuGT0sYYHTv5F/vqvBVIMPyHobM33ZChOwOLU4I+nVCsTo96GqF2v3HGQ==", "14ec2715-44ce-4d84-b535-313bb192ee8c", 145419320L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440083",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "757857b5-8666-41ba-9e10-5128e313a491", "IFF-7/5", "AQAAAAEAACcQAAAAEONjon7IRbAbIUZyT2/eA4yGmpPYOKPyyYSWV9P63RAarc+ANnFpQv4Uo12aXw0fgA==", "629dde95-ed3e-4977-9d44-8ce96e1009b2", 108190173L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440084",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "54599dba-984c-4ae2-81e0-e7f4098a6f06", "IFF-8/6", "AQAAAAEAACcQAAAAEITq2RdYw8bqRYEiczXLHCQgmNz7BFtIvBXfHZwomhk7/SDO6A3smXFavQdUGoXIlQ==", "831e9533-32e1-4c94-bbf0-ac1e65dfd912", 196393283L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440085",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8808daf9-7359-4b05-991e-73cd42c4b348", "IFF-7/3", "AQAAAAEAACcQAAAAEAS2eTcDYjgZz8F3gLasqUdmphx1xi068wXuLAmKDfdQn1U8I8cRO3YlxO4OE8L/3g==", "6c8dc0c5-9349-484f-9a2a-b5eabe0e9c58", 120379062L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440086",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "72bd7269-a897-4574-a703-ab54e5dcf2af", "IFF-3/9", "AQAAAAEAACcQAAAAEPaHOIxI7wCvEU5KESDyKYPWLj1CGCFCGaTvo/BzzEKvSycSnOE/Ll49akJbiGycuw==", "8a5340fd-e08d-486a-a3cc-d8b7e8f0cea9", 144993840L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440087",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bd5f624f-ff2d-4659-abbc-97bed96a5e12", "IFF-9/2", "AQAAAAEAACcQAAAAEOFqvTmClHjZxQZxQqbB8zLWWFdkQO2amZgdB0RJTbtqsIerlwiOYd/GLj9WDjes4Q==", "deb5cb48-b78d-428f-a01f-d3faa3aaf131", 170629480L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440088",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "72c51f37-ea32-4d83-aef6-5d51c064702a", "IFF-7/9", "AQAAAAEAACcQAAAAELV7L6C8azsdPvBTb+2egL2y0vhLAg5ncvIZrjT1Xedve618OBfad5CAs2FfMy7zAg==", "a1ac4209-a2f4-4d99-b8ee-19b16bcff0a6", 162970650L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440089",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "236bf045-6d6e-4f02-b1ac-ae24244916ba", "IFF-2/7", "AQAAAAEAACcQAAAAEGqG26lb4hTBY5DDoUWbH7ALG/jgqxfJYy08fPc/+BBx0RVWani9jdMSbmJxs3WMkw==", "ebf22bb6-5219-4cf3-a7bc-1d427b783be4", 146966476L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440090",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "57168174-53ee-46c4-8a8e-55ab3c906662", "IFF-4/5", "AQAAAAEAACcQAAAAEITdZTnhJYuD/ASeoqJLIBna1E1yWnBSyJsVPkAc6QxpjVsP0efAfId2TST9cHkhjQ==", "cd91072a-ba68-4749-b416-ba8a1b11bd85", 185803728L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440091",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4f7fb500-ba26-41ba-a9fb-db82d4750581", "IFF-5/1", "AQAAAAEAACcQAAAAEML2mq+A2AMKi59oiLUmkC1G4v2Q1mk5DloUzdzRW3LB2o8q/yPVevfFLekzlhRvvQ==", "2f8e38ce-b9b9-49a4-89c1-c1ba41fa9769", 156839240L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440092",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "756647da-17e7-47cd-88c3-52fa24d52692", "IFF-1/9", "AQAAAAEAACcQAAAAEKtZ5IgrMsB4bTpWxzVm+U/y7OUU4dcnYSLTvxXZVfmcmT7HwK1eryrvnW4j2+B40w==", "2085085b-2366-47ec-8b3f-92d10bc6c6f0", 110828169L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440093",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ee00a951-98bc-4907-af5e-9e75458dc343", "IFF-4/2", "AQAAAAEAACcQAAAAEF2T59XiFh4DW9lD4LCb+/W3NB066sXE6C1to/7NYCX/lzX42MZEKH6D41/meLz5lg==", "86a467df-7d96-48d2-996d-fcc974236c40", 151140453L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440094",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "63f51978-60cc-48c8-8d40-40394f445666", "IFF-5/3", "AQAAAAEAACcQAAAAENC1oWYv6BGW4SWTvi0bThS3mlAOHPP3qFGf2ebUO1A5QnAlBGLKZw06TkEo2WLUgg==", "3117b2ac-761a-42e0-9cd6-75b5cdafe658", 136164134L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440095",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f7e4b9ae-4b73-44dd-9bae-cf24e75f7232", "IFF-1/1", "AQAAAAEAACcQAAAAEJMXfVvsxBOa4kWrcs8jHkEdmtDF8rDuqo/6pHt19rR4rBttkLuZNKOgRGyebDJKvg==", "1faf2ec8-1608-4501-9692-3280d3af979b", 173723396L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440096",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bd59cdcb-cc21-4c1d-8dde-a0527d86319e", "IFF-5/2", "AQAAAAEAACcQAAAAEC4uIU4r+HoZNanoZS2a69Xn4xL+DaXFiu7hEHwjQt8FBgwtuiJ2AjH1l5lSrDsAsA==", "b7f57fbd-bb99-43b7-9331-ef90c49911c9", 167394584L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440097",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b84bbfe8-0099-4823-b425-95e04e360946", "IFF-6/8", "AQAAAAEAACcQAAAAEPehPpLXJj7Nx41ymjLcDhaBK8/ZIavEpDoOmwOQrcqa9DKjm8z/ysZtlMP90wO+9g==", "f894697f-fc9a-440f-9dfb-842e59cb53f3", 196010973L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440098",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0b3d8382-e47c-4382-b18d-2b7080f5962f", "IFF-2/7", "AQAAAAEAACcQAAAAEDo9CdIigYpJRfHgwrz2LIiXfiV7j3Q57F4A6n6iQhCL2FRfS0vSncKfYW1LzqaB1w==", "539090a0-b549-437f-85f6-79d34d71241a", 127752758L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440099",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bb582045-e13c-4c28-a945-fe714857ebd2", "IFF-7/1", "AQAAAAEAACcQAAAAEBVw0LN04/oxtrH4Luu677bdHiNGpa8GkYYhZgIE0IFqhrm45cQxaT2yXFe1fyt/0g==", "96966f0e-6fc8-476b-aa59-543ad80b4872", 102196298L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440100",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fdf596b6-5a9a-4234-ad9a-14a6fda5a10c", "IFF-9/7", "AQAAAAEAACcQAAAAEGaL0PYGoMhMMFMto44lwO3a0iu/dr8Lmm2xSfUMc6aePJtmD5EEG5clPf51cHokrg==", "cb05a2ef-e33e-4ca5-a80e-4e17093a06ce", 117542043L });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "ClassroomId", "CourseId", "Date", "LectureType", "PeriodId", "StudentId", "isVisited" },
                values: new object[] { 1, 9999, "PB0000", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 1, "a18be9c0-aa65-4af8-bd17-00bd93440001", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Timetables");

            migrationBuilder.DropColumn(
                name: "LectureType",
                table: "Timetables");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "7ab7706e-50dd-4d8a-8624-1d83be135a02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "b0f50de3-541d-49e6-bdac-45a800da7280");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "5ce0e1c0-7966-4d7a-b41b-f94ebf3926e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440001",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1751ca9f-8a6c-407e-89a0-7a17ad27d345", "IFF-6/4", "AQAAAAEAACcQAAAAEG0K+9fgD/TiSPysbTA1qFQePJcy1dLYwfSVU+rDnRl0h6KeCYQrXagLojiq/byPNw==", "33520f28-8948-4d81-869d-1519d3d10565", 180725540L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440002",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1a35e15f-42c6-40c2-9946-37c409a54974", "IFF-3/3", "AQAAAAEAACcQAAAAEMuD9Cs3YU0hlw4BtOutH8b3Z4bTD+/FzZZnu9PC+NTRuFAZvRJgJw+LjIdHjLUntg==", "a980d1d9-3701-4bcf-a127-5f3f07418247", 120406698L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440003",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3efec7b9-713c-440d-b2c2-f3f9d98efffa", "IFF-6/6", "AQAAAAEAACcQAAAAEFLaMaIjV0YAXQdSAZr4BE6M59ZyL77a97T8AUi5vUvuv+SVz2Z3xlfeW2ITPozA6Q==", "04d22aa1-cfeb-431f-8afb-7b7d8d755545", 155425846L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440004",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a48c36cc-ac50-468f-aa64-97e4b82b4ade", "IFF-9/7", "AQAAAAEAACcQAAAAEJr0TC82hjTma3JpgkEUIOhnVxYgn47uqHDebpfFX46wKSh6TvR0LlgXayZuz2ZPGA==", "8f6ec2b2-dcfb-4278-acc5-c2bd1982e70b", 181126377L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440005",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "824d35a5-c9b8-4b1f-9fd4-8f6fa2990f02", "IFF-9/3", "AQAAAAEAACcQAAAAEEUlSdFnnMKBg4VVWOlizkazWd1VxFL39v5tGkddykk5toMY/mfU/cxWEU0QvOkrxQ==", "ea43296c-5f91-456f-a73a-4834f6723fa6", 114173252L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440006",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "dfa49293-29c6-40f3-bae2-2333182b33f5", "IFF-2/7", "AQAAAAEAACcQAAAAECC5S73ja2pdmTxxJT74xin/dl80rQMYF6B2XzOuI6P/JozgWiYDNQ4jL15ICQwH+Q==", "0ee6d271-826c-46ca-8fa8-7e21d9d401b4", 108001308L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440007",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "29fb8a94-5fbd-4e1d-89d2-201e12d45bd2", "IFF-9/6", "AQAAAAEAACcQAAAAEMeZS3aAo+nzVdiJ8c32fz8SkdxC+L3ZvpFj1W9C173L5OsGsRWaAxbTTUp88CnEag==", "6fc54679-1969-42eb-bd2c-a9f9dd05bf24", 164791657L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440008",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "52ef0135-05b8-41c0-a532-1e63766a40a9", "IFF-2/9", "AQAAAAEAACcQAAAAEMsM2NZL+a/xO08xQxkck2r9Gjs2UCMJdwyxVFTNVb16HyBmN72Ayp69uNWKR2PTww==", "a72714e1-59c6-4f51-8f5f-3f850d4092cc", 185406648L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440009",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "89610499-850f-45de-be65-9fad9550cd83", "IFF-4/9", "AQAAAAEAACcQAAAAEKDGsBM/KkuuVZnJttdgZjWyBdsoLba07UbnsZivqiYqq+5ixOPCjN5ffjQr5EwI8w==", "d4d1244b-6790-4827-9931-9004ad922387", 116084181L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440010",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2563bad0-335c-44bf-9f09-e4ec297388bc", "IFF-3/6", "AQAAAAEAACcQAAAAEBQqvsXkhyCNXFVJzxDo5GxUwxApDCUxsnkW/U5//u4Pl2gnnIwyBLfOYXDXCYjPnQ==", "06660bde-3604-4b09-aa08-a49e61bc138f", 140688718L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440011",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e3a1f99d-8913-44d8-9f22-6d881790f7e0", "IFF-3/8", "AQAAAAEAACcQAAAAEAofYbDZM0nyWLGUGCIHFND2fjw/HaAa2+YQHHDbUEwlGJmi/FdOOj43cExY5tEgSw==", "3b94cc63-9c51-43ed-b6e6-74f2d849ea76", 160937489L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440012",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ab0c16c2-b26b-4d18-960e-a42d083189d3", "IFF-7/9", "AQAAAAEAACcQAAAAEBgVIgPRAI5OC2fT3ax3Eg96Q8NOKSXPObPBrwTPBqtxv3fbyTyVVh5EC1MhDpRrEQ==", "d1d1b968-a685-424e-be20-8547a0e3b949", 120958363L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440013",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7bc93158-793a-4c94-8949-6844a9805bf9", "IFF-6/1", "AQAAAAEAACcQAAAAEHVONPO/3WQJSA0zy1AzeXPX04aVXfOM6QzcvpWTb7OLJrfQ13rotM3YlCHJNJop8w==", "11a22107-c66b-4573-9e87-9979be7a15d1", 121475051L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440014",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d963b6c9-7c98-4f8a-b93d-ceffbd38909f", "IFF-3/5", "AQAAAAEAACcQAAAAEGnRviyRQ66qMrzk1AaJ50VgFOMme6J4J5OGc8beUKohn2fRhGE18ewOXZ0aXOdBRA==", "dfdd51ff-6df0-4f47-bfdb-eb69a96e5437", 179625650L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440015",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "83d3085f-35ae-4bc8-a5f0-0113591aef85", "AQAAAAEAACcQAAAAEJv3dGMzjUGVGLd+XxMPXs6uxqlAy026rdQUS/7YbPhgSqVcxpPa/qhvcWPQJDud9Q==", "3197fced-d15e-4112-b315-209426089cbe", 180507000L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440016",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0b42dc35-a6bd-4acd-b666-a8f302d90fb3", "IFF-3/6", "AQAAAAEAACcQAAAAEOrJUcFpanAGOkuhc36e6IcxPb3YQjAIDLoQdi62q1Snq+YZeKxMn2HsaWPiAYpwIg==", "b33bfe30-36f8-4f55-a03d-9a2f804724a7", 168919844L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440017",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d4d9f327-625b-4a26-a06c-cbed551d850a", "IFF-3/4", "AQAAAAEAACcQAAAAEBAljEUwUmmeO/lGsRPLFKLCYYRyVVftLx+ydLkoQIFIb1QVXTVB3XTey12hwnoenQ==", "8c177dec-8d97-4219-9d0c-25689ed55212", 192868781L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440018",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b57a0ffd-7159-4588-adfc-dfb55501e95e", "IFF-6/2", "AQAAAAEAACcQAAAAELQZVbE4qu8pZdr2xaguewx5wV9JSQ9r8q0KHM3noFiPwWnSLEUaUcuK75VkPYjj5Q==", "b5d3728d-e7df-4364-83a7-9b09554bacd2", 129720128L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440019",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b3dfd663-76ef-44a3-a345-fad82f326bf2", "IFF-9/5", "AQAAAAEAACcQAAAAEPB64strmelXBP2WP9tgDPcBVSEMejhG4xXFVreuQxnxFfQYpJcp8LefbxGp+GMm2Q==", "d334ef93-5141-4529-893d-116a14ee54b2", 171477695L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440020",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a489e391-4dce-4454-8e72-3ea9d8b35f11", "IFF-1/9", "AQAAAAEAACcQAAAAEP9H8uFQ+iMqyTdlCRxmo65tM9kx+ahPo8VDO/2PwJY4F1O2dRAbUrAwF0VP85PUcQ==", "aafbb6a1-0c0c-4821-b576-4f501cc974d5", 136927559L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440021",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "30d0919e-8ee2-4594-a754-c8b7d72b993f", "IFF-2/3", "AQAAAAEAACcQAAAAEESOykU4jfjMFrm8h2sQ9rq3wZ77PO0X5uATx4YnIZNfMlFJzFyYlnnsbJcAdaQPTw==", "dd762ad0-0c87-4282-8feb-cc7984ffb470", 132237601L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440022",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8c8a45f4-815f-4530-9e8e-7ed4550feb60", "IFF-2/6", "AQAAAAEAACcQAAAAEF8AMkc2BJ0W4FiTzL+G5CPJUiBIvB8UsenBwUP15v/8mOMOy5Pp5vyKMiMeETo5aw==", "2cb1dea6-4890-45fe-b3b1-8ac9937521ac", 199324310L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440023",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b59bc968-0218-4760-8987-e521ea425ddf", "IFF-9/2", "AQAAAAEAACcQAAAAEFxOTd7vwStzhohX952ZGv/p7+6ZF544covQJDVhsPUq7VLD9BvD/4JHYywQpcoigQ==", "848cb768-1ef2-4fff-a210-c91339edf8b7", 186746580L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440024",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "20ce4132-0524-474a-b30d-44d10acec659", "IFF-8/6", "AQAAAAEAACcQAAAAEGh7F60IPjOfNzlNjEHti8VsSfxfrmuNl6zT0TKB6YLXf7qsObzkX9AoQczg8yyJ3Q==", "b4d2d735-c3c3-498f-90e5-5a412a1ec0ca", 129492386L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440025",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b5cede0e-4530-4c2c-b0e6-680730ebe20a", "IFF-8/7", "AQAAAAEAACcQAAAAEAdRdsFbu9SGKeAIt4R4i24n8E7U8B5AE2N1gIx0qy4ZCpK6qTS0cMKD3xptAOoWtA==", "57934de7-bce2-41a3-82b7-a696b503efc8", 168036646L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440026",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "601dfe3d-5d7b-4290-8492-ee1623d6dbcb", "IFF-1/1", "AQAAAAEAACcQAAAAEInsZg2BqrOP42o5vimYVdTLa9YfbJ8pt6yG6DGBO27Mr2dGkKgjHyGwbvKaSMaGdg==", "4f6aa93f-fc02-413f-a7ab-d8b7fd2e07ac", 116328620L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440027",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d51a5a3c-097f-4331-bc20-5d61dc006385", "IFF-5/1", "AQAAAAEAACcQAAAAEBcg3H03SQsxZug6UFucC7kJvo/4JcYdeVu2JxYuQQircI90/yFEA91LdHE9b1GOVw==", "39eed4d1-f29f-4501-ba87-1ccc776d0bc0", 113055084L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440028",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a806892b-358a-4a80-a21c-3d609bda3c52", "IFF-5/9", "AQAAAAEAACcQAAAAEH3quUtlmhH1jf4lkNezDgUOykjOihcoJMLkOtn49snvH0CMxyU+cCrRP0BD8J8nCA==", "8e03f8b5-972a-4bfb-b8d8-66190e3edced", 134431737L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440029",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4d9f0978-f938-457a-a92d-c0599f60762f", "IFF-3/7", "AQAAAAEAACcQAAAAELPxT7bQPC8pNyOvMi7itfb/wTH0BSQFTl05v7mAdskN7JlW73Ys4R/Ct0H+lCaBnw==", "e1f563eb-a496-4220-b79e-503b3dc08285", 117835928L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440030",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "385c540b-f3e0-437d-bf63-627a46ec3b27", "IFF-5/8", "AQAAAAEAACcQAAAAEP3Y8eIIfjWS8LEL7cLQ4OxGl3/+d9+EwoXcSqHWVVsCD3i95TE5IsoKQM9kO7U7Kg==", "50d47330-1c60-41da-973c-7e8531bc5cd1", 168673626L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440031",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d32ec7f5-4b72-4563-bab3-f46866d75eeb", "IFF-8/5", "AQAAAAEAACcQAAAAEMMTs0MN23I8GvcoLXgb5qegswIXEfdGvH/XwLFcM6aJLoHdG7/3lny/3KsmEEqt3g==", "604684b2-0765-4dac-8fb5-579d3829e9c5", 141229298L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440032",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "558fc5aa-56ff-458c-9dd0-3997dbdd320e", "IFF-5/2", "AQAAAAEAACcQAAAAEGlcxy6GeSOKiXovRRm48z/EUQjBKk6emqoy+aV/JXv/kYoriHk7MRpsftn10j3H0A==", "eb0e35bb-051e-4ff9-ba19-9afadee1c22e", 111807414L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440033",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "be5d9a2d-dc8f-41e0-a213-f663e6ee74a3", "IFF-8/8", "AQAAAAEAACcQAAAAED6XLOy6DvDjAZXODVDMs10zcVZ+bNOzumLS94Q99j6ucqcKQMJklB5BqCKV/cvB8A==", "60d9b02d-fd61-439b-882e-63db7083edd3", 122697682L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440034",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2cefca84-04c6-4e98-bb37-c9f592f0f034", "IFF-8/3", "AQAAAAEAACcQAAAAEEjhDPaa/59uUd3AYzBqVy0ok+jo3Zw8tluIlyBw3WRQuSHo0X8D1LJm4ItFRRrEgg==", "dcf21537-b729-4b04-a3b1-ce368f8cd609", 116826042L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440035",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e6c9a591-ec64-4ec1-a7b8-2cde2cb0851b", "IFF-6/4", "AQAAAAEAACcQAAAAECeyJAnZXaxMBu/Fat8YppNXa6Bk3OinL0XPtEg6vPNmq+jkPeiHo99J3bIA3oDWkQ==", "dd506e49-da44-4ab0-a90e-8ce8b6ff6e66", 147590426L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440036",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3c8afb47-4c61-462b-93fb-e91ec0ce8dc4", "IFF-6/7", "AQAAAAEAACcQAAAAEJB+mQ1KEYaUEur6vOoXSY8O/Kdw9/pXfpYiLB/qw5KOm3qlD7dQqHbTVMagc8utRg==", "ffdb4ddf-4635-471f-8c36-0f7ce9928af8", 176422864L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440037",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "707b786f-b53f-425d-b139-0b112ba79708", "IFF-5/9", "AQAAAAEAACcQAAAAEO5V+14VD3rmbzDNlAzrWT/RjcKfgpE6vYU1u0ulNoiAp6yknbB9o/Ffwsrx9rYZZA==", "8c758733-4a80-47f1-8981-feba6dea68c7", 145022243L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440038",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "af514e98-77ae-41ff-b456-2147a35f3b8c", "IFF-3/6", "AQAAAAEAACcQAAAAEINTcT1/iny2tx7usyv9MnD3QJ4hyDDg4B4sX1VpAOgeCjNnmkPBBgdkSqUcyN1o8w==", "ea2d582a-59a9-46e2-bcc7-4413217a382c", 143499845L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440039",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3e98e65d-91c1-44ca-97df-af6d21d9e89a", "IFF-9/7", "AQAAAAEAACcQAAAAEGCDzi/QFDk0lz1ZjAwybblNe/V+a8xdHJEllPeT7qtbMnDnlaLg6lh6KbW+GUhuhQ==", "4b837901-bd9d-4f1c-a2b6-ce964977bafc", 182578655L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440040",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1674750f-74ac-4847-972b-6095bf9ed447", "IFF-8/9", "AQAAAAEAACcQAAAAEBDkm0HtbEdbqkqBDp74ZPwpm79mZi8b0QDQ7r3bLylr6MF9Zb/g1n5leVk8E+lX2Q==", "e4e77af4-8c65-4282-b0d9-1fa6293b3eb0", 127785738L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440041",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "17cc9558-d63a-4592-b366-9b41a024e3db", "IFF-2/4", "AQAAAAEAACcQAAAAENEz2HQzHrRZweuIU9FvP5PRZlQFgZe1GNSMyzeY2+aQsG2RDf4ZtmJ3grxJ5AOB6A==", "f4c7464f-d1f3-4823-b00c-163fce017f53", 192393649L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440042",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a149d717-0295-4166-9c10-f47f1e1bd5aa", "IFF-8/1", "AQAAAAEAACcQAAAAECE85nxXuHe5T68m3HrBs+UmNxLDV8YdeSJ9MWP4+no1k2WBF2HAe1RKA0BfzKjZqg==", "df2bdf07-86fd-4761-b7db-572f87b7bc89", 135594674L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440043",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5589758d-b796-4692-bfbd-2e6e5a222e66", "IFF-6/4", "AQAAAAEAACcQAAAAEMdVA1VaNmg5g+aq2VMR4X3GFVVzKD4VErl2I4G1pV4BBoxN9Ibn1evVkMTFrXXIxg==", "61493c78-191c-4791-a1fa-3ab5108a1fe4", 113584055L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440044",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "11cb9f4e-fba3-461b-a483-26c613960787", "IFF-9/3", "AQAAAAEAACcQAAAAEHZtJ33NTVPwHv2DGpaUtCRwmqCYt3PUzcsGSI09yRv36i+Jcsg+Y5wEF/VQfK9b+A==", "9fa77e82-aff5-4328-9e99-500b0cda2bc6", 161901777L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440045",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "cc83b27d-26e7-4e01-b014-be6c6f9efc5e", "IFF-9/6", "AQAAAAEAACcQAAAAECbNx50zHk60vIP9ATSy+mxoOoafBQHmnsAhjKaGDG/bbp7SX36/n59Yt+jw62EWaw==", "72cbc2e3-4d6f-46fb-b2ef-b1266604be58", 126356513L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440046",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "cb63fba0-87c6-4407-b95f-9bc458ca83d5", "IFF-8/8", "AQAAAAEAACcQAAAAEKQmkm65N7Cx4UKo9dA2eviEXcsDfyL/iL5x1hpXX9dFue8EDayH1dp5g4xCWCCYCg==", "643bf682-77cd-4c59-8e08-64a5d55fa4d2", 174462007L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440047",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1d993370-d68f-4d37-998c-70652c5ba361", "IFF-4/7", "AQAAAAEAACcQAAAAEDB6jjKdvTwL/V3NRDADWGR3GewCJy2fJnNiDfBtgSs6HPQPfJx1elf6wtMLsByWQg==", "392d8b6e-60a5-4656-a057-02a2629debc8", 154582721L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440048",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6a8c1dc8-f546-4159-83af-ece745e84099", "IFF-3/9", "AQAAAAEAACcQAAAAEJgmjxeDS09AVw4PocXKKo99zaItqLOX2qT602+PQDsfEFxb98CQyJeuR9zH8cOAkw==", "46e58d59-3f6e-4d03-95d2-d4b15c781464", 103396374L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440049",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "455e64d7-e9d1-48b7-a794-2f89fa062418", "IFF-9/6", "AQAAAAEAACcQAAAAEDWwij9bVhjiKkq7Dv+3wvAi720v/k4K2DJyqKAX8x512Iiq+P4MvDi/FcebY4/lcA==", "a0d3a54a-affa-4f46-a689-e73d72053f42", 191450887L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440050",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bdc32d50-f131-4468-852b-152acd796da7", "IFF-3/5", "AQAAAAEAACcQAAAAEBey6ZhZsgsWH/g7fgw4A3BufBSXzifiZiY9xUS9kGuUvJ+iPYNtieoU12pH7nFlcw==", "241f2ecd-a8f4-420b-87a9-934aeef54325", 194532713L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440051",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e906a0eb-0e77-43a6-9494-a0a85cbbae2a", "IFF-9/9", "AQAAAAEAACcQAAAAEHSFRiQ6Taq0P9k2qh7ON5QmfItVecoqmPPtyLYjap9xrR4rhWhIrqrVYHJjkX4uTg==", "bf7ab69f-12f5-4811-8b81-08310e199771", 144215756L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440052",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "56d85c8f-4600-4818-8aa2-8bff35f53f92", "IFF-3/6", "AQAAAAEAACcQAAAAEKcFXzGZunmb5BoVx80cnCOo9pkyO27mkKUQAeW4czWEWsQZ8L1pt4Y9iuLCMc0x+g==", "7be96d0c-054e-47c7-8374-13799a630261", 193495428L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440053",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "834f9166-89c3-4935-8875-c1083145311f", "IFF-2/7", "AQAAAAEAACcQAAAAEE7aSc1go+cu9DxWUL3ccAdDcp33a9ySuPTuovahmdQwcNz823udCEg0cXt5iQHPUQ==", "b0fd6a33-8513-426b-9327-9af4ecaf259e", 189299679L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440054",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fa85b9d2-b9d8-42fa-9cfe-ca71025f66b5", "IFF-6/1", "AQAAAAEAACcQAAAAEKVqwW66QWFyLdlHhiOezFF9HeQnXGYjlI0lUP8LdH0UN1FbMIFrt9b/8ByYtmwzYg==", "0b1db88d-89aa-4b8a-9d57-de5f01acdc42", 142294586L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440055",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fe83e357-8e7e-443d-86f4-aff15e474e3f", "IFF-8/6", "AQAAAAEAACcQAAAAEGVQm7McIgWCAib8wcAtme07mnaSfon5m+J40Gfo1ln5BsmxUiILtSho5azyZL8kWg==", "377f51a6-a050-4826-9156-49754c1919f9", 132976806L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440056",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f0cbe398-2639-42cf-9e51-a14c32eada70", "IFF-2/3", "AQAAAAEAACcQAAAAEK/ozRTwg46EzMjZBmekX5/LklYB/ZeV+wzrZxP34zkj6/0kDElKMbN4Mn6IJNXnwg==", "4da5bc04-c3d4-4d8e-b303-7783481ef692", 166702283L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440057",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1d65774b-dc05-486f-984e-07c39ba8f6e0", "IFF-1/1", "AQAAAAEAACcQAAAAEAmMy2MCgrd74i56yPRwbvmezAzUrF9VeR8C8TQUfepTcQId0hf6/pnTk5CP2JdepQ==", "a06a2318-6b84-4110-882d-4e3a65a7cb4d", 192167109L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440058",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "24438145-1fcd-4f93-bc65-3984cb0ccb3c", "IFF-7/4", "AQAAAAEAACcQAAAAEAVPewwqk19LpVu7YXa3uhw7iVnEu3XzGemXdeD/kKu3LLwFFKdUj1xpye0ZOvPBGg==", "7536deef-0c96-49b8-80d4-68780ef68085", 182473653L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440059",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7c46028e-d510-42c8-b487-58f7c0a092fe", "IFF-9/9", "AQAAAAEAACcQAAAAEFC1kkGenLypBdeWtfeGy5n5hFCzP/vNDRqAW4QEE/T55lH41pIvPe1hGb3AgwoqIQ==", "3529131c-01bd-40e8-b8e1-8e71f30f2ff1", 119437647L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440060",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "790f881c-4a6d-42bb-8985-4ff41913cc2f", "IFF-4/9", "AQAAAAEAACcQAAAAEKM6rW/XGWmc0AV6BTO3on7IR2XAHlFt3qr+YTJfUxX+SgLyebDwpqwK7cy2ISHDRQ==", "c93b5b27-a4cc-4ce8-a8d2-cf4596758c1a", 149402631L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440061",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "07e5f8ab-1aba-40eb-8bc2-28a330cd212c", "IFF-2/3", "AQAAAAEAACcQAAAAELBV1TypISWpZns4/DkVBXjsROca5BntxpPv+lo1pGL+UjLswC0tsX1gZe/hKYJe4w==", "295a0a9c-d3ee-4ea6-806f-adf355f0cd17", 141303750L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440062",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5f115557-eea0-4513-a5c0-08957f796054", "IFF-2/9", "AQAAAAEAACcQAAAAEBq50tcTgQIdHRkMZYtWn0V4xAxvnl59u0DZGQDP7O46Lj3IfpmP7Wdg5m4OWHgArg==", "690ee735-923d-4b01-a08e-8a934c03a1d7", 188195770L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440063",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2ced1043-b337-4bad-80dd-c2045d22d068", "IFF-3/7", "AQAAAAEAACcQAAAAEHz4zFINp+kaCy2tuKQKlfGYPiOIPi5reQu8yvGgHS+jO4HmbKl2K/zMfuZo18xOIg==", "226bd6f8-ebe8-4ead-8834-9ebd825446b6", 124022653L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440064",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b33faa03-e417-455a-8c1c-2b6355628bab", "IFF-8/7", "AQAAAAEAACcQAAAAEBb4b/IbXJD9MIN4Y4NfI38VhL/N6FIYGccWHi7L5QsIdM4RnJfco1tb3d6PiHMQPw==", "06923bab-ac1f-490d-be1b-0aaeb1b3b6dd", 100890762L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440065",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "eb47d7b9-4ac0-4c55-bc1a-f07f6894ddbb", "AQAAAAEAACcQAAAAEHJqj6bESuGrMX8YZ+JCTq19YSJ+rytuPudSYGBhfl9IFp1rBLMd4aAN/50h8rW9+A==", "021c05dd-97f1-45a8-8ff2-512ab7314117", 109330230L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440066",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "abe6132c-a7ba-46cc-b588-4510a87917f2", "IFF-7/4", "AQAAAAEAACcQAAAAEN1ebx6p5ogexCqNAm7fqUJdvrsKh9roVOtcVNcTT5+1vpRUHZxpvv5M1MLJYopD6g==", "3d64719f-167e-4630-b99b-0c3f60ca3094", 164079630L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440067",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0ecf91b4-0ade-48f3-b734-b86c8132053c", "IFF-3/8", "AQAAAAEAACcQAAAAEGbz5E2+sj06m3ZcjQbzDbE19Ko5a+3izdIoyhciVgxPLTIyS9+5Xxt93BcXRwJzGQ==", "175ce409-f85b-4d06-b2d7-fcc427443e22", 132813453L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440068",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bd77d922-5ab7-493e-88b9-277d0d45e4af", "IFF-1/2", "AQAAAAEAACcQAAAAEGDNe3bddTMIIun+SHTFkUbdTtBZPAIm5tAm1BidmqmjQeb8H9yIknO1g05Ul1OaeQ==", "d055801f-7698-489d-a35c-8949f6f8bcb3", 133031582L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440069",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "860c50c4-e1cf-4449-8d54-5735fdd22db4", "IFF-6/2", "AQAAAAEAACcQAAAAEL/UZzBsHVRlqvo7Ugx6pHiB1baG/0Tk5Adrcdtx0HeT8DwfmraChJE9kwYT6HG3aQ==", "b8010e16-65b3-44dc-8f98-a57027f89dc5", 138617632L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440070",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bf4c14c6-c07f-4ec9-aeaa-8eda1a9d0c03", "IFF-7/4", "AQAAAAEAACcQAAAAEN2NNweOsKZDc4YTEb9MMgbXkGQAcFf45W8jpV5r7B92N785bB8kKwt5YoMFo6YMYQ==", "439c7753-bee2-4e88-baa0-4cbbfa2fa9f9", 159618985L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440071",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "37890f04-aa91-40af-941d-159b6cfb8e2e", "IFF-4/7", "AQAAAAEAACcQAAAAELIvtfpJDgCMmtCOx535bwbG36QUd25qOqTlWaTfIspqObjepFZk2RUMCSJ7UbP2IA==", "585e2118-fb57-4a81-84ea-c67f77383bc2", 169678738L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440072",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0f326693-d885-4c5a-a944-38407ecbc4eb", "IFF-1/4", "AQAAAAEAACcQAAAAEF+9gPTz0OKcMXzYnMk6QxsPpOXOft5V7qT7cCYHtT0QONFtfEvRe0KuS+kzf/xVLA==", "8d02473d-5e95-471b-a36a-15c93bc88e96", 184579672L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440073",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fcd77cd2-3099-423f-8b58-1fd0f5d625c9", "IFF-5/6", "AQAAAAEAACcQAAAAEP9yWrGbG+thA1X/TwXLDsFdsbIg2rQYlZifWtCn6XMzBmmdhMnuhgbjy73m1J++tg==", "9107dc23-50f7-487f-82bd-ebd29347860b", 178453773L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440074",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "10cc7a1b-fbbc-42a2-b8a4-3443d883e427", "IFF-4/8", "AQAAAAEAACcQAAAAEPV9nTaU+067tGFbgaoRL88/ZQTdkyWPwSzZ9EbgRDOedCnKeSB3ln61jr9PuoGPJw==", "c235532c-6b08-4167-a276-12469116cc06", 162799142L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440075",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f0825099-281a-4a79-85fa-ba0a5d721a4a", "IFF-9/3", "AQAAAAEAACcQAAAAEC7Xop6sqQ307/emKWIo++BOnXSuz+7F8e2ZgZ6xA3qrdIIw2CYaC9+9meLqHSmhLw==", "ca7e374b-100d-4ce2-8b23-c21f952cd650", 155846782L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440076",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "72e76bca-4b01-4bb2-9ecd-37dc02a9160c", "IFF-7/6", "AQAAAAEAACcQAAAAEKRNm+ina2KYWVTLhP9EYzj2aSe6GYUcvVxM9KmMm5WHuvfrwH51U2BKI77OPgLqLQ==", "3abf1c9e-b5bc-40cb-b78d-789ecc5d5559", 136118996L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440077",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e838d755-d530-4855-a3c5-3b1dd6370297", "IFF-5/2", "AQAAAAEAACcQAAAAEDuJBLIcJxNELfoSXLU7FmMuFeHCTcd2YbVxi+pZKa/JHgtldIE03p1B4u4I23I/xQ==", "2d607724-cb83-4b26-8988-7837be09c331", 161501067L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440078",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3a38d0a6-84e1-419a-9118-eec7fabe08a7", "IFF-2/2", "AQAAAAEAACcQAAAAEJbbxH8S9htPec94VkW5pvOaR+B3gHOl/X59z/bRp62nDLyXtWt63+UnUUyHrJM0Gw==", "7ee5cf4a-9898-4865-8a66-34644e237d5d", 153890652L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440079",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d7c7780e-650b-4ffa-bf0f-0f122cf72508", "IFF-1/2", "AQAAAAEAACcQAAAAEAzHzrmfatM2M3YGPFVfJ0sUCys+IWdzCzacjGjH+rPy4OR+1yp+uNWWbokkOQKdqg==", "44cb425b-70e4-4a5d-a3b3-9c015decfdea", 109947516L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440080",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bf24fcb1-9d29-4614-a9ab-be2e38bd3788", "IFF-5/6", "AQAAAAEAACcQAAAAENppZE35mgojlonhFULahGx74dZxDjJKX3PF/S8pq/XREcYKtnVux3GgDfTf2fj/Pw==", "b71dc20b-d34a-4564-8dfa-78282960bb42", 105888365L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440081",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d5f8ab28-223d-4f7d-bba2-0ae19323b517", "IFF-6/6", "AQAAAAEAACcQAAAAEC8XyfU7WzCGemZVqEWmPcc4/ftDfTw9p+lU1yZHXPQLCAnhbMBG1rRvVnEQw6X8/Q==", "e1668417-a861-41e2-ba8b-1337f83a3e5d", 177010066L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440082",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "56a8ba54-83f1-4442-8e12-513ded30c715", "IFF-3/5", "AQAAAAEAACcQAAAAEAJiBuN4feoTrx5jFRv1JDE1+dRN8avUBo4frgg/Ml+L+rALsQqMkV/bZ1DWnglHPg==", "151006e1-f4ba-41b0-9bf5-dee2ff5937e9", 136361536L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440083",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8c211109-d2f7-4ce4-bbff-9321e546789e", "IFF-3/2", "AQAAAAEAACcQAAAAEFa1rjAOnjHhD/QVWKTHEH/H4+asTI/uwbSUNA6U8XmtJU2/UzNOvau9FT3We87vng==", "4a59c406-4d89-4d43-a9aa-ce6dd7aca172", 106993590L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440084",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "87b3a9f3-a035-4bc8-8570-a69a377eefdd", "IFF-8/3", "AQAAAAEAACcQAAAAEPl/qCL5wuRkx25tuN+X0nzhF96SqqImqJN/CRC6d6bOaMIEnq6gobXwyYnIkIIA+g==", "081b8bb1-0ee1-4f68-b7ad-9c1830b38d41", 134786782L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440085",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d94625be-0911-4d2c-bde2-c923ce022436", "IFF-7/8", "AQAAAAEAACcQAAAAEFHXcIL9VW7oqKn6u87APYALhoLzkDe6myoclc3nflkqRZRldOdg66OZvig6fVXoKg==", "419788ed-40b2-4cf4-85f1-0b2ae14ad2a4", 175096473L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440086",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f6b6fa6e-b55e-4818-8350-b497f2c57295", "IFF-7/1", "AQAAAAEAACcQAAAAECVIxlJ+ZH0j1jcD7O++Yzo0G0Pq2m8UO1sgCJDLOetqkrUnUOn9MIrhPANiOL8zbg==", "bdab52d4-5c4b-46bc-97ec-6339ecb3855a", 196303868L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440087",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "629d0e49-d559-4e17-88d1-24db8162c2ea", "IFF-1/8", "AQAAAAEAACcQAAAAEAqvFHy2OnstmV7jLsLhE1XAuSnCwSe0xVY0biEmeX9zX+qF/gnxY0IopN0AHzkRcg==", "7dfe0665-264f-4bb2-bcbc-8d17fc2e231d", 198157789L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440088",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a97c0879-9f8d-4f73-bfb1-7d09d0d558a8", "IFF-9/2", "AQAAAAEAACcQAAAAEPeJBGMwUfOLFXMzagnXbaFwmp1yh9koH0nv4zHU3RukMcWifXs1tSgq9CynpOi0VQ==", "a8abaf4b-bf28-433d-a220-27d7d3978c2d", 160794045L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440089",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "44a3d4af-3b7b-4708-b350-a26d9154bd76", "IFF-2/3", "AQAAAAEAACcQAAAAEF1l1zGLkfSpOxpBSy/iK1OcklC+1SW3PyWHGQVFOgbKWV537ctq2VW/XFQHkKwayg==", "b22dc94f-ef6c-46fc-83c6-deae170090f0", 116857406L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440090",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3544a2be-7090-4305-8712-c595c43b2ef6", "IFF-7/9", "AQAAAAEAACcQAAAAECxcB2gIceD3B/v6Zpzpuo4L49+7s//LifybGK3pxgbkvJTnTeBrzA+y/eAc/+gWLQ==", "28a8b376-49d7-4514-89cf-71582d1fa13d", 148456786L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440091",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1d77be7a-8b96-4aeb-8e86-f03cfe033f54", "IFF-7/9", "AQAAAAEAACcQAAAAEE81FypUzVz0/44bIAjb32Cvo9GCRg97OIc7LUUpGKWP2zfJkGLYn1k/fkcCqw3sfQ==", "22340a63-14ab-4800-8462-3fe76accda4e", 127101734L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440092",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2212fc9c-dea6-47f9-b0b9-5518fde95b5b", "IFF-8/8", "AQAAAAEAACcQAAAAEDAS2mkR6ITflavSh2ao/phDT2T9OmG/NS4WxV2WZjmw6Gq4Pepn/IaFpwwR3bg84w==", "59ca0649-3f5d-4f1a-bbb4-efdf95dabbe9", 109490525L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440093",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "661b271e-4c3b-473e-96b5-7d1844539e58", "IFF-2/6", "AQAAAAEAACcQAAAAEAWgXMHq+410Z7SSQQlQUOOBx6XRm9oL29L80pVieAdXuBgdxAmMNyrKKkbQWBsc5A==", "2536f80d-63bb-4137-b61c-a1fa4ab66ba3", 125478950L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440094",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "32c7831e-9f71-4c0b-b328-d82ceda68c81", "IFF-3/5", "AQAAAAEAACcQAAAAEEiHIs+epkazbnlZaIlL/l93zlGY0/5DDitCncy/I645JfRbzNsRZZP051At4P5LWw==", "7a46f3f1-c37f-4785-9423-35be56169df2", 177689040L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440095",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d16f247b-dc93-472e-9f35-f80cd59b905b", "IFF-3/7", "AQAAAAEAACcQAAAAEJMuY8v7wxFQMy9vEmKpSW3GHCQIVXoUYG5d4+Cqic4aD33ZaTGAhKtlnH9ERcUQDA==", "24716874-01b3-4169-a22f-d3ab04c1a0c3", 149617583L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440096",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ae82ac81-aa3d-4bc0-be1a-a3c4f22f2c26", "IFF-8/5", "AQAAAAEAACcQAAAAEDoquIrEkwLfKgPFMOSgp8HxT9DkbKYoBQGGlZM3O1qlC+fkKkkQ7x3NmYCKa0/DZQ==", "a1d5fb1e-9c90-4464-ae9b-285eef5410f1", 192939174L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440097",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "34517579-b007-4c61-9ae1-334bb5edbdc7", "IFF-2/3", "AQAAAAEAACcQAAAAEAGttcSn/LXU3NnUV995fj92w8CL7IluV8YbsTj6Zt0IVM8+90+3Rxw+CyUt8dl1+Q==", "576dd8ae-ba8e-41d0-afbc-f3e8a9b31615", 137326205L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440098",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3c39585e-12ac-4054-b803-9e96ddc33c1c", "IFF-1/5", "AQAAAAEAACcQAAAAEKvEad1omMIARA6GslDPGhdTfSYtEv+siEOipiUShJKijVsazx/KGgf5hWYceGMSUg==", "89c1c4b1-027c-4ee2-b5c3-dbc2a9f373e4", 105596481L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440099",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "20521db3-75ec-44e2-ade6-b85e2bf03936", "IFF-2/6", "AQAAAAEAACcQAAAAEGcrshnFc7hezGy22ca/Y0k7TMXg4MO2WmECigADjG1n9z5pp8Zi4Ca5P/JvqIFoiA==", "f0eff186-c9f1-4535-b58a-e0360d812c1b", 167345242L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440100",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2fdec1fd-deac-4279-a53f-bf15afe1fe18", "IFF-2/2", "AQAAAAEAACcQAAAAEDf8uQsQh6J6fCK/f634/kqq/OfXcsyShA8QBJGcXSxe8X76oP48ur/MG97JMHGHKA==", "ef7ec324-ff75-4c70-a805-baaf0497e5b5", 140103532L });
        }
    }
}
