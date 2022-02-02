using System;


namespace commercetools.Api.Models.ProductSelections
{
    public partial class AssignedProductSelection : IAssignedProductSelection
    {
        public DateTime CreatedAt { get; set; }

        public IProductSelectionReference ProductSelection { get; set; }
    }
}
