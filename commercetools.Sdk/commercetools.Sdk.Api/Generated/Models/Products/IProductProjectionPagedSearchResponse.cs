using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Products.ProductProjectionPagedSearchResponse))]
    public partial interface IProductProjectionPagedSearchResponse
    {
        long Limit { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        long Offset { get; set; }

        List<IProductProjection> Results { get; set; }

        IFacetResults Facets { get; set; }

    }
}
