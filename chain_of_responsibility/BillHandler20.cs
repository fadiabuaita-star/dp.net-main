

namespace dp.net.chain_of_responsibility
{
    public class BillHandler20 : AbsBillHandler
    {
        public override void HandleRequest(int amount)
        {
            if (amount >= 20)
            {
                System.Console.WriteLine("Give 20 X" + amount / 20);
            }

            if (amount % 20 > 0)
            {
                if (next != null)
                {
                    next.HandleRequest(amount % 20);
                }
                else
                {
                    System.Console.WriteLine("Handler chant deliver!!! ");
                }

            }
        }
    }
}