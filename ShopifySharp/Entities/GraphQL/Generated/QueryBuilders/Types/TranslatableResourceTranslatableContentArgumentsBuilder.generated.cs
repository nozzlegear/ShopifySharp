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
    public sealed class TranslatableResourceTranslatableContentArgumentsBuilder : ArgumentsBuilderBase<TranslatableContent?, TranslatableResourceTranslatableContentArgumentsBuilder>
    {
        protected override TranslatableResourceTranslatableContentArgumentsBuilder Self => this;

        public TranslatableResourceTranslatableContentArgumentsBuilder(IQuery<TranslatableContent?> query) : base(query)
        {
        }

        public TranslatableResourceTranslatableContentArgumentsBuilder MarketId(string? marketId)
        {
            base.InnerQuery.AddArgument("marketId", marketId);
            return this;
        }
    }
}