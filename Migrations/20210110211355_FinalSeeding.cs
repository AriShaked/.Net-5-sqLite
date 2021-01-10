using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet_rpg.Migrations
{
    public partial class FinalSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, new byte[] { 190, 145, 119, 44, 74, 70, 114, 169, 203, 18, 38, 230, 108, 143, 178, 131, 5, 124, 130, 23, 53, 71, 54, 160, 145, 7, 136, 153, 143, 232, 176, 75, 40, 40, 101, 247, 16, 32, 159, 60, 134, 187, 223, 136, 29, 243, 70, 50, 91, 21, 244, 150, 240, 242, 178, 169, 156, 116, 105, 110, 126, 172, 33, 52 }, new byte[] { 221, 10, 27, 238, 160, 110, 169, 46, 76, 145, 151, 176, 102, 23, 6, 204, 163, 170, 21, 87, 211, 106, 174, 148, 183, 78, 92, 58, 55, 52, 140, 42, 251, 88, 80, 88, 254, 148, 134, 216, 55, 179, 213, 223, 203, 186, 75, 70, 216, 151, 210, 17, 35, 12, 141, 165, 191, 242, 83, 41, 56, 18, 191, 102, 90, 8, 86, 235, 109, 74, 86, 252, 32, 226, 21, 38, 199, 110, 86, 72, 196, 228, 219, 160, 239, 112, 249, 198, 208, 106, 195, 8, 192, 183, 97, 223, 44, 204, 62, 224, 192, 56, 5, 66, 100, 230, 96, 175, 16, 252, 18, 103, 211, 18, 195, 210, 234, 150, 170, 235, 98, 110, 72, 8, 247, 171, 195, 57 }, "user1" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, new byte[] { 190, 145, 119, 44, 74, 70, 114, 169, 203, 18, 38, 230, 108, 143, 178, 131, 5, 124, 130, 23, 53, 71, 54, 160, 145, 7, 136, 153, 143, 232, 176, 75, 40, 40, 101, 247, 16, 32, 159, 60, 134, 187, 223, 136, 29, 243, 70, 50, 91, 21, 244, 150, 240, 242, 178, 169, 156, 116, 105, 110, 126, 172, 33, 52 }, new byte[] { 221, 10, 27, 238, 160, 110, 169, 46, 76, 145, 151, 176, 102, 23, 6, 204, 163, 170, 21, 87, 211, 106, 174, 148, 183, 78, 92, 58, 55, 52, 140, 42, 251, 88, 80, 88, 254, 148, 134, 216, 55, 179, 213, 223, 203, 186, 75, 70, 216, 151, 210, 17, 35, 12, 141, 165, 191, 242, 83, 41, 56, 18, 191, 102, 90, 8, 86, 235, 109, 74, 86, 252, 32, 226, 21, 38, 199, 110, 86, 72, 196, 228, 219, 160, 239, 112, 249, 198, 208, 106, 195, 8, 192, 183, 97, 223, 44, 204, 62, 224, 192, 56, 5, 66, 100, 230, 96, 175, 16, 252, 18, 103, 211, 18, 195, 210, 234, 150, 170, 235, 98, 110, 72, 8, 247, 171, 195, 57 }, "user2" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 1, 1, 0, 10, 0, 100, 10, "Frodo", 15, 1, 0 });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Class", "Defeats", "Defense", "Fights", "HitPoints", "Intelligence", "Name", "Strength", "UserId", "Victories" },
                values: new object[] { 2, 2, 0, 8, 0, 100, 20, "Raistlin", 10, 2, 0 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "CharacterSkills",
                columns: new[] { "CharacterId", "SkillId" },
                values: new object[] { 2, 3 });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 1, 1, 12, "Sword" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "CharacterId", "Damage", "Name" },
                values: new object[] { 2, 2, 9, "Knife" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CharacterSkills",
                keyColumns: new[] { "CharacterId", "SkillId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
