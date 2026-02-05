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