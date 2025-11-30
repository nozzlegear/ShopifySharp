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

public class CompanyAssignMainContactPayloadQueryBuilder() : GraphQueryBuilder<CompanyAssignMainContactPayload>("query companyAssignMainContactPayload")
{
    public CompanyAssignMainContactPayloadQueryBuilder AddFieldCompany()
    {
        AddField("company");
        return this;
    }

    public CompanyAssignMainContactPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}