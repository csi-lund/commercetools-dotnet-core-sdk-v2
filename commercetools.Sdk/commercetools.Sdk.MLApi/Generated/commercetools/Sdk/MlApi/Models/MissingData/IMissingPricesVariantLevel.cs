using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesVariantLevel))]
    [Obsolete]
    public partial interface IMissingPricesVariantLevel : IMissingPricesProductCount
    {
        new long Total { get; set; }

        new long MissingPrices { get; set; }

    }
}
