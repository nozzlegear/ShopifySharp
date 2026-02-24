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
    public sealed class QueryRootShopLocalesArgumentsBuilder : ArgumentsBuilderBase<ShopLocale?, QueryRootShopLocalesArgumentsBuilder>
    {
        protected override QueryRootShopLocalesArgumentsBuilder Self => this;

        public QueryRootShopLocalesArgumentsBuilder(IQuery<ShopLocale?> query) : base(query)
        {
        }

        public QueryRootShopLocalesArgumentsBuilder Published(bool? published)
        {
            base.InnerQuery.AddArgument("published", published);
            return this;
        }
    }
}