using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class OrderImport : IOrderImport
    {
        public string OrderNumber { get; set; }

        public ICustomerKeyReference Customer { get; set; }

        public string CustomerEmail { get; set; }

        public List<ILineItemImportDraft> LineItems { get; set; }

        public List<ICustomLineItemDraft> CustomLineItems { get; set; }

        public ITypedMoney TotalPrice { get; set; }

        public ITaxedPrice TaxedPrice { get; set; }

        public IAddress ShippingAddress { get; set; }

        public IAddress BillingAddress { get; set; }

        public ICustomerGroupKeyReference CustomerGroup { get; set; }

        public string Country { get; set; }

        public IOrderState OrderState { get; set; }

        public IShipmentState ShipmentState { get; set; }

        public IPaymentState PaymentState { get; set; }

        public IShippingInfoImportDraft ShippingInfo { get; set; }

        public DateTime? CompletedAt { get; set; }

        public ICustom Custom { get; set; }

        public IInventoryMode InventoryMode { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }

        public ICartOrigin Origin { get; set; }

        public List<IAddress> ItemShippingAddresses { get; set; }
    }
}
