using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labo_Netflim.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TitreLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Film",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "Annee", "ImageUrl", "Synopsis", "Titre" },
                values: new object[,]
                {
                    { 1, new DateOnly(1999, 3, 31), "/images/films/matrix.jpg", "Le hacker Neo découvre que le monde qu'il connaît est une simulation créée par des machines, et rejoint la résistance menée par Morpheus.", "Matrix" },
                    { 2, new DateOnly(2010, 7, 16), "/images/films/inception.jpg", "Dom Cobb, voleur capable de s'infiltrer dans les rêves, reçoit une mission inverse : implanter une idée dans l'esprit d'un héritier.", "Inception" },
                    { 3, new DateOnly(2014, 11, 7), "/images/films/interstellar.jpg", "Alors que la Terre se meurt, un ancien pilote rejoint une expédition qui traverse un trou de ver à la recherche d'une planète habitable.", "Interstellar" },
                    { 4, new DateOnly(1994, 10, 14), "/images/films/pulp-fiction.jpg", "Les destins de deux tueurs à gages, d'un boxeur, d'un gangster et de sa femme s'entrecroisent dans un Los Angeles violent et absurde.", "Pulp Fiction" },
                    { 5, new DateOnly(2001, 4, 25), "/images/films/amelie.jpg", "À Montmartre, une jeune serveuse timide décide de changer en secret la vie des gens qui l'entourent, au risque d'oublier la sienne.", "Le Fabuleux Destin d'Amélie Poulain" },
                    { 6, new DateOnly(2001, 7, 20), "/images/films/chihiro.jpg", "Piégée dans un monde peuplé d'esprits, la jeune Chihiro doit travailler dans un établissement de bains pour sauver ses parents changés en cochons.", "Le Voyage de Chihiro" },
                    { 7, new DateOnly(2008, 12, 12), "/images/films/gran-torino.jpg", "Un vétéran de la guerre de Corée, veuf et aigri, se lie malgré lui avec ses jeunes voisins hmongs menacés par un gang.", "Gran Torino" },
                    { 8, new DateOnly(2015, 5, 15), "/images/films/mad-max-fury-road.jpg", "Dans un désert post-apocalyptique, Max et l'impératrice Furiosa fuient le tyran Immortan Joe à bord d'un camion de guerre.", "Mad Max: Fury Road" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "Nom" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Science-fiction" },
                    { 3, "Drame" },
                    { 4, "Thriller" },
                    { 5, "Comédie" },
                    { 6, "Animation" },
                    { 7, "Aventure" },
                    { 8, "Crime" },
                    { 9, "Fantastique" },
                    { 10, "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Personne",
                columns: new[] { "PersonneId", "Nom", "Prenom" },
                values: new object[,]
                {
                    { 1, "Wachowski", "Lana" },
                    { 2, "Wachowski", "Lilly" },
                    { 3, "Reeves", "Keanu" },
                    { 4, "Fishburne", "Laurence" },
                    { 5, "Moss", "Carrie-Anne" },
                    { 6, "Nolan", "Christopher" },
                    { 7, "DiCaprio", "Leonardo" },
                    { 8, "Gordon-Levitt", "Joseph" },
                    { 9, "Page", "Elliot" },
                    { 10, "Hardy", "Tom" },
                    { 11, "McConaughey", "Matthew" },
                    { 12, "Hathaway", "Anne" },
                    { 13, "Chastain", "Jessica" },
                    { 14, "Tarantino", "Quentin" },
                    { 15, "Travolta", "John" },
                    { 16, "Jackson", "Samuel L." },
                    { 17, "Thurman", "Uma" },
                    { 18, "Willis", "Bruce" },
                    { 19, "Jeunet", "Jean-Pierre" },
                    { 20, "Tautou", "Audrey" },
                    { 21, "Kassovitz", "Mathieu" },
                    { 22, "Miyazaki", "Hayao" },
                    { 23, "Hiiragi", "Rumi" },
                    { 24, "Irino", "Miyu" },
                    { 25, "Eastwood", "Clint" },
                    { 26, "Vang", "Bee" },
                    { 27, "Miller", "George" },
                    { 28, "Theron", "Charlize" }
                });

            migrationBuilder.InsertData(
                table: "Acteur_Film",
                columns: new[] { "FilmId", "PersonneId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 4, 18 },
                    { 5, 20 },
                    { 5, 21 },
                    { 6, 23 },
                    { 6, 24 },
                    { 7, 25 },
                    { 7, 26 },
                    { 8, 10 },
                    { 8, 28 }
                });

            migrationBuilder.InsertData(
                table: "Genre_Film",
                columns: new[] { "FilmId", "GenreId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 2 },
                    { 3, 3 },
                    { 3, 7 },
                    { 4, 4 },
                    { 4, 8 },
                    { 5, 5 },
                    { 5, 10 },
                    { 6, 6 },
                    { 6, 7 },
                    { 6, 9 },
                    { 7, 3 },
                    { 7, 8 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 7 }
                });

            migrationBuilder.InsertData(
                table: "Realisateur_Film",
                columns: new[] { "FilmId", "PersonneId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 6 },
                    { 3, 6 },
                    { 4, 14 },
                    { 5, 19 },
                    { 6, 22 },
                    { 7, 25 },
                    { 8, 27 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 4, 16 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 4, 17 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 4, 18 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 5, 20 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 5, 21 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 6, 23 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 6, 24 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 7, 25 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 7, 26 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "Acteur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 8, 28 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 4, 8 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 5, 10 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 6, 7 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 6, 9 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "Genre_Film",
                keyColumns: new[] { "FilmId", "GenreId" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 5, 19 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 6, 22 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 7, 25 });

            migrationBuilder.DeleteData(
                table: "Realisateur_Film",
                keyColumns: new[] { "FilmId", "PersonneId" },
                keyValues: new object[] { 8, 27 });

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Personne",
                keyColumn: "PersonneId",
                keyValue: 28);

            migrationBuilder.AlterColumn<string>(
                name: "Titre",
                table: "Film",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
