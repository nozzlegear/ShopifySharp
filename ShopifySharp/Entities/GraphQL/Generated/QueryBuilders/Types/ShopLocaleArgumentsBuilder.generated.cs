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
    public sealed class ShopLocaleArgumentsBuilder : ArgumentsBuilderBase<ShopLocale, ShopLocaleArgumentsBuilder>
    {
        protected override ShopLocaleArgumentsBuilder Self => this;

        public ShopLocaleArgumentsBuilder(IQuery<ShopLocale> query) : base(query)
        {
        }

        public ShopLocaleArgumentsBuilder Published(bool? published)
        {
            base.InnerQuery.AddArgument("published", published);
            return this;
        }
    }
}