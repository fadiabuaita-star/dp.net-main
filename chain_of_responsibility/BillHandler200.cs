namespace dp.net.chain_of_responsibility
{
    public class BillHandler200 : AbsBillHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 200)
            {
                System.Console.WriteLine("Give 200 X" + amount / 200);
            }

            if (amount % 200 > 0)
            {
                if (next != null)
                {
                    next.HandleRequest(amount % 200);
                }
            }
        }
    }
}