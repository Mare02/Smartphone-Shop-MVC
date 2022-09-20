using Microsoft.EntityFrameworkCore.Migrations;

namespace Smartphone_Shop.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "239ae39d-cd95-4b0e-a245-799df01f3519",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93cbdb36-25e3-4e7b-a071-6e929ff76e07", "AQAAAAEAACcQAAAAEAKhA4N7dcL9fH1hoSfzLqbM4DKhv8zkzZ0HTqeTLHG52xSk+Hq0VmL8KLJgfnKBGg==", "d68810c3-2c97-4bd5-b98a-78963fff1c5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44a56b6a-75da-468e-96ab-69b87f29d825",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "988ae33f-c421-4e64-937f-4287366a1866", "AQAAAAEAACcQAAAAEA7nScrWyIG6zleBxnrLPCJWPfdcDyDnwFxL5r8wPvrZ4TTUQLNhXExiU5rQyoT2YQ==", "87487bd5-629a-49e4-8c93-b621835ef5fe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
