namespace Hangman_Game.Resources.Categories
{
    public static class WordRepository
    {
        public static Dictionary<string, List<string>> Categories { get; } = new()
        {
            {
    "Fruits", new List<string> { "APPLE", "BANANA", "CHERRY", "ORANGE", "MANGO", "DRAGONFRUIT", "PINEAPPLE", "STRAWBERRY", "WATERMELON", "BLUEBERRY", "PEACH", "GRAPEFRUIT", "KIWI" }
},
{
    "Animals", new List<string> { "ELEPHANT", "KANGAROO", "DOLPHIN", "LION", "GIRAFFE", "CROCODILE", "PENGUIN", "HIPPOPOTAMUS", "RACCOON", "ZEBRA", "CHEETAH", "ALLIGATOR", "OSTRICH" }
},
{
    "Countries", new List<string> { "CANADA", "BRAZIL", "FRANCE", "JAPAN", "EGYPT", "AUSTRALIA", "GERMANY", "MEXICO", "ITALY", "RUSSIA", "SPAIN", "INDIA", "CHINA" }
},
{
    "Sports", new List<string> { "SOCCER", "BASKETBALL", "TENNIS", "BASEBALL", "CRICKET", "VOLLEYBALL", "GOLF", "SWIMMING", "RUGBY", "HOCKEY", "BADMINTON" }
},
{
    "Colors", new List<string> { "RED", "BLUE", "GREEN", "YELLOW", "PURPLE", "ORANGE", "BLACK", "WHITE", "PINK", "BROWN", "CYAN", "MAGENTA" }
},
{
    "Movies", new List<string> { "INCEPTION", "GLADIATOR", "TITANIC", "AVATAR", "JOKER", "CASABLANCA", "ALIEN", "FROZEN", "SKYFALL", "COCO", "MATRIX" }
},
{
    "Capitals", new List<string> { "LONDON", "PARIS", "BERLIN", "ROME", "MADRID", "OTTAWA", "CANBERRA", "TOKYO", "MOSCOW", "BEIJING", "CAIRO" }
}
        };

        public static List<string> GetWordsByCategory(string category)
        {
            return Categories.TryGetValue(category, out var words) ? words : new List<string>();
        }

        public static List<string> GetCategoryNames()
        {
            return Categories.Keys.ToList();
        }
    }
}
