#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class ShopStorefrontAccessTokensArgumentsBuilder : ArgumentsBuilderBase<StorefrontAccessTokenConnection?, ShopStorefrontAccessTokensArgumentsBuilder>
    {
        protected override ShopStorefrontAccessTokensArgumentsBuilder Self => this;

        public ShopStorefrontAccessTokensArgumentsBuilder(IQuery<StorefrontAccessTokenConnection?> query) : base(query)
        {
        }

        public ShopStorefrontAccessTokensArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopStorefrontAccessTokensArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopStorefrontAccessTokensArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopStorefrontAccessTokensArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopStorefrontAccessTokensArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}