using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSelections.ProductVariantSelectionType))]
    public partial interface IProductVariantSelectionType
    {
        IProductVariantSelectionTypeEnum Type { get; set; }
    }
}
