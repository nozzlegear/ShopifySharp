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
    public sealed class QueryRootDeliveryCustomizationArgumentsBuilder : ArgumentsBuilderBase<DeliveryCustomization?, QueryRootDeliveryCustomizationArgumentsBuilder>
    {
        protected override QueryRootDeliveryCustomizationArgumentsBuilder Self => this;

        public QueryRootDeliveryCustomizationArgumentsBuilder(IQuery<DeliveryCustomization?> query) : base(query)
        {
        }

        public QueryRootDeliveryCustomizationArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}