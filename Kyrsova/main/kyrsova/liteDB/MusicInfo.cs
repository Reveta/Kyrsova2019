namespace Kyrsova.main.kyrsova.liteDB
{
    public class MusicInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public bool WasCorrectExported { get; set; }

        public MusicInfo()
        {
        }

        public MusicInfo(string name, string originalName, bool wasCorrectExported)
        {
            this.Name = name;
            this.OriginalName = originalName;
            this.WasCorrectExported = wasCorrectExported;
        }

        public override string ToString()
        {
            string accept = WasCorrectExported ? "was" : "was not";
            return $"Music: {Name} -> {accept} added. OriginalName = {OriginalName}";
        }
    }
}