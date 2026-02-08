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
    public sealed class ShopLocaleUpdateArgumentsBuilder : ArgumentsBuilderBase<ShopLocaleUpdatePayload, ShopLocaleUpdateArgumentsBuilder>
    {
        protected override ShopLocaleUpdateArgumentsBuilder Self => this;

        public ShopLocaleUpdateArgumentsBuilder(IQuery<ShopLocaleUpdatePayload> query) : base(query)
        {
        }

        public ShopLocaleUpdateArgumentsBuilder Locale(string? locale)
        {
            base.InnerQuery.AddArgument("locale", locale);
            return this;
        }

        public ShopLocaleUpdateArgumentsBuilder ShopLocale(ShopLocaleInput? shopLocale)
        {
            base.InnerQuery.AddArgument("shopLocale", shopLocale);
            return this;
        }
    }
}