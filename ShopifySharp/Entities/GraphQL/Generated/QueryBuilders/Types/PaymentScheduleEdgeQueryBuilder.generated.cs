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
    public sealed class PaymentScheduleEdgeQueryBuilder : FieldsQueryBuilderBase<PaymentScheduleEdge, PaymentScheduleEdgeQueryBuilder>
    {
        protected override PaymentScheduleEdgeQueryBuilder Self => this;

        public PaymentScheduleEdgeQueryBuilder() : this("paymentScheduleEdge")
        {
        }

        public PaymentScheduleEdgeQueryBuilder(string name) : base(new Query<PaymentScheduleEdge>(name))
        {
        }

        public PaymentScheduleEdgeQueryBuilder(IQuery<PaymentScheduleEdge> query) : base(query)
        {
        }

        public PaymentScheduleEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PaymentScheduleEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentScheduleQueryBuilder> build)
        {
            var query = new Query<PaymentSchedule>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PaymentScheduleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentSchedule>(query);
            return this;
        }
    }
}