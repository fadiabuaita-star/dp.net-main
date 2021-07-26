namespace dp.net.adapter
{
    public class SimpleCalc : ISimpleCalc
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Div(int x, int y)
        {
            return x / y;
        }

        public int Mul(int x, int y)
        {
            return x * y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}