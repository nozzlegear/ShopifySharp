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
    public sealed class StoreCreditAccountCreditOperationQueryBuilder : FieldsQueryBuilderBase<StoreCreditAccountCreditPayload, StoreCreditAccountCreditOperationQueryBuilder>, IGraphOperationQueryBuilder<StoreCreditAccountCreditPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public StoreCreditAccountCreditArgumentsBuilder Arguments { get; }
        protected override StoreCreditAccountCreditOperationQueryBuilder Self => this;

        public StoreCreditAccountCreditOperationQueryBuilder() : this("storeCreditAccountCredit")
        {
        }

        public StoreCreditAccountCreditOperationQueryBuilder(string name) : base(new Query<StoreCreditAccountCreditPayload>(name))
        {
            Arguments = new StoreCreditAccountCreditArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountCreditOperationQueryBuilder(IQuery<StoreCreditAccountCreditPayload> query) : base(query)
        {
            Arguments = new StoreCreditAccountCreditArgumentsBuilder(base.InnerQuery);
        }

        public StoreCreditAccountCreditOperationQueryBuilder StoreCreditAccountTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditTransaction>("storeCreditAccountTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountCreditTransaction>(query);
            return this;
        }

        public StoreCreditAccountCreditOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditUserErrorQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountCreditUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StoreCreditAccountCreditUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountCreditUserError>(query);
            return this;
        }
    }
}