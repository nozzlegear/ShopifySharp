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
    public sealed class FulfillmentCancelPayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentCancelPayload, FulfillmentCancelPayloadQueryBuilder>
    {
        protected override FulfillmentCancelPayloadQueryBuilder Self => this;

        public FulfillmentCancelPayloadQueryBuilder() : this("fulfillmentCancelPayload")
        {
        }

        public FulfillmentCancelPayloadQueryBuilder(string name) : base(new Query<FulfillmentCancelPayload>(name))
        {
        }

        public FulfillmentCancelPayloadQueryBuilder(IQuery<FulfillmentCancelPayload> query) : base(query)
        {
        }

        public FulfillmentCancelPayloadQueryBuilder Fulfillment(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder> build)
        {
            var query = new Query<Fulfillment>("fulfillment");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Fulfillment>(query);
            return this;
        }

        public FulfillmentCancelPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}