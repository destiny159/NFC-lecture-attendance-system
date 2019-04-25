using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "ca29d0bb-3ffa-49b6-8796-7ef930a18abe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "dab26348-fa0d-4095-8c46-99c0ea2ea1c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "e7a895cf-2243-48b8-9190-ef8b01a851a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440001",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0cc2e79d-d4b0-4664-905b-c96dc2597365", "IFF-8/2", "AQAAAAEAACcQAAAAEJX/SKiWWmkRKVLZeQS9QxPoYBcB5GqmsEmKveTP9MED+swm+8mr4aHTeHjUHls7qA==", "4416a62e-2978-4d89-b4df-75f0d442b81e", 109729216L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440002",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2e26f2f5-c35f-4424-92b2-4180f78c77f2", "IFF-2/3", "AQAAAAEAACcQAAAAEOP9WM9N9bv89uAAkqEAj8Fcx1ZBhGD49uab6t6DYmAZVSoZDMg4fgZj5mX3m1fy8w==", "66c0a5e8-16c3-42f8-be27-843adc6e89cc", 129862731L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440003",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f6ca92a3-3350-4c34-bed6-9fe91377c7cd", "IFF-1/3", "AQAAAAEAACcQAAAAEGwvA+OvDTGH1F0+nB4h+8qTo7OdYxtVcQ3l2VuRlMiZN3fBx1Fr5LuzQ+25dp94Hg==", "8e79a8fd-0e3b-44f8-a46a-c60288a094a0", 130743866L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440004",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2adcf98f-a693-4854-9f35-832761cce174", "IFF-5/9", "AQAAAAEAACcQAAAAEN7x3FuApN5PYwSwL4HjEJsBRazinJfhnVcNVZ/yjhOBSoLuwSb3vG9hPZ4p5v2CjA==", "bfcb399e-349d-4b79-b1de-c7aad98380e7", 196146847L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440005",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6b8aa914-9e72-4a31-bc94-80c2beeddaaf", "IFF-8/5", "AQAAAAEAACcQAAAAEHP6ZGQrOXdwmnAZZU63gL5JiO0H0Ap4e3tgqx9bQgFIZEgfU37n2qtTUQBnpbH8gw==", "7e3f27aa-4a06-41af-868e-1cab079c6ac9", 132312940L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440006",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b16dcef7-f222-4bb0-bcd3-62a87c24cc47", "IFF-5/7", "AQAAAAEAACcQAAAAEC2KnBACR7NTWoxLc65VwxxzrS/OdZJEU2wi6cv0AP3g3zwFarH/QEkV8mxDyxvU3w==", "835d3cc7-0fe8-4a6a-a879-03c09f26a66c", 133743747L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440007",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1d05eb9c-f1c7-4cba-9dd5-646f15fe6b8f", "IFF-2/5", "AQAAAAEAACcQAAAAEEA1IyKGiEJp2gMTmJCQmmFPko8f+VGS1M63zyrfQLGjUh42cg9MS7GH9lWKndKadA==", "661fe36c-4798-40b2-8420-c9096002e1d5", 148711148L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440008",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b2882a3f-5c7f-4928-98ae-ae871d6a701b", "IFF-7/7", "AQAAAAEAACcQAAAAEOuZ03ohObTLfmvHGha1p637OEtekz2o8FNTsMuSzqCgzPLJBxpDV1UJel3LSXzbpQ==", "9459cb7a-dbfa-4ce6-a486-2d18834092a0", 105686128L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440009",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8522ed81-4c8b-4ded-8d70-a2fdf411c39a", "IFF-6/8", "AQAAAAEAACcQAAAAEIhSqB4qWyRNpPpJMPkl2V9xxrjGDstEKIbv/htYgN+x2TOYwyt9H4dupvWaVjO3dQ==", "6b2e052f-42ca-4bd6-b509-d17638650e06", 157182093L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440010",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0399aa3b-a390-4027-84af-f23b1d8ba1e0", "IFF-2/2", "AQAAAAEAACcQAAAAEPo/YZNIOrr8SW4rzT7wPJZxVy6g/PTLa4TvW/jdGVVe7Ctuu1cVOWLIxBIlI82aHQ==", "ff33378c-082b-4af3-89be-898778d545a1", 157753834L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440011",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fea14d05-514f-4d17-be5c-35cdbef4022a", "IFF-8/8", "AQAAAAEAACcQAAAAELjszmZuuvu1i0n8vQEzfXtlPGJKUimfD8WIyFtTjIiwsjaeCglXIQlLDT4mivSu4A==", "f24f14bb-d651-41a1-95b5-0811f5ac0b2d", 123652220L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440012",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "de2ea959-b0cc-44fe-88e8-11a58ee1e7ba", "IFF-2/8", "AQAAAAEAACcQAAAAEBxbCRSf0gb3zMovNHOG6jdk/CbvovAi4XvbDlWby2/ISPpLNImWplwlNcdAgWLaIw==", "9409aee8-0a45-4b9e-8182-d6171295734f", 141990484L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440013",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f3b57186-6153-4415-aff1-2a14be657fa7", "IFF-8/6", "AQAAAAEAACcQAAAAEBNrGkLCAHrIllyyOnZfM8hc0E4lc0li/Kj6sr2Yg4l8QIpLBbxe4Fg4Bm4GiMfXMQ==", "36ef066c-a130-4a47-b611-ff99bdcfe3db", 112776499L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440014",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3b950074-7c19-4da6-aa83-cb50b2298142", "IFF-6/5", "AQAAAAEAACcQAAAAEBzVJJ7Io3D4yY3WCr77FPruGcjjbMU/Vy+1arIcwqehkwSi/YJY316Sms/V5+l18Q==", "45924016-d6c6-4e10-9c9f-053f82da75e5", 141049953L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440015",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f5498077-61ca-4592-8003-4c7d62eb6171", "IFF-8/6", "AQAAAAEAACcQAAAAEBhpBIdeaxnO7MtFwuDrHYGNruNeFOM5R+BaFQG+/akh9vkpompo7TOkuUSUC3zVIw==", "72e5ee8f-8ab9-40f1-aeeb-da3c564d7748", 189605311L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440016",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6197cec9-67ba-4f9d-b022-54ff52842507", "IFF-1/9", "AQAAAAEAACcQAAAAEG1vIxXj+1UTpJrCelQohUC+x9KyarhHd3y2Fh1KeJz0zPm0ttr+hCezxxibbEleEg==", "90ab581e-109d-4564-9865-dd71bc24c90a", 190046322L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440017",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8db6d4ac-e055-402f-93e2-794b80c802bd", "IFF-7/9", "AQAAAAEAACcQAAAAEF5zvVsP8OS5PrAcCX86NEPQBsLbIJkZDiTZAwZIZxRcJ1ooXf7Slc1haZv9lToyPg==", "d025bb14-72d4-4705-a320-7f65f2d43b4e", 146218568L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440018",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1c6a95f7-e81a-4036-a7fc-dc92317220c3", "IFF-5/8", "AQAAAAEAACcQAAAAEMRqpHPBllHdnJhdT8IUe1885DOnQPZT4Ov4Wx/RsGLm5NU1KnVDtx9pRfOUKNYOzg==", "744a1987-8dc7-47c1-a148-b3d973347ea6", 100252831L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440019",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1a0abb0b-2dc3-46e7-a8a4-20a3b338c834", "IFF-1/2", "AQAAAAEAACcQAAAAEKlrKOOyTNtknNHoisaUk/U9kHnPC/8aVHX91EGlbLZHSP08KYVszBBoaPksyM9omQ==", "ac00280c-a604-4244-a38a-8876d63d5592", 179777764L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440020",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "beec00bb-95d0-4c14-b599-9bde56c65882", "IFF-7/5", "AQAAAAEAACcQAAAAEMd9UYmHr0Z5ayzU2gXtikdDROXuLoBOGl1+3R0AO8LPXPEHTNTlkt339DtYkBZjEw==", "605f7e4b-0e5f-4491-8f5e-40b71a4095d5", 147041263L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440021",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9a44ab3d-10a9-4495-bc83-2b2cdb0a0007", "IFF-7/9", "AQAAAAEAACcQAAAAEK0L03nbiMqRrYKnpguDhP9SvrZa5mwuyndtQlPNY2VN325diMgBKVq+nzVYxVbr3w==", "91f303ce-473c-47b4-8a09-43ede22d0e00", 144492468L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440022",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fac8ce69-2969-4097-b80e-b3ac55c81421", "IFF-7/7", "AQAAAAEAACcQAAAAEPGet56gGYUK1cw/Wi2A8Syx2tVlyzVAsGrspJp8o7Cd2i1z4xpcI/SQr7q3S15W4Q==", "fc2f94d6-a142-4cc3-99e1-cf6ad555eeb7", 111822092L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440023",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a14546bc-4247-4ac3-b307-9a7bae51bc84", "IFF-9/7", "AQAAAAEAACcQAAAAENs194WwUjfxsrr2iuKmeuccTTLy2QPCbJFv5P5+femLy4+irrhadglwD41/5IV+9Q==", "c18cab04-7724-4235-8b58-5679446a9572", 110881691L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440024",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "007392d5-67a8-4f59-baf8-26ba2eb0c8bf", "IFF-2/6", "AQAAAAEAACcQAAAAEMaNLg252RtVe5oV7SDS/HC2aSzqs1TBLu4T6ZiMoEJJfpK0UOggkFiSlR4Aw+Zh8g==", "fce3a76c-d1ab-4892-8cc9-604e647c28dc", 164377535L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440025",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "619a8da3-4dfe-4d0f-afde-f51073b5df72", "IFF-1/5", "AQAAAAEAACcQAAAAEOBxFa6YyPChNtcul7+V/hTCtHtoxIDGrStyiR4Lzna3j1afmIorw1SEp8YGgSy2pg==", "0cfea7b2-3bb2-40bf-8278-921c5b758da5", 113177034L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440026",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "53c8460c-6721-4b1e-928e-d0d8e27a2bb2", "IFF-2/9", "AQAAAAEAACcQAAAAELYps0VKpo6Lvc70W9GxSdgrDk3+PN4lQUSrABLV7ZD8czpDaEyKEhy5jKHKliR/+g==", "5ea3bf6f-ae25-48b6-be57-ee8344f61665", 104566520L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440027",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "571f2585-5087-420e-b24b-2771de00ba68", "IFF-7/6", "AQAAAAEAACcQAAAAEMI7au9chVuV/NuaMcfWQSbH8lBe4kjpcu0y8FGpG7N2RP42/9wsFGW4XL4fQ14GmQ==", "3d740b84-caa3-4476-a13b-808f53124c78", 107242217L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440028",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f5a9fccf-8226-4c8d-8402-5adec03cd707", "IFF-2/5", "AQAAAAEAACcQAAAAEDChRzzpWu4lsfmRsdNNFASt3hph2091X2U7MNtNVjuPNw6LHwuTbFEFptYjYr/RmA==", "baa9a69c-17b7-47eb-8200-d976d9cf5554", 195015430L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440029",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "766075c6-a5f1-4599-a5df-3e59c31ca9a3", "IFF-3/3", "AQAAAAEAACcQAAAAEKZ4kX4M3Ph41PCR7qkinvp+LfW4w6L0h9fbmq4/2WEGYYVZAp4zPTvMMCjrzRZuLQ==", "affbc175-a8f7-409b-b33f-73d2386da045", 126148593L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440030",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "94a0c030-bdd8-4bfb-843d-8c1a4d262add", "IFF-6/2", "AQAAAAEAACcQAAAAEMtMtoPGekqbF98+N5+Zym8LZ5BePdESR4DU5p1NFAqXNNHpzm1TtnjgJM0nhUQJew==", "1346e096-e527-4437-b343-da0337751987", 106938608L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440031",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bd9038e6-042b-4d84-b2cb-75591f16ebef", "IFF-6/2", "AQAAAAEAACcQAAAAED4AcmWmrP4k/RkohhPLGTmA+dI6/P3CxMRKCI0sAYRZCjZKik7XlH9/bjhmLH3bOA==", "3a08c981-91cc-42e3-b77d-3a1b36671624", 172778141L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440032",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5113029e-02d6-457c-b775-ffc56ecb35d6", "IFF-9/9", "AQAAAAEAACcQAAAAENdp7oM8R6/cwMPbd1JaYTwKQeLBfd52v3uJoVk8lKiKeOFqVBk4Ueli6JSOwDeJJA==", "cc317c21-c1c7-45fb-a969-19d092aaf8d6", 108645409L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440033",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e0516959-696d-4386-a401-8bca50ee2cf5", "IFF-8/1", "AQAAAAEAACcQAAAAEAK/8XfvTcOpzJg9/ZkUwDDLfTMzsFuMpS3eJonjmHnthCCrCDOrGOZJBEVGr8gdOg==", "9aaa2127-5279-4796-a52e-dda9d943abb2", 152923265L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440034",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "736d953f-a9ca-4f78-9fd2-fc25696a393a", "IFF-8/2", "AQAAAAEAACcQAAAAEEmkmzW0AUHMbefZtodpQVvspYKieky7U43hrlWbOs80/S8c6yAlmLwHxcVdgZYUmg==", "44c594f1-4e7f-44bb-a497-a080cf870251", 192234926L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440035",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3f84ccba-c57a-46be-8b77-0bfe8511fe8a", "IFF-8/5", "AQAAAAEAACcQAAAAEIONkd4KirQ4mKzRCLTFp3XGmcfUvfUoYjBFEHy6BZqjkhSBkthELNlhfcUppBu4HA==", "49de9221-d044-4181-af6f-9d937f431517", 122388261L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440036",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "92cdf9ce-46d5-4e95-a758-fac3bc8ff18e", "IFF-8/5", "AQAAAAEAACcQAAAAEJGQuAnzOYkdTN0cpnWK1wlZc8iykhE34GFJaATOwoo0PZ0JWeH5LFzz6gc61lj4IQ==", "39da4813-44ed-4125-95e8-409e0d0c8dc9", 128693204L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440037",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "62a51a1f-c89b-445e-930f-c9eaf8bb8544", "IFF-7/8", "AQAAAAEAACcQAAAAEKXKN0Q9/LOBXh9SDdFbTUhQ/+Vx9N/hN3htAGP8zeOrXSaNDqHG39SWSRYW1dYUEg==", "3a2ecba8-a991-47c7-83dd-309005ea76bc", 129543972L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440038",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b47a09b0-dc53-4d74-8eab-3db16b96f3bb", "IFF-4/1", "AQAAAAEAACcQAAAAENL5jhHl5Gcf6Fg+po2jtIuKE+JsMtJ27rmhOpC34GSF6+zdiAtdL+flS8/+JgZYjA==", "e5326dfd-c411-4d6d-9db7-f15ad0ac8d2a", 120564511L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440039",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f55ddffa-d3bc-49a1-af61-df0975c3c470", "IFF-5/6", "AQAAAAEAACcQAAAAEAoa4Hj+4lJGZs7j5iCglahYHRbom+GGHvmTYckTBWeGuAILnHgrgMcdsq8Uc7bgbw==", "aee4a5c4-fb16-4121-af07-de74fdb0631b", 194182966L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440040",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1c9290f0-1048-4b15-bc20-79bfc4021217", "AQAAAAEAACcQAAAAEOhyUjdnK9lRxdZ+r5RD+MbuihRI2JHD9jhfbjFNEj4K3ULjl6hXHL9VvLktlF5fCA==", "57aa1f4e-803e-432f-abcd-b3d2491d56b0", 147270293L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440041",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7cd8c9d7-3697-4643-bdcb-a8880091a1e2", "IFF-1/3", "AQAAAAEAACcQAAAAEL9Ir3GolVfpc2LPrircKb+r4hHPf0G2AhUC9g10UuU97PnGr0fwojCcAulncsN8Kw==", "f206f3c5-db18-4e5b-979b-ff4036883237", 136464217L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440042",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "15d0a281-28ce-4bbf-9db3-02691a7edfed", "IFF-9/5", "AQAAAAEAACcQAAAAEA/s3/PIYgfOKROBSmzcTHdA6R/XCA1jLV4FvSg+KLqqCkx9f6e3RUbpNnZDhXXRAg==", "4cf6a53c-7a72-4880-9e7a-026c398fdc1a", 156503417L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440043",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bf5bae32-110e-4687-917e-61d8937267a0", "IFF-1/1", "AQAAAAEAACcQAAAAEEI2UdRbUqktQYCh7iopPO6pgcmzUm/ybopq+IU2eP4GDZkOn3o5T0Ip1OIQwj5E8Q==", "50a62d52-5a88-46c4-b2f8-fde09020f2a5", 150211813L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440044",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2afe08f9-b145-4677-b295-0755883b33fd", "IFF-5/4", "AQAAAAEAACcQAAAAEOy5KtRu1cTw2j49UGl84rLO+/BsM1xJkkfekdp9up2JHMQCxU4gkgFqDIWTP6SVHw==", "e983d9fb-9a54-43d1-a5b1-30e570d07a86", 159702307L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440045",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "97edd23f-98f1-4b23-8efb-be3caf193c2c", "IFF-2/8", "AQAAAAEAACcQAAAAEL/KGsK5YpJfRqMdwix00Y4DNGNbdUtxwfB0hO7AYjnpL44yaCrDxrbgmidcaUyYIQ==", "b4a6de51-4153-45c1-8194-1945c1a31ddd", 186927984L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440046",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "79997742-c19a-42bb-9f62-4fe40cc872f1", "IFF-7/3", "AQAAAAEAACcQAAAAEDqb/CbyWEfb+3cb5Zr4zb8pBQv173mE75+hS9yD9XQTcmFegmm3uGScwNa/sCS56A==", "7e5d3b9b-604a-45a4-a070-6a54a5a39e81", 145003921L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440047",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5e40e0ac-4a65-4dba-ade0-61683d89eb5e", "IFF-9/4", "AQAAAAEAACcQAAAAEMVWHkUyXrr7YQD4k0P+Todgj+y5ueRhFyZzOeX7Vyqa+MGrKyYjI3flMYOVX8/NoQ==", "449bd95e-cc82-4731-bcc2-ebe21b386940", 100136311L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440048",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9e374e68-f294-4c41-b443-0edea3ffd99b", "IFF-7/8", "AQAAAAEAACcQAAAAEMDpXehzgrV609bGtPiHRLvnp/4hTn9U7IKft4BTgZPv7rVVNyPXMxbCnYm/kCm4PA==", "c9522128-ef72-40ab-8239-8f95b1736c7e", 185193514L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440049",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5f96054c-8eaa-49c7-9e0b-9391ab89ec3e", "AQAAAAEAACcQAAAAEOthaS05UdrhCf6amWgKSE9mZfsvaVH1kAkmK03eJgx7lRyJ4nddboy/9UW2us/OYQ==", "39bc58c4-025f-4471-887c-c3d16c791600", 124735538L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440050",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5f7fb574-3a99-40b9-98b0-1e7fa297cd78", "IFF-2/5", "AQAAAAEAACcQAAAAEDxv0jHsNL+R153NeYaEmOt42WBfUrnXq4e4hGBIzCJGI8XlR6izpdLV3LeYSYdnOQ==", "fe7c81b2-c724-47e1-992e-beb7990bd275", 106675279L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440051",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8c6d989e-cc61-4a7c-b5a7-e74f85b78607", "IFF-1/9", "AQAAAAEAACcQAAAAEG0ItV1t1Si2yph7R0POAAjkBsT+cFP/tLYnHiQZZzWdMcw/rk0PUHgnXa3sm+o5eA==", "2db390d2-e5ea-4290-ae44-dd236674d879", 130527074L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440052",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9c4d88d8-9b77-4fb4-a173-8e703d6e07a9", "IFF-6/7", "AQAAAAEAACcQAAAAEOQrWkoKgJALi62odmLYMmIWa2XcpxqvjuHOp0ct4CS4F4NIE7bwDqnoRqrgdJki5g==", "4607ab6b-b494-4fb1-9a14-c04e9aaf5775", 156749666L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440053",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4b975f11-0818-44c5-a0f8-3089fe58b454", "IFF-6/9", "AQAAAAEAACcQAAAAEO4RKhUd85AwT9Irxl4sQwfN5K84v7AJ3AXjf3jb1m7HjB5EFeWzEBWCqbABTC+0cQ==", "9422de5d-2094-4fce-ade5-36519362b4c9", 185018050L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440054",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fdfbd090-3a69-458d-86f2-3309ca30bbdb", "IFF-8/8", "AQAAAAEAACcQAAAAEMBhTppNjBcsu/VqL39Ww/5AAU9wv0gJ4FpnR16F47HD0GlzoZwPTa9QEXyzwSi3EQ==", "2bd14a2e-61eb-4747-b17f-9928e830022e", 191220752L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440055",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "254f149a-fcfc-42c3-ba2d-acd0ef1254bd", "IFF-7/3", "AQAAAAEAACcQAAAAEOBYucqA1zeH+FGTM2eP7Hw5MNknA5alZMMlIQrrV+GElgFy7XOLDComG1G2P2GMZQ==", "5d1ebb23-1ce3-4321-812e-3544ab980e14", 135339539L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440056",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "596e55e6-c44e-435a-a6fd-112830e193b9", "IFF-4/3", "AQAAAAEAACcQAAAAEGVpdbNb/RWjm+PBzrrttO/Zb2S8pvZCiCA+pvXU7hzRhIfR1SHdwlNfO3I4uUaHWw==", "a17e97a8-2279-43bf-9b9c-a4f1f3dd379d", 149664679L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440057",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0894b5df-634d-44da-a850-3b43e0e4e7d2", "IFF-5/7", "AQAAAAEAACcQAAAAEMMtXWiCL3uNCvvy7azUcG4xwab8KtYUZAqbBCKq04JNLMhPq0iB0yT3ETVtBLH5qw==", "580bcc2f-50d9-47c7-8aa5-d417167bad2b", 117573729L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440058",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c06c79b2-6902-440f-b1ba-16319f4f205c", "AQAAAAEAACcQAAAAEKMfw5FsMKq++2chQ93e9iI7KwayqrxPv883m5nJJp9z2OsjkcFvhD+P4Xmouaf5Qw==", "6b32cab1-6def-47f7-aed7-101fe7392bf8", 131760532L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440059",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "efd78924-fd7d-4072-9c69-7d618231e659", "IFF-5/3", "AQAAAAEAACcQAAAAEIC35lptpA0A2upUpNTQlbRlnXzROe1YRx6rH0laSA4vDOZUAK1HJvT8NINZ+FF2oQ==", "4b9179b2-a8b1-4e9d-979c-d70ec6d71dbf", 112771645L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440060",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6c8b3554-90c6-4e75-b803-1e3b17a4e5b4", "IFF-3/4", "AQAAAAEAACcQAAAAEH9DWVJCefnKZpYwU14y1DUAzVsh70LDAeSpO8BYOmz1yJNnC+kdtFxcktZhSVgdNA==", "511bfd2a-1913-4e1b-8d77-d5e02e40cc09", 141108264L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440061",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b5613b20-a7b8-4f1b-9576-8cae7b96b539", "IFF-4/9", "AQAAAAEAACcQAAAAEKtQ4T0mU9fK4klpN15hfumyvK+6sj3pr0wo6jGtxSoPZGTvhV/WPwJJSYfOLG8hWA==", "f899a17c-1fa5-423d-ba4c-2fb5ea87916e", 129295827L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440062",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0b6ea24f-7d35-4ed5-a03a-46d3a7617422", "IFF-3/5", "AQAAAAEAACcQAAAAEKsO7iC+iNWvjsLuGR8oMh5Plwv+IEN6HJEG9ViuK3N4fcVvINa3K2KIpTB23GzC0Q==", "19af4f4f-556c-42fa-96fe-1b5c86cb45d9", 164023261L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440063",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "21c936bb-0cc3-4740-bf7f-2878ffbd812d", "IFF-3/6", "AQAAAAEAACcQAAAAEC4AOcuXieWFIZ+vJflJcVUR+6zcOP29MrZbzrR1kHJHPcmuKDzZ8uKGNJdpxHaVkw==", "19f055bd-2e16-40aa-972c-d836c7412ac9", 146187871L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440064",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1374ceb5-a031-4473-bd62-4699a221752b", "IFF-6/1", "AQAAAAEAACcQAAAAEHXT4XF0gXWwmzNcH/ySSiew97mTA+ljxgiBh4/6m11T15O2BWfHVI4zYRXjkVvBMA==", "763cddd4-bedf-4f3f-92c0-aee5b357f965", 112749588L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440065",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "394d800e-f14b-4d5d-b60b-34bb546d1924", "IFF-1/2", "AQAAAAEAACcQAAAAEDoHjiSb2Ovq8YzgvCfP85XGaq2BimRi+KuuQaL9auvVjQ7iK+SJu0kAfwuxU7swlw==", "315cd8c5-549c-4acc-97b0-fbfad316cf58", 139452595L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440066",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "763720aa-2867-4341-b33e-eb6a58ed8d9c", "IFF-5/1", "AQAAAAEAACcQAAAAELzOzogWiT5ODXxkAWX6qEFu69r8HqFaW0W6TSwlglFmuRIvQADdyEBpFkN1EF/Rdw==", "98816203-23ad-468d-85b3-d493749f1309", 153779422L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440067",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4b593065-54cc-42dd-976c-462cca699e96", "IFF-7/2", "AQAAAAEAACcQAAAAEGpHDcjBBQlFvn9vCoLl1bihaAjLecP2DLJY43wRniXApoPnjcFozDenhnDPvwIysA==", "ff286070-a8ea-4cd9-9d3c-7ed087af89f0", 163433479L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440068",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d43fdf35-1017-4600-aeaa-a6b7ab1aa29d", "IFF-9/6", "AQAAAAEAACcQAAAAEMyLZPpra1Id9mdtPauN8qdHjxyQzeIdA2UX+okSpxy8ydkMJOi+rvspauML5KeLvQ==", "0950bff9-e97b-46ed-9273-582904757ae6", 101144430L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440069",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "42f2e40e-75e1-445a-82ae-f2b66c48e271", "IFF-9/6", "AQAAAAEAACcQAAAAEOmDAFPwpDeSCRgUMdINVq3LvDQjAPlhOGiuqC9IcAvwwKTHgcZzLB9twfJvLpQftA==", "8d3a5d0e-1bbd-4673-b184-8c74740c8506", 170230580L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440070",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "31d27e08-f990-45f3-ace9-a5c8bce55e25", "IFF-4/1", "AQAAAAEAACcQAAAAEGwYyX0B7d6lJoqYf60XePNpy5UcBsvok8O5424pWC9iZqVzS2vsCqpwbj1I3MWUgA==", "50b8c460-028a-4a27-b069-50d1c9c37b67", 103891613L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440071",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7ebe0225-a80d-49f8-b564-fc5f9f4729cf", "IFF-4/4", "AQAAAAEAACcQAAAAEKsrm1Oa9v1T3RsP1cE33CZJHkDhornyhIKb1Kpin7XGSVIzxIJXgl5/OUHS89OL0A==", "39ace65c-d94c-48b1-a74e-471a23fa0c59", 148673103L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440072",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "07bb7ae1-8695-497a-9b2f-d7667aaa3306", "IFF-6/4", "AQAAAAEAACcQAAAAEL1fwCGmT6O15Er8ENyRM5MGB6Xl8XoD5DjFZZdVKaHlmwDQAJdzgmP65uxoJCwd5g==", "032bbeb4-b847-4e99-8758-ce2a542b45d1", 150855874L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440073",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ca46e0d2-2f5d-42fb-a184-8b7447985b5e", "AQAAAAEAACcQAAAAEJlElglyzp6Wd34WGW+y+O+8aVyxT4G0IcyrFjmJt1iWDvzltnG+3W8Q7I+THUXoBg==", "7770051d-7319-4f01-9296-abcce078145e", 192474985L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440074",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "055e1033-8972-4763-ad26-6238c70e3d26", "IFF-1/1", "AQAAAAEAACcQAAAAEOsxG1ftQjmHmJNQxxZHb+yevsq8MXI1kvfFgFj9b6oS9ZdVyRAsxnJGbMsGryQL6g==", "d3f51907-eece-4eca-8d5a-600ac1b900ff", 177577710L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440075",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e1ea34ed-bb20-4ff5-bb83-051f6f5f27f1", "IFF-1/9", "AQAAAAEAACcQAAAAEAB6iCjKv7Hze7FP1VGVxJPQgYpTvZT48uJUaqzJw1bHOKgneoF1P8ldQTeVIQ0t/w==", "12a368d3-7981-48d3-8e5f-4e5f9bc41f81", 165555179L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440076",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6be4fb9a-04ba-4115-8bb0-55de32d51312", "IFF-9/4", "AQAAAAEAACcQAAAAEHrMbuACLoTcJMYyUWLX/YTpbmnxB24rjSGdi/XvRGeMuErb1k35f/HZK5zIhrQsQg==", "2da2cce7-b2f6-4ac4-bf2e-8e6193209ce6", 170107539L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440077",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "11bab5f7-480d-4fe0-aed6-758ea67a5fb6", "IFF-6/1", "AQAAAAEAACcQAAAAELtIsX+hAznR8pyZVtk1+wXdd3Qg6GpDgScolXCchD5iF6N6Eaayte+twCjrwwBjfQ==", "39e2a6bb-caaf-4ff4-ba34-be23266bb8e8", 169244111L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440078",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "01efaa84-2bc8-4b45-8db5-ebc6861b783f", "IFF-7/6", "AQAAAAEAACcQAAAAEBIhvpMJXxp4OeZBOew+LcQkYs08gBna3Wy5+8KHslDs2eCiLk7+6JIvG+zGy+g8Tw==", "c3ee92f5-d293-4a43-913f-ed03318b8bc0", 118995474L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440079",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8414eb17-dae1-4758-8b5a-e0c5f18fa9af", "IFF-3/5", "AQAAAAEAACcQAAAAEC2FYC2erJvnW6V0Wzm93xEzRPX7+5hjFOKAI7zfsw21JmdAsJ9fOBtyAon0eQ6BXw==", "54ca4a6f-d1cc-4176-8921-c5ad7df03bc6", 120808658L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440080",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1c31c1f3-22ec-4bbc-84d0-878d75101d84", "IFF-9/3", "AQAAAAEAACcQAAAAEMs5EEJVIY1/DmJh6zTz5FoAAjvMk2tgvKvqgEMp2io9lQNl3QUXZ4LLXr3TuRiyVw==", "9ed32e74-4854-4ee7-abb2-c10a9912c675", 124785789L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440081",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2d6fb47b-2c85-450d-8b76-07430d23665a", "IFF-4/8", "AQAAAAEAACcQAAAAEBIIPXvD9Y9YxJMACn4sGMlm2NtHSCLrD3sgDjXLi5ZdZEfla1jhmDgBgW8lOK2tUQ==", "f4f4677c-aa6c-4b8c-9fcc-76d889cacb6f", 187471290L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440082",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2a1ea298-013d-48d9-983d-ad366c25e3c6", "IFF-6/2", "AQAAAAEAACcQAAAAEO4tx2HlGstvtuo9GI9/EldOFJWK1hwxJ8Hpd+xeynYpjNL9Sn6vtyOheGbr4T0QpQ==", "0924c608-c592-43db-9814-52507183b4ad", 154736569L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440083",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7dd37afc-ff55-4fc1-a3d2-0c7e842d876a", "IFF-8/5", "AQAAAAEAACcQAAAAEAYeY/p5A0Ufq1vke3w1WtLv9FipVyW2qrtDghRKiU5PZuuWEcgkNQiWx3kkltb1Rg==", "060518c1-b6e7-4157-8448-89c57f20a466", 172625363L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440084",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2ac17e58-bd27-43f9-a106-a1f7421a99d8", "IFF-6/8", "AQAAAAEAACcQAAAAEITZLdXpnwAK0IyVg7LuB5GG/ADT/jDlT+6fbPw8S0Prvviu7sPiDpVcNkZQhqVsTA==", "8e786a6a-427f-4604-a23a-3a16c390e574", 184029141L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440085",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f8d13711-e35a-4a5c-ae59-d8a648802d4a", "IFF-8/7", "AQAAAAEAACcQAAAAEFKydFoV+M2wEbX12jB2vxkVPSO4dFwf/DUYDBQT3L7iwQH9f8QIhigBRvlziRrTWQ==", "06841b26-2f55-4758-beee-22a1b427906c", 166886541L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440086",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "71589b1f-55ad-471d-b9bb-4d56f01ff1f0", "IFF-4/8", "AQAAAAEAACcQAAAAELxECxuhP32J6sMO271LyAlYjf8e5tzzgN8cZBfq1EE2Dxg//MX/lVKjhB1qMAVVbw==", "7d089196-e0ef-4cbb-ab6a-f90bf4fb9b6c", 115118900L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440087",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "127e7258-db4c-4285-a81d-7500143f8f3b", "IFF-1/1", "AQAAAAEAACcQAAAAEPdZJnMVpISSowrbIzKgE5UcBXNJybnlBuiRHaqqgxu9xVW+JzgHgHzxy4KOeVdCJQ==", "160f1a81-bfc1-4420-8968-7617e1d5aed1", 176090219L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440088",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "abd43e6e-cedd-427c-bbba-4e8d0636a01f", "IFF-4/8", "AQAAAAEAACcQAAAAEAD7Uy1sCm5HsyM50PAIsMyJJynieFle1yNndZ/LpUoawVOytdBPd36jy4szHpoK8w==", "7fc27436-ec1e-4250-88f9-b17d8c5497f5", 120300564L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440089",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "de1a0172-3b07-4fc3-bd0f-8673511cb1b7", "IFF-3/6", "AQAAAAEAACcQAAAAENhynvvYCoQ6IAYv8cydKpZsxD/1e6v+7P3ejr+1G4QW7s2pCkJI/cIjzIcMGEDv1Q==", "aacb2015-6f39-45d1-840b-b29c6140aa9d", 103083283L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440090",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0fbd3299-1da1-4a4f-804a-6496b97e398c", "IFF-3/4", "AQAAAAEAACcQAAAAEBy/Z/HrKDl68KnWEED+sCsvU+QyT9avwG4qqMGD3fLRBIMqXIL4YKZrZZNNkXGBBg==", "4321db8f-7bf4-429a-854c-95ec727b1123", 177419941L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440091",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "dea3d5b8-97b4-4856-b939-80bec896e096", "IFF-7/7", "AQAAAAEAACcQAAAAEGdNV7Gt2e/038kcP3UM9VgaZ7M0vLeXUtZFEFgmMmS/aXhNyxWdPHhRaIZjHOoGBg==", "e0c17217-7fd9-44fd-b5c8-579659e8371b", 180509871L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440092",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "cb0e60ed-9c8d-4464-aedf-f4fbe168a204", "IFF-9/6", "AQAAAAEAACcQAAAAEFg1h80vkPi9rY7hKc5Pxrr9KyRSb1l+T0MU2KfeWdaGT8CCphoGaYLnBmGWdyncQw==", "c873cf4c-6bb5-4584-87e9-516949289ff0", 110257739L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440093",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e2aa4bc5-01ff-46f7-8c32-8aa8957b693c", "IFF-1/4", "AQAAAAEAACcQAAAAEEVTPl6J0r15MYqvueIadxq1ha62928UxD7vjJ3gwo8p6BBTaVl6UtZd2TVs+Y2soA==", "97826d95-9168-4e4a-968a-471c37f891a0", 117257909L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440094",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "57a14980-0561-4885-8504-2ef04c803136", "IFF-9/1", "AQAAAAEAACcQAAAAEPnmA4+PSqukPCaYoYubcnYuIKHBy8jHprdROM4ONQruBvTepAd2k+lEFvYmX/LdHw==", "0c5a0068-ed5a-4135-9dfa-cf6036e13e66", 173117090L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440095",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a5483987-aedf-4727-841c-7b7e9d9310ab", "IFF-8/9", "AQAAAAEAACcQAAAAEIMuRRaBUt+jXjkLU5riOvW9ga4u5AVzTElo2jHAOzkpDR1iLvU6CNEwtc08LQlA1w==", "31a0d606-ca2c-49f3-b04d-22f29914cc5a", 191227792L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440096",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "52408534-8ba1-4bed-9ff0-bf601ca6f4df", "IFF-5/9", "AQAAAAEAACcQAAAAEB9/VFAQTZNe6VbOX3FK0CuoJLFNGbXNkqNKFmIplf7jJf9D2W38dIf+ADRTD1wYTA==", "ca5378c1-49d8-474d-8667-05ca1e2b4d4e", 122879028L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440097",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7fae4de0-395c-4200-a606-25dc7b5dc0d4", "IFF-1/9", "AQAAAAEAACcQAAAAEOJA0WsAXq8QG0A2yt5FEWwrCNHei9yiG3vH8ndv31sjStxeCjMimDX6pD6SkIiXFQ==", "71793a9a-41bc-4d96-b592-a522b0ea1a09", 185102969L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440098",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "96a36eeb-5164-44ea-9359-28b2e9d8111b", "IFF-5/9", "AQAAAAEAACcQAAAAEHtM/9copNe7HP712K+NY6Tva/6beE98LLwhxOTL1rIix8BZBnurelHFjEZp7SI0JA==", "2766b69e-06fb-4b28-8c79-f2725df47222", 170157574L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440099",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "40cf44a5-4c9c-4ec8-8e10-58202a39672c", "AQAAAAEAACcQAAAAEMfjaUBxJJxmxnwf1sbGxRx/+TYxrhPXQMEzLg3kquZcuNOztSbmvMF1sJWoHB8bQA==", "33120c67-d109-4ae9-9b77-3d1f422b11ca", 123950087L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440100",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "67b3fa17-1084-44a1-b9b4-50e530e246da", "IFF-5/4", "AQAAAAEAACcQAAAAEGtzKMdEX9se7G5qXw/I0OROZJbc4hYsViTStb2Cn51iDbyiaGGzvzDNpiWmFNxumg==", "00e18f51-31d8-4d48-9873-e918dcf531b7", 101214497L });

            migrationBuilder.InsertData(
                table: "Timetables",
                columns: new[] { "TimetableId", "ClassroomId", "CourseId", "Date", "LectureType", "PeriodId", "StudentId", "isVisited" },
                values: new object[,]
                {
                    { 2, 3, "PB0001", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 2, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 3, 5, "PB0002", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 3, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 4, 3, "PB0002", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 4, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 5, 3, "PB0001", new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 6, 5, "PB0005", new DateTime(2019, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 1, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 7, 4, "PB0004", new DateTime(2019, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 8, 13, "PB0005", new DateTime(2019, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 9, 4, "PB0001", new DateTime(2019, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440001", false },
                    { 10, 5, "PB0001", new DateTime(2019, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laborai", 5, "a18be9c0-aa65-4af8-bd17-00bd93440002", false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Timetables",
                keyColumn: "TimetableId",
                keyValue: 10);

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
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3f27d24b-6661-47ff-9de6-26522d8e12e9", "IFF-1/8", "AQAAAAEAACcQAAAAEMPFgz21c7bNG5YvZf/ZTJ3bBwY6IFEvIeH47Ae95B3QXO/e4+EUmOJdjW8u74r82w==", "32c5f8b8-c97b-46f4-8961-7ea3896e5552", 146791232L });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "dae5da4c-f381-42e9-af54-0fdde87bf90a", "AQAAAAEAACcQAAAAEGePOs1P/WRDPneEe3JyLrc2VDeBEhrFTndFeqjwC3Lo4527uONDaa5aH4KQaDcQZw==", "ad15a6fe-7ec7-40c1-b95f-098dbb4358cb", 160734126L });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1571b920-5d72-4f9b-b4b6-82a0f163f0ee", "AQAAAAEAACcQAAAAEPppKlchvgiSPkEJJQUVmDzr531r5UQ+x+5wl5EqObNu0yyk7wPpGEiS2VJXyoBz1w==", "05206d57-8537-4fae-a3ed-d002c9de9e0e", 149153162L });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fcf83100-1fd3-41b3-af7c-e5b60a755d55", "AQAAAAEAACcQAAAAEFBonxB3dFExH51tRnAH8Dt3bLA5tQqU4aZP08Af+6p0QbiuPkA6bbrrZK4qEYFJVQ==", "19e65847-a307-4e86-a85e-99320e399e4f", 134764136L });

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
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3086ba83-066a-413d-98e6-a4797f4383fe", "IFF-2/8", "AQAAAAEAACcQAAAAECyJfOAWVt8pbQ8qzK41oJnQFtQthnHN+c1MBDmCRkC4Ohy6rNnnBJyqDXlmzaStEg==", "9b026045-5e0f-4e72-937c-0faa1bf092e2", 126257040L });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2cdb66c9-77bf-4cdc-96dd-6da58fe4f6af", "AQAAAAEAACcQAAAAECJXePO35lkS32Bp/NxoxFqO64iHFfG0UPy+i15VA4QriEkLJ9tMk/EddDHIThraOQ==", "913bbc16-ae05-48aa-9d20-ade4fe749691", 138322247L });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bb582045-e13c-4c28-a945-fe714857ebd2", "AQAAAAEAACcQAAAAEBVw0LN04/oxtrH4Luu677bdHiNGpa8GkYYhZgIE0IFqhrm45cQxaT2yXFe1fyt/0g==", "96966f0e-6fc8-476b-aa59-543ad80b4872", 102196298L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440100",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fdf596b6-5a9a-4234-ad9a-14a6fda5a10c", "IFF-9/7", "AQAAAAEAACcQAAAAEGaL0PYGoMhMMFMto44lwO3a0iu/dr8Lmm2xSfUMc6aePJtmD5EEG5clPf51cHokrg==", "cb05a2ef-e33e-4ca5-a80e-4e17093a06ce", 117542043L });
        }
    }
}
