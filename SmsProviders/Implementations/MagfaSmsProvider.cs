using SendSMS.Provider.Factory.SmsProviders.Interface;

namespace SendSMS.Provider.Factory.SmsProviders.Implementations;

internal class MagfaSmsProvider : ISmsProvider
{
    public MagfaSmsProvider(){}

    public void SendSms(string user, string message)
    {
        Console.WriteLine($"________\n> Provider: Magfa  \n> message:{message}  \n> user: {user}");
    }
}
