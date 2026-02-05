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
    public sealed class OrderDeletePayloadQueryBuilder : FieldsQueryBuilderBase<OrderDeletePayload, OrderDeletePayloadQueryBuilder>
    {
        protected override OrderDeletePayloadQueryBuilder Self => this;

        public OrderDeletePayloadQueryBuilder() : this("orderDeletePayload")
        {
        }

        public OrderDeletePayloadQueryBuilder(string name) : base(new Query<OrderDeletePayload>(name))
        {
        }

        public OrderDeletePayloadQueryBuilder(IQuery<OrderDeletePayload> query) : base(query)
        {
        }

        public OrderDeletePayloadQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public OrderDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderDeleteUserError>(query);
            return this;
        }
    }
}