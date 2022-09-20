using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cpu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Frequency = table.Column<double>(type: "float", nullable: false),
                    GraphicsChip = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NumOfCores = table.Column<int>(type: "int", nullable: false),
                    ManProcess = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisplayType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OpSystem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OpSystem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsbType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsbType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Phone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CpuId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    UsbTypeId = table.Column<int>(type: "int", nullable: false),
                    SimTypeId = table.Column<int>(type: "int", nullable: false),
                    DisplayTypeId = table.Column<int>(type: "int", nullable: false),
                    OpSystemId = table.Column<int>(type: "int", nullable: false),
                    DisplayRatio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplaySize = table.Column<double>(type: "float", nullable: false),
                    DisplayRes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Camera = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    Battery = table.Column<int>(type: "int", nullable: false),
                    Storage = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HotOffer = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Phone_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_Cpu_CpuId",
                        column: x => x.CpuId,
                        principalTable: "Cpu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_DisplayType_DisplayTypeId",
                        column: x => x.DisplayTypeId,
                        principalTable: "DisplayType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_OpSystem_OpSystemId",
                        column: x => x.OpSystemId,
                        principalTable: "OpSystem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_SimType_SimTypeId",
                        column: x => x.SimTypeId,
                        principalTable: "SimType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phone_UsbType_UsbTypeId",
                        column: x => x.UsbTypeId,
                        principalTable: "UsbType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneId = table.Column<int>(type: "int", nullable: true),
                    ItemImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ram = table.Column<int>(type: "int", nullable: false),
                    Storage = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Phone_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phone",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8ffe0bc0-1a2d-411f-8ad3-a5ba3fa5942c", "9c4cb918-9be8-41fd-bb7a-40b75aebc037", "Admin", "ADMIN" },
                    { "a6a0a663-c119-48cf-b4f6-6fb24b9d5035", "89891c77-9ac3-4e52-bf51-a15e012463f1", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "239ae39d-cd95-4b0e-a245-799df01f3519", 0, "b28331e4-1875-45b9-8917-f39cdde95cd6", "peraUser@gmail.com", false, "Petar", "Petrovic", false, null, "PERAUSER@GMAIL.COM", "PERAUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEMwOXgEwpBXy34ZQ8BCFpjR90vIqWmGswENv/VEZwPoZraPsb+ujcljy6J/f58YLcg==", null, false, "56ed19a5-6e18-4f52-83be-053785631d06", false, "peraUser@gmail.com" },
                    { "44a56b6a-75da-468e-96ab-69b87f29d825", 0, "3f23a0e4-97c1-4c46-b25a-74c6a7d1fa7b", "markoAdmin@gmail.com", false, "Marko", "Obradovic", false, null, "MARKOADMIN@GMAIL.COM", "MARKOADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKMunCiOxBRPMSJFwPU1Et+UJ7Pz6PpdlNnjAb1xP5HKpS8druwsb7OBkC/0EHwWLA==", null, false, "d91994fa-89ed-4370-9d88-2b4d2d24825c", false, "markoAdmin@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Apple" },
                    { 2, "Samsung" },
                    { 3, "Xiaomi" },
                    { 4, "Poco" },
                    { 5, "Nokia" },
                    { 6, "Alcatel" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Purple" },
                    { 5, "Red" },
                    { 4, "Blue" },
                    { 3, "Black" },
                    { 1, "White" },
                    { 2, "Gray" }
                });

            migrationBuilder.InsertData(
                table: "Cpu",
                columns: new[] { "Id", "Frequency", "GraphicsChip", "ManProcess", "ModelName", "NumOfCores" },
                values: new object[,]
                {
                    { 9, 2.2000000000000002, "Qualcomm Adreno 615", 11, "Snapdragon 678", 8 },
                    { 10, 2.3999999999999999, "Adreno 642L", 6, "Snapdragon 778 5G", 8 },
                    { 7, 1.95, "Adreno 505", 12, "Snapdragon 439", 8 },
                    { 6, 3.2000000000000002, "5-core Apple A15 GPU", 5, "Apple A15 Bionic", 4 },
                    { 5, 3.1000000000000001, "4-core Apple A14 GPU", 5, "Apple A14 Bionic", 6 },
                    { 4, 2.8999999999999999, "Adreno 640", 7, "Snapdragon 860", 8 },
                    { 3, 2.2000000000000002, "Adreno 619", 6, "Snapdragon 695 5G", 8 },
                    { 2, 2.7999999999999998, "Adreno 660", 5, "Snapdragon 888", 8 },
                    { 1, 3.0, "Adreno 730", 4, "Snapdragon 8 Gen 1", 8 },
                    { 8, 2.0, "PowerVR GE8320", 12, "Helio G25", 8 }
                });

            migrationBuilder.InsertData(
                table: "DisplayType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Super Retina" },
                    { 3, "Super Retina XDR" },
                    { 2, "LCD" },
                    { 1, "Amoled" }
                });

            migrationBuilder.InsertData(
                table: "OpSystem",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Android" },
                    { 2, "iOS" }
                });

            migrationBuilder.InsertData(
                table: "SimType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Standard" },
                    { 2, "Micro SIM" },
                    { 3, "Nano SIM" }
                });

            migrationBuilder.InsertData(
                table: "UsbType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 3, "USB Type C" },
                    { 1, "USB Type A" },
                    { 2, "USB Type B" },
                    { 4, "Lightning" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8ffe0bc0-1a2d-411f-8ad3-a5ba3fa5942c", "44a56b6a-75da-468e-96ab-69b87f29d825" },
                    { "a6a0a663-c119-48cf-b4f6-6fb24b9d5035", "239ae39d-cd95-4b0e-a245-799df01f3519" }
                });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "Battery", "BrandId", "Camera", "ColorId", "CpuId", "Description", "DisplayRatio", "DisplayRes", "DisplaySize", "DisplayTypeId", "HotOffer", "ImageUrl", "ModelName", "OpSystemId", "Price", "Ram", "ReleaseDate", "SimTypeId", "Storage", "UsbTypeId", "Weight" },
                values: new object[,]
                {
                    { 3, 3500, 6, "Back: Dual 13mpx 5mpx, Selfie: Single 8mpx", 4, 7, "Alcatel 3(2019) powerful core, Snapdragon chipset, long-lasting battery and radiant design, Alcatel 3 has both style and substance.", "19.5:9", "1560 X 720", 5.9400000000000004, 2, false, "https://www.alcatelmobile.com/eu/wp-content/uploads/2019/06/alcatel_product-details_alcatel3_black.png", "3 (2019)", 1, 160.0, 3, new DateTime(2019, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 32, 2, 145 },
                    { 1, 5500, 2, "Back: Quad 108mpx 20mpx 20mpx 16mpx, Selfie: Dual 40mpx 16mpx", 3, 4, "he Samsung Galaxy S22 specs are top-notch including a Snapdragon 8 Gen 1 chipset, 8GB RAM coupled with 128/256GB storage, and a 3700mAh battery with 25W charging speed. The phone sports a 6.1-inch Dynamic AMOLED display with an adaptive 120Hz refresh rate.", "19.5:9", "2160 X 1440", 6.0999999999999996, 1, true, "https://fscl01.fonpit.de/devices/23/2223.png", "Galaxy S22", 1, 800.0, 8, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 256, 3, 280 },
                    { 2, 5160, 4, "Back: Quad 48mpx 8mpx 2mpx 2mpx, Selfie: Single 20mpx", 2, 3, "The POCO X3 Pro specs offer powerful and versatile smartphone that is perfect for any gadget enthusiast.", "20:9", "2400 X 1800", 6.7000000000000002, 1, false, "https://cdn.homeshopping.pk/product_images/g/626/Product-Images---600x600---x3-pro-01_da6f3438-a2ce-4839-93aa-40ebed377067_grande__46137_zoom.png", "X3 Pro", 1, 250.0, 8, new DateTime(2021, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 128, 3, 280 },
                    { 4, 5050, 5, "Back: Triple 13mpx 2mpx 2mpx, Selfie: Single 8mpx", 6, 8, "Nokia G10 Android smartphone. Announced Apr 2021. Features 6.52″ display, MediaTek MT6762G Helio G25 chipset, 5050 mAh battery, 64 GB storage, 4 GB RAM.", "20:9", "1600 X 720", 6.5199999999999996, 2, false, "https://media.croma.com/image/upload/v1657894463/Croma%20Assets/Communication/Mobiles/Images/258404_9_l5jfzl.png", "G10", 1, 130.0, 3, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 32, 3, 194 },
                    { 5, 5000, 4, "Back: Quad 108mpx 64mpx 8mpx 2mpx, Selfie: Single 16mpx", 4, 3, "POCO X4 Pro 5G features a 6.67-inch 120Hz FHD+ AMOLED Display, 108MP triple camera, 67W turbocharging, and High-performance Snapdragon® 5G processor.", "20:9", "2400 X 1080", 6.6699999999999999, 1, false, "https://i01.appmifile.com/webfile/globalimg/Iris/poco-x4-pro-5g-blue!800x800!85.png", "X4 Pro 5g", 1, 280.0, 6, new DateTime(2022, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 64, 3, 205 },
                    { 6, 5000, 3, "Back: Quad 48mpx 8mpx 2mpx 2mpx, Selfie: Single 13mpx", 4, 8, "Redmi Note 10 is equipped with a new 6.43 AMOLED display,Qualcomm® Snapdragon™ 678 processor,5000mAh (typ) battery,33W fast charger.", "20:9", "2400 X 1080", 6.4299999999999997, 1, false, "https://static.ananas.rs/assets/Product_Images/Smartphones/xiaomi_redmi_note_10_16_3_cm_6_43_dve_sim_kartice_android_11_4g_usb_tipa_c_4_gb_128_gb_5000_mah_sivo/3506c52e36560108.png", "Redmi Note 10", 1, 210.0, 4, new DateTime(2021, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 64, 3, 178 },
                    { 7, 2815, 1, "Back: Dual 12mpx 12mpx, Selfie: Single 12mpx", 4, 7, "The iPhone 12 features a 6.1-inch (15 cm) display with Super Retina XDR OLED technology at a resolution of 2532 × 1170 pixels and a pixel density of about 460 ppi.", "19.5:9", "2532 X 1170", 6.0999999999999996, 3, true, "https://www.futuretelecoms.co.za/wp-content/uploads/2020/11/iPhone-12-Blue.png", "iPhone 12", 2, 700.0, 4, new DateTime(2020, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 64, 3, 164 },
                    { 8, 4500, 2, "Back: Quad 64mpx 12mpx 5mpx 5mp, Selfie: Single 32 mpx", 3, 6, "Meet the Samsung Galaxy A52s 5G with its 6.5 inch AMOLED display, multiple cameras and long - lasting battery. Plus, it's IP67 rated water & dust resistant.", "20:9", "2400 X 1080", 6.5, 1, false, "https://img.genial.ly/604b4ccbe40c2b0f76cf0feb/280fd528-970a-40ac-bba4-64b7941d1649.png", "Galaxy A52s 5G", 1, 300.0, 6, new DateTime(2021, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 128, 3, 189 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_BrandId",
                table: "Phone",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_ColorId",
                table: "Phone",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_CpuId",
                table: "Phone",
                column: "CpuId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_DisplayTypeId",
                table: "Phone",
                column: "DisplayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_OpSystemId",
                table: "Phone",
                column: "OpSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_SimTypeId",
                table: "Phone",
                column: "SimTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Phone_UsbTypeId",
                table: "Phone",
                column: "UsbTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_PhoneId",
                table: "ShoppingCartItems",
                column: "PhoneId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartId",
                table: "ShoppingCartItems",
                column: "ShoppingCartId");
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
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Cpu");

            migrationBuilder.DropTable(
                name: "DisplayType");

            migrationBuilder.DropTable(
                name: "OpSystem");

            migrationBuilder.DropTable(
                name: "SimType");

            migrationBuilder.DropTable(
                name: "UsbType");
        }
    }
}
