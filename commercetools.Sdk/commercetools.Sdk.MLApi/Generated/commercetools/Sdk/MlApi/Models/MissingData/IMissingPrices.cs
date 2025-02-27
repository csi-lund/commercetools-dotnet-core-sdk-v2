using commercetools.Sdk.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingPrices))]
    [Obsolete]
    public partial interface IMissingPrices
    {
        IProductReference Product { get; set; }

        long VariantId { get; set; }

    }
}
