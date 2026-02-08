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
    public sealed class GiftCardTransactionQueryBuilder : FieldsQueryBuilderBase<IGiftCardTransaction, GiftCardTransactionQueryBuilder>
    {
        protected override GiftCardTransactionQueryBuilder Self => this;

        public GiftCardTransactionQueryBuilder() : this("giftCardTransaction")
        {
        }

        public GiftCardTransactionQueryBuilder(string name) : base(new Query<IGiftCardTransaction>(name))
        {
        }

        public GiftCardTransactionQueryBuilder(IQuery<IGiftCardTransaction> query) : base(query)
        {
        }

        public GiftCardTransactionQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public GiftCardTransactionQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardTransactionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public GiftCardTransactionQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public GiftCardTransactionQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public GiftCardTransactionQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public GiftCardTransactionQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }
    }
}