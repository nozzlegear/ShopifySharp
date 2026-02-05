#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class AppPurchaseOneTimeCreateArgumentsBuilder : ArgumentsBuilderBase<AppPurchaseOneTimeCreatePayload, AppPurchaseOneTimeCreateArgumentsBuilder>
    {
        protected override AppPurchaseOneTimeCreateArgumentsBuilder Self => this;

        public AppPurchaseOneTimeCreateArgumentsBuilder(IQuery<AppPurchaseOneTimeCreatePayload> query) : base(query)
        {
        }

        public AppPurchaseOneTimeCreateArgumentsBuilder Name(string? name)
        {
            base.InnerQuery.AddArgument("name", name);
            return this;
        }

        public AppPurchaseOneTimeCreateArgumentsBuilder Price(MoneyInput? price)
        {
            base.InnerQuery.AddArgument("price", price);
            return this;
        }

        public AppPurchaseOneTimeCreateArgumentsBuilder ReturnUrl(string? returnUrl)
        {
            base.InnerQuery.AddArgument("returnUrl", returnUrl);
            return this;
        }

        public AppPurchaseOneTimeCreateArgumentsBuilder Test(bool? test)
        {
            base.InnerQuery.AddArgument("test", test);
            return this;
        }
    }
}