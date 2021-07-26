namespace dp.net.factory_method
{
    public class SuprisedCreator : EmojiCreator
    {
        private int suprised_level;

        public SuprisedCreator(int suprised_level)
        {
            this.suprised_level = suprised_level;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new Suprised(position, this.suprised_level);
        }
    }
}