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
    public sealed class FulfillmentConstraintRuleUpdateArgumentsBuilder : ArgumentsBuilderBase<FulfillmentConstraintRuleUpdatePayload, FulfillmentConstraintRuleUpdateArgumentsBuilder>
    {
        protected override FulfillmentConstraintRuleUpdateArgumentsBuilder Self => this;

        public FulfillmentConstraintRuleUpdateArgumentsBuilder(IQuery<FulfillmentConstraintRuleUpdatePayload> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleUpdateArgumentsBuilder DeliveryMethodTypes(ICollection<DeliveryMethodType>? deliveryMethodTypes)
        {
            base.InnerQuery.AddArgument("deliveryMethodTypes", deliveryMethodTypes);
            return this;
        }

        public FulfillmentConstraintRuleUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}