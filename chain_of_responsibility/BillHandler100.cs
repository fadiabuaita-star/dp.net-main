namespace dp.net.chain_of_responsibility
{
    public class BillHandler100 : AbsBillHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 100)
            {
                System.Console.WriteLine("Give 100 X" + amount / 100);
            }

            if (amount % 100 > 0)
            {
                if (next != null)
                {
                    next.HandleRequest(amount % 100);
                }

            }
        }
    }
}