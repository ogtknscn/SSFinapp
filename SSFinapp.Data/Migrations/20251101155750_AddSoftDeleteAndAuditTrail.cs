using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSFinapp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSoftDeleteAndAuditTrail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "StockTransactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuncelleyenKullanici",
                table: "StockTransactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "StockTransactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OlusturanKullanici",
                table: "StockTransactions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "StockTransactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuncelleyenKullanici",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OlusturanKullanici",
                table: "Products",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Products",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuncelleyenKullanici",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OlusturanKullanici",
                table: "Customers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "Customers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "GuncellemeTarihi",
                table: "CurrentAccountTransactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GuncelleyenKullanici",
                table: "CurrentAccountTransactions",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CurrentAccountTransactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "OlusturanKullanici",
                table: "CurrentAccountTransactions",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "SilinmeTarihi",
                table: "CurrentAccountTransactions",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "StockTransactions");

            migrationBuilder.DropColumn(
                name: "GuncelleyenKullanici",
                table: "StockTransactions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "StockTransactions");

            migrationBuilder.DropColumn(
                name: "OlusturanKullanici",
                table: "StockTransactions");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "StockTransactions");

            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GuncelleyenKullanici",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OlusturanKullanici",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GuncelleyenKullanici",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "OlusturanKullanici",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "GuncellemeTarihi",
                table: "CurrentAccountTransactions");

            migrationBuilder.DropColumn(
                name: "GuncelleyenKullanici",
                table: "CurrentAccountTransactions");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CurrentAccountTransactions");

            migrationBuilder.DropColumn(
                name: "OlusturanKullanici",
                table: "CurrentAccountTransactions");

            migrationBuilder.DropColumn(
                name: "SilinmeTarihi",
                table: "CurrentAccountTransactions");
        }
    }
}
