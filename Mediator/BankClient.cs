namespace Mediator
{
    public abstract class BankClient
    {
        private IBank? _bank;
        public string Name { get; set; }

        public BankClient( string name )
        {
            Name = name;
        }

        internal void SetBank( IBank bank ) 
        {
            _bank = bank;
        }

        public void Pay( BankClient receiver, decimal amount ) 
        {
            _bank?.Pay( this, receiver, amount );
        }

        public virtual void Receive( BankClient sender, decimal amount ) 
        {
            Console.WriteLine($"Received ${amount} from {sender.Name}");
        }
    }
}
