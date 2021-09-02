using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.HistoryApi.Models.Changes.ChangeModel))]
    [SubTypeDiscriminator("AddAddressChange", typeof(commercetools.HistoryApi.Models.Changes.AddAddressChange))]
    [SubTypeDiscriminator("AddAssetChange", typeof(commercetools.HistoryApi.Models.Changes.AddAssetChange))]
    [SubTypeDiscriminator("AddAttributeDefinitionChange", typeof(commercetools.HistoryApi.Models.Changes.AddAttributeDefinitionChange))]
    [SubTypeDiscriminator("AddBillingAddressIdChange", typeof(commercetools.HistoryApi.Models.Changes.AddBillingAddressIdChange))]
    [SubTypeDiscriminator("AddChannelRolesChange", typeof(commercetools.HistoryApi.Models.Changes.AddChannelRolesChange))]
    [SubTypeDiscriminator("AddCustomLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.AddCustomLineItemChange))]
    [SubTypeDiscriminator("AddDeliveryChange", typeof(commercetools.HistoryApi.Models.Changes.AddDeliveryChange))]
    [SubTypeDiscriminator("AddDiscountCodeChange", typeof(commercetools.HistoryApi.Models.Changes.AddDiscountCodeChange))]
    [SubTypeDiscriminator("AddEnumValueChange", typeof(commercetools.HistoryApi.Models.Changes.AddEnumValueChange))]
    [SubTypeDiscriminator("AddExternalImageChange", typeof(commercetools.HistoryApi.Models.Changes.AddExternalImageChange))]
    [SubTypeDiscriminator("AddFieldDefinitionChange", typeof(commercetools.HistoryApi.Models.Changes.AddFieldDefinitionChange))]
    [SubTypeDiscriminator("AddInterfaceInteractionChange", typeof(commercetools.HistoryApi.Models.Changes.AddInterfaceInteractionChange))]
    [SubTypeDiscriminator("AddItemShippingAddressesChange", typeof(commercetools.HistoryApi.Models.Changes.AddItemShippingAddressesChange))]
    [SubTypeDiscriminator("AddLocalizedEnumValueChange", typeof(commercetools.HistoryApi.Models.Changes.AddLocalizedEnumValueChange))]
    [SubTypeDiscriminator("AddLocationChange", typeof(commercetools.HistoryApi.Models.Changes.AddLocationChange))]
    [SubTypeDiscriminator("AddOrderLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.AddOrderLineItemChange))]
    [SubTypeDiscriminator("AddParcelToDeliveryChange", typeof(commercetools.HistoryApi.Models.Changes.AddParcelToDeliveryChange))]
    [SubTypeDiscriminator("AddPaymentChange", typeof(commercetools.HistoryApi.Models.Changes.AddPaymentChange))]
    [SubTypeDiscriminator("AddPlainEnumValueChange", typeof(commercetools.HistoryApi.Models.Changes.AddPlainEnumValueChange))]
    [SubTypeDiscriminator("AddPriceChange", typeof(commercetools.HistoryApi.Models.Changes.AddPriceChange))]
    [SubTypeDiscriminator("AddReturnInfoChange", typeof(commercetools.HistoryApi.Models.Changes.AddReturnInfoChange))]
    [SubTypeDiscriminator("AddShippingAddressIdChange", typeof(commercetools.HistoryApi.Models.Changes.AddShippingAddressIdChange))]
    [SubTypeDiscriminator("AddShoppingListLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.AddShoppingListLineItemChange))]
    [SubTypeDiscriminator("AddStateRolesChange", typeof(commercetools.HistoryApi.Models.Changes.AddStateRolesChange))]
    [SubTypeDiscriminator("AddTaxRateChange", typeof(commercetools.HistoryApi.Models.Changes.AddTaxRateChange))]
    [SubTypeDiscriminator("AddTextLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.AddTextLineItemChange))]
    [SubTypeDiscriminator("AddToCategoryChange", typeof(commercetools.HistoryApi.Models.Changes.AddToCategoryChange))]
    [SubTypeDiscriminator("AddTransactionChange", typeof(commercetools.HistoryApi.Models.Changes.AddTransactionChange))]
    [SubTypeDiscriminator("AddVariantChange", typeof(commercetools.HistoryApi.Models.Changes.AddVariantChange))]
    [SubTypeDiscriminator("ChangeAddressChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeAddressChange))]
    [SubTypeDiscriminator("ChangeAmountAuthorizedChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeAmountAuthorizedChange))]
    [SubTypeDiscriminator("ChangeAmountPlannedChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeAmountPlannedChange))]
    [SubTypeDiscriminator("ChangeAssetNameChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeAssetNameChange))]
    [SubTypeDiscriminator("ChangeAssetOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeAssetOrderChange))]
    [SubTypeDiscriminator("ChangeAttributeConstraintChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeAttributeConstraintChange))]
    [SubTypeDiscriminator("ChangeAttributeOrderByNameChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeAttributeOrderByNameChange))]
    [SubTypeDiscriminator("ChangeCartDiscountsChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeCartDiscountsChange))]
    [SubTypeDiscriminator("ChangeCartPredicateChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeCartPredicateChange))]
    [SubTypeDiscriminator("ChangeCustomLineItemQuantityChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeCustomLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeDescriptionChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeDescriptionChange))]
    [SubTypeDiscriminator("ChangeEmailChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeEmailChange))]
    [SubTypeDiscriminator("ChangeEnumValueLabelChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeEnumValueLabelChange))]
    [SubTypeDiscriminator("ChangeEnumValueOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeEnumValueOrderChange))]
    [SubTypeDiscriminator("ChangeFieldDefinitionOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeFieldDefinitionOrderChange))]
    [SubTypeDiscriminator("ChangeGroupsChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeGroupsChange))]
    [SubTypeDiscriminator("ChangeInitialChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeInitialChange))]
    [SubTypeDiscriminator("ChangeInputHintChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeInputHintChange))]
    [SubTypeDiscriminator("ChangeIsActiveChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeIsActiveChange))]
    [SubTypeDiscriminator("ChangeIsSearchableChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeIsSearchableChange))]
    [SubTypeDiscriminator("ChangeKeyChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeKeyChange))]
    [SubTypeDiscriminator("ChangeLabelChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeLabelChange))]
    [SubTypeDiscriminator("ChangeLineItemQuantityChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeLocalizedDescriptionChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeLocalizedDescriptionChange))]
    [SubTypeDiscriminator("ChangeLocalizedEnumValueLabelChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeLocalizedEnumValueLabelChange))]
    [SubTypeDiscriminator("ChangeLocalizedEnumValueOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeLocalizedEnumValueOrderChange))]
    [SubTypeDiscriminator("ChangeLocalizedNameChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeLocalizedNameChange))]
    [SubTypeDiscriminator("ChangeMasterVariantChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeMasterVariantChange))]
    [SubTypeDiscriminator("ChangeNameChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeNameChange))]
    [SubTypeDiscriminator("ChangeOrderHintChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeOrderHintChange))]
    [SubTypeDiscriminator("ChangeOrderStateChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeOrderStateChange))]
    [SubTypeDiscriminator("ChangeParentChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeParentChange))]
    [SubTypeDiscriminator("ChangePaymentStateChange", typeof(commercetools.HistoryApi.Models.Changes.ChangePaymentStateChange))]
    [SubTypeDiscriminator("ChangePlainEnumValueLabelChange", typeof(commercetools.HistoryApi.Models.Changes.ChangePlainEnumValueLabelChange))]
    [SubTypeDiscriminator("ChangePlainEnumValueOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangePlainEnumValueOrderChange))]
    [SubTypeDiscriminator("ChangePredicateChange", typeof(commercetools.HistoryApi.Models.Changes.ChangePredicateChange))]
    [SubTypeDiscriminator("ChangePriceChange", typeof(commercetools.HistoryApi.Models.Changes.ChangePriceChange))]
    [SubTypeDiscriminator("ChangeQuantityChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeQuantityChange))]
    [SubTypeDiscriminator("ChangeRequiresDiscountCodeChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeRequiresDiscountCodeChange))]
    [SubTypeDiscriminator("ChangeReviewRatingStatisticsChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeReviewRatingStatisticsChange))]
    [SubTypeDiscriminator("ChangeShipmentStateChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeShipmentStateChange))]
    [SubTypeDiscriminator("ChangeShoppingListLineItemQuantityChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeShoppingListLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeShoppingListLineItemsOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeShoppingListLineItemsOrderChange))]
    [SubTypeDiscriminator("ChangeSlugChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeSlugChange))]
    [SubTypeDiscriminator("ChangeSortOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeSortOrderChange))]
    [SubTypeDiscriminator("ChangeStackingModeChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeStackingModeChange))]
    [SubTypeDiscriminator("ChangeStateTypeChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeStateTypeChange))]
    [SubTypeDiscriminator("ChangeTargetChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTargetChange))]
    [SubTypeDiscriminator("ChangeTaxCalculationModeChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTaxCalculationModeChange))]
    [SubTypeDiscriminator("ChangeTaxModeChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTaxModeChange))]
    [SubTypeDiscriminator("ChangeTaxRoundingModeChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTaxRoundingModeChange))]
    [SubTypeDiscriminator("ChangeTextLineItemNameChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTextLineItemNameChange))]
    [SubTypeDiscriminator("ChangeTextLineItemQuantityChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTextLineItemQuantityChange))]
    [SubTypeDiscriminator("ChangeTextLineItemsOrderChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTextLineItemsOrderChange))]
    [SubTypeDiscriminator("ChangeTransactionInteractionIdChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTransactionInteractionIdChange))]
    [SubTypeDiscriminator("ChangeTransactionStateChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTransactionStateChange))]
    [SubTypeDiscriminator("ChangeTransactionTimestampChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeTransactionTimestampChange))]
    [SubTypeDiscriminator("ChangeValueChange", typeof(commercetools.HistoryApi.Models.Changes.ChangeValueChange))]
    [SubTypeDiscriminator("MoveImageToPositionChange", typeof(commercetools.HistoryApi.Models.Changes.MoveImageToPositionChange))]
    [SubTypeDiscriminator("PublishChange", typeof(commercetools.HistoryApi.Models.Changes.PublishChange))]
    [SubTypeDiscriminator("RemoveAddressChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveAddressChange))]
    [SubTypeDiscriminator("RemoveAssetChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveAssetChange))]
    [SubTypeDiscriminator("RemoveAttributeDefinitionChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveAttributeDefinitionChange))]
    [SubTypeDiscriminator("RemoveBillingAddressIdChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveBillingAddressIdChange))]
    [SubTypeDiscriminator("RemoveChannelRolesChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveChannelRolesChange))]
    [SubTypeDiscriminator("RemoveCustomLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveCustomLineItemChange))]
    [SubTypeDiscriminator("RemoveDeliveryItemsChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveDeliveryItemsChange))]
    [SubTypeDiscriminator("RemoveDiscountCodeChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveDiscountCodeChange))]
    [SubTypeDiscriminator("RemoveEnumValuesChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveEnumValuesChange))]
    [SubTypeDiscriminator("RemoveFieldDefinitionChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveFieldDefinitionChange))]
    [SubTypeDiscriminator("RemoveFromCategoryChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveFromCategoryChange))]
    [SubTypeDiscriminator("RemoveImageChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveImageChange))]
    [SubTypeDiscriminator("RemoveItemShippingAddressesChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveItemShippingAddressesChange))]
    [SubTypeDiscriminator("RemoveLocalizedEnumValuesChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveLocalizedEnumValuesChange))]
    [SubTypeDiscriminator("RemoveLocationChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveLocationChange))]
    [SubTypeDiscriminator("RemoveOrderLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveOrderLineItemChange))]
    [SubTypeDiscriminator("RemoveParcelFromDeliveryChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveParcelFromDeliveryChange))]
    [SubTypeDiscriminator("RemovePaymentChange", typeof(commercetools.HistoryApi.Models.Changes.RemovePaymentChange))]
    [SubTypeDiscriminator("RemovePriceChange", typeof(commercetools.HistoryApi.Models.Changes.RemovePriceChange))]
    [SubTypeDiscriminator("RemoveShippingAddressIdChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveShippingAddressIdChange))]
    [SubTypeDiscriminator("RemoveShoppingListLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveShoppingListLineItemChange))]
    [SubTypeDiscriminator("RemoveStateRolesChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveStateRolesChange))]
    [SubTypeDiscriminator("RemoveTaxRateChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveTaxRateChange))]
    [SubTypeDiscriminator("RemoveTextLineItemChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveTextLineItemChange))]
    [SubTypeDiscriminator("RemoveVariantChange", typeof(commercetools.HistoryApi.Models.Changes.RemoveVariantChange))]
    [SubTypeDiscriminator("SetAddressChange", typeof(commercetools.HistoryApi.Models.Changes.SetAddressChange))]
    [SubTypeDiscriminator("SetAnonymousIdChange", typeof(commercetools.HistoryApi.Models.Changes.SetAnonymousIdChange))]
    [SubTypeDiscriminator("SetApplicationVersionChange", typeof(commercetools.HistoryApi.Models.Changes.SetApplicationVersionChange))]
    [SubTypeDiscriminator("SetAssetCustomFieldChange", typeof(commercetools.HistoryApi.Models.Changes.SetAssetCustomFieldChange))]
    [SubTypeDiscriminator("SetAssetCustomTypeChange", typeof(commercetools.HistoryApi.Models.Changes.SetAssetCustomTypeChange))]
    [SubTypeDiscriminator("SetAssetDescriptionChange", typeof(commercetools.HistoryApi.Models.Changes.SetAssetDescriptionChange))]
    [SubTypeDiscriminator("SetAssetKeyChange", typeof(commercetools.HistoryApi.Models.Changes.SetAssetKeyChange))]
    [SubTypeDiscriminator("SetAssetSourcesChange", typeof(commercetools.HistoryApi.Models.Changes.SetAssetSourcesChange))]
    [SubTypeDiscriminator("SetAssetTagsChange", typeof(commercetools.HistoryApi.Models.Changes.SetAssetTagsChange))]
    [SubTypeDiscriminator("SetAttributeChange", typeof(commercetools.HistoryApi.Models.Changes.SetAttributeChange))]
    [SubTypeDiscriminator("SetAuthorNameChange", typeof(commercetools.HistoryApi.Models.Changes.SetAuthorNameChange))]
    [SubTypeDiscriminator("SetBillingAddressChange", typeof(commercetools.HistoryApi.Models.Changes.SetBillingAddressChange))]
    [SubTypeDiscriminator("SetCartPredicateChange", typeof(commercetools.HistoryApi.Models.Changes.SetCartPredicateChange))]
    [SubTypeDiscriminator("SetCategoryOrderHintChange", typeof(commercetools.HistoryApi.Models.Changes.SetCategoryOrderHintChange))]
    [SubTypeDiscriminator("SetChannelRolesChange", typeof(commercetools.HistoryApi.Models.Changes.SetChannelRolesChange))]
    [SubTypeDiscriminator("SetCompanyNameChange", typeof(commercetools.HistoryApi.Models.Changes.SetCompanyNameChange))]
    [SubTypeDiscriminator("SetCountryChange", typeof(commercetools.HistoryApi.Models.Changes.SetCountryChange))]
    [SubTypeDiscriminator("SetCustomerChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomerChange))]
    [SubTypeDiscriminator("SetCustomerEmailChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomerEmailChange))]
    [SubTypeDiscriminator("SetCustomerGroupChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomerGroupChange))]
    [SubTypeDiscriminator("SetCustomerIdChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomerIdChange))]
    [SubTypeDiscriminator("SetCustomerNumberChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomerNumberChange))]
    [SubTypeDiscriminator("SetCustomFieldChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomFieldChange))]
    [SubTypeDiscriminator("SetCustomLineItemCustomFieldChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetCustomLineItemCustomTypeChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetCustomLineItemMoneyChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemMoneyChange))]
    [SubTypeDiscriminator("SetCustomLineItemShippingDetailsChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemShippingDetailsChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxAmountChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemTaxAmountChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxCategoryChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemTaxCategoryChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxedPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemTaxedPriceChange))]
    [SubTypeDiscriminator("SetCustomLineItemTaxRateChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemTaxRateChange))]
    [SubTypeDiscriminator("SetCustomLineItemTotalPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemTotalPriceChange))]
    [SubTypeDiscriminator("SetCustomShippingMethodChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomShippingMethodChange))]
    [SubTypeDiscriminator("SetCustomTypeChange", typeof(commercetools.HistoryApi.Models.Changes.SetCustomTypeChange))]
    [SubTypeDiscriminator("SetDateOfBirthChange", typeof(commercetools.HistoryApi.Models.Changes.SetDateOfBirthChange))]
    [SubTypeDiscriminator("SetDefaultBillingAddressChange", typeof(commercetools.HistoryApi.Models.Changes.SetDefaultBillingAddressChange))]
    [SubTypeDiscriminator("SetDefaultShippingAddressChange", typeof(commercetools.HistoryApi.Models.Changes.SetDefaultShippingAddressChange))]
    [SubTypeDiscriminator("SetDeleteDaysAfterLastModificationChange", typeof(commercetools.HistoryApi.Models.Changes.SetDeleteDaysAfterLastModificationChange))]
    [SubTypeDiscriminator("SetDeliveryAddressChange", typeof(commercetools.HistoryApi.Models.Changes.SetDeliveryAddressChange))]
    [SubTypeDiscriminator("SetDeliveryItemsChange", typeof(commercetools.HistoryApi.Models.Changes.SetDeliveryItemsChange))]
    [SubTypeDiscriminator("SetDescriptionChange", typeof(commercetools.HistoryApi.Models.Changes.SetDescriptionChange))]
    [SubTypeDiscriminator("SetDiscountedPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetDiscountedPriceChange))]
    [SubTypeDiscriminator("SetDistributionChannelsChange", typeof(commercetools.HistoryApi.Models.Changes.SetDistributionChannelsChange))]
    [SubTypeDiscriminator("SetExpectedDeliveryChange", typeof(commercetools.HistoryApi.Models.Changes.SetExpectedDeliveryChange))]
    [SubTypeDiscriminator("SetExternalIdChange", typeof(commercetools.HistoryApi.Models.Changes.SetExternalIdChange))]
    [SubTypeDiscriminator("SetFirstNameChange", typeof(commercetools.HistoryApi.Models.Changes.SetFirstNameChange))]
    [SubTypeDiscriminator("SetGeoLocationChange", typeof(commercetools.HistoryApi.Models.Changes.SetGeoLocationChange))]
    [SubTypeDiscriminator("SetImageLabelChange", typeof(commercetools.HistoryApi.Models.Changes.SetImageLabelChange))]
    [SubTypeDiscriminator("SetInputTipChange", typeof(commercetools.HistoryApi.Models.Changes.SetInputTipChange))]
    [SubTypeDiscriminator("SetInterfaceIdChange", typeof(commercetools.HistoryApi.Models.Changes.SetInterfaceIdChange))]
    [SubTypeDiscriminator("SetIsValidChange", typeof(commercetools.HistoryApi.Models.Changes.SetIsValidChange))]
    [SubTypeDiscriminator("SetKeyChange", typeof(commercetools.HistoryApi.Models.Changes.SetKeyChange))]
    [SubTypeDiscriminator("SetLanguagesChange", typeof(commercetools.HistoryApi.Models.Changes.SetLanguagesChange))]
    [SubTypeDiscriminator("SetLastNameChange", typeof(commercetools.HistoryApi.Models.Changes.SetLastNameChange))]
    [SubTypeDiscriminator("SetLineItemDiscountedPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemDiscountedPriceChange))]
    [SubTypeDiscriminator("SetLineItemDiscountedPricePerQuantityChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemDiscountedPricePerQuantityChange))]
    [SubTypeDiscriminator("SetLineItemDistributionChannelChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemDistributionChannelChange))]
    [SubTypeDiscriminator("SetLineItemPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemPriceChange))]
    [SubTypeDiscriminator("SetLineItemProductSlugChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemProductSlugChange))]
    [SubTypeDiscriminator("SetLineItemShippingDetailsChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemShippingDetailsChange))]
    [SubTypeDiscriminator("SetLineItemTaxAmountChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemTaxAmountChange))]
    [SubTypeDiscriminator("SetLineItemTaxedPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemTaxedPriceChange))]
    [SubTypeDiscriminator("SetLineItemTaxRateChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemTaxRateChange))]
    [SubTypeDiscriminator("SetLineItemTotalPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetLineItemTotalPriceChange))]
    [SubTypeDiscriminator("SetLocaleChange", typeof(commercetools.HistoryApi.Models.Changes.SetLocaleChange))]
    [SubTypeDiscriminator("SetLocalizedDescriptionChange", typeof(commercetools.HistoryApi.Models.Changes.SetLocalizedDescriptionChange))]
    [SubTypeDiscriminator("SetMaxApplicationsChange", typeof(commercetools.HistoryApi.Models.Changes.SetMaxApplicationsChange))]
    [SubTypeDiscriminator("SetMaxApplicationsPerCustomerChange", typeof(commercetools.HistoryApi.Models.Changes.SetMaxApplicationsPerCustomerChange))]
    [SubTypeDiscriminator("SetMetaDescriptionChange", typeof(commercetools.HistoryApi.Models.Changes.SetMetaDescriptionChange))]
    [SubTypeDiscriminator("SetMetaKeywordsChange", typeof(commercetools.HistoryApi.Models.Changes.SetMetaKeywordsChange))]
    [SubTypeDiscriminator("SetMetaTitleChange", typeof(commercetools.HistoryApi.Models.Changes.SetMetaTitleChange))]
    [SubTypeDiscriminator("SetMethodInfoInterfaceChange", typeof(commercetools.HistoryApi.Models.Changes.SetMethodInfoInterfaceChange))]
    [SubTypeDiscriminator("SetMethodInfoMethodChange", typeof(commercetools.HistoryApi.Models.Changes.SetMethodInfoMethodChange))]
    [SubTypeDiscriminator("SetMethodInfoNameChange", typeof(commercetools.HistoryApi.Models.Changes.SetMethodInfoNameChange))]
    [SubTypeDiscriminator("SetMiddleNameChange", typeof(commercetools.HistoryApi.Models.Changes.SetMiddleNameChange))]
    [SubTypeDiscriminator("SetNameChange", typeof(commercetools.HistoryApi.Models.Changes.SetNameChange))]
    [SubTypeDiscriminator("SetOrderLineItemCustomFieldChange", typeof(commercetools.HistoryApi.Models.Changes.SetOrderLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetOrderLineItemCustomTypeChange", typeof(commercetools.HistoryApi.Models.Changes.SetOrderLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetOrderNumberChange", typeof(commercetools.HistoryApi.Models.Changes.SetOrderNumberChange))]
    [SubTypeDiscriminator("SetOrderTaxedPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetOrderTaxedPriceChange))]
    [SubTypeDiscriminator("SetOrderTotalPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetOrderTotalPriceChange))]
    [SubTypeDiscriminator("SetOrderTotalTaxChange", typeof(commercetools.HistoryApi.Models.Changes.SetOrderTotalTaxChange))]
    [SubTypeDiscriminator("SetParcelItemsChange", typeof(commercetools.HistoryApi.Models.Changes.SetParcelItemsChange))]
    [SubTypeDiscriminator("SetParcelMeasurementsChange", typeof(commercetools.HistoryApi.Models.Changes.SetParcelMeasurementsChange))]
    [SubTypeDiscriminator("SetParcelTrackingDataChange", typeof(commercetools.HistoryApi.Models.Changes.SetParcelTrackingDataChange))]
    [SubTypeDiscriminator("SetPricesChange", typeof(commercetools.HistoryApi.Models.Changes.SetPricesChange))]
    [SubTypeDiscriminator("SetProductPriceCustomFieldChange", typeof(commercetools.HistoryApi.Models.Changes.SetProductPriceCustomFieldChange))]
    [SubTypeDiscriminator("SetProductPriceCustomTypeChange", typeof(commercetools.HistoryApi.Models.Changes.SetProductPriceCustomTypeChange))]
    [SubTypeDiscriminator("SetProductVariantKeyChange", typeof(commercetools.HistoryApi.Models.Changes.SetProductVariantKeyChange))]
    [SubTypeDiscriminator("SetRatingChange", typeof(commercetools.HistoryApi.Models.Changes.SetRatingChange))]
    [SubTypeDiscriminator("SetReservationsChange", typeof(commercetools.HistoryApi.Models.Changes.SetReservationsChange))]
    [SubTypeDiscriminator("SetRestockableInDaysChange", typeof(commercetools.HistoryApi.Models.Changes.SetRestockableInDaysChange))]
    [SubTypeDiscriminator("SetReturnPaymentStateChange", typeof(commercetools.HistoryApi.Models.Changes.SetReturnPaymentStateChange))]
    [SubTypeDiscriminator("SetReturnShipmentStateChange", typeof(commercetools.HistoryApi.Models.Changes.SetReturnShipmentStateChange))]
    [SubTypeDiscriminator("SetSalutationChange", typeof(commercetools.HistoryApi.Models.Changes.SetSalutationChange))]
    [SubTypeDiscriminator("SetSearchKeywordsChange", typeof(commercetools.HistoryApi.Models.Changes.SetSearchKeywordsChange))]
    [SubTypeDiscriminator("SetShippingAddressChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingAddressChange))]
    [SubTypeDiscriminator("SetShippingInfoPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingInfoPriceChange))]
    [SubTypeDiscriminator("SetShippingInfoTaxedPriceChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingInfoTaxedPriceChange))]
    [SubTypeDiscriminator("SetShippingMethodChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingMethodChange))]
    [SubTypeDiscriminator("SetShippingMethodTaxAmountChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingMethodTaxAmountChange))]
    [SubTypeDiscriminator("SetShippingMethodTaxRateChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingMethodTaxRateChange))]
    [SubTypeDiscriminator("SetShippingRateChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingRateChange))]
    [SubTypeDiscriminator("SetShippingRateInputChange", typeof(commercetools.HistoryApi.Models.Changes.SetShippingRateInputChange))]
    [SubTypeDiscriminator("SetShoppingListLineItemCustomFieldChange", typeof(commercetools.HistoryApi.Models.Changes.SetShoppingListLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetShoppingListLineItemCustomTypeChange", typeof(commercetools.HistoryApi.Models.Changes.SetShoppingListLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetSkuChange", typeof(commercetools.HistoryApi.Models.Changes.SetSkuChange))]
    [SubTypeDiscriminator("SetSlugChange", typeof(commercetools.HistoryApi.Models.Changes.SetSlugChange))]
    [SubTypeDiscriminator("SetStateRolesChange", typeof(commercetools.HistoryApi.Models.Changes.SetStateRolesChange))]
    [SubTypeDiscriminator("SetStatusInterfaceCodeChange", typeof(commercetools.HistoryApi.Models.Changes.SetStatusInterfaceCodeChange))]
    [SubTypeDiscriminator("SetStatusInterfaceTextChange", typeof(commercetools.HistoryApi.Models.Changes.SetStatusInterfaceTextChange))]
    [SubTypeDiscriminator("SetStoreChange", typeof(commercetools.HistoryApi.Models.Changes.SetStoreChange))]
    [SubTypeDiscriminator("SetStoresChange", typeof(commercetools.HistoryApi.Models.Changes.SetStoresChange))]
    [SubTypeDiscriminator("SetSupplyChannelChange", typeof(commercetools.HistoryApi.Models.Changes.SetSupplyChannelChange))]
    [SubTypeDiscriminator("SetSupplyChannelsChange", typeof(commercetools.HistoryApi.Models.Changes.SetSupplyChannelsChange))]
    [SubTypeDiscriminator("SetTargetChange", typeof(commercetools.HistoryApi.Models.Changes.SetTargetChange))]
    [SubTypeDiscriminator("SetTaxCategoryChange", typeof(commercetools.HistoryApi.Models.Changes.SetTaxCategoryChange))]
    [SubTypeDiscriminator("SetTextChange", typeof(commercetools.HistoryApi.Models.Changes.SetTextChange))]
    [SubTypeDiscriminator("SetTextLineItemCustomFieldChange", typeof(commercetools.HistoryApi.Models.Changes.SetTextLineItemCustomFieldChange))]
    [SubTypeDiscriminator("SetTextLineItemCustomTypeChange", typeof(commercetools.HistoryApi.Models.Changes.SetTextLineItemCustomTypeChange))]
    [SubTypeDiscriminator("SetTextLineItemDescriptionChange", typeof(commercetools.HistoryApi.Models.Changes.SetTextLineItemDescriptionChange))]
    [SubTypeDiscriminator("SetTitleChange", typeof(commercetools.HistoryApi.Models.Changes.SetTitleChange))]
    [SubTypeDiscriminator("SetTransitionsChange", typeof(commercetools.HistoryApi.Models.Changes.SetTransitionsChange))]
    [SubTypeDiscriminator("SetValidFromAndUntilChange", typeof(commercetools.HistoryApi.Models.Changes.SetValidFromAndUntilChange))]
    [SubTypeDiscriminator("SetValidFromChange", typeof(commercetools.HistoryApi.Models.Changes.SetValidFromChange))]
    [SubTypeDiscriminator("SetValidUntilChange", typeof(commercetools.HistoryApi.Models.Changes.SetValidUntilChange))]
    [SubTypeDiscriminator("SetVariantAvailabilityChange", typeof(commercetools.HistoryApi.Models.Changes.SetVariantAvailabilityChange))]
    [SubTypeDiscriminator("SetVatIdChange", typeof(commercetools.HistoryApi.Models.Changes.SetVatIdChange))]
    [SubTypeDiscriminator("TransitionCustomLineItemStateChange", typeof(commercetools.HistoryApi.Models.Changes.TransitionCustomLineItemStateChange))]
    [SubTypeDiscriminator("TransitionLineItemStateChange", typeof(commercetools.HistoryApi.Models.Changes.TransitionLineItemStateChange))]
    [SubTypeDiscriminator("TransitionStateChange", typeof(commercetools.HistoryApi.Models.Changes.TransitionStateChange))]
    [SubTypeDiscriminator("UnknownChange", typeof(commercetools.HistoryApi.Models.Changes.UnknownChange))]
    [SubTypeDiscriminator("UnpublishChange", typeof(commercetools.HistoryApi.Models.Changes.UnpublishChange))]
    [SubTypeDiscriminator("UpdateSyncInfoChange", typeof(commercetools.HistoryApi.Models.Changes.UpdateSyncInfoChange))]
    [SubTypeDiscriminator("VerifyEmailChange", typeof(commercetools.HistoryApi.Models.Changes.VerifyEmailChange))]
    public partial interface IChange
    {
        string Type { get; set; }

        string Change { get; set; }
    }
}
