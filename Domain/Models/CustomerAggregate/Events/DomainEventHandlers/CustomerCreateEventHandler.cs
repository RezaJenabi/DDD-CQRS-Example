﻿using Domain.Models.CustomerAggregate.Events.DomainEvents;
using eCommerce.Helpers.Domain;

namespace Domain.Models.CustomerAggregate.Events.DomainEventHandlers
{
    public class CustomerCreateEventHandler : Handles<CustomerCreateEvent>
    {
        //readonly INewsletterSubscriber newsletterSubscriber;
        //readonly IEmailDispatcher emailDispatcher;

        public CustomerCreateEventHandler()
        {
        }

        public void Handle(CustomerCreateEvent args)
        {
            //example #1 calling an interface email dispatcher this can have differnet kind of implementation depending on context, e.g
            // smtp = SmtpEmailDispatcher, exchange = ExchangeEmailDispatcher, msmq = MsmqEmailDispatcher, etc...
           
            //this.emailDispatcher.Dispatch(new MailMessage());

            //example #2 calling an interface newsletter subscriber  this can differnet kind of implementation e.g
            // web service = WSNewsletterSubscriber (current), msmq = MsmqNewsletterSubscriber, Sql = SqlNewsletterSubscriber, etc...
            
            //this.newsletterSubscriber.Subscribe(args.Customer);
        }
    }
}
