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
    public sealed class QueryRootDeliveryProfileArgumentsBuilder : ArgumentsBuilderBase<DeliveryProfile?, QueryRootDeliveryProfileArgumentsBuilder>
    {
        protected override QueryRootDeliveryProfileArgumentsBuilder Self => this;

        public QueryRootDeliveryProfileArgumentsBuilder(IQuery<DeliveryProfile?> query) : base(query)
        {
        }

        public QueryRootDeliveryProfileArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}