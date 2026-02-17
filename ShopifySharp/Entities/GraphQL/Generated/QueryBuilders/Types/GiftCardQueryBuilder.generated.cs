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
    public sealed class GiftCardQueryBuilder : FieldsQueryBuilderBase<GiftCard, GiftCardQueryBuilder>
    {
        protected override GiftCardQueryBuilder Self => this;

        public GiftCardQueryBuilder() : this("giftCard")
        {
        }

        public GiftCardQueryBuilder(string name) : base(new Query<GiftCard>(name))
        {
        }

        public GiftCardQueryBuilder(IQuery<GiftCard> query) : base(query)
        {
        }

        public GiftCardQueryBuilder Balance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public GiftCardQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public GiftCardQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public GiftCardQueryBuilder DeactivatedAt()
        {
            base.InnerQuery.AddField("deactivatedAt");
            return this;
        }

        public GiftCardQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public GiftCardQueryBuilder ExpiresOn()
        {
            base.InnerQuery.AddField("expiresOn");
            return this;
        }

        public GiftCardQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public GiftCardQueryBuilder InitialValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("initialValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public GiftCardQueryBuilder LastCharacters()
        {
            base.InnerQuery.AddField("lastCharacters");
            return this;
        }

        public GiftCardQueryBuilder MaskedCode()
        {
            base.InnerQuery.AddField("maskedCode");
            return this;
        }

        public GiftCardQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public GiftCardQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public GiftCardQueryBuilder RecipientAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardRecipientQueryBuilder> build)
        {
            var query = new Query<GiftCardRecipient>("recipientAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardRecipientQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardRecipient>(query);
            return this;
        }

        public GiftCardQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public GiftCardQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionConnection>(query);
            return this;
        }

        public GiftCardQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}