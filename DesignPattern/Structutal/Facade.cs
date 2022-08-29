using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structutal
{
    public class AccountService
    {
        public void GetAccout(string email)
        {
            Console.WriteLine("Getting the account of " + email);
        }
    }

    public class EmailService
    {
        public void SendMail(string mailTo)
        {
            Console.WriteLine("Sending an email to " + mailTo);
        }
    }

    public class PaymentService
    {
        public void PaymentByPaypal()
        {
            Console.WriteLine("Payment by Paypal");
        }
        public void PaymentByCreditCard()
        {
            Console.WriteLine("Payment by Credit Card");
        }
        public void PaymentByEBankingAccount()
        {
            Console.WriteLine("Payment by E-banking account");
        }
        public void PaymentByCash()
        {
            Console.WriteLine("Payment by cash");
        }
    }

    public class ShippingService
    {
        public void FreeShipping()
        {
            Console.WriteLine("Free Shipping");
        }

        public void StandardShipping()
        {
            Console.WriteLine("Standard Shipping");
        }

        public void ExpressShipping()
        {
            Console.WriteLine("Express Shipping");
        }
    }

    public class SmsService
    {
        public void sendSMS(string mobilePhone)
        {
            Console.WriteLine("Sending an message to " + mobilePhone);
        }
    }

    public class ShopFacade
    {
        private static ShopFacade _instance;

        private AccountService accountService;
        private PaymentService paymentService;
        private ShippingService shippingService;
        private EmailService emailService;
        private SmsService smsService;

        private ShopFacade()
        {
            accountService = new AccountService();
            paymentService = new PaymentService();
            shippingService = new ShippingService();
            emailService = new EmailService();
            smsService = new SmsService();
        }

        public static ShopFacade getInstance()
        {
            if (_instance == null)
                _instance = new ShopFacade();
            return _instance;
        }

        public void buyProductByCashWithFreeShipping(string email)
        {
            accountService.GetAccout(email);
            paymentService.PaymentByCash();
            shippingService.FreeShipping();
            emailService.SendMail(email);
            Console.WriteLine("Done\n");
        }

        public void buyProductByPaypalWithStandardShipping(string email, string mobilePhone)
        {
            accountService.GetAccout(email);
            paymentService.PaymentByPaypal();
            shippingService.StandardShipping();
            emailService.SendMail(email);
            smsService.sendSMS(mobilePhone);
            Console.WriteLine("Done\n");
        }
    }


}
