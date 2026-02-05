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
    public sealed class OrderCancelPayloadQueryBuilder : FieldsQueryBuilderBase<OrderCancelPayload, OrderCancelPayloadQueryBuilder>
    {
        protected override OrderCancelPayloadQueryBuilder Self => this;

        public OrderCancelPayloadQueryBuilder() : this("orderCancelPayload")
        {
        }

        public OrderCancelPayloadQueryBuilder(string name) : base(new Query<OrderCancelPayload>(name))
        {
        }

        public OrderCancelPayloadQueryBuilder(IQuery<OrderCancelPayload> query) : base(query)
        {
        }

        public OrderCancelPayloadQueryBuilder Job(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder> build)
        {
            var query = new Query<Job>("job");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.JobQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Job>(query);
            return this;
        }

        public OrderCancelPayloadQueryBuilder OrderCancelUserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancelUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderCancelUserError>("orderCancelUserErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderCancelUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderCancelUserError>(query);
            return this;
        }

        public OrderCancelPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}