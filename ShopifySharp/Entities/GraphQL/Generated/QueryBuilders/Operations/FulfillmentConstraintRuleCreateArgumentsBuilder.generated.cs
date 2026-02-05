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

        public FulfillmentConstraintRuleCreateArgumentsBuilder FunctionHandle(string? functionHandle)
        {
            base.InnerQuery.AddArgument("functionHandle", functionHandle);
            return this;
        }

        public FulfillmentConstraintRuleCreateArgumentsBuilder Metafields(ICollection<MetafieldInput>? metafields)
        {
            base.InnerQuery.AddArgument("metafields", metafields);
            return this;
        }
    }
}