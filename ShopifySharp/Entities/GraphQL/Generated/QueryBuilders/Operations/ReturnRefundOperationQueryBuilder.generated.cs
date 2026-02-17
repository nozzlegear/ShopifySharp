#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    [Obsolete("Use `returnProcess` instead.")]
    public sealed class ReturnRefundOperationQueryBuilder : FieldsQueryBuilderBase<ReturnRefundPayload, ReturnRefundOperationQueryBuilder>, IGraphOperationQueryBuilder<ReturnRefundPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public ReturnRefundArgumentsBuilder Arguments { get; }
        protected override ReturnRefundOperationQueryBuilder Self => this;

        public ReturnRefundOperationQueryBuilder() : this("returnRefund")
        {
        }

        public ReturnRefundOperationQueryBuilder(string name) : base(new Query<ReturnRefundPayload>(name))
        {
            Arguments = new ReturnRefundArgumentsBuilder(base.InnerQuery);
        }

        public ReturnRefundOperationQueryBuilder(IQuery<ReturnRefundPayload> query) : base(query)
        {
            Arguments = new ReturnRefundArgumentsBuilder(base.InnerQuery);
        }

        public ReturnRefundOperationQueryBuilder Refund(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refund");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public ReturnRefundOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder> build)
        {
            var query = new Query<ReturnUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnUserError>(query);
            return this;
        }
    }
}