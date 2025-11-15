#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CompanyLocationTaxSettingsQueryBuilder() : GraphQueryBuilder<CompanyLocationTaxSettings>("query companyLocationTaxSettings")
{
    public CompanyLocationTaxSettingsQueryBuilder AddFieldTaxExempt()
    {
        AddField("taxExempt");
        return this;
    }

    public CompanyLocationTaxSettingsQueryBuilder AddFieldTaxExemptions()
    {
        AddField("taxExemptions");
        return this;
    }

    public CompanyLocationTaxSettingsQueryBuilder AddFieldTaxRegistrationId()
    {
        AddField("taxRegistrationId");
        return this;
    }
}