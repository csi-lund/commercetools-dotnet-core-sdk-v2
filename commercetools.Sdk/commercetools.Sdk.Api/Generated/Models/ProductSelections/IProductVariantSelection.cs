using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelection))]
    public partial interface IProductVariantSelection
    {
        string Type { get; set; }

        List<string> Skus { get; set; }
    }
}
