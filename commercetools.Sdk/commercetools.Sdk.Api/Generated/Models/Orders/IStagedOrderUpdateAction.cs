using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.Orders.StagedOrderUpdateAction))]
    [SubTypeDiscriminator("addCustomLineItem", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddCustomLineItemAction))]
    [SubTypeDiscriminator("addDelivery", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddDeliveryAction))]
    [SubTypeDiscriminator("addDiscountCode", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddDiscountCodeAction))]
    [SubTypeDiscriminator("addItemShippingAddress", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddItemShippingAddressAction))]
    [SubTypeDiscriminator("addLineItem", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddLineItemAction))]
    [SubTypeDiscriminator("addParcelToDelivery", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddParcelToDeliveryAction))]
    [SubTypeDiscriminator("addPayment", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddPaymentAction))]
    [SubTypeDiscriminator("addReturnInfo", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction))]
    [SubTypeDiscriminator("addShoppingList", typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddShoppingListAction))]
    [SubTypeDiscriminator("changeCustomLineItemMoney", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemMoneyAction))]
    [SubTypeDiscriminator("changeCustomLineItemQuantity", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeCustomLineItemQuantityAction))]
    [SubTypeDiscriminator("changeLineItemQuantity", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeLineItemQuantityAction))]
    [SubTypeDiscriminator("changeOrderState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeOrderStateAction))]
    [SubTypeDiscriminator("changePaymentState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangePaymentStateAction))]
    [SubTypeDiscriminator("changeShipmentState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeShipmentStateAction))]
    [SubTypeDiscriminator("changeTaxCalculationMode", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeTaxCalculationModeAction))]
    [SubTypeDiscriminator("changeTaxMode", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeTaxModeAction))]
    [SubTypeDiscriminator("changeTaxRoundingMode", typeof(commercetools.Api.Models.OrderEdits.StagedOrderChangeTaxRoundingModeAction))]
    [SubTypeDiscriminator("importCustomLineItemState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderImportCustomLineItemStateAction))]
    [SubTypeDiscriminator("importLineItemState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderImportLineItemStateAction))]
    [SubTypeDiscriminator("removeCustomLineItem", typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveCustomLineItemAction))]
    [SubTypeDiscriminator("removeDelivery", typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveDeliveryAction))]
    [SubTypeDiscriminator("removeDiscountCode", typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveDiscountCodeAction))]
    [SubTypeDiscriminator("removeItemShippingAddress", typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveItemShippingAddressAction))]
    [SubTypeDiscriminator("removeLineItem", typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveLineItemAction))]
    [SubTypeDiscriminator("removeParcelFromDelivery", typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemoveParcelFromDeliveryAction))]
    [SubTypeDiscriminator("removePayment", typeof(commercetools.Api.Models.OrderEdits.StagedOrderRemovePaymentAction))]
    [SubTypeDiscriminator("setBillingAddress", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetBillingAddressAction))]
    [SubTypeDiscriminator("setBillingAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setBillingAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetBillingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setCountry", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCountryAction))]
    [SubTypeDiscriminator("setCustomerEmail", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomerEmailAction))]
    [SubTypeDiscriminator("setCustomerGroup", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomerGroupAction))]
    [SubTypeDiscriminator("setCustomerId", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomerIdAction))]
    [SubTypeDiscriminator("setCustomField", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomField", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setCustomLineItemCustomType", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setCustomLineItemShippingDetails", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxAmount", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setCustomLineItemTaxRate", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomLineItemTaxRateAction))]
    [SubTypeDiscriminator("setCustomShippingMethod", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomShippingMethodAction))]
    [SubTypeDiscriminator("setCustomType", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryAddress", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomFieldAction))]
    [SubTypeDiscriminator("setDeliveryAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryAddressCustomTypeAction))]
    [SubTypeDiscriminator("setDeliveryItems", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetDeliveryItemsAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setItemShippingAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetItemShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemCustomField", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemCustomFieldAction))]
    [SubTypeDiscriminator("setLineItemCustomType", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemCustomTypeAction))]
    [SubTypeDiscriminator("setLineItemDistributionChannel", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemDistributionChannelAction))]
    [SubTypeDiscriminator("setLineItemPrice", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemPriceAction))]
    [SubTypeDiscriminator("setLineItemShippingDetails", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemShippingDetailsAction))]
    [SubTypeDiscriminator("setLineItemTaxAmount", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemTaxAmountAction))]
    [SubTypeDiscriminator("setLineItemTaxRate", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemTaxRateAction))]
    [SubTypeDiscriminator("setLineItemTotalPrice", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLineItemTotalPriceAction))]
    [SubTypeDiscriminator("setLocale", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetLocaleAction))]
    [SubTypeDiscriminator("setOrderNumber", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetOrderNumberAction))]
    [SubTypeDiscriminator("setOrderTotalTax", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetOrderTotalTaxAction))]
    [SubTypeDiscriminator("setParcelItems", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetParcelItemsAction))]
    [SubTypeDiscriminator("setParcelMeasurements", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetParcelMeasurementsAction))]
    [SubTypeDiscriminator("setParcelTrackingData", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetParcelTrackingDataAction))]
    [SubTypeDiscriminator("setReturnPaymentState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetReturnPaymentStateAction))]
    [SubTypeDiscriminator("setReturnShipmentState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetReturnShipmentStateAction))]
    [SubTypeDiscriminator("setShippingAddress", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingAddressAction))]
    [SubTypeDiscriminator("setShippingAddressAndCustomShippingMethod", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndCustomShippingMethodAction))]
    [SubTypeDiscriminator("setShippingAddressAndShippingMethod", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingAddressAndShippingMethodAction))]
    [SubTypeDiscriminator("setShippingAddressCustomField", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomFieldAction))]
    [SubTypeDiscriminator("setShippingAddressCustomType", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingAddressCustomTypeAction))]
    [SubTypeDiscriminator("setShippingMethod", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingMethodAction))]
    [SubTypeDiscriminator("setShippingMethodTaxAmount", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxAmountAction))]
    [SubTypeDiscriminator("setShippingMethodTaxRate", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingMethodTaxRateAction))]
    [SubTypeDiscriminator("setShippingRateInput", typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingRateInputAction))]
    [SubTypeDiscriminator("transitionCustomLineItemState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderTransitionCustomLineItemStateAction))]
    [SubTypeDiscriminator("transitionLineItemState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderTransitionLineItemStateAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Api.Models.OrderEdits.StagedOrderTransitionStateAction))]
    [SubTypeDiscriminator("updateItemShippingAddress", typeof(commercetools.Api.Models.OrderEdits.StagedOrderUpdateItemShippingAddressAction))]
    [SubTypeDiscriminator("updateSyncInfo", typeof(commercetools.Api.Models.OrderEdits.StagedOrderUpdateSyncInfoAction))]
    public partial interface IStagedOrderUpdateAction
    {
        string Action { get; set; }
    }
}
