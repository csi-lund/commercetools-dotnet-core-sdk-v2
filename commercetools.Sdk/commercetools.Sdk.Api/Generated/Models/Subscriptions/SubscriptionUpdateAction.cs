using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionUpdateAction : ISubscriptionUpdateAction
    {
        public string Action { get; set; }
    }
}
