
namespace dp.net.chain_of_responsibility
{
    public abstract class AbsBillHandler
    {

        protected AbsBillHandler next;

        public void SetNext(AbsBillHandler next)
        {
            this.next = next;
        }

        public abstract void HandleRequest(int amount);
    }
}