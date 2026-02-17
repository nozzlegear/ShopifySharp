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
    public sealed class FulfillmentOrderRescheduleUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderRescheduleUserError, FulfillmentOrderRescheduleUserErrorQueryBuilder>
    {
        protected override FulfillmentOrderRescheduleUserErrorQueryBuilder Self => this;

        public FulfillmentOrderRescheduleUserErrorQueryBuilder() : this("fulfillmentOrderRescheduleUserError")
        {
        }

        public FulfillmentOrderRescheduleUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderRescheduleUserError>(name))
        {
        }

        public FulfillmentOrderRescheduleUserErrorQueryBuilder(IQuery<FulfillmentOrderRescheduleUserError> query) : base(query)
        {
        }

        public FulfillmentOrderRescheduleUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderRescheduleUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderRescheduleUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}