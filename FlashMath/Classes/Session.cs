using FlashMath.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System.Security.Principal;

namespace FlashMath.Classes
{
    public class userSession
    {
        public IPrincipal user;
        public gameDificulty difficulty { get; set; }
        public List<Game> Games;

        public userSession()
        {
            this.user = HttpContext.Current.User;
        }

        public void addGame(Game game)
        {
            this.Games.Add(game);
        }

        public void setGameDifficulty(gameDificulty difficulty)
        {
            this.difficulty = difficulty;
        }

        public Game getCurrentGame()
        {
            return this.Games.LastOrDefault();
        }

    }
}