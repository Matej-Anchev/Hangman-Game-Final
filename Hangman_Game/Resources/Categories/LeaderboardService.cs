using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hangman_Game.Resources.Categories
{
    public class LeaderboardService
    {
        private static readonly string FILEPATH = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "HangmanGame",
            "leaderboard.json"
        );

        private List<LeaderboardEntry> entries = new();
        public IReadOnlyList<LeaderboardEntry> Entries => entries.AsReadOnly();

        public async Task LoadAsync()
        {
            if (File.Exists(FILEPATH)){
                var json = await File.ReadAllTextAsync(FILEPATH);
                entries = JsonSerializer.Deserialize<List<LeaderboardEntry>>(json) ?? new List<LeaderboardEntry>();
            }
        }

        public async Task SaveAsync()
        {
            var directory = Path.GetDirectoryName(FILEPATH);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(FILEPATH, json);
        }



        public async Task AddEntryAsync(LeaderboardEntry entry)
        {
            entries.Add(entry);
            entries = entries.OrderByDescending(e => e.Score).Take(20).ToList();
            await SaveAsync();
        }
    }
}
