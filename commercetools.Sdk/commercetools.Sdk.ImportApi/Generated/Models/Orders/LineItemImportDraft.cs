using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Orders;
using commercetools.ImportApi.Models.Prices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class LineItemImportDraft : ILineItemImportDraft
    {
        public IProductKeyReference Product { get; set; }

        public ILocalizedString Name { get; set; }

        public ILineItemProductVariantImportDraft Variant { get; set; }

        public ILineItemPrice Price { get; set; }

        public double Quantity { get; set; }

        public List<IItemState> State { get; set; }

        public IChannelKeyReference SupplyChannel { get; set; }

        public IChannelKeyReference DistributionChannel { get; set; }

        public ITaxRate TaxRate { get; set; }

        public IItemShippingDetailsDraft ShippingDetails { get; set; }
    }
}
