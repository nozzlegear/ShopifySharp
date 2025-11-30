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

public class ICustomerAccountPageQueryBuilder() : GraphQueryBuilder<ICustomerAccountPage>("query iCustomerAccountPage")
{
    public ICustomerAccountPageQueryBuilder AddFieldDefaultCursor()
    {
        AddField("defaultCursor");
        return this;
    }

    public ICustomerAccountPageQueryBuilder AddFieldHandle()
    {
        AddField("handle");
        return this;
    }

    public ICustomerAccountPageQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ICustomerAccountPageQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}