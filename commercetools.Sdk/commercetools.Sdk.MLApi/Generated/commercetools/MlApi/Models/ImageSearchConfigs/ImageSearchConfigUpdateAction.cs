using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearchConfigs
{
    public partial class ImageSearchConfigUpdateAction : IImageSearchConfigUpdateAction
    {
        public string Action { get; set; }
    }
}
