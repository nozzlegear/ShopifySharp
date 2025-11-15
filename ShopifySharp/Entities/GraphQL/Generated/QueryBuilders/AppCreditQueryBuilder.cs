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

public class AppCreditQueryBuilder() : GraphQueryBuilder<AppCredit>("query appCredit")
{
    public AppCreditQueryBuilder AddFieldAmount()
    {
        AddField("amount");
        return this;
    }

    public AppCreditQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AppCreditQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public AppCreditQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppCreditQueryBuilder AddFieldTest()
    {
        AddField("test");
        return this;
    }
}