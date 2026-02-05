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
    public sealed class FulfillmentOrderSplitPayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderSplitPayload, FulfillmentOrderSplitPayloadQueryBuilder>
    {
        protected override FulfillmentOrderSplitPayloadQueryBuilder Self => this;

        public FulfillmentOrderSplitPayloadQueryBuilder() : this("fulfillmentOrderSplitPayload")
        {
        }

        public FulfillmentOrderSplitPayloadQueryBuilder(string name) : base(new Query<FulfillmentOrderSplitPayload>(name))
        {
        }

        public FulfillmentOrderSplitPayloadQueryBuilder(IQuery<FulfillmentOrderSplitPayload> query) : base(query)
        {
        }

        public FulfillmentOrderSplitPayloadQueryBuilder FulfillmentOrderSplits(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitResultQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderSplitResult>("fulfillmentOrderSplits");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderSplitResult>(query);
            return this;
        }

        public FulfillmentOrderSplitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderSplitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderSplitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderSplitUserError>(query);
            return this;
        }
    }
}