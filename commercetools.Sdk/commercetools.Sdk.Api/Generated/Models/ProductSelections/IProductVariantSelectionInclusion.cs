using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionInclusion))]
    public partial interface IProductVariantSelectionInclusion : IProductVariantSelection
    {
        List<string> Skus { get; set; }
    }
}
