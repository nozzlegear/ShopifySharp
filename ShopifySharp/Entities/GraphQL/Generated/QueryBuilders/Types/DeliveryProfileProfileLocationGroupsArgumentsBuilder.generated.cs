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
    public sealed class DeliveryProfileProfileLocationGroupsArgumentsBuilder : ArgumentsBuilderBase<DeliveryProfileLocationGroup?, DeliveryProfileProfileLocationGroupsArgumentsBuilder>
    {
        protected override DeliveryProfileProfileLocationGroupsArgumentsBuilder Self => this;

        public DeliveryProfileProfileLocationGroupsArgumentsBuilder(IQuery<DeliveryProfileLocationGroup?> query) : base(query)
        {
        }

        public DeliveryProfileProfileLocationGroupsArgumentsBuilder LocationGroupId(string? locationGroupId)
        {
            base.InnerQuery.AddArgument("locationGroupId", locationGroupId);
            return this;
        }
    }
}