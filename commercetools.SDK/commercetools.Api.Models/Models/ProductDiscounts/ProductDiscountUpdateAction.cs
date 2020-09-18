using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [Discriminator(nameof(Action))]
    public abstract class ProductDiscountUpdateAction 
    {
        public string Action { get; set;}
    }
}
