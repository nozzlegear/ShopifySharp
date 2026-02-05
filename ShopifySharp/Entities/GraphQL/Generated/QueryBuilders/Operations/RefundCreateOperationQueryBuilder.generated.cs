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
    public sealed class RefundCreateOperationQueryBuilder : FieldsQueryBuilderBase<RefundCreatePayload, RefundCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<RefundCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public RefundCreateArgumentsBuilder Arguments { get; }
        protected override RefundCreateOperationQueryBuilder Self => this;

        public RefundCreateOperationQueryBuilder() : this("refundCreate")
        {
        }

        public RefundCreateOperationQueryBuilder(string name) : base(new Query<RefundCreatePayload>(name))
        {
            Arguments = new RefundCreateArgumentsBuilder(base.InnerQuery);
        }

        public RefundCreateOperationQueryBuilder(IQuery<RefundCreatePayload> query) : base(query)
        {
            Arguments = new RefundCreateArgumentsBuilder(base.InnerQuery);
        }

        public RefundCreateOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public RefundCreateOperationQueryBuilder Refund(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refund");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public RefundCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}