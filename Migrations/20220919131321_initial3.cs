using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed180cb4-0a3c-4f28-9761-9977808593a2", "AQAAAAEAACcQAAAAEE17FZtv+sKYNZ2/jRewxiSDB+dJdZg4QBAGjcs6EVCJ+i2y0Hrww7nRBfzmaS+/QA==", "6820a7e7-38aa-42b4-ae07-7d43a34f5b80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff1ef2f2-f3df-401f-88c0-7236b937393f", "AQAAAAEAACcQAAAAEK40TlqPEv+hvz80/BpiyTqNQXhHEIzchiOp2ds4ra7FzxRI+QKlxtDFv9broUuaBw==", "9b1c371d-4723-4a80-a3c4-369233c5bb28" });

            migrationBuilder.UpdateData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "The Samsung Galaxy S22 specs are top-notch including a Snapdragon 8 Gen 1 chipset, 8GB RAM coupled with 128/256GB storage, and a 3700mAh battery with 25W charging speed. The phone sports a 6.1-inch Dynamic AMOLED display with an adaptive 120Hz refresh rate.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Phone",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "he Samsung Galaxy S22 specs are top-notch including a Snapdragon 8 Gen 1 chipset, 8GB RAM coupled with 128/256GB storage, and a 3700mAh battery with 25W charging speed. The phone sports a 6.1-inch Dynamic AMOLED display with an adaptive 120Hz refresh rate.");
        }
    }
}
