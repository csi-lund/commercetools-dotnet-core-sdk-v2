using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPricesProductLevel))]
    [Obsolete]
    public partial interface IMissingPricesProductLevel : IMissingPricesProductCount
    {
        new long Total { get; set; }

        new long MissingPrices { get; set; }

    }
}
