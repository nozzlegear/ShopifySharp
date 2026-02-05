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
    public sealed class TransactionVoidPayloadQueryBuilder : FieldsQueryBuilderBase<TransactionVoidPayload, TransactionVoidPayloadQueryBuilder>
    {
        protected override TransactionVoidPayloadQueryBuilder Self => this;

        public TransactionVoidPayloadQueryBuilder() : this("transactionVoidPayload")
        {
        }

        public TransactionVoidPayloadQueryBuilder(string name) : base(new Query<TransactionVoidPayload>(name))
        {
        }

        public TransactionVoidPayloadQueryBuilder(IQuery<TransactionVoidPayload> query) : base(query)
        {
        }

        public TransactionVoidPayloadQueryBuilder Transaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }

        public TransactionVoidPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TransactionVoidUserErrorQueryBuilder> build)
        {
            var query = new Query<TransactionVoidUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.TransactionVoidUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<TransactionVoidUserError>(query);
            return this;
        }
    }
}