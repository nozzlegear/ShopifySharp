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
    public sealed class PaymentScheduleConnectionQueryBuilder : FieldsQueryBuilderBase<PaymentScheduleConnection, PaymentScheduleConnectionQueryBuilder>
    {
        protected override PaymentScheduleConnectionQueryBuilder Self => this;

        public PaymentScheduleConnectionQueryBuilder() : this("paymentScheduleConnection")
        {
        }

        public PaymentScheduleConnectionQueryBuilder(string name) : base(new Query<PaymentScheduleConnection>(name))
        {
        }

        public PaymentScheduleConnectionQueryBuilder(IQuery<PaymentScheduleConnection> query) : base(query)
        {
        }

        public PaymentScheduleConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleEdgeQueryBuilder> build)
        {
            var query = new Query<PaymentScheduleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentScheduleEdge>(query);
            return this;
        }

        public PaymentScheduleConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleQueryBuilder> build)
        {
            var query = new Query<PaymentSchedule>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentScheduleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentSchedule>(query);
            return this;
        }

        public PaymentScheduleConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}