using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicPodcast.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlbumTrack",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumTrack", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArtistTrack",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistTrack", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistTrack",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    isOwner = table.Column<bool>(type: "bit", nullable: false),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistTrack", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserPlaylist",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlaylist", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    albumType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    albumTrackId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Album_AlbumTrack_albumTrackId",
                        column: x => x.albumTrackId,
                        principalTable: "AlbumTrack",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trackPlaylistId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    artistTrackId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    albumTrackId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Track_AlbumTrack_albumTrackId",
                        column: x => x.albumTrackId,
                        principalTable: "AlbumTrack",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Track_ArtistTrack_artistTrackId",
                        column: x => x.artistTrackId,
                        principalTable: "ArtistTrack",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Track_PlaylistTrack_trackPlaylistId",
                        column: x => x.trackPlaylistId,
                        principalTable: "PlaylistTrack",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    imgPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    playlistTrackId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    playlistUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Playlist_PlaylistTrack_playlistTrackId",
                        column: x => x.playlistTrackId,
                        principalTable: "PlaylistTrack",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Playlist_UserPlaylist_playlistUserId",
                        column: x => x.playlistUserId,
                        principalTable: "UserPlaylist",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pathImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    createAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updateOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trackId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    userPlayslistId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    artistTrackId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_ArtistTrack_artistTrackId",
                        column: x => x.artistTrackId,
                        principalTable: "ArtistTrack",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_User_Track_trackId",
                        column: x => x.trackId,
                        principalTable: "Track",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_User_UserPlaylist_userPlayslistId",
                        column: x => x.userPlayslistId,
                        principalTable: "UserPlaylist",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Track",
                columns: new[] { "ID", "albumTrackId", "artistTrackId", "createAt", "genre", "name", "trackPlaylistId", "type", "updateOn", "url" },
                values: new object[,]
                {
                    { "30e3de05-5afb-4d64-b266-a6d1574f05ad", null, null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3950), "nhạc trẻ", "Anh sẽ đưa em về", null, null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3950), "AnhSeDuaEmVe-NQP-6309479.mp3" },
                    { "f80b6678-270d-4aed-9496-b7c972da5f0b", null, null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3940), "nhạc trẻ", "Anh Đã Yên Bình Tôi Biết Thương Mình", null, null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3940), "AnhDaYenBinhToiBietThuongMinh-PhamQuynhAnh-9010380.mp3" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "artistTrackId", "createAt", "email", "password", "pathImg", "phoneNumber", "role", "trackId", "updateOn", "userName", "userPlayslistId" },
                values: new object[,]
                {
                    { "d2ae1f58-7545-4a4d-8995-b3132e323ac6", null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3850), "truong2@gmail.com", "admin2", null, null, "amdin", null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3850), "truong2", null },
                    { "ff9ead90-0b66-4bcf-be59-703aaac5dfe7", null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3810), "truong@gmail.com", "admin", null, null, "user", null, new DateTime(2023, 11, 21, 14, 50, 29, 854, DateTimeKind.Local).AddTicks(3840), "truong", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_albumTrackId",
                table: "Album",
                column: "albumTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_playlistTrackId",
                table: "Playlist",
                column: "playlistTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_playlistUserId",
                table: "Playlist",
                column: "playlistUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_albumTrackId",
                table: "Track",
                column: "albumTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_artistTrackId",
                table: "Track",
                column: "artistTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Track_trackPlaylistId",
                table: "Track",
                column: "trackPlaylistId");

            migrationBuilder.CreateIndex(
                name: "IX_User_artistTrackId",
                table: "User",
                column: "artistTrackId");

            migrationBuilder.CreateIndex(
                name: "IX_User_trackId",
                table: "User",
                column: "trackId");

            migrationBuilder.CreateIndex(
                name: "IX_User_userPlayslistId",
                table: "User",
                column: "userPlayslistId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Track");

            migrationBuilder.DropTable(
                name: "UserPlaylist");

            migrationBuilder.DropTable(
                name: "AlbumTrack");

            migrationBuilder.DropTable(
                name: "ArtistTrack");

            migrationBuilder.DropTable(
                name: "PlaylistTrack");
        }
    }
}
