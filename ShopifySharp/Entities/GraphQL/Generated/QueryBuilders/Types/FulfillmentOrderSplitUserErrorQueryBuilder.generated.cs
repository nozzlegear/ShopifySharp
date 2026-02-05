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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class FulfillmentOrderSplitUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderSplitUserError, FulfillmentOrderSplitUserErrorQueryBuilder>
    {
        protected override FulfillmentOrderSplitUserErrorQueryBuilder Self => this;

        public FulfillmentOrderSplitUserErrorQueryBuilder() : this("fulfillmentOrderSplitUserError")
        {
        }

        public FulfillmentOrderSplitUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderSplitUserError>(name))
        {
        }

        public FulfillmentOrderSplitUserErrorQueryBuilder(IQuery<FulfillmentOrderSplitUserError> query) : base(query)
        {
        }

        public FulfillmentOrderSplitUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderSplitUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderSplitUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}