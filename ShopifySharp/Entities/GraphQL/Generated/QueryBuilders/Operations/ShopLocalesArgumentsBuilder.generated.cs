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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ShopLocalesArgumentsBuilder : ArgumentsBuilderBase<ShopLocale, ShopLocalesArgumentsBuilder>
    {
        protected override ShopLocalesArgumentsBuilder Self => this;

        public ShopLocalesArgumentsBuilder(IQuery<ShopLocale> query) : base(query)
        {
        }

        public ShopLocalesArgumentsBuilder Published(bool? published)
        {
            base.InnerQuery.AddArgument("published", published);
            return this;
        }
    }
}