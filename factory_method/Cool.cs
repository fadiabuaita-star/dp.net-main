namespace dp.net.factory_method
{
    public class Cool : Emoji
    {
        private string glasses_color;

        public Cool(int position, string glasses_color) : base(position)
        {
            this.glasses_color = glasses_color;
        }
    }
}