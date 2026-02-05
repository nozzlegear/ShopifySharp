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
    public sealed class OrderByIdentifierArgumentsBuilder : ArgumentsBuilderBase<Order, OrderByIdentifierArgumentsBuilder>
    {
        protected override OrderByIdentifierArgumentsBuilder Self => this;

        public OrderByIdentifierArgumentsBuilder(IQuery<Order> query) : base(query)
        {
        }

        public OrderByIdentifierArgumentsBuilder Identifier(OrderIdentifierInput? identifier)
        {
            base.InnerQuery.AddArgument("identifier", identifier);
            return this;
        }
    }
}