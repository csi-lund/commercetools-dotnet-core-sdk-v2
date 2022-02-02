using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.AssignedProductSelection))]
    public partial interface IAssignedProductSelection
    {
        DateTime CreatedAt { get; set; }

        IProductSelectionReference ProductSelection { get; set; }
    }
}
