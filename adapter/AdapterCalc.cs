namespace dp.net.adapter
{
    public class AdapterCalc : IScientificCalc
    {

        private ISimpleCalc simpleCalc = new SimpleCalc();
        public double Add(double x, double y)
        {
            return simpleCalc.Add((int)x, (int)y);
        }

        public double Div(double x, double y)
        {
            return simpleCalc.Div((int)x, (int)y);
        }

        public double Mul(double x, double y)
        {
            return simpleCalc.Mul((int)x, (int)y);
        }

        public double Sub(double x, double y)
        {
            return simpleCalc.Sub((int)x, (int)y);
        }
    }
}