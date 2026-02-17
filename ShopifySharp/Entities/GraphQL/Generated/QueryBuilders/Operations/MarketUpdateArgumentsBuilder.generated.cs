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
    public sealed class MarketUpdateArgumentsBuilder : ArgumentsBuilderBase<MarketUpdatePayload, MarketUpdateArgumentsBuilder>
    {
        protected override MarketUpdateArgumentsBuilder Self => this;

        public MarketUpdateArgumentsBuilder(IQuery<MarketUpdatePayload> query) : base(query)
        {
        }

        public MarketUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public MarketUpdateArgumentsBuilder Input(MarketUpdateInput? input)
        {
            base.InnerQuery.AddArgument("input", input);
            return this;
        }
    }
}