using commercetools.Sdk.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.Sdk.MLApi.Models.MissingData.MissingDataTaskStatus))]
    [Obsolete]
    public partial interface IMissingDataTaskStatus
    {
        ITaskStatusEnum State { get; set; }

        DateTime Expires { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        IMissingAttributesPagedQueryResult Result { get; set; }

    }
}
