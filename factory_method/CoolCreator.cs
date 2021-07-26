namespace dp.net.factory_method
{
    public class CoolCreator : EmojiCreator
    {
        private string glasses_color;

        public CoolCreator(string glasses_color)
        {
            this.glasses_color = glasses_color;
        }

        public override Emoji CreateEmoji(int position)
        {
            return new Cool(position, this.glasses_color);
        }
    }
}