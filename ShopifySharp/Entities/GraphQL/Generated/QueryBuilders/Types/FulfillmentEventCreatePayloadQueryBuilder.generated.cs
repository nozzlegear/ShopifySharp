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
    public sealed class FulfillmentEventCreatePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentEventCreatePayload, FulfillmentEventCreatePayloadQueryBuilder>
    {
        protected override FulfillmentEventCreatePayloadQueryBuilder Self => this;

        public FulfillmentEventCreatePayloadQueryBuilder() : this("fulfillmentEventCreatePayload")
        {
        }

        public FulfillmentEventCreatePayloadQueryBuilder(string name) : base(new Query<FulfillmentEventCreatePayload>(name))
        {
        }

        public FulfillmentEventCreatePayloadQueryBuilder(IQuery<FulfillmentEventCreatePayload> query) : base(query)
        {
        }

        public FulfillmentEventCreatePayloadQueryBuilder FulfillmentEvent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEventQueryBuilder> build)
        {
            var query = new Query<FulfillmentEvent>("fulfillmentEvent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEventQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEvent>(query);
            return this;
        }

        public FulfillmentEventCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}