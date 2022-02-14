using System.Collections.Generic;
using System.Net;

namespace Guide.Scripts
{
    public class Article
    {
        public string heading { get; set; }
        public List<Definition> definitions { get; set; }

        public override string ToString()
        {
            string textBuffer = $"{heading}\n";
            foreach (Definition definition in definitions)
            {
                if(definition.name == "%code%")
                    try { textBuffer += $"{new WebClient().DownloadString(definition.text)}\n"; }
                    catch { textBuffer += "Ошибка подключения"; }
                else
                {
                    string textIndent = $"{{0, {definition.name.Length + 5}}}";
                    textBuffer += $"\n{string.Format(textIndent, definition.name)} — {definition.text}\n";
                }
            }
            return textBuffer;
        }

        public Article(string heading, List<Definition> definitions)
        {
            this.heading = heading;
            this.definitions = definitions;
        }
        public Article()
        {
            this.heading = this.heading;
            this.definitions = this.definitions;
        }
    }
}