using System;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [Obsolete("usage of this endpoint has been deprecated.", false)]
    public partial class MissingImagesCount : IMissingImagesCount
    {
        public long MissingImages { get; set; }

        public long Total { get; set; }
    }
}
