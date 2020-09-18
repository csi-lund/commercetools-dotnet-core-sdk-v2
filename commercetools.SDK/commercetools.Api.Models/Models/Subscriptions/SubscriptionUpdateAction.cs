using commercetools.Api.Models.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [Discriminator(nameof(Action))]
    public abstract class SubscriptionUpdateAction 
    {
        public string Action { get; set;}
    }
}
