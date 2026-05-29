using Microsoft.EntityFrameworkCore;
using MediaCatalog.Data;
using MediaCatalog.Models;

var builder = WebApplication.CreateBuilder(args);

// Регистрируем контекст БД
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Добавляем только то, что нужно minimal APIs
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Автосоздание базы при первом запуске (для теста)
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

// =============================================
// API для MOVIES
// =============================================
var moviesGroup = app.MapGroup("/api/movies");

// GET все фильмы
moviesGroup.MapGet("/", async (AppDbContext db) =>
    await db.Movies.ToListAsync());

// GET фильм по id
moviesGroup.MapGet("/{id:int}", async (int id, AppDbContext db) =>
    await db.Movies.FindAsync(id) is Movie movie
        ? Results.Ok(movie)
        : Results.NotFound());

// POST создать фильм
moviesGroup.MapPost("/", async (Movie movie, AppDbContext db) =>
{
    db.Movies.Add(movie);
    await db.SaveChangesAsync();
    return Results.Created($"/api/movies/{movie.Id}", movie);
});

// PUT обновить фильм
moviesGroup.MapPut("/{id:int}", async (int id, Movie updatedMovie, AppDbContext db) =>
{
    var movie = await db.Movies.FindAsync(id);
    if (movie is null) return Results.NotFound();

    movie.Title = updatedMovie.Title;
    movie.Director = updatedMovie.Director;
    movie.Year = updatedMovie.Year;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

// DELETE удалить фильм
moviesGroup.MapDelete("/{id:int}", async (int id, AppDbContext db) =>
{
    var movie = await db.Movies.FindAsync(id);
    if (movie is null) return Results.NotFound();

    db.Movies.Remove(movie);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

// =============================================
// API для ALBUMS (аналогично)
// =============================================
var albumsGroup = app.MapGroup("/api/albums");

albumsGroup.MapGet("/", async (AppDbContext db) =>
    await db.Albums.ToListAsync());

albumsGroup.MapGet("/{id:int}", async (int id, AppDbContext db) =>
    await db.Albums.FindAsync(id) is Album album
        ? Results.Ok(album)
        : Results.NotFound());

albumsGroup.MapPost("/", async (Album album, AppDbContext db) =>
{
    db.Albums.Add(album);
    await db.SaveChangesAsync();
    return Results.Created($"/api/albums/{album.Id}", album);
});

albumsGroup.MapPut("/{id:int}", async (int id, Album updatedAlbum, AppDbContext db) =>
{
    var album = await db.Albums.FindAsync(id);
    if (album is null) return Results.NotFound();

    album.Title = updatedAlbum.Title;
    album.Artist = updatedAlbum.Artist;
    album.TracksCount = updatedAlbum.TracksCount;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

albumsGroup.MapDelete("/{id:int}", async (int id, AppDbContext db) =>
{
    var album = await db.Albums.FindAsync(id);
    if (album is null) return Results.NotFound();

    db.Albums.Remove(album);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

// =============================================
// API для GAMES (аналогично)
// =============================================
var gamesGroup = app.MapGroup("/api/games");

gamesGroup.MapGet("/", async (AppDbContext db) =>
    await db.Games.ToListAsync());

gamesGroup.MapGet("/{id:int}", async (int id, AppDbContext db) =>
    await db.Games.FindAsync(id) is Game game
        ? Results.Ok(game)
        : Results.NotFound());

gamesGroup.MapPost("/", async (Game game, AppDbContext db) =>
{
    db.Games.Add(game);
    await db.SaveChangesAsync();
    return Results.Created($"/api/games/{game.Id}", game);
});

gamesGroup.MapPut("/{id:int}", async (int id, Game updatedGame, AppDbContext db) =>
{
    var game = await db.Games.FindAsync(id);
    if (game is null) return Results.NotFound();

    game.Title = updatedGame.Title;
    game.Platform = updatedGame.Platform;
    game.Genre = updatedGame.Genre;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

gamesGroup.MapDelete("/{id:int}", async (int id, AppDbContext db) =>
{
    var game = await db.Games.FindAsync(id);
    if (game is null) return Results.NotFound();

    db.Games.Remove(game);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.Run();