using commercetools.Sdk.ImportApi.Models.Categories;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Importrequests
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Importrequests.CategoryImportRequest))]
    public partial interface ICategoryImportRequest : IImportRequest
    {
        List<ICategoryImport> Resources { get; set; }

    }
}
