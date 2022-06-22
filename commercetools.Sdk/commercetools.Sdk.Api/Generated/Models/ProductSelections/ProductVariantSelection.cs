using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    public partial class ProductVariantSelection : IProductVariantSelection
    {
        public string Type { get; set; }

        public List<string> Skus { get; set; }
    }
}
