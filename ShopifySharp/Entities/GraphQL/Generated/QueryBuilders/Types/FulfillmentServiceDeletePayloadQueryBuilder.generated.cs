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
    public sealed class FulfillmentServiceDeletePayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentServiceDeletePayload, FulfillmentServiceDeletePayloadQueryBuilder>
    {
        protected override FulfillmentServiceDeletePayloadQueryBuilder Self => this;

        public FulfillmentServiceDeletePayloadQueryBuilder() : this("fulfillmentServiceDeletePayload")
        {
        }

        public FulfillmentServiceDeletePayloadQueryBuilder(string name) : base(new Query<FulfillmentServiceDeletePayload>(name))
        {
        }

        public FulfillmentServiceDeletePayloadQueryBuilder(IQuery<FulfillmentServiceDeletePayload> query) : base(query)
        {
        }

        public FulfillmentServiceDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public FulfillmentServiceDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}