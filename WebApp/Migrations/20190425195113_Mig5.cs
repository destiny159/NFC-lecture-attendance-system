using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "2bae65bc-ffd3-4101-b665-592f3b25f7d3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "dc2214f2-0098-45a9-8ff1-3f6ac4bae570");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "28e455a8-0eaf-45b4-af15-280d48995e24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440001",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4c5452b5-49ab-4f88-af07-8086c3c64703", "IFF-8/1", "AQAAAAEAACcQAAAAELEH7KqmVx5XesA3ug6rNlyNtSFQ30a2n5ZSXfsm2kGJ3NxZ9LJeE1LdXdLihjHgYQ==", "4e8d0147-14ef-4380-85b5-488b72f0422b", 115393246L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440002",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "cf10d8a2-789f-4790-86af-bcaf0c065d2d", "IFF-6/5", "AQAAAAEAACcQAAAAEJ0fp2egL7lwqcj7nZxfxDTLGpaog9U9iO7jYOLeyukw5JI1VSUTJebGl21TD95jig==", "54266239-5ac3-405a-aca9-a1d4fe7de3a4", 149570461L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440003",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5ae4a42c-c681-44ec-9e60-23f020e8b5e3", "IFF-3/8", "AQAAAAEAACcQAAAAEPP5CIR8inkb/+2+RU8nBnJ8RU1l8CPrlXNT8ENygdZlyZIpczY6kXP3MuKem8L1WQ==", "2504e1d7-4512-41a9-be85-963f2bd47cae", 143068219L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440004",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2ca004cd-7e3a-404a-9050-59539232616e", "IFF-6/6", "AQAAAAEAACcQAAAAEMoXThwY3jlDODmnSz6AMUSpxvf1OYo8RtjoNucHDJ3d5PaP2JJ/+JywiXqfncHvbg==", "aa8f3082-964a-463e-8e6a-00b34b11ae55", 165482078L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440005",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b7bc65a7-387c-4508-b268-0f2fa60c24e0", "IFF-2/7", "AQAAAAEAACcQAAAAEFZ4AdSWnkqWogYkAi/PwKVY7cisNvV7Wy29xkLpVCfBtrPuNyN/OUeaQf1OIN9VUw==", "ccdf11cd-500c-4fcd-b5be-848a8206b0bc", 171182094L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440006",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4077730a-f4e6-403d-8e25-c7fff1b20257", "IFF-6/4", "AQAAAAEAACcQAAAAEPD4wpY9MD53AEud9ndqYVEHT0VspO27ZBirPG0MiU1j3z16ss9kt2lJfmiS8Uxm9w==", "56ba8318-f537-46cb-89aa-4fc185a5c7a6", 121953454L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440007",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fc4052e1-3ace-40f4-b4bb-7393a26e5640", "IFF-9/8", "AQAAAAEAACcQAAAAEEtyDuhmkV/Iy8Ut1m+cLRAmaedoIcfqJnb1rPL9Lo9DPFoz+f5QUUxysipsXJ9piw==", "3a6aaa5a-97e0-4df2-b151-2d047cde31c8", 184054839L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440008",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "96b13ec1-15fb-46b9-8f5b-b126f10af799", "IFF-5/4", "AQAAAAEAACcQAAAAEPrfniddZ3KZrhoxJtK9msdu+GPd9DqRtDm7wgTb4pyRNQXfnNuZQizWSDFNK97Vbw==", "f6f35ac6-dd07-43ea-8b99-e72f35ce2088", 158548901L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440009",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b7b192ac-a8fc-4156-b352-1c4a88d382bb", "IFF-9/8", "AQAAAAEAACcQAAAAEEVjFZrI/ErLp/RLMul3CmdawMW26kgq6mBvCeNq7510kOAYNVUYNxRCHdOalyDKqQ==", "4a45fe1d-5c82-42c5-af2d-143c68dc0ef9", 191793949L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440010",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fc09ddc2-9345-4207-a294-9f3ab58d02b4", "IFF-9/2", "AQAAAAEAACcQAAAAEFyF67feCLEhTxrWMXKdJZfJpzqb8Unk5FXK2F5eHJyNztuhBm7b4Iri0yGc0AbLbA==", "70a794a6-be22-467a-a0d1-dfe3e2416f45", 107827946L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440011",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4c2f0b26-e672-4a03-8144-775b8644be03", "IFF-1/3", "AQAAAAEAACcQAAAAEG1UHKnRkaHRoMV6eWNg5GZK0uF34ywp1tjgGqAwT/NfRAypJyUJ6jrLIN24kXK4WQ==", "b578c4b3-ac84-48df-8c8c-44cd240d6498", 161502498L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440012",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ece72b03-72cb-44fd-bdf8-026d39f463d7", "IFF-8/9", "AQAAAAEAACcQAAAAEBWwECCsnkF1DQ1f/FUkNJGU+i4elSvUpGA0R86sDz9JMQYcaKUi2dDtKN0ozbZk0A==", "f2561c34-28f6-439c-a306-dfa362547062", 154101215L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440013",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "788bfba9-b588-415d-90a6-7e4617ecee0a", "IFF-4/9", "AQAAAAEAACcQAAAAECe+nxyfrpwC9DpM4wERtOGNzCwubomnsQ8Pln8+GR0T2X2aEEYiNqpkXze7namqsw==", "5ef1981d-210d-454a-a1dc-06c408697eeb", 170717491L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440014",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d997452e-1fa8-4afc-bcc0-314e3fa14f57", "IFF-2/6", "AQAAAAEAACcQAAAAEIiGKKZBG6pJqAOdmIyITQ7mkcMPR0qMnvhgBx42hTkXlA76q97AJ6pYJqdCU3uZ2A==", "b2db12ec-95f5-43ae-bd3e-17c5da9b3ff6", 113306641L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440015",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "05742950-278e-4432-9fd5-4322bd15d943", "IFF-4/8", "AQAAAAEAACcQAAAAEN4WEYu87okPLxLSSEx6ysO31e4S6w+GOh/96nQnhlFKxMX/Lj3RUAPuHfiXZgWBeQ==", "bba69808-b66c-4053-ad4b-73dc56b16b9d", 145256863L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440016",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "de12dceb-de1c-4652-b0c1-098445903f91", "IFF-3/5", "AQAAAAEAACcQAAAAEIhOJmxsHbb/tq94oeBDbFO9Hj/74AyBeBBUj/8zHfQaUI7fh08OFsTQ5OWpfwSbEQ==", "2ca471fe-4048-4433-a514-5b0b5129f8ff", 147503726L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440017",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "282eb931-57d8-4cbb-84c7-f5556b770e65", "IFF-7/6", "AQAAAAEAACcQAAAAEGr+655uu+kkIivQ1YXh8rtngdiH3wx+xrwW3toWS6z3CAhyIoFhHi0nBRO/sUzq3g==", "a4496958-8843-42de-81d8-eec2be8e771e", 100997804L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440018",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "91ff1937-0cd7-49a1-826b-aa2a0d293069", "IFF-8/2", "AQAAAAEAACcQAAAAEDa+dTlnBnZomsCIHcj/7xOi63bXXS9byi5rHUEwFw8VTYIM61a+x1+mBuCjgzv5Og==", "bbcb8019-16e3-41bc-aa3a-e7290fcef0a5", 137228901L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440019",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "90e9f2fc-b83d-468a-b5f2-f10656e01e39", "IFF-6/3", "AQAAAAEAACcQAAAAEFHI30R369f9beLDMwCEa0D7q2kn2NJLg2w5fs72HU0hyp7NPEK2sXu5E/YXcl35Ww==", "4c29cb90-57f7-4f58-b708-a142e907fd35", 108999372L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440020",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "61c3299d-dd19-4c59-8d7e-6052d1a309c1", "IFF-6/7", "AQAAAAEAACcQAAAAEC71wFUoyhv5uTPI/dxrscy3rCiQqv7b4CMzpODJKKrpCMioZALeYwqDZ/z4aThzqQ==", "5e77b6d3-c034-40d6-91d5-d48f8abe7659", 171815845L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440021",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "86969b7e-c134-41a5-8846-09762e0fac60", "IFF-4/3", "AQAAAAEAACcQAAAAEAV9wEqTyJ97T42AvKmLEN2kDp8pFHhzyoWZq6bSnptObx3FpCgSKGhculRcCuBF3Q==", "0f243890-196e-48fe-8a22-21e0f7642417", 162636266L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440022",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b95e95bd-6aff-43a2-8be6-7d2b28f5fd11", "IFF-1/5", "AQAAAAEAACcQAAAAEMKbdTv/1ryAge/EHeLEkvBUpKniMJ5NwNy2T1mB2KB40Q6CZ4vqtZnwQrPjOxSuOQ==", "372074e2-0a8d-4ffc-9f8e-661a5c14bf9b", 160339745L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440023",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "88998be9-7c62-4d76-a3b3-0cfb176a00eb", "IFF-2/3", "AQAAAAEAACcQAAAAEFaI34+8N7a/Pq7KoxqAh3mvYMqSRbIy0W2D04hCZVPK4PlGbtGj7h2jPdyxq7Wlzw==", "97719d5c-3cc9-4244-bde5-cea8034f70f6", 133443838L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440024",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "50721f06-9e0e-476e-9450-9e7c37f08cb9", "IFF-5/2", "AQAAAAEAACcQAAAAEG7CJltxpFagqCc4NizB2DozBOfB+omXvZU+FBhkC/wPaEq+bqrZgCQF0YLtbTlh5g==", "f7f0e637-d253-4028-a105-63086587d4d3", 168343887L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440025",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3ce6713e-52f2-47ec-8ddb-1e02bf462659", "IFF-7/8", "AQAAAAEAACcQAAAAEEM04oKl5N2qeNd+J66chtG1s876sJnCQbEIUzzqJn1CqKHn6andu9jco07vYLRRHQ==", "acb103c7-9508-4cd1-863c-4c17cd916a02", 143464633L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440026",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "55f0c22c-9df3-49a9-a310-e1a3da0f97bf", "IFF-2/1", "AQAAAAEAACcQAAAAEINbMuuZcxSOR7rdEVghQ9uBjbrX45DPGQj/O3TthL4McOdTKeUuWHN41AuV68rTTA==", "e5a52849-2d69-46b5-9806-3886452ce422", 123944821L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440027",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f599a199-791a-4393-9395-6150d640c6c5", "IFF-4/6", "AQAAAAEAACcQAAAAEMLs1Le2GiEsL+2LQmLf6lJ8F16fTpWYClhFocl5uBEAjxSZWLs+Z2Ry3XHJ34Cxeg==", "b3ff4ac9-5e01-4c95-9c90-7b5478537978", 158844907L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440028",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e59ad3fc-4605-470f-b2de-205e65563925", "IFF-1/3", "AQAAAAEAACcQAAAAEJPFNK1EVmjfMAFmBa614XhNPSbwBO5KNMdGcwAnRF90s40MZiiR9j3jTjCB+LHsyw==", "5efb9b69-9acf-4a5a-af26-71e1bab5fc03", 138773516L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440029",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "deef78f4-5a63-4bb9-a446-7ea23814bd53", "IFF-3/3", "AQAAAAEAACcQAAAAECkVuMGTR2uA9WKAFOHsLdnMSISPnq4n2sM5tXvbsU0O3d08ga8l9x4zAX7zr+qmxA==", "4063021f-cd82-4023-bb31-f9ef10398105", 156284306L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440030",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "11d06e66-a475-4ab4-bd5e-31e6b42735fb", "IFF-5/3", "AQAAAAEAACcQAAAAEIsXoN3Ood45OLhgdSFZI6jUVOPnbQgHyZ3gTCh7HvOWWgY2y5vD43KVlzR5sgeJUA==", "db641115-45cc-47f4-9549-9ec39d468571", 114399437L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440031",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b99c1c5e-b607-4a87-8389-a6922ec07234", "IFF-9/8", "AQAAAAEAACcQAAAAEKkKYP8BkTqq9vwHvR66oZ0OEDdwktGkvPtPKTQ//RyNvwQu4eBwmdkefRWKeUTDSQ==", "05234c09-3ca8-4317-b2f7-bb2cf34ca900", 172731553L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440032",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "46e74a24-1256-410e-9290-37164dd14d78", "IFF-5/8", "AQAAAAEAACcQAAAAEEvH/ziEmWOa5cI9HWq7kCwgdLV8SSpow07q5qwHevxOTWUTiwIA8+AwrJgge5VuKA==", "448ef56a-9bd6-4288-9909-9a45fffd92b0", 125286906L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440033",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "54a30aa0-e22e-4da3-904e-2b61e43c7138", "IFF-8/4", "AQAAAAEAACcQAAAAEKgXgZQ/ACZM6qfQGZ0A9QdsnEPhkHp8qG9E4XeJM1rFFa2qd/COso9ers9jZY6dDQ==", "c47f3142-9f88-4d44-a105-10ea99e695eb", 126724576L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440034",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "943cd397-dfd5-4111-a6a0-55e5404c11d5", "IFF-2/2", "AQAAAAEAACcQAAAAENqqqjwCRenfilsSzzPNG9GtyhNs4QUMUf0XNI7i8CTIqdy2ofqmeDRHCZlRizwrzw==", "e4825ea1-1170-4bd1-a74d-c21f8cb72f38", 126286569L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440035",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "17097f38-83a4-4cda-a49a-f23c178b7d74", "IFF-3/2", "AQAAAAEAACcQAAAAEPXaa344jZ+Zocd2keJm+9cVnM3ar8FAJKJN+pIK9tsarpfhJcj2RL1psbHXx0OoJw==", "1722205b-ba20-4c36-9708-6b748e022388", 113669613L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440036",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7d81e98a-2b8f-47f0-9c39-edb2badec9db", "IFF-9/2", "AQAAAAEAACcQAAAAEA+ejScDVlEe2JCpPoIR3B2r5wx8x0OTBcmQUVrsXIRiiXqRD4zUTBrHG1OZsz8Bcg==", "df189bdd-c2a1-47f3-90b0-ceaab00fa5b9", 146113837L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440037",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c55c294a-ce28-4758-b6e6-abaff50f9d35", "IFF-8/4", "AQAAAAEAACcQAAAAEGzvfVUbZLqwr3INl1326rTmAjPyHHWzyQZ1SGvBeT5twav5ZNk7QfmghF5d4pFWPg==", "50f47d22-c80b-43f0-a3f4-20584115b5d9", 132349944L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440038",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "55fea753-12f4-4d43-8d33-628aa2ceb3c3", "IFF-2/2", "AQAAAAEAACcQAAAAEKWXsSkMaVowBTisMQJKpRWbDl2J89I5aUetEeUDxmt8OmF4LadXaz0qdzB7Ymojyw==", "0e306170-2e22-49a0-aad1-dbd6b376f7aa", 117404441L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440039",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "94679447-defa-42fa-8886-eb3b8901b5ca", "IFF-3/3", "AQAAAAEAACcQAAAAENIheeBlw5zCGy0/GyMt1YS3822HmGHR9dALfkkXT09d21dkd5iCSzBo5WFkTCVa4A==", "91e89b17-44e0-4579-b4ee-0e93e3da8ebf", 109778469L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440040",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a5b4cce7-ba4b-4b28-9c3b-baa5aa88cf2c", "IFF-1/8", "AQAAAAEAACcQAAAAEAnZunUd9fTNmo5RSqi0418KHZIHGPiKakfXyDx+yl/0qv7R66tnXAzfEn8O+gv0yg==", "24539f74-5b61-443d-aa97-d4b140c6a0b5", 104699016L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440041",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4329c603-1e30-4515-b759-fd40ac5d56af", "IFF-2/7", "AQAAAAEAACcQAAAAEIgDP6Em1lWTxrLGOuA65y8HNbIt9rHjNEAnDCo53/XRg1LBzUi5X7U9ytK6o8TXRw==", "2cde314d-0e1e-4658-a5d4-c9861d96cce6", 130184988L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440042",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b25b5c16-bf9b-4004-8610-6bf9914f505f", "IFF-9/5", "AQAAAAEAACcQAAAAEPa+BYe8lAFvJLN3E60/r+Je7uAcFlQd8Omrxd5/Pb7qV/6pb2bIBAC5M5r0jH+OTg==", "d1d840db-b70c-4793-8eca-889d7e56eb08", 106319946L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440043",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "949496d3-be28-4543-983e-d36aa574f949", "IFF-2/2", "AQAAAAEAACcQAAAAEIVKwSfjGgR5WykVBqmzESPKLmj8MTtRk+PA2mRIPXEJyBf4/ntMob9fB05TW4600w==", "7898937a-a48a-4a72-9991-19aec71eb250", 134024810L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440044",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "32614807-3e49-4bdd-87cf-a419d20fbacd", "IFF-9/3", "AQAAAAEAACcQAAAAEGLqm8olb9hJ0cPgtORYrN0gQ5MqaEkHA8P+Plcn7EssUrgdnauea/a17CfySEmkGg==", "9eb965b2-2e0c-4688-8904-115264de046c", 101321675L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440045",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ecba4357-a522-4541-b0f1-3b324e3ee924", "IFF-3/3", "AQAAAAEAACcQAAAAEPJSVCA34sPnOzZUnAxmMCsQyGK4fbvnC4A3qSgV/rdYZNt/BpnPXxG04EMCRbbnbw==", "3394ce39-9b6c-4bbe-be24-476a5ffbffda", 172107461L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440046",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e5a39795-0d11-487f-ba58-d6b4618576c2", "IFF-3/7", "AQAAAAEAACcQAAAAEEeviPRoMhHk23yIGWKu9aXxM38mkFl4MU0mtlAuRwTCgSElyr/fKY9Z3++nSAOY2Q==", "cd8ea188-726f-4474-bb35-a9ed089bc309", 150691057L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440047",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6f2275cb-220e-4e95-a1e1-e523b4664c64", "IFF-1/3", "AQAAAAEAACcQAAAAEA06HEZhac+BNQ9HRmK5sZaWBylc/NsUrD1tXLzujEc0AUTuaxDLtKoZ+1DQlFxavQ==", "78f9fce2-dab0-4dcd-9457-1064836e860e", 107758033L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440048",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f35aebdb-57a2-4c62-959a-b65a008f3b97", "IFF-8/6", "AQAAAAEAACcQAAAAEGKPV8zvLPhWAWNye2hHwqu89XfmXVdiufgex3N1jnQkYzxBeq4gWLgY/eCpba83vA==", "13df57ac-e83f-4b89-b701-b691b00ac897", 111612631L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440049",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7af5f035-6212-477a-a771-cc8790c5bfce", "IFF-5/8", "AQAAAAEAACcQAAAAEN9UVGKw7PLuOEeehSAdtSLK1xG+cRo0slI190PFRZcXoZ7lwfI+98xkG7aT9Qfx9Q==", "1bcd09d2-ee57-4f31-be1c-6b334c442c93", 182635009L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440050",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8000f239-4752-402e-998a-e5367107f1cd", "IFF-2/3", "AQAAAAEAACcQAAAAENwqklh/t9bfXqvn/n+X1F3uXa90H5vIRZViyxJxBLgzwCCtt9Xus9AQS3ktkDJFLg==", "f9c47376-88ec-46f0-b032-56dad584aab0", 169665162L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440051",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "604c0d4b-9461-4d09-a937-a3a67f86f03a", "IFF-2/8", "AQAAAAEAACcQAAAAEHv3+hz3IEfD8QGhnIw64xfFMYKn0dXxf30HqXHJJL0bHGoW8nC2tPoWj9Gykg8rHg==", "df787860-96cb-4ca4-88cf-30c23a013ce4", 152382370L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440052",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2969ff75-9df0-4884-9e4b-fb8e5fbd15f8", "IFF-9/9", "AQAAAAEAACcQAAAAEEiCVotZZ7kpaqp+tVfGFX3BPj6UmWjetRR0LCHbYzt3d5Erv3usdaV4HBqoijjGIQ==", "e81b95b3-27e8-4de2-a000-224f380349d6", 157749271L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440053",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "895f56a1-7dd7-413a-b115-4828ecd96227", "IFF-1/4", "AQAAAAEAACcQAAAAEGbz8w+uyPYZIKeFc0V7GuoJb0Vj4rkfm+FMXoyz8Q4ZEx4lP/hlYb6nRmTabVyYdw==", "82074aea-f176-460b-833a-588b83f38952", 140165927L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440054",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "653b1c6b-c10b-4b3e-b908-c8257ae51855", "IFF-2/7", "AQAAAAEAACcQAAAAEObZHRxTNF5SezDlo+1bsHQwfDl2zqg4FAaNLPewREOYojlF9TyKuovavvzmC8u1IQ==", "f04fd584-bac0-4a59-b947-9d9122b03150", 164689404L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440055",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1ba0fb7a-f04a-4b74-828a-3e13924b4b7b", "IFF-3/8", "AQAAAAEAACcQAAAAEJRYD+GrcmbYxVT3kCCZPbQY+mRs/tqvBUompUP5eeE+5f9iHCOJwpwOL9ku9sVITw==", "2fa8abe0-e767-4cc5-bd32-a7663808253e", 191132562L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440056",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7b98f9f9-3f92-4e9e-a57a-b3828735e5b1", "IFF-5/8", "AQAAAAEAACcQAAAAENnbSYzM80uWkvYxQ5qPKwvnsXUMgFfXDvdCKzdEQ2d8SpaVdSeQ04g6ZeUeOBT4Lg==", "fdc867f9-b2b9-4fb7-8d6a-7ce51f614eab", 115177386L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440057",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bfa28bad-c38f-47b2-8d37-62da58ee54bb", "IFF-6/9", "AQAAAAEAACcQAAAAEARLnH5EjUJIQ98wpEo5HA/JTLlwp100O1aCzcUSUQo/ZZ48p2eZ6lv8GiussUCluw==", "b97beb89-f7ad-4c90-9c95-41845149ed84", 183255949L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440058",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e52741dd-38df-47ab-aa2f-0e25e8925c6f", "IFF-9/9", "AQAAAAEAACcQAAAAELLJYGRVkrOSUz1XlnEnBPmqdbXQRJSTmMXNGP94uPgul5E/SHYxTFjDFqxAGAsD2g==", "dc3d55a6-f523-4c0e-abdd-d41642af3a36", 154233903L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440059",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "489232e0-4f8d-4249-8192-f5f44eb39844", "IFF-2/4", "AQAAAAEAACcQAAAAEH9P1vGAyNjikzRYzfh8J6Fgbk1XMEfVQ3EYMnwgjQgnr2WIV1+0ToDPbtzHvLMaLA==", "57b2d08f-b3c7-4c8d-8fc3-7b098108e94e", 149196653L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440060",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b32064e0-4e40-4901-8003-0acf1de6b5f8", "AQAAAAEAACcQAAAAEDO2x+ENwndNcOemg9bJFB1EfK1GyUfvYYWedmQFSR1n34V6qkLYqub0Xd3VNBkMwg==", "1223597d-57a8-4ee5-bdb4-040fe9f03978", 111931741L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440061",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0bb60419-be80-420b-98f4-c6f86cba38f8", "IFF-6/1", "AQAAAAEAACcQAAAAEDPpZ7zSufFgoGpEkvBoBIlBUB/hxbBqlnP6TYt+FUjkpzQIwOdY67HaAzLIz2COGg==", "44c230a6-2c6c-43e2-b431-d9c038f0792b", 166403607L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440062",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "34f9d0c6-3a3b-4e3c-a03f-41894036fceb", "IFF-5/7", "AQAAAAEAACcQAAAAEGHK46UdBqbCVUtsUWfb5LhiB+LdwlzSkFX4bnQrIo1Xx/+czGDFrNDEkTc3Y7HXpQ==", "e9fe2369-95ec-45cc-a31e-14645e717fde", 193270199L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440063",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b540b48b-4616-4158-9628-a4e1bc1374d6", "IFF-2/4", "AQAAAAEAACcQAAAAEJNZw+xHA8CpOAJNfjef0mBjTlsNzd4Mwex/6rphukc2LVF9jyNMOig06rFcjljwhw==", "5b394a9e-f57a-4cd4-a672-0a8600ed1c5a", 147513241L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440064",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "34370579-451d-47bc-9f42-9408566f9763", "IFF-1/2", "AQAAAAEAACcQAAAAEF6DJngAfpsiD5mC5m/7A+rs8r8qLwOLD7SLd19dSQpTjiPImcZ+CchRmAUCmHzHxw==", "3e1f2c05-ba15-49dd-9c27-092e2cf940da", 135214850L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440065",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e3334187-3a0f-4ffe-8fc1-7f3cc57f99ce", "IFF-4/9", "AQAAAAEAACcQAAAAEBTSeMDFrNmkOVPtPlueSFhoDLiee/Dw5vu7XY+NseiubGjXOQOjl1UduYq+DVYe9w==", "8d0b2146-7102-4e79-bdd4-c76406295f5d", 137134644L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440066",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "567825f5-1c16-4ac6-a846-abc25a5313e0", "IFF-2/5", "AQAAAAEAACcQAAAAEKwcD/LmCORa1zCaMp5JB5+id0Vzb3l3PgFFP/m5iaCiOUYc/eNNpabEg6ugzN3mFA==", "b0d49e6f-c092-4f66-b548-2c515ead1629", 154922788L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440067",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "21915a86-1617-4298-a119-4512ea59f36b", "IFF-7/1", "AQAAAAEAACcQAAAAEPXhZaOWgT5+WEhj3XyHhMxsdtlFZRleXzdJd59vTpgls4LwwV7rCJqYiDBF98F6Sg==", "5a1f1330-d1b0-4b4a-9f64-54633df32a70", 172212986L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440068",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "40263492-5a12-42e7-951d-864737cd4378", "IFF-8/6", "AQAAAAEAACcQAAAAECS6RzpPIM6tOPOLzUUsSVNXGXOw0c1yTcs2dtrM0nPwAi7sTbx2qu1Ed62olpuRCA==", "5bd1533d-5116-4d66-b75f-98300956b8de", 105518109L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440069",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "12c4c62e-4989-4631-b350-270b0d5a9d69", "IFF-9/3", "AQAAAAEAACcQAAAAEEHN35kV0tPj2rM+MiGXa/vA/CzNhs/Hh/Ci/ayR4lmSnJkn5AFnkpbYVh2YCKkySQ==", "22885473-d374-404d-9864-f693c6cf9df3", 128048778L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440070",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ce9a9118-52e7-41d9-8689-6a1470f8301f", "IFF-1/7", "AQAAAAEAACcQAAAAEOtn2Y31EKmNkq9V8aXHyPTFWqF+fqmA5J48NbwXhFY6zRG7G1ar3OOZe2IstsOjbw==", "a3de8ec8-f788-4aab-8016-4bd0ddfeed50", 186976708L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440071",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "65c3e14c-4c48-4012-b267-09daffba81f8", "IFF-3/8", "AQAAAAEAACcQAAAAED+q3Mc2iI4NmPtzNQtXPfmREMQ8vxygYADy922J/Y8jcZWm/OTm5+kiEiBRjy0Wew==", "001d0d55-24ba-49a7-90f4-b126b037bef8", 158020576L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440072",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0d5e4be9-4319-4f5a-a5eb-efce14cf760e", "IFF-9/5", "AQAAAAEAACcQAAAAEG190fcc/vVqtOOJLWTCw55B6Xx+S7fTr3V9mzuoT0hHAzPSvTeiLbs2b7I8b9M8iw==", "e6b09b18-8b1e-4a7d-8728-89a52b875cbd", 196756361L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440073",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b36dbbff-ba80-4aa8-b118-48e77d0d7892", "IFF-9/8", "AQAAAAEAACcQAAAAECyfphYBSByUs31RzYdKVlSUeFveoAolBNZnG2LeS4gcdtCTJmElQhIiETOTvrB9Yw==", "8a5aa53a-3c49-442e-bb66-017d75153b62", 172917249L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440074",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1aa87c5b-9155-40c6-912f-163f77c5dbad", "IFF-7/3", "AQAAAAEAACcQAAAAELan5mplldTaN1duMrt0tGHRjq6vzrEnAqof/UNdwwGryKAQPkW1Hlv0mmyh5mvVkQ==", "76fd5069-3525-4a60-8219-308e73f306fa", 112639622L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440075",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ddf75ab2-37e6-4655-a1b0-16f8daa0c2e5", "IFF-5/5", "AQAAAAEAACcQAAAAEKTjROoCrVEKw2anRJivkqa0aE/4G0ZBA89EK2haXnHpmB+bZIBL5JE9dDm5QqlTJQ==", "6078e979-4764-490a-87e2-cdc4e38e5bed", 143955841L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440076",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2fb48bee-2dd0-4d9c-84d1-3eb09c7d9c08", "IFF-2/5", "AQAAAAEAACcQAAAAEGbosL7JdE6DbreOuL9wZ8Nkbb8KEoB6Gh4JG3Zz8TMd+V2Y8l/mhQ7bMbQzAF1XRA==", "a65a8b60-d513-48d9-8022-c5b24324861f", 181004608L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440077",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "27c921df-f758-45da-8d04-965292897f4b", "IFF-9/9", "AQAAAAEAACcQAAAAEO8PI7wawbwVse6oUFEitz4ME1V8p5GNYNid8CZedTF8i6Y5q65oARKN+wFv9U3Mpw==", "d9e9f0a2-3404-4e2f-a5a9-4db9cb117d4c", 195803526L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440078",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c83b1bd6-3df8-4c6f-8687-af67700eed5c", "IFF-4/6", "AQAAAAEAACcQAAAAEJakwvVm5eiYsp36t15bkzlhSu823DVW+gdAplYuaO6NkfsDQSZpLnz4hmyHjzYo4A==", "52c5d388-0e79-4bbe-b480-9bc8f51372d1", 185973686L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440079",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "315f3c06-4041-4245-ae3b-3db7ba103b60", "IFF-6/8", "AQAAAAEAACcQAAAAEEJHG/jmPlHoYL9UyZpMTMjXfoIopasllD+sCAbElO74W8WDhHdjk196DFRWlIzbAA==", "ed620fa1-a945-4766-845f-10bea922a385", 130255085L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440080",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "71536223-afbf-4634-afbb-5521e2384523", "IFF-6/5", "AQAAAAEAACcQAAAAEIeoO1FCyhWxa0RvoWPSI3fbpC2ovrbxa52ltzZx9jM6gwaf2C0gJa+c4vWE249p1g==", "e61312f0-8e59-472e-b30a-2528e8e3f54d", 146248264L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440081",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b35a30fa-3bdf-4cd7-86a0-cee9c513e831", "IFF-6/1", "AQAAAAEAACcQAAAAEB4UeQzNJmtByR7bPYcFnNYPeQx9gKLfBH4sktP2EkTnD1vFt7xbHEBJa1vorFsdUg==", "59154956-1e42-4b8a-a95e-9e1be7b660fb", 150110106L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440082",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f57a7c4f-ca04-471a-a612-24ab0ac07490", "IFF-7/8", "AQAAAAEAACcQAAAAENQvz27bmpMwZXSz0lnfsa23HcuncLVBYomNYMnzF3XMoXPaPQSxlGuZVkrwALzsMw==", "678a6c5d-690a-42ef-80c2-1f300c2cc237", 158927535L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440083",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "dc1362d3-2914-431e-a6f5-78e589cf3a76", "IFF-4/5", "AQAAAAEAACcQAAAAEPF1YLbyrgl25OYmd2/yhwUNBcVVlEjVtbkTEwxx9GCiadZRnw9iA96mpliyIhGD1A==", "1a1c4b62-db62-4724-8da1-2e3bfc16c536", 134089505L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440084",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f33c35d9-e771-4e79-a653-d248d184f34e", "IFF-8/3", "AQAAAAEAACcQAAAAEKlhUnvhChuoJtE+P6eY/m7soG1RuovB8s0NlVCCPcH/K0RiGpWH2fveHqKjOq6D9g==", "2eb67115-55a2-4f59-a738-ab62d228f6ff", 150352063L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440085",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "82111acb-cbe3-40e8-b474-205df48a1cd4", "IFF-6/9", "AQAAAAEAACcQAAAAENs/SUCm2aNqlcvSC8gEhnOwo+52bk4XM4qApS9Dgbg3T+w9biZJEuT2ENO49jY8bg==", "1999e07f-68f1-45a5-9b7a-0775941f0643", 168932256L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440086",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1b821a21-1c06-4ade-9a25-04f940adea65", "IFF-6/4", "AQAAAAEAACcQAAAAEBrQlIYEwUR0K9ib7DGtfC9tD8G55A9CN7fDyRCUYcFTZrqrnskLVAd2QWUnSvAEvA==", "e7526b33-0516-456c-a09c-377ad8ae3b21", 179091345L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440087",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d6db4a6f-db2f-45e7-8c15-015e488c317a", "IFF-5/8", "AQAAAAEAACcQAAAAECfD7lTmks9OXDUF3OpQvAi9Ls0txyGneUm1zfF7+TJ8g/vIQeEseLgv8eLGZQRGGQ==", "1b6e4e8d-31ca-4cf4-9edc-90065d7bebea", 107858745L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440088",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c2161306-54c2-4ae8-8011-659548b3d59d", "IFF-9/2", "AQAAAAEAACcQAAAAEHcKrDld1tKmJXUR3/hljjCkYal+JghQK2vbDFOnJoMIlf/ztezswGqTq7/OwO+FLA==", "f4c852d4-6ff8-472a-9bf9-1dcd547ce40a", 171212220L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440089",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "540e3a0a-dd03-4ad2-b2f8-e89295810f99", "IFF-7/8", "AQAAAAEAACcQAAAAEMk1tEUvTF5PP0V3OwY+vNMdEoEpILuTqt0lX3sGcULbYCe3dCadpA4pSsKsrx2Eaw==", "cdeafb46-1223-46d7-b530-aa9ab072dadc", 179436932L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440090",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f19975eb-f668-4935-ba45-94ffc398c2f2", "IFF-6/4", "AQAAAAEAACcQAAAAEOCHfclTD0pJe67lPP4AN7REvJVfeD1QPNxpFNsL5aR7gQiFQliuiXDwmpUgLYdAOg==", "653b91a9-86db-4a1e-9bff-700f9cf499e3", 127437421L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440091",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ab099065-cd02-4afb-bee5-0ba2b02e9ff6", "IFF-3/3", "AQAAAAEAACcQAAAAELLZ/axsCf7sCNFmhmXd/FvN7vc8V1d92V0Usq1cyHppjAePjQ2wKkQlB5mE2U1pLQ==", "a30d7f85-70da-46b4-a4dd-9e9ae06dbeaf", 169778942L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440092",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c1a7862e-0196-4836-b74c-cef5d9241120", "IFF-6/1", "AQAAAAEAACcQAAAAEEFFbezX2axfQ+7a1xKnTWDS9UpwGZno0JtIs3bIign1xGR4oBT8WatE82Tw10u5Vw==", "d8b98836-5ffe-4699-bb4c-df655aec62e5", 131298128L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440093",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6812646f-b851-4135-8d63-27790b545fa8", "IFF-8/7", "AQAAAAEAACcQAAAAEEds5Jf2Hd6OQN874ny/1UmecrALepEl5b3uPgNi6QRLw860v8BEmWQ8AZqIh6L0PQ==", "22160d25-c144-45ee-9579-392e194fe267", 125133215L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440094",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "93942221-d900-4fb5-bb23-5e1256d9ff37", "IFF-5/7", "AQAAAAEAACcQAAAAEIqkIf3IHnaoCAsy3nbgFMH+6ibFf1Zq2M8SGviPownQh7iYOowuj+pgOPOECKqM8A==", "b4a25b0d-1c95-4734-baa3-7e1ce43e2e3d", 166271338L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440095",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f092f3da-83e6-4c08-a2c2-27362a69a577", "IFF-5/2", "AQAAAAEAACcQAAAAEOMeDoZFSv0D4CfXHxVZTOQi8oqvrQw+vYXohUaJg/pl89JK5oklfj4bFTpCxYIgGw==", "5d1b0f9e-032e-4dde-87e3-d05f3e3da53f", 109089525L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440096",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d6c2cd6b-eac9-41eb-bd4f-68312f72f5f2", "IFF-2/8", "AQAAAAEAACcQAAAAEIIYjzyVlaIU7BdEY1SVhPDcAV7XHo0WLkUDvogvd1zwBJTw/hC+2fsLtgFrZsNewg==", "5245eb24-8879-4093-a80e-18596e1bfadb", 175474584L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440097",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c58f4c42-08f4-46e8-862e-544b4667ff2f", "IFF-5/9", "AQAAAAEAACcQAAAAECpkT1wcn/ShxPnXtXuCub8RgC5sJhLkBn2FoY/5sLjTPfQaBbK/r01oKcoQuiK6xA==", "54ff9803-6fce-468f-b482-a64090933239", 156433830L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440098",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "130e286e-b08a-48f0-b190-2b908d1a2d27", "IFF-4/2", "AQAAAAEAACcQAAAAENbD0ytxNVcbL0TrpWyxXxEbupvib1tm3m/Xo60pUckQAO6R/YRRzd8OFrb/vwpv2g==", "5fed0e3d-fc7d-4b2d-a218-85057fe7fd2e", 139582324L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440099",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "84386ae8-e6c2-4583-bf8d-d22449868e21", "IFF-8/7", "AQAAAAEAACcQAAAAECZx1DVOhVcLmV3Vvbo088DyA40FCHi116eE0RnIFiHW/iFWkleSQKyAMb1uDcA7cQ==", "32901190-19b6-4a50-9388-2a8fea9fc742", 169741629L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440100",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4f0c80cf-b96a-4dea-80af-b069e7239acd", "IFF-8/1", "AQAAAAEAACcQAAAAEEawNb5reAFqO9gUXc+xQgp/CqnwHT9halW3Y1wOFQYK3DhzT5JrFtOYK1IkrnRXiw==", "cb3fdf6f-7642-436f-9de4-8ab21a88dd17", 191526819L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "338c238b-c448-46ee-bbd4-71115f2c082f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "6f126ea0-0b48-49b2-887f-bce6b73b18b5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "a3b1e52f-9f59-4cc0-b397-f5a110b477a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440001",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6293c818-09a0-4489-8636-ccc2419b664a", "IFF-5/6", "AQAAAAEAACcQAAAAEN8FWyWHGfVwv4wlGGpnOOOijk1fmNFRQjSv6H0oZpcolPKR3G9i7kZmzieYX0z61w==", "82eedf7e-4e47-4fc2-b7ee-a471c57b1c82", 172354188L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440002",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a6e0a9d4-3d7d-4156-a8ff-cb679f7a6592", "IFF-5/7", "AQAAAAEAACcQAAAAEKdZMNVFs/dRx3JxL7duNYxkwc9i4Au3tir1VQQgZBd65SwZmtkUh7K5g1E1MPKBRg==", "f078ba67-e850-4587-ab97-7d62c48dfce9", 108533800L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440003",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "98094fa5-239f-4159-9dce-5eca0eae5933", "IFF-1/8", "AQAAAAEAACcQAAAAECVCh0JfOq99AVN4y/8QwFy695C4vx4Bfxy3C8G6hBJEAFEELHhIlxhJvXw3+k3fFQ==", "257ca80e-ca25-4fe8-90d6-9cd752add03a", 188441179L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440004",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "153bd3c1-10bf-44e5-819d-c12b6ddd0410", "IFF-5/8", "AQAAAAEAACcQAAAAEKqpTyb7FdejUZaTuTA+Nw/fIzKd2eaWsnSdoIdFT3yRKA2Kn4FgETba2x+t91QWuw==", "fa987e4d-69b2-4fb5-8563-f50dc3499ccf", 191453252L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440005",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2b368466-addf-4546-8566-62063b7a648e", "IFF-2/9", "AQAAAAEAACcQAAAAEGS0tmPMJRvkZYXgEEmiCzF+C0h/9opYwuN7QTS5Nju6HZ9WqmpfWFDjhXQ7RgArcQ==", "1dd8748c-618f-4caf-96c7-38696c85e2bb", 173521338L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440006",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f0417d6e-dc35-4d8f-81d8-97c05db451d3", "IFF-9/4", "AQAAAAEAACcQAAAAEBmQhvqaLslox6oUGTs+fayGgQQyPHttFWRMfvCbG5Hofu9lfBxW5oSZklvn9qWSLA==", "725aaeb0-b8f3-419e-aea1-5ee108ea2c7c", 102294058L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440007",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a7165c5c-0416-4eb6-9a7a-5b5300699c9c", "IFF-2/3", "AQAAAAEAACcQAAAAEAVxrBB6dBuvKmJqyduZR4Psoznyoup98lVk9ebEkiNbIxJnd0HUGd48brXWEIeaTQ==", "f0129bf8-1a0d-4bbf-a4c4-2001ab2259e2", 127205191L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440008",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "565b7364-10e3-41ac-be25-79668ce7d513", "IFF-4/5", "AQAAAAEAACcQAAAAEGsH72xQaNBCJ9Ykfr3coI2Ir1rA+yLWib6UTAjB8aOrH2pWiAnJ2Oi2+kJgtDmL8g==", "58be19bb-c6c1-4e73-86a1-300fdcfe0617", 140935096L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440009",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "aa0c659a-6456-4010-8e7c-37af66789572", "IFF-1/6", "AQAAAAEAACcQAAAAEEUsx20XSNZ3/9Z3ZQ0CzQlTWfL4guoLNLGC7ObAb1Mgcct+xpMDa/6TrJocFVd26Q==", "39eb44ea-0fed-40e2-92d8-195f8782cfc0", 166146766L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440010",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6477c0d8-82ef-45f0-91af-6185774db135", "IFF-2/1", "AQAAAAEAACcQAAAAEP6IH8kJasAPIJb9V7I4f0eErny35kNS5LU2dmetBNNzQp+2a9CwZXXITHRqvLfOOg==", "e45e14d8-7ffe-4330-90d8-46d32418c2f3", 127814299L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440011",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "31e3f782-39fb-43dc-91c7-4f27b9db2c8e", "IFF-2/8", "AQAAAAEAACcQAAAAELf4ef4Up+yKWGyZomoWFWt59tX/Hu3s/E2GHN6IvENeBsoCJPEPRKUY9lHZIJa9XA==", "fbf6c673-2e37-4823-adde-a3a567497604", 115513273L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440012",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "875945c7-1eb2-4d22-9cf7-081a1b7134b7", "IFF-8/3", "AQAAAAEAACcQAAAAEPJYuJLRDk6aMnXzBc0XS3lTFh1XicC9qKT8166UnmFADq7ps43Ly2kUdcGSS6DjZA==", "e63cc12f-c3dd-4433-a677-a7c493356ec2", 133055998L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440013",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "585b6757-6002-4d83-aa7f-c599821e87a2", "IFF-3/4", "AQAAAAEAACcQAAAAEH9JJttrtkC04ggS4pJZPONRLG3bouybUkVgYhsMDoMm1YnjO234a9wUdvcgSXg/kQ==", "1033e3d5-1080-4db3-9a84-37a2865a2d28", 128289546L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440014",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "29bb88b9-c71c-423e-bd70-54ff86101012", "IFF-6/2", "AQAAAAEAACcQAAAAEKgucjOZVZL+F/kcZAms/Y41VZs9P/WpD3jomKU0iiHvLJ4LQUpNp5kxHfbu4RfSVg==", "c077d1f5-ce0d-44f5-9c5a-419827fb9184", 151133193L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440015",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "df5a4138-ff9c-4d45-b85e-527f0ea4d361", "IFF-2/5", "AQAAAAEAACcQAAAAEIzfIVFG4KX/IigTP7uUo5lwm3VlYi97dlZ6A+r++vqWphb4Q/3g+cHoEtLe1DfMww==", "4a34e5ff-dcae-48b5-a256-b1faf4634f16", 117760766L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440016",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "7050c19b-3733-4f9d-b40f-a891bfa1498e", "IFF-2/9", "AQAAAAEAACcQAAAAEBO2Sl/GWgKg1MTiFjNit9+jZIOW7iI9i2EiRTIy4hlyMaT+NDjJHAOySSe8F8D8ng==", "70eca6f4-e9b7-4087-856d-09c52f3e280e", 120714739L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440017",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "826366cf-c859-4e83-aa07-83f36e4f606b", "IFF-2/9", "AQAAAAEAACcQAAAAEGDpYsvIukgW8uYub3TVBz2gBcO6sTH7DxEqR96IU5aXmwxtLoULBTQPT7A7zaC1Yw==", "3511a159-28be-4d97-9b01-6e65a4640bcb", 171961001L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440018",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6bbd5c23-5748-4d0c-a505-d7b871027874", "IFF-4/9", "AQAAAAEAACcQAAAAEL2J5rvAxPwyFp1fCILxBYQ7fWZNpwrwYvHjcCXsEk8ScagrWhXGE/CkEKa7J/wF1g==", "5185c4ac-7b96-4ee2-b333-b8a68953cbfc", 123810382L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440019",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a1c74ac4-63fb-4f6b-bfcc-3dc9d6bec4d3", "IFF-3/2", "AQAAAAEAACcQAAAAEMUZot1JR1XcyptJGTeWGJWlCqO7sXN6DCTI7G6u3ojel/GxrgALcimg7odZh1KWvw==", "f9ddc9cd-4357-4d51-ae3c-20bcf5ff82ed", 130512498L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440020",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e86e9d65-d1c3-4b58-85da-b62016c8258d", "IFF-4/4", "AQAAAAEAACcQAAAAEP2TWnRt6BJ4Pj2674MVc0MGEl7ejSSQHhXgMC3tW1qBMWTHMq6l7K/af2fVx0un0w==", "9037dea4-3088-4e61-8f66-f057bc1ef6f0", 119447802L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440021",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "43545c03-45a6-4a09-ae55-50cdf4e417bc", "IFF-6/8", "AQAAAAEAACcQAAAAEFNDgJ+Z+GT/ZX+nGdYliFDYpRW2NN48853AZUdDiUNEKefefK2OBWBNZbewUOxX3g==", "43dc1a54-322d-40b8-a8f5-cbad72fef3c0", 107229098L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440022",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8c85b1e9-b254-4f85-8446-90fd3b484230", "IFF-7/4", "AQAAAAEAACcQAAAAEPU7kw4VuP7VVZmWZ8ij6IYnx/fYte3i1ZXOqZk1ZCi83mR0yCYfG1iom5/pRzolow==", "67593b42-7d03-45ec-84c3-9627b9700e47", 173521322L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440023",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "642411e2-4c92-4524-90cf-97a125c93e61", "IFF-4/3", "AQAAAAEAACcQAAAAEGJ1bEp4DNGGtDJ2rnTkwhjFgO0qaMJ+4P3YKGfvzJTrKBIhLl+sGIoQeei7VBS4tA==", "9f2165cc-ad5e-4ac5-85f9-9ac425a1ee82", 108874613L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440024",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6ca20e59-4182-46ae-a0d4-55f2062ebf69", "IFF-7/6", "AQAAAAEAACcQAAAAEEC0toPIWq5EvvGev1oiLG2nLK8+pWDbPYoLlNFresxeR1WDV/jWiJCJQHNqDO/iXw==", "9e043e1a-bc01-4b46-aa14-ee330afb0cdb", 173213406L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440025",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8a365b91-3ec1-4dd3-9dba-7f0698a003f6", "IFF-7/6", "AQAAAAEAACcQAAAAEAN8XNBR2gUyDYsQqcVO/Q9E2FiSLlRNNInd6gAsaroPBhLxzFAWm9akof/RZVj08A==", "928736db-4e5e-4ab0-aa49-b0d958d2b37b", 108091617L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440026",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4a190e44-4265-4d64-b130-af1c4b497132", "IFF-3/3", "AQAAAAEAACcQAAAAEJXZTsgYnrICQlXseN48zoFYq16f+dt4Bple1PmOzN6V7YsljjTA+R7IFW1b9TW2zQ==", "ef9fd434-3fca-4bf8-97a6-d691e557f750", 115743569L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440027",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1d029b0d-eb52-4a30-8ba1-0c0d480c54c4", "IFF-5/8", "AQAAAAEAACcQAAAAEFFOZZpkgtvFiZMHMciHyrWAyji+neET/xIPJ1JlewY1+j0TyC8R2KjJ8zoq+xnC3Q==", "212fea72-4df4-4b9c-a913-d3fd78f3de6b", 196346107L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440028",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "b8b538fa-ccb2-4465-ad93-b4e9d29edd2b", "IFF-6/9", "AQAAAAEAACcQAAAAEJjxoXqQRsjOrV0kv3y3kbeh0m9YrXoRi1mVenUwmBX2R3Snnts0Mnu0EzgFp8EIcA==", "23267707-1461-482e-b703-eb6745c89433", 164897243L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440029",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "cdd5dbbc-d897-48d2-8ef7-bd85acb7dd1a", "IFF-9/7", "AQAAAAEAACcQAAAAEEadRiqfTVmx1F8a/cBJY/1Tzj7ZwjzQIo/vnHLexvEMPRYjcp+TCm3CZMcOWFaoIA==", "2bdd120d-f04b-4b22-a724-889936fa2fa7", 107038013L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440030",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4a246517-a6c2-4eed-92ce-fcd2c6c29ad0", "IFF-1/6", "AQAAAAEAACcQAAAAEMOb1/oNIuzGSGem3vq8e2o+mCpsc4PPke6QXpS9bIALle7pvJJR9/RLNNt9jmhmZQ==", "32f75a83-bf70-46d9-b27f-c11d91968a4f", 182776808L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440031",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "26f089dd-ef38-458e-80a6-f3144297cfeb", "IFF-1/8", "AQAAAAEAACcQAAAAELf8rjkxO9RDFlC3UXf/TUFn4sTve0KxpO4RR5di6MSXow8DzPp8n3lLQUOdIUM5KA==", "c184a531-4600-4abb-a4ab-7a899444a76d", 111869723L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440032",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "61c745db-92b5-41a2-984e-a26e868157e3", "IFF-4/9", "AQAAAAEAACcQAAAAEJ9bX7xv+4URA2Lzrrugl97xySE6qT/4G4QNZ1i/VFXwgW13JWX93+zIlpHJJyT2Pw==", "179334f9-ed62-4089-87c9-c952f7c5e7c7", 194646040L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440033",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f6d08d3e-2f51-4840-b18d-e53e37244030", "IFF-4/4", "AQAAAAEAACcQAAAAEC/iO5FI8zw0PekCNNs6r+ZcfABnsnDDkAUlK02dJmGbHil0m1kkPjFeKoKwoePYlA==", "d7308162-da1a-4576-92b9-41b66ff02ff0", 127310128L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440034",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bcb2091c-44ec-4759-9119-55ff7dbb4f1d", "IFF-2/8", "AQAAAAEAACcQAAAAEHVsZVqntfznHdDuYfp7WG037pPZ6fmwTLfbovGJz+YoECubiLt4yaCHmn5UT+W7uA==", "05c231ec-8aff-4d0c-8ac6-fdcd7eb48402", 109208148L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440035",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0ca23d41-8af0-47d5-b0a1-039802314435", "IFF-9/5", "AQAAAAEAACcQAAAAEM/ihzt3mfeslX+w6ECKSZ7mcIwWi60VNCmAmJlyHP+Ry2F2EUrv0tAUgsUV8TTQUA==", "32fa471e-bf9d-42e9-b128-b4b543c050b3", 169314812L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440036",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d1c04f8d-6503-4678-a300-d0d785db6487", "IFF-2/7", "AQAAAAEAACcQAAAAENw6nTONqx35MX1IM/ucpgAarOzIUFD3srQrn+YVzSQge2JkBnRcn8UiX5Vsk679Dg==", "8732aa66-b911-4792-bb06-d6f3291658bc", 134912417L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440037",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ddd67770-63b6-4e6e-a135-2648ccada525", "IFF-2/1", "AQAAAAEAACcQAAAAEBR0+F5wf3J1+nsnf/rqcRb8J7C7GMvz+0vZ4inRHyqfYDQ+vcfJSu1wVXgGz9PyRg==", "fd467dfc-c368-4a48-ac64-c3b724309354", 135426810L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440038",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4a71e116-75e8-4dff-bfb0-df440dd3bdec", "IFF-3/9", "AQAAAAEAACcQAAAAEIb7+75zljZcOhs/kcyYdthnhaZJoUrw7pmbuySJ8Jv4384TMlP9nCi3A7lARK/Xow==", "dfc8eda4-8612-4882-9b6f-3199306faeb1", 184177782L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440039",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9afbc0eb-e5c6-488e-a724-8e09e715682a", "IFF-4/1", "AQAAAAEAACcQAAAAEObsFseaWTRo7jIAGnv89B7biPKLzdahijsPAhLboQfwVVSVTuGevWFeiOmSOq1U8A==", "cfb85ac7-284b-4455-9133-3dfd7d54947e", 152463389L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440040",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0853254f-96bd-46ce-8ab7-4de1afb23973", "IFF-6/8", "AQAAAAEAACcQAAAAEHZoGUKuYbqLNCkHgFQI5TuBRnpdCmh7kAT3O/AmvICXueAFokAF9jfJprxoXQ4bGA==", "61b82d5d-30e4-49f0-97a1-020bf7cdf552", 187440141L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440041",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9e55ee4a-8f15-46d1-aae9-faffb0ab56e3", "IFF-3/4", "AQAAAAEAACcQAAAAEJjIJCskQAbE7vSCTDTpVQ+t8kEzBgghQmuNGqIy0dJN4/lSHGHHYOYWN02b+J/5jg==", "5203d520-c58b-439f-acb0-064766622fcf", 168678570L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440042",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "99fd3660-979e-4a15-bd96-f7ba9a79d167", "IFF-6/6", "AQAAAAEAACcQAAAAEMJ6S4C16rgJ5Fi+t0vv6H1yJqkRjuBewR0rzH4IibQnnVmsgxRETWeU3g0xxal4ig==", "49c37af5-875a-4a5a-a958-35f41bab201c", 172492011L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440043",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0cbab7e1-c08e-4391-a74d-d5f51d3d26e8", "IFF-2/3", "AQAAAAEAACcQAAAAEDzcE2XqwPjeRIA2WpPSfIeC4cigSqgrPfnF+BXqUOlPypIBa41TLfIGDt7cL7iWmw==", "5ffbbb19-2398-4cec-8b92-6b19a5c209bf", 179671973L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440044",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1ad61ec3-2325-410d-9b1b-13d3215e70d0", "IFF-8/8", "AQAAAAEAACcQAAAAEGDMAe+ahUB2ktwr1rL8v1xbRyVJUtOiJe1oPiZk+EL3DrO1wQn5/7YXo+bVk9kxSA==", "f6eab326-0a93-4b68-b1c4-bfbdc28af68b", 164882305L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440045",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "bc2ad89a-b90c-49f4-bc91-f2420a493654", "IFF-8/4", "AQAAAAEAACcQAAAAEDf59xKOkI5WQTjgJQDJfvhDVJOTeCDPxNFFn2y4dpZ6QXVT4J7iu8tFOhYbwjsGBQ==", "4a502c7b-5c53-441e-9d57-9f9d997371b1", 190352498L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440046",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a77a76a9-71f0-4771-bce4-f9f74598ca81", "IFF-9/6", "AQAAAAEAACcQAAAAEIjHMuVhoutDV4w4d75/8um8gIX650QVvOrPWROxNWGumS1wctA3My9GYuzE+P2ecg==", "2d38bac3-0243-4475-8b29-66428d764354", 108897859L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440047",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "25d5d3ba-51c4-44a0-b4ac-4920824f499f", "IFF-7/7", "AQAAAAEAACcQAAAAECVh5t9UEwDO8IPQmaYMe+3pYq4VdSOOANoBpnI/KWUUIkNrnwz5DX3OTqqqrvKShw==", "c57a2fa9-b7e4-464d-a197-e2b47439c855", 152399322L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440048",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "2eb129fb-5f3e-4c16-9c10-23a4c2bd6e26", "IFF-5/8", "AQAAAAEAACcQAAAAELxiZLYf8+mcIiZleN90zs/dhi9BgCViVu01uQuVIdkU0U4nAX899f/WFB/mdkm07Q==", "2d8dbf56-042a-480a-aa4d-6edd26931229", 102025125L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440049",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9a5f99a1-9452-4365-93ec-d6b40bb42865", "IFF-3/8", "AQAAAAEAACcQAAAAEAAyGf7/psPHVLKMj10WNs7H0Pw42od9MMG33xBhQvHae/4Rm2A8qDtuOB91YRyWSA==", "b857c343-426d-493d-9d53-946a1976c592", 148125781L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440050",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "81c066a3-85ef-403b-b950-81eb4ec8362d", "IFF-4/1", "AQAAAAEAACcQAAAAEOqicV2+s/yeWPTbFrX0JR5oMyDzAVJrpuVMRpuOmtR0q6g9/ieBwHKolooF1urY/A==", "5cc99333-0340-476b-96a3-0dc5a380438a", 187036149L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440051",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0dc854de-ba13-4f7a-83db-d5fe00bc59d2", "IFF-4/7", "AQAAAAEAACcQAAAAEGm7fGV+97QlLuhWb/75H40gw4ooYFhUKLNWzma+aLnzkG+ZL1PMR0/aVitBm2TRuA==", "d74bae4a-668a-48ff-a119-cb466169031d", 191734451L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440052",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "38134bc3-d2a2-4690-bca1-112528db3e9e", "IFF-4/8", "AQAAAAEAACcQAAAAENOWUye5EjOEnKVio1z9CjZ9skYyV53W4wDuMNd+McsPDlHg+R3yr3k5IacgxhwDOQ==", "d72151be-8d2a-48bc-b34d-089e263a72ee", 153396077L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440053",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e695220f-b877-47d8-8ed5-8b228659c03e", "IFF-9/4", "AQAAAAEAACcQAAAAEMSAMRZE57TfD9kTpXkTK9ArOz0GmqzanwHHwSV4kxMnq+vCRZIMwucFWkP4RAR1jQ==", "017bcb49-94d8-4ebc-a0b0-28482ab99b47", 141450514L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440054",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fbad8d4f-357f-4a03-9812-bd1113ed6378", "IFF-5/1", "AQAAAAEAACcQAAAAEA3NmpoqoZTLZa1Md4l8Rv5N6ldXKpxbnQQzQji7MuNwosQQeGPLfy7+yXbRPQFa2Q==", "58e0086b-4ec1-49ce-b41e-e165921f84dc", 179910459L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440055",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a0e73437-a0b8-4bbb-a39d-1176ba694dca", "IFF-7/3", "AQAAAAEAACcQAAAAENPJ78XjBlpNLvosU73yxikRIWvx5vzoulfcd4s+yxV7xCTS4PicZLGlZbWxwruPNg==", "e1c6ad40-d1c2-4c11-ba37-e5851fe173c5", 136088086L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440056",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1c63e269-d255-44a4-b55d-7313bbabeb21", "IFF-9/4", "AQAAAAEAACcQAAAAEP0KiQOKH6LZwGBAN09/OWROT3PaoUQWI86sPCuKYB2VW3AmsOPdotFHCMXhN1cNNQ==", "080f54da-bc37-443c-8678-e97f7011d8f9", 129309875L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440057",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "67514f68-dc4b-4a66-866f-4fbd8a03c660", "IFF-4/5", "AQAAAAEAACcQAAAAELkQQjrP29V9JpWeIy6im+E5lPOAQWoFZ+ECygKsrnwgSzNGKr/k4g8bqGldXNJfuA==", "7ff1a1c3-248e-49e6-9989-b379039a073d", 163363101L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440058",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6781118e-0467-4ce0-b478-b4ceadeb8e47", "IFF-4/9", "AQAAAAEAACcQAAAAEBMwyDWP4obdWtZfyczXPbIrKW5FHO1qoRLQUO4ZCPB1R8ZiT9n70155gjhqs7U8NA==", "715afaca-9c86-4ad6-9a34-768e3d472177", 147667882L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440059",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "010fa99c-517c-4e3a-8200-b3569b708ea1", "IFF-6/8", "AQAAAAEAACcQAAAAEHhqauE6/UxplZd/MfBnxRE7aFmNejHaAh0aSgWFPdsSxjaxPqSwcmgmrCytB/OOZg==", "b219c5f8-370e-4371-9582-89b4e0ab46ea", 108252964L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440060",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4ce965ca-d3df-427d-b730-8a2318904411", "AQAAAAEAACcQAAAAEOKK6tAarj1nQEzbPiIv1cfGfQ7pXCDYu4ngITU/JF75cJfjW1NMkW7Xc204lKneeg==", "513c1128-0b0b-483e-b660-09417dafad73", 150147271L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440061",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "49c4d054-a667-4895-9abc-836c98b7ec00", "IFF-9/7", "AQAAAAEAACcQAAAAEAgWHEB+/pJAISQiMUJ6QQFuGJ0zKn07fen67idM3r3fSBJdhElc1dvkU+R4Qej6RA==", "79815425-7e83-4bdf-b8c9-a460efa54574", 179422719L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440062",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fc7e92dd-489d-4c14-8dd9-4b1cade3f080", "IFF-7/5", "AQAAAAEAACcQAAAAENHp9qSOjJ3ib6fOZgO1Av4mkLTqjPUc43RXSqToyfq9+dTQCZthHiaKWMwDyUAenw==", "ad274ec7-64ba-471b-b7f9-f51bb2a334c9", 130595657L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440063",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "30cc72a6-7dba-4d13-874c-740696f27922", "IFF-4/5", "AQAAAAEAACcQAAAAEPUpFi1gkvAKj7g7UhrY9Jgg7VwG+gwhy9A5OBj4CQEk/RGad1inrF9eRGRuaFEyIg==", "a9ab7ad7-1bfb-4fd2-a64b-7e0f9dbed41a", 101178755L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440064",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "f7de14dd-69fa-472e-ab68-05e22003a379", "IFF-7/9", "AQAAAAEAACcQAAAAECeTENMaBEpHRIvsqBBumRo9Q22cuFI2qrLuxoEE1DLYkHElpcblOxaJaOjsioQk3A==", "e5c94cc9-a6b6-44e8-b780-303625ff1cc3", 147849580L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440065",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1504be10-535a-4ec0-b683-d3dd6372496b", "IFF-7/2", "AQAAAAEAACcQAAAAEGlFkVrDeR43r8P/bJ70wPCL2fZWxiTs54y0Yi/eub+bJSESuGL7aFWXsPt47nn8zw==", "13dce6a9-ec72-46c6-9d25-89fad08aa81d", 119701791L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440066",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "473132d1-2a91-4584-96a9-55b859ddc392", "IFF-6/7", "AQAAAAEAACcQAAAAEEn+dTmfhIYZGx4TEdlwrK6Bi+RBLkvrSCKOc/dOokBeH5ArgW2h4uVM3LdXXJ53Fw==", "3501156f-4fc7-4bf9-a1cc-547cb4bf8f8c", 173710934L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440067",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c2c16550-21a1-41f5-90e4-fc0644b8cd6c", "IFF-2/4", "AQAAAAEAACcQAAAAENVxY93ticcdoSFVR2Gz3K2o05HSgyZ4Y03CEUNXlBlOzEOt7jW5noAhuE1tnZWJCQ==", "12dcac66-e563-4148-8bee-8c45cbd33e4b", 161439082L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440068",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "cc82b873-726d-4df3-a080-2af14ca02909", "IFF-3/9", "AQAAAAEAACcQAAAAEJSul+3fA74/KtuO2lJ0dHjv1ruTJV6utVHJwT4l3Erho16LHyhMs7l7/r+iknMuSQ==", "5c0d5de4-e4f9-44ea-9b8d-20a9ef465682", 149776314L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440069",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "98598077-3759-4b5b-9049-116a338a6f4b", "IFF-4/1", "AQAAAAEAACcQAAAAEHuJUWdLMLTLIr2o3e5lbQQ92zvvKml2rUUIX2Xdl16nNCsb8CPO7RLj4gTb5gaCbA==", "419cd3dd-ca2c-47d7-937b-aecb1bfde3ce", 154822819L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440070",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fdf8020a-73b3-456a-825f-07a2599064c8", "IFF-5/7", "AQAAAAEAACcQAAAAEFJpyF8gah7ztD+yhwcH5lTQoFkJzyaYs0/LTbFTMY5OSsFSGMUGZNdMSEbhO/WgAQ==", "973ebadf-f254-41b4-beb9-b370a53f8702", 183398415L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440071",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1060035a-f026-42ae-b7ae-552750c12685", "IFF-9/7", "AQAAAAEAACcQAAAAEJbH/Vb89WSwIyCMS8DamZPR/kgNhiEaLJ3wh6NbVBZT1oRha8ddmkFDwxgmxNVNDg==", "949d8299-9799-48c4-90d2-54e33507bc99", 106994517L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440072",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "8dc47fce-13e3-44e7-881d-5aec44c92909", "IFF-1/6", "AQAAAAEAACcQAAAAECxOLmYTfIn8hPbwF0rQXDRwVnARpJbmQErBWmgC/pgBpVZHteL+EjrFdh8DicafTw==", "7e4bbd58-ae63-4ce8-aef5-dabc7dbb706c", 103752166L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440073",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "63704677-32e0-46a4-ae76-f8c8fa6f16cc", "IFF-1/9", "AQAAAAEAACcQAAAAEKg301bjQhUgv6I+xZy2EXmrg32enxSOXuUqeXZm1DFyl4ObTDdsljmueMLT0+Eptg==", "df3322b2-e526-4abb-9c6c-0116998b9be9", 131010267L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440074",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d25fc744-f06c-4a8d-92c9-7b92bf72b878", "IFF-3/6", "AQAAAAEAACcQAAAAENm5hgHFlXMbC3Ll0H1JY6vJYTnXgyE6PsYIFSj1XJaWeDgaro8/QZy5F7xJD0oi9g==", "8a671dce-33e9-46f5-a324-6426902af306", 177772031L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440075",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "3ed249b4-798f-4140-88b9-c9c70a5854a6", "IFF-2/7", "AQAAAAEAACcQAAAAEJDBjrJ22bCTFZgom3dA7GPOtyVIGZ3wcBLIeKU2GRspiWjeR44QgsmiG8XwLOSDvQ==", "fbaa7e17-e5aa-439f-88a1-c4a086203425", 189355350L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440076",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "6dc96a45-1fbe-49a4-ac74-6824b9946553", "IFF-3/6", "AQAAAAEAACcQAAAAEMq4LEwAGx1V1EXwm22d6NsgV50fENMe0ZYqS40Pegnobq6Zuvudb8ggD1XDL3HWLw==", "06d9d958-e57b-46da-83c4-d7672fe0fa58", 147989793L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440077",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d11fde84-eeab-4412-bffa-8f65f2ccf1fc", "IFF-4/1", "AQAAAAEAACcQAAAAEAjd5DqXCScP+LQpNZgV6PSoi7l5pUO6ojmP7QaaC372iKw90HIKGNGCGuQIqT7Jzw==", "afa27d56-203a-4fc2-aba6-8e8d87a666b7", 177472563L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440078",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "a5d03575-5118-4214-80a3-62090df2c16b", "IFF-8/1", "AQAAAAEAACcQAAAAEAEjOXCiMltoWKp/cqWASWh6wm8iAyhCKdgifxnhvJE49NoWk6HoIqSLKDP5JNsCvw==", "d371c60e-944d-418b-a168-41b51ed7538b", 101942312L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440079",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "67a90f17-73c5-4ef6-8243-25744b5c9d15", "IFF-3/7", "AQAAAAEAACcQAAAAEFqOALUZB9SYhVX+VrEgl9TFTM9oyl7Y7I8vPdmiwf2ZiqD3odrMc+PV+VC0m52SAA==", "14db572c-73e8-4217-b7ee-7e164c57ab93", 199785087L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440080",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e5904495-f176-416c-a076-af27040effc1", "IFF-7/3", "AQAAAAEAACcQAAAAEEUAzRbzBd1HrH7k3GCrR0gzxKxlxoq35p8cYp3IIs+/Q638tJe8VIwO5AoAJ5FamA==", "b4a7af71-ac29-47f2-afb7-1a0fd307c824", 172645801L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440081",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "5a97c20d-ee50-4647-bbac-9e4c239e4fa9", "IFF-2/9", "AQAAAAEAACcQAAAAEFSNWSsSMfrIqvvLfv9OxlNVNPv/7QyoFoxMVTOyO4QHIP0/s9se+cDeTSIbq2UBHQ==", "719ae40f-d3c6-454e-8938-e9542b7e028c", 143734290L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440082",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9d97f0bd-c7bf-4282-8bb7-320032e1454e", "IFF-4/7", "AQAAAAEAACcQAAAAEG6Fe+SsmlKuLX2I4Iag3ioeJCI0aCx8ZErfXmtCB7nwPF80qt+9C6CM9aGnaYslag==", "d4729070-9381-41ba-9b39-dbdc89341755", 172732251L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440083",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "75cbac21-b357-4433-bea0-53bf44b2eba3", "IFF-2/7", "AQAAAAEAACcQAAAAEJSIxe5o+mXy/Vof1bOvpD01FGykl0pbzhYFDes0E40aPzhb5EbIM0zYi4N1R1isKg==", "7a34f5c0-0e27-4117-aa09-4b8e57668b34", 126303058L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440084",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9b3ad5bf-afb5-45de-b970-e7bff0e27557", "IFF-4/6", "AQAAAAEAACcQAAAAEFKelcRd2Kk3CLEyaKARLCi4Y9zXsWTiKaWAFDQH1LOxB3LEhCtw9fzjzqksr2aBrQ==", "638b9c24-bcd8-46a8-a94a-9407803bb0e4", 154280533L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440085",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0be07175-445a-41e2-beb4-c9562ddec024", "IFF-8/9", "AQAAAAEAACcQAAAAEOG9gqa6KqkBaWs3eDlr22mHIjtoLq2AWcklhRqIuNa/mXKfkegV/eWmR7+k8Z+LcQ==", "32386ec2-1cf5-4933-9ba8-715c4cccc9d1", 179408843L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440086",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "c9246077-2f9a-4d7c-b145-2fcc1083d72e", "IFF-6/1", "AQAAAAEAACcQAAAAEM2xYVmPmOZBCPfYdmVT20frBw22o61atMQt3zpZtQNGuwd4i/A5Ie7qvkDo+DZP1g==", "85c0e3a1-f7a2-4377-9e82-07d4ee9ee8b2", 176997793L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440087",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "64d80eb3-b865-46e9-93cc-5ebc01befe37", "IFF-1/2", "AQAAAAEAACcQAAAAEIrs1HAQPscw4vXo/na9h2CSy3GCpePQoKkMi/B1ScP+BXkd3cj2YBvAFNQAZm9Rug==", "f7e832f8-09fc-4138-b294-b36193384277", 122498934L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440088",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "9de92915-b25e-47ff-9c10-a6471ed79bd8", "IFF-1/1", "AQAAAAEAACcQAAAAENycqP5snXjL/7KxCk8W+UEvrYM4KauQozPPX8YVLxEmZXrF9e9nHfpIbYgklwnuDg==", "25071234-3b34-4519-b463-900217d86b42", 142277208L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440089",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4ec431a5-2676-47eb-b107-4dbc26b546f3", "IFF-1/1", "AQAAAAEAACcQAAAAEOwIv3qtyBaCaZFNQ5rDLPhmgAy1eQorfIPJ+3U6m204EnW44APxxYd2/CHzvx4ZRQ==", "09d183da-b047-4d7c-a877-88538dfb649e", 173159722L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440090",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "086cf459-fffe-4b48-80ab-a70d1014f2c4", "IFF-1/7", "AQAAAAEAACcQAAAAEH4sQ/piXz4gb1WYDBpZiIvfV+Oa6huR0qz0+yRk87GEOm/hBmbt0KJOZnif/Bg/dw==", "7a66f78f-ef46-45b2-9ffb-d4d860ea8a3d", 166906247L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440091",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "ab0a1ecb-cf28-4924-8347-bd211815155c", "IFF-6/3", "AQAAAAEAACcQAAAAEFw1lb+rASu89XYcbNbHLAWHRZZpuZv3KKD4B9nzS43Ai/3KpT8bzxsX9gq1ryPL/A==", "97a1f744-57d2-495f-9041-480cd99662de", 193641841L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440092",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "1842988b-148d-457f-84c6-cdfad63aafe1", "IFF-4/1", "AQAAAAEAACcQAAAAEGc48kvGOEAqZDPODcj2/G7/LSjcLZxfLP16cN4WRHpWZ8K76YsWb2VGYz+C5E0Nyw==", "d93e3863-604f-4b57-bc85-c90d47e5ef86", 168315364L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440093",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "4e916fc9-3c89-48d6-8791-f67209e0f28c", "IFF-2/7", "AQAAAAEAACcQAAAAED7JwjyTvKE3A/YxGb8UoUQXlvDZBhpu8chEuES9NKZwdkP8sJMK3uN92r/PUYzHjA==", "4c3a9025-6c2f-4d74-96c8-ac4dad7e83a9", 165055553L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440094",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0f8dd1a0-7a71-4244-8312-517982db0126", "IFF-2/2", "AQAAAAEAACcQAAAAEDY0TqW9HVLe6AwBrwqKi1+4W6rvTqcsh4KA4ZXSG3LbGo6YiBsXdZpwWmzAVyI3lA==", "094d8596-55a9-4a69-ac62-0d94588776f9", 199974084L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440095",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "fd9fb828-bd47-40cf-bcbe-df0724a018d0", "IFF-3/9", "AQAAAAEAACcQAAAAED0D8Fjfu7EelAKFTcvgg3llQem5QUc5iLzChvBxFRhX8CSDSQlyflVFq6qooL/Gug==", "98b14075-9f10-47d2-9683-b8576e4ff63c", 190550834L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440096",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "e4fee38a-8c64-4a11-aa7f-ecb5657ad59a", "IFF-3/1", "AQAAAAEAACcQAAAAEJs3qcKiQJABJefbiozZtiBgVf+kdxQnytj62dF0/B26+/n/XK4zDm7O2CLZan7iOA==", "117b0aa7-5f62-4c0b-9df0-ba85f88d8c74", 140271798L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440097",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "d5a7719b-ad52-482e-9044-8aa0a7cec803", "IFF-3/7", "AQAAAAEAACcQAAAAEIMgxWm5RTKKz6Z8IOvpsv74t+43YUt9UGNbyGmEUMaYBTxNfXu6Ftuou8wlFRaIIA==", "82592824-327b-4b28-9a54-08b783635d2e", 114865538L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440098",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "0f22dee5-4285-4813-81ff-2d81a0922d59", "IFF-5/7", "AQAAAAEAACcQAAAAEKgFuNxx9+K04V57I6Xit7jKW5+NsGXmkgU59afdjycN/0TvOPOAi8dp2RGWTPrqbA==", "5b5b9f44-adf6-45b4-99e2-22ec0a1019e0", 160803248L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440099",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "943bc842-4cad-478c-aea2-bc702ec61743", "IFF-1/2", "AQAAAAEAACcQAAAAEGqsbPYG/YYcxXzY0BKdZRYdgJqJ9e2I+aCB9G9uVK0zIK89Qq5eIPe02oh2lkOsKA==", "e8e1380c-f946-4a70-9659-d6eab883d6b0", 112980808L });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440100",
                columns: new[] { "ConcurrencyStamp", "Group", "PasswordHash", "SecurityStamp", "UID" },
                values: new object[] { "288d5722-5bcb-4dd2-a037-4e022eb20d30", "IFF-9/4", "AQAAAAEAACcQAAAAEOrrdQXqS/TLxnrzP9DiInnfvJwDgcKQBQcdv4SMBS/0Kw1zMU+fGIZ8LVFweVAi4Q==", "4b3acedd-5248-4b3d-9b51-5c1902d764e6", 181212222L });
        }
    }
}
