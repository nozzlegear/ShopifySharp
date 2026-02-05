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
    public sealed class OrderEditCommitPayloadQueryBuilder : FieldsQueryBuilderBase<OrderEditCommitPayload, OrderEditCommitPayloadQueryBuilder>
    {
        protected override OrderEditCommitPayloadQueryBuilder Self => this;

        public OrderEditCommitPayloadQueryBuilder() : this("orderEditCommitPayload")
        {
        }

        public OrderEditCommitPayloadQueryBuilder(string name) : base(new Query<OrderEditCommitPayload>(name))
        {
        }

        public OrderEditCommitPayloadQueryBuilder(IQuery<OrderEditCommitPayload> query) : base(query)
        {
        }

        public OrderEditCommitPayloadQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderEditCommitPayloadQueryBuilder SuccessMessages()
        {
            base.InnerQuery.AddField("successMessages");
            return this;
        }

        public OrderEditCommitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}