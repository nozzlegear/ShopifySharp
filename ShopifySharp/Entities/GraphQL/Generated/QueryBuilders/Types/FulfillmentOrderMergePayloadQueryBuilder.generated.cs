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
    public sealed class FulfillmentOrderMergePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderMergePayload, FulfillmentOrderMergePayloadQueryBuilder>
    {
        protected override FulfillmentOrderMergePayloadQueryBuilder Self => this;

        public FulfillmentOrderMergePayloadQueryBuilder() : this("fulfillmentOrderMergePayload")
        {
        }

        public FulfillmentOrderMergePayloadQueryBuilder(string name) : base(new Query<FulfillmentOrderMergePayload>(name))
        {
        }

        public FulfillmentOrderMergePayloadQueryBuilder(IQuery<FulfillmentOrderMergePayload> query) : base(query)
        {
        }

        public FulfillmentOrderMergePayloadQueryBuilder FulfillmentOrderMerges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeResultQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMergeResult>("fulfillmentOrderMerges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeResultQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMergeResult>(query);
            return this;
        }

        public FulfillmentOrderMergePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMergeUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderMergeUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMergeUserError>(query);
            return this;
        }
    }
}