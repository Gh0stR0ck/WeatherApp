using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeatherApp.Migrations
{
    /// <inheritdoc />
    public partial class dataseedWeatherdata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WeatherData",
                columns: new[] { "Id", "Cloud", "DateTime", "Humidity", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[,]
                {
                    { 1, 78, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2658), 31, 4, 212, 385 },
                    { 2, 9, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2831), 62, 20, 253, 376 },
                    { 3, 49, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2841), 1, 4, 201, 297 },
                    { 4, 88, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2851), 87, 17, 17, 59 },
                    { 5, 64, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2860), 23, 21, 319, 317 },
                    { 6, 53, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2870), 87, 9, 77, 257 },
                    { 7, 41, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2879), 17, 14, 74, 495 },
                    { 8, 13, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2891), 28, 11, 171, 180 },
                    { 9, 79, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2899), 1, 24, 292, 358 },
                    { 10, 50, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2910), 57, 34, 277, 447 },
                    { 11, 85, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2919), 97, 28, 45, 498 },
                    { 12, 0, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2928), 79, 11, 148, 374 },
                    { 13, 27, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2937), 18, 0, 175, 15 },
                    { 14, 18, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2946), 82, 1, 111, 366 },
                    { 15, 31, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2956), 8, 9, 284, 489 },
                    { 16, 84, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2964), 20, 15, 24, 499 },
                    { 17, 57, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2972), 87, 4, 347, 435 },
                    { 18, 9, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(2983), 21, 34, 102, 486 },
                    { 19, 64, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3049), 41, 20, 6, 321 },
                    { 20, 4, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3059), 23, 33, 131, 15 },
                    { 21, 65, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3071), 47, 29, 221, 178 },
                    { 22, 92, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3080), 20, 5, 281, 408 },
                    { 23, 60, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3092), 98, 23, 263, 213 },
                    { 24, 55, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3101), 82, 26, 11, 494 },
                    { 25, 88, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3110), 13, 6, 192, 399 },
                    { 26, 2, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3120), 12, 3, 170, 268 },
                    { 27, 72, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3131), 82, 26, 214, 483 },
                    { 28, 13, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3141), 47, 35, 249, 167 },
                    { 29, 19, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3150), 1, 17, 216, 339 },
                    { 30, 77, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3162), 43, 9, 21, 371 },
                    { 31, 43, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3171), 66, 0, 91, 128 },
                    { 32, 52, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3181), 76, 27, 134, 425 },
                    { 33, 68, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3192), 16, 9, 247, 498 },
                    { 34, 65, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3204), 92, 33, 23, 335 },
                    { 35, 66, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3214), 2, 28, 172, 116 },
                    { 36, 20, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3223), 41, 7, 242, 371 },
                    { 37, 15, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3232), 62, 7, 54, 128 },
                    { 38, 23, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3243), 74, 14, 3, 173 },
                    { 39, 97, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3252), 68, 2, 146, 190 },
                    { 40, 98, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3262), 19, 29, 171, 246 },
                    { 41, 31, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3273), 68, 31, 147, 141 },
                    { 42, 73, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3283), 6, 19, 265, 315 },
                    { 43, 32, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3293), 62, 24, 60, 161 },
                    { 44, 64, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3302), 50, 28, 214, 199 },
                    { 45, 24, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3313), 51, 16, 225, 455 },
                    { 46, 65, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3321), 57, 8, 38, 450 },
                    { 47, 48, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3351), 97, 0, 133, 66 },
                    { 48, 44, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3361), 73, 28, 224, 453 },
                    { 49, 9, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3370), 18, 25, 138, 279 },
                    { 50, 7, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3379), 60, 31, 118, 361 },
                    { 51, 62, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3387), 15, 12, 286, 302 },
                    { 52, 88, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3397), 14, 24, 277, 279 },
                    { 53, 46, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3407), 1, 35, 6, 476 },
                    { 54, 77, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3417), 88, 21, 9, 451 },
                    { 55, 61, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3425), 71, 36, 109, 176 },
                    { 56, 51, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3434), 23, 29, 179, 132 },
                    { 57, 1, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3444), 34, 30, 317, 242 },
                    { 58, 21, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3452), 29, 33, 352, 163 },
                    { 59, 72, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3463), 12, 6, 153, 309 },
                    { 60, 82, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3472), 51, 19, 316, 77 },
                    { 61, 27, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3481), 26, 24, 338, 446 },
                    { 62, 5, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3490), 74, 22, 33, 11 },
                    { 63, 74, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3499), 97, 32, 300, 18 },
                    { 64, 54, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3508), 74, 9, 79, 2 },
                    { 65, 81, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3519), 95, 11, 84, 426 },
                    { 66, 54, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3534), 13, 30, 121, 371 },
                    { 67, 4, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3542), 75, 37, 284, 202 },
                    { 68, 38, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3551), 35, 11, 149, 183 },
                    { 69, 15, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3562), 95, 37, 148, 411 },
                    { 70, 8, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3573), 42, 13, 189, 172 },
                    { 71, 11, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3582), 41, 26, 138, 473 },
                    { 72, 29, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3591), 17, 7, 109, 78 },
                    { 73, 4, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3628), 13, 30, 334, 216 },
                    { 74, 88, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3639), 0, 18, 106, 244 },
                    { 75, 37, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3650), 28, 15, 7, 163 },
                    { 76, 16, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3661), 2, 22, 78, 37 },
                    { 77, 16, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3672), 2, 27, 158, 271 },
                    { 78, 4, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3682), 68, 26, 244, 383 },
                    { 79, 95, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3691), 56, 14, 2, 484 },
                    { 80, 60, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3701), 16, 20, 312, 453 },
                    { 81, 47, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3711), 76, 31, 86, 459 },
                    { 82, 14, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3722), 50, 16, 151, 496 },
                    { 83, 73, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3732), 61, 11, 251, 114 },
                    { 84, 9, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3741), 16, 26, 241, 147 },
                    { 85, 18, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3751), 29, 35, 113, 288 },
                    { 86, 45, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3760), 59, 9, 350, 482 },
                    { 87, 38, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3770), 23, 35, 349, 11 },
                    { 88, 99, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3779), 36, 17, 259, 0 },
                    { 89, 45, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3788), 64, 21, 239, 175 },
                    { 90, 50, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3797), 37, 19, 55, 364 },
                    { 91, 31, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3807), 91, 23, 133, 69 },
                    { 92, 54, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3816), 64, 35, 65, 481 },
                    { 93, 0, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3829), 30, 5, 303, 440 },
                    { 94, 38, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3839), 93, 34, 98, 455 },
                    { 95, 58, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3849), 35, 8, 19, 89 },
                    { 96, 78, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3859), 18, 38, 197, 68 },
                    { 97, 62, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3868), 32, 33, 72, 71 },
                    { 98, 64, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3878), 25, 6, 19, 125 },
                    { 99, 61, new DateTime(2023, 7, 19, 22, 48, 37, 16, DateTimeKind.Local).AddTicks(3888), 74, 11, 356, 305 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "WeatherData",
                keyColumn: "Id",
                keyValue: 99);
        }
    }
}
