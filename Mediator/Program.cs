using Mediator;

Console.WriteLine( "Mediator Behavioural Design Pattern example\n" );

Bank bank = new();

PrivateClient adam = new("Adam");
PrivateClient ben = new("Ben");
PrivateClient charlie = new("Charlie");
BusinessClient smallShop = new("A small shop on the corner");
BusinessClient insuranceCompany = new("Insurance Company");

bank.Register( adam );
bank.Register( ben );
bank.Register( charlie );
bank.Register( smallShop );
bank.Register( insuranceCompany );

smallShop.Pay( adam, 120.15m );
smallShop.Pay( ben, 240.80m );
insuranceCompany.Pay( charlie, 2000m);
charlie.Pay( adam, 314.15m);
ben.Pay( insuranceCompany, 88.45m);
