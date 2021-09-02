using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    public partial class FieldDefinition : IFieldDefinition
    {
        public Object Type { get; set; }

        public string Name { get; set; }

        public ILocalizedString Label { get; set; }

        public ITextInputHint InputHint { get; set; }
    }
}
