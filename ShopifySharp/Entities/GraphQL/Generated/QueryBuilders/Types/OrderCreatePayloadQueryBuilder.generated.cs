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
    public sealed class OrderCreatePayloadQueryBuilder : FieldsQueryBuilderBase<OrderCreatePayload, OrderCreatePayloadQueryBuilder>
    {
        protected override OrderCreatePayloadQueryBuilder Self => this;

        public OrderCreatePayloadQueryBuilder() : this("orderCreatePayload")
        {
        }

        public OrderCreatePayloadQueryBuilder(string name) : base(new Query<OrderCreatePayload>(name))
        {
        }

        public OrderCreatePayloadQueryBuilder(IQuery<OrderCreatePayload> query) : base(query)
        {
        }

        public OrderCreatePayloadQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCreateUserError>(query);
            return this;
        }
    }
}