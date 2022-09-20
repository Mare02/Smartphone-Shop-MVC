using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "136720df-91c1-4e86-ad6f-9d844a971f32", "AQAAAAEAACcQAAAAEMQBASj/4R0eqcIvIEZt3d6b+cqx1ShFWiH7yEJT75QyT0wGBUNyoDAzAoba5l+Ylw==", "ab3eb161-00b8-4b7d-8a52-2353dc3a8601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "564ea8da-5678-48f5-b3e9-d32afe8f15a2", "AQAAAAEAACcQAAAAECOz8LM4LtihktCre1C2FSXupf3/iLo53bK6Y4xfth+THfRDbXugarUQcGmbybBFrA==", "b995fa1a-26dd-44fe-a518-1e1b9c6bfcdf" });

            migrationBuilder.InsertData(
                table: "Phone",
                columns: new[] { "Id", "Battery", "BrandId", "Camera", "ColorId", "CpuId", "Description", "DisplayRatio", "DisplayRes", "DisplaySize", "DisplayTypeId", "HotOffer", "ImageUrl", "ModelName", "OpSystemId", "Price", "Ram", "ReleaseDate", "SimTypeId", "Storage", "UsbTypeId", "Weight" },
                values: new object[] { 9, 5500, 2, "Back: Quad 108mpx 20mpx 20mpx 16mpx, Selfie: Dual 40mpx 16mpx", 3, 4, "he Samsung Galaxy S22 specs are top-notch including a Snapdragon 8 Gen 1 chipset, 8GB RAM coupled with 128/256GB storage, and a 3700mAh battery with 25W charging speed. The phone sports a 6.1-inch Dynamic AMOLED display with an adaptive 120Hz refresh rate.", "19.5:9", "2160 X 1440", 6.0999999999999996, 1, true, "https://img.global.news.samsung.com/in/wp-content/uploads/2022/01/SM-G990_S21FE_BackFront_ZW.png", "Galaxy S21 FE", 1, 600.0, 8, new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 256, 3, 280 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b28331e4-1875-45b9-8917-f39cdde95cd6", "AQAAAAEAACcQAAAAEMwOXgEwpBXy34ZQ8BCFpjR90vIqWmGswENv/VEZwPoZraPsb+ujcljy6J/f58YLcg==", "56ed19a5-6e18-4f52-83be-053785631d06" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f23a0e4-97c1-4c46-b25a-74c6a7d1fa7b", "AQAAAAEAACcQAAAAEKMunCiOxBRPMSJFwPU1Et+UJ7Pz6PpdlNnjAb1xP5HKpS8druwsb7OBkC/0EHwWLA==", "d91994fa-89ed-4370-9d88-2b4d2d24825c" });
        }
    }
}
