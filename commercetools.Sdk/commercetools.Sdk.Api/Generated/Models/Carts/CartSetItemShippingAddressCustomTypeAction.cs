using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartSetItemShippingAddressCustomTypeAction : ICartSetItemShippingAddressCustomTypeAction
    {
        public string Action { get; set; }

        public string AddressKey { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public CartSetItemShippingAddressCustomTypeAction()
        {
            this.Action = "setItemShippingAddressCustomType";
        }
    }
}
