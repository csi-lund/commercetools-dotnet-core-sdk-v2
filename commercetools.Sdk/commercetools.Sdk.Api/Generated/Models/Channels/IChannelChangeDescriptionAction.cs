using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Channels
{
    [DeserializeAs(typeof(commercetools.Api.Models.Channels.ChannelChangeDescriptionAction))]
    public partial interface IChannelChangeDescriptionAction : IChannelUpdateAction
    {
        ILocalizedString Description { get; set; }
    }
}
