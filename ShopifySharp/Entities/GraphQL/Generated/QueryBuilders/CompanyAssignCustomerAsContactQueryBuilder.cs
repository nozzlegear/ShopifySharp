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

public class CompanyAssignCustomerAsContactQueryBuilder() : GraphQueryBuilder<CompanyAssignCustomerAsContactPayload>("query companyAssignCustomerAsContact")
{
    public CompanyAssignCustomerAsContactQueryBuilder AddArgumentCompanyId(string? companyId)
    {
        AddArgument("companyId", companyId);
        return this;
    }

    public CompanyAssignCustomerAsContactQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }
}