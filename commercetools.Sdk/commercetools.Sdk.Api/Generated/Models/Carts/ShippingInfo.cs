using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class ShippingInfo : IShippingInfo
    {
        public string ShippingMethodName { get; set; }

        public ITypedMoney Price { get; set; }

        public IShippingRate ShippingRate { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }

        public ITaxRate TaxRate { get; set; }

        public ITaxCategoryReference TaxCategory { get; set; }

        public IShippingMethodReference ShippingMethod { get; set; }

        public List<IDelivery> Deliveries { get; set; }

        public IDiscountedLineItemPrice DiscountedPrice { get; set; }

        public IShippingMethodState ShippingMethodState { get; set; }
    }
}
