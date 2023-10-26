using SendSMS.Provider.Factory.SmsProviders.Factory;
using System.Configuration;

namespace SendSMS.Provider.Factory;

public class Program
{
    static void Main(string[] args)
    {
        var smsProvider = SmsProviderFactory.Create(ConfigurationManager.AppSettings["smsProvider"]);
        Authentication.Login(smsProvider);
    }
}