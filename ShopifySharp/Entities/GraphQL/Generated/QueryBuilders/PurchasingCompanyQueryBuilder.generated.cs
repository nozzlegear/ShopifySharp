#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class PurchasingCompanyQueryBuilder() : GraphQueryBuilder<PurchasingCompany>("purchasingCompany")
{
    public PurchasingCompanyQueryBuilder AddFieldCompany(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddField<Company, CompanyQueryBuilder>("company", build);
        return this;
    }

    public PurchasingCompanyQueryBuilder AddFieldContact(Func<CompanyContactQueryBuilder, CompanyContactQueryBuilder> build)
    {
        AddField<CompanyContact, CompanyContactQueryBuilder>("contact", build);
        return this;
    }

    public PurchasingCompanyQueryBuilder AddFieldLocation(Func<CompanyLocationQueryBuilder, CompanyLocationQueryBuilder> build)
    {
        AddField<CompanyLocation, CompanyLocationQueryBuilder>("location", build);
        return this;
    }
}