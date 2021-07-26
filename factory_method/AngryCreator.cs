namespace dp.net.factory_method
{
    public class AngryCreator : EmojiCreator
    {
        private string red_strength;

        public AngryCreator(string red_strength)
        {
            this.red_strength = red_strength;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new Angry(position, this.red_strength);
        }
    }
}