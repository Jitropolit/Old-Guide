using System.Collections.Generic;

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
                string textIndent = $"{{0, {definition.name.Length + 5}}}";
                textBuffer += $"{string.Format(textIndent, definition.name)} — {definition.text}\n\n";
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