using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game.Resources.Categories
{
    public class LeaderboardEntry
    {
        public string Nickname { get; set; } = string.Empty;
        public int Score { get; set; }
        public string GameMode { get; set; } = string.Empty;
        public DateTime DateAchieved { get; set; } = DateTime.Now;
    }
}
