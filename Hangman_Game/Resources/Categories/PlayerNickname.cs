using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Game.Resources.Categories
{
    public class PlayerNickname
    {
        public string Nickname { get; set; } = string.Empty;
        public bool IsNicknameSet => !string.IsNullOrWhiteSpace(Nickname);

        public static bool HasShownNicknameModalStatic { get; set; } = false;
    }

}
