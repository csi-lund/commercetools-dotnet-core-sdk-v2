using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Products.FacetResult))]
    [SubTypeDiscriminator("filter", typeof(commercetools.Api.Models.Products.FilteredFacetResult))]
    [SubTypeDiscriminator("range", typeof(commercetools.Api.Models.Products.RangeFacetResult))]
    [SubTypeDiscriminator("terms", typeof(commercetools.Api.Models.Products.TermFacetResult))]
    public partial interface IFacetResult
    {
        IFacetTypes Type { get; set; }
    }
}
