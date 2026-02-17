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
    public sealed class ExchangeV2QueryBuilder : FieldsQueryBuilderBase<ExchangeV2, ExchangeV2QueryBuilder>
    {
        protected override ExchangeV2QueryBuilder Self => this;

        public ExchangeV2QueryBuilder() : this("exchangeV2")
        {
        }

        public ExchangeV2QueryBuilder(string name) : base(new Query<ExchangeV2>(name))
        {
        }

        public ExchangeV2QueryBuilder(IQuery<ExchangeV2> query) : base(query)
        {
        }

        public ExchangeV2QueryBuilder Additions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2AdditionsQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Additions>("additions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2AdditionsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Additions>(query);
            return this;
        }

        public ExchangeV2QueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public ExchangeV2QueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public ExchangeV2QueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ExchangeV2QueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public ExchangeV2QueryBuilder Mirrored()
        {
            base.InnerQuery.AddField("mirrored");
            return this;
        }

        public ExchangeV2QueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public ExchangeV2QueryBuilder Refunds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refunds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public ExchangeV2QueryBuilder Returns(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2ReturnsQueryBuilder> build)
        {
            var query = new Query<ExchangeV2Returns>("returns");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ExchangeV2ReturnsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ExchangeV2Returns>(query);
            return this;
        }

        public ExchangeV2QueryBuilder StaffMember(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("staffMember");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public ExchangeV2QueryBuilder TotalAmountProcessedSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalAmountProcessedSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ExchangeV2QueryBuilder TotalPriceSet(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder> build)
        {
            var query = new Query<MoneyBag>("totalPriceSet");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyBagQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyBag>(query);
            return this;
        }

        public ExchangeV2QueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder> build)
        {
            var query = new Query<OrderTransaction>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransaction>(query);
            return this;
        }
    }
}