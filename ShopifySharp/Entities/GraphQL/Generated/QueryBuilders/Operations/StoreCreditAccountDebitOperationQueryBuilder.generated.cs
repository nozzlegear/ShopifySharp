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
    public sealed class StoreCreditAccountDebitOperationQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountDebitPayload, StoreCreditAccountDebitOperationQueryBuilder>, IGraphOperationQueryBuilder<StoreCreditAccountDebitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StoreCreditAccountDebitArgumentsBuilder Arguments { get; }
        protected override StoreCreditAccountDebitOperationQueryBuilder Self => this;

        public StoreCreditAccountDebitOperationQueryBuilder() : this("storeCreditAccountDebit")
        {
        }

        public StoreCreditAccountDebitOperationQueryBuilder(string name) : base(new Query<StoreCreditAccountDebitPayload>(name))
        {
            Arguments = new StoreCreditAccountDebitArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountDebitOperationQueryBuilder(IQuery<StoreCreditAccountDebitPayload> query) : base(query)
        {
            Arguments = new StoreCreditAccountDebitArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountDebitOperationQueryBuilder StoreCreditAccountTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitTransaction>("storeCreditAccountTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountDebitTransaction>(query);
            return this;
        }

        public StoreCreditAccountDebitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitUserErrorQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountDebitUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountDebitUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountDebitUserError>(query);
            return this;
        }
    }
}