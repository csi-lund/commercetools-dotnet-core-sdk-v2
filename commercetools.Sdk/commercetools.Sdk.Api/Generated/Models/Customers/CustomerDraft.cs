using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Stores;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerDraft : ICustomerDraft
    {
        public string CustomerNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string Title { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public string AnonymousCartId { get; set; }

        public ICartResourceIdentifier AnonymousCart { get; set; }

        public string AnonymousId { get; set; }

        public Date? DateOfBirth { get; set; }

        public string CompanyName { get; set; }

        public string VatId { get; set; }

        public List<IBaseAddress> Addresses { get; set; }

        public int? DefaultShippingAddress { get; set; }

        public List<int> ShippingAddresses { get; set; }

        public int? DefaultBillingAddress { get; set; }

        public List<int> BillingAddresses { get; set; }

        public bool? IsEmailVerified { get; set; }

        public string ExternalId { get; set; }

        public ICustomerGroupResourceIdentifier CustomerGroup { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Locale { get; set; }

        public string Salutation { get; set; }

        public string Key { get; set; }

        public List<IStoreResourceIdentifier> Stores { get; set; }

        public IAuthenticationMode AuthenticationMode { get; set; }
    }
}
