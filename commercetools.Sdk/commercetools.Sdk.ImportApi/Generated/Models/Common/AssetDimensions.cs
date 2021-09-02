using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Common
{
    public partial class AssetDimensions : IAssetDimensions
    {
        public int W { get; set; }

        public int H { get; set; }
    }
}
