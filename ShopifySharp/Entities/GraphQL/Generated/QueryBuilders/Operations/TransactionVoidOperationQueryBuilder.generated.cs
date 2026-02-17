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
    public sealed class TransactionVoidOperationQueryBuilder : FieldsQueryBuilderBase<TransactionVoidPayload, TransactionVoidOperationQueryBuilder>, IGraphOperationQueryBuilder<TransactionVoidPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public TransactionVoidArgumentsBuilder Arguments { get; }
        protected override TransactionVoidOperationQueryBuilder Self => this;

        public TransactionVoidOperationQueryBuilder() : this("transactionVoid")
        {
        }

        public TransactionVoidOperationQueryBuilder(string name) : base(new Query<TransactionVoidPayload>(name))
        {
            Arguments = new TransactionVoidArgumentsBuilder(base.InnerQuery);
        }

        public TransactionVoidOperationQueryBuilder(IQuery<TransactionVoidPayload> query) : base(query)
        {
            Arguments = new TransactionVoidArgumentsBuilder(base.InnerQuery);
        }

        public TransactionVoidOperationQueryBuilder Transaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public TransactionVoidOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.TransactionVoidUserErrorQueryBuilder> build)
        {
            var query = new Query<TransactionVoidUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.TransactionVoidUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TransactionVoidUserError>(query);
            return this;
        }
    }
}