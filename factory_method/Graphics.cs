namespace dp.net.factory_method
{
    public class Graphics
    {
        private EmojiCreator creator;
        private Chat chat;

        public Graphics(Chat chat)
        {
            this.chat = chat;
        }

        public void UserSelectedSuprisedEmoji(int surprise_level)
        {
            creator = new SuprisedCreator(surprise_level);
        }
        public void UserSelectedAngryEmoji(string red_strength)
        {
            creator = new AngryCreator(red_strength);
        }
        public void UserSelectedCoolEmoji(string glasses_color)
        {
            creator = new CoolCreator(glasses_color);
        }

        public void UserAddEmojuToChat(int position)
        {
            if (creator == null)
            {
                return;
            }
            Emoji emoji = creator.CreateEmoji(position);
            chat.AddEmoji(emoji);
        }

    }
}