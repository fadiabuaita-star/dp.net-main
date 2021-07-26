namespace dp.net.factory_method
{
    public class Suprised : Emoji
    {
        private int suprised_level;

        public Suprised(int position, int suprised_level): base(position)
        {
            this.suprised_level = suprised_level;
        }
    }
}