namespace Mediator
{
    public class PrivateClient : BankClient
    {
        public PrivateClient( string name ) : base( name )
        {
        }

        public override void Receive( BankClient sender, decimal amount )
        {
            Console.WriteLine( $"{Name}:" );
            base.Receive( sender, amount );
        }
    }
}
