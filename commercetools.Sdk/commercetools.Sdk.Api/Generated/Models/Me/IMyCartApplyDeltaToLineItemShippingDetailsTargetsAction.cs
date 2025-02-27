using commercetools.Sdk.Api.Models.Carts;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyCartApplyDeltaToLineItemShippingDetailsTargetsAction))]
    public partial interface IMyCartApplyDeltaToLineItemShippingDetailsTargetsAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        List<IItemShippingTarget> TargetsDelta { get; set; }

    }
}
