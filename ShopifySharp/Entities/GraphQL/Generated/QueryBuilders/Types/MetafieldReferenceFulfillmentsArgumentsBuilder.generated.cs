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
    public sealed class MetafieldReferenceFulfillmentsArgumentsBuilder : ArgumentsBuilderBase<Fulfillment?, MetafieldReferenceFulfillmentsArgumentsBuilder>
    {
        protected override MetafieldReferenceFulfillmentsArgumentsBuilder Self => this;

        public MetafieldReferenceFulfillmentsArgumentsBuilder(IQuery<Fulfillment?> query) : base(query)
        {
        }

        public MetafieldReferenceFulfillmentsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferenceFulfillmentsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }
    }
}