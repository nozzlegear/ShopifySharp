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
    public sealed class ShopLocaleDisableArgumentsBuilder : ArgumentsBuilderBase<ShopLocaleDisablePayload, ShopLocaleDisableArgumentsBuilder>
    {
        protected override ShopLocaleDisableArgumentsBuilder Self => this;

        public ShopLocaleDisableArgumentsBuilder(IQuery<ShopLocaleDisablePayload> query) : base(query)
        {
        }

        public ShopLocaleDisableArgumentsBuilder Locale(string? locale)
        {
            base.InnerQuery.AddArgument("locale", locale);
            return this;
        }
    }
}