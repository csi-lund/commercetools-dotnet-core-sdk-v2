using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetDiscountedPriceChange))]
    public partial interface ISetDiscountedPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CatalogData { get; set; }

        string Variant { get; set; }

        string PriceId { get; set; }

        IPrice PreviousValue { get; set; }

        IPrice NextValue { get; set; }
    }
}
