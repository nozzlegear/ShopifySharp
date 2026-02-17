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
    public sealed class FulfillmentOrderHoldUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderHoldUserError, FulfillmentOrderHoldUserErrorQueryBuilder>
    {
        protected override FulfillmentOrderHoldUserErrorQueryBuilder Self => this;

        public FulfillmentOrderHoldUserErrorQueryBuilder() : this("fulfillmentOrderHoldUserError")
        {
        }

        public FulfillmentOrderHoldUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderHoldUserError>(name))
        {
        }

        public FulfillmentOrderHoldUserErrorQueryBuilder(IQuery<FulfillmentOrderHoldUserError> query) : base(query)
        {
        }

        public FulfillmentOrderHoldUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderHoldUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderHoldUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}