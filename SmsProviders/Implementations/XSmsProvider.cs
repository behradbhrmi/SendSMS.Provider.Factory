using SendSMS.Provider.Factory.SmsProviders.Interface;

namespace SendSMS.Provider.Factory.SmsProviders.Implementations;

internal class XSmsProvider : ISmsProvider
{
    public XSmsProvider() { }

    public void SendSms(string user, string message)
    {
        Console.WriteLine($"________\n> Provider: X \n> message:{message}  \n> user: {user}");
    }
}
