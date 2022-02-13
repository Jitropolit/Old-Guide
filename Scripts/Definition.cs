namespace Guide.Scripts
{
    public class Definition
    {
        public string name { get; set; }
        public string text { get; set; }

        public Definition(string name, string text)
        {
            this.name = name;
            this.text = text;
        }
        public Definition()
        {
            this.name = this.name;
            this.text = this.text;
        }
    }
}