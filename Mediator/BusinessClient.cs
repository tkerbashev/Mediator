namespace Mediator
{
    public class BusinessClient : BankClient
    {
        public BusinessClient( string name ) : base( name )
        {
        }

        public override void Receive( BankClient sender, decimal amount )
        {
            Console.WriteLine( $"{Name}:" );
            base.Receive( sender, amount );
        }

    }
}
