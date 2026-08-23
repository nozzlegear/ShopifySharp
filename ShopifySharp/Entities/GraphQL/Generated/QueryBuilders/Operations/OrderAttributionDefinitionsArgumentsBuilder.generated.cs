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
    public sealed class OrderAttributionDefinitionsArgumentsBuilder : ArgumentsBuilderBase<OrderAttributionDefinitionConnection, OrderAttributionDefinitionsArgumentsBuilder>
    {
        protected override OrderAttributionDefinitionsArgumentsBuilder Self => this;

        public OrderAttributionDefinitionsArgumentsBuilder(IQuery<OrderAttributionDefinitionConnection> query) : base(query)
        {
        }

        public OrderAttributionDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public OrderAttributionDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public OrderAttributionDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public OrderAttributionDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public OrderAttributionDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}