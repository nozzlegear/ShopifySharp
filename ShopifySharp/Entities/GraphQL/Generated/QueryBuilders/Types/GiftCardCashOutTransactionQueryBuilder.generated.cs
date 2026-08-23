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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class GiftCardCashOutTransactionQueryBuilder : FieldsQueryBuilderBase<GiftCardCashOutTransaction, GiftCardCashOutTransactionQueryBuilder>
    {
        protected override GiftCardCashOutTransactionQueryBuilder Self => this;

        public GiftCardCashOutTransactionQueryBuilder() : this("giftCardCashOutTransaction")
        {
        }

        public GiftCardCashOutTransactionQueryBuilder(string name) : base(new Query<GiftCardCashOutTransaction>(name))
        {
        }

        public GiftCardCashOutTransactionQueryBuilder(IQuery<GiftCardCashOutTransaction> query) : base(query)
        {
        }

        public GiftCardCashOutTransactionQueryBuilder Amount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public GiftCardCashOutTransactionQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardCashOutTransactionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public GiftCardCashOutTransactionQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public GiftCardCashOutTransactionQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public GiftCardCashOutTransactionQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public GiftCardCashOutTransactionQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }
    }
}