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
    public sealed class GiftCardCreditOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardCreditPayload, GiftCardCreditOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardCreditPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardCreditArgumentsBuilder Arguments { get; }
        protected override GiftCardCreditOperationQueryBuilder Self => this;

        public GiftCardCreditOperationQueryBuilder() : this("giftCardCredit")
        {
        }

        public GiftCardCreditOperationQueryBuilder(string name) : base(new Query<GiftCardCreditPayload>(name))
        {
            Arguments = new GiftCardCreditArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCreditOperationQueryBuilder(IQuery<GiftCardCreditPayload> query) : base(query)
        {
            Arguments = new GiftCardCreditArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCreditOperationQueryBuilder GiftCardCreditTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardCreditTransaction>("giftCardCreditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardCreditTransaction>(query);
            return this;
        }

        public GiftCardCreditOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionUserError>(query);
            return this;
        }
    }
}