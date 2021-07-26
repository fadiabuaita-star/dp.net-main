
namespace dp.net.chain_of_responsibility
{
    public class BillHandler50 : AbsBillHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 50)
            {
                System.Console.WriteLine("Give 50 X" + amount / 50);
            }

            if (amount % 50 > 0)
            {
                if (next != null)
                {
                    next.HandleRequest(amount % 50);
                }

            }
        }
    }
}