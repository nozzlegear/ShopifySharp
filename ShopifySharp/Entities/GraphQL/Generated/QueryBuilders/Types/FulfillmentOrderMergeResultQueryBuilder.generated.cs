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
    public sealed class FulfillmentOrderMergeResultQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMergeResult, FulfillmentOrderMergeResultQueryBuilder>
    {
        protected override FulfillmentOrderMergeResultQueryBuilder Self => this;

        public FulfillmentOrderMergeResultQueryBuilder() : this("fulfillmentOrderMergeResult")
        {
        }

        public FulfillmentOrderMergeResultQueryBuilder(string name) : base(new Query<FulfillmentOrderMergeResult>(name))
        {
        }

        public FulfillmentOrderMergeResultQueryBuilder(IQuery<FulfillmentOrderMergeResult> query) : base(query)
        {
        }

        public FulfillmentOrderMergeResultQueryBuilder FulfillmentOrder(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrder>("fulfillmentOrder");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrder>(query);
            return this;
        }
    }
}