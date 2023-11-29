namespace Mediator
{
    public class Bank : IBank
    {
        private readonly Dictionary<string, BankClient> _clients = new();

        public void Register( BankClient client )
        {
            client.SetBank( this );
            if ( !_clients.ContainsKey( client.Name ) ) 
            {
                _clients.Add( client.Name, client );
            }
        }

        public void Pay( BankClient payer, BankClient receiver, decimal amount )
        {
            if ( _clients.ContainsKey( receiver.Name ) )
            {
                receiver.Receive( payer, amount );
            }
            else
            {
                Console.WriteLine( $"The receiver {receiver.Name} is not a client of this bank. Additional information is needed! ");
            }
        }

    }
}
