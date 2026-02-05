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
    public sealed class GiftCardDebitPayloadQueryBuilder : FieldsQueryBuilderBase<GiftCardDebitPayload, GiftCardDebitPayloadQueryBuilder>
    {
        protected override GiftCardDebitPayloadQueryBuilder Self => this;

        public GiftCardDebitPayloadQueryBuilder() : this("giftCardDebitPayload")
        {
        }

        public GiftCardDebitPayloadQueryBuilder(string name) : base(new Query<GiftCardDebitPayload>(name))
        {
        }

        public GiftCardDebitPayloadQueryBuilder(IQuery<GiftCardDebitPayload> query) : base(query)
        {
        }

        public GiftCardDebitPayloadQueryBuilder GiftCardDebitTransaction(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder> build)
        {
            var query = new Query<GiftCardDebitTransaction>("giftCardDebitTransaction");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardDebitTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardDebitTransaction>(query);
            return this;
        }

        public GiftCardDebitPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardTransactionUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionUserError>(query);
            return this;
        }
    }
}