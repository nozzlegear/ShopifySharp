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
    public sealed class FulfillmentConstraintRuleCreateArgumentsBuilder : ArgumentsBuilderBase<FulfillmentConstraintRuleCreatePayload, FulfillmentConstraintRuleCreateArgumentsBuilder>
    {
        protected override FulfillmentConstraintRuleCreateArgumentsBuilder Self => this;

        public FulfillmentConstraintRuleCreateArgumentsBuilder(IQuery<FulfillmentConstraintRuleCreatePayload> query) : base(query)
        {
        }

        public FulfillmentConstraintRuleCreateArgumentsBuilder DeliveryMethodTypes(ICollection<DeliveryMethodType>? deliveryMethodTypes)
        {
            base.InnerQuery.AddArgument("deliveryMethodTypes", deliveryMethodTypes);
            return this;
        }

        public FulfillmentConstraintRuleCreateArgumentsBuilder FunctionId(string? functionId)
        {
            base.InnerQuery.AddArgument("functionId", functionId);
            return this;
        }

        public FulfillmentConstraintRuleCreateArgumentsBuilder Metafields(ICollection<MetafieldInput>? metafields)
        {
            base.InnerQuery.AddArgument("metafields", metafields);
            return this;
        }
    }
}