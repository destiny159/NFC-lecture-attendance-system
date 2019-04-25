using Microsoft.EntityFrameworkCore.Migrations;

namespace NFCSystem.Migrations
{
    public partial class Mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575");

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Group", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCode", "Surname", "TwoFactorEnabled", "UID", "UserName" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd93440072", 0, "8dc47fce-13e3-44e7-881d-5aec44c92909", "Vardas072.Pavarde072072@email.com", false, "IFF-1/6", false, null, "Vardas072", "VARDAS072.PAVARDE072072@EMAIL.COM", "VARPAV072", "AQAAAAEAACcQAAAAECxOLmYTfIn8hPbwF0rQXDRwVnARpJbmQErBWmgC/pgBpVZHteL+EjrFdh8DicafTw==", null, false, "7e4bbd58-ae63-4ce8-aef5-dabc7dbb706c", "C00072", "Pavarde072", false, 103752166L, "varpav072" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440071", 0, "1060035a-f026-42ae-b7ae-552750c12685", "Vardas071.Pavarde071071@email.com", false, "IFF-9/7", false, null, "Vardas071", "VARDAS071.PAVARDE071071@EMAIL.COM", "VARPAV071", "AQAAAAEAACcQAAAAEJbH/Vb89WSwIyCMS8DamZPR/kgNhiEaLJ3wh6NbVBZT1oRha8ddmkFDwxgmxNVNDg==", null, false, "949d8299-9799-48c4-90d2-54e33507bc99", "C00071", "Pavarde071", false, 106994517L, "varpav071" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440070", 0, "fdf8020a-73b3-456a-825f-07a2599064c8", "Vardas070.Pavarde070070@email.com", false, "IFF-5/7", false, null, "Vardas070", "VARDAS070.PAVARDE070070@EMAIL.COM", "VARPAV070", "AQAAAAEAACcQAAAAEFJpyF8gah7ztD+yhwcH5lTQoFkJzyaYs0/LTbFTMY5OSsFSGMUGZNdMSEbhO/WgAQ==", null, false, "973ebadf-f254-41b4-beb9-b370a53f8702", "C00070", "Pavarde070", false, 183398415L, "varpav070" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440069", 0, "98598077-3759-4b5b-9049-116a338a6f4b", "Vardas069.Pavarde069069@email.com", false, "IFF-4/1", false, null, "Vardas069", "VARDAS069.PAVARDE069069@EMAIL.COM", "VARPAV069", "AQAAAAEAACcQAAAAEHuJUWdLMLTLIr2o3e5lbQQ92zvvKml2rUUIX2Xdl16nNCsb8CPO7RLj4gTb5gaCbA==", null, false, "419cd3dd-ca2c-47d7-937b-aecb1bfde3ce", "C00069", "Pavarde069", false, 154822819L, "varpav069" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440068", 0, "cc82b873-726d-4df3-a080-2af14ca02909", "Vardas068.Pavarde068068@email.com", false, "IFF-3/9", false, null, "Vardas068", "VARDAS068.PAVARDE068068@EMAIL.COM", "VARPAV068", "AQAAAAEAACcQAAAAEJSul+3fA74/KtuO2lJ0dHjv1ruTJV6utVHJwT4l3Erho16LHyhMs7l7/r+iknMuSQ==", null, false, "5c0d5de4-e4f9-44ea-9b8d-20a9ef465682", "C00068", "Pavarde068", false, 149776314L, "varpav068" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440067", 0, "c2c16550-21a1-41f5-90e4-fc0644b8cd6c", "Vardas067.Pavarde067067@email.com", false, "IFF-2/4", false, null, "Vardas067", "VARDAS067.PAVARDE067067@EMAIL.COM", "VARPAV067", "AQAAAAEAACcQAAAAENVxY93ticcdoSFVR2Gz3K2o05HSgyZ4Y03CEUNXlBlOzEOt7jW5noAhuE1tnZWJCQ==", null, false, "12dcac66-e563-4148-8bee-8c45cbd33e4b", "C00067", "Pavarde067", false, 161439082L, "varpav067" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440066", 0, "473132d1-2a91-4584-96a9-55b859ddc392", "Vardas066.Pavarde066066@email.com", false, "IFF-6/7", false, null, "Vardas066", "VARDAS066.PAVARDE066066@EMAIL.COM", "VARPAV066", "AQAAAAEAACcQAAAAEEn+dTmfhIYZGx4TEdlwrK6Bi+RBLkvrSCKOc/dOokBeH5ArgW2h4uVM3LdXXJ53Fw==", null, false, "3501156f-4fc7-4bf9-a1cc-547cb4bf8f8c", "C00066", "Pavarde066", false, 173710934L, "varpav066" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440065", 0, "1504be10-535a-4ec0-b683-d3dd6372496b", "Vardas065.Pavarde065065@email.com", false, "IFF-7/2", false, null, "Vardas065", "VARDAS065.PAVARDE065065@EMAIL.COM", "VARPAV065", "AQAAAAEAACcQAAAAEGlFkVrDeR43r8P/bJ70wPCL2fZWxiTs54y0Yi/eub+bJSESuGL7aFWXsPt47nn8zw==", null, false, "13dce6a9-ec72-46c6-9d25-89fad08aa81d", "C00065", "Pavarde065", false, 119701791L, "varpav065" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440064", 0, "f7de14dd-69fa-472e-ab68-05e22003a379", "Vardas064.Pavarde064064@email.com", false, "IFF-7/9", false, null, "Vardas064", "VARDAS064.PAVARDE064064@EMAIL.COM", "VARPAV064", "AQAAAAEAACcQAAAAECeTENMaBEpHRIvsqBBumRo9Q22cuFI2qrLuxoEE1DLYkHElpcblOxaJaOjsioQk3A==", null, false, "e5c94cc9-a6b6-44e8-b780-303625ff1cc3", "C00064", "Pavarde064", false, 147849580L, "varpav064" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440063", 0, "30cc72a6-7dba-4d13-874c-740696f27922", "Vardas063.Pavarde063063@email.com", false, "IFF-4/5", false, null, "Vardas063", "VARDAS063.PAVARDE063063@EMAIL.COM", "VARPAV063", "AQAAAAEAACcQAAAAEPUpFi1gkvAKj7g7UhrY9Jgg7VwG+gwhy9A5OBj4CQEk/RGad1inrF9eRGRuaFEyIg==", null, false, "a9ab7ad7-1bfb-4fd2-a64b-7e0f9dbed41a", "C00063", "Pavarde063", false, 101178755L, "varpav063" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440061", 0, "49c4d054-a667-4895-9abc-836c98b7ec00", "Vardas061.Pavarde061061@email.com", false, "IFF-9/7", false, null, "Vardas061", "VARDAS061.PAVARDE061061@EMAIL.COM", "VARPAV061", "AQAAAAEAACcQAAAAEAgWHEB+/pJAISQiMUJ6QQFuGJ0zKn07fen67idM3r3fSBJdhElc1dvkU+R4Qej6RA==", null, false, "79815425-7e83-4bdf-b8c9-a460efa54574", "C00061", "Pavarde061", false, 179422719L, "varpav061" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440073", 0, "63704677-32e0-46a4-ae76-f8c8fa6f16cc", "Vardas073.Pavarde073073@email.com", false, "IFF-1/9", false, null, "Vardas073", "VARDAS073.PAVARDE073073@EMAIL.COM", "VARPAV073", "AQAAAAEAACcQAAAAEKg301bjQhUgv6I+xZy2EXmrg32enxSOXuUqeXZm1DFyl4ObTDdsljmueMLT0+Eptg==", null, false, "df3322b2-e526-4abb-9c6c-0116998b9be9", "C00073", "Pavarde073", false, 131010267L, "varpav073" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440060", 0, "4ce965ca-d3df-427d-b730-8a2318904411", "Vardas060.Pavarde060060@email.com", false, "IFF-3/4", false, null, "Vardas060", "VARDAS060.PAVARDE060060@EMAIL.COM", "VARPAV060", "AQAAAAEAACcQAAAAEOKK6tAarj1nQEzbPiIv1cfGfQ7pXCDYu4ngITU/JF75cJfjW1NMkW7Xc204lKneeg==", null, false, "513c1128-0b0b-483e-b660-09417dafad73", "C00060", "Pavarde060", false, 150147271L, "varpav060" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440059", 0, "010fa99c-517c-4e3a-8200-b3569b708ea1", "Vardas059.Pavarde059059@email.com", false, "IFF-6/8", false, null, "Vardas059", "VARDAS059.PAVARDE059059@EMAIL.COM", "VARPAV059", "AQAAAAEAACcQAAAAEHhqauE6/UxplZd/MfBnxRE7aFmNejHaAh0aSgWFPdsSxjaxPqSwcmgmrCytB/OOZg==", null, false, "b219c5f8-370e-4371-9582-89b4e0ab46ea", "C00059", "Pavarde059", false, 108252964L, "varpav059" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440058", 0, "6781118e-0467-4ce0-b478-b4ceadeb8e47", "Vardas058.Pavarde058058@email.com", false, "IFF-4/9", false, null, "Vardas058", "VARDAS058.PAVARDE058058@EMAIL.COM", "VARPAV058", "AQAAAAEAACcQAAAAEBMwyDWP4obdWtZfyczXPbIrKW5FHO1qoRLQUO4ZCPB1R8ZiT9n70155gjhqs7U8NA==", null, false, "715afaca-9c86-4ad6-9a34-768e3d472177", "C00058", "Pavarde058", false, 147667882L, "varpav058" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440057", 0, "67514f68-dc4b-4a66-866f-4fbd8a03c660", "Vardas057.Pavarde057057@email.com", false, "IFF-4/5", false, null, "Vardas057", "VARDAS057.PAVARDE057057@EMAIL.COM", "VARPAV057", "AQAAAAEAACcQAAAAELkQQjrP29V9JpWeIy6im+E5lPOAQWoFZ+ECygKsrnwgSzNGKr/k4g8bqGldXNJfuA==", null, false, "7ff1a1c3-248e-49e6-9989-b379039a073d", "C00057", "Pavarde057", false, 163363101L, "varpav057" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440056", 0, "1c63e269-d255-44a4-b55d-7313bbabeb21", "Vardas056.Pavarde056056@email.com", false, "IFF-9/4", false, null, "Vardas056", "VARDAS056.PAVARDE056056@EMAIL.COM", "VARPAV056", "AQAAAAEAACcQAAAAEP0KiQOKH6LZwGBAN09/OWROT3PaoUQWI86sPCuKYB2VW3AmsOPdotFHCMXhN1cNNQ==", null, false, "080f54da-bc37-443c-8678-e97f7011d8f9", "C00056", "Pavarde056", false, 129309875L, "varpav056" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440055", 0, "a0e73437-a0b8-4bbb-a39d-1176ba694dca", "Vardas055.Pavarde055055@email.com", false, "IFF-7/3", false, null, "Vardas055", "VARDAS055.PAVARDE055055@EMAIL.COM", "VARPAV055", "AQAAAAEAACcQAAAAENPJ78XjBlpNLvosU73yxikRIWvx5vzoulfcd4s+yxV7xCTS4PicZLGlZbWxwruPNg==", null, false, "e1c6ad40-d1c2-4c11-ba37-e5851fe173c5", "C00055", "Pavarde055", false, 136088086L, "varpav055" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440054", 0, "fbad8d4f-357f-4a03-9812-bd1113ed6378", "Vardas054.Pavarde054054@email.com", false, "IFF-5/1", false, null, "Vardas054", "VARDAS054.PAVARDE054054@EMAIL.COM", "VARPAV054", "AQAAAAEAACcQAAAAEA3NmpoqoZTLZa1Md4l8Rv5N6ldXKpxbnQQzQji7MuNwosQQeGPLfy7+yXbRPQFa2Q==", null, false, "58e0086b-4ec1-49ce-b41e-e165921f84dc", "C00054", "Pavarde054", false, 179910459L, "varpav054" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440053", 0, "e695220f-b877-47d8-8ed5-8b228659c03e", "Vardas053.Pavarde053053@email.com", false, "IFF-9/4", false, null, "Vardas053", "VARDAS053.PAVARDE053053@EMAIL.COM", "VARPAV053", "AQAAAAEAACcQAAAAEMSAMRZE57TfD9kTpXkTK9ArOz0GmqzanwHHwSV4kxMnq+vCRZIMwucFWkP4RAR1jQ==", null, false, "017bcb49-94d8-4ebc-a0b0-28482ab99b47", "C00053", "Pavarde053", false, 141450514L, "varpav053" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440052", 0, "38134bc3-d2a2-4690-bca1-112528db3e9e", "Vardas052.Pavarde052052@email.com", false, "IFF-4/8", false, null, "Vardas052", "VARDAS052.PAVARDE052052@EMAIL.COM", "VARPAV052", "AQAAAAEAACcQAAAAENOWUye5EjOEnKVio1z9CjZ9skYyV53W4wDuMNd+McsPDlHg+R3yr3k5IacgxhwDOQ==", null, false, "d72151be-8d2a-48bc-b34d-089e263a72ee", "C00052", "Pavarde052", false, 153396077L, "varpav052" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440062", 0, "fc7e92dd-489d-4c14-8dd9-4b1cade3f080", "Vardas062.Pavarde062062@email.com", false, "IFF-7/5", false, null, "Vardas062", "VARDAS062.PAVARDE062062@EMAIL.COM", "VARPAV062", "AQAAAAEAACcQAAAAENHp9qSOjJ3ib6fOZgO1Av4mkLTqjPUc43RXSqToyfq9+dTQCZthHiaKWMwDyUAenw==", null, false, "ad274ec7-64ba-471b-b7f9-f51bb2a334c9", "C00062", "Pavarde062", false, 130595657L, "varpav062" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440074", 0, "d25fc744-f06c-4a8d-92c9-7b92bf72b878", "Vardas074.Pavarde074074@email.com", false, "IFF-3/6", false, null, "Vardas074", "VARDAS074.PAVARDE074074@EMAIL.COM", "VARPAV074", "AQAAAAEAACcQAAAAENm5hgHFlXMbC3Ll0H1JY6vJYTnXgyE6PsYIFSj1XJaWeDgaro8/QZy5F7xJD0oi9g==", null, false, "8a671dce-33e9-46f5-a324-6426902af306", "C00074", "Pavarde074", false, 177772031L, "varpav074" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440076", 0, "6dc96a45-1fbe-49a4-ac74-6824b9946553", "Vardas076.Pavarde076076@email.com", false, "IFF-3/6", false, null, "Vardas076", "VARDAS076.PAVARDE076076@EMAIL.COM", "VARPAV076", "AQAAAAEAACcQAAAAEMq4LEwAGx1V1EXwm22d6NsgV50fENMe0ZYqS40Pegnobq6Zuvudb8ggD1XDL3HWLw==", null, false, "06d9d958-e57b-46da-83c4-d7672fe0fa58", "C00076", "Pavarde076", false, 147989793L, "varpav076" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440051", 0, "0dc854de-ba13-4f7a-83db-d5fe00bc59d2", "Vardas051.Pavarde051051@email.com", false, "IFF-4/7", false, null, "Vardas051", "VARDAS051.PAVARDE051051@EMAIL.COM", "VARPAV051", "AQAAAAEAACcQAAAAEGm7fGV+97QlLuhWb/75H40gw4ooYFhUKLNWzma+aLnzkG+ZL1PMR0/aVitBm2TRuA==", null, false, "d74bae4a-668a-48ff-a119-cb466169031d", "C00051", "Pavarde051", false, 191734451L, "varpav051" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440098", 0, "0f22dee5-4285-4813-81ff-2d81a0922d59", "Vardas098.Pavarde098098@email.com", false, "IFF-5/7", false, null, "Vardas098", "VARDAS098.PAVARDE098098@EMAIL.COM", "VARPAV098", "AQAAAAEAACcQAAAAEKgFuNxx9+K04V57I6Xit7jKW5+NsGXmkgU59afdjycN/0TvOPOAi8dp2RGWTPrqbA==", null, false, "5b5b9f44-adf6-45b4-99e2-22ec0a1019e0", "C00098", "Pavarde098", false, 160803248L, "varpav098" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440097", 0, "d5a7719b-ad52-482e-9044-8aa0a7cec803", "Vardas097.Pavarde097097@email.com", false, "IFF-3/7", false, null, "Vardas097", "VARDAS097.PAVARDE097097@EMAIL.COM", "VARPAV097", "AQAAAAEAACcQAAAAEIMgxWm5RTKKz6Z8IOvpsv74t+43YUt9UGNbyGmEUMaYBTxNfXu6Ftuou8wlFRaIIA==", null, false, "82592824-327b-4b28-9a54-08b783635d2e", "C00097", "Pavarde097", false, 114865538L, "varpav097" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440096", 0, "e4fee38a-8c64-4a11-aa7f-ecb5657ad59a", "Vardas096.Pavarde096096@email.com", false, "IFF-3/1", false, null, "Vardas096", "VARDAS096.PAVARDE096096@EMAIL.COM", "VARPAV096", "AQAAAAEAACcQAAAAEJs3qcKiQJABJefbiozZtiBgVf+kdxQnytj62dF0/B26+/n/XK4zDm7O2CLZan7iOA==", null, false, "117b0aa7-5f62-4c0b-9df0-ba85f88d8c74", "C00096", "Pavarde096", false, 140271798L, "varpav096" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440095", 0, "fd9fb828-bd47-40cf-bcbe-df0724a018d0", "Vardas095.Pavarde095095@email.com", false, "IFF-3/9", false, null, "Vardas095", "VARDAS095.PAVARDE095095@EMAIL.COM", "VARPAV095", "AQAAAAEAACcQAAAAED0D8Fjfu7EelAKFTcvgg3llQem5QUc5iLzChvBxFRhX8CSDSQlyflVFq6qooL/Gug==", null, false, "98b14075-9f10-47d2-9683-b8576e4ff63c", "C00095", "Pavarde095", false, 190550834L, "varpav095" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440094", 0, "0f8dd1a0-7a71-4244-8312-517982db0126", "Vardas094.Pavarde094094@email.com", false, "IFF-2/2", false, null, "Vardas094", "VARDAS094.PAVARDE094094@EMAIL.COM", "VARPAV094", "AQAAAAEAACcQAAAAEDY0TqW9HVLe6AwBrwqKi1+4W6rvTqcsh4KA4ZXSG3LbGo6YiBsXdZpwWmzAVyI3lA==", null, false, "094d8596-55a9-4a69-ac62-0d94588776f9", "C00094", "Pavarde094", false, 199974084L, "varpav094" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440093", 0, "4e916fc9-3c89-48d6-8791-f67209e0f28c", "Vardas093.Pavarde093093@email.com", false, "IFF-2/7", false, null, "Vardas093", "VARDAS093.PAVARDE093093@EMAIL.COM", "VARPAV093", "AQAAAAEAACcQAAAAED7JwjyTvKE3A/YxGb8UoUQXlvDZBhpu8chEuES9NKZwdkP8sJMK3uN92r/PUYzHjA==", null, false, "4c3a9025-6c2f-4d74-96c8-ac4dad7e83a9", "C00093", "Pavarde093", false, 165055553L, "varpav093" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440092", 0, "1842988b-148d-457f-84c6-cdfad63aafe1", "Vardas092.Pavarde092092@email.com", false, "IFF-4/1", false, null, "Vardas092", "VARDAS092.PAVARDE092092@EMAIL.COM", "VARPAV092", "AQAAAAEAACcQAAAAEGc48kvGOEAqZDPODcj2/G7/LSjcLZxfLP16cN4WRHpWZ8K76YsWb2VGYz+C5E0Nyw==", null, false, "d93e3863-604f-4b57-bc85-c90d47e5ef86", "C00092", "Pavarde092", false, 168315364L, "varpav092" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440091", 0, "ab0a1ecb-cf28-4924-8347-bd211815155c", "Vardas091.Pavarde091091@email.com", false, "IFF-6/3", false, null, "Vardas091", "VARDAS091.PAVARDE091091@EMAIL.COM", "VARPAV091", "AQAAAAEAACcQAAAAEFw1lb+rASu89XYcbNbHLAWHRZZpuZv3KKD4B9nzS43Ai/3KpT8bzxsX9gq1ryPL/A==", null, false, "97a1f744-57d2-495f-9041-480cd99662de", "C00091", "Pavarde091", false, 193641841L, "varpav091" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440090", 0, "086cf459-fffe-4b48-80ab-a70d1014f2c4", "Vardas090.Pavarde090090@email.com", false, "IFF-1/7", false, null, "Vardas090", "VARDAS090.PAVARDE090090@EMAIL.COM", "VARPAV090", "AQAAAAEAACcQAAAAEH4sQ/piXz4gb1WYDBpZiIvfV+Oa6huR0qz0+yRk87GEOm/hBmbt0KJOZnif/Bg/dw==", null, false, "7a66f78f-ef46-45b2-9ffb-d4d860ea8a3d", "C00090", "Pavarde090", false, 166906247L, "varpav090" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440089", 0, "4ec431a5-2676-47eb-b107-4dbc26b546f3", "Vardas089.Pavarde089089@email.com", false, "IFF-1/1", false, null, "Vardas089", "VARDAS089.PAVARDE089089@EMAIL.COM", "VARPAV089", "AQAAAAEAACcQAAAAEOwIv3qtyBaCaZFNQ5rDLPhmgAy1eQorfIPJ+3U6m204EnW44APxxYd2/CHzvx4ZRQ==", null, false, "09d183da-b047-4d7c-a877-88538dfb649e", "C00089", "Pavarde089", false, 173159722L, "varpav089" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440075", 0, "3ed249b4-798f-4140-88b9-c9c70a5854a6", "Vardas075.Pavarde075075@email.com", false, "IFF-2/7", false, null, "Vardas075", "VARDAS075.PAVARDE075075@EMAIL.COM", "VARPAV075", "AQAAAAEAACcQAAAAEJDBjrJ22bCTFZgom3dA7GPOtyVIGZ3wcBLIeKU2GRspiWjeR44QgsmiG8XwLOSDvQ==", null, false, "fbaa7e17-e5aa-439f-88a1-c4a086203425", "C00075", "Pavarde075", false, 189355350L, "varpav075" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440088", 0, "9de92915-b25e-47ff-9c10-a6471ed79bd8", "Vardas088.Pavarde088088@email.com", false, "IFF-1/1", false, null, "Vardas088", "VARDAS088.PAVARDE088088@EMAIL.COM", "VARPAV088", "AQAAAAEAACcQAAAAENycqP5snXjL/7KxCk8W+UEvrYM4KauQozPPX8YVLxEmZXrF9e9nHfpIbYgklwnuDg==", null, false, "25071234-3b34-4519-b463-900217d86b42", "C00088", "Pavarde088", false, 142277208L, "varpav088" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440086", 0, "c9246077-2f9a-4d7c-b145-2fcc1083d72e", "Vardas086.Pavarde086086@email.com", false, "IFF-6/1", false, null, "Vardas086", "VARDAS086.PAVARDE086086@EMAIL.COM", "VARPAV086", "AQAAAAEAACcQAAAAEM2xYVmPmOZBCPfYdmVT20frBw22o61atMQt3zpZtQNGuwd4i/A5Ie7qvkDo+DZP1g==", null, false, "85c0e3a1-f7a2-4377-9e82-07d4ee9ee8b2", "C00086", "Pavarde086", false, 176997793L, "varpav086" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440085", 0, "0be07175-445a-41e2-beb4-c9562ddec024", "Vardas085.Pavarde085085@email.com", false, "IFF-8/9", false, null, "Vardas085", "VARDAS085.PAVARDE085085@EMAIL.COM", "VARPAV085", "AQAAAAEAACcQAAAAEOG9gqa6KqkBaWs3eDlr22mHIjtoLq2AWcklhRqIuNa/mXKfkegV/eWmR7+k8Z+LcQ==", null, false, "32386ec2-1cf5-4933-9ba8-715c4cccc9d1", "C00085", "Pavarde085", false, 179408843L, "varpav085" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440084", 0, "9b3ad5bf-afb5-45de-b970-e7bff0e27557", "Vardas084.Pavarde084084@email.com", false, "IFF-4/6", false, null, "Vardas084", "VARDAS084.PAVARDE084084@EMAIL.COM", "VARPAV084", "AQAAAAEAACcQAAAAEFKelcRd2Kk3CLEyaKARLCi4Y9zXsWTiKaWAFDQH1LOxB3LEhCtw9fzjzqksr2aBrQ==", null, false, "638b9c24-bcd8-46a8-a94a-9407803bb0e4", "C00084", "Pavarde084", false, 154280533L, "varpav084" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440083", 0, "75cbac21-b357-4433-bea0-53bf44b2eba3", "Vardas083.Pavarde083083@email.com", false, "IFF-2/7", false, null, "Vardas083", "VARDAS083.PAVARDE083083@EMAIL.COM", "VARPAV083", "AQAAAAEAACcQAAAAEJSIxe5o+mXy/Vof1bOvpD01FGykl0pbzhYFDes0E40aPzhb5EbIM0zYi4N1R1isKg==", null, false, "7a34f5c0-0e27-4117-aa09-4b8e57668b34", "C00083", "Pavarde083", false, 126303058L, "varpav083" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440082", 0, "9d97f0bd-c7bf-4282-8bb7-320032e1454e", "Vardas082.Pavarde082082@email.com", false, "IFF-4/7", false, null, "Vardas082", "VARDAS082.PAVARDE082082@EMAIL.COM", "VARPAV082", "AQAAAAEAACcQAAAAEG6Fe+SsmlKuLX2I4Iag3ioeJCI0aCx8ZErfXmtCB7nwPF80qt+9C6CM9aGnaYslag==", null, false, "d4729070-9381-41ba-9b39-dbdc89341755", "C00082", "Pavarde082", false, 172732251L, "varpav082" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440081", 0, "5a97c20d-ee50-4647-bbac-9e4c239e4fa9", "Vardas081.Pavarde081081@email.com", false, "IFF-2/9", false, null, "Vardas081", "VARDAS081.PAVARDE081081@EMAIL.COM", "VARPAV081", "AQAAAAEAACcQAAAAEFSNWSsSMfrIqvvLfv9OxlNVNPv/7QyoFoxMVTOyO4QHIP0/s9se+cDeTSIbq2UBHQ==", null, false, "719ae40f-d3c6-454e-8938-e9542b7e028c", "C00081", "Pavarde081", false, 143734290L, "varpav081" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440080", 0, "e5904495-f176-416c-a076-af27040effc1", "Vardas080.Pavarde080080@email.com", false, "IFF-7/3", false, null, "Vardas080", "VARDAS080.PAVARDE080080@EMAIL.COM", "VARPAV080", "AQAAAAEAACcQAAAAEEUAzRbzBd1HrH7k3GCrR0gzxKxlxoq35p8cYp3IIs+/Q638tJe8VIwO5AoAJ5FamA==", null, false, "b4a7af71-ac29-47f2-afb7-1a0fd307c824", "C00080", "Pavarde080", false, 172645801L, "varpav080" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440079", 0, "67a90f17-73c5-4ef6-8243-25744b5c9d15", "Vardas079.Pavarde079079@email.com", false, "IFF-3/7", false, null, "Vardas079", "VARDAS079.PAVARDE079079@EMAIL.COM", "VARPAV079", "AQAAAAEAACcQAAAAEFqOALUZB9SYhVX+VrEgl9TFTM9oyl7Y7I8vPdmiwf2ZiqD3odrMc+PV+VC0m52SAA==", null, false, "14db572c-73e8-4217-b7ee-7e164c57ab93", "C00079", "Pavarde079", false, 199785087L, "varpav079" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440078", 0, "a5d03575-5118-4214-80a3-62090df2c16b", "Vardas078.Pavarde078078@email.com", false, "IFF-8/1", false, null, "Vardas078", "VARDAS078.PAVARDE078078@EMAIL.COM", "VARPAV078", "AQAAAAEAACcQAAAAEAEjOXCiMltoWKp/cqWASWh6wm8iAyhCKdgifxnhvJE49NoWk6HoIqSLKDP5JNsCvw==", null, false, "d371c60e-944d-418b-a168-41b51ed7538b", "C00078", "Pavarde078", false, 101942312L, "varpav078" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440077", 0, "d11fde84-eeab-4412-bffa-8f65f2ccf1fc", "Vardas077.Pavarde077077@email.com", false, "IFF-4/1", false, null, "Vardas077", "VARDAS077.PAVARDE077077@EMAIL.COM", "VARPAV077", "AQAAAAEAACcQAAAAEAjd5DqXCScP+LQpNZgV6PSoi7l5pUO6ojmP7QaaC372iKw90HIKGNGCGuQIqT7Jzw==", null, false, "afa27d56-203a-4fc2-aba6-8e8d87a666b7", "C00077", "Pavarde077", false, 177472563L, "varpav077" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440087", 0, "64d80eb3-b865-46e9-93cc-5ebc01befe37", "Vardas087.Pavarde087087@email.com", false, "IFF-1/2", false, null, "Vardas087", "VARDAS087.PAVARDE087087@EMAIL.COM", "VARPAV087", "AQAAAAEAACcQAAAAEIrs1HAQPscw4vXo/na9h2CSy3GCpePQoKkMi/B1ScP+BXkd3cj2YBvAFNQAZm9Rug==", null, false, "f7e832f8-09fc-4138-b294-b36193384277", "C00087", "Pavarde087", false, 122498934L, "varpav087" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440050", 0, "81c066a3-85ef-403b-b950-81eb4ec8362d", "Vardas050.Pavarde050050@email.com", false, "IFF-4/1", false, null, "Vardas050", "VARDAS050.PAVARDE050050@EMAIL.COM", "VARPAV050", "AQAAAAEAACcQAAAAEOqicV2+s/yeWPTbFrX0JR5oMyDzAVJrpuVMRpuOmtR0q6g9/ieBwHKolooF1urY/A==", null, false, "5cc99333-0340-476b-96a3-0dc5a380438a", "C00050", "Pavarde050", false, 187036149L, "varpav050" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440049", 0, "9a5f99a1-9452-4365-93ec-d6b40bb42865", "Vardas049.Pavarde049049@email.com", false, "IFF-3/8", false, null, "Vardas049", "VARDAS049.PAVARDE049049@EMAIL.COM", "VARPAV049", "AQAAAAEAACcQAAAAEAAyGf7/psPHVLKMj10WNs7H0Pw42od9MMG33xBhQvHae/4Rm2A8qDtuOB91YRyWSA==", null, false, "b857c343-426d-493d-9d53-946a1976c592", "C00049", "Pavarde049", false, 148125781L, "varpav049" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440048", 0, "2eb129fb-5f3e-4c16-9c10-23a4c2bd6e26", "Vardas048.Pavarde048048@email.com", false, "IFF-5/8", false, null, "Vardas048", "VARDAS048.PAVARDE048048@EMAIL.COM", "VARPAV048", "AQAAAAEAACcQAAAAELxiZLYf8+mcIiZleN90zs/dhi9BgCViVu01uQuVIdkU0U4nAX899f/WFB/mdkm07Q==", null, false, "2d8dbf56-042a-480a-aa4d-6edd26931229", "C00048", "Pavarde048", false, 102025125L, "varpav048" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440021", 0, "43545c03-45a6-4a09-ae55-50cdf4e417bc", "Vardas021.Pavarde021021@email.com", false, "IFF-6/8", false, null, "Vardas021", "VARDAS021.PAVARDE021021@EMAIL.COM", "VARPAV021", "AQAAAAEAACcQAAAAEFNDgJ+Z+GT/ZX+nGdYliFDYpRW2NN48853AZUdDiUNEKefefK2OBWBNZbewUOxX3g==", null, false, "43dc1a54-322d-40b8-a8f5-cbad72fef3c0", "C00021", "Pavarde021", false, 107229098L, "varpav021" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440020", 0, "e86e9d65-d1c3-4b58-85da-b62016c8258d", "Vardas020.Pavarde020020@email.com", false, "IFF-4/4", false, null, "Vardas020", "VARDAS020.PAVARDE020020@EMAIL.COM", "VARPAV020", "AQAAAAEAACcQAAAAEP2TWnRt6BJ4Pj2674MVc0MGEl7ejSSQHhXgMC3tW1qBMWTHMq6l7K/af2fVx0un0w==", null, false, "9037dea4-3088-4e61-8f66-f057bc1ef6f0", "C00020", "Pavarde020", false, 119447802L, "varpav020" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440019", 0, "a1c74ac4-63fb-4f6b-bfcc-3dc9d6bec4d3", "Vardas019.Pavarde019019@email.com", false, "IFF-3/2", false, null, "Vardas019", "VARDAS019.PAVARDE019019@EMAIL.COM", "VARPAV019", "AQAAAAEAACcQAAAAEMUZot1JR1XcyptJGTeWGJWlCqO7sXN6DCTI7G6u3ojel/GxrgALcimg7odZh1KWvw==", null, false, "f9ddc9cd-4357-4d51-ae3c-20bcf5ff82ed", "C00019", "Pavarde019", false, 130512498L, "varpav019" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440018", 0, "6bbd5c23-5748-4d0c-a505-d7b871027874", "Vardas018.Pavarde018018@email.com", false, "IFF-4/9", false, null, "Vardas018", "VARDAS018.PAVARDE018018@EMAIL.COM", "VARPAV018", "AQAAAAEAACcQAAAAEL2J5rvAxPwyFp1fCILxBYQ7fWZNpwrwYvHjcCXsEk8ScagrWhXGE/CkEKa7J/wF1g==", null, false, "5185c4ac-7b96-4ee2-b333-b8a68953cbfc", "C00018", "Pavarde018", false, 123810382L, "varpav018" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440017", 0, "826366cf-c859-4e83-aa07-83f36e4f606b", "Vardas017.Pavarde017017@email.com", false, "IFF-2/9", false, null, "Vardas017", "VARDAS017.PAVARDE017017@EMAIL.COM", "VARPAV017", "AQAAAAEAACcQAAAAEGDpYsvIukgW8uYub3TVBz2gBcO6sTH7DxEqR96IU5aXmwxtLoULBTQPT7A7zaC1Yw==", null, false, "3511a159-28be-4d97-9b01-6e65a4640bcb", "C00017", "Pavarde017", false, 171961001L, "varpav017" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440016", 0, "7050c19b-3733-4f9d-b40f-a891bfa1498e", "Vardas016.Pavarde016016@email.com", false, "IFF-2/9", false, null, "Vardas016", "VARDAS016.PAVARDE016016@EMAIL.COM", "VARPAV016", "AQAAAAEAACcQAAAAEBO2Sl/GWgKg1MTiFjNit9+jZIOW7iI9i2EiRTIy4hlyMaT+NDjJHAOySSe8F8D8ng==", null, false, "70eca6f4-e9b7-4087-856d-09c52f3e280e", "C00016", "Pavarde016", false, 120714739L, "varpav016" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440015", 0, "df5a4138-ff9c-4d45-b85e-527f0ea4d361", "Vardas015.Pavarde015015@email.com", false, "IFF-2/5", false, null, "Vardas015", "VARDAS015.PAVARDE015015@EMAIL.COM", "VARPAV015", "AQAAAAEAACcQAAAAEIzfIVFG4KX/IigTP7uUo5lwm3VlYi97dlZ6A+r++vqWphb4Q/3g+cHoEtLe1DfMww==", null, false, "4a34e5ff-dcae-48b5-a256-b1faf4634f16", "C00015", "Pavarde015", false, 117760766L, "varpav015" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440014", 0, "29bb88b9-c71c-423e-bd70-54ff86101012", "Vardas014.Pavarde014014@email.com", false, "IFF-6/2", false, null, "Vardas014", "VARDAS014.PAVARDE014014@EMAIL.COM", "VARPAV014", "AQAAAAEAACcQAAAAEKgucjOZVZL+F/kcZAms/Y41VZs9P/WpD3jomKU0iiHvLJ4LQUpNp5kxHfbu4RfSVg==", null, false, "c077d1f5-ce0d-44f5-9c5a-419827fb9184", "C00014", "Pavarde014", false, 151133193L, "varpav014" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440013", 0, "585b6757-6002-4d83-aa7f-c599821e87a2", "Vardas013.Pavarde013013@email.com", false, "IFF-3/4", false, null, "Vardas013", "VARDAS013.PAVARDE013013@EMAIL.COM", "VARPAV013", "AQAAAAEAACcQAAAAEH9JJttrtkC04ggS4pJZPONRLG3bouybUkVgYhsMDoMm1YnjO234a9wUdvcgSXg/kQ==", null, false, "1033e3d5-1080-4db3-9a84-37a2865a2d28", "C00013", "Pavarde013", false, 128289546L, "varpav013" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440012", 0, "875945c7-1eb2-4d22-9cf7-081a1b7134b7", "Vardas012.Pavarde012012@email.com", false, "IFF-8/3", false, null, "Vardas012", "VARDAS012.PAVARDE012012@EMAIL.COM", "VARPAV012", "AQAAAAEAACcQAAAAEPJYuJLRDk6aMnXzBc0XS3lTFh1XicC9qKT8166UnmFADq7ps43Ly2kUdcGSS6DjZA==", null, false, "e63cc12f-c3dd-4433-a677-a7c493356ec2", "C00012", "Pavarde012", false, 133055998L, "varpav012" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440011", 0, "31e3f782-39fb-43dc-91c7-4f27b9db2c8e", "Vardas011.Pavarde011011@email.com", false, "IFF-2/8", false, null, "Vardas011", "VARDAS011.PAVARDE011011@EMAIL.COM", "VARPAV011", "AQAAAAEAACcQAAAAELf4ef4Up+yKWGyZomoWFWt59tX/Hu3s/E2GHN6IvENeBsoCJPEPRKUY9lHZIJa9XA==", null, false, "fbf6c673-2e37-4823-adde-a3a567497604", "C00011", "Pavarde011", false, 115513273L, "varpav011" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440010", 0, "6477c0d8-82ef-45f0-91af-6185774db135", "Vardas010.Pavarde010010@email.com", false, "IFF-2/1", false, null, "Vardas010", "VARDAS010.PAVARDE010010@EMAIL.COM", "VARPAV010", "AQAAAAEAACcQAAAAEP6IH8kJasAPIJb9V7I4f0eErny35kNS5LU2dmetBNNzQp+2a9CwZXXITHRqvLfOOg==", null, false, "e45e14d8-7ffe-4330-90d8-46d32418c2f3", "C00010", "Pavarde010", false, 127814299L, "varpav010" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440009", 0, "aa0c659a-6456-4010-8e7c-37af66789572", "Vardas009.Pavarde009009@email.com", false, "IFF-1/6", false, null, "Vardas009", "VARDAS009.PAVARDE009009@EMAIL.COM", "VARPAV009", "AQAAAAEAACcQAAAAEEUsx20XSNZ3/9Z3ZQ0CzQlTWfL4guoLNLGC7ObAb1Mgcct+xpMDa/6TrJocFVd26Q==", null, false, "39eb44ea-0fed-40e2-92d8-195f8782cfc0", "C00009", "Pavarde009", false, 166146766L, "varpav009" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440008", 0, "565b7364-10e3-41ac-be25-79668ce7d513", "Vardas008.Pavarde008008@email.com", false, "IFF-4/5", false, null, "Vardas008", "VARDAS008.PAVARDE008008@EMAIL.COM", "VARPAV008", "AQAAAAEAACcQAAAAEGsH72xQaNBCJ9Ykfr3coI2Ir1rA+yLWib6UTAjB8aOrH2pWiAnJ2Oi2+kJgtDmL8g==", null, false, "58be19bb-c6c1-4e73-86a1-300fdcfe0617", "C00008", "Pavarde008", false, 140935096L, "varpav008" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440007", 0, "a7165c5c-0416-4eb6-9a7a-5b5300699c9c", "Vardas007.Pavarde007007@email.com", false, "IFF-2/3", false, null, "Vardas007", "VARDAS007.PAVARDE007007@EMAIL.COM", "VARPAV007", "AQAAAAEAACcQAAAAEAVxrBB6dBuvKmJqyduZR4Psoznyoup98lVk9ebEkiNbIxJnd0HUGd48brXWEIeaTQ==", null, false, "f0129bf8-1a0d-4bbf-a4c4-2001ab2259e2", "C00007", "Pavarde007", false, 127205191L, "varpav007" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440006", 0, "f0417d6e-dc35-4d8f-81d8-97c05db451d3", "Vardas006.Pavarde006006@email.com", false, "IFF-9/4", false, null, "Vardas006", "VARDAS006.PAVARDE006006@EMAIL.COM", "VARPAV006", "AQAAAAEAACcQAAAAEBmQhvqaLslox6oUGTs+fayGgQQyPHttFWRMfvCbG5Hofu9lfBxW5oSZklvn9qWSLA==", null, false, "725aaeb0-b8f3-419e-aea1-5ee108ea2c7c", "C00006", "Pavarde006", false, 102294058L, "varpav006" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440005", 0, "2b368466-addf-4546-8566-62063b7a648e", "Vardas005.Pavarde005005@email.com", false, "IFF-2/9", false, null, "Vardas005", "VARDAS005.PAVARDE005005@EMAIL.COM", "VARPAV005", "AQAAAAEAACcQAAAAEGS0tmPMJRvkZYXgEEmiCzF+C0h/9opYwuN7QTS5Nju6HZ9WqmpfWFDjhXQ7RgArcQ==", null, false, "1dd8748c-618f-4caf-96c7-38696c85e2bb", "C00005", "Pavarde005", false, 173521338L, "varpav005" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440004", 0, "153bd3c1-10bf-44e5-819d-c12b6ddd0410", "Vardas004.Pavarde004004@email.com", false, "IFF-5/8", false, null, "Vardas004", "VARDAS004.PAVARDE004004@EMAIL.COM", "VARPAV004", "AQAAAAEAACcQAAAAEKqpTyb7FdejUZaTuTA+Nw/fIzKd2eaWsnSdoIdFT3yRKA2Kn4FgETba2x+t91QWuw==", null, false, "fa987e4d-69b2-4fb5-8563-f50dc3499ccf", "C00004", "Pavarde004", false, 191453252L, "varpav004" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440003", 0, "98094fa5-239f-4159-9dce-5eca0eae5933", "Vardas003.Pavarde003003@email.com", false, "IFF-1/8", false, null, "Vardas003", "VARDAS003.PAVARDE003003@EMAIL.COM", "VARPAV003", "AQAAAAEAACcQAAAAECVCh0JfOq99AVN4y/8QwFy695C4vx4Bfxy3C8G6hBJEAFEELHhIlxhJvXw3+k3fFQ==", null, false, "257ca80e-ca25-4fe8-90d6-9cd752add03a", "C00003", "Pavarde003", false, 188441179L, "varpav003" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440002", 0, "a6e0a9d4-3d7d-4156-a8ff-cb679f7a6592", "Vardas002.Pavarde002002@email.com", false, "IFF-5/7", false, null, "Vardas002", "VARDAS002.PAVARDE002002@EMAIL.COM", "VARPAV002", "AQAAAAEAACcQAAAAEKdZMNVFs/dRx3JxL7duNYxkwc9i4Au3tir1VQQgZBd65SwZmtkUh7K5g1E1MPKBRg==", null, false, "f078ba67-e850-4587-ab97-7d62c48dfce9", "C00002", "Pavarde002", false, 108533800L, "varpav002" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440001", 0, "6293c818-09a0-4489-8636-ccc2419b664a", "Vardas001.Pavarde001001@email.com", false, "IFF-5/6", false, null, "Vardas001", "VARDAS001.PAVARDE001001@EMAIL.COM", "VARPAV001", "AQAAAAEAACcQAAAAEN8FWyWHGfVwv4wlGGpnOOOijk1fmNFRQjSv6H0oZpcolPKR3G9i7kZmzieYX0z61w==", null, false, "82eedf7e-4e47-4fc2-b7ee-a471c57b1c82", "C00001", "Pavarde001", false, 172354188L, "varpav001" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440022", 0, "8c85b1e9-b254-4f85-8446-90fd3b484230", "Vardas022.Pavarde022022@email.com", false, "IFF-7/4", false, null, "Vardas022", "VARDAS022.PAVARDE022022@EMAIL.COM", "VARPAV022", "AQAAAAEAACcQAAAAEPU7kw4VuP7VVZmWZ8ij6IYnx/fYte3i1ZXOqZk1ZCi83mR0yCYfG1iom5/pRzolow==", null, false, "67593b42-7d03-45ec-84c3-9627b9700e47", "C00022", "Pavarde022", false, 173521322L, "varpav022" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440023", 0, "642411e2-4c92-4524-90cf-97a125c93e61", "Vardas023.Pavarde023023@email.com", false, "IFF-4/3", false, null, "Vardas023", "VARDAS023.PAVARDE023023@EMAIL.COM", "VARPAV023", "AQAAAAEAACcQAAAAEGJ1bEp4DNGGtDJ2rnTkwhjFgO0qaMJ+4P3YKGfvzJTrKBIhLl+sGIoQeei7VBS4tA==", null, false, "9f2165cc-ad5e-4ac5-85f9-9ac425a1ee82", "C00023", "Pavarde023", false, 108874613L, "varpav023" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440024", 0, "6ca20e59-4182-46ae-a0d4-55f2062ebf69", "Vardas024.Pavarde024024@email.com", false, "IFF-7/6", false, null, "Vardas024", "VARDAS024.PAVARDE024024@EMAIL.COM", "VARPAV024", "AQAAAAEAACcQAAAAEEC0toPIWq5EvvGev1oiLG2nLK8+pWDbPYoLlNFresxeR1WDV/jWiJCJQHNqDO/iXw==", null, false, "9e043e1a-bc01-4b46-aa14-ee330afb0cdb", "C00024", "Pavarde024", false, 173213406L, "varpav024" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440025", 0, "8a365b91-3ec1-4dd3-9dba-7f0698a003f6", "Vardas025.Pavarde025025@email.com", false, "IFF-7/6", false, null, "Vardas025", "VARDAS025.PAVARDE025025@EMAIL.COM", "VARPAV025", "AQAAAAEAACcQAAAAEAN8XNBR2gUyDYsQqcVO/Q9E2FiSLlRNNInd6gAsaroPBhLxzFAWm9akof/RZVj08A==", null, false, "928736db-4e5e-4ab0-aa49-b0d958d2b37b", "C00025", "Pavarde025", false, 108091617L, "varpav025" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440047", 0, "25d5d3ba-51c4-44a0-b4ac-4920824f499f", "Vardas047.Pavarde047047@email.com", false, "IFF-7/7", false, null, "Vardas047", "VARDAS047.PAVARDE047047@EMAIL.COM", "VARPAV047", "AQAAAAEAACcQAAAAECVh5t9UEwDO8IPQmaYMe+3pYq4VdSOOANoBpnI/KWUUIkNrnwz5DX3OTqqqrvKShw==", null, false, "c57a2fa9-b7e4-464d-a197-e2b47439c855", "C00047", "Pavarde047", false, 152399322L, "varpav047" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440046", 0, "a77a76a9-71f0-4771-bce4-f9f74598ca81", "Vardas046.Pavarde046046@email.com", false, "IFF-9/6", false, null, "Vardas046", "VARDAS046.PAVARDE046046@EMAIL.COM", "VARPAV046", "AQAAAAEAACcQAAAAEIjHMuVhoutDV4w4d75/8um8gIX650QVvOrPWROxNWGumS1wctA3My9GYuzE+P2ecg==", null, false, "2d38bac3-0243-4475-8b29-66428d764354", "C00046", "Pavarde046", false, 108897859L, "varpav046" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440045", 0, "bc2ad89a-b90c-49f4-bc91-f2420a493654", "Vardas045.Pavarde045045@email.com", false, "IFF-8/4", false, null, "Vardas045", "VARDAS045.PAVARDE045045@EMAIL.COM", "VARPAV045", "AQAAAAEAACcQAAAAEDf59xKOkI5WQTjgJQDJfvhDVJOTeCDPxNFFn2y4dpZ6QXVT4J7iu8tFOhYbwjsGBQ==", null, false, "4a502c7b-5c53-441e-9d57-9f9d997371b1", "C00045", "Pavarde045", false, 190352498L, "varpav045" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440044", 0, "1ad61ec3-2325-410d-9b1b-13d3215e70d0", "Vardas044.Pavarde044044@email.com", false, "IFF-8/8", false, null, "Vardas044", "VARDAS044.PAVARDE044044@EMAIL.COM", "VARPAV044", "AQAAAAEAACcQAAAAEGDMAe+ahUB2ktwr1rL8v1xbRyVJUtOiJe1oPiZk+EL3DrO1wQn5/7YXo+bVk9kxSA==", null, false, "f6eab326-0a93-4b68-b1c4-bfbdc28af68b", "C00044", "Pavarde044", false, 164882305L, "varpav044" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440043", 0, "0cbab7e1-c08e-4391-a74d-d5f51d3d26e8", "Vardas043.Pavarde043043@email.com", false, "IFF-2/3", false, null, "Vardas043", "VARDAS043.PAVARDE043043@EMAIL.COM", "VARPAV043", "AQAAAAEAACcQAAAAEDzcE2XqwPjeRIA2WpPSfIeC4cigSqgrPfnF+BXqUOlPypIBa41TLfIGDt7cL7iWmw==", null, false, "5ffbbb19-2398-4cec-8b92-6b19a5c209bf", "C00043", "Pavarde043", false, 179671973L, "varpav043" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440042", 0, "99fd3660-979e-4a15-bd96-f7ba9a79d167", "Vardas042.Pavarde042042@email.com", false, "IFF-6/6", false, null, "Vardas042", "VARDAS042.PAVARDE042042@EMAIL.COM", "VARPAV042", "AQAAAAEAACcQAAAAEMJ6S4C16rgJ5Fi+t0vv6H1yJqkRjuBewR0rzH4IibQnnVmsgxRETWeU3g0xxal4ig==", null, false, "49c37af5-875a-4a5a-a958-35f41bab201c", "C00042", "Pavarde042", false, 172492011L, "varpav042" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440041", 0, "9e55ee4a-8f15-46d1-aae9-faffb0ab56e3", "Vardas041.Pavarde041041@email.com", false, "IFF-3/4", false, null, "Vardas041", "VARDAS041.PAVARDE041041@EMAIL.COM", "VARPAV041", "AQAAAAEAACcQAAAAEJjIJCskQAbE7vSCTDTpVQ+t8kEzBgghQmuNGqIy0dJN4/lSHGHHYOYWN02b+J/5jg==", null, false, "5203d520-c58b-439f-acb0-064766622fcf", "C00041", "Pavarde041", false, 168678570L, "varpav041" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440040", 0, "0853254f-96bd-46ce-8ab7-4de1afb23973", "Vardas040.Pavarde040040@email.com", false, "IFF-6/8", false, null, "Vardas040", "VARDAS040.PAVARDE040040@EMAIL.COM", "VARPAV040", "AQAAAAEAACcQAAAAEHZoGUKuYbqLNCkHgFQI5TuBRnpdCmh7kAT3O/AmvICXueAFokAF9jfJprxoXQ4bGA==", null, false, "61b82d5d-30e4-49f0-97a1-020bf7cdf552", "C00040", "Pavarde040", false, 187440141L, "varpav040" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440039", 0, "9afbc0eb-e5c6-488e-a724-8e09e715682a", "Vardas039.Pavarde039039@email.com", false, "IFF-4/1", false, null, "Vardas039", "VARDAS039.PAVARDE039039@EMAIL.COM", "VARPAV039", "AQAAAAEAACcQAAAAEObsFseaWTRo7jIAGnv89B7biPKLzdahijsPAhLboQfwVVSVTuGevWFeiOmSOq1U8A==", null, false, "cfb85ac7-284b-4455-9133-3dfd7d54947e", "C00039", "Pavarde039", false, 152463389L, "varpav039" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440038", 0, "4a71e116-75e8-4dff-bfb0-df440dd3bdec", "Vardas038.Pavarde038038@email.com", false, "IFF-3/9", false, null, "Vardas038", "VARDAS038.PAVARDE038038@EMAIL.COM", "VARPAV038", "AQAAAAEAACcQAAAAEIb7+75zljZcOhs/kcyYdthnhaZJoUrw7pmbuySJ8Jv4384TMlP9nCi3A7lARK/Xow==", null, false, "dfc8eda4-8612-4882-9b6f-3199306faeb1", "C00038", "Pavarde038", false, 184177782L, "varpav038" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440099", 0, "943bc842-4cad-478c-aea2-bc702ec61743", "Vardas099.Pavarde099099@email.com", false, "IFF-1/2", false, null, "Vardas099", "VARDAS099.PAVARDE099099@EMAIL.COM", "VARPAV099", "AQAAAAEAACcQAAAAEGqsbPYG/YYcxXzY0BKdZRYdgJqJ9e2I+aCB9G9uVK0zIK89Qq5eIPe02oh2lkOsKA==", null, false, "e8e1380c-f946-4a70-9659-d6eab883d6b0", "C00099", "Pavarde099", false, 112980808L, "varpav099" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440037", 0, "ddd67770-63b6-4e6e-a135-2648ccada525", "Vardas037.Pavarde037037@email.com", false, "IFF-2/1", false, null, "Vardas037", "VARDAS037.PAVARDE037037@EMAIL.COM", "VARPAV037", "AQAAAAEAACcQAAAAEBR0+F5wf3J1+nsnf/rqcRb8J7C7GMvz+0vZ4inRHyqfYDQ+vcfJSu1wVXgGz9PyRg==", null, false, "fd467dfc-c368-4a48-ac64-c3b724309354", "C00037", "Pavarde037", false, 135426810L, "varpav037" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440035", 0, "0ca23d41-8af0-47d5-b0a1-039802314435", "Vardas035.Pavarde035035@email.com", false, "IFF-9/5", false, null, "Vardas035", "VARDAS035.PAVARDE035035@EMAIL.COM", "VARPAV035", "AQAAAAEAACcQAAAAEM/ihzt3mfeslX+w6ECKSZ7mcIwWi60VNCmAmJlyHP+Ry2F2EUrv0tAUgsUV8TTQUA==", null, false, "32fa471e-bf9d-42e9-b128-b4b543c050b3", "C00035", "Pavarde035", false, 169314812L, "varpav035" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440034", 0, "bcb2091c-44ec-4759-9119-55ff7dbb4f1d", "Vardas034.Pavarde034034@email.com", false, "IFF-2/8", false, null, "Vardas034", "VARDAS034.PAVARDE034034@EMAIL.COM", "VARPAV034", "AQAAAAEAACcQAAAAEHVsZVqntfznHdDuYfp7WG037pPZ6fmwTLfbovGJz+YoECubiLt4yaCHmn5UT+W7uA==", null, false, "05c231ec-8aff-4d0c-8ac6-fdcd7eb48402", "C00034", "Pavarde034", false, 109208148L, "varpav034" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440033", 0, "f6d08d3e-2f51-4840-b18d-e53e37244030", "Vardas033.Pavarde033033@email.com", false, "IFF-4/4", false, null, "Vardas033", "VARDAS033.PAVARDE033033@EMAIL.COM", "VARPAV033", "AQAAAAEAACcQAAAAEC/iO5FI8zw0PekCNNs6r+ZcfABnsnDDkAUlK02dJmGbHil0m1kkPjFeKoKwoePYlA==", null, false, "d7308162-da1a-4576-92b9-41b66ff02ff0", "C00033", "Pavarde033", false, 127310128L, "varpav033" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440032", 0, "61c745db-92b5-41a2-984e-a26e868157e3", "Vardas032.Pavarde032032@email.com", false, "IFF-4/9", false, null, "Vardas032", "VARDAS032.PAVARDE032032@EMAIL.COM", "VARPAV032", "AQAAAAEAACcQAAAAEJ9bX7xv+4URA2Lzrrugl97xySE6qT/4G4QNZ1i/VFXwgW13JWX93+zIlpHJJyT2Pw==", null, false, "179334f9-ed62-4089-87c9-c952f7c5e7c7", "C00032", "Pavarde032", false, 194646040L, "varpav032" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440031", 0, "26f089dd-ef38-458e-80a6-f3144297cfeb", "Vardas031.Pavarde031031@email.com", false, "IFF-1/8", false, null, "Vardas031", "VARDAS031.PAVARDE031031@EMAIL.COM", "VARPAV031", "AQAAAAEAACcQAAAAELf8rjkxO9RDFlC3UXf/TUFn4sTve0KxpO4RR5di6MSXow8DzPp8n3lLQUOdIUM5KA==", null, false, "c184a531-4600-4abb-a4ab-7a899444a76d", "C00031", "Pavarde031", false, 111869723L, "varpav031" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440030", 0, "4a246517-a6c2-4eed-92ce-fcd2c6c29ad0", "Vardas030.Pavarde030030@email.com", false, "IFF-1/6", false, null, "Vardas030", "VARDAS030.PAVARDE030030@EMAIL.COM", "VARPAV030", "AQAAAAEAACcQAAAAEMOb1/oNIuzGSGem3vq8e2o+mCpsc4PPke6QXpS9bIALle7pvJJR9/RLNNt9jmhmZQ==", null, false, "32f75a83-bf70-46d9-b27f-c11d91968a4f", "C00030", "Pavarde030", false, 182776808L, "varpav030" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440029", 0, "cdd5dbbc-d897-48d2-8ef7-bd85acb7dd1a", "Vardas029.Pavarde029029@email.com", false, "IFF-9/7", false, null, "Vardas029", "VARDAS029.PAVARDE029029@EMAIL.COM", "VARPAV029", "AQAAAAEAACcQAAAAEEadRiqfTVmx1F8a/cBJY/1Tzj7ZwjzQIo/vnHLexvEMPRYjcp+TCm3CZMcOWFaoIA==", null, false, "2bdd120d-f04b-4b22-a724-889936fa2fa7", "C00029", "Pavarde029", false, 107038013L, "varpav029" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440028", 0, "b8b538fa-ccb2-4465-ad93-b4e9d29edd2b", "Vardas028.Pavarde028028@email.com", false, "IFF-6/9", false, null, "Vardas028", "VARDAS028.PAVARDE028028@EMAIL.COM", "VARPAV028", "AQAAAAEAACcQAAAAEJjxoXqQRsjOrV0kv3y3kbeh0m9YrXoRi1mVenUwmBX2R3Snnts0Mnu0EzgFp8EIcA==", null, false, "23267707-1461-482e-b703-eb6745c89433", "C00028", "Pavarde028", false, 164897243L, "varpav028" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440027", 0, "1d029b0d-eb52-4a30-8ba1-0c0d480c54c4", "Vardas027.Pavarde027027@email.com", false, "IFF-5/8", false, null, "Vardas027", "VARDAS027.PAVARDE027027@EMAIL.COM", "VARPAV027", "AQAAAAEAACcQAAAAEFFOZZpkgtvFiZMHMciHyrWAyji+neET/xIPJ1JlewY1+j0TyC8R2KjJ8zoq+xnC3Q==", null, false, "212fea72-4df4-4b9c-a913-d3fd78f3de6b", "C00027", "Pavarde027", false, 196346107L, "varpav027" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440026", 0, "4a190e44-4265-4d64-b130-af1c4b497132", "Vardas026.Pavarde026026@email.com", false, "IFF-3/3", false, null, "Vardas026", "VARDAS026.PAVARDE026026@EMAIL.COM", "VARPAV026", "AQAAAAEAACcQAAAAEJXZTsgYnrICQlXseN48zoFYq16f+dt4Bple1PmOzN6V7YsljjTA+R7IFW1b9TW2zQ==", null, false, "ef9fd434-3fca-4bf8-97a6-d691e557f750", "C00026", "Pavarde026", false, 115743569L, "varpav026" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440036", 0, "d1c04f8d-6503-4678-a300-d0d785db6487", "Vardas036.Pavarde036036@email.com", false, "IFF-2/7", false, null, "Vardas036", "VARDAS036.PAVARDE036036@EMAIL.COM", "VARPAV036", "AQAAAAEAACcQAAAAENw6nTONqx35MX1IM/ucpgAarOzIUFD3srQrn+YVzSQge2JkBnRcn8UiX5Vsk679Dg==", null, false, "8732aa66-b911-4792-bb06-d6f3291658bc", "C00036", "Pavarde036", false, 134912417L, "varpav036" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440100", 0, "288d5722-5bcb-4dd2-a037-4e022eb20d30", "Vardas100.Pavarde100100@email.com", false, "IFF-9/4", false, null, "Vardas100", "VARDAS100.PAVARDE100100@EMAIL.COM", "VARPAV100", "AQAAAAEAACcQAAAAEOrrdQXqS/TLxnrzP9DiInnfvJwDgcKQBQcdv4SMBS/0Kw1zMU+fGIZ8LVFweVAi4Q==", null, false, "4b3acedd-5248-4b3d-9b51-5c1902d764e6", "C00100", "Pavarde100", false, 181212222L, "varpav100" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "a18be9c0-aa65-4af8-bd17-00bd93440001", "STUDENT" },
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
                    { "a18be9c0-aa65-4af8-bd17-00bd93440053", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440074", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440052", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440075", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440077", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440098", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440097", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440096", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440095", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440094", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440093", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440092", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440091", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440090", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440089", "STUDENT" },
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
                    { "a18be9c0-aa65-4af8-bd17-00bd93440078", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440076", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440051", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440050", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440049", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440022", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440021", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440020", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440019", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440018", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440017", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440016", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440015", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440014", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440013", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440012", "STUDENT" },
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
                    { "a18be9c0-aa65-4af8-bd17-00bd93440023", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440024", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440025", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440026", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440048", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440047", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440046", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440045", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440044", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440043", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440042", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440041", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440040", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440039", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440099", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440038", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440036", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440035", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440034", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440033", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440032", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440031", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440030", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440029", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440028", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440027", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440037", "STUDENT" },
                    { "a18be9c0-aa65-4af8-bd17-00bd93440100", "STUDENT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440001", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440002", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440003", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440004", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440005", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440006", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440007", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440008", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440009", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440010", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440011", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440012", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440013", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440014", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440015", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440016", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440017", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440018", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440019", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440020", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440021", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440022", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440023", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440024", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440025", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440026", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440027", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440028", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440029", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440030", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440031", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440032", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440033", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440034", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440035", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440036", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440037", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440038", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440039", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440040", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440041", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440042", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440043", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440044", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440045", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440046", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440047", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440048", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440049", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440050", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440051", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440052", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440053", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440054", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440055", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440056", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440057", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440058", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440059", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440060", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440061", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440062", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440063", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440064", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440065", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440066", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440067", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440068", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440069", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440070", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440071", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440072", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440073", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440074", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440075", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440076", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440077", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440078", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440079", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440080", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440081", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440082", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440083", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440084", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440085", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440086", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440087", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440088", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440089", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440090", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440091", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440092", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440093", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440094", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440095", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440096", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440097", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440098", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440099", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a18be9c0-aa65-4af8-bd17-00bd93440100", "STUDENT" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440002");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440003");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440004");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440005");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440006");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440007");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440008");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440009");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440012");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440013");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440014");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440015");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440016");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440017");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440018");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440019");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440020");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440021");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440022");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440023");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440024");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440025");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440026");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440027");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440028");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440029");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440030");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440031");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440032");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440033");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440034");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440035");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440036");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440037");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440038");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440039");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440040");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440041");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440042");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440043");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440045");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440046");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440047");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440048");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440050");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440051");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440052");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440053");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440054");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440055");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440056");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440057");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440058");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440059");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440060");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440061");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440062");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440063");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440064");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440065");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440066");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440067");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440068");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440069");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440070");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440071");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440072");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440073");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440074");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440075");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440076");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440077");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440078");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440079");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440080");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440081");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440083");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440084");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440085");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440086");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440087");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440088");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440089");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440090");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440091");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440092");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440093");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440094");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440095");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440096");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440097");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440098");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440099");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd93440100");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ADMIN",
                column: "ConcurrencyStamp",
                value: "8f1ea878-efe2-4a5e-b77e-36d1c037b1f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "LECTURER",
                column: "ConcurrencyStamp",
                value: "9c55b54d-9658-4b1a-94d2-f07cfc0884f3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "STUDENT",
                column: "ConcurrencyStamp",
                value: "2f6a805b-61aa-4344-98b9-a6ce12079951");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Group", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCode", "Surname", "TwoFactorEnabled", "UID", "UserName" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", 0, "fc865da9-bd62-4a69-b582-7180e7a4c8a8", "vardenis.pavardenis@email.com", false, "IFF-6/9", false, null, "Vardenis", "VARDENIS.PAVARDENIS@EMAIL.COM", "VARVAV", "AQAAAAEAACcQAAAAEB6C1+58Xu39M0aQhRD1Kohn5rYmk4G5x2Y2iv5PoBjSl2p6W0cu6DiTMZYVe2yBKQ==", null, false, "2cbd3bfa-9b86-481d-8ffa-356f175a0560", "C0000", "Pavardenis", false, 25554654L, "varvav" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "a18be9c0-aa65-4af8-bd17-00bd9344e575", "STUDENT" });
        }
    }
}
