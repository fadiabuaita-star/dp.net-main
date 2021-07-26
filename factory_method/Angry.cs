namespace dp.net.factory_method
{
    public class Angry : Emoji
    {
        private string red_strength;

        public Angry(int position, string red_strength) : base(position)
        {
            this.red_strength = red_strength;
        }
    }
}