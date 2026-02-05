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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class OrderDeleteOperationQueryBuilder : FieldsQueryBuilderBase<OrderDeletePayload, OrderDeleteOperationQueryBuilder>, IGraphOperationQueryBuilder<OrderDeletePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public OrderDeleteArgumentsBuilder Arguments { get; }
        protected override OrderDeleteOperationQueryBuilder Self => this;

        public OrderDeleteOperationQueryBuilder() : this("orderDelete")
        {
        }

        public OrderDeleteOperationQueryBuilder(string name) : base(new Query<OrderDeletePayload>(name))
        {
            Arguments = new OrderDeleteArgumentsBuilder(base.InnerQuery);
        }

        public OrderDeleteOperationQueryBuilder(IQuery<OrderDeletePayload> query) : base(query)
        {
            Arguments = new OrderDeleteArgumentsBuilder(base.InnerQuery);
        }

        public OrderDeleteOperationQueryBuilder DeletedId()
        {
            base.InnerQuery.AddField("deletedId");
            return this;
        }

        public OrderDeleteOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDeleteUserErrorQueryBuilder> build)
        {
            var query = new Query<OrderDeleteUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderDeleteUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderDeleteUserError>(query);
            return this;
        }
    }
}