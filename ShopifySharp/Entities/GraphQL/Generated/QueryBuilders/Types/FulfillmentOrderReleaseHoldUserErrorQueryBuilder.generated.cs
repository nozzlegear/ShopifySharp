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
    public sealed class FulfillmentOrderReleaseHoldUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderReleaseHoldUserError, FulfillmentOrderReleaseHoldUserErrorQueryBuilder>
    {
        protected override FulfillmentOrderReleaseHoldUserErrorQueryBuilder Self => this;

        public FulfillmentOrderReleaseHoldUserErrorQueryBuilder() : this("fulfillmentOrderReleaseHoldUserError")
        {
        }

        public FulfillmentOrderReleaseHoldUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderReleaseHoldUserError>(name))
        {
        }

        public FulfillmentOrderReleaseHoldUserErrorQueryBuilder(IQuery<FulfillmentOrderReleaseHoldUserError> query) : base(query)
        {
        }

        public FulfillmentOrderReleaseHoldUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderReleaseHoldUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderReleaseHoldUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}