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
    public sealed class GiftCardDebitOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardDebitPayload, GiftCardDebitOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardDebitPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardDebitArgumentsBuilder Arguments { get; }
        protected override GiftCardDebitOperationQueryBuilder Self => this;

        public GiftCardDebitOperationQueryBuilder() : this("giftCardDebit")
        {
        }

        public GiftCardDebitOperationQueryBuilder(string name) : base(new Query<GiftCardDebitPayload>(name))
        {
            Arguments = new GiftCardDebitArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardDebitOperationQueryBuilder(IQuery<GiftCardDebitPayload> query) : base(query)
        {
            Arguments = new GiftCardDebitArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardDebitOperationQueryBuilder GiftCardDebitTransaction(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardDebitTransaction>("giftCardDebitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardDebitTransaction>(query);
            return this;
        }

        public GiftCardDebitOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionUserError>(query);
            return this;
        }
    }
}