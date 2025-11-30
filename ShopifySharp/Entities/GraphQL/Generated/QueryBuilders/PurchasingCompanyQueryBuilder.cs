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

public class PurchasingCompanyQueryBuilder() : GraphQueryBuilder<PurchasingCompany>("query purchasingCompany")
{
    public PurchasingCompanyQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public PurchasingCompanyQueryBuilder AddFieldContact()
    {
        AddField("contact");
        return this;
    }

    public PurchasingCompanyQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }
}