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

public class SaleTaxQueryBuilder() : GraphQueryBuilder<SaleTax>("query saleTax")
{
    public SaleTaxQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public SaleTaxQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SaleTaxQueryBuilder AddFieldTaxLine()
    {
        AddField("taxLine");
        return this;
    }
}