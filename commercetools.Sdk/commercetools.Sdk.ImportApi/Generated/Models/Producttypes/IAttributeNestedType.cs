using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Producttypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Producttypes
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Producttypes.AttributeNestedType))]
    public partial interface IAttributeNestedType : IAttributeType
    {
        IProductTypeKeyReference TypeReference { get; set; }
    }
}
