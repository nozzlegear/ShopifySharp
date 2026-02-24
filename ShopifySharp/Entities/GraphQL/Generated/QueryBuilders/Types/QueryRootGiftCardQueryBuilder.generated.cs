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
    public sealed class QueryRootGiftCardQueryBuilder : FieldsQueryBuilderBase<GiftCard, QueryRootGiftCardQueryBuilder>, IHasArguments<QueryRootGiftCardArgumentsBuilder>
    {
        public QueryRootGiftCardArgumentsBuilder Arguments { get; }
        protected override QueryRootGiftCardQueryBuilder Self => this;

        public QueryRootGiftCardQueryBuilder(string name) : base(new Query<GiftCard>(name))
        {
            Arguments = new QueryRootGiftCardArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootGiftCardQueryBuilder(IQuery<GiftCard> query) : base(query)
        {
            Arguments = new QueryRootGiftCardArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootGiftCardQueryBuilder SetArguments(Action<QueryRootGiftCardArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootGiftCardQueryBuilder Balance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootGiftCardQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootGiftCardQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootGiftCardQueryBuilder DeactivatedAt()
        {
            base.InnerQuery.AddField("deactivatedAt");
            return this;
        }

        public QueryRootGiftCardQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public QueryRootGiftCardQueryBuilder ExpiresOn()
        {
            base.InnerQuery.AddField("expiresOn");
            return this;
        }

        public QueryRootGiftCardQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootGiftCardQueryBuilder InitialValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("initialValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootGiftCardQueryBuilder LastCharacters()
        {
            base.InnerQuery.AddField("lastCharacters");
            return this;
        }

        public QueryRootGiftCardQueryBuilder MaskedCode()
        {
            base.InnerQuery.AddField("maskedCode");
            return this;
        }

        public QueryRootGiftCardQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public QueryRootGiftCardQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootGiftCardQueryBuilder RecipientAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardRecipientQueryBuilder> build)
        {
            var query = new Query<GiftCardRecipient>("recipientAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardRecipientQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardRecipient>(query);
            return this;
        }

        public QueryRootGiftCardQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public QueryRootGiftCardQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionConnection>(query);
            return this;
        }

        public QueryRootGiftCardQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}