using exercise.main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace exercise.main.ReceiptPrinters
{
    public class TwilioReceiptPrinter : IReceiptPrinter
    {
        string accountSid = Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID");
        string authToken = Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN");

        public TwilioReceiptPrinter()
        {
            TwilioClient.Init(accountSid, authToken);
        }

        public async void Print(string receipt)
        {
            var message = await MessageResource.CreateAsync(
            body: receipt,
            from: new Twilio.Types.PhoneNumber("+15017122661"),
            to: new Twilio.Types.PhoneNumber("+15558675310"));
        }
    }
}
