using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicPodcast.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DurationMs = table.Column<int>(type: "int", nullable: false),
                    Explicit = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Popularity = table.Column<int>(type: "int", nullable: false),
                    PreviewUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackNumber = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsLocal = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pathImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    ID_Album = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AlbumType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalTracks = table.Column<int>(type: "int", nullable: false),
                    AvailableMarkets = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.ID_Album);
                    table.ForeignKey(
                        name: "FK_Album_Track_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Track",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Genres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Popularity = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Artist_Track_TrackID",
                        column: x => x.TrackID,
                        principalTable: "Track",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ArtistFollower",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Href = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    ArtistID = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistFollower", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArtistFollower_Artist_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artist",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_TrackID",
                table: "Album",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_TrackID",
                table: "Artist",
                column: "TrackID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistFollower_ArtistID",
                table: "ArtistFollower",
                column: "ArtistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "ArtistFollower");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Track");
        }
    }
}
