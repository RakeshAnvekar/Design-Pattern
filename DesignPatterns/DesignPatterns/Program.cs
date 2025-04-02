// See https://aka.ms/new-console-template for more information
using DesignPatterns.FactoryDesignPattern;
using DesignPatterns.SingleTonDesignPattern;
using Microsoft.Extensions.DependencyInjection;

#region for Adapter DP configuration
var serviceProvider = new ServiceCollection()
    .AddSingleton<ThirdPartyPaymentService>()
    .AddSingleton<IPaymentGateWay, PaymentAdapter>()
    .AddSingleton<Client>().BuildServiceProvider();

var client=serviceProvider.GetService<Client>();
client?.MakePayment(100);
#endregion

#region for Factory
var dataBaseConnection = DataBaseConnectionFactory.GetDataBaseConnection("sql");
dataBaseConnection.Connect();
#endregion

#region SingleTon Design Pattern
DataBaseConnection conn = DataBaseConnection.GetInstance();
conn.Connect();
#endregion