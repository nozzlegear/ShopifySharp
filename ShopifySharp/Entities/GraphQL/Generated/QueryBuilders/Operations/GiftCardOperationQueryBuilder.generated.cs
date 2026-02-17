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
    public sealed class GiftCardOperationQueryBuilder : FieldsQueryBuilderBase<GiftCard, GiftCardOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCard>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public GiftCardArgumentsBuilder Arguments { get; }
        protected override GiftCardOperationQueryBuilder Self => this;

        public GiftCardOperationQueryBuilder() : this("giftCard")
        {
        }

        public GiftCardOperationQueryBuilder(string name) : base(new Query<GiftCard>(name))
        {
            Arguments = new GiftCardArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardOperationQueryBuilder(IQuery<GiftCard> query) : base(query)
        {
            Arguments = new GiftCardArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardOperationQueryBuilder Balance(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("balance");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public GiftCardOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public GiftCardOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public GiftCardOperationQueryBuilder DeactivatedAt()
        {
            base.InnerQuery.AddField("deactivatedAt");
            return this;
        }

        public GiftCardOperationQueryBuilder Enabled()
        {
            base.InnerQuery.AddField("enabled");
            return this;
        }

        public GiftCardOperationQueryBuilder ExpiresOn()
        {
            base.InnerQuery.AddField("expiresOn");
            return this;
        }

        public GiftCardOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public GiftCardOperationQueryBuilder InitialValue(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("initialValue");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public GiftCardOperationQueryBuilder LastCharacters()
        {
            base.InnerQuery.AddField("lastCharacters");
            return this;
        }

        public GiftCardOperationQueryBuilder MaskedCode()
        {
            base.InnerQuery.AddField("maskedCode");
            return this;
        }

        public GiftCardOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public GiftCardOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public GiftCardOperationQueryBuilder RecipientAttributes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardRecipientQueryBuilder> build)
        {
            var query = new Query<GiftCardRecipient>("recipientAttributes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardRecipientQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardRecipient>(query);
            return this;
        }

        public GiftCardOperationQueryBuilder TemplateSuffix()
        {
            base.InnerQuery.AddField("templateSuffix");
            return this;
        }

        public GiftCardOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<GiftCardTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardTransactionConnection>(query);
            return this;
        }

        public GiftCardOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}