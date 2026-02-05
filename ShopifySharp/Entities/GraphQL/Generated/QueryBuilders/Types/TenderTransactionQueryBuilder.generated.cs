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
    public sealed class TenderTransactionQueryBuilder : FieldsQueryBuilderBase<TenderTransaction, TenderTransactionQueryBuilder>
    {
        protected override TenderTransactionQueryBuilder Self => this;

        public TenderTransactionQueryBuilder() : this("tenderTransaction")
        {
        }

        public TenderTransactionQueryBuilder(string name) : base(new Query<TenderTransaction>(name))
        {
        }

        public TenderTransactionQueryBuilder(IQuery<TenderTransaction> query) : base(query)
        {
        }

        public TenderTransactionQueryBuilder Amount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("amount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public TenderTransactionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public TenderTransactionQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public TenderTransactionQueryBuilder PaymentMethod()
        {
            base.InnerQuery.AddField("paymentMethod");
            return this;
        }

        public TenderTransactionQueryBuilder ProcessedAt()
        {
            base.InnerQuery.AddField("processedAt");
            return this;
        }

        public TenderTransactionQueryBuilder RemoteReference()
        {
            base.InnerQuery.AddField("remoteReference");
            return this;
        }

        public TenderTransactionQueryBuilder Test()
        {
            base.InnerQuery.AddField("test");
            return this;
        }

        public TenderTransactionQueryBuilder User(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("user");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public TenderTransactionQueryBuilder TransactionDetails(Action<TenderTransactionDetailsUnionCasesBuilder> build)
        {
            var query = new Query<TenderTransactionDetails>("transactionDetails");
            var unionBuilder = new TenderTransactionDetailsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}