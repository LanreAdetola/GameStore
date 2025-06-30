using System;
using GameStore.frontend.Models;

namespace GameStore.frontend.Clients;

public class GamesClient
{


    private readonly List<GameSummary> games =
   [
   new () {
            Id = 1,
            Name = "Street Fighter II",
            Genre = "Fighting",
            Price = 19.99m,
            ReleaseDate = new DateOnly(1992, 7, 15)
            },
    new () {
            Id = 2,
            Name = "Super Mario World",
            Genre = "Platformer",
            Price = 29.99m,
            ReleaseDate = new DateOnly(1990, 11, 21)
            },
    new () {
            Id = 3,
            Name = "The Legend of Zelda",
            Genre = "Adventure",
            Price = 39.99m,
            ReleaseDate = new DateOnly(1991, 11, 21)
            },
    new () {
            Id = 4,
            Name = "Final Fantasy VII",
            Genre = "Role-Playing",
            Price = 49.99m,
            ReleaseDate = new DateOnly(1997, 1, 31)
            }

   ];
    
    public GameSummary[] GetGames()=> [.. games];
}
