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
    public sealed class GiftCardCreditPayloadQueryBuilder : FieldsQueryBuilderBase<GiftCardCreditPayload, GiftCardCreditPayloadQueryBuilder>
    {
        protected override GiftCardCreditPayloadQueryBuilder Self => this;

        public GiftCardCreditPayloadQueryBuilder() : this("giftCardCreditPayload")
        {
        }

        public GiftCardCreditPayloadQueryBuilder(string name) : base(new Query<GiftCardCreditPayload>(name))
        {
        }

        public GiftCardCreditPayloadQueryBuilder(IQuery<GiftCardCreditPayload> query) : base(query)
        {
        }

        public GiftCardCreditPayloadQueryBuilder GiftCardCreditTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardCreditTransaction>("giftCardCreditTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardCreditTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardCreditTransaction>(query);
            return this;
        }

        public GiftCardCreditPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionUserError>(query);
            return this;
        }
    }
}