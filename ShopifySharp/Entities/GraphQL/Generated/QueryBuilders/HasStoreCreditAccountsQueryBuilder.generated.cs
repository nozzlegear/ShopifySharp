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

public class HasStoreCreditAccountsQueryBuilder() : GraphQueryBuilder<IHasStoreCreditAccounts>("hasStoreCreditAccounts")
{
    public HasStoreCreditAccountsQueryBuilder AddFieldStoreCreditAccounts(Func<StoreCreditAccountConnectionQueryBuilder, StoreCreditAccountConnectionQueryBuilder> build)
    {
        AddField<StoreCreditAccountConnection, StoreCreditAccountConnectionQueryBuilder>("storeCreditAccounts", build);
        return this;
    }
}