namespace KomicBuddy
{
    public class Manga
    {
        public Manga(string name, string link, string rank, string status, string latest)
        {
            Name = name;
            Link = link;
            Rank = rank;
            Status = string.IsNullOrEmpty(status) ? "Unknown" : status;
            Latest = latest;
        }

        public string Name { get; private set; }
        public string Link { get; private set; }
        public string Rank { get; private set; }
        public string Status { get; private set; }
        public string Latest { get; private set; }
    }
}