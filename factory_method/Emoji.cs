namespace dp.net.factory_method
{
    public abstract class Emoji
    {
        public int Position { get; set; }
        public Emoji(int position)
        {
            this.Position = position;
        }
    }

}