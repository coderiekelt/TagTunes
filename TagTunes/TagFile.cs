namespace TagTunes
{
    public class TagFile
    {
        public TagMeta TagMeta;

        public string Location;

        public override string ToString()
        {
            if (TagMeta == null)
            {
                return "Unknown";
            }

            return TagMeta.Name + " - " + TagMeta.Artist;
        }
    }
}
