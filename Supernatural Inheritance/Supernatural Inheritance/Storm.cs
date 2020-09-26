namespace Supernatural_Inheritance
{
    public class Storm
    {
        public Storm(string type, bool isStrong, string caster)
        {
            this.Type = type;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        public string Type { get; set; }
        public bool IsStrong { get; set; }
        public string Caster { get; set; }

    }
}