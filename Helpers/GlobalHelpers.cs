using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wallpaper_manager.Helpers
{
    public static class GlobalHelpers
    {
        // Define ALL languages for API search
        public static Dictionary<string, string> Languages = new Dictionary<string, string>
        {
            { "Čeština", "cs" },
            { "Dansk", "da" },
            { "Deutsch", "de" },
            { "English", "en" },
            { "Español", "es" },
            { "Français", "fr" },
            { "Bahasa Indonesia", "id" },
            { "Italiano", "it" },
            { "Magyar", "hu" },
            { "Nederlands", "nl" },
            { "Norsk", "no" },
            { "Polski", "pl" },
            { "Português", "pt" },
            { "Română", "ro" },
            { "Slovenčina", "sk" },
            { "Suomi", "fi" },
            { "Svenska", "sv" },
            { "Türkçe", "tr" },
            { "Tiếng Việt", "vi" },
            { "ไทย", "th" },
            { "Български", "bg" },
            { "Русский", "ru" },
            { "Ελληνικά", "el" },
            { "日本語", "ja" },
            { "한국어", "ko" },
            { "中文", "zh" }
        };
    }
}
