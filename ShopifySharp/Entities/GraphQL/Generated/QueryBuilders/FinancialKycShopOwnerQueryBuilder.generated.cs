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

public class FinancialKycShopOwnerQueryBuilder() : GraphQueryBuilder<FinancialKycShopOwner>("financialKycShopOwner")
{
    public FinancialKycShopOwnerQueryBuilder AddFieldEmail()
    {
        AddField("email");
        return this;
    }

    public FinancialKycShopOwnerQueryBuilder AddFieldFirstName()
    {
        AddField("firstName");
        return this;
    }

    public FinancialKycShopOwnerQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FinancialKycShopOwnerQueryBuilder AddFieldLastName()
    {
        AddField("lastName");
        return this;
    }

    public FinancialKycShopOwnerQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }
}