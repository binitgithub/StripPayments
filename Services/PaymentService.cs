using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Stripe;
using Stripe.Checkout;

namespace StripPayments.Services
{
    public class PaymentService
    {
        public async Task<PaymentIntent> CreatePaymentIntentAsync(long amount, string currency = "usd")
    {
        var options = new PaymentIntentCreateOptions
        {
            Amount = amount,
            Currency = currency,
            PaymentMethodTypes = new List<string> { "card" }
        };

        var service = new PaymentIntentService();
        return await service.CreateAsync(options);
    }
    }
}