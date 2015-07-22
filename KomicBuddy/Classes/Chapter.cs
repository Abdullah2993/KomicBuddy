using System.Windows.Forms;

namespace KomicBuddy
{
    public class Chapter
    {
        public Chapter(string name, string scanlated, string date, string link, bool isNew)
        {
            Name = name;
            Scanlated = scanlated;
            Date = date;
            Link = link;
            IsNew = isNew;
        }

        public string Name { get; private set; }
        public string Scanlated { get; private set; }
        public string Date { get; private set; }
        public string Link { get; private set; }
        public bool IsNew { get; private set; }

        public static explicit operator ListViewItem(Chapter chapter)
        {
            var item = new ListViewItem
                {
                    Tag = chapter,
                    Text = chapter.Name + (chapter.IsNew ? "    new" : string.Empty)
                };
            item.SubItems.Add(chapter.Scanlated);
            item.SubItems.Add(chapter.Date);
            item.SubItems.Add(chapter.Link);
            return item;
        }
    }
}