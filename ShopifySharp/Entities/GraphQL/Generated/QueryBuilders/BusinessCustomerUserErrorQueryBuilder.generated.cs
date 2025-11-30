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

public class BusinessCustomerUserErrorQueryBuilder() : GraphQueryBuilder<BusinessCustomerUserError>("businessCustomerUserError")
{
    public BusinessCustomerUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public BusinessCustomerUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public BusinessCustomerUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}