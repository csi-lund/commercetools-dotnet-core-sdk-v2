using System;
using System.Collections.Generic;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingAttributesSearchRequest : IMissingAttributesSearchRequest
    {
        public int? Limit { get; set; }

        public int? Offset { get; set; }

        public bool? Staged { get; set; }

        public int? ProductSetLimit { get; set; }

        public bool? IncludeVariants { get; set; }

        public decimal? CoverageMin { get; set; }

        public decimal? CoverageMax { get; set; }

        public string SortBy { get; set; }

        public bool? ShowMissingAttributeNames { get; set; }

        public List<string> ProductIds { get; set; }

        public List<string> ProductTypeIds { get; set; }

        public string AttributeName { get; set; }
    }
}
