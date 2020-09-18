using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [Discriminator(nameof(Action))]
    public abstract class MyShoppingListUpdateAction 
    {
        public string Action { get; set;}
    }
}
