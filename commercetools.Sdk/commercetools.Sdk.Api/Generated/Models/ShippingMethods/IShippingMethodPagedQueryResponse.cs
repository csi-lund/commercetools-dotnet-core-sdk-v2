using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ShippingMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShippingMethods.ShippingMethodPagedQueryResponse))]
    public partial interface IShippingMethodPagedQueryResponse
    {
        long? Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long? Offset { get; set; }

        List<IShippingMethod> Results { get; set; }

    }
}
